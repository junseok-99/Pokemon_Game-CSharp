using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDungeonGame
{
    public partial class PokemonChoice : Form
    {
        
        
        FightRoom fightRoomform;
        SoundPlayer mainsound;
        SoundPlayer kkobuksound;
        SoundPlayer pikasound;
        SoundPlayer firysound;
        FightRoom_multi_ fightroomform_multi;
        Form1 mainform = null;

        private string User_name;

        public string user_name
        {
            get { return User_name; }
            set { User_name = value; }
        }

        public PokemonChoice(Form1 form1)
        {
            InitializeComponent();
            mainsound = new SoundPlayer("LoginForm.wav");
            kkobuksound = new SoundPlayer("Kkobuk.wav");
            pikasound = new SoundPlayer("pikachu.wav");
            firysound = new SoundPlayer("firy.wav");

            mainform = form1;
        }

        private void pictureBoxpikachu_Click(object sender, EventArgs e)
        {
            buttonchoice.Enabled = true;
            checkBoxpika.Checked = true;
            checkBoxkkobuk.Checked = false;
            checkBoxfiry.Checked = false;
        }

        private void pictureBoxkkobuk_Click(object sender, EventArgs e)
        {
            
            buttonchoice.Enabled = true;
            checkBoxkkobuk.Checked = true;
            checkBoxfiry.Checked = false;
            checkBoxpika.Checked = false;
        }

        private void pictureBoxfiry_Click(object sender, EventArgs e)
        {
            buttonchoice.Enabled = true;
            checkBoxfiry.Checked = true;
            checkBoxpika.Checked = false;
            checkBoxkkobuk.Checked = false;
        }

        private void buttonchoice_Click(object sender, EventArgs e)
        {
            user_name = mainform.user_nickname;
            if (checkBoxpika.Checked)
            {
                if(MessageBox.Show("피카츄를 선택하시겠습니까??", "Pokemon Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    pikasound.PlaySync();
                    buttonsinglegame.Visible = true;
                    buttonmultimode.Visible = true;
                    labelmultimode.Visible = true;
                    labelsinglemode.Visible = true;
                    pictureBoxfiry.Visible = false;
                    pictureBoxkkobuk.Visible = false;
                    pictureBoxpikachu.Visible = false;
                    buttonchoice.Visible = false;
                    buttoncancel.Visible = false;
                    checkBoxfiry.Visible = false;
                    checkBoxkkobuk.Visible = false;
                    checkBoxpika.Visible = false;
                    labelfiryinfo.Visible = false;
                    labelfiryinfo2.Visible = false;
                    labelfiryinfo3.Visible = false;
                    labelfiryinfo4.Visible = false;
                    labelfiryinfo5.Visible = false;
                    labelfiryinfo6.Visible = false;
                    labelfiryinfo7.Visible = false;
                    labelfiryinfo8.Visible = false;
                    labelpikainfo.Visible = false;
                    labelpikainfo2.Visible = false;
                    labelpikainfo3.Visible = false;
                    labelpikainfo4.Visible = false;
                    labelpikainfo5.Visible = false;
                    labelpikainfo6.Visible = false;
                    labelpikainfo7.Visible = false;
                    labelpikainfo8.Visible = false;
                    labelkkobukinfo.Visible = false;
                    labelkkobukinfo2.Visible = false;
                    labelkkobukinfo3.Visible = false;
                    labelkkobukinfo4.Visible = false;
                    labelkkobukinfo5.Visible = false;
                    labelkkobukinfo6.Visible = false;
                    labelkkobukinfo7.Visible = false;
                    labelkkobukinfo8.Visible = false;
                }
                
            }
            else if (checkBoxkkobuk.Checked)
            {
                if (MessageBox.Show("꼬부기를 선택하시겠습니까??", "Pokemon Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    kkobuksound.PlaySync();
                    buttonsinglegame.Visible = true;
                    buttonmultimode.Visible = true;
                    labelmultimode.Visible = true;
                    labelsinglemode.Visible = true;
                    pictureBoxfiry.Visible = false;
                    pictureBoxkkobuk.Visible = false;
                    pictureBoxpikachu.Visible = false;
                    buttonchoice.Visible = false;
                    buttoncancel.Visible = false;
                    checkBoxfiry.Visible = false;
                    checkBoxkkobuk.Visible = false;
                    checkBoxpika.Visible = false;
                    labelfiryinfo.Visible = false;
                    labelfiryinfo2.Visible = false;
                    labelfiryinfo3.Visible = false;
                    labelfiryinfo4.Visible = false;
                    labelfiryinfo5.Visible = false;
                    labelfiryinfo6.Visible = false;
                    labelfiryinfo7.Visible = false;
                    labelfiryinfo8.Visible = false;
                    labelpikainfo.Visible = false;
                    labelpikainfo2.Visible = false;
                    labelpikainfo3.Visible = false;
                    labelpikainfo4.Visible = false;
                    labelpikainfo5.Visible = false;
                    labelpikainfo6.Visible = false;
                    labelpikainfo7.Visible = false;
                    labelpikainfo8.Visible = false;
                    labelkkobukinfo.Visible = false;
                    labelkkobukinfo2.Visible = false;
                    labelkkobukinfo3.Visible = false;
                    labelkkobukinfo4.Visible = false;
                    labelkkobukinfo5.Visible = false;
                    labelkkobukinfo6.Visible = false;
                    labelkkobukinfo7.Visible = false;
                    labelkkobukinfo8.Visible = false;
                }
            }
            else if (checkBoxfiry.Checked)
            {
                if (MessageBox.Show("파이리를 선택하시겠습니까??", "Pokemon Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    firysound.PlaySync();
                    buttonsinglegame.Visible = true;
                    buttonmultimode.Visible = true;
                    labelmultimode.Visible = true;
                    labelsinglemode.Visible = true;
                    pictureBoxfiry.Visible = false;
                    pictureBoxkkobuk.Visible = false;
                    pictureBoxpikachu.Visible = false;
                    buttonchoice.Visible = false;
                    buttoncancel.Visible = false;
                    checkBoxfiry.Visible = false;
                    checkBoxkkobuk.Visible = false;
                    checkBoxpika.Visible = false;
                    labelfiryinfo.Visible = false;
                    labelfiryinfo2.Visible = false;
                    labelfiryinfo3.Visible = false;
                    labelfiryinfo4.Visible = false;
                    labelfiryinfo5.Visible = false;
                    labelfiryinfo6.Visible = false;
                    labelfiryinfo7.Visible = false;
                    labelfiryinfo8.Visible = false;
                    labelpikainfo.Visible = false;
                    labelpikainfo2.Visible = false;
                    labelpikainfo3.Visible = false;
                    labelpikainfo4.Visible = false;
                    labelpikainfo5.Visible = false;
                    labelpikainfo6.Visible = false;
                    labelpikainfo7.Visible = false;
                    labelpikainfo8.Visible = false;
                    labelkkobukinfo.Visible = false;
                    labelkkobukinfo2.Visible = false;
                    labelkkobukinfo3.Visible = false;
                    labelkkobukinfo4.Visible = false;
                    labelkkobukinfo5.Visible = false;
                    labelkkobukinfo6.Visible = false;
                    labelkkobukinfo7.Visible = false;
                    labelkkobukinfo8.Visible = false;
                }
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainsound.PlayLooping();
        }

        private void CheckBoxpika_Choice(object sender, EventArgs e)
        {
            buttonchoice.Enabled = true;
            checkBoxkkobuk.Checked = false;
            checkBoxfiry.Checked = false;
        }

        private void CheckBoxfiry_Choice(object sender, EventArgs e)
        {
            buttonchoice.Enabled = true;
            checkBoxpika.Checked = false;
            checkBoxkkobuk.Checked = false;
        }

        private void CheckBoxkkobuk_Choice(object sender, EventArgs e)
        {
            buttonchoice.Enabled = true;
            checkBoxfiry.Checked = false;
            checkBoxpika.Checked = false;
        }

        private void buttonsinglegame_Click(object sender, EventArgs e)
        {
            fightRoomform = new FightRoom(this);
            fightRoomform.Show();
            mainform.Hide();
            this.Hide();
        }

        private void buttonmultimode_Click(object sender, EventArgs e)
        {
            fightroomform_multi = new FightRoom_multi_(this);
            fightroomform_multi.Show();
            mainform.Hide();
            this.Hide();
        }

        private void PokomonChoice_FormCloing(object sender, FormClosingEventArgs e)
        {
            mainsound.PlayLooping();
        }
    }
}
