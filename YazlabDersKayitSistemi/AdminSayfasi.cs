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
using System.Data.SqlClient;

namespace YazlabDersKayitSistemi
{
    public partial class AdminSayfasi : Form
    {
        AdminOgrenciIslemleri adminOgrenciIslemleri;
        AdminHocaIslemleri adminHocaIslemleri;
        AdminDersİslemleri adminDersIslemleri;
        AdminTalepYonetimi adminTalepYonetimi;
        public static DateTime dersSecimSüresi;
        public static int maxKarakterBelirle;
        public static int maxHocadanDersAlma = 1;
        public static  System.TimeSpan zaman;
        public static int toplamFark;
        public AdminSayfasi(string label)
        {
            InitializeComponent();
            label3.Text = label;
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");
        private void ilgiAlaniGoster()
        {
            string sorgu = "SELECT * FROM ilgialani";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonIlgiAlaniEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("INSERT INTO ilgialani (ilgialani) " +
                                                          "VALUES (@P1)", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxIlgiAlaniAciklama.Text);

                sqlKomut.ExecuteNonQuery();

                textBoxIlgiAlaniID.Text = "";
                textBoxIlgiAlaniAciklama.Text = "";
                ilgiAlaniGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İlgi alanı eklenirken bir hata oluştu, tekrar deneyin" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonIlgiAlaniListele_Click(object sender, EventArgs e)
        {
            ilgiAlaniGoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxIlgiAlaniID.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxIlgiAlaniAciklama.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
        }

        private void buttonIlgiAlaniDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("UPDATE ilgialani SET ilgialani = @P1 WHERE ilgialaniid = @P2", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", textBoxIlgiAlaniAciklama.Text);
                sqlKomut.Parameters.AddWithValue("@P2", int.Parse(textBoxIlgiAlaniID.Text));

                sqlKomut.ExecuteNonQuery();

                textBoxIlgiAlaniID.Text = "";
                textBoxIlgiAlaniAciklama.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ilgiAlaniGoster();
        }

        private void buttonIlgiAlaniSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("DELETE FROM ilgialani WHERE ilgialaniid = @P1", baglanti);
                sqlKomut.Parameters.AddWithValue("@P1", int.Parse(textBoxIlgiAlaniID.Text));

                sqlKomut.ExecuteNonQuery();

                textBoxIlgiAlaniID.Text = "";
                textBoxIlgiAlaniAciklama.Text = "";
                ilgiAlaniGoster();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dersSecimSüresi = dateTimePickerIlkDeger.Value;
            MessageBox.Show(dateTimePickerIlkDeger.Value + " tarihi son gün olarak belirlenmiştir.");
        }
        private void buttonKarakterSayi_Click(object sender, EventArgs e)
        {
            maxKarakterBelirle = int.Parse(textBoxKarakterSayi.Text);
            MessageBox.Show(" Yönetici tarafından karakter sayısı belirlendi....");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adminOgrenciIslemleri = new AdminOgrenciIslemleri();
            adminOgrenciIslemleri.Show();
        }
        private void buttonHocaIslemleri_Click(object sender, EventArgs e)
        {
            adminHocaIslemleri = new AdminHocaIslemleri();
            adminHocaIslemleri.Show();
        }

        private void buttonDersAtamaIslemleri_Click(object sender, EventArgs e)
        {
            adminDersIslemleri = new AdminDersİslemleri();
            adminDersIslemleri.Show();
        }

        private void buttonTalepleriYonet_Click(object sender, EventArgs e)
        {
            adminTalepYonetimi = new AdminTalepYonetimi();
            adminTalepYonetimi.Show();
        }

        private void buttonMaxHocaBelirler_Click(object sender, EventArgs e)
        {
            maxHocadanDersAlma = int.Parse(textBoxMaxHocadanDersAlma.Text);
        }

        private void buttonGunAtla_Click(object sender, EventArgs e)
        {
            DateTime ilkdeger = dateTimePickerIlkDeger.Value;
            DateTime sondeger = dateTimePickerSonDeger.Value;          
            zaman = sondeger.Subtract(ilkdeger);
            toplamFark = Convert.ToInt32(zaman.TotalDays);
            MessageBox.Show("Gün atlama işlemi yaplıdı");

        }
    }
}
