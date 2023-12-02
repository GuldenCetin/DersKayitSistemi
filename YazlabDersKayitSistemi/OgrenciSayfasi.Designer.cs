using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace YazlabDersKayitSistemi
{
    partial class OgrenciSayfasi
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
            buttonTranskriptEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBoxDersFiltresi = new ComboBox();
            dataGridViewHocalar = new DataGridView();
            groupBox1 = new GroupBox();
            buttonFiltrele = new Button();
            label4 = new Label();
            comboBoxIlgiFiltresi = new ComboBox();
            labelGirisYapanId = new Label();
            groupBox2 = new GroupBox();
            richTextBoxMesaj = new RichTextBox();
            buttonTalepOlustur = new Button();
            label8 = new Label();
            label7 = new Label();
            textBoxAlanId = new TextBox();
            label6 = new Label();
            textBoxGonderenId = new TextBox();
            buttonDersBilgileriGoster = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            buttonTalepGeriCek = new Button();
            buttonBekleyenTalepGoster = new Button();
            groupBox3 = new GroupBox();
            buttonOnaylananDersler = new Button();
            buttonTalepOnayla = new Button();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "Transkript Belgenizi Yükleyiniz";
            // 
            // buttonTranskriptEkle
            // 
            buttonTranskriptEkle.Location = new Point(25, 128);
            buttonTranskriptEkle.Name = "buttonTranskriptEkle";
            buttonTranskriptEkle.Size = new Size(133, 36);
            buttonTranskriptEkle.TabIndex = 1;
            buttonTranskriptEkle.Text = "Transkript Ekle";
            buttonTranskriptEkle.UseVisualStyleBackColor = true;
            buttonTranskriptEkle.Click += buttonTranskriptEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(181, 23);
            label2.Name = "label2";
            label2.Size = new Size(264, 41);
            label2.TabIndex = 2;
            label2.Text = "Ders Seçim İşlemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 85);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 3;
            label3.Text = "Almak İstediğiniz Ders :";
            // 
            // comboBoxDersFiltresi
            // 
            comboBoxDersFiltresi.FormattingEnabled = true;
            comboBoxDersFiltresi.Location = new Point(181, 83);
            comboBoxDersFiltresi.Name = "comboBoxDersFiltresi";
            comboBoxDersFiltresi.Size = new Size(142, 28);
            comboBoxDersFiltresi.TabIndex = 4;
            comboBoxDersFiltresi.SelectionChangeCommitted += comboBoxDersFiltresi_SelectionChangeCommitted;
            // 
            // dataGridViewHocalar
            // 
            dataGridViewHocalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHocalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocalar.Location = new Point(33, 193);
            dataGridViewHocalar.Name = "dataGridViewHocalar";
            dataGridViewHocalar.RowHeadersWidth = 51;
            dataGridViewHocalar.RowTemplate.Height = 29;
            dataGridViewHocalar.Size = new Size(569, 235);
            dataGridViewHocalar.TabIndex = 5;
            dataGridViewHocalar.CellClick += dataGridViewHocalar_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonFiltrele);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxIlgiFiltresi);
            groupBox1.Controls.Add(dataGridViewHocalar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxDersFiltresi);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(238, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 515);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // buttonFiltrele
            // 
            buttonFiltrele.Enabled = false;
            buttonFiltrele.Location = new Point(293, 139);
            buttonFiltrele.Name = "buttonFiltrele";
            buttonFiltrele.Size = new Size(153, 39);
            buttonFiltrele.TabIndex = 10;
            buttonFiltrele.Text = "Filtrele";
            buttonFiltrele.UseVisualStyleBackColor = true;
            buttonFiltrele.Click += buttonFiltrele_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 85);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "İlgi Alanı :";
            // 
            // comboBoxIlgiFiltresi
            // 
            comboBoxIlgiFiltresi.FormattingEnabled = true;
            comboBoxIlgiFiltresi.Location = new Point(435, 83);
            comboBoxIlgiFiltresi.Name = "comboBoxIlgiFiltresi";
            comboBoxIlgiFiltresi.Size = new Size(142, 28);
            comboBoxIlgiFiltresi.TabIndex = 6;
            // 
            // labelGirisYapanId
            // 
            labelGirisYapanId.AutoSize = true;
            labelGirisYapanId.Location = new Point(1476, 12);
            labelGirisYapanId.Name = "labelGirisYapanId";
            labelGirisYapanId.Size = new Size(50, 20);
            labelGirisYapanId.TabIndex = 7;
            labelGirisYapanId.Text = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxMesaj);
            groupBox2.Controls.Add(buttonTalepOlustur);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxAlanId);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxGonderenId);
            groupBox2.Location = new Point(865, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 492);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // richTextBoxMesaj
            // 
            richTextBoxMesaj.Location = new Point(26, 264);
            richTextBoxMesaj.Name = "richTextBoxMesaj";
            richTextBoxMesaj.Size = new Size(239, 120);
            richTextBoxMesaj.TabIndex = 7;
            richTextBoxMesaj.Text = "";
            // 
            // buttonTalepOlustur
            // 
            buttonTalepOlustur.Location = new Point(71, 432);
            buttonTalepOlustur.Name = "buttonTalepOlustur";
            buttonTalepOlustur.Size = new Size(133, 35);
            buttonTalepOlustur.TabIndex = 6;
            buttonTalepOlustur.Text = "Talep Oluştur";
            buttonTalepOlustur.UseVisualStyleBackColor = true;
            buttonTalepOlustur.Click += buttonTalepOlustur_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 209);
            label8.Name = "label8";
            label8.Size = new Size(171, 31);
            label8.TabIndex = 5;
            label8.Text = "İletilecek Mesaj";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 139);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 3;
            label7.Text = "Alan :";
            // 
            // textBoxAlanId
            // 
            textBoxAlanId.Location = new Point(106, 139);
            textBoxAlanId.Name = "textBoxAlanId";
            textBoxAlanId.Size = new Size(146, 27);
            textBoxAlanId.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 80);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 1;
            label6.Text = "Gönderen :";
            // 
            // textBoxGonderenId
            // 
            textBoxGonderenId.Location = new Point(113, 80);
            textBoxGonderenId.Name = "textBoxGonderenId";
            textBoxGonderenId.ReadOnly = true;
            textBoxGonderenId.Size = new Size(146, 27);
            textBoxGonderenId.TabIndex = 0;
            // 
            // buttonDersBilgileriGoster
            // 
            buttonDersBilgileriGoster.Location = new Point(25, 205);
            buttonDersBilgileriGoster.Name = "buttonDersBilgileriGoster";
            buttonDersBilgileriGoster.Size = new Size(168, 29);
            buttonDersBilgileriGoster.TabIndex = 10;
            buttonDersBilgileriGoster.Text = " Ders Bilgileri Göster";
            buttonDersBilgileriGoster.UseVisualStyleBackColor = true;
            buttonDersBilgileriGoster.Click += buttonDersBilgileriGoster_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(348, 189);
            dataGridView2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1278, 34);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 12;
            label5.Text = "Onaylanan Talepler";
            // 
            // buttonTalepGeriCek
            // 
            buttonTalepGeriCek.Location = new Point(1175, 550);
            buttonTalepGeriCek.Name = "buttonTalepGeriCek";
            buttonTalepGeriCek.Size = new Size(187, 29);
            buttonTalepGeriCek.TabIndex = 13;
            buttonTalepGeriCek.Text = "Talep Geri Çek";
            buttonTalepGeriCek.UseVisualStyleBackColor = true;
            buttonTalepGeriCek.Click += buttonTalepGeriCek_Click;
            // 
            // buttonBekleyenTalepGoster
            // 
            buttonBekleyenTalepGoster.Location = new Point(1175, 498);
            buttonBekleyenTalepGoster.Margin = new Padding(3, 4, 3, 4);
            buttonBekleyenTalepGoster.Name = "buttonBekleyenTalepGoster";
            buttonBekleyenTalepGoster.Size = new Size(187, 31);
            buttonBekleyenTalepGoster.TabIndex = 14;
            buttonBekleyenTalepGoster.Text = "Bekleyen Talepleri Göster";
            buttonBekleyenTalepGoster.UseVisualStyleBackColor = true;
            buttonBekleyenTalepGoster.Click += buttonBekleyenTalepGoster_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(1175, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 215);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // buttonOnaylananDersler
            // 
            buttonOnaylananDersler.Location = new Point(1377, 498);
            buttonOnaylananDersler.Name = "buttonOnaylananDersler";
            buttonOnaylananDersler.Size = new Size(149, 29);
            buttonOnaylananDersler.TabIndex = 16;
            buttonOnaylananDersler.Text = "Onaylanan Dersler";
            buttonOnaylananDersler.UseVisualStyleBackColor = true;
            buttonOnaylananDersler.Click += buttonOnaylananDersler_Click;
            // 
            // buttonTalepOnayla
            // 
            buttonTalepOnayla.Location = new Point(1377, 550);
            buttonTalepOnayla.Name = "buttonTalepOnayla";
            buttonTalepOnayla.Size = new Size(149, 29);
            buttonTalepOnayla.TabIndex = 17;
            buttonTalepOnayla.Text = "Talep Onayla";
            buttonTalepOnayla.UseVisualStyleBackColor = true;
            buttonTalepOnayla.Click += buttonTalepOnayla_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1178, 299);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(348, 186);
            dataGridView3.TabIndex = 18;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // OgrenciSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 589);
            Controls.Add(dataGridView3);
            Controls.Add(buttonTalepOnayla);
            Controls.Add(buttonOnaylananDersler);
            Controls.Add(groupBox3);
            Controls.Add(buttonBekleyenTalepGoster);
            Controls.Add(buttonTalepGeriCek);
            Controls.Add(label5);
            Controls.Add(buttonDersBilgileriGoster);
            Controls.Add(groupBox2);
            Controls.Add(labelGirisYapanId);
            Controls.Add(groupBox1);
            Controls.Add(buttonTranskriptEkle);
            Controls.Add(label1);
            Name = "OgrenciSayfasi";
            Text = "OgrenciSayfasi";
            Load += OgrenciSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonTranskriptEkle;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxDersFiltresi;
        private DataGridView dataGridViewHocalar;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox comboBoxIlgiFiltresi;
        private Button buttonFiltrele;
        private Label labelGirisYapanId;
        private GroupBox groupBox2;
        private Button buttonTalepOlustur;
        private Label label8;
        private Label label7;
        private TextBox textBoxAlanId;
        private Label label6;
        private TextBox textBoxGonderenId;
        private RichTextBox richTextBoxMesaj;
        private Button buttonDersBilgileriGoster;
        private DataGridView dataGridView2;
        private Label label5;
        private Button buttonTalepGeriCek;
        private Button buttonBekleyenTalepGoster;
        private GroupBox groupBox3;
        private Button buttonOnaylananDersler;
        private Button buttonTalepOnayla;
        private DataGridView dataGridView3;
    }
}