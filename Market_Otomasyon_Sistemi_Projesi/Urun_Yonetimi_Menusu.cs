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
    public partial class Urun_Yonetimi_Menusu : Form
    {
        public Urun_Yonetimi_Menusu()
        {
            InitializeComponent();
        }

        public void KategoriYukle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Select Ad From UrunKategoriTablosu";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
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
                string Sorgu = "SELECT * FROM Urun_Tablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu,Ana_Ekran.Baglanti);
                da.Fill(ds,"Urun_Tablosu");
                dataGridView1.DataSource = ds.Tables["Urun_Tablosu"];
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
                string SorguTartiKategori;
                string SorguTarti;
                string Sorgu = "SELECT * FROM Urun_Tablosu";
                string SorguKategori = "SELECT * FROM Urun_Tablosu where Kategori='" + cmbKategori.Text +"'";
                if (radEvet.Checked == true)
                {
                    SorguTarti = "SELECT * FROM Urun_Tablosu where Tartilabilir='True'";
                    SorguTartiKategori = "SELECT * FROM Urun_Tablosu where Tartilabilir='True' AND Kategori='" + cmbKategori.Text + "'";
                }
                else
                {
                    SorguTarti = "SELECT * FROM Urun_Tablosu where Tartilabilir='False'";
                    SorguTartiKategori = "SELECT * FROM Urun_Tablosu where Tartilabilir='False' AND Kategori='" + cmbKategori.Text + "'";
                }
                if (chkKategori.Checked == true && chkTartilabilir.Checked == true)
                    Sorgu = SorguTartiKategori;
                else if (chkTartilabilir.Checked == true)
                    Sorgu = SorguTarti;
                else if (chkKategori.Checked == true)
                    Sorgu = SorguKategori;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "Urun_Tablosu");
                dataGridView1.DataSource = ds.Tables["Urun_Tablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HizliAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Urun_Tablosu";
                string SorguBarNoBas = "Select * From Urun_Tablosu Where BarkodNo Like '" + txtAra.Text + "%'";
                string SorguBarNoBit = "Select * From Urun_Tablosu Where BarkodNo Like '%" + txtAra.Text + "'";
                string SorguBarNoIc = "Select * From Urun_Tablosu Where BarkodNo Like '%" + txtAra.Text + "%'";
                string SorguUruAdBas = "Select * From Urun_Tablosu Where UrunAd Like '" + txtAra.Text + "%'";
                string SorguUruAdBit = "Select * From Urun_Tablosu Where UrunAd Like '%" + txtAra.Text + "'";
                string SorguUruAdIc = "Select * From Urun_Tablosu Where UrunAd Like '%" + txtAra.Text + "%'";

                if (radBarkodNo.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguBarNoBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguBarNoBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguBarNoIc;
                }
                else if (radUrunAd.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguUruAdBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguUruAdBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguUruAdIc;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "Urun_Tablosu");
                dataGridView1.DataSource = ds.Tables["Urun_Tablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hizli Ara Hata Penceresi");
            }
        }

        private void Urun_Yonetimi_Menusu_Load(object sender, EventArgs e)
        {
            KayitListele();
            KategoriYukle();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleEkrani urunEkleEkrani = new UrunEkleEkrani();
            urunEkleEkrani.ShowDialog();
        }

        private void Urun_Yonetimi_Menusu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "UrunID";
            KayitSilForm1.Tablo = "Urun_Tablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Urun Kayıt Sil";
            FrmSil.lbl1.Text = "UrunID";
            FrmSil.lbl2.Text = "UrunAd";
            FrmSil.lbl3.Text = "Kategori";
            FrmSil.lbl4.Text = "BarkodNo";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            UrunKayitDuzenleForm frmDuzenle = new UrunKayitDuzenleForm();
            frmDuzenle.txtUrunID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.cmbKategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtBarkod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzenle.txtMinStok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmDuzenle.txtAlisFiy.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value) - (Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value) % 1));
            frmDuzenle.txtAlisOndalik.Text = Convert.ToString((Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value) % 1) * 100);
            frmDuzenle.txtAKDV.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value));
            frmDuzenle.txtSatisFiy.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[7].Value) - (Convert.ToDouble(dataGridView1.CurrentRow.Cells[7].Value) % 1));
            frmDuzenle.txtSatisOndalik.Text = Convert.ToString((Convert.ToDouble(dataGridView1.CurrentRow.Cells[7].Value) % 1) * 100);
            frmDuzenle.txtSKDV.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value));
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString()=="True")
                frmDuzenle.checkBoxTartilabilir.Checked = true;
            else
                frmDuzenle.checkBoxTartilabilir.Checked = false;
            frmDuzenle.cmbOlcuBirim.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmDuzenle.rtxtAciklama.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            if(chkKategori.Checked == true)
            {
                cmbKategori.Enabled = true;
                cmbKategori.Text = "Kategori Seçiniz";
            }
            else
            {
                cmbKategori.Enabled = false;
                cmbKategori.Text = "";
            }
        }

        private void chkTartilabilir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTartilabilir.Checked == true)
            {
                radEvet.Enabled = true;
                radHayir.Enabled = true;
            }
            else
            {
                radEvet.Checked = false;
                radEvet.Enabled = false;
                radHayir.Checked = false;
                radHayir.Enabled = false;
            }
        }

        private void radBarkodNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radBarkodNo.Checked == true)
            {
                txtAra.Text = "";
                lblArananAlan.Text = "Barkod No:";
                txtAra.Focus();
            }
        }

        private void radUrunAd_CheckedChanged(object sender, EventArgs e)
        {
            if(radUrunAd.Checked == true)
            {
                txtAra.Text = "";
                lblArananAlan.Text = "Ürün Adı:";
                txtAra.Focus();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }
    }
}
