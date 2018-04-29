using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class MonsterFactory
    {
        private int count;
        private List<Monster> monsters;

        public MonsterFactory()
        {
            count = 0;
            monsters = new List<Monster>();
        }

        public int addMonster(int health, int diceMelee, int armor, int diceDst, int baseDmgMelee, int baseDmgDst)
        {
            monsters.Add(new Monster(count, health, diceMelee, armor, diceDst, baseDmgMelee, baseDmgDst));
            count++;
            return count;
        }
    }
}
