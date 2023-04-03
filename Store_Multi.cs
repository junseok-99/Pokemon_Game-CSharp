using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDungeonGame
{
    public partial class Store_Multi : Form
    {
        public static Random rnd = new Random();
        FightRoom_multi_ multifightform = null;
        int hp_price = 0, df_price = 0, att_price = 0, sum_price = 0;
        int hp_potion_count, df_potion_count, att_potion_count;
        public Store_Multi(FightRoom_multi_ multiform)
        {
            InitializeComponent();
            multifightform = multiform;
        }

        private void numericUpDownhppotion_ValueChanged(object sender, EventArgs e)
        {
            hp_potion_count = (int)numericUpDownhppotion.Value;
            hp_price = 250 * hp_potion_count;
            sum_price = hp_price + df_price + att_price;
            labelcurrentprice_num.Text = "" + sum_price + "원";
        }

        private void Store_Multi_Load(object sender, EventArgs e)
        {
            labelmoneynum.Text = "" + multifightform.user_money;
            labelluckymoney.Visible = false;
            labelluckystate.Visible = false;
            buttonluckygame.Enabled = true;
            numericUpDownattpotion.Value = 0;
            numericUpDowndfpotion.Value = 0;
            numericUpDownhppotion.Value = 0;
        }

        private void numericUpDowndfpotion_ValueChanged(object sender, EventArgs e)
        {
            df_potion_count = (int)numericUpDowndfpotion.Value;
            df_price = 300 * df_potion_count;
            sum_price = hp_price + df_price + att_price;
            labelcurrentprice_num.Text = "" + sum_price + "원";
        }

        private void numericUpDownattpotion_ValueChanged(object sender, EventArgs e)
        {
            att_potion_count = (int)numericUpDownattpotion.Value;
            att_price = 350 * att_potion_count;
            sum_price = hp_price + df_price + att_price;
            labelcurrentprice_num.Text = "" + sum_price + "원";
        }

        private void buttonluckygame_Click(object sender, EventArgs e)
        {
            int rnd_num = rnd.Next(0, 6);
            if (rnd_num == 3)
            {
                labelluckymoney.Visible = true;
                labelluckystate.Visible = true;
                labelluckystate.Text = "성공!";
                labelmoneynum.Text = "" + multifightform.user_money;
                multifightform.user_money += 500;
                multifightform.labelPlayerMoney.Text = "Money " + multifightform.user_money;
            }
            else
            {
                labelluckystate.Visible = true;
                labelluckystate.Text = "실패!";
            }
            buttonluckygame.Enabled = false;
            multifightform.store_luckygame = true;
        }

        private void buttonbuy_Click(object sender, EventArgs e)
        {
            if (multifightform.user_money >= sum_price)
            {

                if (MessageBox.Show("구매 하시겠습니까??", "BUY Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int hp, df, att;
                    multifightform.user_money -= sum_price;
                    multifightform.labelPlayerMoney.Text = "Money " + multifightform.user_money;
                    hp = multifightform.user_hp_potion += hp_potion_count;
                    df = multifightform.user_df_potion += df_potion_count;
                    att = multifightform.user_att_potion += att_potion_count;
                    multifightform.labelhppogion_num.Text = "" + hp;
                    multifightform.labeldfpotion_num.Text = "" + df;
                    multifightform.labelattpotion_num.Text = "" + att;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("돈이 부족합니다!!");
            }
        }
    

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
    }
    }
}
