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
    public partial class GelirGiderTablosu : Form
    {
        public GelirGiderTablosu()
        {
            InitializeComponent();
        }

        public void KategoriYükle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT Ad From GGKategoriTable";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while(dr.Read())
                {
                    cmbKategori.Items.Add(dr["Ad"]);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kategori Yükle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM GelirGiderTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "GelirGiderTablosu");
                dataGridView1.DataSource = ds.Tables["GelirGiderTablosu"];
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
                string SorguTum = "SELECT * FROM GelirGiderTablosu";
                string SorguKategori = "SELECT * FROM GelirGiderTablosu where KategoriID='" + cmbKategori.Text + "'";
                string SorguKisiAd = "SELECT * FROM GelirGiderTablosu where KisiID='" + txtKisiAd.Text + "'";
                string SorguKategoriKisiAd = "SELECT * FROM GelirGiderTablosu where KategoriID='" + cmbKategori.Text + "' AND KisiID='" + txtKisiAd.Text + "'";
                if (chkKategori.Checked == true && chkKisiAd.Checked == true)
                    SorguTum = SorguKategoriKisiAd;
                else if (chkKisiAd.Checked == true)
                    SorguTum = SorguKisiAd;
                else if (chkKategori.Checked == true)
                    SorguTum = SorguKategori;
                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "GelirGiderTablosu");
                dataGridView1.DataSource = ds.Tables["GelirGiderTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GelirGiderTablosu_Load(object sender, EventArgs e)
        {
            KayitListele();
            KategoriYükle();
        }

        private void GelirGiderTablosu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            GelirGiderKayitEkleForm frmEkle = new GelirGiderKayitEkleForm();
            frmEkle.ShowDialog();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "IslemID";
            KayitSilForm1.Tablo = "GelirGiderTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Gelir Gider Kayıt Sil";
            FrmSil.lbl1.Text = "IslemID";
            FrmSil.lbl2.Text = "KategoriID";
            FrmSil.lbl3.Text = "Miktar";
            FrmSil.lbl4.Text = "A_VKisiID";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            GelirGiderKayitDuzenleForm frmDuzen = new GelirGiderKayitDuzenleForm();

            frmDuzen.txtIslemID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.cmbKategori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzen.txtMiktar.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value).ToString();
            frmDuzen.cmbKisiSinif.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzen.cmbKisiID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzen.txtVergi.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value).ToString();
            frmDuzen.dtpTarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            frmDuzen.ShowDialog();
        }

        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKategori.Checked == true)
            {
                cmbKategori.Enabled = true;
                cmbKategori.Text = "Kategori Seçiniz";
                cmbKategori.Items.Clear();
                KategoriYükle();
            }
            else
            {
                cmbKategori.Enabled = false;
                cmbKategori.Text = "";
            }
        }

        private void chkKisiAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKisiAd.Checked == true)
            {
                txtKisiAd.Enabled = true;
                txtKisiAd.Text = "";
            }
            else
            {
                txtKisiAd.Enabled = false;
                txtKisiAd.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }
    }
}
