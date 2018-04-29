using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    class InferenceEngine
    {
        public KnowledgeBase knowledgeBase;
        public RuleBase ruleBase;

        public InferenceEngine()
        {
            this.knowledgeBase = new KnowledgeBase();
            this.ruleBase = new RuleBase();
        }

        public void AddFact(string fact) { this.knowledgeBase.AddFact(fact); }

        public void RemoveFact(Fact fact) { this.knowledgeBase.RemoveFact(fact); }

        public void AddRule(string rule) { this.ruleBase.AddRule(rule); }

        public void TestAndFire() {
            this.ruleBase.TestAndFire(knowledgeBase);
            System.Diagnostics.Debug.WriteLine("\n------------------------------------CLEAN UP-------------------------------------");
            this.knowledgeBase.CleanTempFacts();
        }

    }
}
