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
        Player first, second;
         public int random;

        public void Fight(Player primulJucator, Player AlDoileaJucator)
        {
            random = r.Next(0, 100);
            
                //determinam cine loveste
                if (random < 50)
                {

                    primulJucator.hp = primulJucator.hp - (AlDoileaJucator.forta / primulJucator.protection);

                }


                else
                {

                    AlDoileaJucator.hp = AlDoileaJucator.hp - (primulJucator.forta / AlDoileaJucator.protection);

                }     

}
   }
}

