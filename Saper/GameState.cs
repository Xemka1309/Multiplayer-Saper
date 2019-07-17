using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    class GameState
    {
        private int usercellsleft;
        private int enemycellsleft;
        private String winner;
        //private String looser;
        public bool IsGameOver()
        {
            bool result=false;
            if (usercellsleft == 0)
            {
                result = true;
                winner = "user";
            }
            if (enemycellsleft == 0)
            {
                result = true;
                winner = "enemy";
            }
            return result;
        }
        
    }
}
