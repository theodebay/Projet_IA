using System;
using System.Collections.Generic;

namespace InferenceEngine
{
    internal class Condition
    {
        public string op { get; }
        public string test { get; }

        public List<bool> variables { get; }
        public List<string> variablesNames { get; }
        public List<string> variablesValues { get; }

        public Condition subCond1 { get; }
        public Condition subCond2 { get; }

        public Condition(string v)
        {
            this.variables       = new List<bool>();
            this.variablesNames  = new List<string>();
            this.variablesValues = new List<string>();

            
            if (v.StartsWith("not"))
            {
                op = "not";
                string substring = v.Substring(4);
                if (substring.StartsWith("("))
                {
                    subCond1 = new Condition(substring.Substring(1, substring.Length - 2));
                } else
                {
                    subCond1 = new Condition(substring);
                }

            }

            else if (v.StartsWith("test"))
            {
                op = "test";
                string[] elements = v.Split(' ');
            }

            else
            {
                op = "";
                string[] info = v.Split(' ');
                for (int i = 0; i < info.Length; i++)
                {
                    this.variables.Add(info[i].StartsWith("?"));
                    this.variablesNames.Add(info[i]);
                }
            }
        }


        internal bool IsVerified(KnowledgeBase kb, Dictionary<string, string> variablesMap)
        {
            if (op.Equals(""))
            {
                foreach(Fact f in kb.facts)
                {
                    //System.Diagnostics.Debug.WriteLine("fait testé : " + f.ToString());
                    //System.Diagnostics.Debug.Write("variables : ");
                    foreach (string s in this.variablesNames)
                    {
                       // System.Diagnostics.Debug.Write(s + ", ");
                    }
                    //System.Diagnostics.Debug.WriteLine("");

                    //System.Diagnostics.Debug.WriteLine("test: "+ f.value.Count+" // "+ this.variablesNames.Count);
                    if (f.value.Count == this.variablesNames.Count)
                    {
                        
                        for (int i = 0; i < this.variablesNames.Count; i++)
                        {
                            if (!this.variables[i] && this.variablesNames[i] != f.value[i])
                            {
                                // A part differs, condition isn't verified 
                                //System.Diagnostics.Debug.WriteLine("partie pas identique:"+this.variablesNames[i] +"//" + f.value[i]+".");
                                break;
                            }

                            // Add the value of the variable in that fact (needed to fire the rule)
                            if (variablesMap.ContainsKey(this.variablesNames[i]))
                            {
                                if (variablesMap[this.variablesNames[i]] != f.value[i])
                                {
                                    break;
                                }
                                
                            } else
                            {
                                variablesMap[this.variablesNames[i]] = f.value[i];
                            }

                            //System.Diagnostics.Debug.WriteLine(i);
                            if (i == this.variablesNames.Count - 1 && (this.variables[i] || this.variablesNames[i] == f.value[i]))
                            {
                                // Every parts of the condition are verrified
                                //System.Diagnostics.Debug.WriteLine("C'est bon!");
                                return true;
                            }
                        }
                    } else
                    {
                        //System.Diagnostics.Debug.WriteLine("pas la même taille");
                    }
                }
                
                return false;
            }

            else if (op.Equals("not"))
            {
                return !(subCond1.IsVerified(kb, variablesMap));
            }




            else if (op.Equals("test"))
            {
                Random random = new Random();
                int dice = random.Next(1, 20);
                if (dice == 1)
                {
                    System.Diagnostics.Debug.WriteLine("Failure ! You missed your attack...");
                    return false;
                } else
                {
                    int valTest = 0;
                    foreach (Fact f in kb.facts)
                    {
                        if (f.value[0].Equals("test"))
                        {
                            valTest = Int32.Parse(f.value[1]);
                            break;
                        }
                    }
                    if (valTest + dice > Int32.Parse(variablesMap["?armor"]))
                    {
                        return true;
                    } else
                    {
                        System.Diagnostics.Debug.WriteLine("Failure ! The enemy has too much armor...");
                        return false;
                    }
                    
                }
            }

            return false;
        }
    }
}