
namespace RandevuOtomasyonu
{
    partial class frmIsYeriBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsYeriBul));
            this.lblAra = new System.Windows.Forms.Label();
            this.txtIsYeriBul = new System.Windows.Forms.TextBox();
            this.dgvIsYeriBul = new System.Windows.Forms.DataGridView();
            this.btnIsyeriOnceki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriBul)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(44, 42);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(97, 20);
            this.lblAra.TabIndex = 0;
            this.lblAra.Text = "İş Yeri Bul:";
            // 
            // txtIsYeriBul
            // 
            this.txtIsYeriBul.Location = new System.Drawing.Point(158, 42);
            this.txtIsYeriBul.Name = "txtIsYeriBul";
            this.txtIsYeriBul.Size = new System.Drawing.Size(484, 20);
            this.txtIsYeriBul.TabIndex = 1;
            this.txtIsYeriBul.TextChanged += new System.EventHandler(this.txtIsYeriBul_TextChanged);
            // 
            // dgvIsYeriBul
            // 
            this.dgvIsYeriBul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriBul.Location = new System.Drawing.Point(13, 107);
            this.dgvIsYeriBul.Name = "dgvIsYeriBul";
            this.dgvIsYeriBul.Size = new System.Drawing.Size(775, 322);
            this.dgvIsYeriBul.TabIndex = 2;
            // 
            // btnIsyeriOnceki
            // 
            this.btnIsyeriOnceki.BackColor = System.Drawing.Color.White;
            this.btnIsyeriOnceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIsyeriOnceki.BackgroundImage")));
            this.btnIsyeriOnceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIsyeriOnceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsyeriOnceki.Location = new System.Drawing.Point(705, 33);
            this.btnIsyeriOnceki.Name = "btnIsyeriOnceki";
            this.btnIsyeriOnceki.Size = new System.Drawing.Size(55, 41);
            this.btnIsyeriOnceki.TabIndex = 90;
            this.btnIsyeriOnceki.UseVisualStyleBackColor = false;
            this.btnIsyeriOnceki.Click += new System.EventHandler(this.btnIsyeriOnceki_Click);
            // 
            // frmIsYeriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsyeriOnceki);
            this.Controls.Add(this.dgvIsYeriBul);
            this.Controls.Add(this.txtIsYeriBul);
            this.Controls.Add(this.lblAra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIsYeriBul";
            this.Text = "İş Yeri Bul";
            this.Load += new System.EventHandler(this.frmIsYeriBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriBul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtIsYeriBul;
        private System.Windows.Forms.DataGridView dgvIsYeriBul;
        private System.Windows.Forms.Button btnIsyeriOnceki;
    }
}