
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class KasaYonetimEkranı
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
            this.btnKasaEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKasaSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.chkSonKulPer = new System.Windows.Forms.CheckBox();
            this.txtPerID = new System.Windows.Forms.MaskedTextBox();
            this.radAktif = new System.Windows.Forms.RadioButton();
            this.radPasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(452, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnKasaEkle,
            this.toolStripSeparator3,
            this.btnKasaSil,
            this.toolStripSeparator1,
            this.btnDuzenle,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(60, 491);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // btnKasaEkle
            // 
            this.btnKasaEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.add;
            this.btnKasaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKasaEkle.Name = "btnKasaEkle";
            this.btnKasaEkle.Size = new System.Drawing.Size(57, 35);
            this.btnKasaEkle.Text = "Kasa Ekle";
            this.btnKasaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKasaEkle.Click += new System.EventHandler(this.btnKasaEkle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(57, 6);
            // 
            // btnKasaSil
            // 
            this.btnKasaSil.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.cross;
            this.btnKasaSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKasaSil.Name = "btnKasaSil";
            this.btnKasaSil.Size = new System.Drawing.Size(57, 35);
            this.btnKasaSil.Text = "Kasa Sil";
            this.btnKasaSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKasaSil.Click += new System.EventHandler(this.btnKasaSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.page_white_edit;
            this.btnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(57, 35);
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(57, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPasif);
            this.groupBox1.Controls.Add(this.radAktif);
            this.groupBox1.Controls.Add(this.txtPerID);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.chkDurum);
            this.groupBox1.Controls.Add(this.chkSonKulPer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(521, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.magnifier;
            this.btnAra.Location = new System.Drawing.Point(70, 100);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 28);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(22, 62);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(57, 17);
            this.chkDurum.TabIndex = 0;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkDurum_CheckedChanged);
            // 
            // chkSonKulPer
            // 
            this.chkSonKulPer.AutoSize = true;
            this.chkSonKulPer.Location = new System.Drawing.Point(22, 36);
            this.chkSonKulPer.Name = "chkSonKulPer";
            this.chkSonKulPer.Size = new System.Drawing.Size(87, 17);
            this.chkSonKulPer.TabIndex = 0;
            this.chkSonKulPer.Text = "SonKulPerID";
            this.chkSonKulPer.UseVisualStyleBackColor = true;
            this.chkSonKulPer.CheckedChanged += new System.EventHandler(this.chkSonKulPer_CheckedChanged);
            // 
            // txtPerID
            // 
            this.txtPerID.Enabled = false;
            this.txtPerID.Location = new System.Drawing.Point(115, 34);
            this.txtPerID.Mask = "0000000000";
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(68, 20);
            this.txtPerID.TabIndex = 5;
            this.txtPerID.ValidatingType = typeof(int);
            // 
            // radAktif
            // 
            this.radAktif.AutoSize = true;
            this.radAktif.Enabled = false;
            this.radAktif.Location = new System.Drawing.Point(115, 62);
            this.radAktif.Name = "radAktif";
            this.radAktif.Size = new System.Drawing.Size(46, 17);
            this.radAktif.TabIndex = 6;
            this.radAktif.TabStop = true;
            this.radAktif.Text = "Aktif";
            this.radAktif.UseVisualStyleBackColor = true;
            // 
            // radPasif
            // 
            this.radPasif.AutoSize = true;
            this.radPasif.Enabled = false;
            this.radPasif.Location = new System.Drawing.Point(167, 62);
            this.radPasif.Name = "radPasif";
            this.radPasif.Size = new System.Drawing.Size(48, 17);
            this.radPasif.TabIndex = 6;
            this.radPasif.TabStop = true;
            this.radPasif.Text = "Pasif";
            this.radPasif.UseVisualStyleBackColor = true;
            // 
            // KasaYonetimEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KasaYonetimEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KasaYonetimEkranı";
            this.Activated += new System.EventHandler(this.KasaYonetimEkranı_Activated);
            this.Load += new System.EventHandler(this.KasaYonetimEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKasaEkle;
        private System.Windows.Forms.ToolStripButton btnKasaSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.CheckBox chkSonKulPer;
        private System.Windows.Forms.MaskedTextBox txtPerID;
        private System.Windows.Forms.RadioButton radPasif;
        private System.Windows.Forms.RadioButton radAktif;
    }
}