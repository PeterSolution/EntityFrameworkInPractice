using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524.Kasy
{
    public class Character
    {
        protected int strenght;

        protected int intelligence;

        protected int vigor;

        public Character()
        {
            strenght = 0;
            intelligence = 0;
            vigor = 0;
        }
        public void Print()
        {
            string className = GetType().Name;

            Console.WriteLine($"Klasa: {className}\nStrenght: {strenght}\nIntelligence: {intelligence}\nVigor: {vigor}");
        }

        public int GetStrenght()
        {
            return strenght;
        }

        public int GetIntelligence()
        {
            return strenght;
        }

        public int GetVigor()
        {
            return vigor;
        }

        public void UpdateVigor(int vigor)
        {
            this.vigor = vigor;
        }

    }
}
