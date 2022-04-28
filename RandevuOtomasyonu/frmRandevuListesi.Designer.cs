
namespace RandevuOtomasyonu
{
    partial class frmRandevuListesi
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
            this.dgvRandevuListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevuListesi
            // 
            this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvRandevuListesi.Name = "dgvRandevuListesi";
            this.dgvRandevuListesi.Size = new System.Drawing.Size(635, 361);
            this.dgvRandevuListesi.TabIndex = 0;
            // 
            // frmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.dgvRandevuListesi);
            this.Name = "frmRandevuListesi";
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.frmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevuListesi;
    }
}