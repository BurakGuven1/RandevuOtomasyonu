
namespace RandevuOtomasyonu
{
    partial class frmIsYeriYetkiliTanımlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsYeriYetkiliTanımlama));
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            this.txtIsYeriYetkiliAdi = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.dgvIsYeriYetkiliTanımlama = new System.Windows.Forms.DataGridView();
            this.dgvIsYeriYetkili = new System.Windows.Forms.DataGridView();
            this.dgvIsYeri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliTanımlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.Location = new System.Drawing.Point(15, 165);
            this.txtIsYeriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(315, 20);
            this.txtIsYeriAdi.TabIndex = 11;
            // 
            // txtIsYeriYetkiliAdi
            // 
            this.txtIsYeriYetkiliAdi.Location = new System.Drawing.Point(354, 165);
            this.txtIsYeriYetkiliAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsYeriYetkiliAdi.Name = "txtIsYeriYetkiliAdi";
            this.txtIsYeriYetkiliAdi.Size = new System.Drawing.Size(331, 20);
            this.txtIsYeriYetkiliAdi.TabIndex = 10;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOnayla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOnayla.Location = new System.Drawing.Point(299, 199);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(104, 52);
            this.btnOnayla.TabIndex = 9;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // dgvIsYeriYetkiliTanımlama
            // 
            this.dgvIsYeriYetkiliTanımlama.AllowUserToAddRows = false;
            this.dgvIsYeriYetkiliTanımlama.AllowUserToDeleteRows = false;
            this.dgvIsYeriYetkiliTanımlama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeriYetkiliTanımlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkiliTanımlama.Location = new System.Drawing.Point(16, 255);
            this.dgvIsYeriYetkiliTanımlama.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIsYeriYetkiliTanımlama.Name = "dgvIsYeriYetkiliTanımlama";
            this.dgvIsYeriYetkiliTanımlama.ReadOnly = true;
            this.dgvIsYeriYetkiliTanımlama.RowTemplate.Height = 24;
            this.dgvIsYeriYetkiliTanımlama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeriYetkiliTanımlama.Size = new System.Drawing.Size(669, 184);
            this.dgvIsYeriYetkiliTanımlama.TabIndex = 8;
            // 
            // dgvIsYeriYetkili
            // 
            this.dgvIsYeriYetkili.AllowUserToAddRows = false;
            this.dgvIsYeriYetkili.AllowUserToDeleteRows = false;
            this.dgvIsYeriYetkili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeriYetkili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkili.Location = new System.Drawing.Point(355, 23);
            this.dgvIsYeriYetkili.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIsYeriYetkili.Name = "dgvIsYeriYetkili";
            this.dgvIsYeriYetkili.ReadOnly = true;
            this.dgvIsYeriYetkili.RowTemplate.Height = 24;
            this.dgvIsYeriYetkili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeriYetkili.Size = new System.Drawing.Size(330, 122);
            this.dgvIsYeriYetkili.TabIndex = 7;
            this.dgvIsYeriYetkili.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriYetkili_CellEnter);
            // 
            // dgvIsYeri
            // 
            this.dgvIsYeri.AllowUserToAddRows = false;
            this.dgvIsYeri.AllowUserToDeleteRows = false;
            this.dgvIsYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeri.Location = new System.Drawing.Point(16, 23);
            this.dgvIsYeri.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIsYeri.Name = "dgvIsYeri";
            this.dgvIsYeri.ReadOnly = true;
            this.dgvIsYeri.RowTemplate.Height = 24;
            this.dgvIsYeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeri.Size = new System.Drawing.Size(314, 122);
            this.dgvIsYeri.TabIndex = 6;
            this.dgvIsYeri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeri_CellEnter);
            // 
            // frmIsYeriYetkiliTanımlama
            // 
            this.AcceptButton = this.btnOnayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.txtIsYeriYetkiliAdi);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvIsYeriYetkiliTanımlama);
            this.Controls.Add(this.dgvIsYeriYetkili);
            this.Controls.Add(this.dgvIsYeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIsYeriYetkiliTanımlama";
            this.Text = "İş Yeri Yetkili Tanımlama";
            this.Load += new System.EventHandler(this.frmIsYeriYetkiliTanımlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliTanımlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsYeriAdi;
        private System.Windows.Forms.TextBox txtIsYeriYetkiliAdi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.DataGridView dgvIsYeriYetkiliTanımlama;
        private System.Windows.Forms.DataGridView dgvIsYeriYetkili;
        private System.Windows.Forms.DataGridView dgvIsYeri;
    }
}