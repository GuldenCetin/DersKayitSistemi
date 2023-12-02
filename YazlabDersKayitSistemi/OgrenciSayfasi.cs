using IronOcr;
using IronSoftware;
using Npgsql;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazlabDersKayitSistemi
{
    public partial class OgrenciSayfasi : Form
    {
        string[] yazi;
        string yazi2;
        string girisYapanKisiId;
        bool pdfAttiMi = false;
        string dersID;
        string path;
        int gonderenId;
        int alanId;
        string dersId2;
        string transkriptKontrolcu;
        OgrenciDersBilgileriniGoster OgrenciDersBilgileriniGoster;

        public OgrenciSayfasi(string girisYapanKisiId)
        {
            InitializeComponent();
            this.girisYapanKisiId = girisYapanKisiId;
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void ogrenciBekleyenTalepGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT gonderenid,alanid,dersid FROM taleptablosu WHERE  talepdurum = '4' AND gonderenid=" + girisYapanKisiId;

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
            try
            {
                baglanti.Open();

                string sorgu = "SELECT gonderenid,alanid,dersid FROM taleptablosu WHERE  talepdurum = '4' AND alanid=" + girisYapanKisiId;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
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
        private void dersKoduAyir()
        {
            List<string> ogrenciBilgileri = new List<string>();
            string pattern = @"(\w+)\s+(.*?)\s+(?:Z|S)\s+(?:Tr)\s+\d+\s+\d+\s+\d\s+\d+\s+(.*)";
            using (StreamReader sr = new StreamReader("C:\\Users\\cetle\\Onedrive\\Masaüstü\\PDFtoTXT.txt"))
            {
                string satir;

                try
                {
                    baglanti.Open();
                    string eklemeSorgusu = "INSERT INTO ogrencidersbilgileri (harfnotu,ogrencino,dersid,dersadi) VALUES (@P1,@P2,@P3,@P4)";
                    while ((satir = sr.ReadLine()) != null)
                    {
                        Match eslesen = Regex.Match(satir, pattern);

                        if (eslesen.Success)
                        {
                            string dersId = eslesen.Groups[1].Value;
                            string dersAdi = eslesen.Groups[2].Value;
                            string harfNotu = eslesen.Groups[3].Value.Substring(0, 2);

                            NpgsqlCommand sqlkomut = new NpgsqlCommand(eklemeSorgusu, baglanti);
                            sqlkomut.Parameters.AddWithValue("@P1", harfNotu);
                            sqlkomut.Parameters.AddWithValue("@P2", int.Parse(girisYapanKisiId));
                            sqlkomut.Parameters.AddWithValue("@P3", dersId);
                            sqlkomut.Parameters.AddWithValue("@P4", dersAdi);

                            sqlkomut.ExecuteNonQuery();
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
                    MessageBox.Show("Transkript sisteme yüklenmiştir...");
                }
            }
        }
        private void hocaGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT A.adi, A.soyadi, A.sicilno, C.dersid, C.dersadi FROM hocabilgileri A " +
                               "INNER JOIN hocadersbilgileri B ON A.sicilno = B.sicilno " +
                               "INNER JOIN dersler C ON B.dersid = C.dersid " +
                               "INNER JOIN hocailgitablosu D ON A.sicilno = D.sicilno " +
                               "INNER JOIN ilgialani E ON D.ilgialaniid = E.ilgialaniid WHERE A.kontenjan > 0 AND " +
                               "C.dersadi LIKE " +
                               "'" + comboBoxDersFiltresi.Text + "%" + "' " +
                               "AND E.ilgialani LIKE " +
                               "'" + comboBoxIlgiFiltresi.Text + "%" + "'";
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
                NpgsqlCommand sqlKomutKontenjan = new NpgsqlCommand("UPDATE hocabilgileri SET kontenjan = @P1  WHERE sicilno = " + gonderenId, baglanti);
                sqlKomutKontenjan.Parameters.AddWithValue("@P1", dersKontenjan);
                sqlKomutKontenjan.ExecuteNonQuery();
                baglanti.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                MessageBox.Show("Dersiniz eklenmiştir.");
            }
        }
        private void transkriptKontrol()
        {
            try
            {
                baglanti.Open();

                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT pdfattimi FROM ogrencibilgileri WHERE ogrencino = " + int.Parse(girisYapanKisiId), baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
                //sqlDataReader[""]

                while (sqlDataReader.Read())
                {
                    transkriptKontrolcu = sqlDataReader["pdfattimi"].ToString();
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
        private void OgrenciSayfasi_Load(object sender, EventArgs e)
        {
            transkriptKontrol();
            if (transkriptKontrolcu == "True")
            {
                buttonTranskriptEkle.Enabled = false;
                buttonFiltrele.Enabled = true;
            }
            int zamanFark = AdminSayfasi.toplamFark;
            if (zamanFark > 7)
            {
                buttonTalepOlustur.Enabled = false;
                buttonTalepOnayla.Enabled = false;
                buttonTalepGeriCek.Enabled = false;
            }
            richTextBoxMesaj.MaxLength = AdminSayfasi.maxKarakterBelirle;
            labelGirisYapanId.Text = girisYapanKisiId;
            textBoxGonderenId.Text = girisYapanKisiId;
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from dersler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxDersFiltresi.DataSource = dt;
                comboBoxDersFiltresi.DisplayMember = "dersadi";
                comboBoxDersFiltresi.ValueMember = "dersid";

                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from ilgialani", baglanti);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBoxIlgiFiltresi.DataSource = dt2;
                comboBoxIlgiFiltresi.DisplayMember = "ilgialani";
                comboBoxIlgiFiltresi.ValueMember = "ilgialaniid";
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

        private void comboBoxDersFiltresi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //hocaGoster(); 
        }

        private void buttonFiltrele_Click(object sender, EventArgs e)
        {
            hocaGoster();
        }

        private void buttonTranskriptEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "pdf files|*.pdf";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }
            PdfDocument doc = new PdfDocument(path);

            StringBuilder buffer = new StringBuilder();

            foreach (PdfPageBase page in doc.Pages)
            {
                buffer.Append(page.ExtractText());
            }
            String fileName = "C:\\Users\\cetle\\Onedrive\\Masaüstü\\PDFtoTXT.txt";
            File.WriteAllText(fileName, buffer.ToString());

            buttonFiltrele.Enabled = true;
            transkriptKontrol();
            if (transkriptKontrolcu == "True")
            {
                buttonTranskriptEkle.Enabled = false;
            }
            dersKoduAyir();
        }

        private void dataGridViewHocalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewHocalar.SelectedCells[0].RowIndex;
            textBoxAlanId.Text = dataGridViewHocalar.Rows[secilenSatir].Cells[2].Value.ToString();
            dersID = dataGridViewHocalar.Rows[secilenSatir].Cells[3].Value.ToString();
        }

        private void buttonTalepOlustur_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            try
            {
                baglanti.Open();
                string taleptanAl = "SELECT * FROM taleptablosu WHERE gonderenid =" + int.Parse(girisYapanKisiId) + " AND dersid = '" + dersID + "'" + " AND talepdurum = '4'";
                NpgsqlCommand sqlKomut = new NpgsqlCommand(taleptanAl, baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " burdaki catch");
            }
            finally
            {
                baglanti.Close();
            }

            baglanti.Open();
            NpgsqlCommand kontrol = new NpgsqlCommand("SELECT EXISTS (SELECT 1 FROM ogrencidonemdersleri " +
                                                      "WHERE ogrenciid = @P1 AND dersid = @P2)", baglanti);

            kontrol.Parameters.AddWithValue("@P1", int.Parse(girisYapanKisiId));
            kontrol.Parameters.AddWithValue("@P2", dataGridViewHocalar.CurrentRow.Cells[3].Value);
            bool result = Convert.ToBoolean(kontrol.ExecuteScalar());
            baglanti.Close();
            if (result == false)
            {
                try
                {
                    baglanti.Open();
                    if (AdminSayfasi.maxHocadanDersAlma > sayac)
                    {
                        string eklemeSorgusu = "INSERT INTO taleptablosu (gonderenid,alanid,dersid,talepdurum,mesaj) VALUES (@P1,@P2,@P3,@P4,@P5)";
                        NpgsqlCommand sqlkomut = new NpgsqlCommand(eklemeSorgusu, baglanti);

                        sqlkomut.Parameters.AddWithValue("@P1", int.Parse(textBoxGonderenId.Text));
                        sqlkomut.Parameters.AddWithValue("@P2", int.Parse(textBoxAlanId.Text));
                        sqlkomut.Parameters.AddWithValue("@P3", dersID);
                        sqlkomut.Parameters.AddWithValue("@P4", "4");
                        sqlkomut.Parameters.AddWithValue("@P5", richTextBoxMesaj.Text);

                        sqlkomut.ExecuteNonQuery();
                        MessageBox.Show("Talebiniz oluşturulmuştur...");
                    }
                    else
                    {
                        MessageBox.Show("Max hoca sayısına ulaştınız");
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
            else
            {
                MessageBox.Show("Bu dersi zaten almışsınız");
            }

        }

        private void buttonDersBilgileriGoster_Click(object sender, EventArgs e)
        {
            OgrenciDersBilgileriniGoster = new OgrenciDersBilgileriniGoster(0, girisYapanKisiId);
            OgrenciDersBilgileriniGoster.Show();
        }

        private void buttonBekleyenTalepGoster_Click(object sender, EventArgs e)
        {
            ogrenciBekleyenTalepGoster();
        }

        private void buttonTalepGeriCek_Click(object sender, EventArgs e)
        {

            int secilenSatir = dataGridView2.SelectedCells[0].RowIndex;
            dersID = dataGridView2.Rows[secilenSatir].Cells[1].Value.ToString();
            int alanid = (int)dataGridView2.Rows[secilenSatir].Cells[0].Value;

            try
            {
                baglanti.Open();

                string sorgu = "DELETE  FROM taleptablosu WHERE  talepdurum = '4' AND dersid=@P1 AND gonderenid=@P2 AND alanid=@P3";
                NpgsqlCommand sqlkomut = new NpgsqlCommand(sorgu, baglanti);

                sqlkomut.Parameters.AddWithValue("@P1", dersID);
                sqlkomut.Parameters.AddWithValue("@P2", int.Parse(girisYapanKisiId));
                sqlkomut.Parameters.AddWithValue("@P3", alanid);
                sqlkomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            ogrenciBekleyenTalepGoster();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOnaylananDersler_Click(object sender, EventArgs e)
        {
            OgrenciDersBilgileriniGoster = new OgrenciDersBilgileriniGoster(1, girisYapanKisiId);
            OgrenciDersBilgileriniGoster.Show();
        }

        private void buttonTalepOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE taleptablosu SET talepdurum = @P1 WHERE gonderenid = @P2 AND alanid = @P3 AND dersid = @P4", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", '2');
                sqlKomut.Parameters.AddWithValue("@P2", gonderenId);
                sqlKomut.Parameters.AddWithValue("@P3", alanId);
                sqlKomut.Parameters.AddWithValue("@P4", dersId2);

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
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO ogrencidonemdersleri (ogrenciid,hocaid,dersid) VALUES (@P1,@P2,@P3)", baglanti);

                sqlKomut.Parameters.AddWithValue("@P1", int.Parse(girisYapanKisiId));
                sqlKomut.Parameters.AddWithValue("@P2", gonderenId);
                sqlKomut.Parameters.AddWithValue("@P3", dersId2);

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
            ogretmenkredidusur();
            ogrenciBekleyenTalepGoster();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView3.SelectedCells[0].RowIndex;
            gonderenId = int.Parse(dataGridView3.Rows[secilenSatir].Cells[0].Value.ToString());
            alanId = int.Parse(dataGridView3.Rows[secilenSatir].Cells[1].Value.ToString());
            dersId2 = (dataGridView3.Rows[secilenSatir].Cells[2].Value.ToString());
        }
    }
}
