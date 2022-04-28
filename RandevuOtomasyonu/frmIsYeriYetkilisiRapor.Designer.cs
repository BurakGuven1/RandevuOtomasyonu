
namespace RandevuOtomasyonu
{
    partial class frmIsYeriYetkilisiRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsYeriYetkilisiRapor));
            this.dgvIsYeriYetkilisiRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkilisiRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsYeriYetkilisiRapor
            // 
            this.dgvIsYeriYetkilisiRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeriYetkilisiRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkilisiRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriYetkilisiRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvIsYeriYetkilisiRapor.Name = "dgvIsYeriYetkilisiRapor";
            this.dgvIsYeriYetkilisiRapor.Size = new System.Drawing.Size(800, 450);
            this.dgvIsYeriYetkilisiRapor.TabIndex = 0;
            // 
            // frmIsYeriYetkilisiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIsYeriYetkilisiRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIsYeriYetkilisiRapor";
            this.Text = "İş Yeri Yetkilisi Raporu";
            this.Load += new System.EventHandler(this.frmIsYeriYetkilisiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkilisiRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsYeriYetkilisiRapor;
    }
}