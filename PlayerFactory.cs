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

        public PlayerFactory()
        {
            players = new List<Player>();
        }

        public void addPlayer(string name, int health, int diceMelee, int armor, int diceDst, int baseDmgMelee, int baseDmgDst)
        {
            players.Add(new Player(name, health, diceMelee, armor, diceDst, baseDmgMelee, baseDmgDst));
        }

        public List<Player> getList()
        {
            return players;
        }
    }
}
