
namespace PokemonDungeonGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttongamestart = new System.Windows.Forms.Button();
            this.buttonnicknameset = new System.Windows.Forms.Button();
            this.buttonchangenickname = new System.Windows.Forms.Button();
            this.labelwelcomeuser = new System.Windows.Forms.Label();
            this.buttonfingerminigame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttongamestart
            // 
            this.buttongamestart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttongamestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttongamestart.FlatAppearance.BorderSize = 0;
            this.buttongamestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttongamestart.Font = new System.Drawing.Font("문체부 제목 돋음체", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttongamestart.Location = new System.Drawing.Point(9, 580);
            this.buttongamestart.Name = "buttongamestart";
            this.buttongamestart.Size = new System.Drawing.Size(209, 63);
            this.buttongamestart.TabIndex = 0;
            this.buttongamestart.Text = "게임시작";
            this.buttongamestart.UseVisualStyleBackColor = false;
            this.buttongamestart.Visible = false;
            this.buttongamestart.Click += new System.EventHandler(this.buttongamestart_Click);
            // 
            // buttonnicknameset
            // 
            this.buttonnicknameset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonnicknameset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonnicknameset.FlatAppearance.BorderSize = 0;
            this.buttonnicknameset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonnicknameset.Font = new System.Drawing.Font("문체부 제목 돋음체", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonnicknameset.Location = new System.Drawing.Point(161, 580);
            this.buttonnicknameset.Name = "buttonnicknameset";
            this.buttonnicknameset.Size = new System.Drawing.Size(250, 63);
            this.buttonnicknameset.TabIndex = 1;
            this.buttonnicknameset.Text = "닉네임설정";
            this.buttonnicknameset.UseVisualStyleBackColor = false;
            this.buttonnicknameset.Click += new System.EventHandler(this.buttonnicknameset_Click);
            // 
            // buttonchangenickname
            // 
            this.buttonchangenickname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonchangenickname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonchangenickname.FlatAppearance.BorderSize = 0;
            this.buttonchangenickname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonchangenickname.Font = new System.Drawing.Font("문체부 제목 돋음체", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonchangenickname.Location = new System.Drawing.Point(480, 580);
            this.buttonchangenickname.Name = "buttonchangenickname";
            this.buttonchangenickname.Size = new System.Drawing.Size(250, 63);
            this.buttonchangenickname.TabIndex = 2;
            this.buttonchangenickname.Text = "닉네임변경";
            this.buttonchangenickname.UseVisualStyleBackColor = false;
            this.buttonchangenickname.Visible = false;
            this.buttonchangenickname.Click += new System.EventHandler(this.buttonchangenickname_Click);
            // 
            // labelwelcomeuser
            // 
            this.labelwelcomeuser.AutoSize = true;
            this.labelwelcomeuser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelwelcomeuser.Font = new System.Drawing.Font("휴먼엑스포", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelwelcomeuser.ForeColor = System.Drawing.Color.White;
            this.labelwelcomeuser.Location = new System.Drawing.Point(66, 528);
            this.labelwelcomeuser.Name = "labelwelcomeuser";
            this.labelwelcomeuser.Size = new System.Drawing.Size(505, 32);
            this.labelwelcomeuser.TabIndex = 3;
            this.labelwelcomeuser.Text = "반갑습니다. 닉네임을 설정해주세요.";
            // 
            // buttonfingerminigame
            // 
            this.buttonfingerminigame.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonfingerminigame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfingerminigame.FlatAppearance.BorderSize = 0;
            this.buttonfingerminigame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfingerminigame.Font = new System.Drawing.Font("문체부 제목 돋음체", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfingerminigame.Location = new System.Drawing.Point(224, 580);
            this.buttonfingerminigame.Name = "buttonfingerminigame";
            this.buttonfingerminigame.Size = new System.Drawing.Size(250, 63);
            this.buttonfingerminigame.TabIndex = 4;
            this.buttonfingerminigame.Text = "가위바위보";
            this.buttonfingerminigame.UseVisualStyleBackColor = false;
            this.buttonfingerminigame.Visible = false;
            this.buttonfingerminigame.Click += new System.EventHandler(this.buttonfingerminigame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonDungeonGame.Properties.Resources.maintema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 667);
            this.Controls.Add(this.buttonfingerminigame);
            this.Controls.Add(this.labelwelcomeuser);
            this.Controls.Add(this.buttonchangenickname);
            this.Controls.Add(this.buttonnicknameset);
            this.Controls.Add(this.buttongamestart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon DungeonGame Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonchangenickname;
        public System.Windows.Forms.Button buttongamestart;
        public System.Windows.Forms.Button buttonnicknameset;
        public System.Windows.Forms.Label labelwelcomeuser;
        public System.Windows.Forms.Button buttonfingerminigame;
    }
}

