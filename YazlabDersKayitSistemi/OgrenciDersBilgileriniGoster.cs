using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazlabDersKayitSistemi
{
    public partial class OgrenciDersBilgileriniGoster : Form
    {
        int parametre;
        int girisYapanKisiId;
        public OgrenciDersBilgileriniGoster(int v, string girisYapanKisiId)
        {
            InitializeComponent();
            this.parametre = v;
            this.girisYapanKisiId = int.Parse(girisYapanKisiId);
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void oncekiDersleriGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM ogrencidersbilgileri WHERE ogrencino = " + girisYapanKisiId;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void donemDersleriGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.ogrenciid,A.dersid ,B.adi,B.soyadi FROM ogrencidonemdersleri A INNER JOIN hocabilgileri B on A.hocaid = B.sicilno  WHERE ogrenciid =" + girisYapanKisiId;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void OgrenciDersBilgileriniGoster_Load(object sender, EventArgs e)
        {
            if (parametre == 1)
            {
                donemDersleriGoster();
            }
            else
            {
                oncekiDersleriGoster();


            }

        }
    }
}
