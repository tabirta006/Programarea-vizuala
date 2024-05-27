using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaMelodii
{
    public partial class Form6 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridViewTopParticipanti.AutoGenerateColumns = true;
        }

        private void buttonAfiseazaTop5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT TOP 5
                            pc.ID_Participant,
                            m.NumeMelodie,
                            i.Nume AS NumeIntervievat,
                            i.Prenume AS PrenumeIntervievat,
                            pc.PozitieConcurs
                        FROM ParticipantiConcurs pc
                        INNER JOIN Melodii m ON pc.ID_Melodie = m.MelodieID
                        INNER JOIN Intervievati i ON pc.ID_Intervievat = i.IntervievatID
                        ORDER BY pc.PozitieConcurs ASC";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewTopParticipanti.DataSource = dataTable;

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
