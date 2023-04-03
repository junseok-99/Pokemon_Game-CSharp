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
    public partial class Form1 : Form
    {

        private string User_Nickname;

        public string user_nickname
        {
            get { return User_Nickname; }
            set { User_Nickname = value; }
        }

        User user;
        Nameform nameform;
        PokemonChoice pokemonchoiceform;
        FingerMiniGame minigameform;
        SoundPlayer mainsound;
        SoundPlayer pokepicksound;
        public Form1()
        {
            InitializeComponent();
            user = new User();
            mainsound = new SoundPlayer("LoginForm.wav");
            pokepicksound = new SoundPlayer("PokemonPickForm.wav");
            mainsound.PlayLooping();
        }

        

        private void buttonnicknameset_Click(object sender, EventArgs e)
        {
            nameform = new Nameform(this);
            nameform.Show();
        }

        private void buttongamestart_Click(object sender, EventArgs e)
        {
            pokemonchoiceform = new PokemonChoice(this);
            pokepicksound.PlayLooping();
            pokemonchoiceform.Show();
        }

        private void buttonchangenickname_Click(object sender, EventArgs e)
        {
            nameform.Show();
        }

        private void buttonfingerminigame_Click(object sender, EventArgs e)
        {
            minigameform = new FingerMiniGame();
            minigameform.Show();
        }
    }
}
