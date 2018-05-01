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
        InstructionTreatment traitement_String;
        InferenceEngine engine;
        int nbMonster;

        string monster_list = "";
        string player_list = "";
        public Form1()
        {
            InitializeComponent();

            engine = new InferenceEngine();
            engine.InitRules();

            monsterFactory = new MonsterFactory(engine.knowledgeBase);
            playerFactory = new PlayerFactory(engine.knowledgeBase);

            traitement_String = new InstructionTreatment();

            nbMonster = 0;
        }

        private void b_Addmonster_Click(object sender, EventArgs e)
        {
            int id = monsterFactory.AddMonster(Decimal.ToInt32(monsterHealth.Value), Decimal.ToInt32(monsterAttack.Value), Decimal.ToInt32(monsterArmor.Value), Decimal.ToInt32(monsterAgility.Value), Decimal.ToInt32(monsterMeleeDamage.Value), Decimal.ToInt32(monsterDistDamage.Value));
            //Console.WriteLine("Monster created with id" + id);
            System.Windows.Forms.MessageBox.Show("Monster added !");
            nbMonster++;
            MonsterNumber.Text = Convert.ToString(nbMonster);

            List<Monster> monsters = monsterFactory.GetList();
            foreach(Monster monster in monsters)
            {
                string temps_monster = monster.ToFact();
                monster_list = monster_list + "\n" + temps_monster;
            }

            Monsterbox.Text = monster_list;
            monster_list = "";
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            playerFactory.AddPlayer(PlayerName.Text, Decimal.ToInt32(playerHp.Value), Decimal.ToInt32(Playerdmg.Value), Decimal.ToInt32(PlayerArmor.Value), Decimal.ToInt32(PlayerAgility.Value), Decimal.ToInt32(PlayerMeleeDmg.Value), Decimal.ToInt32(PlayerDistDmg.Value));
            System.Windows.Forms.MessageBox.Show("Player added !");

            List<Player> players = playerFactory.GetList();
            foreach (Player player in players)
            {
                
               string temps_player = player.ToFact();
               player_list = player_list + "\n" + temps_player;
            }

            PlayerBox.Text = player_list;
            player_list = "";
        }

        private void BattleBegin_Click(object sender, EventArgs e)
        {

            jeux form = new jeux(monsterFactory, playerFactory, engine);
            form.Show();
        }
    }
}
