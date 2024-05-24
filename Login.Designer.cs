namespace Tic_Toc_Toe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.ADMAIN = new System.Windows.Forms.Label();
            this.AdmainLogin = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // ADMAIN
            // 
            this.ADMAIN.AutoSize = true;
            this.ADMAIN.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMAIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADMAIN.Location = new System.Drawing.Point(107, 134);
            this.ADMAIN.Name = "ADMAIN";
            this.ADMAIN.Size = new System.Drawing.Size(143, 37);
            this.ADMAIN.TabIndex = 1;
            this.ADMAIN.Text = "ADMAIN";
            // 
            // AdmainLogin
            // 
            this.AdmainLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdmainLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmainLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdmainLogin.Location = new System.Drawing.Point(276, 134);
            this.AdmainLogin.Name = "AdmainLogin";
            this.AdmainLogin.Size = new System.Drawing.Size(147, 37);
            this.AdmainLogin.TabIndex = 3;
            this.AdmainLogin.Text = "CLICK";
            this.AdmainLogin.UseVisualStyleBackColor = false;
            this.AdmainLogin.Click += new System.EventHandler(this.AdmainLogin_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserLogin.Location = new System.Drawing.Point(276, 55);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(147, 37);
            this.UserLogin.TabIndex = 4;
            this.UserLogin.Text = "CLICK";
            this.UserLogin.UseVisualStyleBackColor = true;
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 253);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.AdmainLogin);
            this.Controls.Add(this.ADMAIN);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ADMAIN;
        private System.Windows.Forms.Button AdmainLogin;
        private System.Windows.Forms.Button UserLogin;
    }
}