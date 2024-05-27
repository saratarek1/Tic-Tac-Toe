using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AdmainLogin_Click(object sender, EventArgs e)
        {
            AdmainClick admainClick = new AdmainClick();
            admainClick.Show(); 
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {
            AfterStartForm After= new AfterStartForm();
             After.Show();
        }
    }
}
