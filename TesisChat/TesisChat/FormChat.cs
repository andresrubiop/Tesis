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
        Thread t;
        string aux;
        
        internal static frmChat GetInstance()
        {
            return frmChat.formChat;
            
        }
        
     
        

        public frmChat()
        {
            InitializeComponent();
        
          
            
            
        }
       
     
        public static void  Receiver(string msg)
        {

           data = msg;

            
            
         
           
        }

        

        

        private void reliableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            this.ShowMyDialogBox();
            this.InitializeDDS();
            t = new Thread(Actualice);
            t.Start();

            
                
           
               
           
          
            
            
        }
        private void Actualice()
        {
            loop();

            Actualice();
            
           
            
            




        }
        private void loop()
        {
            while (true)
            {

                if(aux!=data)
                {
                    break;
                }


            }
            SetText(data);
            aux = data;
        }

       
        
        delegate void setTextCallback(string text);
        private void SetText(string text)
        {
            if (lsvHistory.InvokeRequired)
            {
                setTextCallback d = new setTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lsvHistory.Items.Add(text); 
            }
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
            ls = new MyListener();
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
            DataReader<ChatMessage> dr;
            private SampleIterator<ChatMessage> It;
            ChatMessage dt;
            
         

             
            
            
            
           
            /// <summary>
            /// Method is called when a new message arrives from the Publisher
            /// </summary>
            /// <param name="status">get data avaliable</param>
            public override void OnDataAvailable(DataAvailableStatus<ChatMessage> status)
            {
                
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
                    
                    Rec handler = new Rec(Receiver);
                    handler(dt.Value+"  "+smp.GetHashCode().ToString());
                    
                  
                    
                  
                  
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
           
            
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dp.Close();
        }

        

      
       

      
    }
}
