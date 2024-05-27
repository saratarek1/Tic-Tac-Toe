namespace Tic_Toc_Toe
{
    partial class NameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
            this.yourname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NEWGAME = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.player1name = new System.Windows.Forms.Label();
            this.player2name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yourname
            // 
            this.yourname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourname.Location = new System.Drawing.Point(12, 27);
            this.yourname.Name = "yourname";
            this.yourname.Size = new System.Drawing.Size(295, 36);
            this.yourname.TabIndex = 0;
            this.yourname.Text = "Enter your name ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 1;
            // 
            // NEWGAME
            // 
            this.NEWGAME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NEWGAME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NEWGAME.BackgroundImage")));
            this.NEWGAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NEWGAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWGAME.Location = new System.Drawing.Point(18, 204);
            this.NEWGAME.Name = "NEWGAME";
            this.NEWGAME.Size = new System.Drawing.Size(391, 56);
            this.NEWGAME.TabIndex = 10;
            this.NEWGAME.Text = "START        GAME";
            this.NEWGAME.UseVisualStyleBackColor = false;
            this.NEWGAME.Click += new System.EventHandler(this.NEWGAME_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 11;
            // 
            // player1name
            // 
            this.player1name.AutoSize = true;
            this.player1name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1name.Location = new System.Drawing.Point(0, 86);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(126, 32);
            this.player1name.TabIndex = 12;
            this.player1name.Text = "Player 1";
            // 
            // player2name
            // 
            this.player2name.AutoSize = true;
            this.player2name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2name.Location = new System.Drawing.Point(0, 138);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(126, 32);
            this.player2name.TabIndex = 13;
            this.player2name.Text = "Player 2";
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NEWGAME);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yourname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameForm";
            this.Text = "NewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NEWGAME;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label player1name;
        private System.Windows.Forms.Label player2name;
    }
}