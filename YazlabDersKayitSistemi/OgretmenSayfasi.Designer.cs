using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace YazlabDersKayitSistemi
{
    partial class OgretmenSayfasi
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
            label1 = new Label();
            comboBoxIlgiSec = new ComboBox();
            buttonIlgiKaydet = new Button();
            buttonTalepGoruntule = new Button();
            dataGridViewHocayaTalepAtanlar = new DataGridView();
            buttonOgrenciyeTalepGonder = new Button();
            richTextBoxMesaj = new RichTextBox();
            label2 = new Label();
            buttonTalepOnayla = new Button();
            dataGridViewBaskaHocalaraTalepAtanlar = new DataGridView();
            buttonBaskaHocalaraTalepAtan = new Button();
            buttonTalepAtmayanOgrenciler = new Button();
            dataGridViewOgrenciGecmisDersler = new DataGridView();
            label3 = new Label();
            comboBoxKriterDers = new ComboBox();
            buttonTalepReddet = new Button();
            buttonKriterDersEkleme = new Button();
            textBoxKatsayiAlma = new TextBox();
            label4 = new Label();
            dataGridViewKritereGore = new DataGridView();
            buttonKritereGoreListele = new Button();
            buttonKritereGoreFiltrele = new Button();
            comboBoxHocaninVerdigiDersler = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocayaTalepAtanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaskaHocalaraTalepAtanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciGecmisDersler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKritereGore).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "İlgi Alanlarını Seçme";
            // 
            // comboBoxIlgiSec
            // 
            comboBoxIlgiSec.FormattingEnabled = true;
            comboBoxIlgiSec.Location = new Point(186, 31);
            comboBoxIlgiSec.Name = "comboBoxIlgiSec";
            comboBoxIlgiSec.Size = new Size(151, 28);
            comboBoxIlgiSec.TabIndex = 1;
            comboBoxIlgiSec.SelectedIndexChanged += comboBoxIlgiSec_SelectedIndexChanged;
            // 
            // buttonIlgiKaydet
            // 
            buttonIlgiKaydet.Location = new Point(186, 81);
            buttonIlgiKaydet.Name = "buttonIlgiKaydet";
            buttonIlgiKaydet.Size = new Size(151, 39);
            buttonIlgiKaydet.TabIndex = 2;
            buttonIlgiKaydet.Text = "Veritabanına Kaydet";
            buttonIlgiKaydet.UseVisualStyleBackColor = true;
            buttonIlgiKaydet.Click += buttonIlgiKaydet_Click;
            // 
            // buttonTalepGoruntule
            // 
            buttonTalepGoruntule.Location = new Point(24, 141);
            buttonTalepGoruntule.Name = "buttonTalepGoruntule";
            buttonTalepGoruntule.Size = new Size(228, 29);
            buttonTalepGoruntule.TabIndex = 3;
            buttonTalepGoruntule.Text = "Talep Oluşturanları görüntüle";
            buttonTalepGoruntule.UseVisualStyleBackColor = true;
            buttonTalepGoruntule.Click += buttonTalepGoruntule_Click;
            // 
            // dataGridViewHocayaTalepAtanlar
            // 
            dataGridViewHocayaTalepAtanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocayaTalepAtanlar.Location = new Point(24, 221);
            dataGridViewHocayaTalepAtanlar.Name = "dataGridViewHocayaTalepAtanlar";
            dataGridViewHocayaTalepAtanlar.ReadOnly = true;
            dataGridViewHocayaTalepAtanlar.RowHeadersWidth = 51;
            dataGridViewHocayaTalepAtanlar.RowTemplate.Height = 29;
            dataGridViewHocayaTalepAtanlar.Size = new Size(447, 135);
            dataGridViewHocayaTalepAtanlar.TabIndex = 4;
            dataGridViewHocayaTalepAtanlar.CellDoubleClick += dataGridViewHocayaTalepAtanlar_CellDoubleClick;
            // 
            // buttonOgrenciyeTalepGonder
            // 
            buttonOgrenciyeTalepGonder.Location = new Point(607, 501);
            buttonOgrenciyeTalepGonder.Name = "buttonOgrenciyeTalepGonder";
            buttonOgrenciyeTalepGonder.Size = new Size(198, 29);
            buttonOgrenciyeTalepGonder.TabIndex = 5;
            buttonOgrenciyeTalepGonder.Text = "Öğrenciye Talep Gönder";
            buttonOgrenciyeTalepGonder.UseVisualStyleBackColor = true;
            buttonOgrenciyeTalepGonder.Click += buttonOgrenciyeTalepGonder_Click;
            // 
            // richTextBoxMesaj
            // 
            richTextBoxMesaj.Location = new Point(607, 549);
            richTextBoxMesaj.Name = "richTextBoxMesaj";
            richTextBoxMesaj.Size = new Size(198, 121);
            richTextBoxMesaj.TabIndex = 6;
            richTextBoxMesaj.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(904, -13);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // buttonTalepOnayla
            // 
            buttonTalepOnayla.Location = new Point(351, 140);
            buttonTalepOnayla.Name = "buttonTalepOnayla";
            buttonTalepOnayla.Size = new Size(120, 30);
            buttonTalepOnayla.TabIndex = 8;
            buttonTalepOnayla.Text = "Talep Onayla";
            buttonTalepOnayla.UseVisualStyleBackColor = true;
            buttonTalepOnayla.Click += buttonTalepOnayla_Click;
            // 
            // dataGridViewBaskaHocalaraTalepAtanlar
            // 
            dataGridViewBaskaHocalaraTalepAtanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaskaHocalaraTalepAtanlar.Location = new Point(24, 462);
            dataGridViewBaskaHocalaraTalepAtanlar.Name = "dataGridViewBaskaHocalaraTalepAtanlar";
            dataGridViewBaskaHocalaraTalepAtanlar.RowHeadersWidth = 51;
            dataGridViewBaskaHocalaraTalepAtanlar.RowTemplate.Height = 29;
            dataGridViewBaskaHocalaraTalepAtanlar.Size = new Size(447, 135);
            dataGridViewBaskaHocalaraTalepAtanlar.TabIndex = 9;
            // 
            // buttonBaskaHocalaraTalepAtan
            // 
            buttonBaskaHocalaraTalepAtan.Location = new Point(103, 378);
            buttonBaskaHocalaraTalepAtan.Name = "buttonBaskaHocalaraTalepAtan";
            buttonBaskaHocalaraTalepAtan.Size = new Size(289, 30);
            buttonBaskaHocalaraTalepAtan.TabIndex = 10;
            buttonBaskaHocalaraTalepAtan.Text = "Başka Hocalara Talep Atan Öğrenciler";
            buttonBaskaHocalaraTalepAtan.UseVisualStyleBackColor = true;
            buttonBaskaHocalaraTalepAtan.Click += buttonBaskaHocalaraTalepAtan_Click;
            // 
            // buttonTalepAtmayanOgrenciler
            // 
            buttonTalepAtmayanOgrenciler.Location = new Point(103, 414);
            buttonTalepAtmayanOgrenciler.Name = "buttonTalepAtmayanOgrenciler";
            buttonTalepAtmayanOgrenciler.Size = new Size(289, 29);
            buttonTalepAtmayanOgrenciler.TabIndex = 11;
            buttonTalepAtmayanOgrenciler.Text = "Talep Atmayan Öğrenciler";
            buttonTalepAtmayanOgrenciler.UseVisualStyleBackColor = true;
            buttonTalepAtmayanOgrenciler.Click += buttonTalepAtmayanOgrenciler_Click;
            // 
            // dataGridViewOgrenciGecmisDersler
            // 
            dataGridViewOgrenciGecmisDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciGecmisDersler.Location = new Point(904, 378);
            dataGridViewOgrenciGecmisDersler.Name = "dataGridViewOgrenciGecmisDersler";
            dataGridViewOgrenciGecmisDersler.RowHeadersWidth = 51;
            dataGridViewOgrenciGecmisDersler.RowTemplate.Height = 29;
            dataGridViewOgrenciGecmisDersler.Size = new Size(420, 314);
            dataGridViewOgrenciGecmisDersler.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 100);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 13;
            label3.Text = "Kriter dersleri seçiniz";
            // 
            // comboBoxKriterDers
            // 
            comboBoxKriterDers.FormattingEnabled = true;
            comboBoxKriterDers.Location = new Point(604, 159);
            comboBoxKriterDers.Name = "comboBoxKriterDers";
            comboBoxKriterDers.Size = new Size(198, 28);
            comboBoxKriterDers.TabIndex = 14;
            // 
            // buttonTalepReddet
            // 
            buttonTalepReddet.Location = new Point(351, 176);
            buttonTalepReddet.Name = "buttonTalepReddet";
            buttonTalepReddet.Size = new Size(120, 30);
            buttonTalepReddet.TabIndex = 15;
            buttonTalepReddet.Text = "Talep Reddet";
            buttonTalepReddet.UseVisualStyleBackColor = true;
            buttonTalepReddet.Click += buttonTalepReddet_Click;
            // 
            // buttonKriterDersEkleme
            // 
            buttonKriterDersEkleme.Location = new Point(607, 267);
            buttonKriterDersEkleme.Name = "buttonKriterDersEkleme";
            buttonKriterDersEkleme.Size = new Size(195, 29);
            buttonKriterDersEkleme.TabIndex = 16;
            buttonKriterDersEkleme.Text = "Kriter Ders Ekleme";
            buttonKriterDersEkleme.UseVisualStyleBackColor = true;
            buttonKriterDersEkleme.Click += buttonKriterDersEkleme_Click;
            // 
            // textBoxKatsayiAlma
            // 
            textBoxKatsayiAlma.Location = new Point(711, 220);
            textBoxKatsayiAlma.Name = "textBoxKatsayiAlma";
            textBoxKatsayiAlma.Size = new Size(91, 27);
            textBoxKatsayiAlma.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 220);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 18;
            label4.Text = "Katsayı veriniz";
            // 
            // dataGridViewKritereGore
            // 
            dataGridViewKritereGore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKritereGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKritereGore.Location = new Point(904, 42);
            dataGridViewKritereGore.Name = "dataGridViewKritereGore";
            dataGridViewKritereGore.RowHeadersWidth = 51;
            dataGridViewKritereGore.RowTemplate.Height = 29;
            dataGridViewKritereGore.Size = new Size(420, 314);
            dataGridViewKritereGore.TabIndex = 19;
            dataGridViewKritereGore.CellDoubleClick += dataGridViewKritereGore_CellDoubleClick;
            // 
            // buttonKritereGoreListele
            // 
            buttonKritereGoreListele.Location = new Point(607, 319);
            buttonKritereGoreListele.Name = "buttonKritereGoreListele";
            buttonKritereGoreListele.Size = new Size(195, 29);
            buttonKritereGoreListele.TabIndex = 20;
            buttonKritereGoreListele.Text = "Kriter Derse Göre Listele";
            buttonKritereGoreListele.UseVisualStyleBackColor = true;
            buttonKritereGoreListele.Click += buttonKritereGoreListele_Click;
            // 
            // buttonKritereGoreFiltrele
            // 
            buttonKritereGoreFiltrele.Location = new Point(607, 367);
            buttonKritereGoreFiltrele.Name = "buttonKritereGoreFiltrele";
            buttonKritereGoreFiltrele.Size = new Size(195, 29);
            buttonKritereGoreFiltrele.TabIndex = 21;
            buttonKritereGoreFiltrele.Text = "Kriter Derse Göre Filtrele";
            buttonKritereGoreFiltrele.UseVisualStyleBackColor = true;
            buttonKritereGoreFiltrele.Click += buttonKritereGoreFiltrele_Click;
            // 
            // comboBoxHocaninVerdigiDersler
            // 
            comboBoxHocaninVerdigiDersler.FormattingEnabled = true;
            comboBoxHocaninVerdigiDersler.Location = new Point(630, 451);
            comboBoxHocaninVerdigiDersler.Name = "comboBoxHocaninVerdigiDersler";
            comboBoxHocaninVerdigiDersler.Size = new Size(175, 28);
            comboBoxHocaninVerdigiDersler.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 454);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 23;
            label5.Text = "Verdiğim Dersler ";
            // 
            // OgretmenSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 716);
            Controls.Add(label5);
            Controls.Add(comboBoxHocaninVerdigiDersler);
            Controls.Add(buttonKritereGoreFiltrele);
            Controls.Add(buttonKritereGoreListele);
            Controls.Add(dataGridViewKritereGore);
            Controls.Add(label4);
            Controls.Add(textBoxKatsayiAlma);
            Controls.Add(buttonKriterDersEkleme);
            Controls.Add(buttonTalepReddet);
            Controls.Add(comboBoxKriterDers);
            Controls.Add(label3);
            Controls.Add(dataGridViewOgrenciGecmisDersler);
            Controls.Add(buttonTalepAtmayanOgrenciler);
            Controls.Add(buttonBaskaHocalaraTalepAtan);
            Controls.Add(dataGridViewBaskaHocalaraTalepAtanlar);
            Controls.Add(buttonTalepOnayla);
            Controls.Add(label2);
            Controls.Add(richTextBoxMesaj);
            Controls.Add(buttonOgrenciyeTalepGonder);
            Controls.Add(dataGridViewHocayaTalepAtanlar);
            Controls.Add(buttonTalepGoruntule);
            Controls.Add(buttonIlgiKaydet);
            Controls.Add(comboBoxIlgiSec);
            Controls.Add(label1);
            Name = "OgretmenSayfasi";
            Text = "OgretmenSayfasi";
            Load += OgretmenSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocayaTalepAtanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaskaHocalaraTalepAtanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciGecmisDersler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKritereGore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxIlgiSec;
        private Button buttonIlgiKaydet;
        private Button buttonTalepGoruntule;
        private DataGridView dataGridViewHocayaTalepAtanlar;
        private Button buttonOgrenciyeTalepGonder;
        private RichTextBox richTextBoxMesaj;
        private Label label2;
        private Button buttonTalepOnayla;
        private DataGridView dataGridViewBaskaHocalaraTalepAtanlar;
        private Button buttonBaskaHocalaraTalepAtan;
        private Button buttonTalepAtmayanOgrenciler;
        private DataGridView dataGridViewOgrenciGecmisDersler;
        private Label label3;
        private ComboBox comboBoxKriterDers;
        private Button buttonTalepReddet;
        private Button buttonKriterDersEkleme;
        private TextBox textBoxKatsayiAlma;
        private Label label4;
        private DataGridView dataGridViewKritereGore;
        private Button buttonKritereGoreListele;
        private Button buttonKritereGoreFiltrele;
        private ComboBox comboBoxHocaninVerdigiDersler;
        private Label label5;
    }
}