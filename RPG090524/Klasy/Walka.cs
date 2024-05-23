using RPG090524.Kasy;
using RPG090524.Kasy.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524.Klasy
{
    static class Walka
    {
        public static void inicjalizacja(Character gracz,Enemy enemy)
        {
            int hpgracza = gracz.GetVigor();
            int intel1=gracz.GetIntelligence();
            int str1=gracz.GetIntelligence();

            int hpwroga = enemy.GetVigor();
            int atk2 = enemy.GetDamage();
            int atk1 = intel1 * str1;
            while(hpgracza > 0&&hpwroga>0) {

                if(hpwroga > 0)
                {

                    hpwroga = hpwroga - atk1;
                    Console.WriteLine("Hp wroga wynosi: " + hpwroga.ToString());

                }

                if(hpgracza > 0&& hpwroga > 0)
                {
                    hpgracza = hpgracza - atk2;
                    Console.WriteLine("Hp gracza wynosi: " + hpgracza.ToString());
                }
                if(hpgracza <= 0)
                {
                    Console.WriteLine("Wygral przeciwnik");
                }
                if(hpwroga <= 0)
                {
                    Console.WriteLine("Wygral gracz");
                }
            }

        }
        public static string inicjalizacjawpf(Character gracz, Enemy enemy)
        {
            int hpgracza = gracz.GetVigor();
            int intel1 = gracz.GetIntelligence();
            int str1 = gracz.GetIntelligence();

            int hpwroga = enemy.GetVigor();
            int atk2 = enemy.GetDamage();
            int atk1 = intel1 * str1;
            while (hpgracza > 0 && hpwroga > 0)
            {

                if (hpwroga > 0)
                {

                    hpwroga = hpwroga - atk1;
                    Console.WriteLine("Hp wroga wynosi: " + hpwroga.ToString());

                }

                if (hpgracza > 0 && hpwroga > 0)
                {
                    hpgracza = hpgracza - atk2;
                    Console.WriteLine("Hp gracza wynosi: " + hpgracza.ToString());
                }
            }
            if (hpgracza <= 0)
            {
                return ("Wygral przeciwnik");
            }
            else
            {
                return ("Wygral gracz");
            }

        }
    }
}
