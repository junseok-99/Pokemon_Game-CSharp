
namespace PokemonDungeonGame
{
    partial class PauseGame_Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseGame_Multi));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Turquoise;
            this.buttonExit.Font = new System.Drawing.Font("휴먼엑스포", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(92, 160);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(320, 90);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "게임종료";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReGame
            // 
            this.buttonReGame.BackColor = System.Drawing.Color.Turquoise;
            this.buttonReGame.Font = new System.Drawing.Font("휴먼엑스포", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonReGame.ForeColor = System.Drawing.Color.Blue;
            this.buttonReGame.Location = new System.Drawing.Point(92, 28);
            this.buttonReGame.Name = "buttonReGame";
            this.buttonReGame.Size = new System.Drawing.Size(320, 90);
            this.buttonReGame.TabIndex = 2;
            this.buttonReGame.Text = "이어하기";
            this.buttonReGame.UseVisualStyleBackColor = false;
            this.buttonReGame.Click += new System.EventHandler(this.buttonReGame_Click);
            // 
            // PauseGame_Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(511, 284);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PauseGame_Multi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PauseGame_Multi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReGame;
    }
}