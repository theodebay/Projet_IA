using System;
using System.Collections.Generic;

namespace ProjetIA
{
    internal class Result
    {
        private string result;
        string op;

        public Result(string v)
        {
            if (v.StartsWith("assert"))
            {
                this.op = "assert";
                this.result = v.Substring(7, v.Length - 8);
            }

            else if (v.StartsWith("retract"))
            {
                this.op = "retract";
                this.result = v.Substring(8, v.Length - 9);
            }
        }

        internal void Fire(KnowledgeBase kb, Dictionary<string, string> variables)
        {
            if (op.Equals("assert"))
            {
                string newFact = this.result.Substring(0);

                // Replace ?variables with their values
                foreach (string key in variables.Keys)
                {
                    newFact = newFact.Replace(key, variables[key]);
                }

                // Do operations + and - 
                newFact = ReplaceOperation(newFact);

                // Add the new fact to the knowledge base
                newFact = "f" + (kb.count + 1) + " " + newFact;
                kb.AddFact(newFact);
            }

            else if (op.Equals("retract"))
            {
                // Replace ?variables with their values
                string newFact = this.result.Substring(0);
                foreach (string key in variables.Keys)
                {
                    newFact = newFact.Replace(key, variables[key]);
                }

                // Find the fact and remove it
                string[] elements = newFact.Split(' ');
                Fact fact = null;
                foreach (Fact f in kb.facts)
                {
                    if (f.value[1] == elements[0] && f.value[2] == elements[1])
                    {
                        fact = f;
                        kb.RemoveFact(f);
                        break;
                    }
                }   
                System.Diagnostics.Debug.WriteLine("Removed fact - " + fact.name);
            }


        }

        /**
         * Replace the operation by their value and return the corresponding string 
         **/
        private string ReplaceOperation(string newFact)
        {
            
            bool done = false;

            while (!done) // Could be done without iterating but I don't want to bother with the indexes -.-"
            {
                // Find operations
                List<int> startParanthesis = new List<int>();
                List<int> endParanthesis   = new List<int>();
                List<int> operationSign    = new List<int>();

                for (int i = 0; i < newFact.Length; i++)
                {
                    if (newFact[i] == '(') startParanthesis.Add(i);
                    else if (newFact[i] == ')') endParanthesis.Add(i);
                    else if (newFact[i] == '+' || newFact[i] == '-' && newFact[i+1] == ' ') operationSign.Add(i);
                }

                // Replace operation by their result
                if (operationSign.Count != 0)
                {
                    operationSign.Reverse();
                    int ind = operationSign[0];
                    int indEnd = 0;

                    // Find closest end parenthesis
                    foreach (int i in endParanthesis)
                    {
                        if (i > ind)
                        {
                            indEnd = i;
                            break;
                        }
                    }

                    // Isolate the operation and calculate
                    string substring = newFact.Substring(ind, indEnd - ind);
                    string[] elements = substring.Split(' ');

                    // --- Is it an int or a dice ?
                    int int1 = 0;
                    int int2 = 0;

                    if (elements[1].Contains("d")){
                        int1 = RollDice(elements[1]); 
                    } else
                    {
                        int1 = Int32.Parse(elements[1]);
                    }

                    if (elements[2].Contains("d"))
                    {
                        int2 = RollDice(elements[2]);
                    }
                    else
                    {
                        int2 = Int32.Parse(elements[2]);
                    }

                    int result = (elements[0].Equals("+")) ? int1 + int2 : int1 - int2;

                    // Replace 
                    newFact = newFact.Substring(0, ind-1) +result+ newFact.Substring(indEnd+1);
                    
                } else
                {
                    done = true;
                }
            }

            return newFact;

        }

        private int RollDice(string v)
        {
            Random random = new Random();
            string[] elements = v.Split('d');
            int value = 0;

            for (int i = 0; i < Int32.Parse(elements[0]); i++)
            {
                value += random.Next(1, Int32.Parse(elements[1]));
            }

            return value;
        }
    }
}