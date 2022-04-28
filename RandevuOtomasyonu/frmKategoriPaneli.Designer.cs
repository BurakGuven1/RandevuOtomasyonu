
namespace RandevuOtomasyonu
{
    partial class frmKategoriPaneli
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
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.dgvKategoriPaneli = new System.Windows.Forms.DataGridView();
            this.txtKaategoriAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.lblKategoriId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriPaneli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnDoktorGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(73, 168);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(144, 47);
            this.btnDoktorGuncelle.TabIndex = 78;
            this.btnDoktorGuncelle.Text = "Branş Güncelle";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoktorSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorSil.Location = new System.Drawing.Point(155, 118);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(97, 44);
            this.btnDoktorSil.TabIndex = 77;
            this.btnDoktorSil.Text = "Branş Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBransEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransEkle.Location = new System.Drawing.Point(28, 118);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(100, 44);
            this.btnBransEkle.TabIndex = 76;
            this.btnBransEkle.Text = "Branş Ekle";
            this.btnBransEkle.UseVisualStyleBackColor = false;
            // 
            // dgvKategoriPaneli
            // 
            this.dgvKategoriPaneli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriPaneli.Location = new System.Drawing.Point(270, 31);
            this.dgvKategoriPaneli.Name = "dgvKategoriPaneli";
            this.dgvKategoriPaneli.Size = new System.Drawing.Size(474, 294);
            this.dgvKategoriPaneli.TabIndex = 75;
            // 
            // txtKaategoriAd
            // 
            this.txtKaategoriAd.Location = new System.Drawing.Point(97, 64);
            this.txtKaategoriAd.Name = "txtKaategoriAd";
            this.txtKaategoriAd.Size = new System.Drawing.Size(129, 20);
            this.txtKaategoriAd.TabIndex = 74;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(12, 68);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(81, 16);
            this.lblAd.TabIndex = 73;
            this.lblAd.Text = "Kategori Ad:";
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(97, 30);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(129, 20);
            this.txtKategoriId.TabIndex = 72;
            // 
            // lblKategoriId
            // 
            this.lblKategoriId.AutoSize = true;
            this.lblKategoriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriId.Location = new System.Drawing.Point(16, 34);
            this.lblKategoriId.Name = "lblKategoriId";
            this.lblKategoriId.Size = new System.Drawing.Size(75, 16);
            this.lblKategoriId.TabIndex = 71;
            this.lblKategoriId.Text = "Kategori Id:";
            // 
            // frmKategoriPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.btnBransEkle);
            this.Controls.Add(this.dgvKategoriPaneli);
            this.Controls.Add(this.txtKaategoriAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.lblKategoriId);
            this.Name = "frmKategoriPaneli";
            this.Text = "Kategori Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriPaneli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.DataGridView dgvKategoriPaneli;
        private System.Windows.Forms.TextBox txtKaategoriAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label lblKategoriId;
    }
}