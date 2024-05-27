using System.Data;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace PracticaMelodii
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=L20_PC08\SQLEXPRESS;Initial Catalog=Melodii;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sterge continutul tabelei MelodiiPopularitate daca exista
                    string truncateQuery = "TRUNCATE TABLE MelodiiPopularitate";
                    SqlCommand truncateCmd = new SqlCommand(truncateQuery, connection);
                    truncateCmd.ExecuteNonQuery();

                    // Insereaza melodiile in tabela MelodiiPopularitate
                    string insertQuery = @"INSERT INTO MelodiiPopularitate (IDMelodie, MelodieNume, Artist, TotalPuncte)
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
                    TotalPuncte DESC";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Tabela de popularitate a fost actualizată cu succes!");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void labelExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Nume, Prenume, Varsta, Oras FROM Intervievati WHERE Varsta <= 18";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(dataTable, "Participanti < 18 ani");
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Salvează fișierul Excel";
                        saveFileDialog.ShowDialog();

                        if (saveFileDialog.FileName != "")
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Fișierul Excel a fost salvat cu succes!");
                        }
                    }

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
