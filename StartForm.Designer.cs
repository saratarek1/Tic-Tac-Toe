namespace Tic_Toc_Toe
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.STARTGAME = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // STARTGAME
            // 
            this.STARTGAME.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.STARTGAME.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.STARTGAME.Font = new System.Drawing.Font("Wide Latin", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTGAME.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.STARTGAME.Location = new System.Drawing.Point(153, 126);
            this.STARTGAME.Name = "STARTGAME";
            this.STARTGAME.Size = new System.Drawing.Size(278, 52);
            this.STARTGAME.TabIndex = 2;
            this.STARTGAME.Text = "START";
            this.STARTGAME.UseVisualStyleBackColor = false;
            this.STARTGAME.Click += new System.EventHandler(this.STARTGAME_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Toc_Toe.Properties.Resources.Screenshot__132_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 294);
            this.Controls.Add(this.STARTGAME);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Startform";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button STARTGAME;
    }
}

