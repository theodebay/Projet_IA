﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA
{
    partial class jeux : Form
    {
        MonsterFactory monsterFactory;
        PlayerFactory playerFactory;
        InstructionTreatment traitement_String;
        InferenceEngine engine;
        public jeux(MonsterFactory monsters, PlayerFactory players, InferenceEngine curengine)
        {
            InitializeComponent();
            this.monsterFactory = monsters;
            this.playerFactory = players;
            this.engine = curengine;
            traitement_String = new InstructionTreatment();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\n-------------------------------------REQUEST--------------------------------------");
            bool ok = true;

            // Find the attacker
            string attacker = traitement_String.From(PlayerAction.Text, playerFactory, monsterFactory);
            if (attacker == null)
            {
                BattleInfo.Text = "Can't find attacker";
                ok = false;
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " from " + attacker);

            }

            // Find the target
            string defender = traitement_String.To(PlayerAction.Text, playerFactory, monsterFactory);
            if (attacker == null)
            {
                BattleInfo.Text = "Can't find defender";
                ok = false;
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " to " + defender);
            }


            // Find the action
            string action = traitement_String.FindAction(PlayerAction.Text);
            if (action == null)
            {
                BattleInfo.Text = "Action impossible";
                ok = false;
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " action " + action);
            }

            if (action == "attacks" || action == "shoots")
            {
                // Find the weapon
                string keyword = traitement_String.FindWeapon(PlayerAction.Text);
                if (keyword == null)
                {
                    BattleInfo.Text = "Weapon missing";
                    ok = false;
                }
                else
                {
                    engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " weapon " + keyword);
                }
            }

            if (ok)
            {
                engine.TestAndFire();
                UpdateEntities();
                Recap();
            }



        }

        private void Recap()
        {
            BattleInfo.Text += "\n----------------------ENTITIES LEFT----------------------\n\n";
            foreach (Fact f in engine.knowledgeBase.facts)
            {
                BattleInfo.Text += "Monster " + f.value[1] + ": " + f.ToString()+"\n";
            }
            BattleInfo.Text += "\n---------------------------------------------------------------------------\n\n";
        }

        private void UpdateEntities()
        {
            foreach (Fact f in engine.knowledgeBase.facts)
            {
                Monster m = monsterFactory.GetById(f.value[1]);
                Player p = playerFactory.GetById(f.value[1]);

                if (m == null)
                {
                    // Player has been updated ?
                    if (f.value[2] != p.health.ToString())
                    {
                        int val = -(p.health - Int32.Parse(f.value[2]));
                        BattleInfo.Text += "Player " + p.name + " received " + val + " HP (from " + p.health + " to " + f.value[2] + " HP)\n";

                        if (Int32.Parse(f.value[2]) <= 0)
                        {
                            BattleInfo.Text += "Player " + p.name + " has been slain\n";
                            playerFactory.RemovePlayer(p);
                        }
                        else
                        {
                            p.health = Int32.Parse(f.value[2]);
                        }
                    }
                }
                else
                {
                    // Monster has been updated ?
                    if (f.value[2] != m.health.ToString())
                    {
                        int val = -(m.health - Int32.Parse(f.value[2]));
                        BattleInfo.Text += "Monster " + m.id + " received " + val + " HP (from "+m.health+" to "+f.value[2]+" HP)\n";

                        if (Int32.Parse(f.value[2]) <= 0)
                        {
                            BattleInfo.Text += "Monster " + m.id + " has been slain\n";
                            monsterFactory.RemoveMonster(m);
                        }
                        else
                        {
                            m.health = Int32.Parse(f.value[2]);
                        }
                    }
                }
            }

            engine.knowledgeBase.CleanDead();
        }
    }
}
