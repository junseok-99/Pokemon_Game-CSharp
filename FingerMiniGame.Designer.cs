
namespace PokemonDungeonGame
{
    partial class FingerMiniGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerMiniGame));
            this.labelbossname = new System.Windows.Forms.Label();
            this.labelplayername = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.labelvs = new System.Windows.Forms.Label();
            this.buttongamestrat = new System.Windows.Forms.Button();
            this.buttonregame = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.labelstagenumber = new System.Windows.Forms.Label();
            this.buttonkkobuk = new System.Windows.Forms.Button();
            this.buttonfiry = new System.Windows.Forms.Button();
            this.buttonpika = new System.Windows.Forms.Button();
            this.labelpokemonchoice = new System.Windows.Forms.Label();
            this.buttonscissors = new System.Windows.Forms.Button();
            this.buttonpaper = new System.Windows.Forms.Button();
            this.buttonrock = new System.Windows.Forms.Button();
            this.bosstimer = new System.Windows.Forms.Timer(this.components);
            this.labeltime = new System.Windows.Forms.Label();
            this.labelbossfinger = new System.Windows.Forms.Label();
            this.stagetimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxplayerpaper = new System.Windows.Forms.PictureBox();
            this.pictureBoxplayerscissor = new System.Windows.Forms.PictureBox();
            this.pictureBoxplayerrock = new System.Windows.Forms.PictureBox();
            this.pictureBoxrock = new System.Windows.Forms.PictureBox();
            this.pictureBoxpaper = new System.Windows.Forms.PictureBox();
            this.pictureBoxscissor = new System.Windows.Forms.PictureBox();
            this.pictureBoxkkobuchoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxfirychoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxpikachoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxpika = new System.Windows.Forms.PictureBox();
            this.pictureBoxkkobuk = new System.Windows.Forms.PictureBox();
            this.pictureBoxfiry = new System.Windows.Forms.PictureBox();
            this.pictureBoxmews = new System.Windows.Forms.PictureBox();
            this.pictureBoxmangnanyong = new System.Windows.Forms.PictureBox();
            this.pictureBoxgyarados = new System.Windows.Forms.PictureBox();
            this.pictureBoxlijamong = new System.Windows.Forms.PictureBox();
            this.labelgamelose = new System.Windows.Forms.Label();
            this.labelgamewin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerscissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkkobuchoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfirychoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpikachoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkkobuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmangnanyong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgyarados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlijamong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelbossname
            // 
            this.labelbossname.AutoSize = true;
            this.labelbossname.Font = new System.Drawing.Font("굴림", 20F);
            this.labelbossname.Location = new System.Drawing.Point(655, 354);
            this.labelbossname.Name = "labelbossname";
            this.labelbossname.Size = new System.Drawing.Size(117, 34);
            this.labelbossname.TabIndex = 4;
            this.labelbossname.Text = "리자몽";
            this.labelbossname.Visible = false;
            // 
            // labelplayername
            // 
            this.labelplayername.AutoSize = true;
            this.labelplayername.Font = new System.Drawing.Font("굴림", 20F);
            this.labelplayername.Location = new System.Drawing.Point(81, 354);
            this.labelplayername.Name = "labelplayername";
            this.labelplayername.Size = new System.Drawing.Size(83, 34);
            this.labelplayername.TabIndex = 5;
            this.labelplayername.Text = "이름";
            this.labelplayername.Visible = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // labelvs
            // 
            this.labelvs.AutoSize = true;
            this.labelvs.Font = new System.Drawing.Font("굴림", 20F);
            this.labelvs.Location = new System.Drawing.Point(396, 190);
            this.labelvs.Name = "labelvs";
            this.labelvs.Size = new System.Drawing.Size(57, 34);
            this.labelvs.TabIndex = 6;
            this.labelvs.Text = "VS";
            this.labelvs.Visible = false;
            // 
            // buttongamestrat
            // 
            this.buttongamestrat.BackColor = System.Drawing.Color.Black;
            this.buttongamestrat.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttongamestrat.ForeColor = System.Drawing.Color.White;
            this.buttongamestrat.Location = new System.Drawing.Point(370, 175);
            this.buttongamestrat.Name = "buttongamestrat";
            this.buttongamestrat.Size = new System.Drawing.Size(110, 71);
            this.buttongamestrat.TabIndex = 7;
            this.buttongamestrat.Text = "게임시작";
            this.buttongamestrat.UseVisualStyleBackColor = false;
            this.buttongamestrat.Visible = false;
            this.buttongamestrat.Click += new System.EventHandler(this.buttongamestrat_Click);
            // 
            // buttonregame
            // 
            this.buttonregame.BackColor = System.Drawing.Color.Black;
            this.buttonregame.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonregame.ForeColor = System.Drawing.Color.White;
            this.buttonregame.Location = new System.Drawing.Point(371, 98);
            this.buttonregame.Name = "buttonregame";
            this.buttonregame.Size = new System.Drawing.Size(110, 71);
            this.buttonregame.TabIndex = 8;
            this.buttonregame.Text = "다시하기";
            this.buttonregame.UseVisualStyleBackColor = false;
            this.buttonregame.Visible = false;
            this.buttonregame.Click += new System.EventHandler(this.buttonregame_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Black;
            this.buttonexit.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Location = new System.Drawing.Point(371, 252);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(110, 71);
            this.buttonexit.TabIndex = 9;
            this.buttonexit.Text = "나가기";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Visible = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // labelstagenumber
            // 
            this.labelstagenumber.AutoSize = true;
            this.labelstagenumber.Font = new System.Drawing.Font("굴림", 20F);
            this.labelstagenumber.Location = new System.Drawing.Point(355, 29);
            this.labelstagenumber.Name = "labelstagenumber";
            this.labelstagenumber.Size = new System.Drawing.Size(157, 34);
            this.labelstagenumber.TabIndex = 10;
            this.labelstagenumber.Text = "STAGE 1";
            this.labelstagenumber.Visible = false;
            // 
            // buttonkkobuk
            // 
            this.buttonkkobuk.BackColor = System.Drawing.Color.Aqua;
            this.buttonkkobuk.Font = new System.Drawing.Font("문체부 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonkkobuk.ForeColor = System.Drawing.Color.Blue;
            this.buttonkkobuk.Location = new System.Drawing.Point(371, 391);
            this.buttonkkobuk.Name = "buttonkkobuk";
            this.buttonkkobuk.Size = new System.Drawing.Size(110, 71);
            this.buttonkkobuk.TabIndex = 14;
            this.buttonkkobuk.Text = "꼬부기";
            this.buttonkkobuk.UseVisualStyleBackColor = false;
            this.buttonkkobuk.Click += new System.EventHandler(this.buttonkkobuk_Click);
            // 
            // buttonfiry
            // 
            this.buttonfiry.BackColor = System.Drawing.Color.Crimson;
            this.buttonfiry.Font = new System.Drawing.Font("문체부 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfiry.ForeColor = System.Drawing.Color.White;
            this.buttonfiry.Location = new System.Drawing.Point(661, 391);
            this.buttonfiry.Name = "buttonfiry";
            this.buttonfiry.Size = new System.Drawing.Size(110, 71);
            this.buttonfiry.TabIndex = 15;
            this.buttonfiry.Text = "파이리";
            this.buttonfiry.UseVisualStyleBackColor = false;
            this.buttonfiry.Click += new System.EventHandler(this.buttonfiry_Click);
            // 
            // buttonpika
            // 
            this.buttonpika.BackColor = System.Drawing.Color.Yellow;
            this.buttonpika.Font = new System.Drawing.Font("문체부 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonpika.ForeColor = System.Drawing.Color.Red;
            this.buttonpika.Location = new System.Drawing.Point(87, 391);
            this.buttonpika.Name = "buttonpika";
            this.buttonpika.Size = new System.Drawing.Size(110, 71);
            this.buttonpika.TabIndex = 16;
            this.buttonpika.Text = "피카츄";
            this.buttonpika.UseVisualStyleBackColor = false;
            this.buttonpika.Click += new System.EventHandler(this.buttonpika_Click);
            // 
            // labelpokemonchoice
            // 
            this.labelpokemonchoice.AutoSize = true;
            this.labelpokemonchoice.Font = new System.Drawing.Font("굴림", 30F);
            this.labelpokemonchoice.Location = new System.Drawing.Point(294, 14);
            this.labelpokemonchoice.Name = "labelpokemonchoice";
            this.labelpokemonchoice.Size = new System.Drawing.Size(289, 50);
            this.labelpokemonchoice.TabIndex = 17;
            this.labelpokemonchoice.Text = "포켓몬 선택";
            // 
            // buttonscissors
            // 
            this.buttonscissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonscissors.BackgroundImage = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_03;
            this.buttonscissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonscissors.Font = new System.Drawing.Font("문체부 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonscissors.Location = new System.Drawing.Point(12, 420);
            this.buttonscissors.Name = "buttonscissors";
            this.buttonscissors.Size = new System.Drawing.Size(90, 71);
            this.buttonscissors.TabIndex = 20;
            this.buttonscissors.UseVisualStyleBackColor = false;
            this.buttonscissors.Visible = false;
            this.buttonscissors.Click += new System.EventHandler(this.buttonscissors_Click);
            // 
            // buttonpaper
            // 
            this.buttonpaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonpaper.BackgroundImage = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_04;
            this.buttonpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpaper.Font = new System.Drawing.Font("문체부 제목 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonpaper.Location = new System.Drawing.Point(204, 420);
            this.buttonpaper.Name = "buttonpaper";
            this.buttonpaper.Size = new System.Drawing.Size(90, 71);
            this.buttonpaper.TabIndex = 21;
            this.buttonpaper.UseVisualStyleBackColor = false;
            this.buttonpaper.Visible = false;
            this.buttonpaper.Click += new System.EventHandler(this.buttonpaper_Click);
            // 
            // buttonrock
            // 
            this.buttonrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonrock.BackgroundImage = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491;
            this.buttonrock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonrock.Font = new System.Drawing.Font("문체부 제목 돋음체", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonrock.Location = new System.Drawing.Point(108, 420);
            this.buttonrock.Name = "buttonrock";
            this.buttonrock.Size = new System.Drawing.Size(90, 71);
            this.buttonrock.TabIndex = 22;
            this.buttonrock.UseVisualStyleBackColor = false;
            this.buttonrock.Visible = false;
            this.buttonrock.Click += new System.EventHandler(this.buttonrock_Click);
            // 
            // bosstimer
            // 
            this.bosstimer.Interval = 25;
            this.bosstimer.Tick += new System.EventHandler(this.bosstimer_Tick);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("굴림", 30F);
            this.labeltime.Location = new System.Drawing.Point(395, 354);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(51, 50);
            this.labeltime.TabIndex = 23;
            this.labeltime.Text = "7";
            this.labeltime.Visible = false;
            // 
            // labelbossfinger
            // 
            this.labelbossfinger.AutoSize = true;
            this.labelbossfinger.Font = new System.Drawing.Font("굴림", 20F);
            this.labelbossfinger.Location = new System.Drawing.Point(480, 176);
            this.labelbossfinger.Name = "labelbossfinger";
            this.labelbossfinger.Size = new System.Drawing.Size(83, 34);
            this.labelbossfinger.TabIndex = 24;
            this.labelbossfinger.Text = "이름";
            this.labelbossfinger.Visible = false;
            // 
            // stagetimer
            // 
            this.stagetimer.Interval = 2000;
            this.stagetimer.Tick += new System.EventHandler(this.stagetimer_Tick);
            // 
            // pictureBoxplayerpaper
            // 
            this.pictureBoxplayerpaper.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_04;
            this.pictureBoxplayerpaper.Location = new System.Drawing.Point(251, 165);
            this.pictureBoxplayerpaper.Name = "pictureBoxplayerpaper";
            this.pictureBoxplayerpaper.Size = new System.Drawing.Size(109, 110);
            this.pictureBoxplayerpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxplayerpaper.TabIndex = 33;
            this.pictureBoxplayerpaper.TabStop = false;
            this.pictureBoxplayerpaper.Visible = false;
            // 
            // pictureBoxplayerscissor
            // 
            this.pictureBoxplayerscissor.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_03;
            this.pictureBoxplayerscissor.Location = new System.Drawing.Point(251, 165);
            this.pictureBoxplayerscissor.Name = "pictureBoxplayerscissor";
            this.pictureBoxplayerscissor.Size = new System.Drawing.Size(109, 110);
            this.pictureBoxplayerscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxplayerscissor.TabIndex = 32;
            this.pictureBoxplayerscissor.TabStop = false;
            this.pictureBoxplayerscissor.Visible = false;
            // 
            // pictureBoxplayerrock
            // 
            this.pictureBoxplayerrock.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491;
            this.pictureBoxplayerrock.Location = new System.Drawing.Point(251, 165);
            this.pictureBoxplayerrock.Name = "pictureBoxplayerrock";
            this.pictureBoxplayerrock.Size = new System.Drawing.Size(109, 110);
            this.pictureBoxplayerrock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxplayerrock.TabIndex = 31;
            this.pictureBoxplayerrock.TabStop = false;
            this.pictureBoxplayerrock.Visible = false;
            // 
            // pictureBoxrock
            // 
            this.pictureBoxrock.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491;
            this.pictureBoxrock.Location = new System.Drawing.Point(486, 165);
            this.pictureBoxrock.Name = "pictureBoxrock";
            this.pictureBoxrock.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxrock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxrock.TabIndex = 30;
            this.pictureBoxrock.TabStop = false;
            this.pictureBoxrock.Visible = false;
            // 
            // pictureBoxpaper
            // 
            this.pictureBoxpaper.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_04;
            this.pictureBoxpaper.Location = new System.Drawing.Point(486, 165);
            this.pictureBoxpaper.Name = "pictureBoxpaper";
            this.pictureBoxpaper.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpaper.TabIndex = 29;
            this.pictureBoxpaper.TabStop = false;
            this.pictureBoxpaper.Visible = false;
            // 
            // pictureBoxscissor
            // 
            this.pictureBoxscissor.Image = global::PokemonDungeonGame.Properties.Resources.KakaoTalk_20210531_162001491_03;
            this.pictureBoxscissor.Location = new System.Drawing.Point(486, 165);
            this.pictureBoxscissor.Name = "pictureBoxscissor";
            this.pictureBoxscissor.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxscissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxscissor.TabIndex = 28;
            this.pictureBoxscissor.TabStop = false;
            this.pictureBoxscissor.Visible = false;
            // 
            // pictureBoxkkobuchoice
            // 
            this.pictureBoxkkobuchoice.Image = global::PokemonDungeonGame.Properties.Resources.kkobuk;
            this.pictureBoxkkobuchoice.Location = new System.Drawing.Point(319, 98);
            this.pictureBoxkkobuchoice.Name = "pictureBoxkkobuchoice";
            this.pictureBoxkkobuchoice.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxkkobuchoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxkkobuchoice.TabIndex = 27;
            this.pictureBoxkkobuchoice.TabStop = false;
            // 
            // pictureBoxfirychoice
            // 
            this.pictureBoxfirychoice.Image = global::PokemonDungeonGame.Properties.Resources.firy;
            this.pictureBoxfirychoice.Location = new System.Drawing.Point(602, 98);
            this.pictureBoxfirychoice.Name = "pictureBoxfirychoice";
            this.pictureBoxfirychoice.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxfirychoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxfirychoice.TabIndex = 26;
            this.pictureBoxfirychoice.TabStop = false;
            // 
            // pictureBoxpikachoice
            // 
            this.pictureBoxpikachoice.Image = global::PokemonDungeonGame.Properties.Resources.pikachu;
            this.pictureBoxpikachoice.Location = new System.Drawing.Point(23, 98);
            this.pictureBoxpikachoice.Name = "pictureBoxpikachoice";
            this.pictureBoxpikachoice.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxpikachoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpikachoice.TabIndex = 25;
            this.pictureBoxpikachoice.TabStop = false;
            // 
            // pictureBoxpika
            // 
            this.pictureBoxpika.Image = global::PokemonDungeonGame.Properties.Resources.pikachu;
            this.pictureBoxpika.Location = new System.Drawing.Point(23, 56);
            this.pictureBoxpika.Name = "pictureBoxpika";
            this.pictureBoxpika.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxpika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpika.TabIndex = 13;
            this.pictureBoxpika.TabStop = false;
            this.pictureBoxpika.Visible = false;
            // 
            // pictureBoxkkobuk
            // 
            this.pictureBoxkkobuk.Image = global::PokemonDungeonGame.Properties.Resources.kkobuk;
            this.pictureBoxkkobuk.Location = new System.Drawing.Point(23, 56);
            this.pictureBoxkkobuk.Name = "pictureBoxkkobuk";
            this.pictureBoxkkobuk.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxkkobuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxkkobuk.TabIndex = 12;
            this.pictureBoxkkobuk.TabStop = false;
            this.pictureBoxkkobuk.Visible = false;
            // 
            // pictureBoxfiry
            // 
            this.pictureBoxfiry.Image = global::PokemonDungeonGame.Properties.Resources.firy;
            this.pictureBoxfiry.Location = new System.Drawing.Point(23, 56);
            this.pictureBoxfiry.Name = "pictureBoxfiry";
            this.pictureBoxfiry.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxfiry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxfiry.TabIndex = 11;
            this.pictureBoxfiry.TabStop = false;
            this.pictureBoxfiry.Visible = false;
            // 
            // pictureBoxmews
            // 
            this.pictureBoxmews.Image = global::PokemonDungeonGame.Properties.Resources.mew;
            this.pictureBoxmews.Location = new System.Drawing.Point(602, 66);
            this.pictureBoxmews.Name = "pictureBoxmews";
            this.pictureBoxmews.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxmews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmews.TabIndex = 3;
            this.pictureBoxmews.TabStop = false;
            this.pictureBoxmews.Visible = false;
            // 
            // pictureBoxmangnanyong
            // 
            this.pictureBoxmangnanyong.Image = global::PokemonDungeonGame.Properties.Resources.mangna;
            this.pictureBoxmangnanyong.Location = new System.Drawing.Point(602, 66);
            this.pictureBoxmangnanyong.Name = "pictureBoxmangnanyong";
            this.pictureBoxmangnanyong.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxmangnanyong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmangnanyong.TabIndex = 2;
            this.pictureBoxmangnanyong.TabStop = false;
            this.pictureBoxmangnanyong.Visible = false;
            // 
            // pictureBoxgyarados
            // 
            this.pictureBoxgyarados.Image = global::PokemonDungeonGame.Properties.Resources.gyra;
            this.pictureBoxgyarados.Location = new System.Drawing.Point(602, 66);
            this.pictureBoxgyarados.Name = "pictureBoxgyarados";
            this.pictureBoxgyarados.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxgyarados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgyarados.TabIndex = 1;
            this.pictureBoxgyarados.TabStop = false;
            this.pictureBoxgyarados.Visible = false;
            // 
            // pictureBoxlijamong
            // 
            this.pictureBoxlijamong.Image = global::PokemonDungeonGame.Properties.Resources.lijamong1;
            this.pictureBoxlijamong.Location = new System.Drawing.Point(602, 66);
            this.pictureBoxlijamong.Name = "pictureBoxlijamong";
            this.pictureBoxlijamong.Size = new System.Drawing.Size(222, 253);
            this.pictureBoxlijamong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlijamong.TabIndex = 0;
            this.pictureBoxlijamong.TabStop = false;
            this.pictureBoxlijamong.Visible = false;
            // 
            // labelgamelose
            // 
            this.labelgamelose.AutoSize = true;
            this.labelgamelose.BackColor = System.Drawing.Color.Transparent;
            this.labelgamelose.Font = new System.Drawing.Font("한컴 윤체 B", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelgamelose.ForeColor = System.Drawing.Color.Blue;
            this.labelgamelose.Location = new System.Drawing.Point(435, 379);
            this.labelgamelose.Name = "labelgamelose";
            this.labelgamelose.Size = new System.Drawing.Size(271, 83);
            this.labelgamelose.TabIndex = 43;
            this.labelgamelose.Text = "게임패배..";
            this.labelgamelose.Visible = false;
            // 
            // labelgamewin
            // 
            this.labelgamewin.AutoSize = true;
            this.labelgamewin.BackColor = System.Drawing.Color.Transparent;
            this.labelgamewin.Font = new System.Drawing.Font("한컴 윤체 B", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelgamewin.ForeColor = System.Drawing.Color.Red;
            this.labelgamewin.Location = new System.Drawing.Point(435, 388);
            this.labelgamewin.Name = "labelgamewin";
            this.labelgamewin.Size = new System.Drawing.Size(293, 83);
            this.labelgamewin.TabIndex = 44;
            this.labelgamewin.Text = "게임승리!!";
            this.labelgamewin.Visible = false;
            // 
            // FingerMiniGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(864, 503);
            this.Controls.Add(this.labelgamewin);
            this.Controls.Add(this.labelgamelose);
            this.Controls.Add(this.pictureBoxplayerpaper);
            this.Controls.Add(this.pictureBoxplayerscissor);
            this.Controls.Add(this.pictureBoxplayerrock);
            this.Controls.Add(this.pictureBoxrock);
            this.Controls.Add(this.pictureBoxpaper);
            this.Controls.Add(this.pictureBoxscissor);
            this.Controls.Add(this.pictureBoxkkobuchoice);
            this.Controls.Add(this.pictureBoxfirychoice);
            this.Controls.Add(this.pictureBoxpikachoice);
            this.Controls.Add(this.labelbossfinger);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.buttonrock);
            this.Controls.Add(this.buttonpaper);
            this.Controls.Add(this.buttonscissors);
            this.Controls.Add(this.labelpokemonchoice);
            this.Controls.Add(this.buttonpika);
            this.Controls.Add(this.buttonfiry);
            this.Controls.Add(this.buttonkkobuk);
            this.Controls.Add(this.pictureBoxpika);
            this.Controls.Add(this.pictureBoxkkobuk);
            this.Controls.Add(this.pictureBoxfiry);
            this.Controls.Add(this.labelstagenumber);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonregame);
            this.Controls.Add(this.buttongamestrat);
            this.Controls.Add(this.labelvs);
            this.Controls.Add(this.labelplayername);
            this.Controls.Add(this.labelbossname);
            this.Controls.Add(this.pictureBoxmews);
            this.Controls.Add(this.pictureBoxmangnanyong);
            this.Controls.Add(this.pictureBoxgyarados);
            this.Controls.Add(this.pictureBoxlijamong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FingerMiniGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerMiniGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FingerGame_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerscissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplayerrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkkobuchoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfirychoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpikachoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkkobuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmangnanyong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgyarados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlijamong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxlijamong;
        private System.Windows.Forms.PictureBox pictureBoxgyarados;
        private System.Windows.Forms.PictureBox pictureBoxmangnanyong;
        private System.Windows.Forms.PictureBox pictureBoxmews;
        private System.Windows.Forms.Label labelbossname;
        private System.Windows.Forms.Label labelplayername;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label labelvs;
        private System.Windows.Forms.Button buttongamestrat;
        private System.Windows.Forms.Button buttonregame;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label labelstagenumber;
        private System.Windows.Forms.PictureBox pictureBoxfiry;
        private System.Windows.Forms.PictureBox pictureBoxkkobuk;
        private System.Windows.Forms.PictureBox pictureBoxpika;
        private System.Windows.Forms.Button buttonkkobuk;
        private System.Windows.Forms.Button buttonfiry;
        private System.Windows.Forms.Button buttonpika;
        private System.Windows.Forms.Label labelpokemonchoice;
        private System.Windows.Forms.Button buttonscissors;
        private System.Windows.Forms.Button buttonpaper;
        private System.Windows.Forms.Button buttonrock;
        private System.Windows.Forms.Timer bosstimer;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labelbossfinger;
        private System.Windows.Forms.Timer stagetimer;
        private System.Windows.Forms.PictureBox pictureBoxpikachoice;
        private System.Windows.Forms.PictureBox pictureBoxfirychoice;
        private System.Windows.Forms.PictureBox pictureBoxkkobuchoice;
        private System.Windows.Forms.PictureBox pictureBoxscissor;
        private System.Windows.Forms.PictureBox pictureBoxpaper;
        private System.Windows.Forms.PictureBox pictureBoxrock;
        private System.Windows.Forms.PictureBox pictureBoxplayerrock;
        private System.Windows.Forms.PictureBox pictureBoxplayerscissor;
        private System.Windows.Forms.PictureBox pictureBoxplayerpaper;
        private System.Windows.Forms.Label labelgamelose;
        private System.Windows.Forms.Label labelgamewin;
    }
}