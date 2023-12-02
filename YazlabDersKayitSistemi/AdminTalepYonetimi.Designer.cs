namespace YazlabDersKayitSistemi
{
    partial class AdminTalepYonetimi
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
            dataGridView1 = new DataGridView();
            dataGridViewOgrenciler = new DataGridView();
            dataGridViewHocalar = new DataGridView();
            textBoxOgrencino = new TextBox();
            textBoxOgrenciAdi = new TextBox();
            textBoxHocaAdi = new TextBox();
            textBoxHocaSicilNo = new TextBox();
            textBoxOgrenciSoyadi = new TextBox();
            textBoxHocaSoyadi = new TextBox();
            buttonEkle = new Button();
            textBoxDersId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(28, 391);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(919, 227);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new System.Drawing.Point(28, 23);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.RowTemplate.Height = 29;
            dataGridViewOgrenciler.Size = new System.Drawing.Size(411, 278);
            dataGridViewOgrenciler.TabIndex = 1;
            dataGridViewOgrenciler.CellDoubleClick += dataGridViewOgrenciler_CellDoubleClick;
            // 
            // dataGridViewHocalar
            // 
            dataGridViewHocalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHocalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocalar.Location = new System.Drawing.Point(522, 23);
            dataGridViewHocalar.Name = "dataGridViewHocalar";
            dataGridViewHocalar.RowHeadersWidth = 51;
            dataGridViewHocalar.RowTemplate.Height = 29;
            dataGridViewHocalar.Size = new System.Drawing.Size(556, 278);
            dataGridViewHocalar.TabIndex = 2;
            dataGridViewHocalar.CellDoubleClick += dataGridViewHocalar_CellDoubleClick;
            // 
            // textBoxOgrencino
            // 
            textBoxOgrencino.Location = new System.Drawing.Point(28, 331);
            textBoxOgrencino.Name = "textBoxOgrencino";
            textBoxOgrencino.Size = new System.Drawing.Size(133, 27);
            textBoxOgrencino.TabIndex = 3;
            // 
            // textBoxOgrenciAdi
            // 
            textBoxOgrenciAdi.Location = new System.Drawing.Point(167, 331);
            textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            textBoxOgrenciAdi.Size = new System.Drawing.Size(133, 27);
            textBoxOgrenciAdi.TabIndex = 4;
            // 
            // textBoxHocaAdi
            // 
            textBoxHocaAdi.Location = new System.Drawing.Point(661, 331);
            textBoxHocaAdi.Name = "textBoxHocaAdi";
            textBoxHocaAdi.Size = new System.Drawing.Size(133, 27);
            textBoxHocaAdi.TabIndex = 6;
            // 
            // textBoxHocaSicilNo
            // 
            textBoxHocaSicilNo.Location = new System.Drawing.Point(522, 331);
            textBoxHocaSicilNo.Name = "textBoxHocaSicilNo";
            textBoxHocaSicilNo.Size = new System.Drawing.Size(133, 27);
            textBoxHocaSicilNo.TabIndex = 5;
            // 
            // textBoxOgrenciSoyadi
            // 
            textBoxOgrenciSoyadi.Location = new System.Drawing.Point(306, 331);
            textBoxOgrenciSoyadi.Name = "textBoxOgrenciSoyadi";
            textBoxOgrenciSoyadi.Size = new System.Drawing.Size(133, 27);
            textBoxOgrenciSoyadi.TabIndex = 7;
            // 
            // textBoxHocaSoyadi
            // 
            textBoxHocaSoyadi.Location = new System.Drawing.Point(800, 331);
            textBoxHocaSoyadi.Name = "textBoxHocaSoyadi";
            textBoxHocaSoyadi.Size = new System.Drawing.Size(133, 27);
            textBoxHocaSoyadi.TabIndex = 8;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new System.Drawing.Point(972, 487);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new System.Drawing.Size(154, 35);
            buttonEkle.TabIndex = 9;
            buttonEkle.Text = "Öğrenciyi Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // textBoxDersId
            // 
            textBoxDersId.Location = new System.Drawing.Point(945, 331);
            textBoxDersId.Name = "textBoxDersId";
            textBoxDersId.Size = new System.Drawing.Size(133, 27);
            textBoxDersId.TabIndex = 10;
            // 
            // AdminTalepYonetimi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1155, 630);
            Controls.Add(textBoxDersId);
            Controls.Add(buttonEkle);
            Controls.Add(textBoxHocaSoyadi);
            Controls.Add(textBoxOgrenciSoyadi);
            Controls.Add(textBoxHocaAdi);
            Controls.Add(textBoxHocaSicilNo);
            Controls.Add(textBoxOgrenciAdi);
            Controls.Add(textBoxOgrencino);
            Controls.Add(dataGridViewHocalar);
            Controls.Add(dataGridViewOgrenciler);
            Controls.Add(dataGridView1);
            Name = "AdminTalepYonetimi";
            Text = "AdminTalepYonetimi";
            Load += AdminTalepYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridViewOgrenciler;
        private DataGridView dataGridViewHocalar;
        private TextBox textBoxOgrencino;
        private TextBox textBoxOgrenciAdi;
        private TextBox textBoxHocaAdi;
        private TextBox textBoxHocaSicilNo;
        private TextBox textBoxOgrenciSoyadi;
        private TextBox textBoxHocaSoyadi;
        private Button buttonEkle;
        private TextBox textBoxDersId;
    }
}