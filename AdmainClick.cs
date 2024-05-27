using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tic_Toc_Toe
{
    public partial class AdmainClick : Form
    {
        public AdmainClick() //constructor
        {
            InitializeComponent(); //load of page 
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text.Trim(); // Trim whitespace
            string password = txtPassword.Text.Trim(); // Trim whitespace
            Console.WriteLine(userName);

            if (userName == "")
                MessageBox.Show("Please enter your username.");

            else if (password == "")
                MessageBox.Show("Please enter your password.");


            else
            {
                string connectionString = @"Data Source=LAPTOP-FT2KH9LD;Initial Catalog=Tic Tac Toe;User ID=sa;Password=sara123;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryPlayer1 = $"SELECT * FROM [Admin] WHERE username = '" + userName + "';";

                    using (SqlCommand command = new SqlCommand(queryPlayer1, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        int no = 0; 
                        while (reader.Read())
                        {    
                            if (userName == reader["username"].ToString() && password == reader["password"].ToString())
                            {
                                no++;   
                                MessageBox.Show("Welcome," +userName);
                                AdminDashboard afterLogin = new AdminDashboard();
                                afterLogin.Show();

                            }
                            
                        }
                        if(no == 0)
                        {
                                MessageBox.Show("Invalid username or password.");
                        }

                    }

                    connection.Close();
                }
               
            }

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
