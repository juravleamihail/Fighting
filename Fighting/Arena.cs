using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        public const int SANSA = 50;
        private int runda = 1;
        private static Random r = new Random();
        private Player player1;
        private Player player2;

        public Arena(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public bool PlayersAreAlive()
        {
            return player1.IsAlive() && player2.IsAlive();
        }
      
        public void Fight()
        {
            int randomCineAtaca = r.Next(0, 100);

            if (randomCineAtaca < SANSA)
            {
                player1.Punch(player2);
            }
            else
            {
                player2.Punch(player1);
            }
            runda++;
        }

        public Player GetWinner()
        {
            if (PlayersAreAlive())
                return null;

            return player1.IsAlive() && !player2.IsAlive() ? player1 : player2; //s
        }

        public int GetRunda()
        {
            return runda;
        }
    }
}

