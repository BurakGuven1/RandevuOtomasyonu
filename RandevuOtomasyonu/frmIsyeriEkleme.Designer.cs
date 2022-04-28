
namespace RandevuOtomasyonu
{
    partial class frmIsyeriEkleme
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
            this.btnIsYeriEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsYeriKategoriId = new System.Windows.Forms.TextBox();
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            this.txtIsYeriAdres = new System.Windows.Forms.TextBox();
            this.txtIsYeriYetkiliId = new System.Windows.Forms.TextBox();
            this.mskdtxtIsYeriTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtIsYeriKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtIsYeriYetkilisiAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIsYeriEkle
            // 
            this.btnIsYeriEkle.Location = new System.Drawing.Point(243, 378);
            this.btnIsYeriEkle.Name = "btnIsYeriEkle";
            this.btnIsYeriEkle.Size = new System.Drawing.Size(111, 49);
            this.btnIsYeriEkle.TabIndex = 0;
            this.btnIsYeriEkle.Text = "İş yeri ekle";
            this.btnIsYeriEkle.UseVisualStyleBackColor = true;
            this.btnIsYeriEkle.Click += new System.EventHandler(this.btnIsYeriEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is Yeri Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Is Yeri Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Is Yeri Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Is Yeri Yetkili Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Is Yeri Kategori Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Is Yeri Yetkilisi Adı:";
            // 
            // txtIsYeriKategoriId
            // 
            this.txtIsYeriKategoriId.Location = new System.Drawing.Point(189, 76);
            this.txtIsYeriKategoriId.Name = "txtIsYeriKategoriId";
            this.txtIsYeriKategoriId.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriKategoriId.TabIndex = 10;
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.Location = new System.Drawing.Point(189, 120);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriAdi.TabIndex = 11;
            // 
            // txtIsYeriAdres
            // 
            this.txtIsYeriAdres.Location = new System.Drawing.Point(189, 166);
            this.txtIsYeriAdres.Name = "txtIsYeriAdres";
            this.txtIsYeriAdres.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriAdres.TabIndex = 12;
            // 
            // txtIsYeriYetkiliId
            // 
            this.txtIsYeriYetkiliId.Location = new System.Drawing.Point(189, 247);
            this.txtIsYeriYetkiliId.Name = "txtIsYeriYetkiliId";
            this.txtIsYeriYetkiliId.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriYetkiliId.TabIndex = 14;
            // 
            // mskdtxtIsYeriTelNo
            // 
            this.mskdtxtIsYeriTelNo.Location = new System.Drawing.Point(189, 212);
            this.mskdtxtIsYeriTelNo.Mask = "(999) 000-0000";
            this.mskdtxtIsYeriTelNo.Name = "mskdtxtIsYeriTelNo";
            this.mskdtxtIsYeriTelNo.Size = new System.Drawing.Size(128, 20);
            this.mskdtxtIsYeriTelNo.TabIndex = 15;
            // 
            // txtIsYeriKategoriAdi
            // 
            this.txtIsYeriKategoriAdi.Location = new System.Drawing.Point(189, 285);
            this.txtIsYeriKategoriAdi.Name = "txtIsYeriKategoriAdi";
            this.txtIsYeriKategoriAdi.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriKategoriAdi.TabIndex = 16;
            // 
            // txtIsYeriYetkilisiAdi
            // 
            this.txtIsYeriYetkilisiAdi.Location = new System.Drawing.Point(189, 317);
            this.txtIsYeriYetkilisiAdi.Name = "txtIsYeriYetkilisiAdi";
            this.txtIsYeriYetkilisiAdi.Size = new System.Drawing.Size(128, 20);
            this.txtIsYeriYetkilisiAdi.TabIndex = 17;
            // 
            // frmIsyeriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.txtIsYeriYetkilisiAdi);
            this.Controls.Add(this.txtIsYeriKategoriAdi);
            this.Controls.Add(this.mskdtxtIsYeriTelNo);
            this.Controls.Add(this.txtIsYeriYetkiliId);
            this.Controls.Add(this.txtIsYeriAdres);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.txtIsYeriKategoriId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIsYeriEkle);
            this.Name = "frmIsyeriEkleme";
            this.Text = "frmIsyeriEkleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsYeriEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIsYeriKategoriId;
        private System.Windows.Forms.TextBox txtIsYeriAdi;
        private System.Windows.Forms.TextBox txtIsYeriAdres;
        private System.Windows.Forms.TextBox txtIsYeriYetkiliId;
        private System.Windows.Forms.MaskedTextBox mskdtxtIsYeriTelNo;
        private System.Windows.Forms.TextBox txtIsYeriKategoriAdi;
        private System.Windows.Forms.TextBox txtIsYeriYetkilisiAdi;
    }
}