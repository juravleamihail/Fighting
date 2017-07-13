using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Player
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private float hp;
        private float protection;
        public float forta;

        public Player(string Name, float Hp, float protection)
        {
            this.name = Name;
            this.hp = Hp;
            this.protection = protection;
            SetForce();
        }

        public void SetForce()
        {
            Random NrRandom = new Random();
            forta = NrRandom.Next(40, 80);
        }

        internal void Punch(Player enemy)
        {
            if (!IsAlive() || !enemy.IsAlive())
                return;

            enemy.hp -= (forta / enemy.protection);            
        }

        public bool IsAlive()
        {
            return hp > 0;
        }

        public override string ToString()
        {
            return string.Format("{0} : HP - {1} , Protection - {2} ", name, hp, protection);
        }

        //public string GetName()
        //{
        //    return name;
        //}

        public float GetProtection()
        {
            return protection;
        }
    }
}

