using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tic_Toc_Toe
{
    public partial class AfterStartForm : Form
    {
        public AfterStartForm()
        {
            InitializeComponent();

        }
        private void NEWGAME_Click(object sender, EventArgs e)
        {
            Game After = new Game(comboBox1.Text,comboBox2.Text);
            After.Show();
        }
        private void newname_Click(object sender, EventArgs e)
        {
            NameForm name = new NameForm();
            name.Show();
        }



        private void afterstartform_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FT2KH9LD;Initial Catalog=Tic Tac Toe;User ID=sa;Password=sara123;"))
            {
                try
                {
                    string query = "select *  FROM [Tic Tac Toe].[dbo].[Player_Information]";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Player_Information");
                    comboBox1.DisplayMember = "player_name";
                    comboBox1.ValueMember = "player_id";
                    comboBox1.DataSource = ds.Tables["Player_Information"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FT2KH9LD;Initial Catalog=Tic Tac Toe;User ID=sa;Password=sara123;"))
            {
                try
                {
                    string query = "select *  FROM [Tic Tac Toe].[dbo].[Player_Information]";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Player_Information");
                    comboBox2.DisplayMember = "player_name";
                    comboBox2.ValueMember = "player_id";
                    comboBox2.DataSource = ds.Tables["Player_Information"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }
    }
}
