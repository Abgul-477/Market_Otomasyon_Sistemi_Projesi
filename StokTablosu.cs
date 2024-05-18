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
    public partial class StokTablosu : Form
    {
        public StokTablosu()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM StokTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "StokTablosu");
                dataGridView1.DataSource = ds.Tables["StokTablosu"];
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
                string Sorgu = "SELECT * FROM StokTablosu";
                string SorguTedID = "SELECT * FROM StokTablosu where TedarikciID='"+cmbTedID.Text+"'";
                string SorguUrID = "SELECT * FROM StokTablosu where UrunID='" + cmbUrunID.Text + "'";
                string SorguTedIDUrID = "SELECT * FROM StokTablosu where TedarikciID='" + cmbTedID.Text + "' AND UrunID='" + cmbUrunID.Text + "'";
                if (chkTedarikciID.Checked == true && chkUrunID.Checked == true)
                    Sorgu = SorguTedIDUrID;
                else if (chkTedarikciID.Checked == true)
                    Sorgu = SorguTedID;
                else if (chkUrunID.Checked == true)
                    Sorgu = SorguUrID;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "StokTablosu");
                dataGridView1.DataSource = ds.Tables["StokTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StokTablosu_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void StokTablosu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            StokGirisEkraniForm frmGiris = new StokGirisEkraniForm();
            frmGiris.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            StokKayitDuzenleForm frmDuzenle = new StokKayitDuzenleForm();
            frmDuzenle.txtStokID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.cmbUrun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.cmbTedarikci.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtMiktar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzenle.dtpSKT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmDuzenle.txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmDuzenle.cmbPersonel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "StokID";
            KayitSilForm1.Tablo = "StokTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Stok Kayıt Sil";
            FrmSil.lbl1.Text = "StokID";
            FrmSil.lbl2.Text = "UrunID";
            FrmSil.lbl3.Text = "Miktar";
            FrmSil.lbl4.Text = "TedarID";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void chkUrunID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrunID.Checked == true)
            {
                cmbUrunID.Enabled = true;
                cmbUrunID.Text = "Ürün ID Seçin";
            }
            else
            {
                cmbUrunID.Enabled = false;
                cmbUrunID.Text = "";
            }
        }

        private void chkTedarikciID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTedarikciID.Checked == true)
            {
                cmbTedID.Enabled = true;
                cmbTedID.Text = "Toptancı ID Seçin";
            }
            else
            {
                cmbTedID.Enabled = false;
                cmbTedID.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }
    }
}
