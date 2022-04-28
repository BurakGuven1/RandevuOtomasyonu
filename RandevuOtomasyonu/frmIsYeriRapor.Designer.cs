
namespace RandevuOtomasyonu
{
    partial class frmIsYeriRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsYeriRapor));
            this.dgvIsyeriRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsyeriRapor
            // 
            this.dgvIsyeriRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsyeriRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsyeriRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvIsyeriRapor.Name = "dgvIsyeriRapor";
            this.dgvIsyeriRapor.Size = new System.Drawing.Size(800, 450);
            this.dgvIsyeriRapor.TabIndex = 0;
            // 
            // frmIsYeriRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIsyeriRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIsYeriRapor";
            this.Text = "İş Yeri Raporu";
            this.Load += new System.EventHandler(this.frmIsYeriRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsyeriRapor;
    }
}