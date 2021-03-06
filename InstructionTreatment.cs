﻿using System.Collections.Generic;
using System.Linq;

namespace ProjetIA
{
    class InstructionTreatment
    {
        private string keyword;
        private string action;
        private List<int> enemy;

        public InstructionTreatment()
        {
            keyword = null;
            enemy = new List<int>();
        }

        public string FindWeapon(string action)
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

        public string FindAction(string actiontofind)
        {
            string[] words = actiontofind.Split(' ');

            foreach (string word in words)
            {
                switch (word)
                {
                    case "attacks":
                        action = word;
                        return action;

                    case "shoots":
                        action = word;
                        return action;

                    case "heals":
                        action = word;
                        return action;

                    case "cures":
                        action = word;
                        return action;

                    default:
                        action = null;
                        break;
                }
            }

            return action;
        }

        public Monster FindMonster(string text, MonsterFactory monster_factory)
        {
            Monster monster_find;

            List<Monster> monsters = monster_factory.GetList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i<monsters.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).GetStringNumber())
                    {
                        monster_find = monsters.ElementAt(i);
                        return monster_find;
                    }
                }
            }

            return null;
        }

        public Player FindPlayer(string text, PlayerFactory player_factory)
        {
            Player player_find;

            List<Player> players = player_factory.GetList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).GetName())
                    {
                        player_find = players.ElementAt(i);
                        return player_find;
                    }
                }
            }

            return null;
        }

        public string From(string text, PlayerFactory player_factory, MonsterFactory monster_factory)
        {
            string attacker;

            List<Monster> monsters = monster_factory.GetList();
            List<Player> players = player_factory.GetList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).GetName())
                    {
                        attacker = players.ElementAt(i).GetName();
                        return attacker;
                    }
                }
                for(int i = 0; i < monsters.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).GetStringId())
                    {
                        attacker = monsters.ElementAt(i).GetStringId();
                        return attacker;
                    }
                }
            }

            return null;
        }

        public string To(string text, PlayerFactory player_factory, MonsterFactory monster_factory)
        {
            string defender;
            int from = 0;
            List<Monster> monsters = monster_factory.GetList();
            List<Player> players = player_factory.GetList();
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (word == players.ElementAt(i).GetName() && from < 1)
                    {
                        from ++;
                    }
                    else if (word == players.ElementAt(i).GetName() && from > 0)
                    {
                        defender = players.ElementAt(i).GetName();
                        return defender;
                    }
                    
                }

                for(int i = 0; i < players.Count(); i++)
                {
                    if (word == monsters.ElementAt(i).GetStringNumber() && from < 1)
                    {
                        from++;
                    }
                    else if (word == monsters.ElementAt(i).GetStringNumber() && from > 0)
                    {
                        defender = monsters.ElementAt(i).GetStringId();
                        return defender;
                    }
                }
            }

            return null;
        }
    }
  
}
