
namespace RandevuOtomasyonu
{
    partial class frmNormalKullaniciEkrani
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
            this.grpbxAktifRandevular = new System.Windows.Forms.GroupBox();
            this.dgvAktifRandevu = new System.Windows.Forms.DataGridView();
            this.grpbxRandevuGecmisi = new System.Windows.Forms.GroupBox();
            this.dgvGecmisRandevu = new System.Windows.Forms.DataGridView();
            this.grpbxRandevuPaneli = new System.Windows.Forms.GroupBox();
            this.txtRandevuId = new System.Windows.Forms.TextBox();
            this.lblRandevuId = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.cmbxDoktorSecimi = new System.Windows.Forms.ComboBox();
            this.lblDoktorSecimi = new System.Windows.Forms.Label();
            this.cmbxIsYeriSecimi = new System.Windows.Forms.ComboBox();
            this.lblIsyeriSecimi = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.rchtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.grpbxKisiBilgi = new System.Windows.Forms.GroupBox();
            this.lnklblBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.lblNormalKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.grpbxAktifRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifRandevu)).BeginInit();
            this.grpbxRandevuGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisRandevu)).BeginInit();
            this.grpbxRandevuPaneli.SuspendLayout();
            this.grpbxKisiBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxAktifRandevular
            // 
            this.grpbxAktifRandevular.Controls.Add(this.dgvAktifRandevu);
            this.grpbxAktifRandevular.Location = new System.Drawing.Point(373, 158);
            this.grpbxAktifRandevular.Name = "grpbxAktifRandevular";
            this.grpbxAktifRandevular.Size = new System.Drawing.Size(411, 316);
            this.grpbxAktifRandevular.TabIndex = 7;
            this.grpbxAktifRandevular.TabStop = false;
            this.grpbxAktifRandevular.Text = "Aktif Randevular";
            // 
            // dgvAktifRandevu
            // 
            this.dgvAktifRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktifRandevu.Location = new System.Drawing.Point(3, 16);
            this.dgvAktifRandevu.Name = "dgvAktifRandevu";
            this.dgvAktifRandevu.Size = new System.Drawing.Size(405, 297);
            this.dgvAktifRandevu.TabIndex = 0;
            // 
            // grpbxRandevuGecmisi
            // 
            this.grpbxRandevuGecmisi.Controls.Add(this.dgvGecmisRandevu);
            this.grpbxRandevuGecmisi.Location = new System.Drawing.Point(367, 22);
            this.grpbxRandevuGecmisi.Name = "grpbxRandevuGecmisi";
            this.grpbxRandevuGecmisi.Size = new System.Drawing.Size(417, 130);
            this.grpbxRandevuGecmisi.TabIndex = 6;
            this.grpbxRandevuGecmisi.TabStop = false;
            this.grpbxRandevuGecmisi.Text = "Randevu Geçmişi";
            // 
            // dgvGecmisRandevu
            // 
            this.dgvGecmisRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGecmisRandevu.Location = new System.Drawing.Point(3, 16);
            this.dgvGecmisRandevu.Name = "dgvGecmisRandevu";
            this.dgvGecmisRandevu.Size = new System.Drawing.Size(411, 111);
            this.dgvGecmisRandevu.TabIndex = 0;
            // 
            // grpbxRandevuPaneli
            // 
            this.grpbxRandevuPaneli.Controls.Add(this.txtRandevuId);
            this.grpbxRandevuPaneli.Controls.Add(this.lblRandevuId);
            this.grpbxRandevuPaneli.Controls.Add(this.lblMesaj);
            this.grpbxRandevuPaneli.Controls.Add(this.cmbxDoktorSecimi);
            this.grpbxRandevuPaneli.Controls.Add(this.lblDoktorSecimi);
            this.grpbxRandevuPaneli.Controls.Add(this.cmbxIsYeriSecimi);
            this.grpbxRandevuPaneli.Controls.Add(this.lblIsyeriSecimi);
            this.grpbxRandevuPaneli.Controls.Add(this.btnRandevuAl);
            this.grpbxRandevuPaneli.Controls.Add(this.rchtxtMesaj);
            this.grpbxRandevuPaneli.Location = new System.Drawing.Point(38, 158);
            this.grpbxRandevuPaneli.Name = "grpbxRandevuPaneli";
            this.grpbxRandevuPaneli.Size = new System.Drawing.Size(323, 316);
            this.grpbxRandevuPaneli.TabIndex = 5;
            this.grpbxRandevuPaneli.TabStop = false;
            this.grpbxRandevuPaneli.Text = "Randevu Paneli";
            // 
            // txtRandevuId
            // 
            this.txtRandevuId.Location = new System.Drawing.Point(127, 36);
            this.txtRandevuId.Name = "txtRandevuId";
            this.txtRandevuId.Size = new System.Drawing.Size(169, 20);
            this.txtRandevuId.TabIndex = 24;
            // 
            // lblRandevuId
            // 
            this.lblRandevuId.AutoSize = true;
            this.lblRandevuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuId.Location = new System.Drawing.Point(17, 40);
            this.lblRandevuId.Name = "lblRandevuId";
            this.lblRandevuId.Size = new System.Drawing.Size(80, 16);
            this.lblRandevuId.TabIndex = 23;
            this.lblRandevuId.Text = "Randevu Id:";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(17, 145);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(236, 16);
            this.lblMesaj.TabIndex = 22;
            this.lblMesaj.Text = "Bize iletmek istediğiniz sorunız var mı ?";
            // 
            // cmbxDoktorSecimi
            // 
            this.cmbxDoktorSecimi.FormattingEnabled = true;
            this.cmbxDoktorSecimi.Location = new System.Drawing.Point(127, 106);
            this.cmbxDoktorSecimi.Name = "cmbxDoktorSecimi";
            this.cmbxDoktorSecimi.Size = new System.Drawing.Size(169, 21);
            this.cmbxDoktorSecimi.TabIndex = 21;
            // 
            // lblDoktorSecimi
            // 
            this.lblDoktorSecimi.AutoSize = true;
            this.lblDoktorSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorSecimi.Location = new System.Drawing.Point(17, 106);
            this.lblDoktorSecimi.Name = "lblDoktorSecimi";
            this.lblDoktorSecimi.Size = new System.Drawing.Size(109, 16);
            this.lblDoktorSecimi.TabIndex = 20;
            this.lblDoktorSecimi.Text = "Doktor seçiminiz:";
            // 
            // cmbxIsYeriSecimi
            // 
            this.cmbxIsYeriSecimi.FormattingEnabled = true;
            this.cmbxIsYeriSecimi.Location = new System.Drawing.Point(127, 69);
            this.cmbxIsYeriSecimi.Name = "cmbxIsYeriSecimi";
            this.cmbxIsYeriSecimi.Size = new System.Drawing.Size(169, 21);
            this.cmbxIsYeriSecimi.TabIndex = 19;
            // 
            // lblIsyeriSecimi
            // 
            this.lblIsyeriSecimi.AutoSize = true;
            this.lblIsyeriSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeriSecimi.Location = new System.Drawing.Point(17, 69);
            this.lblIsyeriSecimi.Name = "lblIsyeriSecimi";
            this.lblIsyeriSecimi.Size = new System.Drawing.Size(104, 16);
            this.lblIsyeriSecimi.TabIndex = 18;
            this.lblIsyeriSecimi.Text = "Branş seçiminiz:";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.Orange;
            this.btnRandevuAl.Location = new System.Drawing.Point(167, 275);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(99, 38);
            this.btnRandevuAl.TabIndex = 1;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            // 
            // rchtxtMesaj
            // 
            this.rchtxtMesaj.Location = new System.Drawing.Point(20, 168);
            this.rchtxtMesaj.Name = "rchtxtMesaj";
            this.rchtxtMesaj.Size = new System.Drawing.Size(276, 101);
            this.rchtxtMesaj.TabIndex = 0;
            this.rchtxtMesaj.Text = "";
            // 
            // grpbxKisiBilgi
            // 
            this.grpbxKisiBilgi.Controls.Add(this.lnklblBilgiDuzenle);
            this.grpbxKisiBilgi.Controls.Add(this.lblNormalKullaniciAdi);
            this.grpbxKisiBilgi.Controls.Add(this.lblKullaniciAd);
            this.grpbxKisiBilgi.Location = new System.Drawing.Point(38, 22);
            this.grpbxKisiBilgi.Name = "grpbxKisiBilgi";
            this.grpbxKisiBilgi.Size = new System.Drawing.Size(323, 130);
            this.grpbxKisiBilgi.TabIndex = 4;
            this.grpbxKisiBilgi.TabStop = false;
            this.grpbxKisiBilgi.Text = "Kişi Bilgi";
            // 
            // lnklblBilgiDuzenle
            // 
            this.lnklblBilgiDuzenle.AutoSize = true;
            this.lnklblBilgiDuzenle.Location = new System.Drawing.Point(52, 73);
            this.lnklblBilgiDuzenle.Name = "lnklblBilgiDuzenle";
            this.lnklblBilgiDuzenle.Size = new System.Drawing.Size(178, 13);
            this.lnklblBilgiDuzenle.TabIndex = 1;
            this.lnklblBilgiDuzenle.TabStop = true;
            this.lnklblBilgiDuzenle.Text = "Bilgilerinizi güncellemek için tıklayınız";
            this.lnklblBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBilgiDuzenle_LinkClicked);
            // 
            // lblNormalKullaniciAdi
            // 
            this.lblNormalKullaniciAdi.AutoSize = true;
            this.lblNormalKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciAdi.Location = new System.Drawing.Point(145, 39);
            this.lblNormalKullaniciAdi.Name = "lblNormalKullaniciAdi";
            this.lblNormalKullaniciAdi.Size = new System.Drawing.Size(85, 16);
            this.lblNormalKullaniciAdi.TabIndex = 25;
            this.lblNormalKullaniciAdi.Text = "00000000000";
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.Location = new System.Drawing.Point(24, 39);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(96, 16);
            this.lblKullaniciAd.TabIndex = 17;
            this.lblKullaniciAd.Text = "Kullanıcı Adınız";
            // 
            // frmNormalKullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.grpbxAktifRandevular);
            this.Controls.Add(this.grpbxRandevuGecmisi);
            this.Controls.Add(this.grpbxRandevuPaneli);
            this.Controls.Add(this.grpbxKisiBilgi);
            this.Name = "frmNormalKullaniciEkrani";
            this.Text = "Normal Kullanıcı Ekrani";
            this.Load += new System.EventHandler(this.frmNormalKullaniciEkrani_Load);
            this.grpbxAktifRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifRandevu)).EndInit();
            this.grpbxRandevuGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisRandevu)).EndInit();
            this.grpbxRandevuPaneli.ResumeLayout(false);
            this.grpbxRandevuPaneli.PerformLayout();
            this.grpbxKisiBilgi.ResumeLayout(false);
            this.grpbxKisiBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxAktifRandevular;
        private System.Windows.Forms.DataGridView dgvAktifRandevu;
        private System.Windows.Forms.GroupBox grpbxRandevuGecmisi;
        private System.Windows.Forms.DataGridView dgvGecmisRandevu;
        private System.Windows.Forms.GroupBox grpbxRandevuPaneli;
        private System.Windows.Forms.TextBox txtRandevuId;
        private System.Windows.Forms.Label lblRandevuId;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ComboBox cmbxDoktorSecimi;
        private System.Windows.Forms.Label lblDoktorSecimi;
        private System.Windows.Forms.ComboBox cmbxIsYeriSecimi;
        private System.Windows.Forms.Label lblIsyeriSecimi;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.RichTextBox rchtxtMesaj;
        private System.Windows.Forms.GroupBox grpbxKisiBilgi;
        private System.Windows.Forms.LinkLabel lnklblBilgiDuzenle;
        private System.Windows.Forms.Label lblNormalKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAd;
    }
}