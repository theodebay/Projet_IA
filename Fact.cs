using System.Collections.Generic;

namespace ProjetIA
{
    internal class Fact
    {
        public string name { get; }
        public List<string> value { get; }

        public Fact(string fact)
        {
            this.value = new List<string>();

            string[] info = fact.Split(' ');

            this.name = info[0];

            for (int i = 1; i < info.Length; i++)
            {
                this.value.Add(info[i]);

            }

        }


        public override string ToString()
        {
            string line = this.name + ": (";
            foreach(string v in this.value){
                line = line + " " + v;
            }
            line = line + " )";
            return line;
        }
    }
}