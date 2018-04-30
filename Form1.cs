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
            System.Windows.Forms.MessageBox.Show("Monster added !");
            nbMonster++;
            MonsterNumber.Text = Convert.ToString(nbMonster);

            
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            playerFactory.addPlayer(PlayerName.Text, Decimal.ToInt32(playerHp.Value), Decimal.ToInt32(Playerdmg.Value), Decimal.ToInt32(PlayerArmor.Value), Decimal.ToInt32(PlayerAgility.Value), Decimal.ToInt32(PlayerMeleeDmg.Value), Decimal.ToInt32(PlayerDistDmg.Value));
            System.Windows.Forms.MessageBox.Show("Player added !");
        }

        private void BattleBegin_Click(object sender, EventArgs e)
        {
            List<Monster> monsters = monsterFactory.getList();
            List<Player> players = playerFactory.getList();

            foreach(Monster monster in monsters)
            {
                string monster_temp = monster.ToString();
                engine.AddFact(monster_temp);
            }

            foreach (Player player in players)
            {
                string player_temp = player.ToString();
                engine.AddFact(player_temp);
            }
            jeux form = new jeux(monsterFactory, playerFactory, engine);
            form.Show();
        }
    }
}
