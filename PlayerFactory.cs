using System.Collections.Generic;

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

        public void AddPlayer(string name, int health, int attack, int armor, int agility, int baseDmgMelee, int baseDmgDst)
        {
            Player p = new Player(name, health, attack, armor, agility, baseDmgMelee, baseDmgDst);
            players.Add(p);
            this.kb.AddFact("f" + (kb.count + 1) + " " + p.ToFact());
        }

        public List<Player> GetList()
        {
            return players;
        }

        public Player GetById(string id)
        {
            foreach (Player p in players)
            {
                if (p.name == id)
                {
                    return p;
                }
            }
            return null;
        }

        internal void RemovePlayer(Player p)
        {
            this.players.Remove(p);
        }
    }
}
