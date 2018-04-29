using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class Player
    {
        public int health;
        public string name;

        private int armor;
        private int baseDmgMelee;
        private int diceMelee;
        private int baseDmgDst;
        private int diceDst;

        public Player(string name,int health, int diceMelee, int armor, int diceDst, int baseDmgMelee, int baseDmgDst)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            this.baseDmgMelee = baseDmgMelee;
            this.diceMelee = diceMelee;
            this.baseDmgDst = baseDmgDst;
            this.diceDst = diceDst;
        }

        public void Takedamage(int damage)
        {
            health = health - damage;
        }

        public void Heal(int heal)
        {
            health = health + heal;
        }
    }
}
