using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        private Player Winner;
        public const int constanta = 50;
        static Random r = new Random();

        public void ShowInitMessage(Player player1, Player player2)
        {
            Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", player1.name, player2.name);
        }

        private void ShowPlayerAttributes(Player a)
        {
            Console.WriteLine("{0} : HP - {1} , Protection - {2} ", a.name, a.hp, a.protection);
        }


        private bool IsDead(Player a, Player b)
        {
            if (a.hp < 0)
            {
                Winner = b;
            }
            return true;
            if (b.hp <0)
            {
                Winner = a;
            }
           return true;
        }
        
        private void CalculateHpDamage(Player player,Player otherPlayer)
        {
          player.hp-=(otherPlayer.forta/player.protection);
        }
      
        public string Fight(Player firstPlayer, Player secondPlayer)
        {
            int rundaContor = 1;

            int randomCineAtaca = r.Next(0, 100);

            ShowInitMessage(firstPlayer, secondPlayer);

            while (IsDead(firstPlayer, secondPlayer))
              {
                Console.WriteLine("Runda cu nr: {0}", rundaContor);
                ShowPlayerAttributes(firstPlayer);
                ShowPlayerAttributes(secondPlayer);
                //CR: magic number 50
                if (randomCineAtaca < constanta)
                {
                    //CR:DRY :)
                    CalculateHpDamage(firstPlayer, secondPlayer);
                }
                else
                {
                    //CR:DRY :)
                    CalculateHpDamage(secondPlayer, firstPlayer);
                }

                rundaContor++;
                Console.ReadLine();
             }

            return "Castigatorul este: " + Winner.name;
        }
    }
}

