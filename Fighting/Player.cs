using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Player
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
            SetForce();
        }

        private void SetForce()
        {
            Random NrRandom = new Random();
            forta = NrRandom.Next(40, 80);
        }
   }
}

