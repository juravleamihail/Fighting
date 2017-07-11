using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            int rundaContor = 1;

            Player player1 = new Player("Mitica", 100, 3);
            Player player2 = new Player("Mircea", 110, 3);
            Arena fight = new Arena();

            System.Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", player1.name, player2.name);
            System.Console.WriteLine("{0} : HP - {1} , Protection - {2} ", player1.name, player1.hp, player1.protection);
            System.Console.WriteLine("{0} : HP - {1} , Protection - {2} ", player2.name, player2.hp, player2.protection);
            Random r = new Random();
            Console.ReadLine();

            while (player1.hp > 0 || player2.hp > 0)
            {
                Console.Clear();
                System.Console.WriteLine("Runda cu nr: {0}", rundaContor);
                // fight.Fight(player1, player2);
                // fight.Fight(player2, player1);
                System.Console.WriteLine("{0} : HP - {1} , Protection - {2} ", player1.name, player1.hp, player1.protection);
                System.Console.WriteLine("{0} : HP - {1} , Protection - {2} ", player2.name, player2.hp, player2.protection);
                Console.ReadLine();
                rundaContor++;
            }



        }
    }
}
