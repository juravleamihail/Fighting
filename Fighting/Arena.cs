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
        
        private void CalculateHpDamage(Player player, Player otherPlayer)
        {
            if (!player.IsAlive())
                return;

            player.Punch(otherPlayer.forta);
        }
      
        public void Fight()
        {
            int randomCineAtaca = r.Next(0, 100);

            if (randomCineAtaca < SANSA)
            {
                CalculateHpDamage(player1, player2);
            }
            else
            {
                CalculateHpDamage(player2, player1);
            }
            runda++;
        }

        public Player GetWinner()
        {
            return player1.IsAlive() && !player2.IsAlive() ? player1 : player2; //s
        }

        public int GetRunda()
        {
            return runda;
        }
    }
}

