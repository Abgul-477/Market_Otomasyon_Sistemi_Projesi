
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class MaasTablosuForm
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
            this.radPasif = new System.Windows.Forms.RadioButton();
            this.radAktif = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.chkTutar = new System.Windows.Forms.CheckBox();
            this.txtMaasTutar = new System.Windows.Forms.MaskedTextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(86, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 536);
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
            this.toolStrip1.Size = new System.Drawing.Size(83, 560);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayıtEkle
            // 
            this.btnKayıtEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.add;
            this.btnKayıtEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayıtEkle.Name = "btnKayıtEkle";
            this.btnKayıtEkle.Size = new System.Drawing.Size(80, 35);
            this.btnKayıtEkle.Text = "Kayıt Ekle";
            this.btnKayıtEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayıtEkle.Click += new System.EventHandler(this.btnKayıtEkle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayıtSil
            // 
            this.btnKayıtSil.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.cross;
            this.btnKayıtSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayıtSil.Name = "btnKayıtSil";
            this.btnKayıtSil.Size = new System.Drawing.Size(80, 35);
            this.btnKayıtSil.Text = "Kayit Sil";
            this.btnKayıtSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayıtSil.Click += new System.EventHandler(this.btnKayıtSil_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(80, 6);
            // 
            // btnKayitDüzenle
            // 
            this.btnKayitDüzenle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.page_white_edit;
            this.btnKayitDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDüzenle.Name = "btnKayitDüzenle";
            this.btnKayitDüzenle.Size = new System.Drawing.Size(80, 35);
            this.btnKayitDüzenle.Text = "Kayıt Düzenle";
            this.btnKayitDüzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitDüzenle.Click += new System.EventHandler(this.btnKayitDüzenle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(80, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaasTutar);
            this.groupBox1.Controls.Add(this.radPasif);
            this.groupBox1.Controls.Add(this.radAktif);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.chkDurum);
            this.groupBox1.Controls.Add(this.chkTutar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(604, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
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
            // chkTutar
            // 
            this.chkTutar.AutoSize = true;
            this.chkTutar.Location = new System.Drawing.Point(22, 36);
            this.chkTutar.Name = "chkTutar";
            this.chkTutar.Size = new System.Drawing.Size(51, 17);
            this.chkTutar.TabIndex = 0;
            this.chkTutar.Text = "Tutar";
            this.chkTutar.UseVisualStyleBackColor = true;
            this.chkTutar.CheckedChanged += new System.EventHandler(this.chkTutar_CheckedChanged);
            // 
            // txtMaasTutar
            // 
            this.txtMaasTutar.Enabled = false;
            this.txtMaasTutar.Location = new System.Drawing.Point(115, 34);
            this.txtMaasTutar.Mask = "0000000000";
            this.txtMaasTutar.Name = "txtMaasTutar";
            this.txtMaasTutar.Size = new System.Drawing.Size(73, 20);
            this.txtMaasTutar.TabIndex = 7;
            this.txtMaasTutar.ValidatingType = typeof(int);
            // 
            // MaasTablosuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaasTablosuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaasTablosuForm";
            this.Activated += new System.EventHandler(this.MaasTablosuForm_Activated);
            this.Load += new System.EventHandler(this.MaasTablosuForm_Load);
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
        private System.Windows.Forms.RadioButton radPasif;
        private System.Windows.Forms.RadioButton radAktif;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.CheckBox chkTutar;
        private System.Windows.Forms.MaskedTextBox txtMaasTutar;
    }
}