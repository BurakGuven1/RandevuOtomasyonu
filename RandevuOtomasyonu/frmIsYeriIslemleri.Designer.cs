
namespace RandevuOtomasyonu
{
    partial class frmIsYeriIslemleri
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
            this.btnIsYeriGuncelle = new System.Windows.Forms.Button();
            this.btnIsYeriSil = new System.Windows.Forms.Button();
            this.btnIsYeriEkle = new System.Windows.Forms.Button();
            this.dgvIsYeri = new System.Windows.Forms.DataGridView();
            this.txtIsyeriAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtIsyeriAdres = new System.Windows.Forms.TextBox();
            this.lblIsyeri = new System.Windows.Forms.Label();
            this.btnKategoriIslemleri = new System.Windows.Forms.Button();
            this.btnIsyeriOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIsYeriGuncelle
            // 
            this.btnIsYeriGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnIsYeriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsYeriGuncelle.Location = new System.Drawing.Point(104, 296);
            this.btnIsYeriGuncelle.Name = "btnIsYeriGuncelle";
            this.btnIsYeriGuncelle.Size = new System.Drawing.Size(144, 47);
            this.btnIsYeriGuncelle.TabIndex = 86;
            this.btnIsYeriGuncelle.Text = "İş Yeri Güncelle";
            this.btnIsYeriGuncelle.UseVisualStyleBackColor = false;
            this.btnIsYeriGuncelle.Click += new System.EventHandler(this.btnIsYeriGuncelle_Click);
            // 
            // btnIsYeriSil
            // 
            this.btnIsYeriSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnIsYeriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsYeriSil.Location = new System.Drawing.Point(172, 231);
            this.btnIsYeriSil.Name = "btnIsYeriSil";
            this.btnIsYeriSil.Size = new System.Drawing.Size(97, 44);
            this.btnIsYeriSil.TabIndex = 85;
            this.btnIsYeriSil.Text = "İş Yeri Sil";
            this.btnIsYeriSil.UseVisualStyleBackColor = false;
            this.btnIsYeriSil.Click += new System.EventHandler(this.btnIsYeriSil_Click);
            // 
            // btnIsYeriEkle
            // 
            this.btnIsYeriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIsYeriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsYeriEkle.Location = new System.Drawing.Point(37, 231);
            this.btnIsYeriEkle.Name = "btnIsYeriEkle";
            this.btnIsYeriEkle.Size = new System.Drawing.Size(100, 44);
            this.btnIsYeriEkle.TabIndex = 84;
            this.btnIsYeriEkle.Text = "İş Yeri Ekle";
            this.btnIsYeriEkle.UseVisualStyleBackColor = false;
            this.btnIsYeriEkle.Click += new System.EventHandler(this.btnIsYeriEkle_Click);
            // 
            // dgvIsYeri
            // 
            this.dgvIsYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeri.Location = new System.Drawing.Point(303, 34);
            this.dgvIsYeri.Name = "dgvIsYeri";
            this.dgvIsYeri.Size = new System.Drawing.Size(474, 294);
            this.dgvIsYeri.TabIndex = 83;
            this.dgvIsYeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeri_CellClick);
            // 
            // txtIsyeriAd
            // 
            this.txtIsyeriAd.Location = new System.Drawing.Point(119, 116);
            this.txtIsyeriAd.Name = "txtIsyeriAd";
            this.txtIsyeriAd.Size = new System.Drawing.Size(129, 20);
            this.txtIsyeriAd.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(34, 116);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(68, 16);
            this.lblAd.TabIndex = 81;
            this.lblAd.Text = "İş Yeri Ad:";
            // 
            // txtIsyeriAdres
            // 
            this.txtIsyeriAdres.Location = new System.Drawing.Point(119, 82);
            this.txtIsyeriAdres.Name = "txtIsyeriAdres";
            this.txtIsyeriAdres.Size = new System.Drawing.Size(129, 20);
            this.txtIsyeriAdres.TabIndex = 1;
            // 
            // lblIsyeri
            // 
            this.lblIsyeri.AutoSize = true;
            this.lblIsyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeri.Location = new System.Drawing.Point(24, 83);
            this.lblIsyeri.Name = "lblIsyeri";
            this.lblIsyeri.Size = new System.Drawing.Size(87, 16);
            this.lblIsyeri.TabIndex = 79;
            this.lblIsyeri.Text = "Is Yeri Adres:";
            // 
            // btnKategoriIslemleri
            // 
            this.btnKategoriIslemleri.BackColor = System.Drawing.Color.Coral;
            this.btnKategoriIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriIslemleri.Location = new System.Drawing.Point(599, 375);
            this.btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            this.btnKategoriIslemleri.Size = new System.Drawing.Size(144, 47);
            this.btnKategoriIslemleri.TabIndex = 87;
            this.btnKategoriIslemleri.Text = "Kategori işlemleri";
            this.btnKategoriIslemleri.UseVisualStyleBackColor = false;
            this.btnKategoriIslemleri.Click += new System.EventHandler(this.btnKategoriIslemleri_Click);
            // 
            // btnIsyeriOnceki
            // 
            this.btnIsyeriOnceki.BackColor = System.Drawing.Color.Brown;
            this.btnIsyeriOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsyeriOnceki.Location = new System.Drawing.Point(27, 409);
            this.btnIsyeriOnceki.Name = "btnIsyeriOnceki";
            this.btnIsyeriOnceki.Size = new System.Drawing.Size(75, 29);
            this.btnIsyeriOnceki.TabIndex = 88;
            this.btnIsyeriOnceki.Text = "<<Onceki";
            this.btnIsyeriOnceki.UseVisualStyleBackColor = false;
            this.btnIsyeriOnceki.Click += new System.EventHandler(this.btnIsyeriOnceki_Click);
            // 
            // frmIsYeriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsyeriOnceki);
            this.Controls.Add(this.btnKategoriIslemleri);
            this.Controls.Add(this.btnIsYeriGuncelle);
            this.Controls.Add(this.btnIsYeriSil);
            this.Controls.Add(this.btnIsYeriEkle);
            this.Controls.Add(this.dgvIsYeri);
            this.Controls.Add(this.txtIsyeriAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtIsyeriAdres);
            this.Controls.Add(this.lblIsyeri);
            this.Name = "frmIsYeriIslemleri";
            this.Text = "Is Yeri Islemleri";
            this.Load += new System.EventHandler(this.frmIsYeriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsYeriGuncelle;
        private System.Windows.Forms.Button btnIsYeriSil;
        private System.Windows.Forms.Button btnIsYeriEkle;
        private System.Windows.Forms.DataGridView dgvIsYeri;
        private System.Windows.Forms.TextBox txtIsyeriAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtIsyeriAdres;
        private System.Windows.Forms.Label lblIsyeri;
        private System.Windows.Forms.Button btnKategoriIslemleri;
        private System.Windows.Forms.Button btnIsyeriOnceki;
    }
}