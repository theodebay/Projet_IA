using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class PlayerFactory
    {
        private List<Player> players;
        private KnowledgeBase kb;

        public PlayerFactory(KnowledgeBase kb)
        {
            players = new List<Player>();
            this.kb = kb;
        }

        public void addPlayer(string name, int health, int attack, int armor, int agility, int baseDmgMelee, int baseDmgDst)
        {
            Player p = new Player(name, health, attack, armor, agility, baseDmgMelee, baseDmgDst);
            players.Add(p);
            this.kb.AddFact("f" + (kb.count + 1) + " " + p.toFact());
        }

        public List<Player> getList()
        {
            return players;
        }
    }
}
