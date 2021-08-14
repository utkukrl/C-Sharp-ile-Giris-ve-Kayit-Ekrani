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

namespace FinanceTrackerr
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = tbxAd.Text;
            string sifre = tbxSifre.Text;
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = FinanceTracker; Integrated Security = true");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Uye where k_ad='" + tbxAd.Text + "' AND k_sifre='" + tbxSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa f2 = new AnaSayfa();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayıtFormu f3 = new KayıtFormu();
            f3.Show();
            this.Hide();
        }
    }
}
