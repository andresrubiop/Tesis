using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using DDS.ConversionUtils;
using log4net;
using org.omg.dds.core;
using org.omg.dds.core.policy;
using org.omg.dds.core.policy.modifiable;
using org.omg.dds.core.status;
using org.omg.dds.domain;
using org.omg.dds.pub;
using org.omg.dds.sub;
using org.omg.dds.sub.modifiable;
using org.omg.dds.topic;
using System.Timers;

namespace TesisChat
{
    public partial class frmChat : Form
    {
        public User usuario=new User("","");
        protected static int domainId = -1;
        DataWriter<ChatMessage> dw;
        Publisher pub;
        DataReader<ChatMessage> dr;
        DataReaderListener<ChatMessage> ls;
        DomainParticipantFactory factory;
        DomainParticipant dp;
        Topic<ChatMessage> tp ;
        Subscriber sub;
        delegate  void Rec(string message);
        static string data;
        private static frmChat formChat = new frmChat();
       
        public BackgroundWorker backgroundWorker1;
        public BackgroundWorker backgroundWorker2;
        
        internal static frmChat GetInstance()
        {
            return frmChat.formChat;
            
        }
        
     
        

        public frmChat()
        {
            InitializeComponent();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);

            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
          
            
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ChatMessage msg = e.Argument as ChatMessage;
            e.Result = msg;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChatMessage msg = e.Result as ChatMessage;
            if (msg != null && msg.Values != null)
            {
                this.lsvHistory.Items.Add("Received data: " + msg.Values);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            ChatMessage msg = e.Argument as ChatMessage;
            e.Result = msg;
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChatMessage msg = e.Result as ChatMessage;
            if (msg != null && msg.Values != null)
            {
                this.lsvHistory.Items.Add("Received data: " + msg.Values);
            }
        }
     
        
        

        

        private void reliableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            this.ShowMyDialogBox();
            this.InitializeDDS();
                 
             
            
        }
     
      

       
        
      
        
       

        private void InitializeDDS()
        {
            
            string id = usuario.Id;
            int.TryParse(id, out domainId);
            

            // Create the DomainFactory
            factory = DomainParticipantFactory.GetInstance(Bootstrap.CreateInstance());
            // Create the DomainParticipant with reference to the configuration file with the domain ID
            dp = factory.CreateParticipant(domainId);
           // Console.WriteLine("Domain ID = {0} has been created", domainId);
            // Implicitly create TypeSupport and register type:
            tp = dp.CreateTopic<ChatMessage>("Greetings Topic");
            // Create the subscriber
            sub = dp.CreateSubscriber();
            // Create a Listener for the publishing data
            ls = new MyListener(backgroundWorker1,backgroundWorker2);
            // Create the DataReader using the topic, politics of QoS for DataReader and implemented listener
            dr = sub.CreateDataReader<ChatMessage>(tp,
                                                                            sub.GetDefaultDataReaderQos(),
                                                                            ls,
                                                                            null);
          
            
            
            // Create the publisher
            pub = dp.CreatePublisher();
            // Create the DataWriter using the topic specified
            dw = pub.CreateDataWriter(tp);


         

        }

     
             
        public void ShowMyDialogBox()
        {
            frmId formId = new frmId();
            if(formId.ShowDialog(this)==DialogResult.OK)
            {
                this.usuario.UserName = formId.TxtId.Text;
                this.usuario.Id = formId.TxtId.Text;
            }
            else
            {
                this.usuario.UserName = "Cancelled";
            }
            formId.Dispose();
        }

        private void bestEffortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }

        private void reliableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }

        private void reliableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }

        private void conEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
         class MyListener : DataReaderAdapter<ChatMessage>
        {
            public BackgroundWorker backgroundWorker1;
            public BackgroundWorker backgroundWorker2;

            public MyListener(BackgroundWorker backgroundWorker1, BackgroundWorker backgroundWorker2)
            {
                this.backgroundWorker1 = backgroundWorker1;
                this.backgroundWorker2 = backgroundWorker2;
            }
          
            
         

             
            
            
            
           
            /// <summary>
            /// Method is called when a new message arrives from the Publisher
            /// </summary>
            /// <param name="status">get data avaliable</param>
            public override void OnDataAvailable(DataAvailableStatus<ChatMessage> status)
            {
                
                  DataReader<ChatMessage> dr;
             SampleIterator<ChatMessage> It;
            ChatMessage dt;
                // Obtain the source of DataReader 
                dr= status.GetSource();
                // Obtain the stack of messages published
                It = dr.Take();
                
              
                // Iterator of the list of messages, to present it in console
                foreach (Sample<ChatMessage> smp in It)
                {
                    
                    // SampleInfo stuff is built into Sample:
                    // InstanceHandle inst = smp.GetInstanceHandle();
                    // Data accessible from Sample; null if invalid:
                    
                    dt = smp.GetData();

                    if (backgroundWorker1.IsBusy)
                    {
                        BackgroundLoop(dt);                  
                    }
                    else
                    {
                        this.backgroundWorker1.RunWorkerAsync(dt);

                    }
                 
                   

                    
               
                    
                  
                    
                  
                  
                }
            }
             private void BackgroundLoop(ChatMessage dt)
             {
                 if (backgroundWorker2.IsBusy)
                 {
                     if(backgroundWorker1.IsBusy )
                     {
                         BackgroundLoop(dt);
                     }
                     else
                     {
                         this.backgroundWorker1.RunWorkerAsync(dt);

                     }
                 }
                 else
                 {
                     this.backgroundWorker2.RunWorkerAsync(dt);
                 }
             }
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String msg = txtMessage.Text;
            ChatMessage datas = new ChatMessage(msg);
            //Console.WriteLine("Sending data:\"{0}\"", data.Value);
            dw.Write(datas);
            txtMessage.Clear();
            //dp.Close();
            txtMessage.Focus();
           
            
        
        }

       

       
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dp.Close();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            
                
            
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //aqui codigo
                String msg = txtMessage.Text;
                ChatMessage datas = new ChatMessage(msg);
                //Console.WriteLine("Sending data:\"{0}\"", data.Value);
                dw.Write(datas);
                txtMessage.Clear();
                //dp.Close();
                txtMessage.Focus();
            
                //aqui codigo
            }
        }

        

      
       

      
    }
}
