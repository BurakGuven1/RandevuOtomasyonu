using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandevuOtomasyonu
{
    public partial class frmGenelAdminEkrani : Form
    {


        public frmGenelAdminEkrani()
        {
            InitializeComponent();
        }

        public string Kullaniciadi;

        sqlBaglantisi bgl = new sqlBaglantisi();

        

        private void IsYeriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriIslemleri fr = new frmIsYeriIslemleri();
            fr.Show();
            this.Hide();
        }


    }
}
