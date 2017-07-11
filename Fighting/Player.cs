using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Player
    {

        public string name;
        public float hp;
        public float protection;
        public float forta;

        public Player(string Name, float Hp, float Protection)
        {

            this.name = Name;
            this.hp = Hp;
            this.protection = Protection;
            this.forta = RandomNumbers();
        }


        public int RandomNumbers()
        {

            Random NrRandom = new Random();
            int RandomForta = NrRandom.Next(10, 30);
            return RandomForta;
        }
            }


    }

