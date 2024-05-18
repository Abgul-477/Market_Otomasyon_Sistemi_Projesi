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
    public partial class Musteri_Islemleri_Menusu : Form
    {
        public Musteri_Islemleri_Menusu()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM MusteriTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "MusteriTablosu");
                dataGridView1.DataSource = ds.Tables["MusteriTablosu"];
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
                string TumSorgu = "SELECT * FROM MusteriTablosu";
                string SoyadSorgu = "SELECT * FROM MusteriTablosu where Soyad='"+txtSoyadAra.Text+"'";
                string ilSorgu = "SELECT * FROM MusteriTablosu where il='"+cmbIlAra.Text+"'";
                string CinsiyetSorgu;
                string SoyadilSorgu = "SELECT * FROM MusteriTablosu where Soyad='" + txtSoyadAra.Text + "' AND il='" + cmbIlAra.Text + "'";
                string SoyadCinsiyetSorgu;
                string CinsiyetilSorgu;
                string SoyadilCinsiyetSorgu;
                if (radErkek.Checked == true)
                {
                    CinsiyetSorgu = "SELECT * FROM MusteriTablosu where Cinsiyet='Erkek'";
                    SoyadCinsiyetSorgu = "SELECT * FROM MusteriTablosu where Soyad='" + txtSoyadAra.Text + "' AND Cinsiyet='Erkek'";
                    CinsiyetilSorgu = "SELECT * FROM MusteriTablosu where Cinsiyet='Erkek' AND il='" + cmbIlAra.Text + "'";
                    SoyadilCinsiyetSorgu = "SELECT * FROM MusteriTablosu where Soyad='" + txtSoyadAra.Text + "' AND il='" + cmbIlAra.Text + "' AND Cinsiyet='Erkek'";
                }
                else
                {
                    CinsiyetSorgu = "SELECT * FROM MusteriTablosu where Cinsiyet='Kadin'";
                    SoyadCinsiyetSorgu = "SELECT * FROM MusteriTablosu where Soyad='" + txtSoyadAra.Text + "' AND Cinsiyet='Kadin'";
                    CinsiyetilSorgu = "SELECT * FROM MusteriTablosu where Cinsiyet='Kadin' AND il='" + cmbIlAra.Text + "'";
                    SoyadilCinsiyetSorgu = "SELECT * FROM MusteriTablosu where Soyad='" + txtSoyadAra.Text + "' AND il='" + cmbIlAra.Text + "' AND Cinsiyet='Kadin'";
                }
                if (chkCinsiyet.Checked == true && chkDYeri.Checked == true && chkSoyad.Checked == true)
                    TumSorgu = SoyadilCinsiyetSorgu;
                else if (chkSoyad.Checked == true && chkDYeri.Checked == true)
                    TumSorgu = SoyadilSorgu;
                else if (chkCinsiyet.Checked == true && chkDYeri.Checked == true)
                    TumSorgu = CinsiyetilSorgu;
                else if (chkSoyad.Checked == true && chkCinsiyet.Checked == true)
                    TumSorgu = SoyadCinsiyetSorgu;
                else if (chkCinsiyet.Checked == true)
                    TumSorgu = CinsiyetSorgu;
                else if (chkDYeri.Checked == true)
                    TumSorgu = ilSorgu;
                else if (chkSoyad.Checked == true)
                    TumSorgu = SoyadSorgu;
                SqlDataAdapter da = new SqlDataAdapter(TumSorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "MusteriTablosu");
                dataGridView1.DataSource = ds.Tables["MusteriTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HizliAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From MusteriTablosu";
                string SorguTCnoBas = "Select * From MusteriTablosu Where TCno Like '" + txtAra.Text + "%'";
                string SorguTCnoBit = "Select * From MusteriTablosu Where TCno Like '%" + txtAra.Text + "'";
                string SorguTCnoIc = "Select * From MusteriTablosu Where TCno Like '%" + txtAra.Text + "%'";
                string SorguSoyadBas = "Select * From MusteriTablosu Where Ad Like '" + txtAra.Text + "%'";
                string SorguSoyadBit = "Select * From MusteriTablosu Where Ad Like '%" + txtAra.Text + "'";
                string SorguSoyadIc = "Select * From MusteriTablosu Where Ad Like '%" + txtAra.Text + "%'";


                if (radTCno.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguTCnoBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguTCnoBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguTCnoIc;
                }
                else if (radAd.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguSoyadBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguSoyadBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguSoyadIc;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "MusteriTablosu");
                dataGridView1.DataSource = ds.Tables["MusteriTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hizli Ara Hata Penceresi");
            }
        }

        private void Musteri_Islemleri_Menusu_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            MusteriKayitForm frmKayit = new MusteriKayitForm();
            frmKayit.ShowDialog();
        }

        private void Musteri_Islemleri_Menusu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "MusteriID";
            KayitSilForm1.Tablo = "MusteriTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Müsteri Kayıt Sil";
            FrmSil.lbl1.Text = "MusteriID";
            FrmSil.lbl2.Text = "TCno";
            FrmSil.lbl3.Text = "Ad";
            FrmSil.lbl4.Text = "Soyad";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            MusterKayitDuzenleForm frmDuzen = new MusterKayitDuzenleForm();

            frmDuzen.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.txtTCno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzen.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzen.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmDuzen.radErkek.Checked = true;
            else
                frmDuzen.radKadin.Checked = true;
            frmDuzen.txtEMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmDuzen.txtCepTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmDuzen.txtSabitTel.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmDuzen.cmbIl.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmDuzen.cmbIlce.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmDuzen.txtAdres.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            frmDuzen.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSoyad.Checked == true)
            {
                txtSoyadAra.Text = "";
                txtSoyadAra.Enabled = true;
            }
            else if(chkSoyad.Checked == false)
            {
                txtSoyadAra.Text = "";
                txtSoyadAra.Enabled = false;
            }
        }

        private void chkDYeri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDYeri.Checked==true)
            {
                cmbIlAra.Enabled = true;
                cmbIlAra.Text = "İl Seçiniz";
            }
            else if(chkDYeri.Checked == false)
            {
                cmbIlAra.Enabled = false;
                cmbIlAra.Text = "";
            }
        }

        private void chkCinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCinsiyet.Checked == true)
            {
                radErkek.Enabled = true;
                radKadin.Enabled = true;
            }
            else
            {
                radErkek.Checked = false;
                radErkek.Enabled = false;
                radKadin.Checked = false;
                radKadin.Enabled = false;
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void radTCno_CheckedChanged(object sender, EventArgs e)
        {
            if (radTCno.Checked == true)
            {
                lblArananAlan.Text = "TC no:";
                txtAra.Text = "";
                txtAra.Focus();
            }
        }

        private void radAd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAd.Checked == true)
            {
                lblArananAlan.Text = "Ad:";
                txtAra.Text = "";
                txtAra.Focus();
            }
        }
    }
}
