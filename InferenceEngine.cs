using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIA
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
            System.Diagnostics.Debug.WriteLine("\n-------------------------------------START---------------------------------------");
            this.ruleBase.TestAndFire(knowledgeBase);
            System.Diagnostics.Debug.WriteLine("\n------------------------------------CLEAN UP-------------------------------------");
            this.knowledgeBase.CleanTempFacts();
            System.Diagnostics.Debug.WriteLine("\n------------------------------------CHECK UP-------------------------------------");
            foreach(Fact f in this.knowledgeBase.facts)
            {
                System.Diagnostics.Debug.WriteLine(f.ToString());
            }
        }


        public void InitRules()
        {
            System.Diagnostics.Debug.WriteLine("\n---------------------------------------INIT--------------------------------------");

            // Rules for our RPG :
            // --- The weapon induces if it's a melee or ranged attack
            System.Diagnostics.Debug.WriteLine("\n// --- The weapon induces if it's a melee or ranged attack");

            this.AddRule("r1 (weapon shortbow)$(assert(typeAtk range))");
            this.AddRule("r2 (weapon bow)$(assert(typeAtk range))");
            this.AddRule("r3 (weapon crossbow)$(assert(typeAtk range))");
            this.AddRule("r4 (weapon longbow)$(assert(typeAtk range))");
            this.AddRule("r5 (weapon throwingAxe)$(assert(typeAtk range))");
            this.AddRule("r6 (weapon spear)$(assert(typeAtk range))");

            this.AddRule("r7 (weapon sword)$(assert(typeAtk melee))");
            this.AddRule("r8 (weapon greatSword)$(assert(typeAtk melee))");
            this.AddRule("r9 (weapon axe)$(assert(typeAtk melee))");
            this.AddRule("r10 (weapon doubleAxe)$(assert(typeAtk melee))");
            this.AddRule("r11 (weapon daggers)$(assert(typeAtk melee))");
            this.AddRule("r12 (weapon hammer)$(assert(typeAtk melee))");

            // --- The verb used in the sentence induces if the target should be healed or damaged
            System.Diagnostics.Debug.WriteLine("\n// --- The verb used in the sentence induces if the target should be healed or damaged");
            this.AddRule("r13 (action attacks)$(assert(typeModif dmg))");
            this.AddRule("r14 (action shoots)$(assert(typeModif dmg))");
            this.AddRule("r15 (action heals)$(assert(typeModif heal))&(assert(typeAtk heal))");
            this.AddRule("r16 (action cures)$(assert(typeModif heal)&(assert(typeAtk heal)))");

            // --- Get the stats of the monster (from)
            System.Diagnostics.Debug.WriteLine("\n// --- Get the stats of the monster (from)");
            this.AddRule("r17 (from ?x)&(typeModif dmg)&(typeAtk range)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages ?baseDmgRg ?DiceRg))&(assert(test ?agility))");
            this.AddRule("r18 (from ?x)&(typeModif dmg)&(typeAtk melee)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages ?baseDmgMelee ?DiceMelee))&(assert(test ?attack))");
            this.AddRule("r19 (from ?x)&(typeModif heal)&(typeAtk heal)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages 10 2d8))");

            // --- Play the action
            System.Diagnostics.Debug.WriteLine("\n// --- Play the action");
            this.AddRule("r20 (to ?x)&(typeAtk heal)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(monster ?x (+ (+ ?val ?dice) ?hp) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");
            this.AddRule("r21 (to ?x)&(typeAtk range)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)&(test ?stat)$(assert(monster ?x (- ?hp (+ ?val ?dice)) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");
            this.AddRule("r22 (to ?x)&(typeAtk melee)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)&(test ?stat)$(assert(monster ?x (- ?hp (+ ?val ?dice)) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");

        }

    }
}
