using System;

namespace ProjetIA
{
    class Monster
    {
        public int health;
        public string id;
        private int armor;
        private int baseDmgMelee;
        private int attack;
        private int baseDmgDst;
        private int agility;

        public Monster(string id, int health, int attack, int armor, int agility, int baseDmgMelee, int baseDmgDst)
        {
            this.health = health;
            this.id = id;
            this.armor = armor;
            this.baseDmgMelee = baseDmgMelee;
            this.attack = attack;
            this.baseDmgDst = baseDmgDst;
            this.agility = agility;
        }

        public string ToFact()
        {
            string fact = ("monster " + id + " " + health + " " + armor + " " + attack + " " + baseDmgMelee + " " + "2d8 " + agility + " " + baseDmgDst + " " + "2d4");
            return fact;
        }

        public string GetStringNumber()
        {
            return Convert.ToString(Int32.Parse(id) + 1);
        }
        
        public string GetStringId()
        {
            return Convert.ToString(id);
        }

        public override string ToString()
        {
            return "monstre" + id + ": " + health;
        }

    }
}
