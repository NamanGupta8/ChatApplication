using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
namespace N_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating socket listener
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0]; 
            TcpListener server = new TcpListener(ip, 8888);
            TcpClient client = default(TcpClient);
            
            try
            {
                server.Start();
                
                Console.WriteLine("Server Started \n");
                Console.WriteLine("Waiting for client\n");

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());

            }
            while (true)
            {
                // Accepting Client
                client = server.AcceptTcpClient();

                byte[] receiverBuffer = new byte[100];
                NetworkStream stream = client.GetStream();

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

                Console.WriteLine(msg.ToString());

            }
            
        }
    }
}
