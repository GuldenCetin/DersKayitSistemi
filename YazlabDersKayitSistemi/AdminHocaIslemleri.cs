using BitMiracle.LibTiff.Classic;
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
    public partial class AdminHocaIslemleri : Form
    {
        public AdminHocaIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void hocaGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.sicilno, A.adi, A.soyadi, A.kontenjan, C.dersadi, E.ilgialani FROM hocabilgileri A " +
                               "INNER JOIN hocadersbilgileri B ON A.sicilno = B.sicilno " +
                               "INNER JOIN dersler C ON B.dersid = C.dersid " +
                               "INNER JOIN hocailgitablosu D ON A.sicilno = D.sicilno " +
                               "INNER JOIN ilgialani E ON D.ilgialaniid = E.ilgialaniid ";

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
        private void textBoxlariTemizle()
        {
            textBoxHocaAdi.Text = "";
            textBoxHocaSoyadi.Text = "";
            textBoxHocaSicilNo.Text = "";
            textBoxHocaKontenjan.Text = "";
        }
        private void buttonHocaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO hocabilgileri (adi, soyadi, kontenjan) " +
                                                           "VAlUES (@P1, @P2, @P3)", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxHocaAdi.Text);
                sqlKomut.Parameters.AddWithValue("@P2", textBoxHocaSoyadi.Text);
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(textBoxHocaKontenjan.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hoca eklenirken bir sıkıntı oluştu " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            textBoxlariTemizle();
            hocaGoster();
        }

        private void buttonHocaGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE hocabilgileri SET adi = @P1, soyadi = @P2, " +
                                                           "kontenjan = @P3 WHERE sicilno = @P4", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxHocaAdi.Text);
                sqlKomut.Parameters.AddWithValue("@P2", textBoxHocaSoyadi.Text);
                sqlKomut.Parameters.AddWithValue("@P3", int.Parse(textBoxHocaKontenjan.Text));
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(textBoxHocaSicilNo.Text));

                sqlKomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            textBoxlariTemizle();
            hocaGoster();
        }

        private void buttonHocaListele_Click(object sender, EventArgs e)
        {
            hocaGoster();
        }

        private void buttonHocaSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlkomut = new NpgsqlCommand("DELETE FROM hocabilgileri WHERE sicilno = @P1", baglanti);

                sqlkomut.Parameters.AddWithValue("@P1", int.Parse(textBoxHocaSicilNo.Text));

                sqlkomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hoca silinirken bir hata oluştu " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            hocaGoster();
        }

        private void AdminHocaIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM dersler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxHocayaDersEkle.DisplayMember = "dersadi";
                comboBoxHocayaDersEkle.ValueMember = "dersid";
                comboBoxHocayaDersEkle.DataSource = dt;
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

        private void buttonDersiHocayaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO hocadersbilgileri (dersid, sicilno) VALUES (@P1, @P2)", baglanti);
                cmd.Parameters.AddWithValue("@P1", comboBoxHocayaDersEkle.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@P2", int.Parse(textBoxHocaSicilNo.Text));
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Hocaya ders eklenmiştir.");
            }
        }

        private void dataGridViewHocalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewHocalar.SelectedCells[0].RowIndex;
            textBoxHocaAdi.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxHocaAdi.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxHocaSoyadi.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxHocaKontenjan.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[3].Value.ToString();
        }

        private void buttonHocaDersiSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlkomut = new NpgsqlCommand("DELETE FROM hocadersbilgileri WHERE sicilno = @P1 AND dersid = @P2", baglanti);
                sqlkomut.Parameters.AddWithValue("@P1", int.Parse(textBoxHocaSicilNo.Text));
                sqlkomut.Parameters.AddWithValue("@P2", comboBoxHocayaDersEkle.SelectedValue.ToString());

                sqlkomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders silinirken bir hata oluştu " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Hocanın dersi silinmiştir.");
            }
        }
    }
}
