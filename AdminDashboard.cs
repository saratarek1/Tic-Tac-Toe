using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class AdminDashboard : Form
    {
        private void Settings_Load(object sender, EventArgs e)
        {
            RefreshPlayerData();
        }

        private void RefreshPlayerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Fetch player names
                    string query = "SELECT player_id, player_name FROM [Player_Information]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private string connectionString = @"Data Source=LAPTOP-FT2KH9LD;Initial Catalog=Tic Tac Toe;User ID=sa;Password=sara123;";

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Assuming you have a TextBox named txtName for user input
            string playerName = txtName.Text.Trim();

            if (playerName != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [Player_Information] ([player_name]) VALUES (@playerName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerName", playerName);
                        command.ExecuteNonQuery();
                    }
                }

                // Refresh ComboBoxes/DataGridView after adding a name
                RefreshPlayerData();
                txtName.Text = ""; // Clear the TextBox
            }
            else
            {
                MessageBox.Show("Please enter a player name.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
         
                string playerName = txtName.Text.Trim();

                if (playerName != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Corrected DELETE statement using WHERE clause
                        string query = "DELETE FROM [Player_Information] WHERE [player_name] = @playerName";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@playerName", playerName);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Refresh ComboBoxes/DataGridView after deleting a name
                    RefreshPlayerData();
                    txtName.Text = ""; // Clear the TextBox
                }
                else
                {
                    MessageBox.Show("Please enter a player name to delete.");
                }
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Modify the SELECT query to include ORDER BY clause
                        string query = "SELECT player_id, player_name FROM [Player_Information] ORDER BY [player_name] ASC";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        
                // Confirmation dialog to prevent accidental deletion
                DialogResult result = MessageBox.Show("Are you sure you want to clear all player data?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM [Player_Information]";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show($"{rowsAffected} rows deleted.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error clearing data: " + ex.Message);
                            }
                        }
                    }

                    // Refresh the DataGridView to reflect the changes
                    RefreshPlayerData();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string playerName = txtName.Text.Trim();
                    // Modify the SEARCH query to include ORDER BY clause
                    string query = "SELECT player_id, player_name FROM [Player_Information] WHERE player_name LIKE '%"+playerName+"%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
