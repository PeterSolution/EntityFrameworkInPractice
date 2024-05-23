using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524.Kasy.Enemies
{
    public class Enemy
    {
        protected int vigor;
        protected int damage;

        public Enemy()
        {
            vigor = 0;
            damage = 0;
        }

        public void Appear()
        {
            string name = GetType().Name;

            Console.WriteLine($"Atakuje {name}");
        }

        public int GetVigor()
        {
            return vigor;
        }
        public int GetDamage()
        {
            return damage;
        }
        public void UpdateVigor(int vigor)
        {
            this.vigor = vigor;
        }
    }
}
