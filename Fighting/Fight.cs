﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        static Random r = new Random();
        Player first, second;
         public int randomCineAtaca;

        public void Fight(Player firstPlayer, Player secondPlayer)
        {
            randomCineAtaca = r.Next(0, 100);
            
                if (randomCineAtaca < 50)
                {

                    firstPlayer.hp = firstPlayer.hp - (secondPlayer.forta / firstPlayer.protection); //21

                   
                //vreau schimbare
                 //vreau schimbare
                }

                //nu vreau schimbare
                //vreau schimbare

                else
                {
                    secondPlayer.hp = secondPlayer.hp - (firstPlayer.forta / secondPlayer.protection); //4
                }     

}
   }
}

