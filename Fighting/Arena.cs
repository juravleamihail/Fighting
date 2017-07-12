using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        static Random r = new Random();

        public void Fight(Player firstPlayer, Player secondPlayer)
        {
            int randomCineAtaca = r.Next(0, 100);
            
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
   }
}

