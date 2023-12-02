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

    public partial class OgretmenSayfasi : Form
    {
        string girisYapanKisiId;
        int ogrenciid;
        string dersId;
        double secilenindex;
        int talepAtilacakOgrenciId;
        public OgretmenSayfasi(string girisYapanKisiId)
        {
            InitializeComponent();
            this.girisYapanKisiId = girisYapanKisiId;
            label2.Text = girisYapanKisiId;

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");

        private void ogretmenkredidusur()
        {
            try
            {

                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT kontenjan FROM hocabilgileri WHERE sicilno = " + int.Parse(girisYapanKisiId), baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                int dersKontenjan = 0;
                while (sqlDataReader.Read())
                {
                    dersKontenjan = int.Parse(sqlDataReader["kontenjan"].ToString());
                }

                dersKontenjan--;
                baglanti.Close();

                baglanti.Open();
                NpgsqlCommand sqlKomutKontenjan = new NpgsqlCommand("UPDATE hocabilgileri SET kontenjan = @P1  WHERE sicilno = " + girisYapanKisiId, baglanti);
                sqlKomutKontenjan.Parameters.AddWithValue("@P1", dersKontenjan);
                sqlKomutKontenjan.ExecuteNonQuery();
                baglanti.Close();

                if (dersKontenjan == 0)
                {
                    buttonTalepOnayla.Enabled = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Öğrencinin talebi onaylanmıştır.");
            }

        }
        private void ogretmenOgrenciListele()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT B.ogrenciad, B.ogrencisoyad, C.dersadi, A.dersid, B.ogrencino FROM taleptablosu A " +
                    "INNER JOIN ogrencibilgileri B ON A.gonderenid = B.ogrencino " +
                    "INNER JOIN dersler C ON A.dersid = C.dersid " +
                    "WHERE  talepdurum = '4' AND alanid=" + girisYapanKisiId;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewHocayaTalepAtanlar.DataSource = ds.Tables[0];
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
        private void talepAtmayanOgrenciGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.ogrencino, A.ogrenciad, A.ogrencisoyad FROM ogrencibilgileri A " +
                               "LEFT JOIN taleptablosu B ON A.ogrencino = B.gonderenid WHERE B.gonderenid IS NULL";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBaskaHocalaraTalepAtanlar.DataSource = ds.Tables[0];
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
        private void baskaHocayaTalepAtanOgrenciGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT B.ogrenciad, B.ogrencisoyad, C.dersadi FROM taleptablosu A " +
                               "INNER JOIN ogrencibilgileri B ON B.ogrencino = A.gonderenid " +
                               "INNER JOIN dersler C ON A.dersid = C.dersid " +
                               "WHERE A.dersid IN (SELECT dersid FROM hocadersbilgileri WHERE sicilno = " + girisYapanKisiId + ") " +
                               "AND alanid != " + girisYapanKisiId;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBaskaHocalaraTalepAtanlar.DataSource = ds.Tables[0];
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

        private void buttonIlgiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string eklemeSorgusu = "INSERT INTO hocailgitablosu (sicilno,ilgialaniid) VALUES (@P1,@P2)";

                NpgsqlCommand cmd = new NpgsqlCommand(eklemeSorgusu, baglanti);
                cmd.Parameters.AddWithValue("@P1", int.Parse(girisYapanKisiId));
                cmd.Parameters.AddWithValue("@P2", comboBoxIlgiSec.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
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

        private void OgretmenSayfasi_Load(object sender, EventArgs e)
        {
            int zamanFark = AdminSayfasi.toplamFark;
            if (zamanFark > 7)
            {
                buttonTalepOnayla.Enabled = false;
                buttonOgrenciyeTalepGonder.Enabled = false;
                buttonTalepReddet.Enabled = false;
            }
            richTextBoxMesaj.MaxLength = AdminSayfasi.maxKarakterBelirle;
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ilgialani", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxIlgiSec.DisplayMember = "ilgialani";
                comboBoxIlgiSec.ValueMember = "ilgialaniid";
                comboBoxIlgiSec.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            try
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT A.dersid, B.dersadi FROM hocadersbilgileri A " +
                    "INNER JOIN dersler B ON A.dersid = B.dersid where sicilno =  " + int.Parse(girisYapanKisiId), baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxHocaninVerdigiDersler.DisplayMember = "dersadi";
                comboBoxHocaninVerdigiDersler.ValueMember = "dersid";
                comboBoxHocaninVerdigiDersler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            try
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT  DISTINCT dersadi,dersid  FROM ogrencidersbilgileri ", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxKriterDers.DisplayMember = "dersadi";
                comboBoxKriterDers.ValueMember = "dersid";
                comboBoxKriterDers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT kontenjan FROM hocabilgileri WHERE sicilno = " + int.Parse(girisYapanKisiId), baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                int dersKontenjan = 0;
                while (sqlDataReader.Read())
                {
                    dersKontenjan = int.Parse(sqlDataReader["kontenjan"].ToString());
                }
                if (dersKontenjan == 0)
                {
                    buttonTalepOnayla.Enabled = false;
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
        private void buttonTalepGoruntule_Click(object sender, EventArgs e)
        {
            ogretmenOgrenciListele();
        }
        private void buttonTalepOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE taleptablosu SET talepdurum = @P1 WHERE gonderenid = @P2 AND alanid = @P3 AND dersid = @P4", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", '2');
                sqlKomut.Parameters.AddWithValue("@P2", ogrenciid);
                sqlKomut.Parameters.AddWithValue("@P3", int.Parse(girisYapanKisiId));
                sqlKomut.Parameters.AddWithValue("@P4", dersId);

                sqlKomut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Talep tablosu güncellenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO ogrencidonemdersleri (ogrenciid,hocaid,dersid) VALUES (@P1,@P2,@P3)", baglanti);

                sqlKomut.Parameters.AddWithValue("@P1", ogrenciid);
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(girisYapanKisiId));
                sqlKomut.Parameters.AddWithValue("@P3", dersId);

                sqlKomut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenciye ders eklenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogretmenkredidusur();
            ogretmenOgrenciListele();

        }
        private void oncekiDersleriGoster(int secilenOgrenciNo)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM ogrencidersbilgileri WHERE ogrencino = " + secilenOgrenciNo;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewOgrenciGecmisDersler.DataSource = ds.Tables[0];
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
        private void buttonOgrenciyeTalepGonder_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlkomut = new NpgsqlCommand("INSERT INTO taleptablosu (gonderenid, alanid, dersid, talepdurum, mesaj) " +
                                                           "VALUES (@P1, @P2, @P3, @P4, @P5)", baglanti);
                sqlkomut.Parameters.AddWithValue("@P1", int.Parse(girisYapanKisiId));
                sqlkomut.Parameters.AddWithValue("@P2", talepAtilacakOgrenciId);
                sqlkomut.Parameters.AddWithValue("@P3", comboBoxHocaninVerdigiDersler.SelectedValue);
                sqlkomut.Parameters.AddWithValue("@P4", '4');
                sqlkomut.Parameters.AddWithValue("@P5", richTextBoxMesaj.Text);
                sqlkomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Talep oluşturulmuştur");
            }
        }
        private void buttonBaskaHocalaraTalepAtan_Click(object sender, EventArgs e)
        {
            baskaHocayaTalepAtanOgrenciGoster();
        }
        private void buttonTalepAtmayanOgrenciler_Click(object sender, EventArgs e)
        {
            talepAtmayanOgrenciGoster();
        }

        private void dataGridViewHocayaTalepAtanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewHocayaTalepAtanlar.SelectedCells[0].RowIndex;
            int listelenecekOgrenci = int.Parse(dataGridViewHocayaTalepAtanlar.Rows[secilenSatir].Cells[4].Value.ToString());
            dersId = dataGridViewHocayaTalepAtanlar.Rows[secilenSatir].Cells[3].Value.ToString();
            ogrenciid = int.Parse(dataGridViewHocayaTalepAtanlar.Rows[secilenSatir].Cells[4].Value.ToString());
            oncekiDersleriGoster(listelenecekOgrenci);
            Console.WriteLine(dersId);
        }

        private void buttonKriterDersEkleme_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                NpgsqlCommand komut;


                string eklemeSorgusu = "INSERT INTO hocalaricinkriterders (sicilno,dersid,derskredi) VALUES (@P1,@P2,@P3)";

                NpgsqlCommand cmd = new NpgsqlCommand(eklemeSorgusu, baglanti);

                cmd.Parameters.AddWithValue("@P1", int.Parse(girisYapanKisiId));
                cmd.Parameters.AddWithValue("@P2", comboBoxKriterDers.SelectedValue);
                cmd.Parameters.AddWithValue("@P3", int.Parse(textBoxKatsayiAlma.Text));
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Kayıt başarılı");
                textBoxKatsayiAlma.Text = " ";
            }
        }
        private void kriterDerseGoreSiralananOgrenciler()
        {
            try
            {
                baglanti.Open();
                string sqlKomut = ("SELECT B.ogrenciad, B.ogrencisoyad, A.toplamnot, B.ogrencino FROM kriterdersegoreogrenci A " +
                                                       "INNER JOIN ogrencibilgileri B ON A.ogrencino = B.ogrencino WHERE sicilno = " + int.Parse(girisYapanKisiId) + " ORDER BY A.toplamnot DESC");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlKomut, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewKritereGore.DataSource = ds.Tables[0];
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
        private void buttonKritereGoreListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                ArrayList notlar = new ArrayList();
                ArrayList derskredi = new ArrayList();
                ArrayList ogrenciIdler = new ArrayList();

                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT A.harfnotu, A.dersid, A.ogrencino,A.dersadi, B.derskredi FROM ogrencidersbilgileri A " +
                                                           "INNER JOIN hocalaricinkriterders B ON A.dersid = B.dersid ORDER BY ogrencino", baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    notlar.Add(sqlDataReader["harfnotu"]);
                    derskredi.Add(sqlDataReader["derskredi"]);
                }
                baglanti.Close();

                for (int i = 0; i < notlar.Count; i++)
                {
                    Console.WriteLine("Harf Notu: " + notlar[i] + " Kredisi: " + derskredi[i] + " Ogrenci: ");
                }
                baglanti.Open();
                NpgsqlCommand ogrenciIdCek = new NpgsqlCommand("SELECT DISTINCT A.ogrencino FROM ogrencidersbilgileri A " +
                                                               "INNER JOIN hocalaricinkriterders B ON A.dersid = B.dersid ORDER BY ogrencino", baglanti);

                NpgsqlDataReader sqlDataReader2 = ogrenciIdCek.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    ogrenciIdler.Add(sqlDataReader2["ogrencino"]);
                }
                baglanti.Close();
                float toplam = 0;
                foreach (var ogrencino in ogrenciIdler)
                {
                    baglanti.Open();
                    NpgsqlCommand sqlCarpimKomut = new NpgsqlCommand("SELECT A.harfnotu, B.derskredi FROM ogrencidersbilgileri A " +
                                                                     "INNER JOIN hocalaricinkriterders B ON A.dersid = B.dersid WHERE ogrencino = " + int.Parse(ogrencino.ToString()) + " AND sicilno = " + int.Parse(girisYapanKisiId), baglanti);
                    NpgsqlDataReader sqlDataReader3 = sqlCarpimKomut.ExecuteReader();

                    int dersKrediToplami = 0;

                    while (sqlDataReader3.Read())
                    {
                        dersKrediToplami += int.Parse(sqlDataReader3["derskredi"].ToString());
                        if (sqlDataReader3["harfnotu"].ToString() == "AA")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 4.0f);
                        }
                        else if (sqlDataReader3["harfnotu"].ToString() == "BA")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 3.5f);
                        }
                        else if (sqlDataReader3["harfnotu"].ToString() == "BB")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 3f);
                        }
                        else if (sqlDataReader3["harfnotu"].ToString() == "CB")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 2.5f);
                        }
                        else if (sqlDataReader3["harfnotu"].ToString() == "CC")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 2f);
                        }
                        else if (sqlDataReader3["harfnotu"].ToString() == "DC")
                        {
                            toplam = toplam + (int.Parse(sqlDataReader3["derskredi"].ToString()) * 1.5f);
                        }
                    }
                    baglanti.Close();

                    baglanti.Open();
                    NpgsqlCommand tabloyaEkle = new NpgsqlCommand("INSERT INTO kriterdersegoreogrenci (ogrencino, sicilno, toplamnot) VALUES (@P1, @P2, @P3)", baglanti);
                    tabloyaEkle.Parameters.AddWithValue("@P1", int.Parse(ogrencino.ToString()));
                    tabloyaEkle.Parameters.AddWithValue("@P2", int.Parse(girisYapanKisiId));
                    tabloyaEkle.Parameters.AddWithValue("@P3", toplam / dersKrediToplami);
                    tabloyaEkle.ExecuteNonQuery();
                    baglanti.Close();
                    toplam = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Ögrencilerin notları hesaplanmıştır");
            }

        }

        private void buttonKritereGoreFiltrele_Click(object sender, EventArgs e)
        {
            kriterDerseGoreSiralananOgrenciler();
        }

        private void dataGridViewKritereGore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewKritereGore.SelectedCells[0].RowIndex;
            talepAtilacakOgrenciId = int.Parse(dataGridViewKritereGore.Rows[secilenSatir].Cells[3].Value.ToString());
        }

        private void comboBoxIlgiSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTalepReddet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE taleptablosu SET talepdurum = @P1 WHERE gonderenid = @P2 AND alanid = @P3 AND dersid = @P4", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", '3');
                sqlKomut.Parameters.AddWithValue("@P2", ogrenciid);
                sqlKomut.Parameters.AddWithValue("@P3", int.Parse(girisYapanKisiId));
                sqlKomut.Parameters.AddWithValue("@P4", dersId);

                sqlKomut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Talep tablosu güncellenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Talep Reddedildi");
            }
        }
    }
}
