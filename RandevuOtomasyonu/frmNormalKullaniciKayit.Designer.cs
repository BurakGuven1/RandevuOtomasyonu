
namespace RandevuOtomasyonu
{
    partial class frmNormalKullaniciKayit
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
            this.btnNormalKullaniciKayıt = new System.Windows.Forms.Button();
            this.mskdtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtNormalKullaniciAdSoyad = new System.Windows.Forms.TextBox();
            this.lblNormalKullaniciAdSoyad = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblNormalKullaniciSifre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdiniz = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdres = new System.Windows.Forms.Label();
            this.txtKullaniciAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNormalKullaniciKayıt
            // 
            this.btnNormalKullaniciKayıt.BackColor = System.Drawing.Color.Orange;
            this.btnNormalKullaniciKayıt.Location = new System.Drawing.Point(264, 346);
            this.btnNormalKullaniciKayıt.Name = "btnNormalKullaniciKayıt";
            this.btnNormalKullaniciKayıt.Size = new System.Drawing.Size(115, 41);
            this.btnNormalKullaniciKayıt.TabIndex = 45;
            this.btnNormalKullaniciKayıt.Text = "Kayıt Ol";
            this.btnNormalKullaniciKayıt.UseVisualStyleBackColor = false;
            this.btnNormalKullaniciKayıt.Click += new System.EventHandler(this.btnNormalKullaniciKayıt_Click);
            // 
            // mskdtxtTelNo
            // 
            this.mskdtxtTelNo.Location = new System.Drawing.Point(212, 142);
            this.mskdtxtTelNo.Mask = "(999) 000-0000";
            this.mskdtxtTelNo.Name = "mskdtxtTelNo";
            this.mskdtxtTelNo.Size = new System.Drawing.Size(176, 20);
            this.mskdtxtTelNo.TabIndex = 3;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(40, 142);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(146, 20);
            this.lblTelNo.TabIndex = 43;
            this.lblTelNo.Text = "Telefon Numaranız:";
            // 
            // txtNormalKullaniciAdSoyad
            // 
            this.txtNormalKullaniciAdSoyad.Location = new System.Drawing.Point(203, 54);
            this.txtNormalKullaniciAdSoyad.Name = "txtNormalKullaniciAdSoyad";
            this.txtNormalKullaniciAdSoyad.Size = new System.Drawing.Size(176, 20);
            this.txtNormalKullaniciAdSoyad.TabIndex = 1;
            // 
            // lblNormalKullaniciAdSoyad
            // 
            this.lblNormalKullaniciAdSoyad.AutoSize = true;
            this.lblNormalKullaniciAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciAdSoyad.Location = new System.Drawing.Point(42, 54);
            this.lblNormalKullaniciAdSoyad.Name = "lblNormalKullaniciAdSoyad";
            this.lblNormalKullaniciAdSoyad.Size = new System.Drawing.Size(148, 20);
            this.lblNormalKullaniciAdSoyad.TabIndex = 41;
            this.lblNormalKullaniciAdSoyad.Text = "Adınız ve Soyadınız:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(223, 276);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(176, 20);
            this.txtSifre.TabIndex = 6;
            // 
            // lblNormalKullaniciSifre
            // 
            this.lblNormalKullaniciSifre.AutoSize = true;
            this.lblNormalKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciSifre.Location = new System.Drawing.Point(92, 276);
            this.lblNormalKullaniciSifre.Name = "lblNormalKullaniciSifre";
            this.lblNormalKullaniciSifre.Size = new System.Drawing.Size(66, 20);
            this.lblNormalKullaniciSifre.TabIndex = 40;
            this.lblNormalKullaniciSifre.Text = "Şifreniz:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(62, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 20);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "E-mail adresiniz:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblKullaniciAdiniz
            // 
            this.lblKullaniciAdiniz.AutoSize = true;
            this.lblKullaniciAdiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiniz.Location = new System.Drawing.Point(73, 228);
            this.lblKullaniciAdiniz.Name = "lblKullaniciAdiniz";
            this.lblKullaniciAdiniz.Size = new System.Drawing.Size(117, 20);
            this.lblKullaniciAdiniz.TabIndex = 48;
            this.lblKullaniciAdiniz.Text = "Kullanıcı Adınız:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(223, 230);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(176, 20);
            this.txtKullaniciAd.TabIndex = 5;
            // 
            // lblKullaniciAdres
            // 
            this.lblKullaniciAdres.AutoSize = true;
            this.lblKullaniciAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdres.Location = new System.Drawing.Point(80, 186);
            this.lblKullaniciAdres.Name = "lblKullaniciAdres";
            this.lblKullaniciAdres.Size = new System.Drawing.Size(78, 20);
            this.lblKullaniciAdres.TabIndex = 50;
            this.lblKullaniciAdres.Text = "Adresiniz:";
            // 
            // txtKullaniciAdres
            // 
            this.txtKullaniciAdres.Location = new System.Drawing.Point(212, 186);
            this.txtKullaniciAdres.Name = "txtKullaniciAdres";
            this.txtKullaniciAdres.Size = new System.Drawing.Size(176, 20);
            this.txtKullaniciAdres.TabIndex = 4;
            // 
            // frmNormalKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 451);
            this.Controls.Add(this.txtKullaniciAdres);
            this.Controls.Add(this.lblKullaniciAdres);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.lblKullaniciAdiniz);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnNormalKullaniciKayıt);
            this.Controls.Add(this.mskdtxtTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtNormalKullaniciAdSoyad);
            this.Controls.Add(this.lblNormalKullaniciAdSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblNormalKullaniciSifre);
            this.Name = "frmNormalKullaniciKayit";
            this.Text = "Normal Kullanıcı Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalKullaniciKayıt;
        private System.Windows.Forms.MaskedTextBox mskdtxtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtNormalKullaniciAdSoyad;
        private System.Windows.Forms.Label lblNormalKullaniciAdSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblNormalKullaniciSifre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblKullaniciAdiniz;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label lblKullaniciAdres;
        private System.Windows.Forms.TextBox txtKullaniciAdres;
    }
}