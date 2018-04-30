using System;
using System.Collections.Generic;

namespace ProjetIA
{
    internal class Rule
    {
        string name;
        string expression;

        Dictionary<string, string> variables = new Dictionary<string, string>();

        // Left-Hand Side(LHS)
        List<Condition> lhs;

        // Right-Hand Side (RHS)
        List<Result> rhs;

        /**
         * string is : (condition1)&(condition2)$(result1)&(result2)
         **/
        public Rule(string rule)
        {
            int ind = rule.IndexOf(' ');
            this.name = rule.Substring(0, ind);
            rule = rule.Substring(ind + 1);
            this.expression = rule;
            string[] conditions = rule.Split('$')[0].Split('&');
            string[] results = rule.Split('$')[1].Split('&');
            MakeConditions(conditions);
            MakeResults(results);
        }

        private void MakeConditions(string[] conditions)
        {
            lhs = new List<Condition>();

            foreach (string s in conditions)
            {
                lhs.Add(new Condition(s.Substring(1, s.Length - 2)));
            }

        }

        private void MakeResults(string[] results)
        {
            rhs = new List<Result>();

            foreach (string s in results)
            {
                rhs.Add(new Result(s.Substring(1, s.Length - 2)));
            }
        }

        public bool IsVerified(KnowledgeBase kb)
        {
            int i = 0; 
            foreach(Condition c in lhs)
            {
                if (!c.IsVerified(kb, variables))
                {
                    //if (this.name == "r19") System.Diagnostics.Debug.WriteLine("condition " + i + " non verifiée");
                    return false;
                }
                //if (this.name == "r20") System.Diagnostics.Debug.WriteLine("condition " + i + " verifiée");
                i++;
            }
            //System.Diagnostics.Debug.WriteLine("condition vérifiée");
            return true;
        }

        public void Fire(KnowledgeBase kb)
        {
            //variables = new Dictionary<string, string>();
            foreach(Result r in rhs)
            {
                System.Diagnostics.Debug.WriteLine("Rule " + this.name + " fired...");
                r.Fire(kb, variables);
            }
        }

        public override string ToString()
        {
            return this.name + ": " + this.expression;
        }

        public void Reset()
        {
            this.variables = new Dictionary<string, string>();
        }
    }
}