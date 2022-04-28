
namespace RandevuOtomasyonu
{
    partial class frmGirisler
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
            this.lblSekreterGirisi = new System.Windows.Forms.Label();
            this.lblIsyeriYetkilisiGirisi = new System.Windows.Forms.Label();
            this.lblNormalKullaniciGiris = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnIsyeriYetkilisiGiris = new System.Windows.Forms.Button();
            this.btnGenelAdminGiris = new System.Windows.Forms.Button();
            this.btnNormalKullaniciGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSekreterGirisi
            // 
            this.lblSekreterGirisi.AutoSize = true;
            this.lblSekreterGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSekreterGirisi.Location = new System.Drawing.Point(506, 323);
            this.lblSekreterGirisi.Name = "lblSekreterGirisi";
            this.lblSekreterGirisi.Size = new System.Drawing.Size(122, 16);
            this.lblSekreterGirisi.TabIndex = 20;
            this.lblSekreterGirisi.Text = "İşyeri Yetkilisi Girişi";
            // 
            // lblIsyeriYetkilisiGirisi
            // 
            this.lblIsyeriYetkilisiGirisi.AutoSize = true;
            this.lblIsyeriYetkilisiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeriYetkilisiGirisi.Location = new System.Drawing.Point(290, 323);
            this.lblIsyeriYetkilisiGirisi.Name = "lblIsyeriYetkilisiGirisi";
            this.lblIsyeriYetkilisiGirisi.Size = new System.Drawing.Size(118, 16);
            this.lblIsyeriYetkilisiGirisi.TabIndex = 19;
            this.lblIsyeriYetkilisiGirisi.Text = "Genel Admin Girişi";
            // 
            // lblNormalKullaniciGiris
            // 
            this.lblNormalKullaniciGiris.AutoSize = true;
            this.lblNormalKullaniciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNormalKullaniciGiris.Location = new System.Drawing.Point(73, 323);
            this.lblNormalKullaniciGiris.Name = "lblNormalKullaniciGiris";
            this.lblNormalKullaniciGiris.Size = new System.Drawing.Size(137, 16);
            this.lblNormalKullaniciGiris.TabIndex = 18;
            this.lblNormalKullaniciGiris.Text = "Normal Kullanici Girişi";
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Location = new System.Drawing.Point(118, 57);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(468, 29);
            this.lblGiris.TabIndex = 17;
            this.lblGiris.Text = "Lütfen yapmak istediğiniz seçimi giriniz";
            // 
            // btnIsyeriYetkilisiGiris
            // 
            this.btnIsyeriYetkilisiGiris.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIsyeriYetkilisiGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIsyeriYetkilisiGiris.Location = new System.Drawing.Point(478, 124);
            this.btnIsyeriYetkilisiGiris.Name = "btnIsyeriYetkilisiGiris";
            this.btnIsyeriYetkilisiGiris.Size = new System.Drawing.Size(169, 172);
            this.btnIsyeriYetkilisiGiris.TabIndex = 16;
            this.btnIsyeriYetkilisiGiris.UseVisualStyleBackColor = false;
            this.btnIsyeriYetkilisiGiris.Click += new System.EventHandler(this.btnIsyeriYetkilisiGiris_Click);
            // 
            // btnGenelAdminGiris
            // 
            this.btnGenelAdminGiris.BackColor = System.Drawing.Color.Orange;
            this.btnGenelAdminGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenelAdminGiris.Location = new System.Drawing.Point(272, 124);
            this.btnGenelAdminGiris.Name = "btnGenelAdminGiris";
            this.btnGenelAdminGiris.Size = new System.Drawing.Size(169, 172);
            this.btnGenelAdminGiris.TabIndex = 15;
            this.btnGenelAdminGiris.UseVisualStyleBackColor = false;
            this.btnGenelAdminGiris.Click += new System.EventHandler(this.btnGenelAdminGiris_Click);
            // 
            // btnNormalKullaniciGiris
            // 
            this.btnNormalKullaniciGiris.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNormalKullaniciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormalKullaniciGiris.Location = new System.Drawing.Point(44, 124);
            this.btnNormalKullaniciGiris.Name = "btnNormalKullaniciGiris";
            this.btnNormalKullaniciGiris.Size = new System.Drawing.Size(197, 172);
            this.btnNormalKullaniciGiris.TabIndex = 14;
            this.btnNormalKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnNormalKullaniciGiris.Click += new System.EventHandler(this.btnNormalKullaniciGiris_Click);
            // 
            // frmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 447);
            this.Controls.Add(this.lblSekreterGirisi);
            this.Controls.Add(this.lblIsyeriYetkilisiGirisi);
            this.Controls.Add(this.lblNormalKullaniciGiris);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnIsyeriYetkilisiGiris);
            this.Controls.Add(this.btnGenelAdminGiris);
            this.Controls.Add(this.btnNormalKullaniciGiris);
            this.Name = "frmGirisler";
            this.Text = "Girişler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSekreterGirisi;
        private System.Windows.Forms.Label lblIsyeriYetkilisiGirisi;
        private System.Windows.Forms.Label lblNormalKullaniciGiris;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnIsyeriYetkilisiGiris;
        private System.Windows.Forms.Button btnGenelAdminGiris;
        private System.Windows.Forms.Button btnNormalKullaniciGiris;
    }
}

