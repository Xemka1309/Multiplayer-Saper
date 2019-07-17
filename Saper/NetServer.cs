using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace Saper
{
    class NetServer
    {
        private IPEndPoint iPEndPoint;
        private TcpListener tcpListener;
        public TcpClient tcpClient;
        public NetServer(String ip,int port)
        {
            iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            tcpListener = new TcpListener(iPEndPoint);
        }
        public void Start()
        {
            tcpListener.Start();
            tcpClient = tcpListener.AcceptTcpClientAsync().Result;
            while (tcpClient == null)
            {
                
            }
            if (tcpClient != null)
            {
                MessageBox.Show("Other player connected!");
            }
        }
        public void Send(String content)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            NetworkStream networkStream = this.tcpClient.GetStream();
            networkStream.Write(bytes,0,bytes.Length);
            networkStream.Close();
        }
        public String Get()
        {
            String result;
            byte[] bytes = new byte[255];
            NetworkStream networkStream = this.tcpClient.GetStream();
            if (networkStream.DataAvailable)
            {
                int size = networkStream.Read(bytes, 0, 255);
                result = Encoding.UTF8.GetString(bytes);
                networkStream.Close();
                return result;
            }
            else
            {
                return "";
            }
            

        }
        public void Close()
        {
            Send("SERVER_CLOSE");
            this.tcpListener.Stop();
        }
    }
}
