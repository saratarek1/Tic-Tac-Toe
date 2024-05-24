using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tic_Toc_Toe
{
    public partial class AdmainClick : Form
    {
        public AdmainClick()
        {
            InitializeComponent();
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

            else if (userName == "sara" && password == "sarsora")
            {
                MessageBox.Show("Welcome, Sara!");
                AdminDashboard afterLogin = new AdminDashboard();
                afterLogin.Show();
            }

            else
                MessageBox.Show("Invalid username or password.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
