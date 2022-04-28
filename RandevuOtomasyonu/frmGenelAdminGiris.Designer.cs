
namespace RandevuOtomasyonu
{
    partial class frmGenelAdminGiris
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
            this.btnGenelAdminGiris = new System.Windows.Forms.Button();
            this.txtGenelAdminSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblGenelAdminAd = new System.Windows.Forms.Label();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.txtGenelAdminKullaniciAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenelAdminGiris
            // 
            this.btnGenelAdminGiris.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGenelAdminGiris.Location = new System.Drawing.Point(268, 195);
            this.btnGenelAdminGiris.Name = "btnGenelAdminGiris";
            this.btnGenelAdminGiris.Size = new System.Drawing.Size(116, 53);
            this.btnGenelAdminGiris.TabIndex = 50;
            this.btnGenelAdminGiris.Text = "Giriş";
            this.btnGenelAdminGiris.UseVisualStyleBackColor = false;
            this.btnGenelAdminGiris.Click += new System.EventHandler(this.btnGenelAdminGiris_Click);
            // 
            // txtGenelAdminSifre
            // 
            this.txtGenelAdminSifre.Location = new System.Drawing.Point(234, 144);
            this.txtGenelAdminSifre.Name = "txtGenelAdminSifre";
            this.txtGenelAdminSifre.Size = new System.Drawing.Size(176, 20);
            this.txtGenelAdminSifre.TabIndex = 49;
            this.txtGenelAdminSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(138, 139);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(76, 24);
            this.lblSifre.TabIndex = 47;
            this.lblSifre.Text = "Şifreniz:";
            // 
            // lblGenelAdminAd
            // 
            this.lblGenelAdminAd.AutoSize = true;
            this.lblGenelAdminAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelAdminAd.Location = new System.Drawing.Point(72, 106);
            this.lblGenelAdminAd.Name = "lblGenelAdminAd";
            this.lblGenelAdminAd.Size = new System.Drawing.Size(142, 24);
            this.lblGenelAdminAd.TabIndex = 46;
            this.lblGenelAdminAd.Text = "Kullanıcı Adınız:";
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisBaslik.Location = new System.Drawing.Point(70, 47);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(331, 32);
            this.lblGirisBaslik.TabIndex = 45;
            this.lblGirisBaslik.Text = "GENEL ADMIN GİRİŞİ";
            // 
            // txtGenelAdminKullaniciAd
            // 
            this.txtGenelAdminKullaniciAd.Location = new System.Drawing.Point(234, 109);
            this.txtGenelAdminKullaniciAd.Name = "txtGenelAdminKullaniciAd";
            this.txtGenelAdminKullaniciAd.Size = new System.Drawing.Size(176, 20);
            this.txtGenelAdminKullaniciAd.TabIndex = 51;
            // 
            // frmGenelAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 337);
            this.Controls.Add(this.txtGenelAdminKullaniciAd);
            this.Controls.Add(this.btnGenelAdminGiris);
            this.Controls.Add(this.txtGenelAdminSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblGenelAdminAd);
            this.Controls.Add(this.lblGirisBaslik);
            this.Name = "frmGenelAdminGiris";
            this.Text = "Genel Admin Giriş";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenelAdminGiris;
        private System.Windows.Forms.TextBox txtGenelAdminSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGenelAdminAd;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.TextBox txtGenelAdminKullaniciAd;
    }
}