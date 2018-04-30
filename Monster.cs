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

        private int id;
        private int armor;
        private int baseDmgMelee;
        private int diceMelee;
        private int baseDmgDst;
        private int diceDst;

        public Monster(int id, int health, int diceMelee, int armor, int diceDst, int baseDmgMelee, int baseDmgDst)
        {
            this.health = health;

            this.id = id;
            this.armor = armor;
            this.baseDmgMelee = baseDmgMelee;
            this.diceMelee = diceMelee;
            this.baseDmgDst = baseDmgDst;
            this.diceDst = diceDst;
        }

        public string toFact()
        {
            string fact = ("monster " + id + " " + health + " " + armor + " " + diceMelee + " " + baseDmgMelee + " " + "2d8 " + diceDst + " " + baseDmgDst + " " + "2d4");
            Console.WriteLine(fact);
            return fact;
        }

        public string getStringNumber()
        {
            return Convert.ToString(id + 1);
        }
        
        public string getStringId()
        {
            return Convert.ToString(id);
        }

    }
}
