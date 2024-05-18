
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class SiparisDuzenleForm
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
            this.radUlasmadi = new System.Windows.Forms.RadioButton();
            this.radUlasti = new System.Windows.Forms.RadioButton();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.txtOlusturmaTar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.MaskedTextBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.dtpUlasmaTar = new System.Windows.Forms.DateTimePicker();
            this.dtpBekTar = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yildizAciklama = new System.Windows.Forms.Label();
            this.yildizBekTar = new System.Windows.Forms.Label();
            this.yildizBirim = new System.Windows.Forms.Label();
            this.yildizUrun = new System.Windows.Forms.Label();
            this.yildizTedarikci = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radUlasmadi);
            this.panel1.Controls.Add(this.radUlasti);
            this.panel1.Controls.Add(this.txtSiparisID);
            this.panel1.Controls.Add(this.txtOlusturmaTar);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.cmbTedarikci);
            this.panel1.Controls.Add(this.cmbUrun);
            this.panel1.Controls.Add(this.dtpUlasmaTar);
            this.panel1.Controls.Add(this.dtpBekTar);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yildizAciklama);
            this.panel1.Controls.Add(this.yildizBekTar);
            this.panel1.Controls.Add(this.yildizBirim);
            this.panel1.Controls.Add(this.yildizUrun);
            this.panel1.Controls.Add(this.yildizTedarikci);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 362);
            this.panel1.TabIndex = 1;
            // 
            // radUlasmadi
            // 
            this.radUlasmadi.AutoSize = true;
            this.radUlasmadi.Enabled = false;
            this.radUlasmadi.Location = new System.Drawing.Point(167, 208);
            this.radUlasmadi.Name = "radUlasmadi";
            this.radUlasmadi.Size = new System.Drawing.Size(93, 24);
            this.radUlasmadi.TabIndex = 5;
            this.radUlasmadi.TabStop = true;
            this.radUlasmadi.Text = "Ulasmadi";
            this.radUlasmadi.UseVisualStyleBackColor = true;
            // 
            // radUlasti
            // 
            this.radUlasti.AutoSize = true;
            this.radUlasti.Enabled = false;
            this.radUlasti.Location = new System.Drawing.Point(266, 208);
            this.radUlasti.Name = "radUlasti";
            this.radUlasti.Size = new System.Drawing.Size(67, 24);
            this.radUlasti.TabIndex = 6;
            this.radUlasti.TabStop = true;
            this.radUlasti.Text = "Ulasti";
            this.radUlasti.UseVisualStyleBackColor = true;
            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Enabled = false;
            this.txtSiparisID.Location = new System.Drawing.Point(167, 10);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.Size = new System.Drawing.Size(91, 26);
            this.txtSiparisID.TabIndex = 0;
            // 
            // txtOlusturmaTar
            // 
            this.txtOlusturmaTar.Enabled = false;
            this.txtOlusturmaTar.Location = new System.Drawing.Point(167, 144);
            this.txtOlusturmaTar.Name = "txtOlusturmaTar";
            this.txtOlusturmaTar.Size = new System.Drawing.Size(139, 26);
            this.txtOlusturmaTar.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(167, 110);
            this.txtMiktar.Mask = "000000000";
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(91, 26);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.ValidatingType = typeof(int);
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Items.AddRange(new object[] {
            "AS Market",
            "Balaban Tarim Ürünleri",
            "Haydar Süt Ürünleri",
            "Civelek Unlu Mamulleri",
            "Bacanak Unlu Mamulleri",
            "Bizim Toptanci",
            "DemirciToptan",
            "KralToptanci",
            "Kardesler Toptan",
            "Zarafet Toptan"});
            this.cmbTedarikci.Location = new System.Drawing.Point(167, 42);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(142, 28);
            this.cmbTedarikci.TabIndex = 0;
            this.cmbTedarikci.Text = "Tedarikçi Seçiniz";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Items.AddRange(new object[] {
            "Elma",
            "Süt",
            "Ekmek",
            "Marul",
            "Kavun",
            "Margarin",
            "PaketliBulgur",
            "Havuç",
            "Etli Haram Gurme",
            "Makarna",
            "Çikolatalı Gofret"});
            this.cmbUrun.Location = new System.Drawing.Point(167, 76);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 28);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.Text = "Ürün Seçiniz";
            // 
            // dtpUlasmaTar
            // 
            this.dtpUlasmaTar.Enabled = false;
            this.dtpUlasmaTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUlasmaTar.Location = new System.Drawing.Point(167, 238);
            this.dtpUlasmaTar.Name = "dtpUlasmaTar";
            this.dtpUlasmaTar.Size = new System.Drawing.Size(139, 26);
            this.dtpUlasmaTar.TabIndex = 7;
            this.dtpUlasmaTar.Visible = false;
            // 
            // dtpBekTar
            // 
            this.dtpBekTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBekTar.Location = new System.Drawing.Point(167, 176);
            this.dtpBekTar.Name = "dtpBekTar";
            this.dtpBekTar.Size = new System.Drawing.Size(139, 26);
            this.dtpBekTar.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(167, 270);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(196, 65);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "SiparisID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Oluşturma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ulaşma Tarihi";
            this.label8.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Beklenilen Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Urun";
            // 
            // yildizAciklama
            // 
            this.yildizAciklama.AutoSize = true;
            this.yildizAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizAciklama.ForeColor = System.Drawing.Color.Red;
            this.yildizAciklama.Location = new System.Drawing.Point(369, 273);
            this.yildizAciklama.Name = "yildizAciklama";
            this.yildizAciklama.Size = new System.Drawing.Size(15, 20);
            this.yildizAciklama.TabIndex = 0;
            this.yildizAciklama.Text = "*";
            this.yildizAciklama.Visible = false;
            // 
            // yildizBekTar
            // 
            this.yildizBekTar.AutoSize = true;
            this.yildizBekTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizBekTar.ForeColor = System.Drawing.Color.Red;
            this.yildizBekTar.Location = new System.Drawing.Point(312, 182);
            this.yildizBekTar.Name = "yildizBekTar";
            this.yildizBekTar.Size = new System.Drawing.Size(15, 20);
            this.yildizBekTar.TabIndex = 0;
            this.yildizBekTar.Text = "*";
            this.yildizBekTar.Visible = false;
            // 
            // yildizBirim
            // 
            this.yildizBirim.AutoSize = true;
            this.yildizBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizBirim.ForeColor = System.Drawing.Color.Red;
            this.yildizBirim.Location = new System.Drawing.Point(264, 116);
            this.yildizBirim.Name = "yildizBirim";
            this.yildizBirim.Size = new System.Drawing.Size(15, 20);
            this.yildizBirim.TabIndex = 0;
            this.yildizBirim.Text = "*";
            this.yildizBirim.Visible = false;
            // 
            // yildizUrun
            // 
            this.yildizUrun.AutoSize = true;
            this.yildizUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizUrun.ForeColor = System.Drawing.Color.Red;
            this.yildizUrun.Location = new System.Drawing.Point(294, 84);
            this.yildizUrun.Name = "yildizUrun";
            this.yildizUrun.Size = new System.Drawing.Size(15, 20);
            this.yildizUrun.TabIndex = 0;
            this.yildizUrun.Text = "*";
            this.yildizUrun.Visible = false;
            // 
            // yildizTedarikci
            // 
            this.yildizTedarikci.AutoSize = true;
            this.yildizTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizTedarikci.ForeColor = System.Drawing.Color.Red;
            this.yildizTedarikci.Location = new System.Drawing.Point(315, 50);
            this.yildizTedarikci.Name = "yildizTedarikci";
            this.yildizTedarikci.Size = new System.Drawing.Size(15, 20);
            this.yildizTedarikci.TabIndex = 0;
            this.yildizTedarikci.Text = "*";
            this.yildizTedarikci.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi";
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.accept;
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.Location = new System.Drawing.Point(12, 380);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(393, 42);
            this.btnOnay.TabIndex = 9;
            this.btnOnay.Text = "Değişiklikleri Onayla";
            this.btnOnay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // SiparisDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 434);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiparisDuzenleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yildizAciklama;
        private System.Windows.Forms.Label yildizBekTar;
        private System.Windows.Forms.Label yildizBirim;
        private System.Windows.Forms.Label yildizUrun;
        private System.Windows.Forms.Label yildizTedarikci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox txtMiktar;
        public System.Windows.Forms.ComboBox cmbTedarikci;
        public System.Windows.Forms.ComboBox cmbUrun;
        public System.Windows.Forms.DateTimePicker dtpBekTar;
        public System.Windows.Forms.RichTextBox txtAciklama;
        public System.Windows.Forms.RadioButton radUlasmadi;
        public System.Windows.Forms.RadioButton radUlasti;
        public System.Windows.Forms.TextBox txtOlusturmaTar;
        public System.Windows.Forms.DateTimePicker dtpUlasmaTar;
        public System.Windows.Forms.TextBox txtSiparisID;
        private System.Windows.Forms.Label label9;
    }
}