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
    public partial class PauseGame : Form
    {
        FightRoom fightroomform = null;
        public PauseGame(FightRoom fightform)
        {
            InitializeComponent();
            fightroomform = fightform;
        }

        private void buttonReGame_Click(object sender, EventArgs e)
        {
            fightroomform.labelpausetime.Visible = true;
            fightroomform.pausetime = 4;
            fightroomform.pausetimer.Interval = 1000;
            fightroomform.pausetimer.Enabled = true;
            fightroomform.pause_tmp++;
            fightroomform.pictureBoxpause.Visible = true;
            fightroomform.pictureBoxrestrat.Visible = false;
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    
    }
}
