
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class MaasKayitEkleForm
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
            this.cmbOdemeGunu = new System.Windows.Forms.ComboBox();
            this.radPasif = new System.Windows.Forms.RadioButton();
            this.radAktif = new System.Windows.Forms.RadioButton();
            this.txtIskonto = new System.Windows.Forms.MaskedTextBox();
            this.txtPrim = new System.Windows.Forms.MaskedTextBox();
            this.txtMaasTutar = new System.Windows.Forms.MaskedTextBox();
            this.cmbPersonelID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yildizOdemeGunu = new System.Windows.Forms.Label();
            this.yildizDurum = new System.Windows.Forms.Label();
            this.yildizIskonto = new System.Windows.Forms.Label();
            this.yildizPrim = new System.Windows.Forms.Label();
            this.yildizMaasTutar = new System.Windows.Forms.Label();
            this.yildizPersonelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbOdemeGunu);
            this.panel1.Controls.Add(this.radPasif);
            this.panel1.Controls.Add(this.radAktif);
            this.panel1.Controls.Add(this.txtIskonto);
            this.panel1.Controls.Add(this.txtPrim);
            this.panel1.Controls.Add(this.txtMaasTutar);
            this.panel1.Controls.Add(this.cmbPersonelID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yildizOdemeGunu);
            this.panel1.Controls.Add(this.yildizDurum);
            this.panel1.Controls.Add(this.yildizIskonto);
            this.panel1.Controls.Add(this.yildizPrim);
            this.panel1.Controls.Add(this.yildizMaasTutar);
            this.panel1.Controls.Add(this.yildizPersonelID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 219);
            this.panel1.TabIndex = 0;
            // 
            // cmbOdemeGunu
            // 
            this.cmbOdemeGunu.FormattingEnabled = true;
            this.cmbOdemeGunu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbOdemeGunu.Location = new System.Drawing.Point(143, 174);
            this.cmbOdemeGunu.Name = "cmbOdemeGunu";
            this.cmbOdemeGunu.Size = new System.Drawing.Size(142, 28);
            this.cmbOdemeGunu.TabIndex = 7;
            this.cmbOdemeGunu.Text = "15";
            // 
            // radPasif
            // 
            this.radPasif.AutoSize = true;
            this.radPasif.Location = new System.Drawing.Point(208, 143);
            this.radPasif.Name = "radPasif";
            this.radPasif.Size = new System.Drawing.Size(62, 24);
            this.radPasif.TabIndex = 6;
            this.radPasif.TabStop = true;
            this.radPasif.Text = "Pasif";
            this.radPasif.UseVisualStyleBackColor = true;
            // 
            // radAktif
            // 
            this.radAktif.AutoSize = true;
            this.radAktif.Location = new System.Drawing.Point(143, 143);
            this.radAktif.Name = "radAktif";
            this.radAktif.Size = new System.Drawing.Size(59, 24);
            this.radAktif.TabIndex = 5;
            this.radAktif.TabStop = true;
            this.radAktif.Text = "Aktif";
            this.radAktif.UseVisualStyleBackColor = true;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(143, 110);
            this.txtIskonto.Mask = "0000000000";
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(142, 26);
            this.txtIskonto.TabIndex = 4;
            this.txtIskonto.ValidatingType = typeof(int);
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(143, 78);
            this.txtPrim.Mask = "0000000000";
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(142, 26);
            this.txtPrim.TabIndex = 3;
            this.txtPrim.ValidatingType = typeof(int);
            // 
            // txtMaasTutar
            // 
            this.txtMaasTutar.Location = new System.Drawing.Point(143, 46);
            this.txtMaasTutar.Mask = "0000000000";
            this.txtMaasTutar.Name = "txtMaasTutar";
            this.txtMaasTutar.Size = new System.Drawing.Size(142, 26);
            this.txtMaasTutar.TabIndex = 2;
            this.txtMaasTutar.ValidatingType = typeof(int);
            // 
            // cmbPersonelID
            // 
            this.cmbPersonelID.FormattingEnabled = true;
            this.cmbPersonelID.Location = new System.Drawing.Point(143, 14);
            this.cmbPersonelID.Name = "cmbPersonelID";
            this.cmbPersonelID.Size = new System.Drawing.Size(142, 28);
            this.cmbPersonelID.TabIndex = 1;
            this.cmbPersonelID.Text = "Personel Seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödeme Günü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "İskonto%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prim%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutar";
            // 
            // yildizOdemeGunu
            // 
            this.yildizOdemeGunu.AutoSize = true;
            this.yildizOdemeGunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizOdemeGunu.ForeColor = System.Drawing.Color.Red;
            this.yildizOdemeGunu.Location = new System.Drawing.Point(291, 182);
            this.yildizOdemeGunu.Name = "yildizOdemeGunu";
            this.yildizOdemeGunu.Size = new System.Drawing.Size(15, 20);
            this.yildizOdemeGunu.TabIndex = 0;
            this.yildizOdemeGunu.Text = "*";
            this.yildizOdemeGunu.Visible = false;
            // 
            // yildizDurum
            // 
            this.yildizDurum.AutoSize = true;
            this.yildizDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizDurum.ForeColor = System.Drawing.Color.Red;
            this.yildizDurum.Location = new System.Drawing.Point(291, 145);
            this.yildizDurum.Name = "yildizDurum";
            this.yildizDurum.Size = new System.Drawing.Size(15, 20);
            this.yildizDurum.TabIndex = 0;
            this.yildizDurum.Text = "*";
            this.yildizDurum.Visible = false;
            // 
            // yildizIskonto
            // 
            this.yildizIskonto.AutoSize = true;
            this.yildizIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizIskonto.ForeColor = System.Drawing.Color.Red;
            this.yildizIskonto.Location = new System.Drawing.Point(291, 116);
            this.yildizIskonto.Name = "yildizIskonto";
            this.yildizIskonto.Size = new System.Drawing.Size(15, 20);
            this.yildizIskonto.TabIndex = 0;
            this.yildizIskonto.Text = "*";
            this.yildizIskonto.Visible = false;
            // 
            // yildizPrim
            // 
            this.yildizPrim.AutoSize = true;
            this.yildizPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizPrim.ForeColor = System.Drawing.Color.Red;
            this.yildizPrim.Location = new System.Drawing.Point(291, 84);
            this.yildizPrim.Name = "yildizPrim";
            this.yildizPrim.Size = new System.Drawing.Size(15, 20);
            this.yildizPrim.TabIndex = 0;
            this.yildizPrim.Text = "*";
            this.yildizPrim.Visible = false;
            // 
            // yildizMaasTutar
            // 
            this.yildizMaasTutar.AutoSize = true;
            this.yildizMaasTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizMaasTutar.ForeColor = System.Drawing.Color.Red;
            this.yildizMaasTutar.Location = new System.Drawing.Point(291, 52);
            this.yildizMaasTutar.Name = "yildizMaasTutar";
            this.yildizMaasTutar.Size = new System.Drawing.Size(15, 20);
            this.yildizMaasTutar.TabIndex = 0;
            this.yildizMaasTutar.Text = "*";
            this.yildizMaasTutar.Visible = false;
            // 
            // yildizPersonelID
            // 
            this.yildizPersonelID.AutoSize = true;
            this.yildizPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizPersonelID.ForeColor = System.Drawing.Color.Red;
            this.yildizPersonelID.Location = new System.Drawing.Point(291, 22);
            this.yildizPersonelID.Name = "yildizPersonelID";
            this.yildizPersonelID.Size = new System.Drawing.Size(15, 20);
            this.yildizPersonelID.TabIndex = 0;
            this.yildizPersonelID.Text = "*";
            this.yildizPersonelID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.accept;
            this.btnKayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayitEkle.Location = new System.Drawing.Point(12, 237);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(315, 62);
            this.btnKayitEkle.TabIndex = 8;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // MaasKayitEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 311);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaasKayitEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaasKayitEkleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtMaasTutar;
        private System.Windows.Forms.ComboBox cmbPersonelID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOdemeGunu;
        private System.Windows.Forms.RadioButton radPasif;
        private System.Windows.Forms.RadioButton radAktif;
        private System.Windows.Forms.MaskedTextBox txtIskonto;
        private System.Windows.Forms.MaskedTextBox txtPrim;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Label yildizOdemeGunu;
        private System.Windows.Forms.Label yildizDurum;
        private System.Windows.Forms.Label yildizIskonto;
        private System.Windows.Forms.Label yildizPrim;
        private System.Windows.Forms.Label yildizMaasTutar;
        private System.Windows.Forms.Label yildizPersonelID;
    }
}