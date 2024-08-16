using System;
using System.CodeDom;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<string> adSoyadList = new List<string>();
        List<string> TCNOList = new List<string>();
        List<string> dogumYeriList = new List<string>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (BosAlanVarMi())
            {
                MessageBox.Show("BOş ALan Bırakmayınız...");
            }
            else
            {
                adSoyadList.Add(txtAdSoyad.Text);
                TCNOList.Add(txtTCNO.Text);
                dogumYeriList.Add(txtDOgumYeri.Text);

                Temizle();
            }
        }

        private bool BosAlanVarMi()
        {
            foreach (Control item in grpPersonelEkle.Controls)
            {

                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;

                    if (txt.Text == "")
                        return true;
                }
            }
            return false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        private void Temizle()
        {
            foreach (Control item in grpPersonelEkle.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
            txtAdSoyad.Focus();
        }
        private void btnKayitlariGoruntule_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.VerileriGonder(adSoyadList, TCNOList, dogumYeriList,this);
            frm.ShowDialog();
            int number = int.Parse(txtAdSoyad.Tag.ToString());

            int index = number - 1;

            txtAdSoyad.Text = adSoyadList[index];
            txtTCNO.Text = TCNOList[index];
            txtDOgumYeri.Text = dogumYeriList[index];
        }
    }
}
