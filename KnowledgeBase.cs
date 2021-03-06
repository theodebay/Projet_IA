﻿

using System;
using System.Collections.Generic;

namespace ProjetIA
{
    internal class KnowledgeBase
    {

        public List<Fact> facts { get; set; }
        public int count;

        public KnowledgeBase()
        {
            this.facts = new List<Fact>();
            count = 0;
        }

        public void AddFact(string fact) {
            Fact f = new Fact(fact);
            this.facts.Add(f);
            count++;
            System.Diagnostics.Debug.WriteLine("Added fact - " + f.ToString());
        }

        public void RemoveFact(Fact fact) { this.facts.Remove(fact); }

        /**
         * Remove all the tempory facts created during the action.
         * Only keeps the monsters.
         **/
        public void CleanTempFacts()
        {
            List<Fact> cleanedBase = new List<Fact>();
            foreach (Fact f in facts)
            {
                if (f.value[0] != "monster")
                {
                    System.Diagnostics.Debug.WriteLine("Cleaned fact - " + f.ToString());
                } else
                {
                    cleanedBase.Add(f);
                }
            }

            this.facts = cleanedBase;
        }

        internal void CleanDead()
        {
            List<Fact> cleanedBase = new List<Fact>();
            foreach (Fact f in facts)
            {
                if (Int32.Parse(f.value[2]) <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("Cleaned dead - " + f.ToString());
                }
                else
                {
                    cleanedBase.Add(f);
                }
            }

            this.facts = cleanedBase;

        }
    }
}