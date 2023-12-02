using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazlabDersKayitSistemi
{
    public partial class AdminOgrenciIslemleri : Form
    {
        Ogrenci ogrenci;
        private ArrayList dersler = new ArrayList();
        private ArrayList dersidler = new ArrayList();
        public AdminOgrenciIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void ogrenciGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM ogrencibilgileri";
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
        private void textBoxlariTemizle()
        {
            textBoxOgrenciNo.Text = "";
            textBoxOgrenciAdi.Text = "";
            textBoxOgrenciSoyadi.Text = "";
            textBoxPDFAttiMi.Text = "";
            textBoxAGNO.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxOgrenciNo.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxOgrenciAdi.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxOgrenciSoyadi.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxPDFAttiMi.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxAGNO.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            MessageBox.Show(dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString());
        }
     
        private void buttonOgrenciOlustur_Click(object sender, EventArgs e)
        {
            
            try
            {
                int ogrenciSayisi = int.Parse(textBoxOgrenciSayisi.Text);

                for (int i = 0; i < ogrenciSayisi; i++)
                {
                    ogrenci = new Ogrenci();
                    ogrenci.rastgeleOgrenciOlustur(ogrenci);
                    baglanti.Open();
                    NpgsqlCommand sqlkomut = new NpgsqlCommand("INSERT INTO ogrencibilgileri (ogrenciad, ogrencisoyad, pdfattimi, agno) " +
                                                           "VALUES (@P1, @P2, @P3, @P4)  ", baglanti);
                    sqlkomut.Parameters.AddWithValue("@P1", ogrenci.OgrenciAd);
                    sqlkomut.Parameters.AddWithValue("@P2", ogrenci.OgrenciSoyad);
                    sqlkomut.Parameters.AddWithValue("@P3", ogrenci.PdfAttiMi);
                    sqlkomut.Parameters.AddWithValue("@P4", ogrenci.Agno); // 
                    sqlkomut.ExecuteNonQuery();
                    baglanti.Close();

                    // öğrenci oluştururkne notları da at dedim  bağlantı açamaya gerek yok mu
                    baglanti.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("SELECT  ogrencino FROM ogrencibilgileri ORDER BY ogrencino DESC", baglanti);
                    NpgsqlDataReader sqlDataReader = komut.ExecuteReader();
                    int ogrencino = 0;
                    if (sqlDataReader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sqlDataReader);
                        ogrencino = int.Parse(dt.Rows[0]["ogrencino"].ToString());

                    }
                    baglanti.Close();
                    for (int j = 0; j < ogrenci.Dersler.Count; j++)
                    {
                        baglanti.Open();
                        NpgsqlCommand sqlkomut2 = new NpgsqlCommand("INSERT INTO ogrencidersbilgileri(harfnotu,ogrencino,dersid,dersadi)" +
                                                        "VALUES (@P1,@P2,@P3,@P4)", baglanti);

                        sqlkomut2.Parameters.AddWithValue("@P1", ogrenci.DersNotlari[j]);
                        sqlkomut2.Parameters.AddWithValue("@P2", ogrencino);
                        sqlkomut2.Parameters.AddWithValue("@P3", ogrenci.Dersidler[j]);
                        sqlkomut2.Parameters.AddWithValue("@P4", ogrenci.Dersler[j]);
                        sqlkomut2.ExecuteNonQuery();
                        baglanti.Close();
                    }


                }
                textBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciGoster();
        }
        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlkomut = new NpgsqlCommand("INSERT INTO ogrencibilgileri (ogrenciad, ogrencisoyad, pdfattimi, agno) " +
                                                           "VALUES (@P1, @P2, @P3, @P4)", baglanti);
                sqlkomut.Parameters.AddWithValue("@P1", textBoxOgrenciAdi.Text);
                sqlkomut.Parameters.AddWithValue("@P2", textBoxOgrenciSoyadi.Text);
                sqlkomut.Parameters.AddWithValue("@P3", ogrenci.PdfAttiMi);
                sqlkomut.Parameters.AddWithValue("@P4", float.Parse(textBoxAGNO.Text));
                sqlkomut.ExecuteNonQuery();

                textBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciGoster();
        }
        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            ogrenciGoster();
        }
        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE ogrencibilgileri SET ogrenciad = @P1, ogrencisoyad = @P2, " +
                                                           "pdfattimi = @P3, agno = @P4 WHERE ogrencino = @P5", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxOgrenciAdi.Text);
                sqlKomut.Parameters.AddWithValue("@P2", textBoxOgrenciSoyadi.Text);
                sqlKomut.Parameters.AddWithValue("@P3", bool.Parse(textBoxPDFAttiMi.Text));
                sqlKomut.Parameters.AddWithValue("@P4", float.Parse(textBoxAGNO.Text));
                sqlKomut.Parameters.AddWithValue("@P5", int.Parse(textBoxOgrenciNo.Text));

                sqlKomut.ExecuteNonQuery();

                textBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciGoster();
        }
        private void buttonOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlkomut = new NpgsqlCommand("DELETE FROM ogrencibilgileri WHERE ogrencino = @P1", baglanti);

                sqlkomut.Parameters.AddWithValue("@P1", int.Parse(textBoxOgrenciNo.Text));

                sqlkomut.ExecuteNonQuery();

                textBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci silinirken bir hata oluştu " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciGoster();
        }

        private void AdminOgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }


    }
}
