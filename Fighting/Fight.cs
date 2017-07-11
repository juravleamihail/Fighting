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
        Player second = new Player();
        Player Winner = new Player();

        public Random r = new Random();

        public string Fight(Player first, Player second)
        {
            public int random = r.Next(0, 100);
            while(first.hp > 0 || second.hp > 0){
            if(random< 50){    

            first.hp -= (second.forta) / first.protection;
            }
            

            else{

            second.hp -= (first.forta) / second.protection;
            }
            if(first.hp >= 0){
            Winner = first;
            }

            else{
            Winner = second;
            }

}

    return "Winner is" + Winner.name;
    }
}
}
