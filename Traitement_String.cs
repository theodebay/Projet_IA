using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class Traitement_String
    {
        private string keyword;
        private string action;
        private List<int> enemy;

        public Traitement_String()
        {
            keyword = null;
            enemy = new List<int>();
        }

        public string findWeapon(string action)
        {
            string[] words = action.Split(' ');

            foreach(string word in words)
            {
                switch (word)
                {
                    case "shortbow":
                        keyword = word;
                        break;

                    case "bow":
                        keyword = word;
                        break;

                    case "crossbow":
                        keyword = word;
                        break;

                    case "longbow":
                        keyword = word;
                        break;

                    case "throwingAxe":
                        keyword = word;
                        break;

                    case "spear":
                        keyword = word;
                        break;

                    case "sword":
                        keyword = word;
                        break;

                    case "greatSword":
                        keyword = word;
                        break;

                    case "axe":
                        keyword = word;
                        break;

                    case "doubleAxe":
                        keyword = word;
                        break;

                    case "daggers":
                        keyword = word;
                        break;

                    case "hammer":
                        keyword = word;
                        break;

                    default:
                        keyword = null;
                        break;

                }
            }

            return keyword;
        }

        public string findAction(string actiontofind)
        {
            string[] words = actiontofind.Split(' ');

            foreach (string word in words)
            {
                switch (word)
                {
                    case "attack":
                        action = word;
                        break;

                    case "shoot":
                        action = word;
                        break;

                    case "heal":
                        action = word;
                        break;

                    case "cure":
                        action = word;
                        break;

                    default:
                        action = null;
                        break;
                }
            }

            return action;
        }

        public Monster findMonster(string text, MonsterFactory monster_factory)
        {
            Monster monster_find;

            List<Monster> monsters = monster_factory.getList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i<monsters.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).getStringId())
                    {
                        monster_find = monsters.ElementAt(i);
                        return monster_find;
                    }
                }
            }

            return null;
        }

        public Player findPlayer(string text, PlayerFactory player_factory)
        {
            Player player_find;

            List<Player> players = player_factory.getList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).getName())
                    {
                        player_find = players.ElementAt(i);
                        return player_find;
                    }
                }
            }

            return null;
        }
    }
}
