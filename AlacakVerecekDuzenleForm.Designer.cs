
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class AlacakVerecekDuzenleForm
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
            this.txtKayitID = new System.Windows.Forms.TextBox();
            this.dtpKayitTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonOdemeTarih = new System.Windows.Forms.DateTimePicker();
            this.txtMiktar = new System.Windows.Forms.MaskedTextBox();
            this.cmbA_VKisiSinif = new System.Windows.Forms.ComboBox();
            this.cmbA_VKisiID = new System.Windows.Forms.ComboBox();
            this.cmbKategoriID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yildizKisiID = new System.Windows.Forms.Label();
            this.yildizKisiSinif = new System.Windows.Forms.Label();
            this.yildizSonOdemeTarih = new System.Windows.Forms.Label();
            this.yildizMiktar = new System.Windows.Forms.Label();
            this.yildizKategoriID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtKayitID);
            this.panel1.Controls.Add(this.dtpKayitTarih);
            this.panel1.Controls.Add(this.dtpSonOdemeTarih);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.cmbA_VKisiSinif);
            this.panel1.Controls.Add(this.cmbA_VKisiID);
            this.panel1.Controls.Add(this.cmbKategoriID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.yildizKisiID);
            this.panel1.Controls.Add(this.yildizKisiSinif);
            this.panel1.Controls.Add(this.yildizSonOdemeTarih);
            this.panel1.Controls.Add(this.yildizMiktar);
            this.panel1.Controls.Add(this.yildizKategoriID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 290);
            this.panel1.TabIndex = 1;
            // 
            // txtKayitID
            // 
            this.txtKayitID.Enabled = false;
            this.txtKayitID.Location = new System.Drawing.Point(180, 13);
            this.txtKayitID.Name = "txtKayitID";
            this.txtKayitID.Size = new System.Drawing.Size(100, 26);
            this.txtKayitID.TabIndex = 0;
            // 
            // dtpKayitTarih
            // 
            this.dtpKayitTarih.Enabled = false;
            this.dtpKayitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKayitTarih.Location = new System.Drawing.Point(180, 235);
            this.dtpKayitTarih.Name = "dtpKayitTarih";
            this.dtpKayitTarih.Size = new System.Drawing.Size(121, 26);
            this.dtpKayitTarih.TabIndex = 6;
            // 
            // dtpSonOdemeTarih
            // 
            this.dtpSonOdemeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonOdemeTarih.Location = new System.Drawing.Point(180, 124);
            this.dtpSonOdemeTarih.Name = "dtpSonOdemeTarih";
            this.dtpSonOdemeTarih.Size = new System.Drawing.Size(121, 26);
            this.dtpSonOdemeTarih.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(180, 89);
            this.txtMiktar.Mask = "0000000000";
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 26);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.ValidatingType = typeof(int);
            // 
            // cmbA_VKisiSinif
            // 
            this.cmbA_VKisiSinif.FormattingEnabled = true;
            this.cmbA_VKisiSinif.Items.AddRange(new object[] {
            "Tedarikci",
            "Musteri",
            "Personel",
            "Banka"});
            this.cmbA_VKisiSinif.Location = new System.Drawing.Point(180, 163);
            this.cmbA_VKisiSinif.Name = "cmbA_VKisiSinif";
            this.cmbA_VKisiSinif.Size = new System.Drawing.Size(121, 28);
            this.cmbA_VKisiSinif.TabIndex = 4;
            this.cmbA_VKisiSinif.Text = "Sınıf Seçin";
            // 
            // cmbA_VKisiID
            // 
            this.cmbA_VKisiID.FormattingEnabled = true;
            this.cmbA_VKisiID.Location = new System.Drawing.Point(180, 200);
            this.cmbA_VKisiID.Name = "cmbA_VKisiID";
            this.cmbA_VKisiID.Size = new System.Drawing.Size(121, 28);
            this.cmbA_VKisiID.TabIndex = 5;
            this.cmbA_VKisiID.Text = "Kişi Seçin";
            // 
            // cmbKategoriID
            // 
            this.cmbKategoriID.FormattingEnabled = true;
            this.cmbKategoriID.Location = new System.Drawing.Point(180, 52);
            this.cmbKategoriID.Name = "cmbKategoriID";
            this.cmbKategoriID.Size = new System.Drawing.Size(121, 28);
            this.cmbKategoriID.TabIndex = 1;
            this.cmbKategoriID.Text = "Kategori Seçin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kayıt Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kişi Sınıfı";
            // 
            // yildizKisiID
            // 
            this.yildizKisiID.AutoSize = true;
            this.yildizKisiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizKisiID.ForeColor = System.Drawing.Color.Red;
            this.yildizKisiID.Location = new System.Drawing.Point(307, 208);
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
            this.yildizKisiSinif.Location = new System.Drawing.Point(307, 171);
            this.yildizKisiSinif.Name = "yildizKisiSinif";
            this.yildizKisiSinif.Size = new System.Drawing.Size(15, 20);
            this.yildizKisiSinif.TabIndex = 0;
            this.yildizKisiSinif.Text = "*";
            this.yildizKisiSinif.Visible = false;
            // 
            // yildizSonOdemeTarih
            // 
            this.yildizSonOdemeTarih.AutoSize = true;
            this.yildizSonOdemeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizSonOdemeTarih.ForeColor = System.Drawing.Color.Red;
            this.yildizSonOdemeTarih.Location = new System.Drawing.Point(307, 130);
            this.yildizSonOdemeTarih.Name = "yildizSonOdemeTarih";
            this.yildizSonOdemeTarih.Size = new System.Drawing.Size(15, 20);
            this.yildizSonOdemeTarih.TabIndex = 0;
            this.yildizSonOdemeTarih.Text = "*";
            this.yildizSonOdemeTarih.Visible = false;
            // 
            // yildizMiktar
            // 
            this.yildizMiktar.AutoSize = true;
            this.yildizMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizMiktar.ForeColor = System.Drawing.Color.Red;
            this.yildizMiktar.Location = new System.Drawing.Point(307, 95);
            this.yildizMiktar.Name = "yildizMiktar";
            this.yildizMiktar.Size = new System.Drawing.Size(15, 20);
            this.yildizMiktar.TabIndex = 0;
            this.yildizMiktar.Text = "*";
            this.yildizMiktar.Visible = false;
            // 
            // yildizKategoriID
            // 
            this.yildizKategoriID.AutoSize = true;
            this.yildizKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizKategoriID.ForeColor = System.Drawing.Color.Red;
            this.yildizKategoriID.Location = new System.Drawing.Point(307, 60);
            this.yildizKategoriID.Name = "yildizKategoriID";
            this.yildizKategoriID.Size = new System.Drawing.Size(15, 20);
            this.yildizKategoriID.TabIndex = 0;
            this.yildizKategoriID.Text = "*";
            this.yildizKategoriID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Son Ödeme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÖdenecekTutar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "KayitID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.accept;
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegistir.Location = new System.Drawing.Point(12, 308);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(341, 51);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "Değişiklikleri Onayla";
            this.btnDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // AlacakVerecekDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 367);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlacakVerecekDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlacakVerecekDuzenleForm";
            this.Load += new System.EventHandler(this.AlacakVerecekDuzenleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label yildizKisiID;
        private System.Windows.Forms.Label yildizKisiSinif;
        private System.Windows.Forms.Label yildizSonOdemeTarih;
        private System.Windows.Forms.Label yildizMiktar;
        private System.Windows.Forms.Label yildizKategoriID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDegistir;
        public System.Windows.Forms.DateTimePicker dtpKayitTarih;
        public System.Windows.Forms.DateTimePicker dtpSonOdemeTarih;
        public System.Windows.Forms.MaskedTextBox txtMiktar;
        public System.Windows.Forms.ComboBox cmbA_VKisiSinif;
        public System.Windows.Forms.ComboBox cmbA_VKisiID;
        public System.Windows.Forms.ComboBox cmbKategoriID;
        public System.Windows.Forms.TextBox txtKayitID;
    }
}