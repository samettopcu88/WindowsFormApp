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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 frm;
        /// <summary>
        /// Kullanıcı Adını alır ve form üzerinde gösterir
        /// </summary>
        /// <param name="kullaniciAdi">string kullanıcı adı</param>
        public void KullaniciAdiYaz(string kullaniciAdi)
        {
            lblKullaniciAdi.Text = "Hoşgeldiniz, " + kullaniciAdi;
        }

        /// <summary>
        /// Kullanıcı adı alır ve form gösteriri. Çağırıldığı formun bilgisinde taşır
        /// </summary>
        /// <param name="kullaniciAdi">string kullanıcı adı</param>
        /// <param name="gelenForm">Form1 türünde form değişkeni</param>
        public void KullaniciAdiYaz(string kullaniciAdi, Form1 gelenForm)
        {
            lblKullaniciAdi.Text = "Hoşgeldiniz, " + kullaniciAdi;
            frm = gelenForm;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            frm.Show();
            frm.ClearForm();
            //Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
