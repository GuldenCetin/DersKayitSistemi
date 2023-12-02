using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Data;

namespace YazlabDersKayitSistemi
{
    public partial class Form1 : Form
    {
        AdminSayfasi adminSayfa;
        OgretmenSayfasi ogretmenSayfa;
        OgrenciSayfasi ogrenciSayfa;
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password= root ");
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
                if (sifre == textBoxSifre.Text)
                {
                    adminSayfa = new AdminSayfasi(textBoxSifre.Text);
                    adminSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı...");
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

        private void buttonOgretmenGiris_Click(object sender, EventArgs e)
        {
            string kisi = "";
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT * FROM hocabilgileri WHERE adi = @P1 AND sicilno = @P2", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(textBoxSifre.Text));
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    kisi = textBoxSifre.Text;
                    ogretmenSayfa = new OgretmenSayfasi(kisi);
                    ogretmenSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı...");
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

        private void buttonOgrenciGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            string girisYapanKisi = "";
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT ogrencino FROM ogrencibilgileri WHERE ogrenciad = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    girisYapanKisi = textBoxSifre.Text;
                    ogrenciSayfa = new OgrenciSayfasi(girisYapanKisi);
                    ogrenciSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı...");
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