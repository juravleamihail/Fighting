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
        static Random r = new Random();

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

        public string Fight(Player firstPlayer, Player secondPlayer)
        {
            int randomCineAtaca = r.Next(0, 100);

            while (!IsDead(firstPlayer, secondPlayer))
              {
                //CR: magic number 50
                if (randomCineAtaca < 50)
                {
                    //CR:DRY :)
                    firstPlayer.hp = firstPlayer.hp - (secondPlayer.forta / firstPlayer.protection);
                }

                else
                {
                    //CR:DRY :)
                    secondPlayer.hp = secondPlayer.hp - (firstPlayer.forta / secondPlayer.protection);
                }
             }
            return "Castigatorul este: " + Winner.name;
        }
   }
}

