
namespace RandevuOtomasyonu
{
    partial class frmNormalKullaniciGiris
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
            this.linklblUyeOl = new System.Windows.Forms.LinkLabel();
            this.btnNormalKullaniciGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblNormalKullaniciSifre = new System.Windows.Forms.Label();
            this.lblNormalKullaniciAd = new System.Windows.Forms.Label();
            this.lblNormalKullaniciGirisBaslik = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linklblUyeOl
            // 
            this.linklblUyeOl.AutoSize = true;
            this.linklblUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblUyeOl.LinkColor = System.Drawing.Color.OrangeRed;
            this.linklblUyeOl.Location = new System.Drawing.Point(202, 189);
            this.linklblUyeOl.Name = "linklblUyeOl";
            this.linklblUyeOl.Size = new System.Drawing.Size(210, 24);
            this.linklblUyeOl.TabIndex = 44;
            this.linklblUyeOl.TabStop = true;
            this.linklblUyeOl.Text = "Üye olmak için tıklayınız.";
            this.linklblUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUyeOl_LinkClicked);
            // 
            // btnNormalKullaniciGiris
            // 
            this.btnNormalKullaniciGiris.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNormalKullaniciGiris.Location = new System.Drawing.Point(264, 239);
            this.btnNormalKullaniciGiris.Name = "btnNormalKullaniciGiris";
            this.btnNormalKullaniciGiris.Size = new System.Drawing.Size(116, 53);
            this.btnNormalKullaniciGiris.TabIndex = 43;
            this.btnNormalKullaniciGiris.Text = "Giriş";
            this.btnNormalKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnNormalKullaniciGiris.Click += new System.EventHandler(this.btnNormalKullaniciGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(225, 145);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(176, 20);
            this.txtSifre.TabIndex = 42;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblNormalKullaniciSifre
            // 
            this.lblNormalKullaniciSifre.AutoSize = true;
            this.lblNormalKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciSifre.Location = new System.Drawing.Point(129, 140);
            this.lblNormalKullaniciSifre.Name = "lblNormalKullaniciSifre";
            this.lblNormalKullaniciSifre.Size = new System.Drawing.Size(76, 24);
            this.lblNormalKullaniciSifre.TabIndex = 40;
            this.lblNormalKullaniciSifre.Text = "Şifreniz:";
            // 
            // lblNormalKullaniciAd
            // 
            this.lblNormalKullaniciAd.AutoSize = true;
            this.lblNormalKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciAd.Location = new System.Drawing.Point(63, 107);
            this.lblNormalKullaniciAd.Name = "lblNormalKullaniciAd";
            this.lblNormalKullaniciAd.Size = new System.Drawing.Size(142, 24);
            this.lblNormalKullaniciAd.TabIndex = 39;
            this.lblNormalKullaniciAd.Text = "Kullanıcı Adınız:";
            // 
            // lblNormalKullaniciGirisBaslik
            // 
            this.lblNormalKullaniciGirisBaslik.AutoSize = true;
            this.lblNormalKullaniciGirisBaslik.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalKullaniciGirisBaslik.Location = new System.Drawing.Point(12, 28);
            this.lblNormalKullaniciGirisBaslik.Name = "lblNormalKullaniciGirisBaslik";
            this.lblNormalKullaniciGirisBaslik.Size = new System.Drawing.Size(422, 32);
            this.lblNormalKullaniciGirisBaslik.TabIndex = 38;
            this.lblNormalKullaniciGirisBaslik.Text = "NORMAL KULLANICI GİRİŞİ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(225, 112);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(176, 20);
            this.txtKullaniciAdi.TabIndex = 46;
            // 
            // frmNormalKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 344);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.linklblUyeOl);
            this.Controls.Add(this.btnNormalKullaniciGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblNormalKullaniciSifre);
            this.Controls.Add(this.lblNormalKullaniciAd);
            this.Controls.Add(this.lblNormalKullaniciGirisBaslik);
            this.Name = "frmNormalKullaniciGiris";
            this.Text = "Normal Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblUyeOl;
        private System.Windows.Forms.Button btnNormalKullaniciGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblNormalKullaniciSifre;
        private System.Windows.Forms.Label lblNormalKullaniciAd;
        private System.Windows.Forms.Label lblNormalKullaniciGirisBaslik;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}