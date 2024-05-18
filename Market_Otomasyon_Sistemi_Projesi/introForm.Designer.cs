
namespace Market_Otomasyon_Sistemi_Projesi
{
    partial class introForm
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
            this.components = new System.ComponentModel.Container();
            this.btnGec = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctAraba = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAraba)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGec
            // 
            this.btnGec.Enabled = false;
            this.btnGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGec.Location = new System.Drawing.Point(462, 154);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(68, 33);
            this.btnGec.TabIndex = 0;
            this.btnGec.Text = "GEÇ";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(145, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 33);
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnGec);
            this.panel1.Location = new System.Drawing.Point(91, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 209);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.KASTAMONU_ÜNİVERSİTESİ_MESLEK_YÜKSEKOKULU_BİLGİSAYAR_PROGRAMCIL;
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(627, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.kastamonu_uni_logo;
            this.pictureBox2.Location = new System.Drawing.Point(105, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctAraba
            // 
            this.pctAraba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctAraba.Image = global::Market_Otomasyon_Sistemi_Projesi.Properties.Resources.market_araba;
            this.pctAraba.Location = new System.Drawing.Point(309, 109);
            this.pctAraba.Name = "pctAraba";
            this.pctAraba.Size = new System.Drawing.Size(200, 200);
            this.pctAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAraba.TabIndex = 1;
            this.pctAraba.TabStop = false;
            // 
            // introForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(819, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctAraba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "introForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "introForm";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.introForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAraba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.PictureBox pctAraba;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}