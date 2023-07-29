using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Stoker
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbStoker;Integrated Security=True;TrustServerCertificate=true;");
            dataAdapter = new SqlDataAdapter("SELECT id, urunad, urunkatagori, alisfiyati, satisfiyati, adet, barkod, kdv, marka FROM urunler", con);
            dataTable = new DataTable();

            try
            {
                con.Open();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    int rowIndex = dataGridView1.Rows.Add(); // Yeni bir satýr ekleme

                    // Verileri doðru sütunlara yerleþtirme
                    dataGridView1.Rows[rowIndex].Cells["Column1"].Value = row["id"];
                    dataGridView1.Rows[rowIndex].Cells["Column2"].Value = row["urunad"];
                    dataGridView1.Rows[rowIndex].Cells["Column3"].Value = row["urunkatagori"];
                    dataGridView1.Rows[rowIndex].Cells["Column4"].Value = row["alisfiyati"];
                    dataGridView1.Rows[rowIndex].Cells["Column5"].Value = row["satisfiyati"];
                    dataGridView1.Rows[rowIndex].Cells["Column6"].Value = row["adet"];
                    dataGridView1.Rows[rowIndex].Cells["Column7"].Value = row["barkod"];
                    dataGridView1.Rows[rowIndex].Cells["Column8"].Value = row["kdv"];
                    dataGridView1.Rows[rowIndex].Cells["Column9"].Value = row["marka"];
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajýný göster
                MessageBox.Show("Hata : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}