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

namespace PracticaMelodii
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO ConcursSondaj (ConcursID, MelodieID, IntervievatID, Rating) VALUES (@ConcursID, @MelodieID, @IntervievatID, @Rating)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ConcursID", textConcursID.Text);
                    cmd.Parameters.AddWithValue("@MelodieID", textMelodieID.Text);
                    cmd.Parameters.AddWithValue("@IntervievatID", textIntervievatID.Text);
                    cmd.Parameters.AddWithValue("@Rating", textRating.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Răspunsul a fost trimis cu succes!");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MelodieID, NumeMelodie FROM Melodii";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    var dataSource = new List<dynamic>();
                    while (reader.Read())
                    {
                        dataSource.Add(new { Value = reader["MelodieID"], Text = reader["NumeMelodie"].ToString() });
                    }

                    comboBoxFavoriteMelody.DataSource = dataSource;
                    comboBoxFavoriteMelody.DisplayMember = "Text";
                    comboBoxFavoriteMelody.ValueMember = "Value";

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }
    }
}
