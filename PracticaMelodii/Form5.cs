using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PracticaMelodii
{
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAfiseazaTop3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Inserează melodiile în tabela MelodiiPopularitate
                    string insertQuery = @"
                        TRUNCATE TABLE MelodiiPopularitate;

                        INSERT INTO MelodiiPopularitate (IDMelodie, MelodieNume, Artist, TotalPuncte)
                        SELECT 
                            m.MelodieID,
                            m.NumeMelodie,
                            m.Artist,
                            SUM(
                                CASE
                                    WHEN rs.Loc = 1 THEN 3
                                    WHEN rs.Loc = 2 THEN 2
                                    WHEN rs.Loc = 3 THEN 1
                                    ELSE 0
                                END
                            ) AS TotalPuncte
                        FROM 
                            Melodii m
                        LEFT JOIN 
                            RezultateSondaj rs ON m.MelodieID = rs.IDMelodie
                        GROUP BY 
                            m.MelodieID, m.NumeMelodie, m.Artist
                        ORDER BY 
                            TotalPuncte DESC;
                    ";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.ExecuteNonQuery();

                    // Selectează primele 3 melodii
                    string selectQuery = "SELECT TOP 3 IDMelodie, MelodieNume, Artist, TotalPuncte FROM MelodiiPopularitate ORDER BY TotalPuncte DESC";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewTopMelodii.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Inițializează DataGridView pentru a afișa datele
            dataGridViewTopMelodii.AutoGenerateColumns = true;
            dataGridViewParticipanti.AutoGenerateColumns = true;
        }

        private void buttonAfiseazaParticipanti_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ParticipantiConcurs ORDER BY PozitieConcurs ASC";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewParticipanti.DataSource = dataTable;

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

