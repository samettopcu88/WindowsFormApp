using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rastgeleSayi;

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 60;
            btnTahminEt.Enabled = false;
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rastgeleSayi = rnd.Next(1, 101);
            progressBar1.Value = progressBar1.Maximum;
            btnTahminEt.Enabled = true;
            lblBilgi.Text = "";
            lblKullaniciMesaj.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--;
            btnTahminEt.Text = "TAHMİN ET (" + progressBar1.Value + ")";

            switch (progressBar1.Value)
            {
                case 50:
                    lblKullaniciMesaj.Text = "Galiba Kaybedeceksimn :)";
                    break;
                case 30:
                    lblKullaniciMesaj.Text = "Sen kaybetmek için yarışıyorsun : )";
                    break;
                case 20:
                    lblKullaniciMesaj.Text = "Bu işi yapamıyorsun bırak :)";
                    ChangeKullaniciMesajLabelStyle();
                    break;
                case 0:
                    lblKullaniciMesaj.Text = "Ne demiştim ben sana :) Tekrar dene ancak yine yapmayacaksın";
                    ChangeKullaniciMesajLabelStyle();
                    timer1.Stop();
                    break;
            }


        }

        private void ChangeKullaniciMesajLabelStyle()
        {
            lblKullaniciMesaj.ForeColor = Color.Red;
            lblKullaniciMesaj.Font = new Font(lblKullaniciMesaj.Font, FontStyle.Bold);
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            try
            {
                sayi = int.Parse(txtGirilenSayi.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            lblBilgi.Text = sayi.ToString();

            if (sayi < rastgeleSayi)
                lblBilgi.Text += " => Küçük sayı girdin !!";
            else if (sayi > rastgeleSayi)
                lblBilgi.Text += "=> Büyük sayı girdin!!";
            else
            {
                lblBilgi.Text = "KAZANDIN";

                int kacSaniyedeBİldi = Math.Abs(progressBar1.Value - 60);

                if (kacSaniyedeBİldi > 50 && kacSaniyedeBİldi <= 60)
                    lblKullaniciMesaj.Text = "Son Saniyede!!!";
                else if(kacSaniyedeBİldi > 40 && kacSaniyedeBİldi <= 50)
                    lblKullaniciMesaj.Text = "Ucundan Yakaldın!!!";
                else if (kacSaniyedeBİldi > 30 && kacSaniyedeBİldi <= 40)
                    lblKullaniciMesaj.Text = "Helal OLsun!!!";
                else if (kacSaniyedeBİldi > 20 && kacSaniyedeBİldi <= 30)
                    lblKullaniciMesaj.Text = "Eh işte!!!";
                else if (kacSaniyedeBİldi > 10 && kacSaniyedeBİldi <= 20)
                    lblKullaniciMesaj.Text = "Gayet iyi!!!";
                else if (kacSaniyedeBİldi > 0 && kacSaniyedeBİldi <= 10)
                    lblKullaniciMesaj.Text = "Süper!!!";

                timer1.Stop();
                btnTahminEt.Enabled = false;
            }

            txtGirilenSayi.Clear();

        }
    }
}
