using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        bool kraj = false;
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            listener.Bind(endPoint);
        }

        public void Start()
        {
            //kraj = false;
            try
            {
                listener.Listen(1000);
                while (kraj == false)
                {
                    Socket socket = listener.Accept();
                    ClientHandler handler = new ClientHandler(socket, this, clients);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                //kraj = true;
                MessageBox.Show("Rad servera je zaustavljen");
                Debug.WriteLine(ex);
            }
        }

        public void Stop()
        {
            listener.Close();
        }
    }
}
