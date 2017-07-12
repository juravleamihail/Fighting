using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        public Player Winner;
        public const int constanta = 50;
        static Random r = new Random();

        private void getStats(Player a)
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
        
        private void updateHpLevel(Player a, Player b)
        {
            a.hp -= (b.forta / a.protection);
        }
      
        public string Fight(Player firstPlayer, Player secondPlayer)
        {
            int randomCineAtaca = r.Next(0, 100);

            Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", firstPlayer.name, secondPlayer.name);

            while (!IsDead(firstPlayer, secondPlayer))
              {
                getStats(firstPlayer);
                getStats(secondPlayer);
                //CR: magic number 50
                if (randomCineAtaca < constanta)
                {
                    //CR:DRY :)
                    updateHpLevel(firstPlayer, secondPlayer);
                }
                else
                {
                    //CR:DRY :)
                    updateHpLevel(secondPlayer, firstPlayer);
                }
             }
            return "Castigatorul este: " + Winner.name;
        }
   }
}

