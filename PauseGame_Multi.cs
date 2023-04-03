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
    public partial class PauseGame_Multi : Form
    {
        FightRoom_multi_ multifightform = null;
        
       
        public PauseGame_Multi(FightRoom_multi_ multiform)
        {
            InitializeComponent();
            multifightform = multiform;
        }

        private void buttonReGame_Click(object sender, EventArgs e)
        {
            multifightform.labelpausetime.Visible = true;
            multifightform.pausetime = 4;
            multifightform.pausetimer.Interval = 1000;
            multifightform.pausetimer.Enabled = true;
            multifightform.pause_tmp++;
            multifightform.pictureBoxpause.Visible = true;
            multifightform.pictureBoxrestart.Visible = false;
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
