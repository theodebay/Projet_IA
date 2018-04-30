using System;
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
        Traitement_String traitement_String;
        InferenceEngine engine;
        public jeux(MonsterFactory monsters, PlayerFactory players, InferenceEngine curengine)
        {
            InitializeComponent();
            this.monsterFactory = monsters;
            this.playerFactory = players;
            this.engine = curengine;
            traitement_String = new Traitement_String();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\n-------------------------------------REQUEST--------------------------------------");
            bool ok = true;

            // Find the attacker
            string attacker = traitement_String.from(PlayerAction.Text, playerFactory, monsterFactory);
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
            string defender = traitement_String.to(PlayerAction.Text, playerFactory, monsterFactory);
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
            string action = traitement_String.findAction(PlayerAction.Text);
            if (action == null)
            {
                BattleInfo.Text = "Action impossible";
                ok = false;
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " action " + action);
            }

            // Find the weapon
            string keyword = traitement_String.findWeapon(PlayerAction.Text);
            if (keyword == null)
            {
                BattleInfo.Text = "Weapon missing";
                ok = false;
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " weapon " + keyword);
            }


            if (ok)
            {
                engine.TestAndFire();
                updateEntities(BattleInfo);
            }



        }

        private void updateEntities(RichTextBox battleInfo)
        {
            foreach (Fact f in engine.knowledgeBase.facts)
            {
                Monster m = monsterFactory.getById(f.value[1]);
                Player p = playerFactory.getById(f.value[1]);

                if (m == null)
                {
                    // Player has been updated ?
                    if (f.value[2] != p.health.ToString())
                    {
                        int val = -(p.health - Int32.Parse(f.value[2]));
                        BattleInfo.Text += "Player " + p.name + " received " + val + " HP\n";

                        if (Int32.Parse(f.value[2]) <= 0)
                        {
                            BattleInfo.Text += "Player " + p.name + " has been slain\n";
                            playerFactory.removePlayer(p);
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
                            monsterFactory.removeMonster(m);
                        }
                        else
                        {
                            m.health = Int32.Parse(f.value[2]);
                        }
                    }
                }
            }
            /*
            BattleInfo.Text += "--------------------"+ "\n";
            foreach (Monster m in monsterFactory.getList())
            {
                BattleInfo.Text += m.ToString() + "\n";
            }
            foreach (Player m in playerFactory.getList())
            {
                BattleInfo.Text += m.ToString() + "\n";
            }
            */
        }
    }
}
