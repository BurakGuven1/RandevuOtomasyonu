
namespace RandevuOtomasyonu
{
    partial class frmRandevuRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevuRapor));
            this.dgvRandevuRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevuRapor
            // 
            this.dgvRandevuRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevuRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuRapor.Location = new System.Drawing.Point(-3, -3);
            this.dgvRandevuRapor.Name = "dgvRandevuRapor";
            this.dgvRandevuRapor.Size = new System.Drawing.Size(803, 459);
            this.dgvRandevuRapor.TabIndex = 0;
            // 
            // frmRandevuRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.dgvRandevuRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRandevuRapor";
            this.Text = "Randevu Raporu";
            this.Load += new System.EventHandler(this.frmRandevuRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevuRapor;
    }
}