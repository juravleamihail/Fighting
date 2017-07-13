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
        static Display display;

        static void InitGame()
        {
            player1 = new Player("Mitica", 100, 3);
            player2 = new Player("Mircea", 100, 3);
            arena = new Arena(player1, player2);
            display = new Display();
        }

        static void Main(string[] args)
        {
            InitGame();

            display.ShowInitMessage(player1,player2);

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

            display.ShowWinner(arena);

            Console.ReadKey();
        }
    }
}

