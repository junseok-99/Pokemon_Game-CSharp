
namespace PokemonDungeonGame
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.numericUpDownhppotion = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownattpotion = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowndfpotion = new System.Windows.Forms.NumericUpDown();
            this.buttonluckygame = new System.Windows.Forms.Button();
            this.labelstore = new System.Windows.Forms.Label();
            this.labelmoney = new System.Windows.Forms.Label();
            this.labelmoneynum = new System.Windows.Forms.Label();
            this.labelattpotion = new System.Windows.Forms.Label();
            this.labeldfpotion = new System.Windows.Forms.Label();
            this.labelhppotion = new System.Windows.Forms.Label();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.labelhppotionprice = new System.Windows.Forms.Label();
            this.labelattporionprice = new System.Windows.Forms.Label();
            this.labeldfpotionprice = new System.Windows.Forms.Label();
            this.labelcurrentprice = new System.Windows.Forms.Label();
            this.labelcurrentprice_num = new System.Windows.Forms.Label();
            this.labelluckystate = new System.Windows.Forms.Label();
            this.labelluckymoney = new System.Windows.Forms.Label();
            this.pictureBoxdfpotion = new System.Windows.Forms.PictureBox();
            this.pictureBoxattpotion = new System.Windows.Forms.PictureBox();
            this.pictureBoxhppotion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhppotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownattpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndfpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdfpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxattpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhppotion)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownhppotion
            // 
            this.numericUpDownhppotion.Location = new System.Drawing.Point(55, 450);
            this.numericUpDownhppotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownhppotion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownhppotion.Name = "numericUpDownhppotion";
            this.numericUpDownhppotion.Size = new System.Drawing.Size(130, 25);
            this.numericUpDownhppotion.TabIndex = 3;
            this.numericUpDownhppotion.ValueChanged += new System.EventHandler(this.numericUpDownhppotion_ValueChanged);
            // 
            // numericUpDownattpotion
            // 
            this.numericUpDownattpotion.Location = new System.Drawing.Point(504, 450);
            this.numericUpDownattpotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownattpotion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownattpotion.Name = "numericUpDownattpotion";
            this.numericUpDownattpotion.Size = new System.Drawing.Size(130, 25);
            this.numericUpDownattpotion.TabIndex = 6;
            this.numericUpDownattpotion.ValueChanged += new System.EventHandler(this.numericUpDownattpotion_ValueChanged);
            // 
            // numericUpDowndfpotion
            // 
            this.numericUpDowndfpotion.Location = new System.Drawing.Point(286, 450);
            this.numericUpDowndfpotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDowndfpotion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDowndfpotion.Name = "numericUpDowndfpotion";
            this.numericUpDowndfpotion.Size = new System.Drawing.Size(130, 25);
            this.numericUpDowndfpotion.TabIndex = 7;
            this.numericUpDowndfpotion.ValueChanged += new System.EventHandler(this.numericUpDowndfpotion_ValueChanged);
            // 
            // buttonluckygame
            // 
            this.buttonluckygame.BackColor = System.Drawing.Color.Black;
            this.buttonluckygame.Font = new System.Drawing.Font("문체부 돋음체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonluckygame.ForeColor = System.Drawing.Color.White;
            this.buttonluckygame.Location = new System.Drawing.Point(717, 195);
            this.buttonluckygame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonluckygame.Name = "buttonluckygame";
            this.buttonluckygame.Size = new System.Drawing.Size(146, 158);
            this.buttonluckygame.TabIndex = 8;
            this.buttonluckygame.Text = "행운의뽑기";
            this.buttonluckygame.UseVisualStyleBackColor = false;
            this.buttonluckygame.Click += new System.EventHandler(this.buttonluckygame_Click);
            // 
            // labelstore
            // 
            this.labelstore.AutoSize = true;
            this.labelstore.Font = new System.Drawing.Font("문체부 제목 돋음체", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelstore.Location = new System.Drawing.Point(343, 31);
            this.labelstore.Name = "labelstore";
            this.labelstore.Size = new System.Drawing.Size(196, 80);
            this.labelstore.TabIndex = 9;
            this.labelstore.Text = "상점";
            // 
            // labelmoney
            // 
            this.labelmoney.AutoSize = true;
            this.labelmoney.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelmoney.Location = new System.Drawing.Point(14, 122);
            this.labelmoney.Name = "labelmoney";
            this.labelmoney.Size = new System.Drawing.Size(293, 47);
            this.labelmoney.TabIndex = 10;
            this.labelmoney.Text = "보유 Money :";
            // 
            // labelmoneynum
            // 
            this.labelmoneynum.AutoSize = true;
            this.labelmoneynum.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelmoneynum.Location = new System.Drawing.Point(290, 129);
            this.labelmoneynum.Name = "labelmoneynum";
            this.labelmoneynum.Size = new System.Drawing.Size(133, 47);
            this.labelmoneynum.TabIndex = 11;
            this.labelmoneynum.Text = "300원";
            // 
            // labelattpotion
            // 
            this.labelattpotion.AutoSize = true;
            this.labelattpotion.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelattpotion.Location = new System.Drawing.Point(485, 362);
            this.labelattpotion.Name = "labelattpotion";
            this.labelattpotion.Size = new System.Drawing.Size(188, 47);
            this.labelattpotion.TabIndex = 12;
            this.labelattpotion.Text = "ATT포션";
            // 
            // labeldfpotion
            // 
            this.labeldfpotion.AutoSize = true;
            this.labeldfpotion.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeldfpotion.Location = new System.Drawing.Point(278, 361);
            this.labeldfpotion.Name = "labeldfpotion";
            this.labeldfpotion.Size = new System.Drawing.Size(166, 47);
            this.labeldfpotion.TabIndex = 13;
            this.labeldfpotion.Text = "DF포션";
            // 
            // labelhppotion
            // 
            this.labelhppotion.AutoSize = true;
            this.labelhppotion.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelhppotion.Location = new System.Drawing.Point(40, 361);
            this.labelhppotion.Name = "labelhppotion";
            this.labelhppotion.Size = new System.Drawing.Size(168, 47);
            this.labelhppotion.TabIndex = 14;
            this.labelhppotion.Text = "HP포션";
            // 
            // buttonbuy
            // 
            this.buttonbuy.BackColor = System.Drawing.Color.Black;
            this.buttonbuy.Font = new System.Drawing.Font("문체부 돋음체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonbuy.ForeColor = System.Drawing.Color.White;
            this.buttonbuy.Location = new System.Drawing.Point(477, 494);
            this.buttonbuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(146, 54);
            this.buttonbuy.TabIndex = 16;
            this.buttonbuy.Text = "구매";
            this.buttonbuy.UseVisualStyleBackColor = false;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Black;
            this.buttonexit.Font = new System.Drawing.Font("문체부 돋음체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Location = new System.Drawing.Point(717, 494);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(146, 54);
            this.buttonexit.TabIndex = 17;
            this.buttonexit.Text = "나가기";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // labelhppotionprice
            // 
            this.labelhppotionprice.AutoSize = true;
            this.labelhppotionprice.Font = new System.Drawing.Font("문체부 제목 돋음체", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelhppotionprice.Location = new System.Drawing.Point(74, 408);
            this.labelhppotionprice.Name = "labelhppotionprice";
            this.labelhppotionprice.Size = new System.Drawing.Size(110, 37);
            this.labelhppotionprice.TabIndex = 18;
            this.labelhppotionprice.Text = "250원";
            // 
            // labelattporionprice
            // 
            this.labelattporionprice.AutoSize = true;
            this.labelattporionprice.Font = new System.Drawing.Font("문체부 제목 돋음체", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelattporionprice.Location = new System.Drawing.Point(523, 408);
            this.labelattporionprice.Name = "labelattporionprice";
            this.labelattporionprice.Size = new System.Drawing.Size(110, 37);
            this.labelattporionprice.TabIndex = 19;
            this.labelattporionprice.Text = "350원";
            // 
            // labeldfpotionprice
            // 
            this.labeldfpotionprice.AutoSize = true;
            this.labeldfpotionprice.Font = new System.Drawing.Font("문체부 제목 돋음체", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeldfpotionprice.Location = new System.Drawing.Point(307, 408);
            this.labeldfpotionprice.Name = "labeldfpotionprice";
            this.labeldfpotionprice.Size = new System.Drawing.Size(110, 37);
            this.labeldfpotionprice.TabIndex = 20;
            this.labeldfpotionprice.Text = "300원";
            // 
            // labelcurrentprice
            // 
            this.labelcurrentprice.AutoSize = true;
            this.labelcurrentprice.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelcurrentprice.Location = new System.Drawing.Point(14, 501);
            this.labelcurrentprice.Name = "labelcurrentprice";
            this.labelcurrentprice.Size = new System.Drawing.Size(244, 47);
            this.labelcurrentprice.TabIndex = 21;
            this.labelcurrentprice.Text = "현재가격 :";
            // 
            // labelcurrentprice_num
            // 
            this.labelcurrentprice_num.AutoSize = true;
            this.labelcurrentprice_num.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelcurrentprice_num.Location = new System.Drawing.Point(278, 505);
            this.labelcurrentprice_num.Name = "labelcurrentprice_num";
            this.labelcurrentprice_num.Size = new System.Drawing.Size(89, 47);
            this.labelcurrentprice_num.TabIndex = 22;
            this.labelcurrentprice_num.Text = "0원";
            // 
            // labelluckystate
            // 
            this.labelluckystate.AutoSize = true;
            this.labelluckystate.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelluckystate.Location = new System.Drawing.Point(731, 362);
            this.labelluckystate.Name = "labelluckystate";
            this.labelluckystate.Size = new System.Drawing.Size(125, 47);
            this.labelluckystate.TabIndex = 23;
            this.labelluckystate.Text = "성공!";
            this.labelluckystate.Visible = false;
            // 
            // labelluckymoney
            // 
            this.labelluckymoney.AutoSize = true;
            this.labelluckymoney.Font = new System.Drawing.Font("문체부 제목 돋음체", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelluckymoney.Location = new System.Drawing.Point(693, 409);
            this.labelluckymoney.Name = "labelluckymoney";
            this.labelluckymoney.Size = new System.Drawing.Size(218, 37);
            this.labelluckymoney.TabIndex = 24;
            this.labelluckymoney.Text = "500원 획득!";
            this.labelluckymoney.Visible = false;
            // 
            // pictureBoxdfpotion
            // 
            this.pictureBoxdfpotion.BackColor = System.Drawing.Color.White;
            this.pictureBoxdfpotion.Image = global::PokemonDungeonGame.Properties.Resources.att;
            this.pictureBoxdfpotion.Location = new System.Drawing.Point(286, 195);
            this.pictureBoxdfpotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxdfpotion.Name = "pictureBoxdfpotion";
            this.pictureBoxdfpotion.Size = new System.Drawing.Size(130, 158);
            this.pictureBoxdfpotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxdfpotion.TabIndex = 5;
            this.pictureBoxdfpotion.TabStop = false;
            // 
            // pictureBoxattpotion
            // 
            this.pictureBoxattpotion.Image = global::PokemonDungeonGame.Properties.Resources.mp;
            this.pictureBoxattpotion.Location = new System.Drawing.Point(504, 195);
            this.pictureBoxattpotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxattpotion.Name = "pictureBoxattpotion";
            this.pictureBoxattpotion.Size = new System.Drawing.Size(130, 158);
            this.pictureBoxattpotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxattpotion.TabIndex = 4;
            this.pictureBoxattpotion.TabStop = false;
            // 
            // pictureBoxhppotion
            // 
            this.pictureBoxhppotion.Image = global::PokemonDungeonGame.Properties.Resources.hp;
            this.pictureBoxhppotion.Location = new System.Drawing.Point(55, 195);
            this.pictureBoxhppotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxhppotion.Name = "pictureBoxhppotion";
            this.pictureBoxhppotion.Size = new System.Drawing.Size(130, 158);
            this.pictureBoxhppotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxhppotion.TabIndex = 0;
            this.pictureBoxhppotion.TabStop = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.labelluckymoney);
            this.Controls.Add(this.labelluckystate);
            this.Controls.Add(this.labelcurrentprice_num);
            this.Controls.Add(this.labelcurrentprice);
            this.Controls.Add(this.labeldfpotionprice);
            this.Controls.Add(this.labelattporionprice);
            this.Controls.Add(this.labelhppotionprice);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonbuy);
            this.Controls.Add(this.labelhppotion);
            this.Controls.Add(this.labeldfpotion);
            this.Controls.Add(this.labelattpotion);
            this.Controls.Add(this.labelmoneynum);
            this.Controls.Add(this.labelmoney);
            this.Controls.Add(this.labelstore);
            this.Controls.Add(this.buttonluckygame);
            this.Controls.Add(this.numericUpDowndfpotion);
            this.Controls.Add(this.numericUpDownattpotion);
            this.Controls.Add(this.pictureBoxdfpotion);
            this.Controls.Add(this.pictureBoxattpotion);
            this.Controls.Add(this.numericUpDownhppotion);
            this.Controls.Add(this.pictureBoxhppotion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhppotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownattpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndfpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdfpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxattpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhppotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxhppotion;
        private System.Windows.Forms.PictureBox pictureBoxattpotion;
        private System.Windows.Forms.PictureBox pictureBoxdfpotion;
        private System.Windows.Forms.Label labelstore;
        private System.Windows.Forms.Label labelmoney;
        private System.Windows.Forms.Label labelattpotion;
        private System.Windows.Forms.Label labeldfpotion;
        private System.Windows.Forms.Label labelhppotion;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label labelhppotionprice;
        private System.Windows.Forms.Label labelattporionprice;
        private System.Windows.Forms.Label labeldfpotionprice;
        private System.Windows.Forms.Label labelcurrentprice;
        private System.Windows.Forms.Label labelcurrentprice_num;
        public System.Windows.Forms.Button buttonluckygame;
        public System.Windows.Forms.NumericUpDown numericUpDownhppotion;
        public System.Windows.Forms.NumericUpDown numericUpDownattpotion;
        public System.Windows.Forms.NumericUpDown numericUpDowndfpotion;
        public System.Windows.Forms.Label labelluckystate;
        public System.Windows.Forms.Label labelluckymoney;
        public System.Windows.Forms.Label labelmoneynum;
    }
}