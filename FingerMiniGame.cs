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
    public partial class FingerMiniGame : Form
    {
        public static Random rnd_tmp=new Random();
        private int time=7;
        private int stage = 1;
        private int win_tmp = 0;
        SoundPlayer pokemonpicksound;
        SoundPlayer fingergamesound;
        SoundPlayer kkobuksound;
        SoundPlayer mainsound;
        SoundPlayer gamewin;
        SoundPlayer gamelose;
        SoundPlayer pika;
        SoundPlayer firy;
        
        public FingerMiniGame()
        {
            InitializeComponent();
            pokemonpicksound = new SoundPlayer("PokemonPickForm.wav");
            fingergamesound = new SoundPlayer("FingerGameRoom.wav");
            kkobuksound = new SoundPlayer("Kkobuk.wav");
            mainsound = new SoundPlayer("LoginForm.wav");
            gamewin = new SoundPlayer("Battle_Victory.wav");
            gamelose = new SoundPlayer("Battle_Lose.wav");
            pika = new SoundPlayer("pikachu.wav");
            firy = new SoundPlayer("firy.wav");
            pokemonpicksound.PlayLooping();
        }

        
        private void buttonpika_Click(object sender, EventArgs e)
        {
            pika.PlaySync();
            pictureBoxpika.Visible = true;
            pictureBoxlijamong.Visible = true;
            labelbossname.Visible = true;
            labelstagenumber.Visible = true;
            labelplayername.Visible = true;
            buttongamestrat.Visible=true;
            buttonfiry.Visible = false;
            buttonkkobuk.Visible = false;
            buttonpika.Visible = false;
            labelpokemonchoice.Visible = false;
            labelplayername.Text = "피카츄";
            pictureBoxfirychoice.Visible = false;
            pictureBoxkkobuchoice.Visible = false;
            pictureBoxpikachoice.Visible = false;
            fingergamesound.PlayLooping();
        }

        private void buttonkkobuk_Click(object sender, EventArgs e)
        {
            kkobuksound.PlaySync();
            pictureBoxkkobuk.Visible = true;
            pictureBoxlijamong.Visible = true;
            labelbossname.Visible = true;
            labelstagenumber.Visible = true;
            labelplayername.Visible = true;
            buttongamestrat.Visible = true;
            buttonfiry.Visible = false;
            buttonkkobuk.Visible = false;
            buttonpika.Visible = false;
            labelpokemonchoice.Visible = false;
            labelplayername.Text = "꼬부기";
            pictureBoxfirychoice.Visible = false;
            pictureBoxkkobuchoice.Visible = false;
            pictureBoxpikachoice.Visible = false;
            fingergamesound.PlayLooping();
        }

        private void buttonfiry_Click(object sender, EventArgs e)
        {
            firy.PlaySync();
            pictureBoxfiry.Visible = true;
            pictureBoxlijamong.Visible = true;
            labelbossname.Visible = true;
            labelstagenumber.Visible = true;
            labelplayername.Visible = true;
            buttongamestrat.Visible = true;
            buttonfiry.Visible = false;
            buttonkkobuk.Visible = false;
            buttonpika.Visible = false;
            labelpokemonchoice.Visible = false;
            labelplayername.Text = "파이리";
            pictureBoxfirychoice.Visible = false;
            pictureBoxkkobuchoice.Visible = false;
            pictureBoxpikachoice.Visible = false;
            fingergamesound.PlayLooping();
        }

        private void buttongamestrat_Click(object sender, EventArgs e)
        {
            buttonrock.Visible = true;
            buttonscissors.Visible = true;
            buttonpaper.Visible = true;
            labeltime.Visible = true;
            labelvs.Visible = true;
            gametimer.Enabled = true;
            buttongamestrat.Visible = false;
            bosstimer.Enabled = true;
            
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            
            labeltime.Text = ""+time;
            time--;
            if (time < 0)
            {
                buttonexit.Visible=true;
                buttonregame.Visible = true;
                labelvs.Visible = false;
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                buttonscissors.Enabled = false;
                buttonrock.Enabled = false;
                buttonpaper.Enabled = false;
                labelgamelose.Visible = true;
                gamelose.Play();
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            mainsound.PlayLooping();
            this.Hide();
        }

        private void buttonregame_Click(object sender, EventArgs e)
        {
            buttonexit.Visible = false;
            buttonregame.Visible = false;
            time = 7;
            stage = 1;
            win_tmp = 0;
            gametimer.Enabled = true;
            bosstimer.Enabled = true;
            pictureBoxlijamong.Visible = true;
            pictureBoxgyarados.Visible = false;
            pictureBoxmangnanyong.Visible = false;
            pictureBoxmews.Visible = false;
            labelbossname.Text = "리자몽";
            labelstagenumber.Text = "STAGE 1";
            buttonpaper.Enabled = true;
            buttonrock.Enabled = true;
            buttonscissors.Enabled = true;
            pictureBoxplayerrock.Visible = false;
            pictureBoxplayerscissor.Visible = false;
            pictureBoxplayerpaper.Visible = false;
            fingergamesound.Play();
            labelgamewin.Visible = false;
            labelgamelose.Visible = false;
        }

        private void bosstimer_Tick(object sender, EventArgs e)
        {

            int rnd_result = rnd_tmp.Next(0, 3);
            if (rnd_result== 0)
            {
                labelbossfinger.Text = "가위";
                pictureBoxscissor.Visible = true;
                pictureBoxrock.Visible = false;
                pictureBoxpaper.Visible = false;
            }
            else if (rnd_result== 1)
            {
                labelbossfinger.Text = "바위";
                pictureBoxscissor.Visible = false;
                pictureBoxrock.Visible = true;
                pictureBoxpaper.Visible = false;
            }
            else if(rnd_result==2)
            {
                labelbossfinger.Text = "보";
                pictureBoxscissor.Visible = false;
                pictureBoxrock.Visible = false;
                pictureBoxpaper.Visible = true;
            }
            
            
        }

        private void buttonscissors_Click(object sender, EventArgs e)
        {

            pictureBoxplayerscissor.Visible = true;
            pictureBoxplayerrock.Visible = false;
            pictureBoxplayerpaper.Visible = false;

            if (labelbossfinger.Text == "보")
            {
                labelgamewin.Visible = true;
                stage++;
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                time = 7;
                stagetimer.Enabled = true;
            }
            else if (labelbossfinger.Text == "가위")
            {
                labeltime.Text = "무승부";
                time = 7;               
                bosstimer.Enabled = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
            }
            else if (labelbossfinger.Text == "바위")
            {
                labelgamelose.Visible = true;
                gamelose.Play();
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                labelvs.Visible = false;
                buttonexit.Visible = true;
                buttonregame.Visible = true;
                buttonscissors.Enabled = false;
                buttonrock.Enabled = false;
                buttonpaper.Enabled = false;
                pictureBoxplayerscissor.Visible = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerpaper.Visible = false;
            }
            
        }

        private void buttonrock_Click(object sender, EventArgs e)
        {
            pictureBoxplayerrock.Visible = true;
            pictureBoxplayerscissor.Visible = false;
            pictureBoxplayerpaper.Visible = false;
            if (labelbossfinger.Text == "가위")
            {
                labelgamewin.Visible = true;
                stage++;
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                time = 7;
                stagetimer.Enabled = true;
            }
            else if (labelbossfinger.Text == "바위")
            {
                labeltime.Text = "무승부";
                gametimer.Enabled = true;
                bosstimer.Enabled = true;
                time = 7;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
            }
            else if (labelbossfinger.Text == "보")
            {
                labelgamelose.Visible = true;
                gamelose.Play();
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                labelvs.Visible = false;
                buttonexit.Visible = true;
                buttonregame.Visible = true;
                pictureBoxplayerrock.Visible = true;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
                buttonscissors.Enabled = false;
                buttonrock.Enabled = false;
                buttonpaper.Enabled = false;
            }
            
        }

        private void buttonpaper_Click(object sender, EventArgs e)
        {
            pictureBoxplayerrock.Visible = false;
            pictureBoxplayerscissor.Visible = false;
            pictureBoxplayerpaper.Visible = true;

            if (labelbossfinger.Text == "바위")
            {
                labelgamewin.Visible = true;
                stage++;
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                time = 7;
                stagetimer.Enabled = true;
            }
            else if (labelbossfinger.Text == "보")
            {
                labeltime.Text = "무승부";
                gametimer.Enabled = true;
                bosstimer.Enabled = true;
                time = 7;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
            }
            else if (labelbossfinger.Text == "가위")
            {
                labelgamelose.Visible = true;
                gamelose.Play();
                gametimer.Enabled = false;
                bosstimer.Enabled = false;
                labelvs.Visible = false;
                buttonexit.Visible = true;
                buttonregame.Visible = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = true;
                buttonscissors.Enabled = false;
                buttonrock.Enabled = false;
                buttonpaper.Enabled = false;
            }
            
        }

        private void stagetimer_Tick(object sender, EventArgs e)
        {
            
            if (stage == 2)
            {
                pictureBoxlijamong.Visible = false;
                pictureBoxgyarados.Visible = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
                if (win_tmp == 0)
                {
                    bosstimer.Enabled = true;
                    gametimer.Enabled = true;
                    win_tmp++;
                }
                labelgamewin.Visible = false;
                labelgamelose.Visible = false;
                labelbossname.Text = "갸라도스";
                labelstagenumber.Text = "STAGE 2";
                stagetimer.Enabled = false;
            }
            else if (stage == 3)
            {
                pictureBoxgyarados.Visible = false;
                pictureBoxmangnanyong.Visible = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
                if (win_tmp == 1)
                {
                    bosstimer.Enabled = true;
                    gametimer.Enabled = true;
                    win_tmp++;
                }
                labelgamewin.Visible = false;
                labelgamelose.Visible = false;
                labelbossname.Text = "망나뇽";
                labelstagenumber.Text = "STAGE 3";
                stagetimer.Enabled = false;
            }
            else if (stage == 4)
            {
                pictureBoxmangnanyong.Visible = false;
                pictureBoxmews.Visible = true;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
                if (win_tmp == 2)
                {
                    bosstimer.Enabled = true;
                    gametimer.Enabled = true;
                    win_tmp++;
                }
                labelgamewin.Visible = false;
                labelgamelose.Visible = false;
                labelbossname.Text = "뮤츠";
                labelstagenumber.Text = "STAGE 4";
                stagetimer.Enabled = false;
            }
            else if (stage == 5)
            {
                bosstimer.Enabled = false;
                gametimer.Enabled = false;
                labelgamewin.Visible = true;
                labelgamewin.Text = "최종 승리!!";
                gamewin.Play();
                buttonexit.Visible = true;
                buttonregame.Visible = true;
                labelvs.Visible = false;
                buttonscissors.Enabled = false;
                buttonrock.Enabled = false;
                buttonpaper.Enabled = false;
                pictureBoxplayerrock.Visible = false;
                pictureBoxplayerscissor.Visible = false;
                pictureBoxplayerpaper.Visible = false;
                stagetimer.Enabled = false;
            }
        }

        private void FingerGame_Closing(object sender, FormClosingEventArgs e)
        {
            fingergamesound.Stop();
            mainsound.PlayLooping();
        }
    }
}
