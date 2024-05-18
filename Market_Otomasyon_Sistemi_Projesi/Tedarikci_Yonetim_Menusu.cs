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
    public partial class Tedarikci_Yonetim_Menusu : Form
    {
        public Tedarikci_Yonetim_Menusu()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM TedarikciTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "TedarikciTablosu");
                dataGridView1.DataSource = ds.Tables["TedarikciTablosu"];
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
                string Sorgu = "SELECT * FROM TedarikciTablosu";
                string SorguTelNo = "SELECT * FROM TedarikciTablosu where TelNo='"+txtTelNo.Text+"'";
                string SorguDurum;
                string SorguDurumTelNo;
                if (radAktif.Checked == true)
                {
                    SorguDurum = "SELECT * FROM TedarikciTablosu where Durum='True'";
                    SorguDurumTelNo = "SELECT * FROM TedarikciTablosu where Durum='True' AND TelNo='" + txtTelNo.Text + "'";
                }
                else
                {
                    SorguDurum = "SELECT * FROM TedarikciTablosu where Durum='False'";
                    SorguDurumTelNo = "SELECT * FROM TedarikciTablosu where Durum='False' AND TelNo='" + txtTelNo.Text + "'";
                }
                if (chkDurum.Checked == true && chkTelNo.Checked == true)
                    Sorgu = SorguDurumTelNo;
                else if (chkDurum.Checked == true)
                    Sorgu = SorguDurum;
                else if (chkTelNo.Checked == true)
                    Sorgu = SorguTelNo;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "TedarikciTablosu");
                dataGridView1.DataSource = ds.Tables["TedarikciTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tedarikci_Yonetim_Menusu_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void Tedarikci_Yonetim_Menusu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            TedarikciKayitEkleForm frmEkle = new TedarikciKayitEkleForm();
            frmEkle.ShowDialog();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "TedarikciID";
            KayitSilForm1.Tablo = "TedarikciTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Tedarikçi Kayıt Sil";
            FrmSil.lbl1.Text = "TedID";
            FrmSil.lbl2.Text = "Ad";
            FrmSil.lbl3.Text = "VergiNo";
            FrmSil.lbl4.Text = "TelNo";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            TedarikciKayitDuzenleForm frmDuzenle = new TedarikciKayitDuzenleForm();
            frmDuzenle.txtTedID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.txtVergiNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzenle.txtEMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzenle.txtFaksNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmDuzenle.txtAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "True")
                frmDuzenle.radAktif.Checked = true;
            else
                frmDuzenle.radPasif.Checked = true;
            frmDuzenle.txtTemsilciID.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkTelNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTelNo.Checked == true)
            {
                txtTelNo.Enabled = true;
                txtTelNo.Text = "";
            }
            else
            {
                txtTelNo.Enabled = false;
                txtTelNo.Text = "";
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
                radAktif.Enabled = false;
                radPasif.Enabled = false;
                radAktif.Checked = false;
                radPasif.Checked = false;
            }
        }
    }
}
