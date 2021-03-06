﻿using System.Collections.Generic;

namespace ProjetIA
{
    internal class RuleBase
    {
        List<Rule> rules;

        public RuleBase()
        {
            this.rules = new List<Rule>();
        }

        public void AddRule(string rule) {
            Rule r = new Rule(rule);
            this.rules.Add(r);
            System.Diagnostics.Debug.WriteLine("Added rule - " + r.ToString());
        }

        public void RemoveRule(Rule rule) { this.rules.Remove(rule); }

        public void TestAndFire(KnowledgeBase kb)
        {
            foreach (Rule rule in rules)
            {
                if (rule.IsVerified(kb))
                {
                    rule.Fire(kb);
                }
            }

            // Reset variables
            foreach (Rule rule in rules)
            {
                rule.Reset();
            }
        }
    }
}