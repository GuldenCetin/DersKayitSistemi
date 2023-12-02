using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazlabDersKayitSistemi
{
    internal class Ogrenci
    {
        private string ogrenciAd;
        private string ogrenciSoyad;
        private bool pdfAttiMi;
        private float agno;
        private int ogrenciNo;
        private ArrayList dersnotlari = new ArrayList();
        private ArrayList dersler ;
        private ArrayList dersidler;
    

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Yazlab; user ID = postgres; password=root ");

        private string[] isimler = {"Adem", "Ahmet", "Akın", "Aytuğ", "Ali", "Açelya", "Afet", "Arzu", "Aslı", "Ayça",
                                "Batu", "Berat", "Berke", "Bora", "Bulut", "Banu", "Begüm", "Beyza", "Buket","Buse",
                                "Can", "Cemal", "Cihan", "Coşkun", "Cüneyt", "Canan", "Cansu", "Cemre", "Ceren", "Ceylin",
                                "Çağan", "Çağrı", "Çelik", "Çetiner", "Çınar", "Çağla", "Çiçek", "Çiğdem", "Çilem",
                                "Demiray", "Deniz", "Devrim", "Doruk", "Dursun", "Damla", "Defne", "Didem", "Dilek", "Duygu",
                                "Ecevit", "Ege", "Ekin", "Emirhan", "Erdoğan", "Ece", "Eda", "Elif", "Esra", "Ezgi",
                                "Fatih", "Ferdi","Fevzi", "Fırat", "Fikri", "Fatma", "Ferah", "Fidan", "Figen", "Fulya",
                                "Gazi", "Gençay", "Gökalp", "Gökhan", "Günay", "Gamze", "Gizem", "Gonca", "Gönül", "Gülden", "Gülsüm",
                                "Hakan", "Hamza", "Hasan", "Hikmet", "Hüseyin", "Hale", "Hayal", "Hazal", "Hediye", "Hilal",
                                "Ilcan", "Ilgaz", "Ilkutay", "Işık", "Işıkalp", "Irmak", "Işık", "Işıl", "Işılay", "Işın",
                                "İbrahim", "İlkay", "İlker", "İsmet", "İzzet", "İclal", "İdil", "İnci", "İpek", "İrem",
                                "Jale", "Jalenur", "Jülide",
                                "Kaan", "Kadir", "Kerem", "Kıvanç", "Kutay", "Kader", "Kadriye", "Kevser", "Kısmet", "Kübra",
                                "Latif", "Levent", "Lokman", "Lütfü", "Lale", "Latife", "Leyla",
                                "Mahsun", "Mehmet", "Mesut", "Muhammet", "Mustafa", "Melek", "Meltem", "Merve", "Mine", "Müge",
                                "Naci", "Nazım", "Nezih", "Nuh", "Nusret", "Nagehan", "Nazlı", "Neslihan", "Nihal", "Nurçin",
                                "Oğuz", "Okan", "Onur", "Orkun", "Ozan", "Orkide", "Oya",
                                "Ömer", "Özay", "Özcan", "Özer", "Özkan", "Övgü", "Özden", "Özge", "Özlem", "Öznur",
                                "Pars", "Peker", "Polat", "Poyraz", "Pusat", "Pelin", "Peri", "Petek", "Pınar", "Poyraz",
                                "Rafet", "Ramazan", "Recep", "Rıdvan", "Rüzgar", "Rabia", "Rana", "Rezzan", "Rukiye", "Rüya",
                                "Sabahattin", "Sabri", "Sefer", "Serhat", "Soner", "Sabriye", "Sahra", "Seda", "Selin", "Songül",
                                "Şafak", "Şahin", "Şener", "Şevki", "Şükrü", "Şaduman", "Şefkat", "Şevval", "Şükran", "Şüle",
                                "Taci", "Taner", "Tarık", "Tevfik", "Tolunay", "Taçnur", "Tanem", "Tuğçe", "Tülay", "Tülin",
                                "Ufuk", "Uğur", "Ulaş", "Umut", "Uygar", "Ubeyde", "Uzay", "Uzel",
                                "Ümit", "Ümmet", "Ünalp", "Ünsal", "Üzeyir", "Ülkenur", "Ümmü", "Ünsel",
                                "Vahit", "Vatan", "Veli", "Veysel", "Volkan", "Vacibe", "Vecibe", "Veda", "Vesile", "Vildan",
                                "Yağız", "Yahya", "Yasin", "Yekta", "Yiğit", "Yağmur", "Yankı", "Yeliz", "Yonca", "Yüsra",
                                "Zafer", "Zahit", "Zekeriya", "Zeki", "Ziya", "Zambak", "Zehra", "Zeynep", "Zuhal", "Zümra"};
        private string[] soyisimler = {"Adanmış", "Ağar", "Algın", "Anıt", "Ardalı", "Bağımsız", "Bastık", "Başçıl", "Beğenmiş", "Başel",
                                       "Caymaz", "Cetik", "Cenker", "Çabacı", "Çağlak", "Çatık", "Çengiz", "Çolak",
                                       "Dağ", "Deli", "Dinç", "Donatır", "Düzgün", "Ege", "Eğri", "Ekelik", "Erdem", "Esirgen",
                                       "Faysallı", "Filiz", "Fulya", "Geçgin", "Gence", "Gezgin", "Gül", "Güner",
                                       "Hakan", "His", "Hissiz", "İş", "İşçi", "İlgi", "İpsiz", "İrade",
                                       "Karagül", "Kaynak", "Keser", "Kara", "Kurtulmuş", "Lav", "Mollaoğlu", "Mumcu",
                                       "Nas", "Nazlı", "Nitelikli", "Normal", "Nil", "Okuyan", "Okumuş", "Olduran", "Olduk", "Ozan",
                                       "Öksüz", "Ödlek", "Örs", "Ölmüş", "Öz", "Piroğlu", "Payedar", "Pay", "Paslı", "Pinti",
                                       "Sabancı", "Sarıgül", "Sözüçetin", "Saygın", "Salihoğlu", "Şabah", "Şahin", "Şen", "Şenlik", "Şeyh",
                                       "Tahir", "Tahtacı", "Tapukçu", "Taşürek", "Taycan", "Uysal", "Uzun", "Umar", "Unutkan",
                                       "Ülke", "Ürkek", "Üründül", "Üst", "Üzgün", "Vanlı", "Varank", "Varmış", "Varol", "Verdi",
                                       "Yaban", "Yad", "Yakut", "Yanar", "Yaş", "Zaman"};

 

        private string[] alinanHarfNotlari = { "AA", "BA" ,"BB", "BC", "CB","CC","DC","DD","FF"};


        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }
        public bool PdfAttiMi { get => pdfAttiMi; set => pdfAttiMi = value; }
        public float Agno { get => agno; set => agno = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public ArrayList Dersler { get => dersler; set => dersler = value; }
        public ArrayList DersNotlari { get => dersnotlari; set => dersnotlari = value; }

        public ArrayList Dersidler { get => dersidler; set => dersidler = value; }


        public Ogrenci()
        { 

        }
        private float rastgeleDoubleOlustur()
        {
            Random random = new Random();
            float randomFloat = (float)(random.NextDouble() * (4 - 1.8) + 1.8);
            return randomFloat;
        }
        private void transkriptOlustur()
        {
            dersler = new ArrayList();
            dersidler = new ArrayList();
            try
            {
                baglanti.Open();
                NpgsqlCommand sqlKomut = new NpgsqlCommand("SELECT DISTINCT dersid, dersadi FROM ogrencidersbilgileri", baglanti);
                NpgsqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dersler.Add(sqlDataReader["dersadi"]);
                    dersidler.Add(sqlDataReader["dersid"]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
       
        
        public void rastgeleOgrenciOlustur( Ogrenci ogrenci)
        {
            Random random = new Random(); 
            int isimIndex = random.Next(0, isimler.Length);
            int soyisimIndex = random.Next(0, soyisimler.Length);
           

            ogrenci.OgrenciAd = isimler[isimIndex];
            ogrenci.OgrenciSoyad = soyisimler[soyisimIndex];
            ogrenci.PdfAttiMi = random.Next(2) == 1;
            ogrenci.Agno = rastgeleDoubleOlustur();

            transkriptOlustur();
            for (int i = 0; i < dersler.Count; i++)
            {
                int harfnotuindex = random.Next(0, alinanHarfNotlari.Length);
                ogrenci.Dersler.Add(dersler[i]);    //  şimdi dersidleri sırayla gelicek harf notları rastgele 
                ogrenci.DersNotlari.Add(alinanHarfNotlari[harfnotuindex]);
                ogrenci.Dersidler.Add(dersidler[i]);
            }



        }

    }
}
