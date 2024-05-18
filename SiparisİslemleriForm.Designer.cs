
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class SiparisİslemleriForm
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayıtEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayıtSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKayitDüzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbUrunID = new System.Windows.Forms.ComboBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.chkUrun = new System.Windows.Forms.CheckBox();
            this.radUlasti = new System.Windows.Forms.RadioButton();
            this.radUlasmadi = new System.Windows.Forms.RadioButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(94, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnKayıtEkle,
            this.toolStripSeparator2,
            this.btnKayıtSil,
            this.toolStripSeparator3,
            this.btnKayitDüzenle,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(91, 482);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(88, 6);
            // 
            // btnKayıtEkle
            // 
            this.btnKayıtEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.add;
            this.btnKayıtEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayıtEkle.Name = "btnKayıtEkle";
            this.btnKayıtEkle.Size = new System.Drawing.Size(88, 35);
            this.btnKayıtEkle.Text = "Sipariş Ekle";
            this.btnKayıtEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayıtEkle.Click += new System.EventHandler(this.btnKayıtEkle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(88, 6);
            // 
            // btnKayıtSil
            // 
            this.btnKayıtSil.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.cross;
            this.btnKayıtSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayıtSil.Name = "btnKayıtSil";
            this.btnKayıtSil.Size = new System.Drawing.Size(88, 35);
            this.btnKayıtSil.Text = "Sipariş Sil";
            this.btnKayıtSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayıtSil.Click += new System.EventHandler(this.btnKayıtSil_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(88, 6);
            // 
            // btnKayitDüzenle
            // 
            this.btnKayitDüzenle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.page_white_edit;
            this.btnKayitDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDüzenle.Name = "btnKayitDüzenle";
            this.btnKayitDüzenle.Size = new System.Drawing.Size(88, 35);
            this.btnKayitDüzenle.Text = "Sipariş Düzenle";
            this.btnKayitDüzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitDüzenle.Click += new System.EventHandler(this.btnKayitDüzenle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(88, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUlasmadi);
            this.groupBox1.Controls.Add(this.radUlasti);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.cmbUrunID);
            this.groupBox1.Controls.Add(this.chkDurum);
            this.groupBox1.Controls.Add(this.chkUrun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(674, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 134);
            this.groupBox1.TabIndex = 6;
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
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbUrunID
            // 
            this.cmbUrunID.Enabled = false;
            this.cmbUrunID.FormattingEnabled = true;
            this.cmbUrunID.Items.AddRange(new object[] {
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
            this.cmbUrunID.Location = new System.Drawing.Point(91, 34);
            this.cmbUrunID.Name = "cmbUrunID";
            this.cmbUrunID.Size = new System.Drawing.Size(100, 21);
            this.cmbUrunID.TabIndex = 1;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(28, 62);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(57, 17);
            this.chkDurum.TabIndex = 2;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkDurum_CheckedChanged);
            // 
            // chkUrun
            // 
            this.chkUrun.AutoSize = true;
            this.chkUrun.Location = new System.Drawing.Point(28, 36);
            this.chkUrun.Name = "chkUrun";
            this.chkUrun.Size = new System.Drawing.Size(49, 17);
            this.chkUrun.TabIndex = 0;
            this.chkUrun.Text = "Urun";
            this.chkUrun.UseVisualStyleBackColor = true;
            this.chkUrun.CheckedChanged += new System.EventHandler(this.chkUrun_CheckedChanged);
            // 
            // radUlasti
            // 
            this.radUlasti.AutoSize = true;
            this.radUlasti.Enabled = false;
            this.radUlasti.Location = new System.Drawing.Point(91, 62);
            this.radUlasti.Name = "radUlasti";
            this.radUlasti.Size = new System.Drawing.Size(51, 17);
            this.radUlasti.TabIndex = 3;
            this.radUlasti.TabStop = true;
            this.radUlasti.Text = "Ulasti";
            this.radUlasti.UseVisualStyleBackColor = true;
            // 
            // radUlasmadi
            // 
            this.radUlasmadi.AutoSize = true;
            this.radUlasmadi.Enabled = false;
            this.radUlasmadi.Location = new System.Drawing.Point(148, 62);
            this.radUlasmadi.Name = "radUlasmadi";
            this.radUlasmadi.Size = new System.Drawing.Size(68, 17);
            this.radUlasmadi.TabIndex = 4;
            this.radUlasmadi.TabStop = true;
            this.radUlasmadi.Text = "Ulasmadi";
            this.radUlasmadi.UseVisualStyleBackColor = true;
            // 
            // SiparisİslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisİslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiparisİslemleriForm";
            this.Activated += new System.EventHandler(this.SiparisİslemleriForm_Activated);
            this.Load += new System.EventHandler(this.SiparisİslemleriForm_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnKayıtEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnKayıtSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnKayitDüzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbUrunID;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.CheckBox chkUrun;
        private System.Windows.Forms.RadioButton radUlasmadi;
        private System.Windows.Forms.RadioButton radUlasti;
    }
}