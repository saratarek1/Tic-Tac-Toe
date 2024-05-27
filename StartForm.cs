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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void STARTGAME_Click(object sender, EventArgs e)
        {
            Login AfterNewGame = new Login();
            AfterNewGame.Show();
           
        }
    }
}
