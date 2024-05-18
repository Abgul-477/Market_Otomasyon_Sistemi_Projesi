using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_Otomasyon_Sistemi_Projesi
{
    public partial class TedarikciTemsilciForm : Form
    {
        public TedarikciTemsilciForm()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From TedTemsilciTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu,Ana_Ekran.Baglanti);
                da.Fill(ds, "TedTemsilciTablosu");
                dataGridView1.DataSource = ds.Tables["TedTemsilciTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"KayıtListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From TedTemsilciTablosu";
                string SorguAd = "Select * From TedTemsilciTablosu where Ad='"+txtAd.Text+"'";
                string SorguSoyad = "Select * From TedTemsilciTablosu where Soyad='" + txtSoyad.Text + "'";
                string SorguAdSoyad = "Select * From TedTemsilciTablosu where Ad='" + txtAd.Text + "' AND Soyad='" + txtSoyad.Text + "'";
                if (chkAd.Checked == true && chkSoyad.Checked == true)
                    Sorgu = SorguAdSoyad;
                else if (chkAd.Checked == true)
                    Sorgu = SorguAd;
                else if (chkSoyad.Checked == true)
                    Sorgu = SorguSoyad;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "TedTemsilciTablosu");
                dataGridView1.DataSource = ds.Tables["TedTemsilciTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayıtListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TedarikciTemsilciForm_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TedarikciTemsilciKayitEkleForm frmKayit = new TedarikciTemsilciKayitEkleForm();
            frmKayit.ShowDialog();
        }

        private void TedarikciTemsilciForm_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "TemsilciID";
            KayitSilForm1.Tablo = "TedTemsilciTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "TedTemsilci Kayıt Sil";
            FrmSil.lbl1.Text = "TemID";
            FrmSil.lbl2.Text = "TCno";
            FrmSil.lbl3.Text = "Ad";
            FrmSil.lbl4.Text = "Soyad";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            TedarikciTemsilcikayitDuzenleForm frmDuzenle = new TedarikciTemsilcikayitDuzenleForm();
            frmDuzenle.txtTemsilciID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.txtTCno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzenle.txtEMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzenle.txtCepTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmDuzenle.txtSabitTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmDuzenle.cmbTedarikci.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmDuzenle.txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void chkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAd.Checked == true)
            {
                txtAd.Enabled = true;
                txtAd.Text = "";
            }
            else
            {
                txtAd.Enabled = false;
                txtAd.Text = "";
            }
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked == true)
            {
                txtSoyad.Enabled = true;
                txtSoyad.Text = "";
            }
            else
            {
                txtSoyad.Enabled = false;
                txtSoyad.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }
    }
}
