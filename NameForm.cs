﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tic_Toc_Toe
{
    public partial class NameForm : Form
    {
        private string player1 = "";
        private string player2 = "";
        public NameForm()
        {
            InitializeComponent();
            this.setPlayer1("");
            this.setPlayer2("");

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void setPlayer1(string str)
        {
            this.player1 = str;   
        }

        public void setPlayer2(string str)
        {
            this.player2 = str;   
        }
        public string getPlayer1() { return this.player1; }
        public string getPlayer2() { return this.player2;}


        private void NEWGAME_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.setPlayer1 ( textBox1.Text);
                this.setPlayer2 ( textBox2.Text);

                if (IsInputLengthValid(this.getPlayer1()) && IsInputLengthValid(this.getPlayer2()))
                {
                    MessageBox.Show("VALID INPUT");
                }
                else
                {
                    throw new ArgumentException("INPUT is INVALID. Please enter names using only letters.");

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox1.Clear();

            string connectionString = @"Data Source=LAPTOP-FT2KH9LD;Initial Catalog=Tic Tac Toe;User ID=sa;Password=sara123;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryPlayer1 = $"INSERT INTO [Player_Information] ([player_name]) VALUES ('{this.getPlayer1()}')";
                string queryPlayer2 = $"INSERT INTO [Player_Information] ([player_name]) VALUES ('{this.getPlayer2()}')";

                using (SqlCommand command = new SqlCommand(queryPlayer1, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand(queryPlayer2, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            Game After = new Game(this.getPlayer1(), this.getPlayer2());

            After.Show();

        }
        private bool IsInputLengthValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");

        }
    }      
}
