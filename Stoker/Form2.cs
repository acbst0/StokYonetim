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
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stoker
{
    public partial class Form2 : Form
    {

        private SqlConnection con;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        SqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbStoker;Integrated Security=True;TrustServerCertificate=true;");
                dataAdapter = new SqlDataAdapter("SELECT id, urunad, urunkatagori, alisfiyati, satisfiyati, adet, barkod, kdv, marka FROM urunler", con);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into urunler(urunad,urunkatagori,alisfiyati,satisfiyati,adet,barkod,kdv,marka) values (" + txtAd.Text + ",'" + txtKategori.Text + "','" + txtAlis.Text + "','" + txtSatis.Text + "','" + txtAdet.Text + "','" + txtBarkod.Text + "','" + txtKdv.Text + "','" + txtMarka.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
    }
}
