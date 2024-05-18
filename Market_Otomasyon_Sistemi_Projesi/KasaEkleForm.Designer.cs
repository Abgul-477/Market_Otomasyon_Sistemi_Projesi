
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class KasaEkleForm
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
            this.YildizDurum = new System.Windows.Forms.Label();
            this.YildizAd = new System.Windows.Forms.Label();
            this.radPasif = new System.Windows.Forms.RadioButton();
            this.radAktif = new System.Windows.Forms.RadioButton();
            this.txtKasaAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.YildizDurum);
            this.panel1.Controls.Add(this.YildizAd);
            this.panel1.Controls.Add(this.radPasif);
            this.panel1.Controls.Add(this.radAktif);
            this.panel1.Controls.Add(this.txtKasaAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 102);
            this.panel1.TabIndex = 0;
            // 
            // YildizDurum
            // 
            this.YildizDurum.AutoSize = true;
            this.YildizDurum.ForeColor = System.Drawing.Color.Red;
            this.YildizDurum.Location = new System.Drawing.Point(251, 57);
            this.YildizDurum.Name = "YildizDurum";
            this.YildizDurum.Size = new System.Drawing.Size(15, 20);
            this.YildizDurum.TabIndex = 3;
            this.YildizDurum.Text = "*";
            this.YildizDurum.Visible = false;
            // 
            // YildizAd
            // 
            this.YildizAd.AutoSize = true;
            this.YildizAd.ForeColor = System.Drawing.Color.Red;
            this.YildizAd.Location = new System.Drawing.Point(251, 22);
            this.YildizAd.Name = "YildizAd";
            this.YildizAd.Size = new System.Drawing.Size(15, 20);
            this.YildizAd.TabIndex = 3;
            this.YildizAd.Text = "*";
            this.YildizAd.Visible = false;
            // 
            // radPasif
            // 
            this.radPasif.AutoSize = true;
            this.radPasif.Location = new System.Drawing.Point(183, 53);
            this.radPasif.Name = "radPasif";
            this.radPasif.Size = new System.Drawing.Size(62, 24);
            this.radPasif.TabIndex = 3;
            this.radPasif.TabStop = true;
            this.radPasif.Text = "Pasif";
            this.radPasif.UseVisualStyleBackColor = true;
            // 
            // radAktif
            // 
            this.radAktif.AutoSize = true;
            this.radAktif.Location = new System.Drawing.Point(121, 53);
            this.radAktif.Name = "radAktif";
            this.radAktif.Size = new System.Drawing.Size(59, 24);
            this.radAktif.TabIndex = 2;
            this.radAktif.TabStop = true;
            this.radAktif.Text = "Aktif";
            this.radAktif.UseVisualStyleBackColor = true;
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Location = new System.Drawing.Point(121, 16);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(124, 26);
            this.txtKasaAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Adı";
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.accept;
            this.btnKayit.Location = new System.Drawing.Point(12, 119);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(282, 42);
            this.btnKayit.TabIndex = 4;
            this.btnKayit.Text = "Kayıt Ekle";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // KasaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 173);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KasaEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KasaEkleForm";
            this.Load += new System.EventHandler(this.KasaEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKasaAd;
        private System.Windows.Forms.RadioButton radPasif;
        private System.Windows.Forms.RadioButton radAktif;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label YildizDurum;
        private System.Windows.Forms.Label YildizAd;
    }
}