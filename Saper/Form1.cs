using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;

namespace Saper
{
    public partial class MainForm : Form
    {
        public String login = "";
        BinaryReader br;
        BinaryWriter bw;
        NetworkStream networkStreamChat;
        bool ischatconnected = false;
        String message;
        String chatip = "127.0.0.1";
        int chatport = 8050;
        TcpClient tcpChatClient;
        TcpListener tcpChatListener;
        String ip = "127.0.0.1";
        int port = 8888;
        bool gameexists;
        Player player;
        Player enemy;
        GameSession gameSession;
        private NetClient client;
        private static int bordsize = 10;
        private GameField gameFieldplayer;
        private GameField gameFieldenemy;
        public MainForm()
        {
            InitializeComponent();
            listViewchat.View = View.List;
        }
        public void thread_proc()
        {
            if (!ischatconnected)
                return;
            if (this.tcpChatClient == null)
                return;
            if (networkStreamChat == null)
                return;
            this.br = new BinaryReader(networkStreamChat);
            while (networkStreamChat.DataAvailable)
            {
                listViewchat.Items.Add(this.br.ReadString());
            }
            
        }
        public void StartChat()
        {
            tcpChatListener = new TcpListener(IPAddress.Parse(chatip), chatport);
            tcpChatListener.Start();
            tcpChatClient = tcpChatListener.AcceptTcpClient();
            networkStreamChat = tcpChatClient.GetStream();
            ischatconnected = true;
        }
        public void JoinChat()
        {
            tcpChatClient = new TcpClient();
            tcpChatClient.Connect(IPAddress.Parse(chatip), chatport);
            networkStreamChat = tcpChatClient.GetStream();
            ischatconnected = true;
        }
        public void Clear()
        {
            labellives.Hide();
            labelusercellsleft.Hide();
            labellives.Text ="Lives:" + 5.ToString();
            labelusercellsleft.Text = "unknown";
            gameFieldplayer = new GameField(bordsize,flowLayoutPanelborduser,textBoxusercellsleft,false);
            gameFieldenemy = new GameField(bordsize,flowLayoutPanelenemy, textBoxenemycells, true);
            textBoxchat.Text = "";
            labelgamenotcreate.Show();
            listViewchat.Items.Clear();
           

        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelusercellsleft.Text = "Cells left";
            labelgamenotcreate.Hide();
            labellives.Show();
            labelusercellsleft.Show();
            flowLayoutPanelenemy.Controls.Clear();
            flowLayoutPanelborduser.Controls.Clear();
            gameFieldplayer = new GameField(bordsize, flowLayoutPanelborduser,textBoxusercellsleft,false);
            gameFieldenemy = new GameField(bordsize, flowLayoutPanelenemy,textBoxenemycells,true);
            player = new Player(gameFieldplayer,"Player",Color.Red);
            enemy = new Player(gameFieldenemy, "Enemy", Color.Blue);
            gameSession = new GameSession(player, enemy);
     
           
            gameSession.CreateGame(ip,port);
            gameFieldplayer.SetGameSession(gameSession);
            labellives.Text = "Lives: " + gameSession.lives.ToString();
            gameFieldplayer.labellives = labellives;
            MessageBox.Show("Game created");
            gameexists = true;
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            gameFieldplayer.showall();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void подключитсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelgamenotcreate.Hide();
            labellives.Show();
            labelusercellsleft.Show();
            flowLayoutPanelenemy.Controls.Clear();
            flowLayoutPanelborduser.Controls.Clear();
            gameFieldplayer = new GameField(bordsize, flowLayoutPanelborduser, textBoxusercellsleft, false);
            gameFieldenemy = new GameField(bordsize, flowLayoutPanelenemy, textBoxenemycells, true);
            player = new Player(gameFieldplayer, "Player", Color.Red);
            enemy = new Player(gameFieldenemy, "Enemy", Color.Blue);
            gameSession = new GameSession(player, enemy);
            gameSession.JoinGame(ip, port);
            gameFieldplayer.SetGameSession(gameSession);
            gameFieldplayer.labellives = labellives;
            MessageBox.Show("Now you can play");
            labellives.Text = "Lives: " + gameSession.lives.ToString();
            gameexists = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            NetworkStream networkStream = gameSession.networkStream;
            BinaryReader reader = new BinaryReader(networkStream);
            if (networkStream.DataAvailable)
            {
                String result=(reader.ReadString());
                int i=reader.ReadInt32();
                int j=reader.ReadInt32();
                gameFieldenemy.SetCellPic(i, j, "res/" + result + ".png");
                if (result.Contains("opened"))
                {
                    textBoxenemycells.Text = (Convert.ToInt32(textBoxenemycells.Text) + 1).ToString();
                }
            }
            
            
                
        }

        private void flowLayoutPanelborduser_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanelborduser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (gameSession == null)
                return;
            if (gameSession.isGameOver)
                return;
            if (!gameexists)
                return;
            if (!gameFieldplayer.gamemove)
                return;
            if (gameSession.networkStream == null)
            {
                MessageBox.Show("Connection closed");
                return;
            }
            NetworkStream networkStream;
            try
            {
                networkStream = gameSession.networkStream;
                BinaryReader reader = new BinaryReader(networkStream);
                if (networkStream.DataAvailable)
                {
                    String result = (reader.ReadString());
                    if (result.Contains("CHAT:"))
                    {
                        int index = reader.ReadInt32();
                        listViewchat.Items.Add(result.Substring(index));
                    }
                    else
                    {
                        int i = reader.ReadInt32();
                        int j = reader.ReadInt32();
                        try
                        {
                            gameFieldenemy.SetCellPic(i, j, "res/" + result + ".png");
                        }
                        catch
                        {

                        }
                        if (result.Contains("opened"))
                        {
                            textBoxenemycells.Text = (Convert.ToInt32(textBoxenemycells.Text) + 1).ToString();
                        }
                        if (result == "WIN")
                        {
                            MessageBox.Show("Your oponent win!");
                            gameSession.EndGame();
                        }

                        if (result == "LOSE")
                        {
                            MessageBox.Show("Your oponent lose, you win, gratz!");
                            gameSession.EndGame();
                        }
                        if (result == "DEAD")
                        {
                            MessageBox.Show("You oponent left");
                        }
                    }
                }
            }
            catch
            {

            }
            
        }

        private void textBoxchat_TextChanged(object sender, EventArgs e)
        {
            this.message = textBoxchat.Text;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (gameSession == null)
                return;
            if (gameFieldplayer.networkStream == null)
            BinaryWriter writer = new BinaryWriter(gameFieldplayer.networkStream);
            writer.Write("CHAT:"+login+":"+message);
            writer.Write(5);
            listViewchat.Items.Add("You:" + message);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBoxlogin_TextChanged(object sender, EventArgs e)
        {
            this.login = textBoxlogin.Text;
        }

        private void цветОкнаПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            this.BackColor = color;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                BinaryWriter writer = new BinaryWriter(gameFieldplayer.gameSession.networkStream);
                writer.Write("LOSE");
            }
            catch
            {

            }
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                BinaryWriter writer = new BinaryWriter(gameFieldplayer.networkStream);
                writer.Write("DEAD");
            }
            catch
            {

            }
        }

        private void изменитьIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeIP formChangeIP = new FormChangeIP();
            formChangeIP.ShowDialog();
            this.ip = formChangeIP.iPAddress;
            this.port = formChangeIP.port;
        }
    }
}
