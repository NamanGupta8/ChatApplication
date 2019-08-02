using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace N_Client
{
    public partial class Form1 : Form
    {

      //  static IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
        TcpListener server;
        Socket s;
        UdpClient listener;
        TcpClient client1;

        string serverIp = "localhost";
       
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_onClick(object sender, EventArgs e)
        {
           //client
            try 
            {
                Action<string> ModifyText = setText;

                
                    int byteCount = Encoding.ASCII.GetByteCount(Info1.Text);
                    Invoke(ModifyText,tcpServer1.Text+ ": " + Info1.Text);
                    byte[] sendData = new byte[byteCount];
                    sendData = Encoding.ASCII.GetBytes(tcpServer1.Text + ": " + Info1.Text);
                    NetworkStream stream = client1.GetStream();
                    //stream.Write(sendData, 0, sendData.Length);
                    //stream.Flush();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(tcpServer1.Text + ": " + Info1.Text);
                    writer.Flush();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void setText(string teste)
        {
            Info.Text += Environment.NewLine + teste;
        }


        private void BeginServer()
        {
            Action<string> ModifyText = setText;
            
            try
            {
                server = new TcpListener(IPAddress.Parse(textBox1.Text), Convert.ToInt32(tcpServer1.Text));
                server.Start();
                Invoke(ModifyText, "Tcp Server Started");
                Invoke(ModifyText, "Waiting for connections");
            }

            catch (Exception ex)
            {
                Invoke(ModifyText, ex.ToString());

            }

            while (true) { 
                    // Accepting Client
                    TcpClient listen = default(TcpClient);
                    listen = server.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(ReadMessage, listen);
                                           
                  
                
            }
            


        }

        private void ReadMessage(object state)
        {
            var listen = (TcpClient)state;
            Action<string> ModifyText = setText;
            while (true)
            {
                byte[] receiverBuffer = new byte[100];
                NetworkStream stream = listen.GetStream();

                stream.Read(receiverBuffer, 0, receiverBuffer.Length);
                StringBuilder msg = new StringBuilder();

                foreach (byte b in receiverBuffer)
                {
                    if (b.Equals(00))
                        break;
                    else
                    {
                        msg.Append(Convert.ToChar(b).ToString());
                    }
                }

                Invoke(ModifyText, msg.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Tcp_Click(object sender, EventArgs e)
        {
            Thread Server = new Thread(BeginServer);
            Server.Start();
        }

        private void Udp_Click(object sender, EventArgs e)
        {
            Thread abc = new Thread(() =>
            {
                Action<string> ModifyText = setText;
                Invoke(ModifyText, "Waiting for broadcast");
                listener = new UdpClient(Convert.ToInt32(udpServer1.Text));
                IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(udpServer1.Text));
                try
                {
                    while (true)
                    {
                                               

                        byte[] receivedBytes = listener.Receive(ref groupEP);

                        if (receivedBytes.Length > 0)
                        {
                            string message = Encoding.ASCII.GetString(receivedBytes, 0, receivedBytes.Length);
                            Invoke(ModifyText, message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
            abc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<string> ModifyText = setText;
            

            IPAddress broadcast = IPAddress.Parse("192.168.1.255");
            byte[] sendbuf = Encoding.ASCII.GetBytes(Info1.Text);
            IPEndPoint ep = new IPEndPoint(broadcast, Convert.ToInt32(udpClient1.Text));
            s.SendTo(sendbuf, ep);
                   
          
        }

        private void Disconnect_Udp(object sender, EventArgs e)
        {
            Action<string> ModifyText = setText;
            listener.Close();
            Invoke(ModifyText, "Udp Closed\n");
        }

        private void Disconnect_Tcp(object sender, EventArgs e)
        {
            Action<string> ModifyText = setText;
            client1.Close();
            Invoke(ModifyText, "Tcp Closed\n");
        }

        private void ConnectUdpClient(object sender, EventArgs e)
        {
            Action<string> ModifyText = setText;
            s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Invoke(ModifyText, "Connected");        
        }

        private void ConnectTcpClient(object sender, EventArgs e)
        {
            Action<string> ModifyText = setText;
            client1 = new TcpClient(textBox1.Text, Convert.ToInt32(tcpClient1.Text));
            
            Invoke(ModifyText, "Client Connected");
        }
    }
}
