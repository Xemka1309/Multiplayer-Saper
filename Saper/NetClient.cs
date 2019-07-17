using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Saper
{
    
    class NetClient
    {
        private int id;
        private IPEndPoint serverIP;
        public TcpClient tcpClient;
        //private int port;
        //private IPAddress ip;
        public NetClient()
        {
            this.tcpClient = new TcpClient();
        }
        // todo: server return user id
        public void JoinGame(String ip, int port)
        {
            serverIP = new IPEndPoint(IPAddress.Parse(ip), port);
            tcpClient.Connect(serverIP);
        }
        // check cell
        public void DoTurn(String request)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] bytes = Encoding.UTF8.GetBytes(request);
            networkStream.Write(bytes, 0, bytes.Length);
            networkStream.Close();

        }
        public void EndGame()
        {
            tcpClient.Close();
        }
        public void GetResponse()
        {
            byte[] response;
            byte[] buff=new byte[256];
            int responselength=0;
            NetworkStream networkStream = tcpClient.GetStream();
            if (networkStream.DataAvailable)
            {
                responselength = networkStream.Read(buff, 0, buff.Length);
            }
            networkStream.Close();
            response = new byte[responselength];
        }
        public void ParseResponse(byte[] response)
        {

        }
        public void Send(String content)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            NetworkStream networkStream = this.tcpClient.GetStream();
            networkStream.Write(bytes, 0, bytes.Length);
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
    }
}
