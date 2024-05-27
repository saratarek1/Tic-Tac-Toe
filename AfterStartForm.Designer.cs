namespace Tic_Toc_Toe
{
    partial class AfterStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterStartForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.NEWGAME = new System.Windows.Forms.Button();
            this.newname = new System.Windows.Forms.Button();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(401, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "player 2\r\n\r\n";
            // 
            // player1
            // 
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(12, 82);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(108, 28);
            this.player1.TabIndex = 6;
            this.player1.Text = "player 1";
            // 
            // NEWGAME
            // 
            this.NEWGAME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NEWGAME.BackgroundImage")));
            this.NEWGAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NEWGAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWGAME.Location = new System.Drawing.Point(344, 161);
            this.NEWGAME.Name = "NEWGAME";
            this.NEWGAME.Size = new System.Drawing.Size(155, 69);
            this.NEWGAME.TabIndex = 9;
            this.NEWGAME.Text = "\r\n";
            this.NEWGAME.UseVisualStyleBackColor = true;
            this.NEWGAME.Click += new System.EventHandler(this.NEWGAME_Click);
            // 
            // newname
            // 
            this.newname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newname.BackgroundImage")));
            this.newname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newname.Location = new System.Drawing.Point(179, 161);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(147, 69);
            this.newname.TabIndex = 11;
            this.newname.UseVisualStyleBackColor = true;
            this.newname.Click += new System.EventHandler(this.newname_Click);
            // 
            // AfterStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 264);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.NEWGAME);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AfterStartForm";
            this.Text = "AfterStartForm";
            this.Load += new System.EventHandler(this.afterstartform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Button NEWGAME;
        private System.Windows.Forms.Button newname;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
    }
}