using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuOtomasyonu
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
        }

        private void btnNormalKullaniciGiris_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciGiris fr = new frmNormalKullaniciGiris();
            fr.Show();
            this.Hide();
        }

        private void btnGenelAdminGiris_Click(object sender, EventArgs e)
        {
            frmGenelAdminGiris fr = new frmGenelAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void btnIsyeriYetkilisiGiris_Click(object sender, EventArgs e)
        {
            frmIsYeriYetkilisiGiris fr = new frmIsYeriYetkilisiGiris();
            fr.Show();
            this.Hide();
        }
    }
}
