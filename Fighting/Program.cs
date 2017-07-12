using Fighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Program
    {
        static Player player1, player2;
        static Arena arena;

        static void InitGame()
        {
            player1 = new Player("Mitica", 100, 3);
            player2 = new Player("Mircea", 100, 3);
            arena = new Arena(player1, player2);
        }

        static void Main(string[] args)
        {
            InitGame();

            ShowInitMessage();

            Console.ReadKey();
            
            while (arena.PlayersAreAlive())
            {
                Console.WriteLine("Runda cu nr: {0}", arena.GetRunda());
                Console.WriteLine(player1);
                Console.WriteLine(player2);

                arena.Fight();

                Console.ReadKey();
            }

            Console.ReadLine();

            ShowWinner();
        }

        static private void ShowInitMessage()
        {
            Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", player1.GetName(), player2.GetName());
        }

        static private void ShowWinner()
        {
            Console.WriteLine("Castigatorul este: {0}", arena.GetWinner().GetName());
        }

    }
}

