using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace Saper
{
    class GameSession
    {
        public int lives;
        public NetworkStream networkStream;
        private bool isserver;
        public IPEndPoint iPEndPoint;
        public String ip;
        public int port;
        public TcpClient tcpClient;
        public TcpListener tcpListener;
        public bool isGameOver;
        private Player player;
        private Player enemy;
        public GameSession(Player player,Player enemy)
        {
            lives = 5;
            // hz
            this.isserver = false;
            this.player = player;
            this.enemy = enemy;
            this.isGameOver = false;
            //this.player.gamefield.SetGameSession(this);
        }
        public void CreateGame(String ip,int port)
        {
            this.ip = ip;
            this.port = port;
            iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            tcpListener = new TcpListener(iPEndPoint);
            tcpListener.Start();
            tcpClient = tcpListener.AcceptTcpClient();
            networkStream = tcpClient.GetStream();
        }
        public void JoinGame(String ip, int port)
        {
            this.ip = ip;
            this.port = port;
            iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            tcpClient = new TcpClient();
            tcpClient.Connect(iPEndPoint);
            networkStream = tcpClient.GetStream();
        }
        public void ReConnect()
        {
            //tcpClient.Connect(iPEndPoint);
        }
        public void EndGame()
        {
            isGameOver = true;
            MessageBox.Show("Game over");
            try
            {
                player.gamefield.Clear();
                enemy.gamefield.Clear();
                this.tcpListener.Stop();
                this.tcpClient.Close();
            }
            catch
            {

            }
        }
    }
}
