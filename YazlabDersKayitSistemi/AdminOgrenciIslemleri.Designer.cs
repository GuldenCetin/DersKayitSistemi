using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace YazlabDersKayitSistemi
{
    partial class AdminOgrenciIslemleri
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
            textBoxOgrenciAdi = new TextBox();
            textBoxOgrenciSoyadi = new TextBox();
            textBoxPDFAttiMi = new TextBox();
            textBoxAGNO = new TextBox();
            buttonOgrenciOlustur = new Button();
            buttonOgrenciEkle = new Button();
            buttonOgrenciListele = new Button();
            dataGridView1 = new DataGridView();
            buttonOgrenciGuncelle = new Button();
            buttonOgrenciSil = new Button();
            textBoxOgrenciNo = new TextBox();
            textBoxOgrenciSayisi = new TextBox();
            labelOgrenciSayisi = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxOgrenciAdi
            // 
            textBoxOgrenciAdi.Location = new Point(274, 148);
            textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            textBoxOgrenciAdi.Size = new Size(140, 27);
            textBoxOgrenciAdi.TabIndex = 0;
            // 
            // textBoxOgrenciSoyadi
            // 
            textBoxOgrenciSoyadi.Location = new Point(274, 197);
            textBoxOgrenciSoyadi.Name = "textBoxOgrenciSoyadi";
            textBoxOgrenciSoyadi.Size = new Size(140, 27);
            textBoxOgrenciSoyadi.TabIndex = 1;
            // 
            // textBoxPDFAttiMi
            // 
            textBoxPDFAttiMi.Location = new Point(274, 248);
            textBoxPDFAttiMi.Name = "textBoxPDFAttiMi";
            textBoxPDFAttiMi.Size = new Size(140, 27);
            textBoxPDFAttiMi.TabIndex = 2;
            // 
            // textBoxAGNO
            // 
            textBoxAGNO.Location = new Point(274, 303);
            textBoxAGNO.Name = "textBoxAGNO";
            textBoxAGNO.Size = new Size(140, 27);
            textBoxAGNO.TabIndex = 3;
            // 
            // buttonOgrenciOlustur
            // 
            buttonOgrenciOlustur.Location = new Point(466, 121);
            buttonOgrenciOlustur.Name = "buttonOgrenciOlustur";
            buttonOgrenciOlustur.Size = new Size(167, 41);
            buttonOgrenciOlustur.TabIndex = 4;
            buttonOgrenciOlustur.Text = "Öğrenci Oluştur";
            buttonOgrenciOlustur.UseVisualStyleBackColor = true;
            buttonOgrenciOlustur.Click += buttonOgrenciOlustur_Click;
            // 
            // buttonOgrenciEkle
            // 
            buttonOgrenciEkle.Location = new Point(466, 168);
            buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            buttonOgrenciEkle.Size = new Size(167, 36);
            buttonOgrenciEkle.TabIndex = 5;
            buttonOgrenciEkle.Text = "Öğrenci Ekle";
            buttonOgrenciEkle.UseVisualStyleBackColor = true;
            buttonOgrenciEkle.Click += buttonOgrenciEkle_Click;
            // 
            // buttonOgrenciListele
            // 
            buttonOgrenciListele.Location = new Point(466, 210);
            buttonOgrenciListele.Name = "buttonOgrenciListele";
            buttonOgrenciListele.Size = new Size(167, 36);
            buttonOgrenciListele.TabIndex = 6;
            buttonOgrenciListele.Text = "Öğrenci Listele";
            buttonOgrenciListele.UseVisualStyleBackColor = true;
            buttonOgrenciListele.Click += buttonOgrenciListele_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(712, 173);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonOgrenciGuncelle
            // 
            buttonOgrenciGuncelle.Location = new Point(466, 252);
            buttonOgrenciGuncelle.Name = "buttonOgrenciGuncelle";
            buttonOgrenciGuncelle.Size = new Size(167, 36);
            buttonOgrenciGuncelle.TabIndex = 8;
            buttonOgrenciGuncelle.Text = "Öğrenci Güncelle";
            buttonOgrenciGuncelle.UseVisualStyleBackColor = true;
            buttonOgrenciGuncelle.Click += buttonOgrenciGuncelle_Click;
            // 
            // buttonOgrenciSil
            // 
            buttonOgrenciSil.Location = new Point(466, 294);
            buttonOgrenciSil.Name = "buttonOgrenciSil";
            buttonOgrenciSil.Size = new Size(167, 36);
            buttonOgrenciSil.TabIndex = 9;
            buttonOgrenciSil.Text = "Öğrenci Sil";
            buttonOgrenciSil.UseVisualStyleBackColor = true;
            buttonOgrenciSil.Click += buttonOgrenciSil_Click;
            // 
            // textBoxOgrenciNo
            // 
            textBoxOgrenciNo.Location = new Point(274, 106);
            textBoxOgrenciNo.Name = "textBoxOgrenciNo";
            textBoxOgrenciNo.ReadOnly = true;
            textBoxOgrenciNo.Size = new Size(140, 27);
            textBoxOgrenciNo.TabIndex = 10;
            // 
            // textBoxOgrenciSayisi
            // 
            textBoxOgrenciSayisi.Location = new Point(581, 92);
            textBoxOgrenciSayisi.Name = "textBoxOgrenciSayisi";
            textBoxOgrenciSayisi.Size = new Size(52, 27);
            textBoxOgrenciSayisi.TabIndex = 11;
            // 
            // labelOgrenciSayisi
            // 
            labelOgrenciSayisi.AutoSize = true;
            labelOgrenciSayisi.Location = new Point(466, 95);
            labelOgrenciSayisi.Name = "labelOgrenciSayisi";
            labelOgrenciSayisi.Size = new Size(109, 20);
            labelOgrenciSayisi.TabIndex = 12;
            labelOgrenciSayisi.Text = "Öğrenci Sayısı :";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // AdminOgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 531);
            Controls.Add(labelOgrenciSayisi);
            Controls.Add(textBoxOgrenciSayisi);
            Controls.Add(textBoxOgrenciNo);
            Controls.Add(buttonOgrenciSil);
            Controls.Add(buttonOgrenciGuncelle);
            Controls.Add(dataGridView1);
            Controls.Add(buttonOgrenciListele);
            Controls.Add(buttonOgrenciEkle);
            Controls.Add(buttonOgrenciOlustur);
            Controls.Add(textBoxAGNO);
            Controls.Add(textBoxPDFAttiMi);
            Controls.Add(textBoxOgrenciSoyadi);
            Controls.Add(textBoxOgrenciAdi);
            Name = "AdminOgrenciIslemleri";
            Text = "AdminOgrenciIslemleri";
            Load += AdminOgrenciIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOgrenciAdi;
        private TextBox textBoxOgrenciSoyadi;
        private TextBox textBoxPDFAttiMi;
        private TextBox textBoxAGNO;
        private Button buttonOgrenciOlustur;
        private Button buttonOgrenciEkle;
        private Button buttonOgrenciListele;
        private DataGridView dataGridView1;
        private Button buttonOgrenciGuncelle;
        private Button buttonOgrenciSil;
        private TextBox textBoxOgrenciNo;
        private TextBox textBoxOgrenciSayisi;
        private Label labelOgrenciSayisi;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}