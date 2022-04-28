
namespace RandevuOtomasyonu
{
    partial class frmKullaniciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciRapor));
            this.dgvKullaniciRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullaniciRapor
            // 
            this.dgvKullaniciRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullaniciRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKullaniciRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvKullaniciRapor.Name = "dgvKullaniciRapor";
            this.dgvKullaniciRapor.Size = new System.Drawing.Size(800, 450);
            this.dgvKullaniciRapor.TabIndex = 0;
            // 
            // frmKullaniciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKullaniciRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKullaniciRapor";
            this.Text = "Kullanıcı Raporu";
            this.Load += new System.EventHandler(this.frmKullaniciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciRapor;
    }
}