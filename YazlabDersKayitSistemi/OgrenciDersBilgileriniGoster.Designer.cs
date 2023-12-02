namespace YazlabDersKayitSistemi
{
    partial class OgrenciDersBilgileriniGoster
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
            label2 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(179, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(258, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Geçmiş Ders Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(754, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 25);
            label2.TabIndex = 3;
            label2.Text = "Aldığı Dersler";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(576, 103);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new System.Drawing.Size(461, 445);
            dataGridView2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(63, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(469, 445);
            dataGridView1.TabIndex = 1;
            // 
            // OgrenciDersBilgileriniGoster
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1097, 594);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciDersBilgileriniGoster";
            Text = "OgrenciDersBilgileriniGoster";
            Load += OgrenciDersBilgileriniGoster_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}