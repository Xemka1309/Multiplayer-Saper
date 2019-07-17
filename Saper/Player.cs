using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Saper
{
    class Player
    {
        enum PlayerStates
        {
            Playing,
            Win,
            Lose
        }
        public NetClient client;
        public GameField gamefield;
        private String name;
        private Color color;
        private int healthpoints;
        private PlayerStates playerstate;
        public Player(GameField gf,String name, Color color)
        {
            this.client = new NetClient();
            this.gamefield = gf;
            this.color = color;
            this.name = name;
            this.healthpoints = 5;
            playerstate = PlayerStates.Playing;
        }
        public GameField GetGameField()
        {
            return this.gamefield;
        }
        public void SetState()
        {

        }
    }
}
