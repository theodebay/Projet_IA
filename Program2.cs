using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
{
    class Program2
    {
        static void Main(string[] args)
        {

            InferenceEngine engine = new ProjetIA();


            // Facts
            engine.AddFact("f1 monster 1 100 4 4 4 2d8 4 4 2d4");
            engine.AddFact("f2 monster 2 50 4 4 4 2d8 4 4 2d4");
            engine.AddFact("f7 monster 3 50 4 4 4 2d8 4 4 2d4");

            engine.AddFact("f3 from 3");
            engine.AddFact("f4 to 1");
            engine.AddFact("f5 action attack");
            engine.AddFact("f6 weapon crossbow");





        }
    }
}
