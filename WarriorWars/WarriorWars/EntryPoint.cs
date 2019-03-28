using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWars.Enums;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rnd = new Random();

        static void Main()
        {
            Console.Write("Hero Name: ");
            String heroName = Console.ReadLine();
            Console.Write("Villain Name: ");
            String villainName = Console.ReadLine();

            Warrior hero = new Warrior(heroName, Faction.Hero);
            Warrior villain = new Warrior(villainName, Faction.Villain);

            Array values = Enum.GetValues(typeof(WeaponList));
            Random list = new Random();
            //WeaponList wpn = (WeaponList)values.GetValue(list.Next(values.Length));

            while (hero.IsAlive && villain.IsAlive)
            {
                WeaponList wpn = (WeaponList)values.GetValue(list.Next(values.Length));
                if (rnd.Next(0,99)%2 == 0)
                {
                    hero.Attack(villain, wpn);

                }
                else
                {
                    villain.Attack(hero,wpn);
                }

            }
            Console.ReadKey();
        }
    }
}
