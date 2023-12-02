using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections;
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
    public partial class AdminDersİslemleri : Form
    {
        public AdminDersİslemleri()
        {
            InitializeComponent();
        }
        ArrayList siraliSicilNolar = new ArrayList();
        ArrayList siraliKontenjanlar = new ArrayList();
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void ogrenciGetir()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT B.ogrencino FROM ogrencidonemdersleri A " +
                               "RIGHT JOIN ogrencibilgileri B ON A.ogrenciid = B.ogrencino WHERE A.ogrenciid IS NULL " +
                               "ORDER BY B.ogrencino ASC";

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
        private void ogrenciOrtalamayaGoreGetir()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT B.ogrencino, B.agno FROM ogrencidonemdersleri A " +
                               "RIGHT JOIN ogrencibilgileri B ON A.ogrenciid = B.ogrencino WHERE A.ogrenciid IS NULL " +
                               "ORDER BY B.agno DESC";

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
        private void hocaGetir()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.sicilno, B.dersid, A.kontenjan FROM hocabilgileri A " +
                               "INNER JOIN hocadersbilgileri B ON A.sicilno = B.sicilno " +
                               "WHERE dersid = '1' AND A.kontenjan > 0 ORDER BY sicilno";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewHocaDersBilgileri.DataSource = ds.Tables[0];
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
        private void ogrenciDonemDersleriSonuc()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT B.ogrenciad, B.ogrencisoyad, C.adi, D.dersadi FROM ogrencidonemdersleri A " +
                               "INNER JOIN ogrencibilgileri B ON A.ogrenciid = B.ogrencino " +
                               "INNER JOIN hocabilgileri C ON A.hocaid = C.sicilno " +
                               "INNER JOIN dersler D ON A.dersid = D.dersid ORDER BY ogrenciid ASC ";
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
        private void buttonRastgeleAtama_Click(object sender, EventArgs e)
        {
            ogrenciGetir();
            hocaGetir();
            int kontenjan = 0;
            int randomSecilenSatir = 0;
            Random rnd = new Random();
            try
            {
                baglanti.Open();
                ArrayList sicilNolar = new ArrayList();
                ArrayList kontenjanlar = new ArrayList();
                NpgsqlCommand sqlKomutDiziler = new NpgsqlCommand("SELECT A.sicilno, B.dersid, A.kontenjan FROM hocabilgileri A " +
                               "INNER JOIN hocadersbilgileri B ON A.sicilno = B.sicilno WHERE dersid = '1' AND A.kontenjan > 0 ORDER BY sicilno", baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomutDiziler.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sicilNolar.Add(sqlDataReader["sicilno"].ToString());
                    kontenjanlar.Add(sqlDataReader["kontenjan"].ToString());
                }
                baglanti.Close();

                int maxOgrenciSayisi = dataGridViewOgrenciler.Rows.Count - 1;
                //dersid = 0 sicilno = 1, -1 yapmamızın amacı column isimlerinin olduğu yer de satır

                for (int i = 0; i < maxOgrenciSayisi; i++)
                {
                    do
                    {
                        if (kontenjanlar.Count > 0)
                        {
                            randomSecilenSatir = rnd.Next(0, kontenjanlar.Count);
                            kontenjan = int.Parse(kontenjanlar[randomSecilenSatir].ToString());
                        }
                    } while (kontenjan < 1 && kontenjanlar == null && kontenjanlar.Count > 0);

                    //kontenjan kontrol
                    if (kontenjan > 0)
                    {
                        baglanti.Open();
                        NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO ogrencidonemdersleri (ogrenciid,hocaid,dersid) VALUES (@P1,@P2,@P3)", baglanti);
                        sqlKomut.Parameters.AddWithValue("@P1", int.Parse(dataGridViewOgrenciler.Rows[i].Cells[0].Value.ToString()));
                        sqlKomut.Parameters.AddWithValue("@P2", int.Parse(dataGridViewHocaDersBilgileri.Rows[randomSecilenSatir].Cells[0].Value.ToString()));
                        sqlKomut.Parameters.AddWithValue("@P3", dataGridViewHocaDersBilgileri.Rows[randomSecilenSatir].Cells[1].Value.ToString());

                        sqlKomut.ExecuteNonQuery();
                        kontenjan--;

                        NpgsqlCommand kontenjanGuncelle = new NpgsqlCommand("UPDATE hocabilgileri SET kontenjan = @P1 WHERE sicilno = "
                            + sicilNolar[randomSecilenSatir], baglanti);
                        kontenjanGuncelle.Parameters.AddWithValue("@P1", kontenjan);
                        kontenjanGuncelle.ExecuteNonQuery();
                        baglanti.Close();
                        kontenjanlar[randomSecilenSatir] = kontenjan.ToString();
                        if (int.Parse(kontenjanlar[randomSecilenSatir].ToString()) == 0)
                        {
                            kontenjanlar.RemoveAt(randomSecilenSatir);
                            sicilNolar.RemoveAt(randomSecilenSatir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Öğrenciler rastgele bir şekilde atanmıştır...");
            }
            ogrenciDonemDersleriSonuc();
        }

        private void buttonNotOrtalamasinaGore_Click(object sender, EventArgs e)
        {
            ogrenciOrtalamayaGoreGetir();
            hocaGetir();

            int kontenjan = 0;
            int sayac = 0;
            try
            {
                int maxOgrenciSayisi = dataGridViewOgrenciler.Rows.Count - 1;
                for (int i = 0; i < maxOgrenciSayisi; i++)
                {
                    if (int.Parse(siraliKontenjanlar[sayac].ToString()) == 0 && siraliKontenjanlar.Count != sayac + 1)
                    {
                        sayac++;
                    }
                    if (siraliSicilNolar.Count > sayac + 1)
                    {

                        kontenjan = int.Parse(siraliKontenjanlar[sayac].ToString());

                        baglanti.Open();
                        NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO ogrencidonemdersleri (ogrenciid,hocaid,dersid) VALUES (@P1,@P2,@P3)", baglanti);
                        sqlKomut.Parameters.AddWithValue("@P1", int.Parse(dataGridViewOgrenciler.Rows[i].Cells[0].Value.ToString()));
                        sqlKomut.Parameters.AddWithValue("@P2", int.Parse(siraliSicilNolar[sayac].ToString()));
                        sqlKomut.Parameters.AddWithValue("@P3", '1');

                        sqlKomut.ExecuteNonQuery();
                        kontenjan--;
                        baglanti.Close();

                        baglanti.Open();
                        NpgsqlCommand hocaKontenjan = new NpgsqlCommand("UPDATE hocabilgileri SET kontenjan = @P1 WHERE sicilno = " + int.Parse(siraliSicilNolar[sayac].ToString()), baglanti);

                        hocaKontenjan.Parameters.AddWithValue("@P1", kontenjan);
                        hocaKontenjan.ExecuteNonQuery();

                        baglanti.Close();

                        siraliKontenjanlar[sayac] = kontenjan.ToString();
                    }
                }

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

        private void dataGridViewHocaDersBilgileri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siraliSicilNolar.Count == dataGridViewHocaDersBilgileri.Rows.Count - 1)
            {
                MessageBox.Show("Daha fazla hoca seçemezsiniz");
            }
            else
            {
                int secilenSatir = dataGridViewHocaDersBilgileri.SelectedCells[0].RowIndex;
                siraliSicilNolar.Add(dataGridViewHocaDersBilgileri.Rows[secilenSatir].Cells[0].Value.ToString());
                siraliKontenjanlar.Add(dataGridViewHocaDersBilgileri.Rows[secilenSatir].Cells[2].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hocaGetir();
        }
    }
}
