using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Saper
{
    class GameField
    {
        public bool gamemove;
        public NetworkStream networkStream;
        public GameSession gameSession;
        private bool[,] bombmask;
        private int bombsnum=20;
        private int bordsize;
        private int cellsleftcount;
        private TextBox cellsleft;
        public Label labellives;
        private FlowLayoutPanel bord; 
        public CellButton[,] CellButtons;

        public GameField(int fieldsize, FlowLayoutPanel bordpanel, TextBox tb,bool isenemy)
        {
            gamemove = true;
            bordsize = fieldsize;
            cellsleft = tb;
            cellsleftcount = fieldsize * fieldsize - bombsnum;
            cellsleft.Text = cellsleftcount.ToString();
            bord = bordpanel;
            bord.FlowDirection = FlowDirection.RightToLeft;
            Padding buff = Padding.Empty;
            bord.Margin = buff;
            bord.Padding=buff;
            CellButtons = new CellButton[fieldsize, fieldsize];
            bool[,] bompmask = GenerateBombs(fieldsize,bombsnum);
            bombmask = bompmask;
            for (int i = 0; i < fieldsize; i++)
            {
                for (int j = 0; j < fieldsize; j++)
                {
                    CellButtons[i, j] = new CellButton(bompmask[i,j],isenemy,this,i,j);
                    CellButtons[i, j].Margin = buff;
                    CellButtons[i, j].Padding = buff;
                    bord.Controls.Add(CellButtons[i, j]);
                }
            }
            CalculateAroundBombs(CellButtons);
        }
        public void DecLives()
        {
            var buff = labellives.Text.Substring(7);
            labellives.Text = "Lives: "+(Convert.ToInt32(buff) - 1).ToString();
        }
        public void SetGameSession(GameSession game)
        {
            this.gameSession = game;
            this.networkStream = this.gameSession.networkStream;
        }
        public void CellOpened()
        {
            cellsleftcount--;
            cellsleft.Text = cellsleftcount.ToString();
            gamemove=CheckGameState();
        }
        //return true if game not over
        public bool CheckGameState()
        {
            bool result = true;
            if (cellsleftcount <= 0)
            {
                result = false;
                MessageBox.Show("You win");
                try
                {
                    this.ClickResult(new CellButton(false, false, this, 1, 1), "WIN");
                }
                catch
                {

                }
                if (gameSession!=null)
                    gameSession.EndGame();
            }
                
            return result;
        }
        public void SetCellPic(int i,int j,String pass)
        {
            CellButtons[i, j].BackgroundImage = Image.FromFile(pass);
        }
        public bool[,] GenerateBombs(int bordsize,int bombnum)
        {
            bool[,] result = new bool[bordsize, bordsize];
            int bombleft = bombnum;
            for (int i = 0; i < bordsize; i++)
            {
                for (int j = 0; j < bordsize; j++)
                {
                    result[i, j] = false;

                }
            }
            Random random = new Random(DateTime.UtcNow.Second);
            while (bombleft > 0)
            {
                for (int i = 0; i < bordsize; i++)
                {
                    for (int j = 0; j < bordsize; j++)
                    {
                        
                        int randomnum = random.Next(1, 100);
                        if (randomnum %9 == 0 && result[i,j] != true )
                        {
                            result[i, j] = true;
                            bombleft--;
                            if (bombleft == 0)
                            {
                                return result;
                            }
                        }
                    }
                }
            }
            return result;
        }
        // only debug function
        public void showall()
        {
            foreach (CellButton cell in CellButtons)
            {
                cell.Mouse_Up(this,new MouseEventArgs(MouseButtons.Left,1,1,1,1));
            }
        }
        public void CalculateAroundBombs(CellButton[,] originalcells)
        {
            CellButton[,] cells = new CellButton[bordsize + 2, bordsize + 2];
            int buffsize = bordsize + 2;
            for (int i = 0; i < buffsize; i++)
            {
                for (int j = 0; j < buffsize; j++)
                {
                    cells[i, j] = new CellButton(false,false,this,i,j);
                }
            }
            for (int i = 1; i < buffsize-1; i++)
            {
                for (int j = 1; j < buffsize-1; j++)
                {
                    cells[i, j] = originalcells[i-1,j-1];
                }
            }

            for(int i = 1; i < buffsize-1; i++)
            {
                for (int j = 1; j < buffsize-1; j++)
                {
                    int result = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            if (cells[k, n].IsBombed())
                                result++;
                        }
                    }
                    cells[i, j].SetBombsAround(result);
                }
            }
        }
        public void ClickResult(CellButton cell,String result)
        {
            if (gameSession == null)
                return;
            if (networkStream == null)
                return;
            if (result == "bombedcell")
                DecLives();
            byte[] bytes = Encoding.UTF8.GetBytes(result+"I:"+cell.i.ToString()+"J:"+cell.j.ToString());
            try
            {
                BinaryWriter writer = new BinaryWriter(networkStream);
                writer.Write(result);
                writer.Write(cell.i);
                writer.Write(cell.j);
            }
            catch
            {

            }
        }
        public void Clear()
        {
            this.bord.Controls.Clear();
            
        }
    }
}
