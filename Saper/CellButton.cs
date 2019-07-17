using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    class CellButton:Button
    {
        private GameField gameField;
        static int size = 32;
        public int i, j;
        private int bombsaround;
        private bool flaged;
        private bool bombed;
        private bool opened;
        private bool isenemy;
        public CellButton(bool isbombed,bool isenemy,GameField gf,int i,int j):base()
        {
            this.i = i;
            this.j = j;
            this.flaged = false;
            gameField = gf;
            Height = size;
            Width = size;
            BackgroundImage = Image.FromFile("res/cell.png");
            this.bombed = isbombed;
            this.isenemy = isenemy;
            this.MouseUp += new MouseEventHandler(Mouse_Up);
            
        }
        public bool IsBombed()
        {
            return this.bombed;
        }
        public void SetBombsAround(int value)
        {
            this.bombsaround = value;
        }
        public void Mouse_Up(object sender, MouseEventArgs e)
        {
            if (gameField == null)
                return;
            if (gameField.gameSession == null)
                return;
            String result="";
            if (this.isenemy)
                return;
            if (this.opened == true)
                return;
            if (e.Button == MouseButtons.Left)
            {
                if (!bombed)
                {
                    this.opened = true;
                    gameField.CellOpened();
                    if (!this.gameField.gamemove)
                        return;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int n = j - 1; n <= j + 1; n++)
                        {
                            try
                            {
                                if (!gameField.CellButtons[k, n].IsBombed())
                                {
                                    Mouse_Up(gameField.CellButtons[k, n], new MouseEventArgs(MouseButtons.Left, 1, 1, 1, 1));
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    switch (this.bombsaround)
                    {
                        case 0:
                            this.BackgroundImage = Image.FromFile("res/openedcell.png");
                            break;
                        case 1:
                            this.BackgroundImage = Image.FromFile("res/openedcellB1.png");
                            break;
                        case 2:
                            this.BackgroundImage = Image.FromFile("res/openedcellB2.png");
                            break;
                        case 3:
                            this.BackgroundImage = Image.FromFile("res/openedcellB3.png");
                            break;
                        case 4:
                            this.BackgroundImage = Image.FromFile("res/openedcellB4.png");
                            break;
                        case 5:
                            this.BackgroundImage = Image.FromFile("res/openedcellB5.png");
                            break;
                        case 6:
                            this.BackgroundImage = Image.FromFile("res/openedcellB6.png");
                            break;
                        case 7:
                            this.BackgroundImage = Image.FromFile("res/openedcellB7.png");
                            break;
                        case 8:
                            this.BackgroundImage = Image.FromFile("res/openedcellB8.png");
                            break;              
                    }
                    result = "openedcellB" + this.bombsaround.ToString(); 
                    if (this.bombsaround == 0)
                    {
                        result = "openedcell";
                    }
                }
                else
                {
                    this.BackgroundImage = Image.FromFile("res/bombedcell.png");
                    MessageBox.Show("You lost live");
                    this.gameField.gameSession.lives--;
                    this.gameField.DecLives();
                    result = "bombedcell";
                    if (this.gameField.gameSession.lives <= 0)
                    {
                        MessageBox.Show("You lose");
                        gameField.ClickResult(this, result);
                        gameField.ClickResult(this, "LOSE");
                        this.gameField.gameSession.EndGame();

                    }
                }
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (!this.flaged)
                {
                    this.flaged = true;
                    this.BackgroundImage = Image.FromFile("res/flagedcell.png");
                }
                else
                {
                    this.flaged = false;
                    this.BackgroundImage = Image.FromFile("res/cell.png");
                }
                result = "flagedcell";
            }

            gameField.ClickResult(this,result);
        }
        
        
    }
}
