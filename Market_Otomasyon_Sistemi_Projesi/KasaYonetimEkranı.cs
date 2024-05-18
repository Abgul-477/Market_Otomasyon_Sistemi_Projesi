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
    public partial class KasaYonetimEkranı : Form
    {
        public KasaYonetimEkranı()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM KasaTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "KasaTablosu");
                dataGridView1.DataSource = ds.Tables["KasaTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "SELECT * FROM KasaTablosu";
                string SorguPerID = "SELECT * FROM KasaTablosu where SonKullaniciID='"+txtPerID.Text+"'";
                string SorguDurum;
                string SorguPerIDDurum;
                if (radAktif.Checked == true)
                {
                    SorguDurum = "SELECT * FROM KasaTablosu where Durum='True'";
                    SorguPerIDDurum = "SELECT * FROM KasaTablosu where SonKullaniciID='" + txtPerID.Text + "' AND Durum='True'";
                }
                else
                {
                    SorguDurum = "SELECT * FROM KasaTablosu where Durum='False'";
                    SorguPerIDDurum = "SELECT * FROM KasaTablosu where SonKullaniciID='" + txtPerID.Text + "' AND Durum='False'";
                }

                if (chkSonKulPer.Checked == true && chkDurum.Checked == true)
                    SorguTum = SorguPerIDDurum;
                else if (chkDurum.Checked == true)
                    SorguTum = SorguDurum;
                else if (chkSonKulPer.Checked == true)
                    SorguTum = SorguPerID;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "KasaTablosu");
                dataGridView1.DataSource = ds.Tables["KasaTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KasaYonetimEkranı_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnKasaEkle_Click(object sender, EventArgs e)
        {
            KasaEkleForm frmEkle = new KasaEkleForm();
            frmEkle.ShowDialog();
        }

        private void btnKasaSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "KasaID";
            KayitSilForm1.Tablo = "KasaTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Kasa Kayıt Sil";
            FrmSil.lbl1.Text = "KasaID";
            FrmSil.lbl2.Text = "KasaAd";
            FrmSil.lbl3.Text = "S.S.K.ID";
            FrmSil.lbl4.Text = "S.K.ID";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void KasaYonetimEkranı_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            KasaDuzenleForm frmDuzen = new KasaDuzenleForm();
            frmDuzen.txtKasaID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.txtKasaAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "True")
                frmDuzen.radAktif.Checked = true;
            else
                frmDuzen.radPasif.Checked = true;
            frmDuzen.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkSonKulPer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSonKulPer.Checked == true)
            {
                txtPerID.Text = "";
                txtPerID.Enabled = true;
            }
            else
            {
                txtPerID.Text = "";
                txtPerID.Enabled = false;
            }
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDurum.Checked == true)
            {
                radAktif.Enabled = true;
                radPasif.Enabled = true;
            }
            else
            {
                radAktif.Checked = false;
                radPasif.Checked = false;
                radAktif.Enabled = false;
                radPasif.Enabled = false;
            }
        }
    }
}
