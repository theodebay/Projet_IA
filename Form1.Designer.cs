namespace ProjetIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Addmonster = new System.Windows.Forms.Button();
            this.mHp = new System.Windows.Forms.Label();
            this.mForce = new System.Windows.Forms.Label();
            this.mAmor = new System.Windows.Forms.Label();
            this.Addmonster = new System.Windows.Forms.Label();
            this.mDmgMelee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monsterHealth = new System.Windows.Forms.NumericUpDown();
            this.monsterAttack = new System.Windows.Forms.NumericUpDown();
            this.monsterArmor = new System.Windows.Forms.NumericUpDown();
            this.monsterMeleeDamage = new System.Windows.Forms.NumericUpDown();
            this.monsterDistDamage = new System.Windows.Forms.NumericUpDown();
            this.monsterAgility = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MonsterNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerAction = new System.Windows.Forms.RichTextBox();
            this.BattleInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.doAction = new System.Windows.Forms.Button();
            this.PlayerAgility = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerDistDmg = new System.Windows.Forms.NumericUpDown();
            this.PlayerMeleeDmg = new System.Windows.Forms.NumericUpDown();
            this.PlayerArmor = new System.Windows.Forms.NumericUpDown();
            this.Playerdmg = new System.Windows.Forms.NumericUpDown();
            this.playerHp = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.monsterHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterMeleeDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterDistDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDistDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMeleeDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerdmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHp)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Addmonster
            // 
            this.b_Addmonster.Location = new System.Drawing.Point(40, 251);
            this.b_Addmonster.Name = "b_Addmonster";
            this.b_Addmonster.Size = new System.Drawing.Size(161, 34);
            this.b_Addmonster.TabIndex = 0;
            this.b_Addmonster.Text = "Add Monster";
            this.b_Addmonster.UseVisualStyleBackColor = true;
            this.b_Addmonster.Click += new System.EventHandler(this.b_Addmonster_Click);
            // 
            // mHp
            // 
            this.mHp.AutoSize = true;
            this.mHp.Location = new System.Drawing.Point(7, 61);
            this.mHp.Name = "mHp";
            this.mHp.Size = new System.Drawing.Size(27, 17);
            this.mHp.TabIndex = 5;
            this.mHp.Text = "HP";
            // 
            // mForce
            // 
            this.mForce.AutoSize = true;
            this.mForce.Location = new System.Drawing.Point(7, 91);
            this.mForce.Name = "mForce";
            this.mForce.Size = new System.Drawing.Size(47, 17);
            this.mForce.TabIndex = 6;
            this.mForce.Text = "Attack";
            // 
            // mAmor
            // 
            this.mAmor.AutoSize = true;
            this.mAmor.Location = new System.Drawing.Point(7, 119);
            this.mAmor.Name = "mAmor";
            this.mAmor.Size = new System.Drawing.Size(46, 17);
            this.mAmor.TabIndex = 7;
            this.mAmor.Text = "Armor";
            // 
            // Addmonster
            // 
            this.Addmonster.AutoSize = true;
            this.Addmonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Addmonster.Location = new System.Drawing.Point(8, 10);
            this.Addmonster.Name = "Addmonster";
            this.Addmonster.Size = new System.Drawing.Size(141, 26);
            this.Addmonster.TabIndex = 8;
            this.Addmonster.Text = "Add  Monster";
            // 
            // mDmgMelee
            // 
            this.mDmgMelee.AutoSize = true;
            this.mDmgMelee.Location = new System.Drawing.Point(10, 174);
            this.mDmgMelee.Name = "mDmgMelee";
            this.mDmgMelee.Size = new System.Drawing.Size(128, 17);
            this.mDmgMelee.TabIndex = 9;
            this.mDmgMelee.Text = "MeleeWeaponDmg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "DistWeaponDmg";
            // 
            // monsterHealth
            // 
            this.monsterHealth.Location = new System.Drawing.Point(147, 56);
            this.monsterHealth.Name = "monsterHealth";
            this.monsterHealth.Size = new System.Drawing.Size(120, 22);
            this.monsterHealth.TabIndex = 11;
            // 
            // monsterAttack
            // 
            this.monsterAttack.Location = new System.Drawing.Point(147, 84);
            this.monsterAttack.Name = "monsterAttack";
            this.monsterAttack.Size = new System.Drawing.Size(120, 22);
            this.monsterAttack.TabIndex = 12;
            // 
            // monsterArmor
            // 
            this.monsterArmor.Location = new System.Drawing.Point(147, 112);
            this.monsterArmor.Name = "monsterArmor";
            this.monsterArmor.Size = new System.Drawing.Size(120, 22);
            this.monsterArmor.TabIndex = 13;
            // 
            // monsterMeleeDamage
            // 
            this.monsterMeleeDamage.Location = new System.Drawing.Point(147, 172);
            this.monsterMeleeDamage.Name = "monsterMeleeDamage";
            this.monsterMeleeDamage.Size = new System.Drawing.Size(120, 22);
            this.monsterMeleeDamage.TabIndex = 14;
            // 
            // monsterDistDamage
            // 
            this.monsterDistDamage.Location = new System.Drawing.Point(147, 200);
            this.monsterDistDamage.Name = "monsterDistDamage";
            this.monsterDistDamage.Size = new System.Drawing.Size(120, 22);
            this.monsterDistDamage.TabIndex = 15;
            // 
            // monsterAgility
            // 
            this.monsterAgility.Location = new System.Drawing.Point(147, 140);
            this.monsterAgility.Name = "monsterAgility";
            this.monsterAgility.Size = new System.Drawing.Size(120, 22);
            this.monsterAgility.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Agility";
            // 
            // MonsterNumber
            // 
            this.MonsterNumber.Location = new System.Drawing.Point(146, 295);
            this.MonsterNumber.Name = "MonsterNumber";
            this.MonsterNumber.Size = new System.Drawing.Size(120, 22);
            this.MonsterNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "MonsterNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Player Action";
            // 
            // PlayerAction
            // 
            this.PlayerAction.Location = new System.Drawing.Point(10, 392);
            this.PlayerAction.Name = "PlayerAction";
            this.PlayerAction.Size = new System.Drawing.Size(383, 149);
            this.PlayerAction.TabIndex = 23;
            this.PlayerAction.Text = "";
            // 
            // BattleInfo
            // 
            this.BattleInfo.Location = new System.Drawing.Point(487, 392);
            this.BattleInfo.Name = "BattleInfo";
            this.BattleInfo.Size = new System.Drawing.Size(383, 149);
            this.BattleInfo.TabIndex = 24;
            this.BattleInfo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(482, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Battle Info";
            // 
            // doAction
            // 
            this.doAction.Location = new System.Drawing.Point(389, 450);
            this.doAction.Name = "doAction";
            this.doAction.Size = new System.Drawing.Size(101, 39);
            this.doAction.TabIndex = 26;
            this.doAction.Text = "Do Action";
            this.doAction.UseVisualStyleBackColor = true;
            this.doAction.Click += new System.EventHandler(this.doAction_Click);
            // 
            // PlayerAgility
            // 
            this.PlayerAgility.Location = new System.Drawing.Point(621, 168);
            this.PlayerAgility.Name = "PlayerAgility";
            this.PlayerAgility.Size = new System.Drawing.Size(120, 22);
            this.PlayerAgility.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Agility";
            // 
            // PlayerDistDmg
            // 
            this.PlayerDistDmg.Location = new System.Drawing.Point(621, 228);
            this.PlayerDistDmg.Name = "PlayerDistDmg";
            this.PlayerDistDmg.Size = new System.Drawing.Size(120, 22);
            this.PlayerDistDmg.TabIndex = 38;
            // 
            // PlayerMeleeDmg
            // 
            this.PlayerMeleeDmg.Location = new System.Drawing.Point(621, 200);
            this.PlayerMeleeDmg.Name = "PlayerMeleeDmg";
            this.PlayerMeleeDmg.Size = new System.Drawing.Size(120, 22);
            this.PlayerMeleeDmg.TabIndex = 37;
            // 
            // PlayerArmor
            // 
            this.PlayerArmor.Location = new System.Drawing.Point(621, 140);
            this.PlayerArmor.Name = "PlayerArmor";
            this.PlayerArmor.Size = new System.Drawing.Size(120, 22);
            this.PlayerArmor.TabIndex = 36;
            // 
            // Playerdmg
            // 
            this.Playerdmg.Location = new System.Drawing.Point(621, 112);
            this.Playerdmg.Name = "Playerdmg";
            this.Playerdmg.Size = new System.Drawing.Size(120, 22);
            this.Playerdmg.TabIndex = 35;
            // 
            // playerHp
            // 
            this.playerHp.Location = new System.Drawing.Point(621, 84);
            this.playerHp.Name = "playerHp";
            this.playerHp.Size = new System.Drawing.Size(120, 22);
            this.playerHp.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "DistWeaponDmg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "MeleeWeaponDmg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(482, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Add  Player";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Armor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Attack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "HP";
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(516, 281);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(161, 34);
            this.AddPlayer.TabIndex = 27;
            this.AddPlayer.Text = "Add Player";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Name";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(621, 56);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(119, 22);
            this.PlayerName.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PlayerAgility);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlayerDistDmg);
            this.Controls.Add(this.PlayerMeleeDmg);
            this.Controls.Add(this.PlayerArmor);
            this.Controls.Add(this.Playerdmg);
            this.Controls.Add(this.playerHp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AddPlayer);
            this.Controls.Add(this.doAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BattleInfo);
            this.Controls.Add(this.PlayerAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MonsterNumber);
            this.Controls.Add(this.monsterAgility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monsterDistDamage);
            this.Controls.Add(this.monsterMeleeDamage);
            this.Controls.Add(this.monsterArmor);
            this.Controls.Add(this.monsterAttack);
            this.Controls.Add(this.monsterHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mDmgMelee);
            this.Controls.Add(this.Addmonster);
            this.Controls.Add(this.mAmor);
            this.Controls.Add(this.mForce);
            this.Controls.Add(this.mHp);
            this.Controls.Add(this.b_Addmonster);
            this.Name = "Form1";
            this.Text = "Gestion de combat";
            ((System.ComponentModel.ISupportInitialize)(this.monsterHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterMeleeDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterDistDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDistDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMeleeDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerdmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Addmonster;
        private System.Windows.Forms.Label mHp;
        private System.Windows.Forms.Label mForce;
        private System.Windows.Forms.Label mAmor;
        private System.Windows.Forms.Label Addmonster;
        private System.Windows.Forms.Label mDmgMelee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown monsterHealth;
        private System.Windows.Forms.NumericUpDown monsterAttack;
        private System.Windows.Forms.NumericUpDown monsterArmor;
        private System.Windows.Forms.NumericUpDown monsterMeleeDamage;
        private System.Windows.Forms.NumericUpDown monsterDistDamage;
        private System.Windows.Forms.NumericUpDown monsterAgility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MonsterNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PlayerAction;
        private System.Windows.Forms.RichTextBox BattleInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button doAction;
        private System.Windows.Forms.NumericUpDown PlayerAgility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PlayerDistDmg;
        private System.Windows.Forms.NumericUpDown PlayerMeleeDmg;
        private System.Windows.Forms.NumericUpDown PlayerArmor;
        private System.Windows.Forms.NumericUpDown Playerdmg;
        private System.Windows.Forms.NumericUpDown playerHp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PlayerName;
    }
}

