namespace Tic_Toc_Toe
{
    partial class AdmainClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmainClick));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(264, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(280, 191);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 35);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "EXIT";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(137, 191);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(119, 35);
            this.Login.TabIndex = 10;
            this.Login.Text = "LOGIN";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(264, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // AdmainClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 246);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdmainClick";
            this.Text = "Admain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}