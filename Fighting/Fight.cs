using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Arena
    {
        Player first = new Player();
        Player second= new Player();

        public Random r = new Random();

        public void Fight(Player first,Player second)
        {
            first.hp -= (second.forta) / first.protection;
        }




    }
}
