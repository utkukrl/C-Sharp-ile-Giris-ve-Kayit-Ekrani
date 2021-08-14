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

namespace FinanceTrackerr
{
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = FinanceTracker; Integrated Security = true");
            cmd = new SqlCommand();

            string sorgu = "INSERT INTO Uye (k_ad,k_sifre,k_resifre,k_telefon) VALUES(@k_ad,@k_sifre,@k_resifre,@k_telefon)";
            cmd = new SqlCommand(sorgu , con);
            cmd.Parameters.AddWithValue("@k_ad",tbxKayitAdi.Text);
            cmd.Parameters.AddWithValue("@k_sifre", tbxKayitSifre.Text);
            cmd.Parameters.AddWithValue("@k_resifre", tbxKayitSifreTkr.Text);
            cmd.Parameters.AddWithValue("@k_telefon", tbxTelefon.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Tamamlandı! Giriş Yapabilirsiniz.");


        }

        private void btnKayittanGiris_Click(object sender, EventArgs e)
        {
            Giris f4 = new Giris();
            f4.Show();
            this.Hide();
        }
    }
}
