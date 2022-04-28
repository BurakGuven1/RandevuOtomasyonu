
namespace RandevuOtomasyonu
{
    partial class frmSoruSor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruSor));
            this.cmbxIsYeriSecimi = new System.Windows.Forms.ComboBox();
            this.lblIsyeriSecimi = new System.Windows.Forms.Label();
            this.rtxtbxSoru = new System.Windows.Forms.RichTextBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.btnSoru = new System.Windows.Forms.Button();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxIsYeriSecimi
            // 
            this.cmbxIsYeriSecimi.FormattingEnabled = true;
            this.cmbxIsYeriSecimi.Location = new System.Drawing.Point(181, 102);
            this.cmbxIsYeriSecimi.Name = "cmbxIsYeriSecimi";
            this.cmbxIsYeriSecimi.Size = new System.Drawing.Size(227, 21);
            this.cmbxIsYeriSecimi.TabIndex = 21;
            // 
            // lblIsyeriSecimi
            // 
            this.lblIsyeriSecimi.AutoSize = true;
            this.lblIsyeriSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeriSecimi.Location = new System.Drawing.Point(56, 103);
            this.lblIsyeriSecimi.Name = "lblIsyeriSecimi";
            this.lblIsyeriSecimi.Size = new System.Drawing.Size(104, 16);
            this.lblIsyeriSecimi.TabIndex = 22;
            this.lblIsyeriSecimi.Text = "İş yeri seçiminiz:";
            // 
            // rtxtbxSoru
            // 
            this.rtxtbxSoru.Location = new System.Drawing.Point(171, 151);
            this.rtxtbxSoru.Name = "rtxtbxSoru";
            this.rtxtbxSoru.Size = new System.Drawing.Size(237, 205);
            this.rtxtbxSoru.TabIndex = 23;
            this.rtxtbxSoru.Text = "";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(95, 152);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(59, 16);
            this.lblSoru.TabIndex = 24;
            this.lblSoru.Text = "Sorunuz:";
            // 
            // btnSoru
            // 
            this.btnSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoru.Location = new System.Drawing.Point(262, 378);
            this.btnSoru.Name = "btnSoru";
            this.btnSoru.Size = new System.Drawing.Size(146, 49);
            this.btnSoru.TabIndex = 25;
            this.btnSoru.Text = "GÖNDER";
            this.btnSoru.UseVisualStyleBackColor = true;
            this.btnSoru.Click += new System.EventHandler(this.btnSoru_Click);
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.Location = new System.Drawing.Point(61, 42);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(99, 16);
            this.lblKullaniciAd.TabIndex = 27;
            this.lblKullaniciAd.Text = "Kullanıcı Adınız:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(181, 42);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(212, 20);
            this.txtKullaniciAd.TabIndex = 28;
            // 
            // btnOnceki
            // 
            this.btnOnceki.BackColor = System.Drawing.Color.White;
            this.btnOnceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnceki.BackgroundImage")));
            this.btnOnceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnceki.Location = new System.Drawing.Point(12, 386);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(55, 41);
            this.btnOnceki.TabIndex = 90;
            this.btnOnceki.UseVisualStyleBackColor = false;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // frmSoruSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.lblKullaniciAd);
            this.Controls.Add(this.btnSoru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.rtxtbxSoru);
            this.Controls.Add(this.cmbxIsYeriSecimi);
            this.Controls.Add(this.lblIsyeriSecimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSoruSor";
            this.Text = "frmSoruSor";
            this.Load += new System.EventHandler(this.frmSoruSor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxIsYeriSecimi;
        private System.Windows.Forms.Label lblIsyeriSecimi;
        private System.Windows.Forms.RichTextBox rtxtbxSoru;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Button btnSoru;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Button btnOnceki;
    }
}