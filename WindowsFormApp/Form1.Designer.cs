namespace WindowsFormApp
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
            label1 = new Label();
            label2 = new Label();
            txtKUllaniciAdi = new TextBox();
            txtParola = new TextBox();
            chkParolaGoster = new CheckBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Paraola : ";
            // 
            // txtKUllaniciAdi
            // 
            txtKUllaniciAdi.Location = new Point(150, 19);
            txtKUllaniciAdi.Name = "txtKUllaniciAdi";
            txtKUllaniciAdi.Size = new Size(184, 23);
            txtKUllaniciAdi.TabIndex = 2;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(150, 52);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(184, 23);
            txtParola.TabIndex = 3;
            // 
            // chkParolaGoster
            // 
            chkParolaGoster.AutoSize = true;
            chkParolaGoster.Location = new Point(150, 89);
            chkParolaGoster.Name = "chkParolaGoster";
            chkParolaGoster.Size = new Size(105, 19);
            chkParolaGoster.TabIndex = 4;
            chkParolaGoster.Text = "Parolayı Göster";
            chkParolaGoster.UseVisualStyleBackColor = true;
            chkParolaGoster.CheckedChanged += chkParolaGoster_CheckedChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(250, 119);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(75, 42);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 173);
            Controls.Add(btnGirisYap);
            Controls.Add(chkParolaGoster);
            Controls.Add(txtParola);
            Controls.Add(txtKUllaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKUllaniciAdi;
        private TextBox txtParola;
        private CheckBox chkParolaGoster;
        private Button btnGirisYap;
    }
}
