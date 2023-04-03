
namespace PokemonDungeonGame
{
    partial class Nameform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nameform));
            this.buttonNicknameSetClear = new System.Windows.Forms.Button();
            this.buttonnickformout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnewnickname = new System.Windows.Forms.TextBox();
            this.buttonNickTextboxdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNicknameSetClear
            // 
            this.buttonNicknameSetClear.BackColor = System.Drawing.Color.White;
            this.buttonNicknameSetClear.Font = new System.Drawing.Font("한컴 윤고딕 250", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNicknameSetClear.Location = new System.Drawing.Point(39, 105);
            this.buttonNicknameSetClear.Name = "buttonNicknameSetClear";
            this.buttonNicknameSetClear.Size = new System.Drawing.Size(152, 38);
            this.buttonNicknameSetClear.TabIndex = 0;
            this.buttonNicknameSetClear.Text = "완료";
            this.buttonNicknameSetClear.UseVisualStyleBackColor = false;
            this.buttonNicknameSetClear.Click += new System.EventHandler(this.buttonNicknameSetClear_Click);
            // 
            // buttonnickformout
            // 
            this.buttonnickformout.BackColor = System.Drawing.Color.Black;
            this.buttonnickformout.Font = new System.Drawing.Font("한컴 윤고딕 250", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonnickformout.ForeColor = System.Drawing.Color.White;
            this.buttonnickformout.Location = new System.Drawing.Point(292, 105);
            this.buttonnickformout.Name = "buttonnickformout";
            this.buttonnickformout.Size = new System.Drawing.Size(160, 38);
            this.buttonnickformout.TabIndex = 1;
            this.buttonnickformout.Text = "나가기";
            this.buttonnickformout.UseVisualStyleBackColor = false;
            this.buttonnickformout.Click += new System.EventHandler(this.buttonnickformout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "닉네임 : ";
            // 
            // textBoxnewnickname
            // 
            this.textBoxnewnickname.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxnewnickname.Location = new System.Drawing.Point(129, 30);
            this.textBoxnewnickname.Name = "textBoxnewnickname";
            this.textBoxnewnickname.Size = new System.Drawing.Size(244, 32);
            this.textBoxnewnickname.TabIndex = 3;
            this.textBoxnewnickname.Text = "글자 수 8자이하";
            this.textBoxnewnickname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Delete_Text);
            this.textBoxnewnickname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Nickname);
            // 
            // buttonNickTextboxdelete
            // 
            this.buttonNickTextboxdelete.BackColor = System.Drawing.Color.Black;
            this.buttonNickTextboxdelete.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNickTextboxdelete.ForeColor = System.Drawing.Color.Red;
            this.buttonNickTextboxdelete.Location = new System.Drawing.Point(389, 28);
            this.buttonNickTextboxdelete.Name = "buttonNickTextboxdelete";
            this.buttonNickTextboxdelete.Size = new System.Drawing.Size(102, 38);
            this.buttonNickTextboxdelete.TabIndex = 4;
            this.buttonNickTextboxdelete.Text = "초기화";
            this.buttonNickTextboxdelete.UseVisualStyleBackColor = false;
            this.buttonNickTextboxdelete.Click += new System.EventHandler(this.buttonNickTextboxdelete_Click);
            // 
            // Nameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 168);
            this.Controls.Add(this.buttonNickTextboxdelete);
            this.Controls.Add(this.textBoxnewnickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonnickformout);
            this.Controls.Add(this.buttonNicknameSetClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Nameform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nameform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNicknameSetClear;
        private System.Windows.Forms.Button buttonnickformout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnewnickname;
        private System.Windows.Forms.Button buttonNickTextboxdelete;
    }
}