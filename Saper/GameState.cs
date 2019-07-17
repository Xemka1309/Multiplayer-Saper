using System;

namespace Saper
{
    class GameState
    {
        private int usercellsleft;
        private int enemycellsleft;
        private String winner;
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
