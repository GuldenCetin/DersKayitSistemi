namespace YazlabDersKayitSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdminGiris = new Button();
            textBoxKullaniciAdi = new TextBox();
            buttonOgrenciGirisi = new Button();
            buttonOgretmenGiris = new Button();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonAdminGiris
            // 
            buttonAdminGiris.Location = new Point(519, 250);
            buttonAdminGiris.Name = "buttonAdminGiris";
            buttonAdminGiris.Size = new Size(160, 42);
            buttonAdminGiris.TabIndex = 0;
            buttonAdminGiris.Text = "Admin Giriş";
            buttonAdminGiris.UseVisualStyleBackColor = true;
            buttonAdminGiris.Click += buttonAdminGiris_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(344, 129);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(125, 27);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // buttonOgrenciGirisi
            // 
            buttonOgrenciGirisi.Location = new Point(148, 250);
            buttonOgrenciGirisi.Name = "buttonOgrenciGirisi";
            buttonOgrenciGirisi.Size = new Size(160, 42);
            buttonOgrenciGirisi.TabIndex = 2;
            buttonOgrenciGirisi.Text = "Öğrenci Giriş";
            buttonOgrenciGirisi.UseVisualStyleBackColor = true;
            // 
            // buttonOgretmenGiris
            // 
            buttonOgretmenGiris.Location = new Point(333, 250);
            buttonOgretmenGiris.Name = "buttonOgretmenGiris";
            buttonOgretmenGiris.Size = new Size(160, 42);
            buttonOgretmenGiris.TabIndex = 3;
            buttonOgretmenGiris.Text = "Öğretmen Giriş";
            buttonOgretmenGiris.UseVisualStyleBackColor = true;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(344, 186);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(125, 27);
            textBoxSifre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 136);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 193);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 332);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(buttonOgretmenGiris);
            Controls.Add(buttonOgrenciGirisi);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(buttonAdminGiris);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdminGiris;
        private TextBox textBoxKullaniciAdi;
        private Button buttonOgrenciGirisi;
        private Button buttonOgretmenGiris;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}