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
    public partial class frmIsYeriYetkiliTanımlama : Form
    {
        public frmIsYeriYetkiliTanımlama()
        {
            InitializeComponent();
        }

        IsYeri isYeri = new IsYeri();
        IsYeriYetkilisi isYeriYetkilisi = new IsYeriYetkilisi();
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            IsYeriYetkiliTanimlama isYeriYetkiliTanimlama = new IsYeriYetkiliTanimlama();

            isYeriYetkiliTanimlama.isYeri = isYeri;
            isYeriYetkiliTanimlama.isYeriYetkilisi = isYeriYetkilisi;
            isYeriYetkiliTanimlama.tanımla();

            //IsYerininYetkilisiniGoster();
            //IsYeriGoster();
            //YetkiliGoster();
        }

        private void dgvIsYeri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isYeri.IsYeriId = Convert.ToInt32(dgvIsYeri.CurrentRow.Cells[0].Value);
                txtIsYeriAdi.Text = dgvIsYeri.CurrentRow.Cells[0].Value.ToString() + " ID 'li " + dgvIsYeri.CurrentRow.Cells[1].Value.ToString() + " İsimli İş Yeri ";

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void dgvIsYeriYetkili_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isYeriYetkilisi.YetkiliId = Convert.ToInt32(dgvIsYeriYetkili.CurrentRow.Cells[0].Value);
                txtIsYeriYetkiliAdi.Text = dgvIsYeriYetkili.CurrentRow.Cells[0].Value.ToString() + " ID 'li " + dgvIsYeriYetkili.CurrentRow.Cells[4].Value.ToString() + " İsimli İş Yeri Yetkilisi ";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmIsYeriYetkiliTanımlama_Load(object sender, EventArgs e)
        {
            //isyeri gösterir

            bgl.da = new SqlDataAdapter("Select * from Tbl_IsYeri where YetkiliTanimlamaDurum=0", bgl.baglanti());
            DataTable tablo = new DataTable();
            bgl.da.Fill(tablo);
            dgvIsYeri.DataSource = tablo;
            bgl.baglanti().Close();




            bgl.da = new SqlDataAdapter("Select * from Tbl_IsYeriYetkilileri where IsYeriTanimlamaDurum=0", bgl.baglanti());
            DataTable tablo1 = new DataTable();
            bgl.da.Fill(tablo1);
            dgvIsYeriYetkili.DataSource = tablo1;
            bgl.baglanti().Close();





            bgl.da = new SqlDataAdapter("Select IsyeriAdi As 'Is Yeri Adi',YetkiliAdi as 'Is Yeri Yetkili Ismi' from Tbl_IsYeri I inner join Tbl_IsYeriYetkilileri IY ON I.YetkiliId=IY.YetkiliId where IsYeriTanimlamaDurum=1", bgl.baglanti());
            DataTable tablo2 = new DataTable();
            bgl.da.Fill(tablo2);
            dgvIsYeriYetkiliTanımlama.DataSource = tablo2;
            bgl.baglanti().Close();


        }

    }
    }
   

