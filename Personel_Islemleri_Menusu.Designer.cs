
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class Personel_Islemleri_Menusu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayitEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayitSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayitDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbBirimAra = new System.Windows.Forms.ComboBox();
            this.cmbIlAra = new System.Windows.Forms.ComboBox();
            this.txtSoyadAra = new System.Windows.Forms.TextBox();
            this.chkBirim = new System.Windows.Forms.CheckBox();
            this.chkDYeri = new System.Windows.Forms.CheckBox();
            this.chkSoyad = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radSoyad = new System.Windows.Forms.RadioButton();
            this.radTCno = new System.Windows.Forms.RadioButton();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnKayitEkle,
            this.toolStripSeparator1,
            this.btnKayitSil,
            this.toolStripSeparator3,
            this.btnKayitDuzenle,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(83, 497);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.add;
            this.btnKayitEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(80, 35);
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.cross;
            this.btnKayitSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(80, 35);
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.page_white_edit;
            this.btnKayitDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(80, 35);
            this.btnKayitDuzenle.Text = "Kayıt Düzenle";
            this.btnKayitDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(80, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.cmbBirimAra);
            this.groupBox1.Controls.Add(this.cmbIlAra);
            this.groupBox1.Controls.Add(this.txtSoyadAra);
            this.groupBox1.Controls.Add(this.chkBirim);
            this.groupBox1.Controls.Add(this.chkDYeri);
            this.groupBox1.Controls.Add(this.chkSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(640, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.magnifier;
            this.btnAra.Location = new System.Drawing.Point(88, 135);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 28);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbBirimAra
            // 
            this.cmbBirimAra.Enabled = false;
            this.cmbBirimAra.FormattingEnabled = true;
            this.cmbBirimAra.Location = new System.Drawing.Point(115, 87);
            this.cmbBirimAra.Name = "cmbBirimAra";
            this.cmbBirimAra.Size = new System.Drawing.Size(121, 21);
            this.cmbBirimAra.TabIndex = 2;
            // 
            // cmbIlAra
            // 
            this.cmbIlAra.Enabled = false;
            this.cmbIlAra.FormattingEnabled = true;
            this.cmbIlAra.Items.AddRange(new object[] {
            "Kastamonu",
            "Karabük",
            "Zonguldak",
            "İstanbul",
            "Ankara",
            "Bolu",
            "Hatay",
            "Mersin",
            "Adana",
            "Antalya",
            "Sinop",
            "Artvin",
            "Iğdır",
            "Bitlis",
            "Van"});
            this.cmbIlAra.Location = new System.Drawing.Point(115, 60);
            this.cmbIlAra.Name = "cmbIlAra";
            this.cmbIlAra.Size = new System.Drawing.Size(121, 21);
            this.cmbIlAra.TabIndex = 2;
            // 
            // txtSoyadAra
            // 
            this.txtSoyadAra.Enabled = false;
            this.txtSoyadAra.Location = new System.Drawing.Point(115, 34);
            this.txtSoyadAra.Name = "txtSoyadAra";
            this.txtSoyadAra.Size = new System.Drawing.Size(121, 20);
            this.txtSoyadAra.TabIndex = 1;
            // 
            // chkBirim
            // 
            this.chkBirim.AutoSize = true;
            this.chkBirim.Location = new System.Drawing.Point(28, 89);
            this.chkBirim.Name = "chkBirim";
            this.chkBirim.Size = new System.Drawing.Size(48, 17);
            this.chkBirim.TabIndex = 0;
            this.chkBirim.Text = "Birim";
            this.chkBirim.UseVisualStyleBackColor = true;
            this.chkBirim.CheckedChanged += new System.EventHandler(this.chkBirim_CheckedChanged);
            // 
            // chkDYeri
            // 
            this.chkDYeri.AutoSize = true;
            this.chkDYeri.Location = new System.Drawing.Point(28, 62);
            this.chkDYeri.Name = "chkDYeri";
            this.chkDYeri.Size = new System.Drawing.Size(31, 17);
            this.chkDYeri.TabIndex = 0;
            this.chkDYeri.Text = "İl";
            this.chkDYeri.UseVisualStyleBackColor = true;
            this.chkDYeri.CheckedChanged += new System.EventHandler(this.chkDYeri_CheckedChanged);
            // 
            // chkSoyad
            // 
            this.chkSoyad.AutoSize = true;
            this.chkSoyad.Location = new System.Drawing.Point(28, 36);
            this.chkSoyad.Name = "chkSoyad";
            this.chkSoyad.Size = new System.Drawing.Size(56, 17);
            this.chkSoyad.TabIndex = 0;
            this.chkSoyad.Text = "Soyad";
            this.chkSoyad.UseVisualStyleBackColor = true;
            this.chkSoyad.CheckedChanged += new System.EventHandler(this.chkSoyad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Controls.Add(this.lblArananAlan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(640, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(115, 118);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(121, 20);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radSoyad);
            this.groupBox3.Controls.Add(this.radTCno);
            this.groupBox3.Location = new System.Drawing.Point(6, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // radSoyad
            // 
            this.radSoyad.AutoSize = true;
            this.radSoyad.Location = new System.Drawing.Point(109, 19);
            this.radSoyad.Name = "radSoyad";
            this.radSoyad.Size = new System.Drawing.Size(55, 17);
            this.radSoyad.TabIndex = 0;
            this.radSoyad.Text = "Soyad";
            this.radSoyad.UseVisualStyleBackColor = true;
            this.radSoyad.CheckedChanged += new System.EventHandler(this.radSoyad_CheckedChanged);
            // 
            // radTCno
            // 
            this.radTCno.AutoSize = true;
            this.radTCno.Checked = true;
            this.radTCno.Location = new System.Drawing.Point(22, 19);
            this.radTCno.Name = "radTCno";
            this.radTCno.Size = new System.Drawing.Size(51, 17);
            this.radTCno.TabIndex = 0;
            this.radTCno.TabStop = true;
            this.radTCno.Text = "TCno";
            this.radTCno.UseVisualStyleBackColor = true;
            this.radTCno.CheckedChanged += new System.EventHandler(this.radTCno_CheckedChanged);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(115, 31);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbAramaTuru.TabIndex = 1;
            this.cmbAramaTuru.Text = "İle Başlayan";
            // 
            // lblArananAlan
            // 
            this.lblArananAlan.AutoSize = true;
            this.lblArananAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArananAlan.Location = new System.Drawing.Point(25, 121);
            this.lblArananAlan.Name = "lblArananAlan";
            this.lblArananAlan.Size = new System.Drawing.Size(45, 13);
            this.lblArananAlan.TabIndex = 0;
            this.lblArananAlan.Text = "TCno :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Türü";
            // 
            // Personel_Islemleri_Menusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Personel_Islemleri_Menusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel_Islemleri_Menusu";
            this.Activated += new System.EventHandler(this.Personel_Islemleri_Menusu_Activated);
            this.Load += new System.EventHandler(this.Personel_Islemleri_Menusu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKayitEkle;
        private System.Windows.Forms.ToolStripButton btnKayitSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbBirimAra;
        private System.Windows.Forms.ComboBox cmbIlAra;
        private System.Windows.Forms.TextBox txtSoyadAra;
        private System.Windows.Forms.CheckBox chkBirim;
        private System.Windows.Forms.CheckBox chkDYeri;
        private System.Windows.Forms.CheckBox chkSoyad;
        private System.Windows.Forms.ToolStripButton btnKayitDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radSoyad;
        private System.Windows.Forms.RadioButton radTCno;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label label1;
    }
}