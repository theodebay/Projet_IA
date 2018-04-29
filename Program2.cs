using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    class Program2
    {
        static void Main(string[] args)
        {

            InferenceEngine engine = new InferenceEngine();

            System.Diagnostics.Debug.WriteLine("\n---------------------------------------INIT--------------------------------------");
            //engine.AddFact("f1 diminue MM");
            //engine.AddFact("f2 augmente TE");
            //engine.AddRule("(diminue ?x)&(augmente ?y)$(assert(augmente ?x))");

            //engine.AddRule("r1 (data ?x ?y)$(assert(data (+ ?x ?y) (+ (- ?x 3) 3)))");
            //engine.AddRule("r2 (data ?x ?y)&(lol ?x)$(assert(data ?x ?y))");
            //engine.AddFact("f1 data 1 2");
            //engine.AddFact("f2 lol 1");

            // Rules for our RPG :
            // --- The weapon induces if it's a melee or ranged attack
            System.Diagnostics.Debug.WriteLine("\n// --- The weapon induces if it's a melee or ranged attack");
            
            engine.AddRule("r1 (weapon shortbow)$(assert(typeAtk range))");
            engine.AddRule("r2 (weapon bow)$(assert(typeAtk range))");
            engine.AddRule("r3 (weapon crossbow)$(assert(typeAtk range))");
            engine.AddRule("r4 (weapon longbow)$(assert(typeAtk range))");
            engine.AddRule("r5 (weapon throwingAxe)$(assert(typeAtk range))");
            engine.AddRule("r6 (weapon spear)$(assert(typeAtk range))");

            engine.AddRule("r7 (weapon sword)$(assert(typeAtk melee))");
            engine.AddRule("r8 (weapon greatSword)$(assert(typeAtk melee))");
            engine.AddRule("r9 (weapon axe)$(assert(typeAtk melee))");
            engine.AddRule("r10 (weapon doubleAxe)$(assert(typeAtk melee))");
            engine.AddRule("r11 (weapon daggers)$(assert(typeAtk melee))");
            engine.AddRule("r12 (weapon hammer)$(assert(typeAtk melee))");
            
            // --- The verb used in the sentence induces if the target should be healed or damaged
            System.Diagnostics.Debug.WriteLine("\n// --- The verb used in the sentence induces if the target should be healed or damaged");
            engine.AddRule("r13 (action attack)$(assert(typeModif dmg))");
            engine.AddRule("r14 (action shoot)$(assert(typeModif dmg))");
            engine.AddRule("r15 (action heal)$(assert(typeModif heal))&(assert(typeAtk heal))");
            engine.AddRule("r16 (action cure)$(assert(typeModif heal)&(assert(typeAtk heal)))");

            // --- Get the stats of the monster (from)
            System.Diagnostics.Debug.WriteLine("\n// --- Get the stats of the monster (from)");
            engine.AddRule("r17 (from ?x)&(typeModif dmg)&(typeAtk range)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages ?baseDmgRg ?DiceRg))&(assert(test ?agility))");
            engine.AddRule("r18 (from ?x)&(typeModif dmg)&(typeAtk melee)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages ?baseDmgMelee ?DiceMelee))&(assert(test ?attack))");
            engine.AddRule("r19 (from ?x)&(typeModif heal)&(typeAtk heal)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(damages 10 2d8))");

            // --- Play the action
            System.Diagnostics.Debug.WriteLine("\n// --- Play the action");
            engine.AddRule("r20 (to ?x)&(typeAtk heal)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)$(assert(monster ?x (+ (+ ?val ?dice) ?hp) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");
            engine.AddRule("r21 (to ?x)&(typeAtk range)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)&(test ?stat)$(assert(monster ?x (- ?hp (+ ?val ?dice)) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");
            engine.AddRule("r22 (to ?x)&(typeAtk melee)&(damages ?val ?dice)&(monster ?x ?hp ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg)&(test ?stat)$(assert(monster ?x (- ?hp (+ ?val ?dice)) ?armor ?attack ?baseDmgMelee ?DiceMelee ?agility ?baseDmgRg ?DiceRg))&(retract(?x ?hp))");



            // Facts
            engine.AddFact("f1 monster 1 100 4 4 4 2d8 4 4 2d4");
            engine.AddFact("f2 monster 2 50 4 4 4 2d8 4 4 2d4");
            engine.AddFact("f7 monster 3 50 4 4 4 2d8 4 4 2d4");

            engine.AddFact("f3 from 3");
            engine.AddFact("f4 to 1");
            engine.AddFact("f5 action attack");
            engine.AddFact("f6 weapon crossbow");
            





            //System.Diagnostics.Debug.WriteLine(engine.knowledgeBase.facts[0]);
            //System.Diagnostics.Debug.WriteLine(engine.knowledgeBase.facts[1]);
            System.Diagnostics.Debug.WriteLine("\n--------------------------------------START--------------------------------------");
            engine.TestAndFire();

            //System.Diagnostics.Debug.WriteLine(engine.knowledgeBase.facts[2]);
            //System.Diagnostics.Debug.WriteLine(engine.knowledgeBase.facts[3]);

            System.Diagnostics.Debug.WriteLine("\n---------------------------------------------------------------------------------");
        }
    }
}
