using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdminGiris = new Button();
            textBoxKullaniciAdi = new TextBox();
            buttonOgrenciGiris = new Button();
            buttonOgretmenGiris = new Button();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdminGiris
            // 
            buttonAdminGiris.Location = new Point(522, 366);
            buttonAdminGiris.Name = "buttonAdminGiris";
            buttonAdminGiris.Size = new Size(160, 42);
            buttonAdminGiris.TabIndex = 0;
            buttonAdminGiris.Text = "Admin Giriş";
            buttonAdminGiris.UseVisualStyleBackColor = true;
            buttonAdminGiris.Click += buttonAdminGiris_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(356, 230);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(125, 27);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // buttonOgrenciGiris
            // 
            buttonOgrenciGiris.Location = new Point(125, 366);
            buttonOgrenciGiris.Name = "buttonOgrenciGiris";
            buttonOgrenciGiris.Size = new Size(160, 42);
            buttonOgrenciGiris.TabIndex = 2;
            buttonOgrenciGiris.Text = "Öğrenci Giriş";
            buttonOgrenciGiris.UseVisualStyleBackColor = true;
            buttonOgrenciGiris.Click += buttonOgrenciGiris_Click;
            // 
            // buttonOgretmenGiris
            // 
            buttonOgretmenGiris.Location = new Point(321, 366);
            buttonOgretmenGiris.Name = "buttonOgretmenGiris";
            buttonOgretmenGiris.Size = new Size(160, 42);
            buttonOgretmenGiris.TabIndex = 3;
            buttonOgretmenGiris.Text = "Öğretmen Giriş";
            buttonOgretmenGiris.UseVisualStyleBackColor = true;
            buttonOgretmenGiris.Click += buttonOgretmenGiris_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(356, 288);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(125, 27);
            textBoxSifre.TabIndex = 4;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 237);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 291);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 525);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(buttonOgretmenGiris);
            Controls.Add(buttonOgrenciGiris);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(buttonAdminGiris);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdminGiris;
        private TextBox textBoxKullaniciAdi;
        private Button buttonOgrenciGiris;
        private Button buttonOgretmenGiris;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}