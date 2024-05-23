using RPG090524.Kasy;
using RPG090524.Kasy.Enemies;
using RPG090524.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG090524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player;

            Enemy enemy;




            player = CharacterCreator.Create(0);

            enemy = EnemyCreator.Create();


            player.Print();

            enemy.Appear();

            Walka.inicjalizacja(player, enemy);
            


            Console.ReadKey();
        }
    }
}
