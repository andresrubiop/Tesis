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
        DataWriterListener<ChatMessage> ls2;
        DomainParticipantFactory factory;
        DomainParticipant dp;
        Topic<ChatMessage> tp ;
        Subscriber sub;
        delegate  void Rec(string message);
        //static string data;
        private static frmChat formChat = new frmChat();
        
        public BackgroundWorker backgroundWorker1;
        public BackgroundWorker backgroundWorker2;
        public BackgroundWorker backgroundWorker3;
        public BackgroundWorker backgroundWorker4;
        public BackgroundWorker backgroundWorker5;
        public BackgroundWorker backgroundWorker6;
        
        internal static frmChat GetInstance()
        {
            return frmChat.formChat;
            
        }
        
     
        

        public frmChat()
        {
            InitializeComponent();
            desconexiónToolStripMenuItem.Enabled = false;
            lsvHistory.Enabled = false;
            btnSend.Enabled = false;
            txtMessage.Enabled = false;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);

            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);

            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);

            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);

            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
           
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();

            this.backgroundWorker6.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker6_RunWorkerCompleted);
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
          
            
            
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
                this.lsvHistory.Items.Add(msg.Values);
                this.lsvHistory.TopIndex = lsvHistory.Items.Count - 1;
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
                this.lsvHistory.Items.Add(msg.Values);
            }
        }
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            ChatMessage msg = e.Argument as ChatMessage;
            e.Result = msg;
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChatMessage msg = e.Result as ChatMessage;
            if (msg != null && msg.Values != null)
            {
                this.lsvHistory.Items.Add(msg.Values);
            }
        }
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int cont = (int)e.Argument;
            //ChatMessage msg = e.Argument as ChatMessage;
            e.Result = cont;
        }
        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int cont = (int)e.Result;
            if (cont != null )
            {
                //this.lblCache.Text = cont.ToString();
                //this.lsvHistory.Items.Add("Received data: " + msg.Values);
            }
        }
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            int cont = (int)e.Argument;
            //ChatMessage msg = e.Argument as ChatMessage;
            e.Result = cont;
        }
        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int cont = (int)e.Result;
            if (cont != null)
            {
                //this.lblCache.Text = cont.ToString();
                //this.lsvHistory.Items.Add("Received data: " + msg.Values);
            }
        }
        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            int cont = (int)e.Argument;
            //ChatMessage msg = e.Argument as ChatMessage;
            e.Result = cont;
        }
        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int cont = (int)e.Result;
            if (cont != null)
            {
                //this.lblCache.Text = cont.ToString();
                //this.lsvHistory.Items.Add("Received data: " + msg.Values);
            }
        }

     
        
        

        

        private void reliableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            this.ShowMyDialogBox();
            this.InitializeDDS();
                 
             
            
        }
     
      

       
        
      
        
       

        private void InitializeDDS()
        {
            
            //string id = usuario.Id;
            string id = "0";
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
            ls = new MyListener(backgroundWorker1,backgroundWorker2,backgroundWorker3,backgroundWorker4 ,backgroundWorker5,
                backgroundWorker6);
            ls2 = new MyListener2();
            // Create the DataReader using the topic, politics of QoS for DataReader and implemented listener
            dr = sub.CreateDataReader<ChatMessage>(tp,
                                                                            sub.GetDefaultDataReaderQos(),
                                                                            ls,
                                                                            null);
            
            
                       
            // Create the publisher
            pub = dp.CreatePublisher();
            // Create the DataWriter using the topic specified
            //dw = pub.CreateDataWriter(tp);

            dw = pub.CreateDataWriter<ChatMessage>(tp,
                                                                            pub.GetDefaultDataWriterQos(),
                                                                            ls2,
                                                                            null);

            

           
            
         

        }

     
             
        public void ShowMyDialogBox()
        {
            frmId formId = new frmId();
            if(formId.ShowDialog(this)==DialogResult.OK)
            {
                this.usuario.UserName = formId.TxtId.Text;
                this.usuario.Id = formId.TxtId.Text;
                
            }
            if ((int)Keys.Enter==13)
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
            public BackgroundWorker backgroundWorker3;
            public BackgroundWorker backgroundWorker4;
            public BackgroundWorker backgroundWorker5;
            public BackgroundWorker backgroundWorker6;
            int cache = 0;
            public MyListener(BackgroundWorker backgroundWorker1,
                BackgroundWorker backgroundWorker2, BackgroundWorker backgroundWorker3, BackgroundWorker backgroundWorker4, BackgroundWorker backgroundWorker5, BackgroundWorker backgroundWorker6)
            {
                this.backgroundWorker1 = backgroundWorker1;
                this.backgroundWorker2 = backgroundWorker2;
                this.backgroundWorker3 = backgroundWorker3;
                this.backgroundWorker4 = backgroundWorker4;
                this.backgroundWorker5 = backgroundWorker5;
                this.backgroundWorker6 = backgroundWorker6;
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
                    cache = cache + 1;
                    dt = smp.GetData();
                    
                   
                    if (backgroundWorker1.IsBusy || backgroundWorker4.IsBusy)
                    {
                        BackgroundLoop(dt,cache);                  
                    }
                    else
                    {
                        cache = cache - 1;
                        this.backgroundWorker1.RunWorkerAsync(dt);
                        this.backgroundWorker4.RunWorkerAsync(cache);
                        
                    }
                 
                   

                    
               
                    
                  
                    
                  
                  
                }
            }
             private void BackgroundLoop(ChatMessage dt, int cont)
             {
                 if (backgroundWorker2.IsBusy || backgroundWorker5.IsBusy)
                 {
                     if(backgroundWorker3.IsBusy || backgroundWorker6.IsBusy )
                     {
                         if(backgroundWorker1.IsBusy || backgroundWorker4.IsBusy)
                         {
                             BackgroundLoop(dt, cont);
                         }
                         else
                         {
                             cache = cache - 1;
                             this.backgroundWorker1.RunWorkerAsync(dt);
                             this.backgroundWorker4.RunWorkerAsync(cont);
                             
                         }

                         
                     }
                     else
                     {
                         cache = cache - 1;
                         this.backgroundWorker3.RunWorkerAsync(dt);
                        this.backgroundWorker6.RunWorkerAsync(cont);
                        
                     }
                 }
                 else
                 {
                     cache = cache - 1;
                     this.backgroundWorker2.RunWorkerAsync(dt);
                     this.backgroundWorker5.RunWorkerAsync(cont);
                     
                 }
             }
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String msg = txtMessage.Text;
            ChatMessage datas = new ChatMessage(usuario.Id+": "+ msg);
            //Console.WriteLine("Sending data:\"{0}\"", data.Value);
           
            dw.Write(datas);
            
            txtMessage.Clear();
            //dp.Close();
            txtMessage.Focus();
           
            
        
        }

       

       
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String msg = usuario.Id + " se ha desconectado";
                ChatMessage datas = new ChatMessage(msg);

                dw.Write(datas);
                dp.Close();
                formChat.Close();
            }
            catch
            {
                try
                {
                    String msg = usuario.Id + " se ha desconectado";
                    ChatMessage datas = new ChatMessage(msg);

                    dw.Write(datas);
                    formChat.Close();
                }
                catch
                {
                    formChat.Close();
                }




            }
            
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            
                
            
        }
        private class MyListener2 : DataWriterAdapter<ChatMessage>
        {
            
            /// Method is called when a new message arrives from the Publisher
            /// </summary>
           
            /// <param name="status">get data avaliable</param>
           
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //aqui codigo
                String msg = txtMessage.Text;
                ChatMessage datas = new ChatMessage(usuario.Id + ": " + msg);
                //Console.WriteLine("Sending data:\"{0}\"", data.Value);
                dw.Write(datas);
                txtMessage.Clear();
                //dp.Close();
                txtMessage.Focus();
            
                //aqui codigo
            }
        }

        private void conexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dp.Close();
                this.ShowMyDialogBox();
                if(dp==null)
                {
                    this.InitializeDDS();
                }
               
                String msg = usuario.Id + " se ha conectado";
                ChatMessage datas = new ChatMessage(msg);

                dw.Write(datas);

                desconexiónToolStripMenuItem.Enabled = true;
                conexiónToolStripMenuItem.Enabled = false;
                lsvHistory.Enabled = true;
                btnSend.Enabled = true;
                txtMessage.Enabled = true;
                txtMessage.Focus();
            }
            catch
            {
                this.ShowMyDialogBox();
                this.InitializeDDS();
                String msg = usuario.Id + " se ha conectado";
                ChatMessage datas = new ChatMessage(msg);

                dw.Write(datas);

                desconexiónToolStripMenuItem.Enabled = true;
                conexiónToolStripMenuItem.Enabled = false;
                lsvHistory.Enabled = true;
                btnSend.Enabled = true;
                txtMessage.Enabled = true;
                txtMessage.Focus();
            }
            

         
                 
        }

        

        private void btnSend3_Click(object sender, EventArgs e)
        {
            String msga = "a";
            ChatMessage datasa = new ChatMessage(msga);

            String msgb = "b";
            ChatMessage datasb = new ChatMessage(msgb);

            String msgc = "c";
            ChatMessage datasc = new ChatMessage(msgc);

            String msgd = "d";
            ChatMessage datasd = new ChatMessage(msgd);

            String msge = "e";
            ChatMessage datase = new ChatMessage(msge);
            //Console.WriteLine("Sending data:\"{0}\"", data.Value);
            dw.Write(datasa);
            dw.Write(datasb);
            dw.Write(datasc);
            
            txtMessage.Clear();
            //dp.Close();
            txtMessage.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

          

           
            

        }

        private void desconexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String msg = usuario.Id + " se ha desconectado";
                ChatMessage datas = new ChatMessage(msg);

                dw.Write(datas);
                
                

                desconexiónToolStripMenuItem.Enabled = false;
                conexiónToolStripMenuItem.Enabled = true ;
                lsvHistory.Enabled = false ;
                btnSend.Enabled = false ;
                txtMessage.Enabled = false;
                //dp.Close();
                
                
                
                
                
            }
            catch
            {
                String msg = usuario.Id + " se ha desconectado";
                ChatMessage datas = new ChatMessage(msg);

                dw.Write(datas);
                
                

                desconexiónToolStripMenuItem.Enabled = false;
                conexiónToolStripMenuItem.Enabled = true;
                lsvHistory.Enabled = false;
                btnSend.Enabled = false;
                txtMessage.Enabled = false;
                //dp.Close();
                
            }
        }








       
    }
}
