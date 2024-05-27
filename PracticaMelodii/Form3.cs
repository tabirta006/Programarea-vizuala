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
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Deschide conexiunea către baza de date
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construiește comanda SQL
                    string query = "INSERT INTO Melodii (MelodieID, NumeMelodie, Artist, AnLansare, GenMuzical) VALUES (@MelodieID, @NumeMelodie, @Artist, @AnLansare, @GenMuzical)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Setează valorile parametrilor din controalele text
                    cmd.Parameters.AddWithValue("@MelodieID", textID.Text);
                    cmd.Parameters.AddWithValue("@NumeMelodie", textNume.Text);
                    cmd.Parameters.AddWithValue("@Artist", textArtist.Text);
                    cmd.Parameters.AddWithValue("@AnLansare", textAn.Text);
                    cmd.Parameters.AddWithValue("@GenMuzical", textGen.Text);

                    // Execută comanda
                    cmd.ExecuteNonQuery();

                    // Mesaj de succes
                    MessageBox.Show("Înregistrarea a fost inserată cu succes!");

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

        private void buttonInsertIntervievat_Click(object sender, EventArgs e)
        {
            try
            {
                // Deschide conexiunea către baza de date
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construiește comanda SQL pentru inserarea unui nou intervievat
                    string query = "INSERT INTO Intervievati (IntervievatID, Nume, Prenume, Varsta, Oras) VALUES (@IntervievatID, @Nume, @Prenume, @Varsta, @Oras)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Setează valorile parametrilor din controalele text
                    cmd.Parameters.AddWithValue("@IntervievatID", textIntervievatID.Text);
                    cmd.Parameters.AddWithValue("@Nume", textNumeIntervievat.Text);
                    cmd.Parameters.AddWithValue("@Prenume", textPrenumeIntervievat.Text);
                    cmd.Parameters.AddWithValue("@Varsta", textVarsta.Text);
                    cmd.Parameters.AddWithValue("@Oras", textOras.Text);

                    // Execută comanda pentru a insera intervievatul
                    cmd.ExecuteNonQuery();

                    // Mesaj de succes
                    MessageBox.Show("Intervievatul a fost înregistrat cu succes!");

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
