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
    public partial class Nameform : Form
    {
        Form1 mainform=null;

        public Nameform(Form1 form1)
        {
            InitializeComponent();
            mainform = form1;
        }

        private void Delete_Text(object sender, MouseEventArgs e)
        {
            textBoxnewnickname.Text = "";
        }

        private void buttonNicknameSetClear_Click(object sender, EventArgs e)
        {
            if (textBoxnewnickname.Text == "" || textBoxnewnickname.Text == "글자 수 8자이하")
            {
                MessageBox.Show("닉네임을 입력해주세요.");
            }
            else
            {
                MessageBox.Show("닉네임이 " + textBoxnewnickname.Text + "로 설정되었습니다.");
                mainform.labelwelcomeuser.Text = textBoxnewnickname.Text + " 님 반갑습니다.!!";
                mainform.buttonchangenickname.Visible = true;
                mainform.buttongamestart.Visible = true;
                mainform.buttonnicknameset.Visible = false;
                mainform.buttonfingerminigame.Visible = true;
                mainform.user_nickname = textBoxnewnickname.Text;
                this.Hide();
            }
        }

        private void buttonnickformout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNickTextboxdelete_Click(object sender, EventArgs e)
        {
            textBoxnewnickname.Text = "";
        }

       

        private void Enter_Nickname(object sender, KeyEventArgs e)
        {
            if (textBoxnewnickname.Text.Length > 7)
            {
                textBoxnewnickname.ReadOnly = true;
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBoxnewnickname.Text == "" || textBoxnewnickname.Text == "글자 수 8자이하")
                    {
                        MessageBox.Show("닉네임을 입력해주세요.");
                    }
                    else
                    {
                        MessageBox.Show("닉네임이 " + textBoxnewnickname.Text + "로 설정되었습니다.","Set Nickname",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        mainform.labelwelcomeuser.Text = textBoxnewnickname.Text + " 님 반갑습니다.!!";
                        mainform.buttonchangenickname.Visible = true;
                        mainform.buttongamestart.Visible = true;
                        mainform.buttonnicknameset.Visible = false;
                        mainform.buttonfingerminigame.Visible = true;
                        mainform.user_nickname = textBoxnewnickname.Text;
                        this.Hide();
                    }
                }
            }
            else
            {
                textBoxnewnickname.ReadOnly = false;
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBoxnewnickname.Text == "" || textBoxnewnickname.Text == "글자 수 8자이하")
                    {
                        MessageBox.Show("닉네임을 입력해주세요.");
                    }
                    else
                    {
                        MessageBox.Show("닉네임이 " + textBoxnewnickname.Text + "로 설정되었습니다.", "Set Nickname", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.labelwelcomeuser.Text = textBoxnewnickname.Text + " 님 반갑습니다.!!";
                        mainform.buttonchangenickname.Visible = true;
                        mainform.buttongamestart.Visible = true;
                        mainform.buttonnicknameset.Visible = false;
                        mainform.buttonfingerminigame.Visible = true;
                        mainform.user_nickname = textBoxnewnickname.Text;
                        this.Hide();
                    }
                }
            }
        }
    }
}
