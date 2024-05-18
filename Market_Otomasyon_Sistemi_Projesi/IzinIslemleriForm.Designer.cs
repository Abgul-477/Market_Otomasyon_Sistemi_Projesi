
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class IzinIslemleriForm
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIzinEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIzinSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIzınDegistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.chkPerID = new System.Windows.Forms.CheckBox();
            this.txtPerID = new System.Windows.Forms.MaskedTextBox();
            this.radOnay = new System.Windows.Forms.RadioButton();
            this.RadIptal = new System.Windows.Forms.RadioButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(78, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnIzinEkle,
            this.toolStripSeparator1,
            this.btnIzinSil,
            this.toolStripSeparator2,
            this.btnIzınDegistir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(75, 450);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(72, 6);
            // 
            // btnIzinEkle
            // 
            this.btnIzinEkle.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.add;
            this.btnIzinEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIzinEkle.Name = "btnIzinEkle";
            this.btnIzinEkle.Size = new System.Drawing.Size(72, 35);
            this.btnIzinEkle.Text = "İzin Ekle";
            this.btnIzinEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzinEkle.Click += new System.EventHandler(this.btnIzinEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(72, 6);
            // 
            // btnIzinSil
            // 
            this.btnIzinSil.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.cross;
            this.btnIzinSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIzinSil.Name = "btnIzinSil";
            this.btnIzinSil.Size = new System.Drawing.Size(72, 35);
            this.btnIzinSil.Text = "İzin Sil";
            this.btnIzinSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzinSil.Click += new System.EventHandler(this.btnIzinSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(72, 6);
            // 
            // btnIzınDegistir
            // 
            this.btnIzınDegistir.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.page_white_edit;
            this.btnIzınDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIzınDegistir.Name = "btnIzınDegistir";
            this.btnIzınDegistir.Size = new System.Drawing.Size(72, 35);
            this.btnIzınDegistir.Text = "İzin Düzenle";
            this.btnIzınDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzınDegistir.Click += new System.EventHandler(this.btnIzınDegistir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(72, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadIptal);
            this.groupBox1.Controls.Add(this.radOnay);
            this.groupBox1.Controls.Add(this.txtPerID);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.chkDurum);
            this.groupBox1.Controls.Add(this.chkPerID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(628, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.magnifier;
            this.btnAra.Location = new System.Drawing.Point(89, 100);
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
            this.chkDurum.Location = new System.Drawing.Point(28, 62);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(57, 17);
            this.chkDurum.TabIndex = 0;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkDurum_CheckedChanged);
            // 
            // chkPerID
            // 
            this.chkPerID.AutoSize = true;
            this.chkPerID.Location = new System.Drawing.Point(28, 36);
            this.chkPerID.Name = "chkPerID";
            this.chkPerID.Size = new System.Drawing.Size(78, 17);
            this.chkPerID.TabIndex = 0;
            this.chkPerID.Text = "PersonelID";
            this.chkPerID.UseVisualStyleBackColor = true;
            this.chkPerID.CheckedChanged += new System.EventHandler(this.chkPerID_CheckedChanged);
            // 
            // txtPerID
            // 
            this.txtPerID.Enabled = false;
            this.txtPerID.Location = new System.Drawing.Point(112, 34);
            this.txtPerID.Mask = "00000000";
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(100, 20);
            this.txtPerID.TabIndex = 4;
            this.txtPerID.ValidatingType = typeof(int);
            // 
            // radOnay
            // 
            this.radOnay.AutoSize = true;
            this.radOnay.Enabled = false;
            this.radOnay.Location = new System.Drawing.Point(112, 62);
            this.radOnay.Name = "radOnay";
            this.radOnay.Size = new System.Drawing.Size(50, 17);
            this.radOnay.TabIndex = 5;
            this.radOnay.TabStop = true;
            this.radOnay.Text = "Onay";
            this.radOnay.UseVisualStyleBackColor = true;
            // 
            // RadIptal
            // 
            this.RadIptal.AutoSize = true;
            this.RadIptal.Enabled = false;
            this.RadIptal.Location = new System.Drawing.Point(166, 62);
            this.RadIptal.Name = "RadIptal";
            this.RadIptal.Size = new System.Drawing.Size(45, 17);
            this.RadIptal.TabIndex = 5;
            this.RadIptal.TabStop = true;
            this.RadIptal.Text = "İptal";
            this.RadIptal.UseVisualStyleBackColor = true;
            // 
            // IzinIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IzinIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IzinIslemleriForm";
            this.Activated += new System.EventHandler(this.IzinIslemleriForm_Activated);
            this.Load += new System.EventHandler(this.IzinIslemleriForm_Load);
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
        private System.Windows.Forms.ToolStripButton btnIzinEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnIzinSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnIzınDegistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.CheckBox chkPerID;
        private System.Windows.Forms.RadioButton RadIptal;
        private System.Windows.Forms.RadioButton radOnay;
        private System.Windows.Forms.MaskedTextBox txtPerID;
    }
}