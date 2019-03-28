using WarriorWars.Enums;

namespace WarriorWars.Equipment
{
    internal class Armor
    {
        private const int HERO_ARMOR=2;
        private const int VILLAIN_ARMOR=2;

        private int armorPoints;

        public int ArmorPoints
        { get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.Hero:
                    armorPoints = HERO_ARMOR;
                    break;
                case Faction.Villain:
                    armorPoints = VILLAIN_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}