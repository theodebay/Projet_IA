using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class Monster
    {
        public int health;

        private string id;
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

        public string toFact()
        {
            string fact = ("monster " + id + " " + health + " " + armor + " " + attack + " " + baseDmgMelee + " " + "2d8 " + agility + " " + baseDmgDst + " " + "2d4");
            //Console.WriteLine(fact);
            return fact;
        }

        public string getStringNumber()
        {
            return Convert.ToString(Int32.Parse(id) + 1);
        }
        
        public string getStringId()
        {
            return Convert.ToString(id);
        }

    }
}
