using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524.Kasy.Enemies
{
    public static class EnemyCreator
    {
        internal static Enemy Create()
        {
            Random rnd = new Random();
            
            int rndNum = rnd.Next(0,2);

            if (rndNum == 0)
            {
                return new Rat();
            }
            if (rndNum == 1)
            {
                return new Bandit();
            }
            if (rndNum == 2)
            {
                return new Golem();
            }
            return new Enemy();
        }
    }
}
