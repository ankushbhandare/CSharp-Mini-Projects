using WarriorWars.Enums;

namespace WarriorWars.Equipment
{
    internal class Weapon
    {
        private const int KNIFE_DAMAGE=2;
        private const int PISTOL_DAMAGE = 5;
        private const int AK47_DAMAGE=8;
        private const int SNIPER_DAMAGE = 30;
        private const int GRENADE_DAMAGE = 50;
        private const int MACHINEGUN_DAMAGE = 10;
        private const int MISSILE_DAMAGE = 50;

        private const int KNIFE_SPEED = 2;
        private const int PISTOL_SPEED = 4;
        private const int AK47_SPEED = 7;
        private const int SNIPER_SPEED = 1;
        private const int GRENADE_SPEED = 1;
        private const int MACHINEGUN_SPEED = 8;
        private const int MISSILE_SPEED = 5;

        private const int KNIFE_ACCURACY = 8;
        private const int PISTOL_ACCURACY = 5;
        private const int AK47_ACCURACY = 4;
        private const int SNIPER_ACCURACY = 10;
        private const int GRENADE_ACCURACY = 6;
        private const int MACHINEGUN_ACCURACY = 3;
        private const int MISSILE_ACCURACY = 6;

        private const int KNIFE_RELOAD_TIME = 2;
        private const int PISTOL_RELOAD_TIME = 3;
        private const int AK47_RELOAD_TIME = 5;
        private const int SNIPER_RELOAD_TIME = 6;
        private const int GRENADE_RELOAD_TIME = 10;
        private const int MACHINEGUN_RELOAD_TIME = 7;
        private const int MISSILE_RELOAD_TIME = 20;

        private const int KNIFE_WEIGHT = 2;
        private const int PISTOL_WEIGHT = 5;
        private const int AK47_WEIGHT = 8;
        private const int SNIPER_WEIGHT = 10;
        private const int GRENADE_WEIGHT = 3;
        private const int MACHINEGUN_WEIGHT = 12;
        private const int MISSILE_WEIGHT = 25;

        private int damage;

        public int Damage
        { get
            {
                return damage;
            }
                
        }

        /*public Weapon(Faction faction, WeaponList weapon)
        {
            if (weapon.Equals(WeaponList.Knife))
            {
                switch (faction)
                {
                    case Faction.Hero:
                        damage = KNIFE_DAMAGE*KNIFE_SPEED*KNIFE_ACCURACY/(KNIFE_RELOAD_TIME+KNIFE_WEIGHT);
                        break;
                    case Faction.Villain:
                        damage = KNIFE_DAMAGE * KNIFE_SPEED * KNIFE_ACCURACY / (KNIFE_RELOAD_TIME + KNIFE_WEIGHT);
                        break;
                    default:
                        break;
                }
            }
            else if (weapon.Equals(WeaponList.Pistol))
            {
                switch (faction)
                {
                    case Faction.Hero:
                        damage = PISTOL_DAMAGE * PISTOL_SPEED * PISTOL_ACCURACY /(PISTOL_RELOAD_TIME + PISTOL_WEIGHT);
                        break;
                    case Faction.Villain:
                        damage = PISTOL_DAMAGE * PISTOL_SPEED * PISTOL_ACCURACY / (PISTOL_RELOAD_TIME + PISTOL_WEIGHT);
                        break;
                    default:
                        break;
                }
            }
            else if (weapon.Equals(WeaponList.AK47))
            {
                switch (faction)
                {
                    case Faction.Hero:
                        damage = AK47_DAMAGE * AK47_SPEED * AK47_ACCURACY / (AK47_RELOAD_TIME + AK47_WEIGHT);
                        break;
                    case Faction.Villain:
                        damage = AK47_DAMAGE * AK47_SPEED * AK47_ACCURACY / (AK47_RELOAD_TIME + AK47_WEIGHT);
                        break;
                    default:
                        break;
                }
            }
            else if (weapon.Equals(WeaponList.Sniper))
            {
                switch (faction)
                {
                    case Faction.Hero:
                        damage = SNIPER_DAMAGE * SNIPER_SPEED * SNIPER_ACCURACY / (SNIPER_RELOAD_TIME + SNIPER_WEIGHT); 
                        break;
                    case Faction.Villain:
                        damage = SNIPER_DAMAGE * SNIPER_SPEED * SNIPER_ACCURACY / (SNIPER_RELOAD_TIME + SNIPER_WEIGHT);
                        break;
                    default:
                        break;
                }
            }

        }
        */
        public Weapon(WeaponList weapon)
        {
            if (weapon.Equals(WeaponList.Knife))
            {
                damage = KNIFE_DAMAGE * KNIFE_SPEED * KNIFE_ACCURACY / (KNIFE_RELOAD_TIME + KNIFE_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.Pistol))
            {
                damage = PISTOL_DAMAGE * PISTOL_SPEED * PISTOL_ACCURACY / (PISTOL_RELOAD_TIME + PISTOL_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.AK47))
            {
                damage = AK47_DAMAGE * AK47_SPEED * AK47_ACCURACY / (AK47_RELOAD_TIME + AK47_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.Sniper))
            {
                damage = SNIPER_DAMAGE * SNIPER_SPEED * SNIPER_ACCURACY / (SNIPER_RELOAD_TIME + SNIPER_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.Grenade))
            {
                damage = GRENADE_DAMAGE * GRENADE_SPEED * GRENADE_ACCURACY / (GRENADE_RELOAD_TIME + GRENADE_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.MachineGun))
            {
                damage = MACHINEGUN_DAMAGE * MACHINEGUN_SPEED * MACHINEGUN_ACCURACY / (MACHINEGUN_ACCURACY + MACHINEGUN_WEIGHT);
            }
            else if (weapon.Equals(WeaponList.Missile))
            {
                damage = MISSILE_DAMAGE * MISSILE_SPEED * MISSILE_ACCURACY / (MISSILE_RELOAD_TIME + MISSILE_WEIGHT);
            }

        }

    }
}