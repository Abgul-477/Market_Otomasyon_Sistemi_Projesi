
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class GelirGiderKayitEkleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKisiID = new System.Windows.Forms.ComboBox();
            this.cmbKisiSinif = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtVergi = new System.Windows.Forms.MaskedTextBox();
            this.yildizVergi = new System.Windows.Forms.Label();
            this.yildizKisiID = new System.Windows.Forms.Label();
            this.yildizKisiSinif = new System.Windows.Forms.Label();
            this.yildizTutar = new System.Windows.Forms.Label();
            this.yildizKategori = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.MaskedTextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbKisiID);
            this.panel1.Controls.Add(this.cmbKisiSinif);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.txtVergi);
            this.panel1.Controls.Add(this.yildizVergi);
            this.panel1.Controls.Add(this.yildizKisiID);
            this.panel1.Controls.Add(this.yildizKisiSinif);
            this.panel1.Controls.Add(this.yildizTutar);
            this.panel1.Controls.Add(this.yildizKategori);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 225);
            this.panel1.TabIndex = 0;
            // 
            // cmbKisiID
            // 
            this.cmbKisiID.FormattingEnabled = true;
            this.cmbKisiID.Location = new System.Drawing.Point(144, 115);
            this.cmbKisiID.Name = "cmbKisiID";
            this.cmbKisiID.Size = new System.Drawing.Size(121, 28);
            this.cmbKisiID.TabIndex = 4;
            this.cmbKisiID.Text = "Kişi Seçiniz";
            // 
            // cmbKisiSinif
            // 
            this.cmbKisiSinif.FormattingEnabled = true;
            this.cmbKisiSinif.Location = new System.Drawing.Point(144, 81);
            this.cmbKisiSinif.Name = "cmbKisiSinif";
            this.cmbKisiSinif.Size = new System.Drawing.Size(121, 28);
            this.cmbKisiSinif.TabIndex = 3;
            this.cmbKisiSinif.Text = "Sınıf Seçiniz";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(144, 181);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(121, 26);
            this.dtpTarih.TabIndex = 6;
            // 
            // txtVergi
            // 
            this.txtVergi.Location = new System.Drawing.Point(144, 149);
            this.txtVergi.Mask = "0000000000";
            this.txtVergi.Name = "txtVergi";
            this.txtVergi.Size = new System.Drawing.Size(121, 26);
            this.txtVergi.TabIndex = 5;
            this.txtVergi.ValidatingType = typeof(int);
            // 
            // yildizVergi
            // 
            this.yildizVergi.AutoSize = true;
            this.yildizVergi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizVergi.ForeColor = System.Drawing.Color.Red;
            this.yildizVergi.Location = new System.Drawing.Point(271, 159);
            this.yildizVergi.Name = "yildizVergi";
            this.yildizVergi.Size = new System.Drawing.Size(15, 20);
            this.yildizVergi.TabIndex = 0;
            this.yildizVergi.Text = "*";
            this.yildizVergi.Visible = false;
            // 
            // yildizKisiID
            // 
            this.yildizKisiID.AutoSize = true;
            this.yildizKisiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizKisiID.ForeColor = System.Drawing.Color.Red;
            this.yildizKisiID.Location = new System.Drawing.Point(271, 123);
            this.yildizKisiID.Name = "yildizKisiID";
            this.yildizKisiID.Size = new System.Drawing.Size(15, 20);
            this.yildizKisiID.TabIndex = 0;
            this.yildizKisiID.Text = "*";
            this.yildizKisiID.Visible = false;
            // 
            // yildizKisiSinif
            // 
            this.yildizKisiSinif.AutoSize = true;
            this.yildizKisiSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizKisiSinif.ForeColor = System.Drawing.Color.Red;
            this.yildizKisiSinif.Location = new System.Drawing.Point(271, 89);
            this.yildizKisiSinif.Name = "yildizKisiSinif";
            this.yildizKisiSinif.Size = new System.Drawing.Size(15, 20);
            this.yildizKisiSinif.TabIndex = 0;
            this.yildizKisiSinif.Text = "*";
            this.yildizKisiSinif.Visible = false;
            // 
            // yildizTutar
            // 
            this.yildizTutar.AutoSize = true;
            this.yildizTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizTutar.ForeColor = System.Drawing.Color.Red;
            this.yildizTutar.Location = new System.Drawing.Point(271, 55);
            this.yildizTutar.Name = "yildizTutar";
            this.yildizTutar.Size = new System.Drawing.Size(15, 20);
            this.yildizTutar.TabIndex = 0;
            this.yildizTutar.Text = "*";
            this.yildizTutar.Visible = false;
            // 
            // yildizKategori
            // 
            this.yildizKategori.AutoSize = true;
            this.yildizKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizKategori.ForeColor = System.Drawing.Color.Red;
            this.yildizKategori.Location = new System.Drawing.Point(271, 22);
            this.yildizKategori.Name = "yildizKategori";
            this.yildizKategori.Size = new System.Drawing.Size(15, 20);
            this.yildizKategori.TabIndex = 0;
            this.yildizKategori.Text = "*";
            this.yildizKategori.Visible = false;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(144, 49);
            this.txtMiktar.Mask = "0000000000";
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 26);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.ValidatingType = typeof(int);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(144, 14);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 28);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.Text = "Kategori Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kişi Sınıf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vergi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.accept;
            this.btnKayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayitEkle.Location = new System.Drawing.Point(12, 241);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(294, 46);
            this.btnKayitEkle.TabIndex = 1;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // GelirGiderKayitEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 299);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GelirGiderKayitEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GelirGiderKayitEkleForm";
            this.Load += new System.EventHandler(this.GelirGiderKayitEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.MaskedTextBox txtVergi;
        private System.Windows.Forms.Label yildizVergi;
        private System.Windows.Forms.Label yildizTutar;
        private System.Windows.Forms.Label yildizKategori;
        private System.Windows.Forms.MaskedTextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKisiSinif;
        private System.Windows.Forms.ComboBox cmbKisiID;
        private System.Windows.Forms.Label yildizKisiID;
        private System.Windows.Forms.Label yildizKisiSinif;
        private System.Windows.Forms.Label label6;
    }
}