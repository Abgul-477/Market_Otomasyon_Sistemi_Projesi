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
    public partial class SiparisİslemleriForm : Form
    {
        public SiparisİslemleriForm()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM SiparisTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "SiparisTablosu");
                dataGridView1.DataSource = ds.Tables["SiparisTablosu"];
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
                string Sorgu = "SELECT * FROM SiparisTablosu";
                string SorguUrun = "SELECT * FROM SiparisTablosu where UrunID='" + cmbUrunID.Text + "'";
                string SorguDurum;
                string SorguUrunDurum;
                if (radUlasti.Checked == true)
                {
                    SorguDurum = "SELECT * FROM SiparisTablosu where Durum='Ulasti'";
                    SorguUrunDurum = "SELECT * FROM SiparisTablosu where UrunID='" + cmbUrunID.Text + "' AND Durum='Ulasti'";
                }
                else
                {
                    SorguDurum = "SELECT * FROM SiparisTablosu where Durum='Ulasmadi'";
                    SorguUrunDurum = "SELECT * FROM SiparisTablosu where UrunID='" + cmbUrunID.Text + "' AND Durum='Ulasmadi'";
                }
                if (chkDurum.Checked == true && chkUrun.Checked == true)
                    Sorgu = SorguUrunDurum;
                else if (chkUrun.Checked == true)
                    Sorgu = SorguUrun;
                else if (chkDurum.Checked == true)
                    Sorgu = SorguDurum;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "SiparisTablosu");
                dataGridView1.DataSource = ds.Tables["SiparisTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SiparisİslemleriForm_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void SiparisİslemleriForm_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            SiparisOlusturForm frmOlustur = new SiparisOlusturForm();
            frmOlustur.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            SiparisDuzenleForm frmDuzenle = new SiparisDuzenleForm();
            frmDuzenle.txtSiparisID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.cmbTedarikci.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.cmbUrun.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzenle.txtOlusturmaTar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzenle.dtpBekTar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Ulasti")
            {
                frmDuzenle.dtpUlasmaTar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmDuzenle.dtpUlasmaTar.Visible = true;
                frmDuzenle.dtpUlasmaTar.Enabled = true;
                frmDuzenle.radUlasti.Checked = true;
            }
            else
                frmDuzenle.radUlasmadi.Checked = true;
            frmDuzenle.txtAciklama.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "SiparisID";
            KayitSilForm1.Tablo = "SiparisTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Sipariş Kayıt Sil";
            FrmSil.lbl1.Text = "UrunID";
            FrmSil.lbl2.Text = "Tedarikci";
            FrmSil.lbl3.Text = "Urun";
            FrmSil.lbl4.Text = "Miktar";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkUrun_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrun.Checked == true)
            {
                cmbUrunID.Enabled = true;
                cmbUrunID.Text = "Ürün Seçiniz";
            }
            else
            {
                cmbUrunID.Enabled = false;
                cmbUrunID.Text = "";
            }
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDurum.Checked == true)
            {
                radUlasmadi.Enabled = true;
                radUlasti.Enabled = true;
            }
            else
            {
                radUlasti.Enabled = false;
                radUlasmadi.Enabled = false;
                radUlasmadi.Checked = false;
                radUlasti.Checked = false;
            }
        }
    }
}
