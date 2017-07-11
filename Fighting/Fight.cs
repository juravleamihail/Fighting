using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        Player Winner;

        static Random r = new Random();
        Player first, second;
         public int random;

        public void Fight(Player first, Player second)
        {
            random = r.Next(0, 100);
            
                //determinam cine loveste
                if (random < 50)
                {

                    first.hp = first.hp - (second.forta / first.protection);

                }


                else
                {

                    second.hp -= second.hp - (first.forta / second.protection);

                }     

}
   }
}

