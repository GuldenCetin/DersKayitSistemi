using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace YazlabDersKayitSistemi
{
    partial class AdminHocaIslemleri
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
            textBoxHocaSicilNo = new TextBox();
            textBoxHocaAdi = new TextBox();
            textBoxHocaSoyadi = new TextBox();
            buttonHocaEkle = new Button();
            buttonHocaListele = new Button();
            buttonHocaGüncelle = new Button();
            buttonHocaSil = new Button();
            dataGridViewHocalar = new DataGridView();
            comboBoxHocayaDersEkle = new ComboBox();
            buttonDersiHocayaEkle = new Button();
            textBoxHocaKontenjan = new TextBox();
            buttonHocaDersiSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).BeginInit();
            SuspendLayout();
            // 
            // textBoxHocaSicilNo
            // 
            textBoxHocaSicilNo.Location = new Point(21, 72);
            textBoxHocaSicilNo.Name = "textBoxHocaSicilNo";
            textBoxHocaSicilNo.ReadOnly = true;
            textBoxHocaSicilNo.Size = new Size(135, 27);
            textBoxHocaSicilNo.TabIndex = 0;
            // 
            // textBoxHocaAdi
            // 
            textBoxHocaAdi.Location = new Point(21, 105);
            textBoxHocaAdi.Name = "textBoxHocaAdi";
            textBoxHocaAdi.Size = new Size(135, 27);
            textBoxHocaAdi.TabIndex = 1;
            // 
            // textBoxHocaSoyadi
            // 
            textBoxHocaSoyadi.Location = new Point(21, 138);
            textBoxHocaSoyadi.Name = "textBoxHocaSoyadi";
            textBoxHocaSoyadi.Size = new Size(135, 27);
            textBoxHocaSoyadi.TabIndex = 2;
            // 
            // buttonHocaEkle
            // 
            buttonHocaEkle.Location = new Point(289, 66);
            buttonHocaEkle.Name = "buttonHocaEkle";
            buttonHocaEkle.Size = new Size(126, 31);
            buttonHocaEkle.TabIndex = 3;
            buttonHocaEkle.Text = "Hoca Ekle";
            buttonHocaEkle.UseVisualStyleBackColor = true;
            buttonHocaEkle.Click += buttonHocaEkle_Click;
            // 
            // buttonHocaListele
            // 
            buttonHocaListele.Location = new Point(289, 103);
            buttonHocaListele.Name = "buttonHocaListele";
            buttonHocaListele.Size = new Size(126, 31);
            buttonHocaListele.TabIndex = 4;
            buttonHocaListele.Text = "Hoca Listele";
            buttonHocaListele.UseVisualStyleBackColor = true;
            buttonHocaListele.Click += buttonHocaListele_Click;
            // 
            // buttonHocaGüncelle
            // 
            buttonHocaGüncelle.Location = new Point(289, 140);
            buttonHocaGüncelle.Name = "buttonHocaGüncelle";
            buttonHocaGüncelle.Size = new Size(126, 31);
            buttonHocaGüncelle.TabIndex = 5;
            buttonHocaGüncelle.Text = "Hoca Güncelle";
            buttonHocaGüncelle.UseVisualStyleBackColor = true;
            buttonHocaGüncelle.Click += buttonHocaGüncelle_Click;
            // 
            // buttonHocaSil
            // 
            buttonHocaSil.Location = new Point(289, 177);
            buttonHocaSil.Name = "buttonHocaSil";
            buttonHocaSil.Size = new Size(126, 31);
            buttonHocaSil.TabIndex = 6;
            buttonHocaSil.Text = "Hoca Sil";
            buttonHocaSil.UseVisualStyleBackColor = true;
            buttonHocaSil.Click += buttonHocaSil_Click;
            // 
            // dataGridViewHocalar
            // 
            dataGridViewHocalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHocalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocalar.Location = new Point(12, 265);
            dataGridViewHocalar.Name = "dataGridViewHocalar";
            dataGridViewHocalar.RowHeadersWidth = 51;
            dataGridViewHocalar.RowTemplate.Height = 29;
            dataGridViewHocalar.Size = new Size(652, 182);
            dataGridViewHocalar.TabIndex = 7;
            dataGridViewHocalar.CellDoubleClick += dataGridViewHocalar_CellDoubleClick;
            // 
            // comboBoxHocayaDersEkle
            // 
            comboBoxHocayaDersEkle.FormattingEnabled = true;
            comboBoxHocayaDersEkle.Location = new Point(501, 76);
            comboBoxHocayaDersEkle.Name = "comboBoxHocayaDersEkle";
            comboBoxHocayaDersEkle.Size = new Size(151, 28);
            comboBoxHocayaDersEkle.TabIndex = 8;
            // 
            // buttonDersiHocayaEkle
            // 
            buttonDersiHocayaEkle.Location = new Point(501, 115);
            buttonDersiHocayaEkle.Name = "buttonDersiHocayaEkle";
            buttonDersiHocayaEkle.Size = new Size(151, 37);
            buttonDersiHocayaEkle.TabIndex = 9;
            buttonDersiHocayaEkle.Text = "Dersi Hocaya Ekle";
            buttonDersiHocayaEkle.UseVisualStyleBackColor = true;
            buttonDersiHocayaEkle.Click += buttonDersiHocayaEkle_Click;
            // 
            // textBoxHocaKontenjan
            // 
            textBoxHocaKontenjan.Location = new Point(21, 177);
            textBoxHocaKontenjan.Name = "textBoxHocaKontenjan";
            textBoxHocaKontenjan.Size = new Size(135, 27);
            textBoxHocaKontenjan.TabIndex = 10;
            // 
            // buttonHocaDersiSil
            // 
            buttonHocaDersiSil.Location = new Point(501, 167);
            buttonHocaDersiSil.Name = "buttonHocaDersiSil";
            buttonHocaDersiSil.Size = new Size(151, 37);
            buttonHocaDersiSil.TabIndex = 12;
            buttonHocaDersiSil.Text = "Hocanın Dersi Sil";
            buttonHocaDersiSil.UseVisualStyleBackColor = true;
            buttonHocaDersiSil.Click += buttonHocaDersiSil_Click;
            // 
            // AdminHocaIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 489);
            Controls.Add(buttonHocaDersiSil);
            Controls.Add(textBoxHocaKontenjan);
            Controls.Add(buttonDersiHocayaEkle);
            Controls.Add(comboBoxHocayaDersEkle);
            Controls.Add(dataGridViewHocalar);
            Controls.Add(buttonHocaSil);
            Controls.Add(buttonHocaGüncelle);
            Controls.Add(buttonHocaListele);
            Controls.Add(buttonHocaEkle);
            Controls.Add(textBoxHocaSoyadi);
            Controls.Add(textBoxHocaAdi);
            Controls.Add(textBoxHocaSicilNo);
            Name = "AdminHocaIslemleri";
            Text = "AdminHocaIslemleri";
            Load += AdminHocaIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHocaSicilNo;
        private TextBox textBoxHocaAdi;
        private TextBox textBoxHocaSoyadi;
        private Button buttonHocaEkle;
        private Button buttonHocaListele;
        private Button buttonHocaGüncelle;
        private Button buttonHocaSil;
        private DataGridView dataGridViewHocalar;
        private ComboBox comboBoxHocayaDersEkle;
        private Button buttonDersiHocayaEkle;
        private TextBox textBoxHocaKontenjan;
        private Button buttonHocaDersiSil;
    }
}