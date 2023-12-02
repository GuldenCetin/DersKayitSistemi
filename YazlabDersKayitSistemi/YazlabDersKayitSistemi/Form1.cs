using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Data;

namespace YazlabDersKayitSistemi
{
    public partial class Form1 : Form
    {
        AdminSayfasi adminSayfa;
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void buttonAdminGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT sifre FROM admintablosu WHERE kullanici = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                label3.Text  = sifre;
                if (sifre == textBoxSifre.Text)
                {
                    adminSayfa = new AdminSayfasi();
                    adminSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�...");
                    label3.Text = sifre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baglanti hatasi" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}