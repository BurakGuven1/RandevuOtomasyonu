
namespace RandevuOtomasyonu
{
    partial class frmSoruCevapRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruCevapRapor));
            this.dgvSoruCevap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoruCevap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoruCevap
            // 
            this.dgvSoruCevap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoruCevap.Location = new System.Drawing.Point(-2, 1);
            this.dgvSoruCevap.Name = "dgvSoruCevap";
            this.dgvSoruCevap.Size = new System.Drawing.Size(802, 451);
            this.dgvSoruCevap.TabIndex = 0;
            // 
            // frmSoruCevapRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSoruCevap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoruCevapRapor";
            this.Text = "Soru-Cevap Raporu";
            this.Load += new System.EventHandler(this.frmSoruCevapRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoruCevap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoruCevap;
    }
}