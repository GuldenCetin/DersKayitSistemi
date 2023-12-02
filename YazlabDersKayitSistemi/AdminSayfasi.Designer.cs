using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace YazlabDersKayitSistemi
{
    partial class AdminSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxIlgiAlaniID = new TextBox();
            textBoxIlgiAlaniAciklama = new TextBox();
            buttonIlgiAlaniEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonIlgiAlaniSil = new Button();
            buttonIlgiAlaniGuncelle = new Button();
            buttonIlgiAlaniListele = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dateTimePickerIlkDeger = new DateTimePicker();
            label4 = new Label();
            textBoxKarakterSayi = new TextBox();
            buttonKarakterSayi = new Button();
            buttonOgrenciIslemleri = new Button();
            buttonHocaIslemleri = new Button();
            buttonDersAtamaIslemleri = new Button();
            buttonTalepleriYonet = new Button();
            buttonMaxHocaBelirler = new Button();
            textBoxMaxHocadanDersAlma = new TextBox();
            dateTimePickerSonDeger = new DateTimePicker();
            buttonGunAtla = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxIlgiAlaniID
            // 
            textBoxIlgiAlaniID.Location = new Point(184, 23);
            textBoxIlgiAlaniID.Name = "textBoxIlgiAlaniID";
            textBoxIlgiAlaniID.ReadOnly = true;
            textBoxIlgiAlaniID.Size = new Size(147, 27);
            textBoxIlgiAlaniID.TabIndex = 0;
            // 
            // textBoxIlgiAlaniAciklama
            // 
            textBoxIlgiAlaniAciklama.Location = new Point(184, 61);
            textBoxIlgiAlaniAciklama.Name = "textBoxIlgiAlaniAciklama";
            textBoxIlgiAlaniAciklama.Size = new Size(147, 27);
            textBoxIlgiAlaniAciklama.TabIndex = 1;
            // 
            // buttonIlgiAlaniEkle
            // 
            buttonIlgiAlaniEkle.Location = new Point(9, 108);
            buttonIlgiAlaniEkle.Name = "buttonIlgiAlaniEkle";
            buttonIlgiAlaniEkle.Size = new Size(147, 52);
            buttonIlgiAlaniEkle.TabIndex = 2;
            buttonIlgiAlaniEkle.Text = "İlgi Alanı Ekle";
            buttonIlgiAlaniEkle.UseVisualStyleBackColor = true;
            buttonIlgiAlaniEkle.Click += buttonIlgiAlaniEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 3;
            label1.Text = "İlgi Alanı ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 4;
            label2.Text = "İlgi Alanı Adı :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonIlgiAlaniSil);
            groupBox1.Controls.Add(buttonIlgiAlaniGuncelle);
            groupBox1.Controls.Add(buttonIlgiAlaniListele);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(buttonIlgiAlaniEkle);
            groupBox1.Controls.Add(textBoxIlgiAlaniAciklama);
            groupBox1.Controls.Add(textBoxIlgiAlaniID);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 550);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlgi Alanı Düzenle";
            // 
            // buttonIlgiAlaniSil
            // 
            buttonIlgiAlaniSil.Location = new Point(9, 172);
            buttonIlgiAlaniSil.Name = "buttonIlgiAlaniSil";
            buttonIlgiAlaniSil.Size = new Size(147, 52);
            buttonIlgiAlaniSil.TabIndex = 7;
            buttonIlgiAlaniSil.Text = "İlgi Alanı Sil";
            buttonIlgiAlaniSil.UseVisualStyleBackColor = true;
            buttonIlgiAlaniSil.Click += buttonIlgiAlaniSil_Click;
            // 
            // buttonIlgiAlaniGuncelle
            // 
            buttonIlgiAlaniGuncelle.Location = new Point(184, 172);
            buttonIlgiAlaniGuncelle.Name = "buttonIlgiAlaniGuncelle";
            buttonIlgiAlaniGuncelle.Size = new Size(147, 52);
            buttonIlgiAlaniGuncelle.TabIndex = 6;
            buttonIlgiAlaniGuncelle.Text = "İlgi Alanı Güncelle";
            buttonIlgiAlaniGuncelle.UseVisualStyleBackColor = true;
            buttonIlgiAlaniGuncelle.Click += buttonIlgiAlaniDuzenle_Click;
            // 
            // buttonIlgiAlaniListele
            // 
            buttonIlgiAlaniListele.Location = new Point(184, 108);
            buttonIlgiAlaniListele.Name = "buttonIlgiAlaniListele";
            buttonIlgiAlaniListele.Size = new Size(147, 52);
            buttonIlgiAlaniListele.TabIndex = 5;
            buttonIlgiAlaniListele.Text = "İlgi Alanı Listele";
            buttonIlgiAlaniListele.UseVisualStyleBackColor = true;
            buttonIlgiAlaniListele.Click += buttonIlgiAlaniListele_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(6, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 300);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(322, 274);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1121, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // dateTimePickerIlkDeger
            // 
            dateTimePickerIlkDeger.Location = new Point(410, 441);
            dateTimePickerIlkDeger.Name = "dateTimePickerIlkDeger";
            dateTimePickerIlkDeger.Size = new Size(213, 27);
            dateTimePickerIlkDeger.TabIndex = 10;
            dateTimePickerIlkDeger.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(370, 103);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 12;
            label4.Text = "Karakter sayısı :";
            // 
            // textBoxKarakterSayi
            // 
            textBoxKarakterSayi.Location = new Point(523, 101);
            textBoxKarakterSayi.Name = "textBoxKarakterSayi";
            textBoxKarakterSayi.Size = new Size(90, 27);
            textBoxKarakterSayi.TabIndex = 13;
            // 
            // buttonKarakterSayi
            // 
            buttonKarakterSayi.Location = new Point(421, 151);
            buttonKarakterSayi.Name = "buttonKarakterSayi";
            buttonKarakterSayi.Size = new Size(174, 29);
            buttonKarakterSayi.TabIndex = 14;
            buttonKarakterSayi.Text = "Karakter sayısını belirle";
            buttonKarakterSayi.UseVisualStyleBackColor = true;
            buttonKarakterSayi.Click += buttonKarakterSayi_Click;
            // 
            // buttonOgrenciIslemleri
            // 
            buttonOgrenciIslemleri.Location = new Point(680, 268);
            buttonOgrenciIslemleri.Name = "buttonOgrenciIslemleri";
            buttonOgrenciIslemleri.Size = new Size(174, 47);
            buttonOgrenciIslemleri.TabIndex = 15;
            buttonOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            buttonOgrenciIslemleri.UseVisualStyleBackColor = true;
            buttonOgrenciIslemleri.Click += button1_Click;
            // 
            // buttonHocaIslemleri
            // 
            buttonHocaIslemleri.Location = new Point(680, 182);
            buttonHocaIslemleri.Name = "buttonHocaIslemleri";
            buttonHocaIslemleri.Size = new Size(174, 47);
            buttonHocaIslemleri.TabIndex = 16;
            buttonHocaIslemleri.Text = "Hoca İşlemleri";
            buttonHocaIslemleri.UseVisualStyleBackColor = true;
            buttonHocaIslemleri.Click += buttonHocaIslemleri_Click;
            // 
            // buttonDersAtamaIslemleri
            // 
            buttonDersAtamaIslemleri.Location = new Point(680, 103);
            buttonDersAtamaIslemleri.Name = "buttonDersAtamaIslemleri";
            buttonDersAtamaIslemleri.Size = new Size(174, 47);
            buttonDersAtamaIslemleri.TabIndex = 17;
            buttonDersAtamaIslemleri.Text = "Ders Atama İşlemleri";
            buttonDersAtamaIslemleri.UseVisualStyleBackColor = true;
            buttonDersAtamaIslemleri.Click += buttonDersAtamaIslemleri_Click;
            // 
            // buttonTalepleriYonet
            // 
            buttonTalepleriYonet.Location = new Point(680, 347);
            buttonTalepleriYonet.Name = "buttonTalepleriYonet";
            buttonTalepleriYonet.Size = new Size(174, 60);
            buttonTalepleriYonet.TabIndex = 18;
            buttonTalepleriYonet.Text = "Talepleri Götüntüle ve Yönet";
            buttonTalepleriYonet.UseVisualStyleBackColor = true;
            buttonTalepleriYonet.Click += buttonTalepleriYonet_Click;
            // 
            // buttonMaxHocaBelirler
            // 
            buttonMaxHocaBelirler.Location = new Point(410, 310);
            buttonMaxHocaBelirler.Name = "buttonMaxHocaBelirler";
            buttonMaxHocaBelirler.Size = new Size(213, 32);
            buttonMaxHocaBelirler.TabIndex = 19;
            buttonMaxHocaBelirler.Text = "Kaç Hocadan Ders Alınabilir";
            buttonMaxHocaBelirler.UseVisualStyleBackColor = true;
            buttonMaxHocaBelirler.Click += buttonMaxHocaBelirler_Click;
            // 
            // textBoxMaxHocadanDersAlma
            // 
            textBoxMaxHocadanDersAlma.Location = new Point(410, 257);
            textBoxMaxHocadanDersAlma.Name = "textBoxMaxHocadanDersAlma";
            textBoxMaxHocadanDersAlma.Size = new Size(213, 27);
            textBoxMaxHocadanDersAlma.TabIndex = 20;
            // 
            // dateTimePickerSonDeger
            // 
            dateTimePickerSonDeger.Location = new Point(410, 494);
            dateTimePickerSonDeger.Name = "dateTimePickerSonDeger";
            dateTimePickerSonDeger.Size = new Size(213, 27);
            dateTimePickerSonDeger.TabIndex = 21;
            // 
            // buttonGunAtla
            // 
            buttonGunAtla.Location = new Point(410, 541);
            buttonGunAtla.Name = "buttonGunAtla";
            buttonGunAtla.Size = new Size(213, 38);
            buttonGunAtla.TabIndex = 22;
            buttonGunAtla.Text = "Gün Atla";
            buttonGunAtla.UseVisualStyleBackColor = true;
            buttonGunAtla.Click += buttonGunAtla_Click;
            // 
            // AdminSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 604);
            Controls.Add(buttonGunAtla);
            Controls.Add(dateTimePickerSonDeger);
            Controls.Add(textBoxMaxHocadanDersAlma);
            Controls.Add(buttonMaxHocaBelirler);
            Controls.Add(buttonTalepleriYonet);
            Controls.Add(buttonDersAtamaIslemleri);
            Controls.Add(buttonHocaIslemleri);
            Controls.Add(buttonOgrenciIslemleri);
            Controls.Add(buttonKarakterSayi);
            Controls.Add(textBoxKarakterSayi);
            Controls.Add(label4);
            Controls.Add(dateTimePickerIlkDeger);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "AdminSayfasi";
            Text = "AdminSayfasi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIlgiAlaniID;
        private TextBox textBoxIlgiAlaniAciklama;
        private Button buttonIlgiAlaniEkle;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Button buttonIlgiAlaniListele;
        private Button buttonIlgiAlaniSil;
        private Button buttonIlgiAlaniGuncelle;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerIlkDeger;
        private Label label4;
        private TextBox textBoxKarakterSayi;
        private Button buttonKarakterSayi;
        private Button buttonOgrenciIslemleri;
        private Button buttonHocaIslemleri;
        private Button buttonDersAtamaIslemleri;
        private Button buttonTalepleriYonet;
        private Button buttonMaxHocaBelirler;
        private TextBox textBoxMaxHocadanDersAlma;
        private DateTimePicker dateTimePickerSonDeger;
        private Button buttonGunAtla;
    }
}