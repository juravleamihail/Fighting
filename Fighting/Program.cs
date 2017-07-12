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

        static void Main(string[] args)
        {
            Init_playerAttributes();

            arena.Fight(player1, player2);
        }
    }
}

