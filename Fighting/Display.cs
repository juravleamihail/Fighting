using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Display
    {
        public void ShowInitMessage(Player player1,Player player2)
        {
            Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", player1.Name, player2.Name);
        }

        public void ShowWinner(Arena arena)
        {
            Console.WriteLine("Castigatorul este: {0}", arena.GetWinner().Name);
        }
    }
}
