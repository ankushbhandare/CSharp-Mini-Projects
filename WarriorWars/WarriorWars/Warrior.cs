using WarriorWars.Enums;
using WarriorWars.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WarriorWars
{
    class Warrior
    {
        private readonly Faction FACTION;
        private static bool flag = true;

        private const int HERO_START_HEALTH=100;
        private const int VILLAIN_START_HEALTH=100;
        //private WeaponList wpn;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
                
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;
            
            switch (faction)
            {
                case Faction.Hero:
                    //weapon = new Weapon(faction,wpn);
                    armor = new Armor(faction);
                    health = HERO_START_HEALTH;
                    break;
                case Faction.Villain:
                    //weapon = new Weapon(faction,wpn);
                    armor = new Armor(faction);
                    health = VILLAIN_START_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy, WeaponList wpn)
        {
            weapon = new Weapon( wpn);
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health = enemy.health - damage;
            //Console.WriteLine(wpn.ToString());
            //Thread.Sleep(2000);
            AttackResult(enemy, damage, wpn);
        }

        private void AttackResult(Warrior enemy, int damage, WeaponList wpn)
        {

            if (flag)
            {
                    Tools.ColorPrint($"{name} attacked {enemy.name} by {wpn}", ConsoleColor.Magenta);
                    Tools.ColorPrint($"Damage done is {damage}", ConsoleColor.Magenta);
                    Tools.ColorPrint($"{enemy.name} health is {enemy.health}", ConsoleColor.Magenta);
                    Console.WriteLine();
                    flag = false;
            }
            else
            {
                    Tools.ColorPrint($"{name} attacked {enemy.name} by {wpn}", ConsoleColor.Yellow);
                    Tools.ColorPrint($"Damage done is {damage}", ConsoleColor.Yellow);
                    Tools.ColorPrint($"{enemy.name} health is {enemy.health}", ConsoleColor.Yellow);
                    Console.WriteLine();
                    flag = true;
            }
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorPrint($"{enemy.name} is Dead! ", ConsoleColor.Red);
                Tools.ColorPrint($"{name} is Victorious!!", ConsoleColor.Green);
            }
            Thread.Sleep(1000);
        }
    }
}
