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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Find the attacker
            string attacker = traitement_String.from(PlayerAction.Text, playerFactory, monsterFactory);
            if (attacker == null)
            {
                BattleInfo.Text = "Can't find attacker";
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
            }
            else
            {
                engine.AddFact("f" + (engine.knowledgeBase.count + 1) + " weapon " + keyword);
            }


            engine.TestAndFire();



        }
    }
}
