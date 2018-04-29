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

            }

            return keyword;
        }
    }
}
