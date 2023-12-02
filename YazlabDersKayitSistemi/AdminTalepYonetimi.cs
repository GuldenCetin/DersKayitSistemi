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
    public partial class AdminTalepYonetimi : Form
    {
        public AdminTalepYonetimi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void hocaListele()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.sicilno, A.adi, A.soyadi, C.dersid, C.dersadi FROM hocabilgileri A " +
                               "INNER JOIN hocadersbilgileri B ON A.sicilno = B.sicilno " +
                               "INNER JOIN dersler C ON B.dersid = C.dersid ORDER BY sicilno ";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewHocalar.DataSource = ds.Tables[0];
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
        private void ogrenciListele()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT ogrencino, ogrenciad, ogrencisoyad FROM ogrencibilgileri ";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewOgrenciler.DataSource = ds.Tables[0];
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
        private void AdminTalepYonetimi_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM taleptablosu ";

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
            hocaListele();
            ogrenciListele();
        }

        private void dataGridViewOgrenciler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewOgrenciler.SelectedCells[0].RowIndex;
            textBoxOgrencino.Text = dataGridViewOgrenciler.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxOgrenciAdi.Text = dataGridViewOgrenciler.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxOgrenciSoyadi.Text = dataGridViewOgrenciler.Rows[secilenSatir].Cells[2].Value.ToString();
        }

        private void dataGridViewHocalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewHocalar.SelectedCells[0].RowIndex;
            textBoxHocaSicilNo.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxHocaAdi.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxHocaSoyadi.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxDersId.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[3].Value.ToString();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO taleptablosu (gonderenid, alanid, dersid, talepdurum) " +
                                                           "VALUES (@P1, @P2, @P3, @P4)", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", int.Parse(textBoxOgrencino.Text));
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(textBoxHocaSicilNo.Text));
                sqlKomut.Parameters.AddWithValue("@P3", textBoxDersId.Text);
                sqlKomut.Parameters.AddWithValue("@P4", '2');

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
