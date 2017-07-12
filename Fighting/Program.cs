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

        static void Init_playerAttributes()
        {
            player1 = new Player("Mitica", 100, 3);
            player2 = new Player("Mircea", 100, 3);
            arena = new Arena();
        }

        static void ShowInitMessage(Player player1,Player player2)
        {
            Console.WriteLine("Doamnelor si domnilor in aceasta seara ii vom avea in arena pe cei 2 mari campioni: {0} si {1} ", player1.name, player2.name);
        }

        static void ShowPlayerAttributes(Player player)
        {
            Console.WriteLine("{0} : HP - {1} , Protection - {2} ", player.name, player.hp, player.protection);
        }

        static void Main(string[] args)
        {
            Init_playerAttributes();

            int rundaContor = 1;

            ShowInitMessage(player1, player2);

            ShowPlayerAttributes(player1);
            ShowPlayerAttributes(player2);

            Console.ReadLine();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Runda cu nr: {0}", rundaContor);

                arena.Fight(player1, player2);

                //CR: extract this
                if (player1.hp < 0 || player2.hp < 0)
                    break;

                ShowPlayerAttributes(player1);
                ShowPlayerAttributes(player2);

                Console.ReadLine();

                rundaContor++;
            }

            
            //CR: extract this
            if (player1.hp > 0)
                Console.WriteLine("{0} a castigat", player1.name);
            else
                Console.WriteLine("{0} a castigat", player2.name);

            Console.ReadKey();
        }
    }
}
