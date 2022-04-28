
namespace RandevuOtomasyonu
{
    partial class frmIsYeriYetkilisiGiris
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
            this.btnIsYeriYetkilisiGiris = new System.Windows.Forms.Button();
            this.txtIsYeriYetkilisiSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.txtIsYeriKullaniciAd = new System.Windows.Forms.TextBox();
            this.linklblUyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnIsYeriYetkilisiGiris
            // 
            this.btnIsYeriYetkilisiGiris.BackColor = System.Drawing.Color.Goldenrod;
            this.btnIsYeriYetkilisiGiris.Location = new System.Drawing.Point(284, 266);
            this.btnIsYeriYetkilisiGiris.Name = "btnIsYeriYetkilisiGiris";
            this.btnIsYeriYetkilisiGiris.Size = new System.Drawing.Size(116, 53);
            this.btnIsYeriYetkilisiGiris.TabIndex = 56;
            this.btnIsYeriYetkilisiGiris.Text = "Giriş";
            this.btnIsYeriYetkilisiGiris.UseVisualStyleBackColor = false;
            this.btnIsYeriYetkilisiGiris.Click += new System.EventHandler(this.btnIsYeriYetkilisiGiris_Click);
            // 
            // txtIsYeriYetkilisiSifre
            // 
            this.txtIsYeriYetkilisiSifre.Location = new System.Drawing.Point(213, 141);
            this.txtIsYeriYetkilisiSifre.Name = "txtIsYeriYetkilisiSifre";
            this.txtIsYeriYetkilisiSifre.Size = new System.Drawing.Size(176, 20);
            this.txtIsYeriYetkilisiSifre.TabIndex = 55;
            this.txtIsYeriYetkilisiSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(117, 136);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(76, 24);
            this.lblSifre.TabIndex = 53;
            this.lblSifre.Text = "Şifreniz:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(51, 103);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(142, 24);
            this.lblAd.TabIndex = 52;
            this.lblAd.Text = "Kullanıcı Adınız:";
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisBaslik.Location = new System.Drawing.Point(26, 40);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(386, 32);
            this.lblGirisBaslik.TabIndex = 51;
            this.lblGirisBaslik.Text = "İŞ YERİ YETKİLİSİ GİRİŞİ";
            // 
            // txtIsYeriKullaniciAd
            // 
            this.txtIsYeriKullaniciAd.Location = new System.Drawing.Point(213, 107);
            this.txtIsYeriKullaniciAd.Name = "txtIsYeriKullaniciAd";
            this.txtIsYeriKullaniciAd.Size = new System.Drawing.Size(176, 20);
            this.txtIsYeriKullaniciAd.TabIndex = 57;
            // 
            // linklblUyeOl
            // 
            this.linklblUyeOl.AutoSize = true;
            this.linklblUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblUyeOl.LinkColor = System.Drawing.Color.OrangeRed;
            this.linklblUyeOl.Location = new System.Drawing.Point(162, 204);
            this.linklblUyeOl.Name = "linklblUyeOl";
            this.linklblUyeOl.Size = new System.Drawing.Size(210, 24);
            this.linklblUyeOl.TabIndex = 58;
            this.linklblUyeOl.TabStop = true;
            this.linklblUyeOl.Text = "Üye olmak için tıklayınız.";
            this.linklblUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUyeOl_LinkClicked);
            // 
            // frmIsYeriYetkilisiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 331);
            this.Controls.Add(this.linklblUyeOl);
            this.Controls.Add(this.txtIsYeriKullaniciAd);
            this.Controls.Add(this.btnIsYeriYetkilisiGiris);
            this.Controls.Add(this.txtIsYeriYetkilisiSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblGirisBaslik);
            this.Name = "frmIsYeriYetkilisiGiris";
            this.Text = "Is Yeri Yetkilisi Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsYeriYetkilisiGiris;
        private System.Windows.Forms.TextBox txtIsYeriYetkilisiSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.TextBox txtIsYeriKullaniciAd;
        private System.Windows.Forms.LinkLabel linklblUyeOl;
    }
}