namespace YazlabDersKayitSistemi
{
    partial class AdminDersİslemleri
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
            buttonRastgeleAtama = new Button();
            dataGridViewOgrenciler = new DataGridView();
            buttonNotOrtalamasinaGore = new Button();
            buttonHocaGoster = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridViewHocaDersBilgileri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocaDersBilgileri).BeginInit();
            SuspendLayout();
            // 
            // buttonRastgeleAtama
            // 
            buttonRastgeleAtama.Location = new System.Drawing.Point(248, 100);
            buttonRastgeleAtama.Name = "buttonRastgeleAtama";
            buttonRastgeleAtama.Size = new System.Drawing.Size(142, 38);
            buttonRastgeleAtama.TabIndex = 0;
            buttonRastgeleAtama.Text = "Rastgele Atama";
            buttonRastgeleAtama.UseVisualStyleBackColor = true;
            buttonRastgeleAtama.Click += buttonRastgeleAtama_Click;
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new System.Drawing.Point(57, 24);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.RowTemplate.Height = 29;
            dataGridViewOgrenciler.Size = new System.Drawing.Size(16, 21);
            dataGridViewOgrenciler.TabIndex = 1;
            dataGridViewOgrenciler.Visible = false;
            // 
            // buttonNotOrtalamasinaGore
            // 
            buttonNotOrtalamasinaGore.Location = new System.Drawing.Point(997, 87);
            buttonNotOrtalamasinaGore.Name = "buttonNotOrtalamasinaGore";
            buttonNotOrtalamasinaGore.Size = new System.Drawing.Size(198, 38);
            buttonNotOrtalamasinaGore.TabIndex = 3;
            buttonNotOrtalamasinaGore.Text = "Not Ortalamasına Göre Ata";
            buttonNotOrtalamasinaGore.UseVisualStyleBackColor = true;
            buttonNotOrtalamasinaGore.Click += buttonNotOrtalamasinaGore_Click;
            // 
            // buttonHocaGoster
            // 
            buttonHocaGoster.Location = new System.Drawing.Point(749, 87);
            buttonHocaGoster.Name = "buttonHocaGoster";
            buttonHocaGoster.Size = new System.Drawing.Size(198, 35);
            buttonHocaGoster.TabIndex = 7;
            buttonHocaGoster.Text = "Hocaları Göster";
            buttonHocaGoster.UseVisualStyleBackColor = true;
            buttonHocaGoster.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(37, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(570, 335);
            dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(509, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 25);
            label1.TabIndex = 9;
            label1.Text = "YÖNETİCİ DERS İŞLEMLERİ";
            // 
            // dataGridViewHocaDersBilgileri
            // 
            dataGridViewHocaDersBilgileri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHocaDersBilgileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocaDersBilgileri.Location = new System.Drawing.Point(713, 144);
            dataGridViewHocaDersBilgileri.Name = "dataGridViewHocaDersBilgileri";
            dataGridViewHocaDersBilgileri.RowHeadersWidth = 51;
            dataGridViewHocaDersBilgileri.RowTemplate.Height = 29;
            dataGridViewHocaDersBilgileri.Size = new System.Drawing.Size(492, 335);
            dataGridViewHocaDersBilgileri.TabIndex = 2;
            dataGridViewHocaDersBilgileri.CellDoubleClick += dataGridViewHocaDersBilgileri_CellDoubleClick;
            // 
            // AdminDersİslemleri
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1299, 529);
            Controls.Add(dataGridViewHocaDersBilgileri);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonHocaGoster);
            Controls.Add(buttonNotOrtalamasinaGore);
            Controls.Add(dataGridViewOgrenciler);
            Controls.Add(buttonRastgeleAtama);
            Name = "AdminDersİslemleri";
            Text = "AdminDersİslemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocaDersBilgileri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRastgeleAtama;
        private DataGridView dataGridViewOgrenciler;
        private Button buttonNotOrtalamasinaGore;
        private Button buttonHocaGoster;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridViewHocaDersBilgileri;
    }
}