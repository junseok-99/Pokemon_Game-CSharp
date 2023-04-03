using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDungeonGame
{
    public partial class FightRoom : Form
    {
        PokemonChoice pokechoiceform=null;
        Pikachu pika;
        Kkobuk kkobuk;
        Firy firy;
        Lijamong lijamong;
        Gyarados gyarados;
        Mangnanyong mangnanyong;
        Mews mews;
        User user;
        SoundPlayer fightroombgm;
        SoundPlayer gamewhinbgm;
        SoundPlayer gamelosebgm;
        PauseGame pausegame;
        Store store;
        IMoving pikamoving;
        IMoving kkobukmoving;
        IMoving firymoving;
        Thread boss_attack_thread;

        public static Random rnd = new Random();
        private int exp = 0,att=0;
        private int pikahpnum, pikampnum, kkobukhpnum, kkobukmpnum, firyhpnum, firympnum;
        private int lijamonghpnum, gyaradoshpnum, mangnanyonghpnum, mewshpnum;
        private int fontsize=80;
        private int waittime = 5;
        private string pokename,bossname;
        private int boss_count = 0;
        private int bosshpnum;
        private int turn_conut = 0;
        private bool df_skill_use,df_potion_use,att_potion_use;
        private int User_money;
        private int user_Hp_potion;
        private int Pause_tmp = 0;
        private bool Store_Luckygame;
        private int PauseTime = 3;
        private int User_Df_Porion;
        private int User_Att_Porion;
        
        public int user_money
        {
            get { return User_money; }
            set { User_money = value; }
        }
        public int pausetime
        {
            get { return PauseTime; }
            set { PauseTime = value; }
        }
        public int pause_tmp
        {
            get { return Pause_tmp; }
            set { Pause_tmp = value; }
        }
        public int user_hp_potion
        {
            get { return user_Hp_potion; }
            set { user_Hp_potion = value; }
        }
        public int user_df_potion
        {
            get { return User_Df_Porion; }
            set { User_Df_Porion = value; }
        }
        public bool store_luckygame
        {
            get { return Store_Luckygame; }
            set { Store_Luckygame = value; }
        }
        public int user_att_potion
        {
            get { return User_Att_Porion; }
            set { User_Att_Porion = value; }
        }

        




        private void bosstimer_Tick(object sender, EventArgs e)
        {
            if (bosshpnum <= 0)
            {
                boss_count++;
                if (boss_count == 1)
                {
                    Stage_Stop();
                    pictureBoxlijamong.Visible = false;
                    pictureBoxgyarados.Visible = true;
                    listBoxfightmessage.Items.Add(lijamong.name + " 사망!!");
                    turnchecktimer.Enabled = false;
                    exp += 100;
                    listBoxfightmessage.Items.Add("경험치 100 획득!!");
                    labelBossname.Text = "갸라도스";
                    labelstage2.Text = "STAGE 2";
                    bosshpnum = gyarados.hp; bossname = gyarados.name;
                    labelbossdefense.Text = "" + gyarados.defense;
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                }
                else if (boss_count == 2)
                {
                    Stage_Stop();
                    labelstage3.Text = "STAGE 3";
                    pictureBoxgyarados.Visible = false;
                    pictureBoxmangnanyong.Visible = true;
                    listBoxfightmessage.Items.Add(gyarados.name + " 사망!!");
                    turnchecktimer.Enabled = false;
                    exp += 200;
                    listBoxfightmessage.Items.Add("경험치 200 획득!!");
                    labelBossname.Text = "망나뇽";
                    bosshpnum = mangnanyong.hp; bossname = mangnanyong.name;
                    labelbossdefense.Text = "" + mangnanyong.defense;
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                }
                else if (boss_count == 3)
                {
                    Stage_Stop();

                    labelstage4.Text = "FINAL STAGE";
                    pictureBoxmangnanyong.Visible = false;
                    pictureBoxmews.Visible = true;
                    listBoxfightmessage.Items.Add(mangnanyong.name + " 사망!!");
                    turnchecktimer.Enabled = false;
                    exp += 400;
                    listBoxfightmessage.Items.Add("경험치 400 획득!!");
                    labelBossname.Text = "뮤츠";
                    bosshpnum = mews.hp; bossname = mews.name;
                    labelbossdefense.Text = "" + mews.defense;
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                }
            }

            if (boss_count == 0)
            {
                if (bosshpnum > lijamonghpnum)
                {
                    bosshpnum = lijamonghpnum;
                    labelBossHpNum.Text = "[ " + bosshpnum + "/" + lijamonghpnum + "]";
                }
            }
            else if (boss_count == 1)
            {
                if (bosshpnum > gyaradoshpnum)
                {
                    bosshpnum = gyaradoshpnum;
                    labelBossHpNum.Text = "[ " + bosshpnum + "/" + gyaradoshpnum + "]";
                }
            }
            else if (boss_count == 2)
            {
                if (bosshpnum > mangnanyonghpnum)
                {
                    bosshpnum = mangnanyonghpnum;
                    labelBossHpNum.Text = "[ " + bosshpnum + "/" + mangnanyonghpnum + "]";
                }
            }
            else if (boss_count == 3)
            {
                if (bosshpnum > mewshpnum)
                {
                    bosshpnum = mewshpnum;
                    labelBossHpNum.Text = "[ " + bosshpnum + "/" + mewshpnum + "]";
                }
            }
        }
        

        private void turnchecktimer_Tick(object sender, EventArgs e)
        {
            if (turn_conut % 2 != 0)
            {
                boss_attack_thread = new Thread(Boss_Attack);
                boss_attack_thread.Start();
            }
            else if (turn_conut % 2 == 0)
            {
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    pika.hp += 10;
                    listBoxfightmessage.Items.Add("체력 10회복!!");
                    pika.mp += 20;
                    listBoxfightmessage.Items.Add("마나 20회복!!");
                    if (pika.hp > pikahpnum)
                    {
                        pika.hp = pikahpnum;
                    }
                    if (pika.mp > pikampnum)
                    {
                        pika.mp = pikampnum;
                    }
                    labelPlayerHpNum.Text = "[" + pika.hp + "/" + pikahpnum + "]";
                    labelPlayerMpNum.Text = "[" + pika.mp + "/" + pikampnum + "]";
                }
                else if (pokechoiceform.checkBoxkkobuk.Checked)
                {
                    kkobuk.hp += 10;
                    listBoxfightmessage.Items.Add("체력 10회복!!");
                    kkobuk.mp += 20;
                    listBoxfightmessage.Items.Add("마나 20회복!!");
                    if (kkobuk.hp > kkobukhpnum)
                    {
                        kkobuk.hp = kkobukhpnum;
                    }
                    if (kkobuk.mp > kkobukmpnum)
                    {
                        kkobuk.mp = kkobukmpnum;
                    }
                    labelPlayerHpNum.Text = "[" + kkobuk.hp + "/" + kkobukhpnum + "]";
                    labelPlayerMpNum.Text = "[" + kkobuk.mp + "/" + kkobukmpnum + "]";
                }
                if (pokechoiceform.checkBoxfiry.Checked)
                {
                    firy.hp += 10;
                    listBoxfightmessage.Items.Add("체력 10회복!!");
                    firy.mp += 20;
                    listBoxfightmessage.Items.Add("마나 20회복!!");
                    if (firy.hp > firyhpnum)
                    {
                        firy.hp = firyhpnum;
                    }
                    if (firy.mp > firympnum)
                    {
                        firy.mp = firympnum;
                    }
                    labelPlayerHpNum.Text = "[" + firy.hp + "/" + firyhpnum + "]";
                    labelPlayerMpNum.Text = "[" + firy.mp + "/" + firympnum + "]";
                }
                 int boss_random_heal = rnd.Next(10, 16);
                if (boss_count == 0)
                {
                    lijamong.Random_Heal(boss_random_heal);
                    bosshpnum = lijamong.hp;
                    listBoxfightmessage.Items.Add(bossname + " 체력 " + boss_random_heal + "회복!!");
                    labelBossHpNum.Text = "[" + bosshpnum + "/" + lijamonghpnum + "]";
                }
                else if (boss_count == 1)
                {
                    gyarados.Random_Heal(boss_random_heal);
                    bosshpnum = gyarados.hp;
                    listBoxfightmessage.Items.Add(bossname + " 체력 " + boss_random_heal + "회복!!");
                    labelBossHpNum.Text = "[" + bosshpnum + "/" + gyaradoshpnum + "]";
                }
                if (boss_count == 2)
                {
                    mangnanyong.Random_Heal(boss_random_heal);
                    bosshpnum = mangnanyong.hp;
                    listBoxfightmessage.Items.Add(bossname + " 체력 " + boss_random_heal + "회복!!");
                    labelBossHpNum.Text = "[" + bosshpnum + "/" + mangnanyonghpnum + "]";
                }
                if (boss_count == 3)
                {
                    mews.Random_Heal(boss_random_heal);
                    bosshpnum = mews.hp;
                    listBoxfightmessage.Items.Add(bossname + " 체력 " + boss_random_heal + "회복!!");
                    labelBossHpNum.Text = "[" + bosshpnum + "/" + mewshpnum + "]";
                }
                exp += 20;
                listBoxfightmessage.Items.Add("경험치 20획득!!");
                progressBarPlayerExp.Value = exp;
                labelPlayerExpNum.Text = "[" + exp + "/100]";
                if (df_potion_use == true)
                {
                    if (pokechoiceform.checkBoxpika.Checked)
                    {
                        pika.defense -= 5;
                        labeldfnum.Text = "" + pika.defense;
                    }
                    if (pokechoiceform.checkBoxkkobuk.Checked)
                    {
                        kkobuk.defense -= 5;
                        labeldfnum.Text = "" + kkobuk.defense;
                    }
                    if (pokechoiceform.checkBoxfiry.Checked)
                    {
                        firy.defense -= 5;
                        labeldfnum.Text = "" + firy.defense;
                    }
                    df_potion_use = false;
                }
                if (att_potion_use == true)
                {
                    att -= 10;
                    labelatt_num.Text = "" + att;
                    att_potion_use = false;
                }
                if (df_skill_use == true)
                {
                    if (pokechoiceform.checkBoxpika.Checked)
                    {
                        pika.defense -= pika.Defense_Skill();
                        labeldfnum.Text = "" + pika.defense;
                    }
                    if (pokechoiceform.checkBoxkkobuk.Checked)
                    {
                        kkobuk.defense -= kkobuk.Defense_Skill();
                        labeldfnum.Text = "" + kkobuk.defense;
                    }
                    if (pokechoiceform.checkBoxfiry.Checked)
                    {
                        firy.defense -= firy.Defense_Skill();
                        labeldfnum.Text = "" + firy.defense;
                    }
                    df_skill_use = false;
                }
                store_luckygame = false;
                user_money += 50;
                listBoxfightmessage.Items.Add("50원 획득");
                labelPlayerMoney.Text = "Money " + user_money;
                buttonCommonAtt.Enabled = true;
                buttonDfSkill.Enabled = true;
                buttonSpecailSkill.Enabled = true;
                buttonStrongAtt.Enabled = true;
                buttonhp_potion.Enabled = true;
                buttondf_potion.Enabled = true;
                buttonatt_potion.Enabled = true;
                turnchecktimer.Enabled = false;

             
            }
        }

        public void Level_Up()
        {
            att += 2;
            if (pokechoiceform.checkBoxpika.Checked)
            {
                pika.defense += 1;
                labeldfnum.Text = "" + pika.defense;
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                kkobuk.defense += 1;
                labeldfnum.Text = "" + kkobuk.defense;
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                firy.defense += 1;
                labeldfnum.Text = "" + firy.defense;
            }
            labelatt_num.Text = "" + att;
            user_money += 100;
            listBoxfightmessage.Items.Add("Level Up Money 100 획득");
            listBoxfightmessage.Items.Add("Level Up!! 현재 Level : " + user.level);
        }

        private void exp_check_timer_Tick(object sender, EventArgs e)
        {
            
            if (exp >= 100&&exp<200)
            {
                user.level++;
                Level_Up();
                labelPlayerLev.Text = "Lv." + user.level;
                exp -= 100;
                progressBarPlayerExp.Value = exp;
                labelPlayerExpNum.Text = "[" + exp + "/100]";
            }
            else if (exp >= 200 && exp < 300)
            {
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                exp -= 200;
                progressBarPlayerExp.Value = exp;
                labelPlayerLev.Text = "Lv." + user.level;
                labelPlayerExpNum.Text = "[" + exp + "/100]";
            }
            else if (exp >= 300 && exp < 400)
            {
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                exp -= 300;
                progressBarPlayerExp.Value = exp;
                labelPlayerLev.Text = "Lv." + user.level;
                labelPlayerExpNum.Text = "[" + exp + "/100]";
            }
            else if (exp >= 400 && exp < 500)
            {
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                user.level++;
                Level_Up();
                exp -= 400;
                progressBarPlayerExp.Value = exp;
                labelPlayerLev.Text = "Lv." + user.level;
                labelPlayerExpNum.Text = "[" + exp + "/100]";
            }
            
        }

        

        public void Stage_Stop()
        {
            buttonCommonAtt.Enabled = false;
            buttonDfSkill.Enabled = false;
            buttonSpecailSkill.Enabled = false;
            buttonStrongAtt.Enabled = false;
            stagetimer.Enabled = false;
            waittimer.Enabled = true;
            labelwaittime.Visible = true;
        }

        private void buttonhp_potion_Click(object sender, EventArgs e)
        {
            if (user_hp_potion <= 0)
            {
                listBoxfightmessage.Items.Add("HP 포션이 부족합니다!!");
            }
            if (user_hp_potion > 0)
            {
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    user_hp_potion -= 1;
                    pika.Eat_HpPotion();
                    if (pika.hp > 100)
                    {
                        pika.hp = pikahpnum;
                    }
                    labelhppogion_num.Text = "" + user_hp_potion;
                    labelPlayerHpNum.Text = "[" + pika.hp + "/" + pikahpnum + "]";
                    listBoxfightmessage.Items.Add("HP 포션 사용!! 남은 Hp=" + pika.hp);


                }
                if (pokechoiceform.checkBoxkkobuk.Checked)
                {
                    user_hp_potion -= 1;
                    kkobuk.Eat_HpPotion();
                    if (kkobuk.hp > 100)
                    {
                        kkobuk.hp = kkobukhpnum;
                    }
                    labelhppogion_num.Text = "" + user_hp_potion;
                    labelPlayerHpNum.Text = "[" + kkobuk.hp + "/" + kkobukhpnum + "]";
                    listBoxfightmessage.Items.Add("HP 포션 사용!! 남은 Hp=" + kkobuk.hp);

                }
                if (pokechoiceform.checkBoxfiry.Checked)
                {
                    user_hp_potion -= 1;
                    firy.Eat_HpPotion();
                    if (firy.hp > 100)
                    {
                        firy.hp = kkobukhpnum;
                    }
                    labelhppogion_num.Text = "" + user_hp_potion;
                    labelPlayerHpNum.Text = "[" + firy.hp + "/" + firyhpnum + "]";
                    listBoxfightmessage.Items.Add("HP 포션 사용!! 남은 Hp=" + firy.hp);

                }
                buttonhp_potion.Enabled = false;
            }
        }

        private void pictureBoxpause_Click(object sender, EventArgs e)
        {
            pause_tmp++;
            if (pause_tmp % 2 != 0)
            {
                pausegame.Show();
                buttonatt_potion.Enabled = false;
                buttondf_potion.Enabled = false;
                buttonatt_potion.Enabled = false;
                buttonCommonAtt.Enabled = false;
                buttonStrongAtt.Enabled = false;
                buttonDfSkill.Enabled = false;
                buttonSpecailSkill.Enabled = false;
                pictureBoxpause.Visible = false;
                pictureBoxrestrat.Visible = true;
            }
            
        }

        private void pausetimer_Tick(object sender, EventArgs e)
        {
            pausetime--;
            labelpausetime.Text = "" + pausetime;
            if (pausetime < 1)
            {
               
                buttonatt_potion.Enabled = true;
                buttondf_potion.Enabled = true;
                buttonatt_potion.Enabled = true;
                buttonCommonAtt.Enabled = true;
                buttonStrongAtt.Enabled = true;
                buttonDfSkill.Enabled = true;
                buttonSpecailSkill.Enabled = true;
                labelpausetime.Visible = false;
                pausetimer.Enabled = false;
                pausetime = 4;
            }
        }

        private void pictureBoxstore_Click(object sender, EventArgs e)
        {
            if (store_luckygame == true)
            {
                MessageBox.Show("상점은 턴 당 1회 이용가능합니다.");
            }
            else {
                store = new Store(this);
                store.Show();
            }
        }

        private void Win_Lose_Check_timer_Tick(object sender, EventArgs e)
        {
            if (mews.hp <= 0)
            {
                labelgamewin.Visible = true;
                buttongameexit.Visible = true;
                pictureBoxstore.Visible = false;
                pictureBoxpause.Visible = false;
                pictureBoxmews.Visible = false;
                buttonatt_potion.Visible = false;
                buttonCommonAtt.Visible = false;
                buttonStrongAtt.Visible = false;
                buttonDfSkill.Visible = false;
                buttonSpecailSkill.Visible = false;
                buttondf_potion.Visible = false;
                buttonhp_potion.Visible = false;
                labelcommonatt_mp.Visible = false;
                labeldfskill_mp.Visible = false;
                labelstrongskill_mp.Visible = false;
                labelspcialskill_mp.Visible = false;
                labelattpotion_num.Visible = false;
                gamewhinbgm = new SoundPlayer("Battle_Victory.wav");
                gamewhinbgm.Play();
                Win_Lose_Check_timer.Enabled = false;
            }
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if (pika.hp <= 0)
                {
                    buttongameexit.Visible = true;
                    pictureBoxpika.Visible = false;
                    pictureBoxstore.Visible = false;
                    pictureBoxpause.Visible = false;
                    buttonatt_potion.Visible = false;
                    buttonCommonAtt.Visible = false;
                    buttonStrongAtt.Visible = false;
                    buttonDfSkill.Visible = false;
                    buttonSpecailSkill.Visible = false;
                    buttondf_potion.Visible = false;
                    buttonhp_potion.Visible = false;
                    labelgamelose.Visible = true;
                    labelcommonatt_mp.Visible = false;
                    labeldfskill_mp.Visible = false;
                    labelstrongskill_mp.Visible = false;
                    labelspcialskill_mp.Visible = false;
                    labelattpotion_num.Visible = false;
                    gamelosebgm = new SoundPlayer("Battle_Lose.wav");
                    gamelosebgm.Play();
                    Win_Lose_Check_timer.Enabled = false;
                }
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (kkobuk.hp <= 0)
                {
                    buttongameexit.Visible = true;
                    pictureBoxkkobuk.Visible = false;
                    pictureBoxstore.Visible = false;
                    pictureBoxpause.Visible = false;
                    buttonatt_potion.Visible = false;
                    buttonCommonAtt.Visible = false;
                    buttonStrongAtt.Visible = false;
                    buttonDfSkill.Visible = false;
                    buttonSpecailSkill.Visible = false;
                    buttondf_potion.Visible = false;
                    buttonhp_potion.Visible = false;
                    labelgamelose.Visible = true;
                    labelcommonatt_mp.Visible = false;
                    labeldfskill_mp.Visible = false;
                    labelstrongskill_mp.Visible = false;
                    labelspcialskill_mp.Visible = false;
                    labelattpotion_num.Visible = false;
                    gamelosebgm = new SoundPlayer("Battle_Lose.wav");
                    gamelosebgm.Play();
                    Win_Lose_Check_timer.Enabled = false;
                }
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (firy.hp <= 0)
                {
                    buttongameexit.Visible = true;
                    pictureBoxfiry.Visible = false;
                    pictureBoxstore.Visible = false;
                    pictureBoxpause.Visible = false;
                    buttonatt_potion.Visible = false;
                    buttonCommonAtt.Visible = false;
                    buttonStrongAtt.Visible = false;
                    buttonDfSkill.Visible = false;
                    buttonSpecailSkill.Visible = false;
                    buttondf_potion.Visible = false;
                    buttonhp_potion.Visible = false;
                    labelgamelose.Visible = true;
                    labelcommonatt_mp.Visible = false;
                    labeldfskill_mp.Visible = false;
                    labelstrongskill_mp.Visible = false;
                    labelspcialskill_mp.Visible = false;
                    labelattpotion_num.Visible = false;
                    gamelosebgm = new SoundPlayer("Battle_Lose.wav");
                    gamelosebgm.Play();
                    Win_Lose_Check_timer.Enabled = false;
                }
            }
        }

        private void buttongameexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hp_Potion_Move(object sender, MouseEventArgs e)
        {
            labelbuttoninfo.Text = "HP포션 : 체력을 20 회복합니다.";
            labelbuttoninfo.Visible = true;
        }

        private void Hp_Potion_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Df_Potion_Move(object sender, MouseEventArgs e)
        {
            labelbuttoninfo.Text = "DF포션 : 방어력이 5 증가됩니다.(1턴)";
            labelbuttoninfo.Visible = true;
        }

        private void Df_Potion_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Att_Potion_Move(object sender, MouseEventArgs e)
        {
            labelbuttoninfo.Text = "ATT포션 : 공격력 10 증가(1턴) 마나 20 회복합니다.";
            labelbuttoninfo.Visible = true;
        }

        private void Att_Potion_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Common_Att_Move(object sender, MouseEventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if(boss_count==0)labelbuttoninfo.Text =buttonCommonAtt.Text+ " : "+pokename+"가 "+ (pika.Common_Attack() - lijamong.defense + att)+" 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (pika.Common_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (pika.Common_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (pika.Common_Attack() - mews.defense + att) + " 으로 공격합니다.";

            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (kkobuk.Common_Attack() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (kkobuk.Common_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (kkobuk.Common_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (kkobuk.Common_Attack() - mews.defense + att) + " 으로 공격합니다.";
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (firy.Common_Attack() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (firy.Common_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (firy.Common_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonCommonAtt.Text + " : "+pokename+"가 " + (firy.Common_Attack() - mews.defense + att) + " 으로 공격합니다.";
            }
            labelbuttoninfo.Visible = true;
        }

        private void Common_Att_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Df_Skill_Move(object sender, MouseEventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + pika.Defense_Skill()  + " 이 증가됩니다.(1턴)";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + pika.Defense_Skill()  + " 이 증가됩니다.(1턴)";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + pika.Defense_Skill()  + " 이 증가됩니다.(1턴)";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + pika.Defense_Skill()  + " 이 증가됩니다.(1턴)";

            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + kkobuk.Defense_Skill()  + " 이 증가됩니다.(1턴)";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + kkobuk.Defense_Skill() + " 이 증가됩니다.(1턴)";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + kkobuk.Defense_Skill() + " 이 증가됩니다.(1턴)";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + kkobuk.Defense_Skill() + " 이 증가됩니다.(1턴)";
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + firy.Defense_Skill()  + " 이 증가됩니다.(1턴)";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + firy.Defense_Skill()+ " 이 증가됩니다.(1턴)";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + firy.Defense_Skill()+ " 이 증가됩니다.(1턴)";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonDfSkill.Text + " : "+pokename+"의 방어력이 " + firy.Defense_Skill() + " 이 증가됩니다.(1턴)";
            }
            labelbuttoninfo.Visible = true;
        }

        private void Df_Skill_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Strong_Att_Move(object sender, MouseEventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (pika.Strong_Attack() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (pika.Strong_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (pika.Strong_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (pika.Strong_Attack() - mews.defense + att) + " 으로 공격합니다.";

            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (kkobuk.Strong_Attack() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (kkobuk.Strong_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (kkobuk.Strong_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (kkobuk.Strong_Attack() - mews.defense + att) + " 으로 공격합니다.";
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (firy.Strong_Attack() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (firy.Strong_Attack() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (firy.Strong_Attack() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonStrongAtt.Text + " : " + pokename + "가 " + (firy.Strong_Attack() - mews.defense + att) + " 으로 공격합니다.";
            }
            labelbuttoninfo.Visible = true;
        }

        private void Strong_Att_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void Specail_Skill_Move(object sender, MouseEventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (pika.Special_Skill() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (pika.Special_Skill() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (pika.Special_Skill() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (pika.Special_Skill() - mews.defense + att) + " 으로 공격합니다.";

            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (kkobuk.Special_Skill() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (kkobuk.Special_Skill() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (kkobuk.Special_Skill() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (kkobuk.Special_Skill() - mews.defense + att) + " 으로 공격합니다.";
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (boss_count == 0) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (firy.Special_Skill() - lijamong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 1) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (firy.Special_Skill() - gyarados.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 2) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (firy.Special_Skill() - mangnanyong.defense + att) + " 으로 공격합니다.";
                else if (boss_count == 3) labelbuttoninfo.Text = buttonSpecailSkill.Text + " : " + pokename + "가 " + (firy.Special_Skill() - mews.defense + att) + " 으로 공격합니다.";
            }
            labelbuttoninfo.Visible = true;
        }

        private void Specail_Skill_Leave(object sender, EventArgs e)
        {
            labelbuttoninfo.Visible = false;
        }

        private void pictureBoxrestrat_Click(object sender, EventArgs e)
        {
            pause_tmp++;
            if (pause_tmp % 2 == 0)
            {
                pictureBoxpause.Visible = true;
                pictureBoxrestrat.Visible = false;
                pausegame.Hide();
                pausetimer.Interval = 1000;
                pausetime = 4;
                labelpausetime.Visible = true;
                pausetimer.Enabled = true;
            }
        }

        private void buttondf_potion_Click(object sender, EventArgs e)
        {
            if (user_df_potion <= 0)
            {
                listBoxfightmessage.Items.Add("DF 포션이 부족합니다!!");
            }
            else if (user_df_potion > 0)
            {
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    user_df_potion -= 1;
                    pika.Eat_DfPotion();
                    labeldfpotion_num.Text = "" + user_df_potion;
                    labeldfnum.Text = "" + pika.defense;
                    listBoxfightmessage.Items.Add("DF 포션 사용!! 방어력 5증가!!");


                }
                if (pokechoiceform.checkBoxkkobuk.Checked)
                {
                    user_df_potion -= 1;
                    kkobuk.Eat_DfPotion();
                    labeldfpotion_num.Text = "" + user_df_potion;
                    labeldfnum.Text = "" + kkobuk.defense;
                    listBoxfightmessage.Items.Add("DF 포션 사용!! 방어력 5증가!!");

                }
                if (pokechoiceform.checkBoxfiry.Checked)
                {
                    user_df_potion -= 1;
                    firy.Eat_DfPotion();
                    labeldfpotion_num.Text = "" + user_df_potion;
                    labeldfnum.Text = "" + firy.defense;
                    listBoxfightmessage.Items.Add("DF 포션 사용!! 방어력 5증가!!");

                }
                df_potion_use = true;
                buttondf_potion.Enabled = false;
            }
        }

        private void buttonatt_potion_Click(object sender, EventArgs e)
        {
            if (user_att_potion <= 0)
            {
                listBoxfightmessage.Items.Add("ATT 포션이 부족합니다!!");
            }
            else if (user_att_potion > 0)
            {
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    user_att_potion -= 1;
                    att += 10;
                    pika.Eat_AttPotion();
                    labelattpotion_num.Text = "" + user_att_potion;
                    if (pika.mp > pikampnum)
                    {
                        pika.mp = pikampnum;
                    }
                    labelPlayerMpNum.Text = "[" + pika.mp + "/" + pikampnum + "]";
                    listBoxfightmessage.Items.Add("ATT 포션 사용!! 공격력 10 마나 20증가!!");
                }
                if (pokechoiceform.checkBoxkkobuk.Checked)
                {
                    user_att_potion -= 1;
                    att += 10;
                    kkobuk.Eat_AttPotion();
                    labelattpotion_num.Text = "" + user_att_potion;
                    if (kkobuk.mp > kkobukmpnum)
                    {
                        kkobuk.mp = kkobukmpnum;
                    }
                    labelPlayerMpNum.Text = "[" + kkobuk.mp + "/" + kkobukmpnum + "]";
                    listBoxfightmessage.Items.Add("ATT 포션 사용!! 공격력 10 마나 20증가!!");

                }
                if (pokechoiceform.checkBoxfiry.Checked)
                {
                    user_att_potion -= 1;
                    att += 10;
                    firy.Eat_AttPotion();
                    labelattpotion_num.Text = "" + user_att_potion;
                    if (firy.mp > firympnum)
                    {
                        firy.mp = firympnum;
                    }
                    labelPlayerMpNum.Text = "[" + firy.mp + "/" + firympnum + "]";
                    listBoxfightmessage.Items.Add("ATT 포션 사용!! 공격력 10 마나 20증가!!");

                }
                labelatt_num.Text = "" + att;
                att_potion_use = true;
                buttonatt_potion.Enabled = false;
            }
        }

        

        public FightRoom(PokemonChoice pokemonchoiceform)
        {
            InitializeComponent();
            
            pictureBoxpika.Parent = pictureBoxfightroom;
            pictureBoxlijamong.Parent = pictureBoxfightroom;
            pictureBoxkkobuk.Parent = pictureBoxfightroom;
            pictureBoxfiry.Parent = pictureBoxfightroom;
            pictureBoxgyarados.Parent = pictureBoxfightroom;
            pictureBoxmangnanyong.Parent = pictureBoxfightroom;
            pictureBoxmews.Parent = pictureBoxfightroom;
            labelstage.Parent = pictureBoxfightroom;
            labelwaittime.Parent = pictureBoxfightroom;
            labelstage2.Parent = pictureBoxfightroom;
            labelstage3.Parent = pictureBoxfightroom;
            labelstage4.Parent = pictureBoxfightroom;
            buttonhp_potion.Parent = pictureBoxfightroom;
            labelpausetime.Parent = pictureBoxfightroom;
            pictureBoxstore.Parent = pictureBoxfightroom;
            labelgamelose.Parent = pictureBoxfightroom;
            labelgamewin.Parent = pictureBoxfightroom;
            pictureBoxpause.Parent = pictureBoxfightroom;
            pictureBoxrestrat.Parent = pictureBoxfightroom;

            lijamong = new Lijamong();
            gyarados = new Gyarados();
            mangnanyong = new Mangnanyong();
            mews = new Mews();
            pokechoiceform =pokemonchoiceform;
            pausegame = new PauseGame(this);
            user = new User();
            fightroombgm = new SoundPlayer("Figthroom.wav");
            panelPlayerState.BringToFront();

        }

        

        private void FightRoomForm_Load(object sender, EventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)
            {
                pictureBoxpika.Visible = true;
                pika = new Pikachu();
                pika.hp = 100; pika.mp = 75; pika.defense = 6;  pika.name = "피카츄";
                pikahpnum = pika.hp; pikampnum = pika.mp; pokename = pika.name;
                
                labelPlayerHpNum.Text = "[" + pika.hp + "/"+pikahpnum+"]";
                labelPlayerMpNum.Text = "[" + pika.mp + "/"+pikampnum+"]";
                labelPokemonname.Text = "이름: " + pika.name;
                labeldfnum.Text = "" + pika.defense;
                buttonCommonAtt.Text = "몸통박치기";
                buttonDfSkill.Text = "단단해지기";
                buttonStrongAtt.Text = "아이언테일";
                buttonSpecailSkill.Text = "백만볼트";
                labeldfskill_mp.Text = "" + 31;
                labelstrongskill_mp.Text = "" + 25;
                labelspcialskill_mp.Text = "" + 45;
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                pictureBoxkkobuk.Visible = true;
                kkobuk = new Kkobuk();
                kkobuk.hp = 100; kkobuk.mp = 80; kkobuk.defense = 7;  kkobuk.name = "꼬부기";
                kkobukhpnum = kkobuk.hp; kkobukmpnum=kkobuk.mp; pokename = kkobuk.name;
                
               
                labelPlayerHpNum.Text = "[" + kkobuk.hp + "/"+kkobukhpnum+"]";
                labelPlayerMpNum.Text = "[" + kkobuk.mp + "/"+kkobukmpnum+"]";
                labelPokemonname.Text = "이름: " + kkobuk.name;
                labeldfnum.Text = "" + kkobuk.defense;
                buttonCommonAtt.Text = "깨물기";
                buttonDfSkill.Text = "단단해지기";
                buttonStrongAtt.Text = "물대포";
                buttonSpecailSkill.Text = "하이드로펌프";
                labeldfskill_mp.Text = "" + 31;
                labelstrongskill_mp.Text = "" + 27;
                labelspcialskill_mp.Text = "" + 47;
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                pictureBoxfiry.Visible = true;
                firy = new Firy();
                firy.hp = 100; firy.mp = 85; exp = 0; firy.defense = 5; firy.name = "파이리";
                firyhpnum = firy.hp; firympnum = firy.mp; pokename = firy.name;
                labelPlayerHpNum.Text = "[" + firy.hp + "/"+firyhpnum+"]";
                labelPlayerMpNum.Text = "[" + firy.mp + "/"+firympnum+"]";
                labelPokemonname.Text = "이름: " + firy.name;
                labeldfnum.Text = "" + firy.defense;
                buttonCommonAtt.Text = "할퀴기";
                buttonDfSkill.Text = "단단해지기";
                buttonStrongAtt.Text = "불꽃세례";
                buttonSpecailSkill.Text = "화염방사";
                labeldfskill_mp.Text = "" + 31;
                labelstrongskill_mp.Text = "" + 29;
                labelspcialskill_mp.Text = "" + 50;
            }

            labelatt_num.Text = "" + att;
            progressBarPlayerExp.Value = exp;
            labelPlayerExpNum.Text = "[" + exp + "/100]";

            labelusername.Text = "" + pokechoiceform.user_name;
            user_money = user.money;
            user_hp_potion = user.hp_potion;
            user_df_potion = user.df_potion;
            user_att_potion = user.att_potion;
            labelPlayerMoney.Text = "Money : " + user_money;
            labelPlayerLev.Text = "LV." + user.level;

            lijamong.name = "리자몽"; gyarados.name = "갸라도스"; mangnanyong.name = "망나뇽"; mews.name = "뮤츠";
            bossname = lijamong.name;
            lijamong.hp = 100; gyarados.hp = 150; mangnanyong.hp = 200; mews.hp = 300;
            lijamong.defense = 5; gyarados.defense = 10; mangnanyong.defense = 15; mews.defense = 18;
            lijamonghpnum = lijamong.hp; bosshpnum = lijamong.hp;
            gyaradoshpnum = gyarados.hp; mangnanyonghpnum = mangnanyong.hp; mewshpnum = mews.hp;
            labelBossname.Text = "" + lijamong.name;
            labelbossdefense.Text = ""+lijamong.defense;
            labelBossHpNum.Text = "[" + lijamong.hp + "/" + lijamonghpnum + "]";

            
            
        }

        

        private void FightRoom_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void waittimer_Tick(object sender, EventArgs e)
        {
            labelwaittime.Text = "" + waittime;
            waittime--;
            if (waittime < 0)
            {
                if (boss_count == 0)
                {
                    labelstage.Visible = true;
                }
                else if (boss_count == 1)
                {
                    labelstage2.Visible = true;
                }
                else if (boss_count ==2)
                {
                    labelstage3.Visible = true;
                }
                else if (boss_count == 3)
                {
                    labelstage4.Visible = true;
                }
                labelwaittime.Visible = false;
                waittimer.Enabled = false;
                stagetimer.Enabled = true;
                buttonCommonAtt.Enabled = true;
                buttonDfSkill.Enabled = true;
                buttonStrongAtt.Enabled = true;
                buttonSpecailSkill.Enabled = true;
                buttonatt_potion.Enabled = true;
                buttondf_potion.Enabled = true;
                buttonhp_potion.Enabled = true;
                pictureBoxpause.Visible = true;
                pictureBoxstore.Visible = true;
                pictureBoxrestrat.Visible = true;
                
                listBoxfightmessage.Items.Clear();
                waittime = 5;
                fightroombgm.PlayLooping();
            }
        }
        private void buttonCommonAtt_Click(object sender, EventArgs e)
        {
            listBoxfightmessage.Items.Clear();
            if (pokechoiceform.checkBoxpika.Checked)
            {
                if (boss_count == 0)
                {
                    lijamong.Hit(pika.Common_Attack()-lijamong.defense+att);
                    labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                    bosshpnum = bosshpnum - pika.Common_Attack() + lijamong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 몸통박치기(" + (pika.Common_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 1)
                {
                    gyarados.Hit(pika.Common_Attack()-gyarados.defense + att);
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                    bosshpnum = bosshpnum - pika.Common_Attack() + gyarados.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 몸통박치기(" + (pika.Common_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 2)
                {
                    mangnanyong.Hit(pika.Common_Attack()-mangnanyong.defense + att);
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                    bosshpnum = bosshpnum - pika.Common_Attack() + mangnanyong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 몸통박치기(" + (pika.Common_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else
                {
                    mews.Hit(pika.Common_Attack()-mews.defense + att);
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                    bosshpnum = bosshpnum - pika.Common_Attack() + mews.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 몸통박치기(" + (pika.Common_Attack() - mews.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
               
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (boss_count == 0)
                {
                    lijamong.Hit(kkobuk.Common_Attack() - lijamong.defense + att);
                    labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Common_Attack() + lijamong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 깨물기(" + (kkobuk.Common_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 1)
                {
                    gyarados.Hit(kkobuk.Common_Attack()-gyarados.defense + att);
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Common_Attack() + gyarados.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 깨물기(" + (kkobuk.Common_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 2)
                {
                    mangnanyong.Hit(kkobuk.Common_Attack() - mangnanyong.defense + att);
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Common_Attack() + mangnanyong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 깨물기(" + (kkobuk.Common_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if(boss_count==3)
                {
                    mews.Hit(kkobuk.Common_Attack() - mews.defense + att);
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Common_Attack() + mews.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 깨물기(" + (kkobuk.Common_Attack() - kkobuk.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
            }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                if (boss_count == 0)
                {
                    lijamong.Hit(firy.Common_Attack() - lijamong.defense + att);
                    labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                    bosshpnum = bosshpnum - firy.Common_Attack() + lijamong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 할퀴기(" + (firy.Common_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 1)
                {
                    gyarados.Hit(firy.Common_Attack() - gyarados.defense + att);
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                    bosshpnum = bosshpnum - firy.Common_Attack() + gyarados.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 할퀴기(" + (firy.Common_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else if (boss_count == 2)
                {
                    mangnanyong.Hit(firy.Common_Attack()-mangnanyong.defense + att);
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                    bosshpnum = bosshpnum - firy.Common_Attack() + mangnanyong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 할퀴기(" + (firy.Common_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
                else
                {
                    mews.Hit(firy.Common_Attack() - mews.defense + att);
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                    bosshpnum = bosshpnum - firy.Common_Attack() + mews.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 할퀴기(" + (firy.Common_Attack() - mews.defense + att) + ") 사용 " + bossname + " Hp= " + bosshpnum);
                }
            }
            buttonCommonAtt.Enabled = false;
            buttonDfSkill.Enabled = false;
            buttonSpecailSkill.Enabled = false;
            buttonStrongAtt.Enabled = false;
            buttonatt_potion.Enabled = false;
            buttondf_potion.Enabled = false;
            buttonhp_potion.Enabled = false;
            turn_conut = 0;
            turn_conut++;
            turnchecktimer.Enabled = true;
            turnchecktimer.Interval = 1500;
            
    }
        private void buttonDfSkill_Click(object sender, EventArgs e)
        {
          
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    if (pika.mp < 31)
                    {
                        listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                    }
                    else {
                    listBoxfightmessage.Items.Clear();
                    pika.defense += pika.Defense_Skill();
                    pika.mp -= 31;
                    listBoxfightmessage.Items.Add("피카츄 Mp 31 사용 남은 Mp=" + pika.mp);
                    labelPlayerMpNum.Text = "[" + pika.mp + "/" + pikampnum + "]";
                    listBoxfightmessage.Items.Add(pokename + "가 단단해지기 방어력 " + pika.Defense_Skill() + " 증가 !! 방어력" + pika.defense);
                    labeldfnum.Text = "" + pika.defense;
                    df_skill_use = true;
                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }
            }
             
            else if (pokechoiceform.checkBoxkkobuk.Checked)
            {
                if (kkobuk.mp < 31)
                    {
                        listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                    }
                else {
                    listBoxfightmessage.Items.Clear();
                    kkobuk.defense += kkobuk.Defense_Skill();
                    kkobuk.mp -= 31;
                    listBoxfightmessage.Items.Add("꼬부기 Mp 31 사용 남은 Mp=" + kkobuk.mp);
                    labelPlayerMpNum.Text = "[" + kkobuk.mp + "/" + kkobukmpnum + "]";
                    listBoxfightmessage.Items.Add(pokename + "가 단단해지기 방어력 " + kkobuk.Defense_Skill() + " 증가 !! 방어력" + kkobuk.defense);
                    labeldfnum.Text = "" + kkobuk.defense;
                    df_skill_use = true;
                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }
                }
            else if (pokechoiceform.checkBoxfiry.Checked)
            {
                    if (firy.mp < 31)
                    {
                        listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                    }
                    else {
                    listBoxfightmessage.Items.Clear();
                    firy.defense += firy.Defense_Skill();
                    firy.mp -= 31;
                    listBoxfightmessage.Items.Add("파이리 Mp 31 사용 남은 Mp=" + firy.mp);
                    labelPlayerMpNum.Text = "[" + firy.mp + "/" + firympnum + "]";
                    listBoxfightmessage.Items.Add(pokename + "가 단단해지기 방어력 " + firy.Defense_Skill() + " 증가 !! 방어력" + firy.defense);
                    labeldfnum.Text = "" + firy.defense;
                    df_skill_use = true;
                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }
                }
            
           

        }
        private void buttonStrongAtt_Click(object sender, EventArgs e)
        {
            
            if (pokechoiceform.checkBoxpika.Checked)//---------------------피카츄--------------------------------
            {
                if (pika.mp < 25)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else {
                    listBoxfightmessage.Items.Clear();
                pika.mp -= 25;
                listBoxfightmessage.Items.Add("피카츄 Mp 25 사용 남은 Mp=" + pika.mp);
                labelPlayerMpNum.Text = "[" + pika.mp + "/" + pikampnum + "]";
                if (boss_count == 0)
                {
                    lijamong.Hit(pika.Strong_Attack() - lijamong.defense + att);
                    labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                    bosshpnum = bosshpnum - pika.Strong_Attack() + lijamong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (pika.Strong_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 1)
                {
                    gyarados.Hit(pika.Strong_Attack() - gyarados.defense + att);
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                    bosshpnum = bosshpnum - pika.Strong_Attack() + gyarados.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (pika.Strong_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 2)
                {
                    mangnanyong.Hit(pika.Strong_Attack() - mangnanyong.defense + att);
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                    bosshpnum = bosshpnum - pika.Strong_Attack() + mangnanyong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (pika.Strong_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 3)
                {
                    mews.Hit(pika.Strong_Attack() - mews.defense + att);
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                    bosshpnum = bosshpnum - pika.Strong_Attack() + mews.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (pika.Strong_Attack() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                buttonCommonAtt.Enabled = false;
                buttonDfSkill.Enabled = false;
                buttonSpecailSkill.Enabled = false;
                buttonStrongAtt.Enabled = false;
                buttonatt_potion.Enabled = false;
                buttondf_potion.Enabled = false;
                buttonhp_potion.Enabled = false;
                turn_conut = 0;
                turn_conut++;
                turnchecktimer.Enabled = true;
                turnchecktimer.Interval = 1500;
            }
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)//----------------------------꼬부기----------------------------------
            {
                if (kkobuk.mp < 27)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else {
                    listBoxfightmessage.Items.Clear();
                    kkobuk.mp -= 27;
                listBoxfightmessage.Items.Add("꼬부기 Mp 27 사용 남은 Mp=" + kkobuk.mp);
                labelPlayerMpNum.Text = "[" + kkobuk.mp + "/" + kkobukmpnum + "]";
                if (boss_count == 0)
                {
                    lijamong.Hit(kkobuk.Strong_Attack() - lijamong.defense + att);
                    labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Strong_Attack() + lijamong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (kkobuk.Strong_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 1)
                {
                    gyarados.Hit(kkobuk.Strong_Attack() - gyarados.defense + att);
                    labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Strong_Attack() + gyarados.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (kkobuk.Strong_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 2)
                {
                    mangnanyong.Hit(kkobuk.Strong_Attack() - mangnanyong.defense + att);
                    labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Strong_Attack() + mangnanyong.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (kkobuk.Strong_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                else if (boss_count == 3)
                {
                    mews.Hit(kkobuk.Strong_Attack() - mews.defense + att);
                    labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                    bosshpnum = bosshpnum - kkobuk.Strong_Attack() + mews.defense;
                    listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (kkobuk.Strong_Attack() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                }
                buttonCommonAtt.Enabled = false;
                buttonDfSkill.Enabled = false;
                buttonSpecailSkill.Enabled = false;
                buttonStrongAtt.Enabled = false;
                buttonatt_potion.Enabled = false;
                buttondf_potion.Enabled = false;
                buttonhp_potion.Enabled = false;
                turn_conut = 0;
                turn_conut++;
                turnchecktimer.Enabled = true;
                turnchecktimer.Interval = 1500;
            }
            }
            else if (pokechoiceform.checkBoxfiry.Checked)//----------------------------파이리----------------------------------
            {
                if (firy.mp < 29)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else
                {
                    listBoxfightmessage.Items.Clear();
                    firy.mp -= 29;
                    listBoxfightmessage.Items.Add("파이리 Mp= 29 사용 남은 Mp" + firy.mp);
                    labelPlayerMpNum.Text = "[" + firy.mp + "/" + firympnum + "]";
                    if (boss_count == 0)
                    {
                        lijamong.Hit(firy.Strong_Attack() - lijamong.defense + att);
                        labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                        bosshpnum = bosshpnum - firy.Strong_Attack() + lijamong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (firy.Strong_Attack() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 1)
                    {
                        gyarados.Hit(firy.Strong_Attack() - gyarados.defense + att);
                        labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                        bosshpnum = bosshpnum - firy.Strong_Attack() + gyarados.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (firy.Strong_Attack() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 2)
                    {
                        mangnanyong.Hit(firy.Strong_Attack() - mangnanyong.defense + att);
                        labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                        bosshpnum = bosshpnum - firy.Strong_Attack() + mangnanyong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (firy.Strong_Attack() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 3)
                    {
                        mews.Hit(firy.Strong_Attack() - mews.defense + att);
                        labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                        bosshpnum = bosshpnum - firy.Strong_Attack() + mews.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonStrongAtt.Text + "(" + (firy.Strong_Attack() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }

                }
            
        }
        private void buttonSpecailSkill_Click(object sender, EventArgs e)
        {
            if (pokechoiceform.checkBoxpika.Checked)//---------------------피카츄--------------------------------
            {
                if (pika.mp < 45)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else
                {
                    listBoxfightmessage.Items.Clear();
                    pika.mp -= 45;
                    listBoxfightmessage.Items.Add("피카츄 Mp 45 사용 남은 Mp=" + pika.mp);
                    labelPlayerMpNum.Text = "[" + pika.mp + "/" + pikampnum + "]";
                    if (boss_count == 0)
                    {
                        lijamong.Hit(pika.Special_Skill() - lijamong.defense + att);
                        labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                        bosshpnum = bosshpnum - pika.Special_Skill() + lijamong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (pika.Special_Skill() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 1)
                    {
                        gyarados.Hit(pika.Special_Skill() - gyarados.defense + att);
                        labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                        bosshpnum = bosshpnum - pika.Special_Skill() + gyarados.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (pika.Special_Skill() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 2)
                    {
                        mangnanyong.Hit(pika.Special_Skill() - mangnanyong.defense + att);
                        labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                        bosshpnum = bosshpnum - pika.Special_Skill() + mangnanyong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (pika.Special_Skill() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 3)
                    {
                        mews.Hit(pika.Special_Skill() - mews.defense + att);
                        labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                        bosshpnum = bosshpnum - pika.Special_Skill() + mews.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (pika.Special_Skill() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }

                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }
            }
            else if (pokechoiceform.checkBoxkkobuk.Checked)//----------------------------꼬부기----------------------------------
            {
                if (kkobuk.mp < 47)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else {
                    listBoxfightmessage.Items.Clear();
                    kkobuk.mp -= 47;
                    listBoxfightmessage.Items.Add("꼬부기 Mp 47 사용 남은 Mp=" + kkobuk.mp);
                    labelPlayerMpNum.Text = "[" + kkobuk.mp + "/" + kkobukmpnum + "]";
                    if (boss_count == 0)
                    {
                        lijamong.Hit(kkobuk.Special_Skill() - lijamong.defense + att);
                        labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                        bosshpnum = bosshpnum - kkobuk.Special_Skill() + lijamong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (kkobuk.Special_Skill() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 1)
                    {
                        gyarados.Hit(kkobuk.Special_Skill() - gyarados.defense + att);
                        labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                        bosshpnum = bosshpnum - kkobuk.Special_Skill() + gyarados.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (kkobuk.Special_Skill() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 2)
                    {
                        mangnanyong.Hit(kkobuk.Special_Skill() - mangnanyong.defense + att);
                        labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                        bosshpnum = bosshpnum - kkobuk.Special_Skill() + mangnanyong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (kkobuk.Special_Skill() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 3)
                    {
                        mews.Hit(kkobuk.Special_Skill() - mews.defense + att);
                        labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                        bosshpnum = bosshpnum - kkobuk.Special_Skill() + mews.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (kkobuk.Special_Skill() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                  }
            }
            else if (pokechoiceform.checkBoxfiry.Checked)//----------------------------파이리----------------------------------
            {
                if (firy.mp < 50)
                {
                    listBoxfightmessage.Items.Add(pokename + "의 Mp가 부족합니다!!");
                }
                else
                {
                    listBoxfightmessage.Items.Clear();
                    firy.mp -= 50;
                    listBoxfightmessage.Items.Add("파이리 Mp 50 사용 남은 Mp=" + firy.mp);
                    labelPlayerMpNum.Text = "[" + firy.mp + "/" + firympnum + "]";
                    if (boss_count == 0)
                    {
                        lijamong.Hit(firy.Special_Skill() - lijamong.defense + att);
                        labelBossHpNum.Text = "[ " + lijamong.hp + "/" + lijamonghpnum + "]";
                        bosshpnum = bosshpnum - firy.Special_Skill() + lijamong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (firy.Special_Skill() - lijamong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 1)
                    {
                        gyarados.Hit(firy.Special_Skill() - gyarados.defense + att);
                        labelBossHpNum.Text = "[ " + gyarados.hp + "/" + gyaradoshpnum + "]";
                        bosshpnum = bosshpnum - firy.Special_Skill() + gyarados.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (firy.Special_Skill() - gyarados.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 2)
                    {
                        mangnanyong.Hit(firy.Special_Skill() - mangnanyong.defense + att);
                        labelBossHpNum.Text = "[ " + mangnanyong.hp + "/" + mangnanyonghpnum + "]";
                        bosshpnum = bosshpnum - firy.Special_Skill() + mangnanyong.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (firy.Special_Skill() - mangnanyong.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }
                    else if (boss_count == 3)
                    {
                        mews.Hit(firy.Special_Skill() - mews.defense + att);
                        labelBossHpNum.Text = "[ " + mews.hp + "/" + mewshpnum + "]";
                        bosshpnum = bosshpnum - firy.Special_Skill() + mews.defense;
                        listBoxfightmessage.Items.Add(pokename + "가 " + buttonSpecailSkill.Text + "(" + (firy.Special_Skill() - mews.defense + att) + ") 사용 " + bossname + " Hp=" + bosshpnum);
                    }

                    buttonCommonAtt.Enabled = false;
                    buttonDfSkill.Enabled = false;
                    buttonSpecailSkill.Enabled = false;
                    buttonStrongAtt.Enabled = false;
                    buttonatt_potion.Enabled = false;
                    buttondf_potion.Enabled = false;
                    buttonhp_potion.Enabled = false;
                    turn_conut = 0;
                    turn_conut++;
                    turnchecktimer.Enabled = true;
                    turnchecktimer.Interval = 1500;
                }
            }
            
            
        }

        private void Boss_Attack()
        {
            int boss_skill = rnd.Next(0, 10);
            int boss_strong_att = rnd.Next(0, 9);
            if (boss_strong_att == 1)
            {
                if (pokechoiceform.checkBoxpika.Checked)
                {
                    pikamoving = pika;
                    pikamoving.Moving();
                    listBoxfightmessage.Items.Add(pokename + "가 " + bossname + "의 공격을 피했습니다.");
                }
                else if (pokechoiceform.checkBoxkkobuk.Checked)
                {
                    kkobukmoving = kkobuk;
                    kkobukmoving.Moving();
                    listBoxfightmessage.Items.Add(pokename + "가 " + bossname + "의 공격을 피했습니다.");
                }
                if (pokechoiceform.checkBoxfiry.Checked)
                {
                    firymoving = firy;
                    firymoving.Moving();
                    listBoxfightmessage.Items.Add(pokename + "가 " + bossname + "의 공격을 피했습니다.");
                }

            }
            else { 
            if (pokechoiceform.checkBoxpika.Checked) // ------------------ 피카츄 ----------------------
            {
                if (boss_count == 0)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        pika.Hit(lijamong.Common_Attack() - pika.defense);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (lijamong.Common_Attack() - pika.defense) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        pika.Hit(lijamong.Strong_Attack() - pika.defense);
                        listBoxfightmessage.Items.Add(bossname + " 물어뜯기(" + (lijamong.Strong_Attack() - pika.defense) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        pika.Hit(lijamong.Special_Skill() - pika.defense);
                        listBoxfightmessage.Items.Add(bossname + " 화염방사(" + (lijamong.Special_Skill() - pika.defense) + ")" + pokename + " HP: " + pika.hp);
                    }
                }
                else if (boss_count == 1)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        pika.Hit(gyarados.Common_Attack() - pika.defense + 3);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (gyarados.Common_Attack() - pika.defense+3) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        pika.Hit(gyarados.Strong_Attack() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 물대포(" + (gyarados.Strong_Attack() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        pika.Hit(gyarados.Special_Skill() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 파도타기(" + (gyarados.Special_Skill() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                }
                else if (boss_count == 2)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        pika.Hit(mangnanyong.Common_Attack() - pika.defense + 5);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mangnanyong.Common_Attack() - pika.defense+5) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        pika.Hit(mangnanyong.Strong_Attack() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 용의분노(" + (mangnanyong.Strong_Attack() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        pika.Hit(mangnanyong.Special_Skill() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 파괴광선(" + (mangnanyong.Special_Skill() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                }
                else if (boss_count == 3)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        pika.Hit(mews.Common_Attack() - pika.defense+8);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mews.Common_Attack() - pika.defense + 8) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        pika.Hit(mews.Strong_Attack() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 염동력(" + (mews.Strong_Attack() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        pika.Hit(mews.Special_Skill() - pika.defense );
                        listBoxfightmessage.Items.Add(bossname + " 미래예지(" + (mews.Special_Skill() - pika.defense ) + ")" + pokename + " HP: " + pika.hp);
                    }
                }

                labelPlayerHpNum.Text = "[" + pika.hp + "/" + pikahpnum + "]";

            }
            else if (pokechoiceform.checkBoxkkobuk.Checked) //------------------ 꼬부기 --------------------
            {
                if (boss_count == 0)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        kkobuk.Hit(lijamong.Common_Attack() - kkobuk.defense);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (lijamong.Common_Attack() - kkobuk.defense) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        kkobuk.Hit(lijamong.Strong_Attack() - kkobuk.defense);
                        listBoxfightmessage.Items.Add(bossname + " 물어뜯기(" + (lijamong.Strong_Attack() - kkobuk.defense) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        kkobuk.Hit(lijamong.Special_Skill() - kkobuk.defense);
                        listBoxfightmessage.Items.Add(bossname + " 화염방사(" + (lijamong.Special_Skill() - kkobuk.defense) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                }
                else if (boss_count == 1)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        kkobuk.Hit(gyarados.Common_Attack() - kkobuk.defense+3);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (gyarados.Common_Attack() - kkobuk.defense + 3) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        kkobuk.Hit(gyarados.Strong_Attack() - kkobuk.defense );
                        listBoxfightmessage.Items.Add(bossname + " 물대포(" + (gyarados.Strong_Attack() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        kkobuk.Hit(gyarados.Special_Skill() - kkobuk.defense + 3);
                        listBoxfightmessage.Items.Add(bossname + " 파도타기(" + (gyarados.Special_Skill() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                }
                else if (boss_count == 2)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        kkobuk.Hit(mangnanyong.Common_Attack() - kkobuk.defense + 5);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mangnanyong.Common_Attack() - kkobuk.defense + 5) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        kkobuk.Hit(mangnanyong.Strong_Attack() - kkobuk.defense );
                        listBoxfightmessage.Items.Add(bossname + " 용의분노(" + (mangnanyong.Strong_Attack() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        kkobuk.Hit(mangnanyong.Special_Skill() - kkobuk.defense );
                        listBoxfightmessage.Items.Add(bossname + " 파괴광선(" + (mangnanyong.Special_Skill() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                }
                else if (boss_count == 3)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        kkobuk.Hit(mews.Common_Attack() - kkobuk.defense + 8);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mews.Common_Attack() - kkobuk.defense + 8) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        kkobuk.Hit(mews.Strong_Attack() - kkobuk.defense );
                        listBoxfightmessage.Items.Add(bossname + " 염동력(" + (mews.Strong_Attack() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        kkobuk.Hit(mews.Special_Skill() - kkobuk.defense );
                        listBoxfightmessage.Items.Add(bossname + " 미래예지(" + (mews.Special_Skill() - kkobuk.defense ) + ")" + pokename + " HP: " + kkobuk.hp);
                    }
                    labelPlayerHpNum.Text = "[" + kkobuk.hp + "/" + kkobukhpnum + "]";

                }
            }
            else if (pokechoiceform.checkBoxfiry.Checked) //---------------------파이리-----------------------------
            {
                if (boss_count == 0)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        firy.Hit(lijamong.Common_Attack() - firy.defense);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (lijamong.Common_Attack() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        firy.Hit(lijamong.Strong_Attack() - firy.defense);
                        listBoxfightmessage.Items.Add(bossname + " 물어뜯기(" + (lijamong.Strong_Attack() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        firy.Hit(lijamong.Special_Skill() - firy.defense);
                        listBoxfightmessage.Items.Add(bossname + " 화염방사(" + (lijamong.Special_Skill() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                }
                else if (boss_count == 1)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        firy.Hit(gyarados.Common_Attack() - firy.defense + 3);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (gyarados.Common_Attack() - firy.defense + 3) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        firy.Hit(gyarados.Strong_Attack() - firy.defense );
                        listBoxfightmessage.Items.Add(bossname + " 물대포(" + (gyarados.Strong_Attack() - firy.defense ) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        firy.Hit(gyarados.Special_Skill() - firy.defense );
                        listBoxfightmessage.Items.Add(bossname + " 파도타기(" + (gyarados.Special_Skill() - firy.defense ) + ")" + pokename + " HP: " + firy.hp);
                    }
                }
                else if (boss_count == 2)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        firy.Hit(mangnanyong.Common_Attack() - firy.defense + 5);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mangnanyong.Common_Attack() - firy.defense +5) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        firy.Hit(mangnanyong.Strong_Attack() - firy.defense );
                        listBoxfightmessage.Items.Add(bossname + " 용의분노(" + (mangnanyong.Strong_Attack() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        firy.Hit(mangnanyong.Special_Skill() - firy.defense );
                        listBoxfightmessage.Items.Add(bossname + " 파괴광선(" + (mangnanyong.Special_Skill() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                }
                else if (boss_count == 3)
                {
                    if (boss_skill == 0 || boss_skill == 1 || boss_skill == 2 || boss_skill == 3 || boss_skill == 4)
                    {
                        firy.Hit(mews.Common_Attack() - firy.defense+8);
                        listBoxfightmessage.Items.Add(bossname + " 일반공격(" + (mews.Common_Attack() - firy.defense + 8) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 5 || boss_skill == 6 || boss_skill == 7)
                    {
                        firy.Hit(mews.Strong_Attack() - firy.defense);
                        listBoxfightmessage.Items.Add(bossname + " 염동력(" + (mews.Strong_Attack() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }
                    else if (boss_skill == 8 || boss_skill == 9)
                    {
                        firy.Hit(mews.Special_Skill() - firy.defense);
                        listBoxfightmessage.Items.Add(bossname + " 미래예지(" + (mews.Special_Skill() - firy.defense) + ")" + pokename + " HP: " + firy.hp);
                    }

                    labelPlayerHpNum.Text = "[" + firy.hp + "/" + firyhpnum + "]";

                }
            }
            }
            turn_conut++;
        }

        private void stagetimer_Tick(object sender, EventArgs e)
        {
            if (boss_count == 0)
            {
                labelstage.Font = new Font(labelstage.Font.FontFamily, fontsize);
                fontsize -= 5;
            }
            else if (boss_count == 1)
            {
                labelstage2.Font = new Font(labelstage.Font.FontFamily, fontsize);
                fontsize -= 5;
            }
            else if (boss_count == 2)
            {
                labelstage3.Font = new Font(labelstage.Font.FontFamily, fontsize);
                fontsize -= 5;
            }
            else if (boss_count == 3)
            {
                labelstage4.Font = new Font(labelstage.Font.FontFamily, fontsize);
                fontsize -= 5;
            }
            if (fontsize == 0)
            {
                fontsize = 80;
                labelstage.Visible = false;
                labelstage2.Visible = false;
                labelstage3.Visible = false;
                labelstage4.Visible = false;
                stagetimer.Enabled = false;
                
            }

        
        }
    }
}
