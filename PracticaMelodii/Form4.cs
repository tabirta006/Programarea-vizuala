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
using System.Data.SqlClient;

namespace PracticaMelodii
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExcludeIntervievatul_Click(object sender, EventArgs e)
        {
            try
            {
                // Deschide conexiunea către baza de date
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verifică dacă codul intervievatului a fost introdus
                    if (!string.IsNullOrWhiteSpace(textCodIntervievat.Text))
                    {
                        // Construiește comanda SQL pentru eliminarea intervievatului din concurs
                        string query = "DELETE FROM ConcursSondaj WHERE IntervievatID = @IntervievatID";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Setează valoarea parametrului pentru codul intervievatului
                        cmd.Parameters.AddWithValue("@IntervievatID", int.Parse(textCodIntervievat.Text));

                        // Execută comanda pentru a elimina intervievatul din concurs
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verifică dacă s-a eliminat cu succes
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Intervievatul a fost exclus din concurs cu succes!");
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a găsit niciun intervievat cu codul specificat în concurs.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Te rog să introduci un cod de intervievat valid.");
                    }

                    // Închide conexiunea
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Mesaj de eroare în caz de problemă
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }
    }
}
