namespace Tic_Toc_Toe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblplayrO = new System.Windows.Forms.Label();
            this.lblplayrX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTic3 = new System.Windows.Forms.Button();
            this.btnTic2 = new System.Windows.Forms.Button();
            this.btnTic9 = new System.Windows.Forms.Button();
            this.btnTic8 = new System.Windows.Forms.Button();
            this.btnTic7 = new System.Windows.Forms.Button();
            this.btnTic6 = new System.Windows.Forms.Button();
            this.btnTic5 = new System.Windows.Forms.Button();
            this.btnTic4 = new System.Windows.Forms.Button();
            this.btnTic1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 361);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Controls.Add(this.btnNewGame);
            this.panel4.Location = new System.Drawing.Point(391, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 158);
            this.panel4.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(206, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 75);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 75);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(3, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(407, 71);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblplayrO);
            this.panel3.Controls.Add(this.lblplayrX);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(388, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 182);
            this.panel3.TabIndex = 1;
            // 
            // lblplayrO
            // 
            this.lblplayrO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblplayrO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblplayrO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayrO.Location = new System.Drawing.Point(269, 99);
            this.lblplayrO.Name = "lblplayrO";
            this.lblplayrO.Size = new System.Drawing.Size(144, 46);
            this.lblplayrO.TabIndex = 3;
            this.lblplayrO.Text = "     0";
            // 
            // lblplayrX
            // 
            this.lblplayrX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblplayrX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblplayrX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayrX.Location = new System.Drawing.Point(271, 29);
            this.lblplayrX.Name = "lblplayrX";
            this.lblplayrX.Size = new System.Drawing.Size(142, 46);
            this.lblplayrX.TabIndex = 2;
            this.lblplayrX.Text = "     0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player O :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player X :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTic3);
            this.panel2.Controls.Add(this.btnTic2);
            this.panel2.Controls.Add(this.btnTic9);
            this.panel2.Controls.Add(this.btnTic8);
            this.panel2.Controls.Add(this.btnTic7);
            this.panel2.Controls.Add(this.btnTic6);
            this.panel2.Controls.Add(this.btnTic5);
            this.panel2.Controls.Add(this.btnTic4);
            this.panel2.Controls.Add(this.btnTic1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 443);
            this.panel2.TabIndex = 0;
            // 
            // btnTic3
            // 
            this.btnTic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic3.Location = new System.Drawing.Point(271, 0);
            this.btnTic3.Name = "btnTic3";
            this.btnTic3.Size = new System.Drawing.Size(108, 107);
            this.btnTic3.TabIndex = 10;
            this.btnTic3.Text = "  ";
            this.btnTic3.UseVisualStyleBackColor = true;
            this.btnTic3.Click += new System.EventHandler(this.btnTic3_Click);
            // 
            // btnTic2
            // 
            this.btnTic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic2.Location = new System.Drawing.Point(134, 0);
            this.btnTic2.Name = "btnTic2";
            this.btnTic2.Size = new System.Drawing.Size(116, 104);
            this.btnTic2.TabIndex = 9;
            this.btnTic2.Text = " ";
            this.btnTic2.UseVisualStyleBackColor = true;
            this.btnTic2.Click += new System.EventHandler(this.btnTic2_Click);
            // 
            // btnTic9
            // 
            this.btnTic9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic9.Location = new System.Drawing.Point(265, 252);
            this.btnTic9.Name = "btnTic9";
            this.btnTic9.Size = new System.Drawing.Size(114, 104);
            this.btnTic9.TabIndex = 8;
            this.btnTic9.UseVisualStyleBackColor = true;
            this.btnTic9.Click += new System.EventHandler(this.btnTic9_Click);
            // 
            // btnTic8
            // 
            this.btnTic8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic8.Location = new System.Drawing.Point(134, 252);
            this.btnTic8.Name = "btnTic8";
            this.btnTic8.Size = new System.Drawing.Size(114, 104);
            this.btnTic8.TabIndex = 7;
            this.btnTic8.UseVisualStyleBackColor = true;
            this.btnTic8.Click += new System.EventHandler(this.btnTic8_Click);
            // 
            // btnTic7
            // 
            this.btnTic7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic7.Location = new System.Drawing.Point(0, 252);
            this.btnTic7.Name = "btnTic7";
            this.btnTic7.Size = new System.Drawing.Size(114, 104);
            this.btnTic7.TabIndex = 6;
            this.btnTic7.UseVisualStyleBackColor = true;
            this.btnTic7.Click += new System.EventHandler(this.btnTic7_Click);
            // 
            // btnTic6
            // 
            this.btnTic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic6.Location = new System.Drawing.Point(265, 123);
            this.btnTic6.Name = "btnTic6";
            this.btnTic6.Size = new System.Drawing.Size(114, 104);
            this.btnTic6.TabIndex = 5;
            this.btnTic6.UseVisualStyleBackColor = true;
            this.btnTic6.Click += new System.EventHandler(this.btnTic6_Click);
            // 
            // btnTic5
            // 
            this.btnTic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic5.Location = new System.Drawing.Point(134, 123);
            this.btnTic5.Name = "btnTic5";
            this.btnTic5.Size = new System.Drawing.Size(114, 104);
            this.btnTic5.TabIndex = 4;
            this.btnTic5.UseVisualStyleBackColor = true;
            this.btnTic5.Click += new System.EventHandler(this.btnTic5_Click);
            // 
            // btnTic4
            // 
            this.btnTic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic4.Location = new System.Drawing.Point(0, 123);
            this.btnTic4.Name = "btnTic4";
            this.btnTic4.Size = new System.Drawing.Size(114, 104);
            this.btnTic4.TabIndex = 3;
            this.btnTic4.UseVisualStyleBackColor = true;
            this.btnTic4.Click += new System.EventHandler(this.btnTic4_Click);
            // 
            // btnTic1
            // 
            this.btnTic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic1.Location = new System.Drawing.Point(0, 0);
            this.btnTic1.Name = "btnTic1";
            this.btnTic1.Size = new System.Drawing.Size(114, 104);
            this.btnTic1.TabIndex = 0;
            this.btnTic1.UseVisualStyleBackColor = true;
            this.btnTic1.Click += new System.EventHandler(this.btnTic1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnTic9;
        private System.Windows.Forms.Button btnTic8;
        private System.Windows.Forms.Button btnTic7;
        private System.Windows.Forms.Button btnTic6;
        private System.Windows.Forms.Button btnTic5;
        private System.Windows.Forms.Button btnTic4;
        private System.Windows.Forms.Button btnTic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayrO;
        private System.Windows.Forms.Label lblplayrX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTic3;
        private System.Windows.Forms.Button btnTic2;
        private System.Windows.Forms.Button btnExit;
    }
}