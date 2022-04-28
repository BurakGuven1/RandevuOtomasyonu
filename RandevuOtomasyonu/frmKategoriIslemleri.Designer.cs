
namespace RandevuOtomasyonu
{
    partial class frmKategoriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriIslemleri));
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.dgvKategoriPaneli = new System.Windows.Forms.DataGridView();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.lblKategoriId = new System.Windows.Forms.Label();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIsyeriOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriPaneli)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(24, 133);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(198, 44);
            this.btnKategoriEkle.TabIndex = 76;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // dgvKategoriPaneli
            // 
            this.dgvKategoriPaneli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriPaneli.Location = new System.Drawing.Point(265, 0);
            this.dgvKategoriPaneli.Name = "dgvKategoriPaneli";
            this.dgvKategoriPaneli.Size = new System.Drawing.Size(486, 335);
            this.dgvKategoriPaneli.TabIndex = 75;
            this.dgvKategoriPaneli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriPaneli_CellClick);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(111, 85);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(129, 20);
            this.txtKategoriAd.TabIndex = 74;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(17, 85);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(88, 18);
            this.lblAd.TabIndex = 73;
            this.lblAd.Text = "Kategori Ad:";
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(111, 47);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(129, 20);
            this.txtKategoriId.TabIndex = 72;
            // 
            // lblKategoriId
            // 
            this.lblKategoriId.AutoSize = true;
            this.lblKategoriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriId.Location = new System.Drawing.Point(21, 49);
            this.lblKategoriId.Name = "lblKategoriId";
            this.lblKategoriId.Size = new System.Drawing.Size(82, 18);
            this.lblKategoriId.TabIndex = 71;
            this.lblKategoriId.Text = "Kategori Id:";
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(24, 264);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(198, 50);
            this.btnKategoriGuncelle.TabIndex = 78;
            this.btnKategoriGuncelle.Text = "Kategori Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(24, 205);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(198, 44);
            this.btnKategoriSil.TabIndex = 79;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(225, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(41, 29);
            this.btnCikis.TabIndex = 92;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnIsyeriOnceki);
            this.panel1.Controls.Add(this.lblKategoriId);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.txtKategoriId);
            this.panel1.Controls.Add(this.btnKategoriSil);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.btnKategoriGuncelle);
            this.panel1.Controls.Add(this.txtKategoriAd);
            this.panel1.Controls.Add(this.btnKategoriEkle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 335);
            this.panel1.TabIndex = 93;
            // 
            // btnIsyeriOnceki
            // 
            this.btnIsyeriOnceki.BackColor = System.Drawing.Color.White;
            this.btnIsyeriOnceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIsyeriOnceki.BackgroundImage")));
            this.btnIsyeriOnceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIsyeriOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsyeriOnceki.Location = new System.Drawing.Point(12, 3);
            this.btnIsyeriOnceki.Name = "btnIsyeriOnceki";
            this.btnIsyeriOnceki.Size = new System.Drawing.Size(49, 32);
            this.btnIsyeriOnceki.TabIndex = 93;
            this.btnIsyeriOnceki.UseVisualStyleBackColor = false;
            this.btnIsyeriOnceki.Click += new System.EventHandler(this.btnIsyeriOnceki_Click);
            // 
            // frmKategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKategoriPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKategoriIslemleri";
            this.Text = "Kategori Paneli";
            this.Load += new System.EventHandler(this.frmKategoriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriPaneli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.DataGridView dgvKategoriPaneli;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label lblKategoriId;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIsyeriOnceki;
    }
}