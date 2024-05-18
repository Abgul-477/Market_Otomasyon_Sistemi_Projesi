using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyon_Sistemi_Projesi
{
    public partial class introForm : Form
    {
        public introForm()
        {
            InitializeComponent();
        }

        int Araba;
        double i = 3;
        bool Gec = false;

        private void introForm_Load(object sender, EventArgs e)
        {
            Araba = pctAraba.Left;
            pctAraba.Left = 0 - pctAraba.Width;
            panel1.Top -= 200;
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Gec==false)
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 2;
                    panel1.Top += 4;
                    this.Opacity += 0.02;
                }
                else if (pctAraba.Left < Araba)
                {
                    pctAraba.Left += 1 * Convert.ToInt32(i);
                    i += 0.5;
                }
                else
                {
                    pctAraba.Left = Araba;
                    btnGec.Enabled = true;
                }
            }

            if (Gec)
            {
                if (pctAraba.Left<this.Width)
                {
                    pctAraba.Left += 1 * Convert.ToInt32(i);
                    i -= 0.5;
                }
                else
                {
                    KullaniciGirisForm frm = new KullaniciGirisForm();
                    frm.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Gec = true;
        }
    }
}
