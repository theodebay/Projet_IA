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
                        return keyword;

                    case "bow":
                        keyword = word;
                        return keyword;

                    case "crossbow":
                        keyword = word;
                        return keyword;

                    case "longbow":
                        keyword = word;
                        return keyword;

                    case "throwingAxe":
                        keyword = word;
                        return keyword;

                    case "spear":
                        keyword = word;
                        return keyword;

                    case "sword":
                        keyword = word;
                        return keyword;

                    case "greatSword":
                        keyword = word;
                        return keyword;

                    case "axe":
                        keyword = word;
                        return keyword;

                    case "doubleAxe":
                        keyword = word;
                        return keyword;

                    case "daggers":
                        keyword = word;
                        return keyword;

                    case "hammer":
                        keyword = word;
                        return keyword;

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
                        return action;

                    case "shoot":
                        action = word;
                        return action;

                    case "heal":
                        action = word;
                        return action;

                    case "cure":
                        action = word;
                        return action;

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
                    if (word == monsters.ElementAt(i).getStringNumber())
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

        public string from(string text, PlayerFactory player_factory, MonsterFactory monster_factory)
        {
            string attacker;

            List<Monster> monsters = monster_factory.getList();
            List<Player> players = player_factory.getList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).getName())
                    {
                        attacker = players.ElementAt(i).getName();
                        return attacker;
                    }
                }
                for(int i = 0; i < monsters.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).getStringId())
                    {
                        attacker = monsters.ElementAt(i).getStringId();
                        return attacker;
                    }
                }
            }

            return null;
        }

        public string to(string text, PlayerFactory player_factory, MonsterFactory monster_factory)
        {
            string defender;
            int from = 0;
            List<Monster> monsters = monster_factory.getList();
            List<Player> players = player_factory.getList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).getName())
                    {
                        from ++;
                    }
                    else if (word == players.ElementAt(i).getName() && from > 0)
                    {
                        defender = players.ElementAt(i).getName();
                        return defender;
                    }
                    
                }

                for(int i = 0; i < players.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).getStringId())
                    {
                        from++;
                    }
                    else if (word == monsters.ElementAt(i).getStringNumber() && from > 0)
                    {
                        defender = monsters.ElementAt(i).getStringId();
                        return defender;
                    }
                }
            }

            return null;
        }
    }
  
}
