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
    public partial class AlacakVerecekTablosu : Form
    {
        public AlacakVerecekTablosu()
        {
            InitializeComponent();
        }

        public void KategoriYukle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT KategoriAdi From AVKategoriTablosu";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKategori.Items.Add(dr["KategoriAdi"]);
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
                string Sorgu = "SELECT * FROM AlacakVerecekTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "AlacakVerecekTablosu");
                dataGridView1.DataSource = ds.Tables["AlacakVerecekTablosu"];
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
                string SorguTum = "SELECT * FROM AlacakVerecekTablosu";
                string SorguKategori = "SELECT * FROM AlacakVerecekTablosu where KategoriID='"+cmbKategori.Text+"'";
                string SorguKisiAd = "SELECT * FROM AlacakVerecekTablosu where A_VKisiID='"+txtKisiAd.Text+"'";
                string SorguKategoriKisiAd = "SELECT * FROM AlacakVerecekTablosu where KategoriID='" + cmbKategori.Text + "' AND A_VKisiID='" + txtKisiAd.Text + "'";
                if (chkKategori.Checked == true && chkKisiAd.Checked == true)
                    SorguTum = SorguKategoriKisiAd;
                else if (chkKisiAd.Checked == true)
                    SorguTum = SorguKisiAd;
                else if (chkKategori.Checked == true)
                    SorguTum = SorguKategori;
                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "AlacakVerecekTablosu");
                dataGridView1.DataSource = ds.Tables["AlacakVerecekTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlacakVerecekTablosu_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void AlacakVerecekTablosu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            AlacakVerecekKayitEkleForm frmEkle = new AlacakVerecekKayitEkleForm();
            frmEkle.ShowDialog();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "KayitID";
            KayitSilForm1.Tablo = "AlacakVerecekTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Alacak Verecek Kayıt Sil";
            FrmSil.lbl1.Text = "KayitID";
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
            AlacakVerecekDuzenleForm frmDuzen = new AlacakVerecekDuzenleForm();

            frmDuzen.txtKayitID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.cmbKategoriID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzen.txtMiktar.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value).ToString();
            frmDuzen.dtpSonOdemeTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzen.cmbA_VKisiSinif.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzen.cmbA_VKisiID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmDuzen.dtpKayitTarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            frmDuzen.ShowDialog();
        }

        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            if(chkKategori.Checked == true)
            {
                cmbKategori.Enabled = true;
                cmbKategori.Text = "Kategori Seçiniz";
                cmbKategori.Items.Clear();
                KategoriYukle();
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
