using System.Collections.Generic;

namespace ProjetIA
{
    class MonsterFactory
    {
        private int count;
        private List<Monster> monsters;
        private KnowledgeBase kb;

        public MonsterFactory(KnowledgeBase kb)
        {
            count = -1;
            monsters = new List<Monster>();
            this.kb = kb;
        }

        public int AddMonster(int health, int attack, int armor, int agility, int baseDmgMelee, int baseDmgDst)
        {
            count++;
            Monster m = new Monster(count.ToString(), health, attack, armor, agility, baseDmgMelee, baseDmgDst);
            monsters.Add(m);
            
            this.kb.AddFact("f" + (kb.count + 1) + " " + m.ToFact());
            return count;
        }

        public List<Monster> GetList()
        {
            return monsters;
        }

        public Monster GetById(string id)
        {
            foreach (Monster m in monsters)
            {
                if (m.id == id)
                {
                    return m;
                }
            }
            return null;
        }

        internal void RemoveMonster(Monster m)
        {
            this.monsters.Remove(m);
        }
    }
}
