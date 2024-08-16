namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> kullaniciAdlari = new List<string>();
        string parola = "123456";
        private void Form1_Load(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';

            kullaniciAdlari.Add("admin");
            kullaniciAdlari.Add("kullanici");
            kullaniciAdlari.Add("sistemKullanicisi");
            kullaniciAdlari.Add("network");
            kullaniciAdlari.Add("powerUser");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKUllaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                string _kullaniciAdi = txtKUllaniciAdi.Text.Trim();
                string _parola = txtParola.Text.Trim();



                if (kullaniciAdlari.Contains(_kullaniciAdi) && parola == _parola)
                {
                    Form2 frm = new Form2();
                    frm.Show();

                    //this.Close();Form nesnesi bellketen siler, kaldýrýr.
                    this.Hide();//Form1' i gizler 
                    //frm.KullaniciAdiYaz(_kullaniciAdi);
                    frm.KullaniciAdiYaz(_kullaniciAdi, this);

                    //frm.lblKullaniciAdi.Text = "Hoþgeldiniz, " + _kullaniciAdi;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Kullanici Adý veya parola hatalý!!!!", "Uyarý Mesajý",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        txtKUllaniciAdi.Text = "";
                        //txtKUllaniciAdi.Clear();
                        txtParola.Text = "";
                        txtKUllaniciAdi.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Kullanýcý Adý ve Parola Boþ Geçilemez", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void chkParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParolaGoster.Checked)
                txtParola.PasswordChar = default;
            else
                txtParola.PasswordChar = '*';
        }

        public void ClearForm()
        {
            txtKUllaniciAdi.Clear();
            txtParola.Clear();
            txtKUllaniciAdi.Focus();
        }
    }
}
