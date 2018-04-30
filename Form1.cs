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
    public partial class Form1 : Form
    {
        MonsterFactory monsterFactory;
        PlayerFactory playerFactory;
        Traitement_String traitement_String;
        InferenceEngine engine;
        int nbMonster;


        public Form1()
        {
            InitializeComponent();

            engine = new InferenceEngine();
            engine.InitRules();

            monsterFactory = new MonsterFactory(engine.knowledgeBase);
            playerFactory = new PlayerFactory(engine.knowledgeBase);

            traitement_String = new Traitement_String();

            nbMonster = 0;
        }

        private void b_Addmonster_Click(object sender, EventArgs e)
        {
            int id = monsterFactory.addMonster(Decimal.ToInt32(monsterHealth.Value), Decimal.ToInt32(monsterAttack.Value), Decimal.ToInt32(monsterArmor.Value), Decimal.ToInt32(monsterAgility.Value), Decimal.ToInt32(monsterMeleeDamage.Value), Decimal.ToInt32(monsterDistDamage.Value));
            //Console.WriteLine("Monster created with id" + id);
            nbMonster++;
            MonsterNumber.Text = Convert.ToString(nbMonster);

            
        }

        private void doAction_Click(object sender, EventArgs e)
        {

            // Find the attacker
            string attacker = traitement_String.from(PlayerAction.Text, playerFactory, monsterFactory);
            if(attacker == null)
            {
                BattleInfo.Text = "Can't find attacker";
            }
            else
            {
                engine.AddFact("f"+(engine.knowledgeBase.count+1) + " from " + attacker);
                
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


        private void AddPlayer_Click(object sender, EventArgs e)
        {
            playerFactory.addPlayer(PlayerName.Text, Decimal.ToInt32(playerHp.Value), Decimal.ToInt32(Playerdmg.Value), Decimal.ToInt32(PlayerArmor.Value), Decimal.ToInt32(PlayerAgility.Value), Decimal.ToInt32(PlayerMeleeDmg.Value), Decimal.ToInt32(PlayerDistDmg.Value));

        }

       
    }
}
