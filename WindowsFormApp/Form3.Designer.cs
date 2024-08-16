namespace WindowsFormApp
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            btnOyunuBaslat = new Button();
            label1 = new Label();
            txtGirilenSayi = new TextBox();
            btnTahminEt = new Button();
            lblBilgi = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblKullaniciMesaj = new Label();
            SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(1, 12);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(373, 38);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "OYUNU BAŞLAT";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 61);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 1;
            label1.Text = "1 - 100 arasında bir sayı giriniz : ";
            // 
            // txtGirilenSayi
            // 
            txtGirilenSayi.Location = new Point(189, 56);
            txtGirilenSayi.Name = "txtGirilenSayi";
            txtGirilenSayi.Size = new Size(185, 23);
            txtGirilenSayi.TabIndex = 2;
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(1, 89);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(373, 31);
            btnTahminEt.TabIndex = 3;
            btnTahminEt.Text = "TAHMİN ET";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Location = new Point(7, 128);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(0, 15);
            lblBilgi.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 168);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(368, 23);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblKullaniciMesaj
            // 
            lblKullaniciMesaj.AutoSize = true;
            lblKullaniciMesaj.Location = new Point(9, 212);
            lblKullaniciMesaj.Name = "lblKullaniciMesaj";
            lblKullaniciMesaj.Size = new Size(0, 15);
            lblKullaniciMesaj.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 241);
            Controls.Add(lblKullaniciMesaj);
            Controls.Add(progressBar1);
            Controls.Add(lblBilgi);
            Controls.Add(btnTahminEt);
            Controls.Add(txtGirilenSayi);
            Controls.Add(label1);
            Controls.Add(btnOyunuBaslat);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOyunuBaslat;
        private Label label1;
        private TextBox txtGirilenSayi;
        private Button btnTahminEt;
        private Label lblBilgi;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblKullaniciMesaj;
    }
}