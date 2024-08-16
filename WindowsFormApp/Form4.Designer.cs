namespace WindowsFormApp
{
    partial class Form4
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
            grpPersonelEkle = new GroupBox();
            btnKayitlariGoruntule = new Button();
            btnKaydet = new Button();
            btnTemizle = new Button();
            txtDOgumYeri = new TextBox();
            txtTCNO = new TextBox();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpPersonelEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonelEkle
            // 
            grpPersonelEkle.Controls.Add(btnKayitlariGoruntule);
            grpPersonelEkle.Controls.Add(btnKaydet);
            grpPersonelEkle.Controls.Add(btnTemizle);
            grpPersonelEkle.Controls.Add(txtDOgumYeri);
            grpPersonelEkle.Controls.Add(txtTCNO);
            grpPersonelEkle.Controls.Add(txtAdSoyad);
            grpPersonelEkle.Controls.Add(label3);
            grpPersonelEkle.Controls.Add(label2);
            grpPersonelEkle.Controls.Add(label1);
            grpPersonelEkle.Location = new Point(12, 12);
            grpPersonelEkle.Name = "grpPersonelEkle";
            grpPersonelEkle.Size = new Size(383, 178);
            grpPersonelEkle.TabIndex = 0;
            grpPersonelEkle.TabStop = false;
            grpPersonelEkle.Text = "PERSONEL BİLGİLERİ";
            // 
            // btnKayitlariGoruntule
            // 
            btnKayitlariGoruntule.Location = new Point(207, 137);
            btnKayitlariGoruntule.Name = "btnKayitlariGoruntule";
            btnKayitlariGoruntule.Size = new Size(153, 23);
            btnKayitlariGoruntule.TabIndex = 8;
            btnKayitlariGoruntule.Text = "Kayıtları Görüntüle";
            btnKayitlariGoruntule.UseVisualStyleBackColor = true;
            btnKayitlariGoruntule.Click += btnKayitlariGoruntule_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(114, 137);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(21, 137);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // txtDOgumYeri
            // 
            txtDOgumYeri.Location = new Point(114, 93);
            txtDOgumYeri.Name = "txtDOgumYeri";
            txtDOgumYeri.Size = new Size(246, 23);
            txtDOgumYeri.TabIndex = 5;
            // 
            // txtTCNO
            // 
            txtTCNO.Location = new Point(114, 59);
            txtTCNO.Name = "txtTCNO";
            txtTCNO.Size = new Size(246, 23);
            txtTCNO.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(114, 25);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(246, 23);
            txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Doğum Yeri : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "TC NO : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad : ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 209);
            Controls.Add(grpPersonelEkle);
            Name = "Form4";
            Text = "Form4";
            grpPersonelEkle.ResumeLayout(false);
            grpPersonelEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonelEkle;
        private TextBox txtDOgumYeri;
        private TextBox txtTCNO;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKayitlariGoruntule;
        private Button btnKaydet;
        private Button btnTemizle;
        public TextBox txtAdSoyad;
    }
}