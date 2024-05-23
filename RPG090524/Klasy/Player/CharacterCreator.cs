using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524.Kasy
{
    public static class CharacterCreator
    {
        public static Character Create(int index)
        {
            if(index == 0)
            {
                return new Warrior();
            }

            if(index == 1)
            {
                return new Mage();
            }

            if (index == 2)
            {
                return new Rogue();
            }

            if(index == 3)
            {
                return new Shaman();
            }
            return new Character();
        }

    }
}
