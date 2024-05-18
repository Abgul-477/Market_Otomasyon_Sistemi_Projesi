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
    public partial class Personel_Islemleri_Menusu : Form
    {
        public Personel_Islemleri_Menusu()
        {
            InitializeComponent();
        }

        public void BirimYukle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT BirimAd From Birimler";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbBirimAra.Items.Add(dr["BirimAd"]);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Yükle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM PersonelTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "PersonelTablosu");
                dataGridView1.DataSource = ds.Tables["PersonelTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi");
            }
        }

        public void KayitAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From PersonelTablosu";
                string SorguSoyad = "Select * From PersonelTablosu Where Soyad='" + txtSoyadAra.Text + "'";
                string SorguDYer = "Select * From PersonelTablosu Where il='" + cmbIlAra.Text + "'";
                string sorguBirim = "Select * From PersonelTablosu Where Yetki='" + cmbBirimAra.Text + "'";
                string SorguSoyadDYer = "Select * From PersonelTablosu Where Soyad='" + txtSoyadAra.Text + "' And il='" + cmbIlAra.Text + "'";
                string SorguSoyadBirim = "Select * From PersonelTablosu Where Soyad='" + txtSoyadAra.Text + "' And Yetki='" + cmbBirimAra.Text + "'";
                string SorguDYerBirim = "Select * From PersonelTablosu Where il='" + cmbIlAra.Text + "' And Yetki='" + cmbBirimAra.Text + "'";
                string SorguSoyadDyerBirim = "Select * From PersonelTablosu Where Soyad='" + txtSoyadAra.Text + "' And il='" + cmbIlAra.Text + "' And Yetki='" + cmbBirimAra.Text + "'";

                if (chkDYeri.Checked == true && chkSoyad.Checked == true && chkBirim.Checked == true)
                    SorguTum = SorguSoyadDyerBirim;
                else if (chkBirim.Checked == true && chkDYeri.Checked == true)
                    SorguTum = SorguDYerBirim;
                else if (chkBirim.Checked == true && chkSoyad.Checked == true)
                    SorguTum = SorguSoyadBirim;
                else if (chkSoyad.Checked == true && chkDYeri.Checked == true)
                    SorguTum = SorguSoyadDYer;
                else if (chkBirim.Checked == true)
                    SorguTum = sorguBirim;
                else if (chkDYeri.Checked == true)
                    SorguTum = SorguDYer;
                else if (chkSoyad.Checked == true)
                    SorguTum = SorguSoyad;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "PersonelTablosu");
                dataGridView1.DataSource = ds.Tables["PersonelTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HizliAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From PersonelTablosu";
                string SorguTCnoBas = "Select * From PersonelTablosu Where TCno Like '" + txtAra.Text + "%'";
                string SorguTCnoBit = "Select * From PersonelTablosu Where TCno Like '%" + txtAra.Text + "'";
                string SorguTCnoIc = "Select * From PersonelTablosu Where TCno Like '%" + txtAra.Text + "%'";
                string SorguSoyadBas = "Select * From PersonelTablosu Where Soyad Like '" + txtAra.Text + "%'";
                string SorguSoyadBit = "Select * From PersonelTablosu Where Soyad Like '%" + txtAra.Text + "'";
                string SorguSoyadIc = "Select * From PersonelTablosu Where Soyad Like '%" + txtAra.Text + "%'";

                /*if (cmbAramaTuru.Text == "İle Başlayan" && radTCno.Checked == true)
                    SorguTum = SorguTCnoBas;
                else if (cmbAramaTuru.Text == "İle Biten" && radTCno.Checked == true)
                    SorguTum = SorguTCnoBit;
                else if (cmbAramaTuru.Text == "İçeren" && radTCno.Checked == true)
                    SorguTum = SorguTCnoIc;
                else if (cmbAramaTuru.Text == "İle Başlayan" && radSoyad.Checked == true)
                    SorguTum = SorguSoyadBas;
                else if (cmbAramaTuru.Text == "İle Biten" && radSoyad.Checked == true)
                    SorguTum = SorguSoyadBit;
                else if (cmbAramaTuru.Text == "İçeren" && radSoyad.Checked == true)
                    SorguTum = SorguSoyadIc;*/

                if (radTCno.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguTCnoBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguTCnoBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguTCnoIc;
                }
                else if (radSoyad.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                        SorguTum = SorguSoyadBas;
                    else if (cmbAramaTuru.Text == "İle Biten")
                        SorguTum = SorguSoyadBit;
                    else if (cmbAramaTuru.Text == "İçeren")
                        SorguTum = SorguSoyadIc;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "PersonelTablosu");
                dataGridView1.DataSource = ds.Tables["PersonelTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hizli Ara Hata Penceresi");
            }
        }

        private void Personel_Islemleri_Menusu_Load(object sender, EventArgs e)
        {
            KayitListele();
            BirimYukle();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            PersonelKayıtEkleForm frmEkle = new PersonelKayıtEkleForm();
            frmEkle.ShowDialog();
        }

        private void Personel_Islemleri_Menusu_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            KayitListele();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "PersonelID";
            KayitSilForm1.Tablo = "PersonelTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Personel Kayıt Sil";
            FrmSil.lbl1.Text = "PersonelID";
            FrmSil.lbl2.Text = "TCno";
            FrmSil.lbl3.Text = "Ad";
            FrmSil.lbl4.Text = "Soyad";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked == true)
            {
                txtSoyadAra.Text = "";
                txtSoyadAra.Enabled = true;
                txtSoyadAra.Focus();
            }
            if (chkSoyad.Checked == false)
            {
                txtSoyadAra.Enabled = false;
                txtSoyadAra.Text = "";
            }
        }

        private void chkDYeri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDYeri.Checked == true)
            {
                cmbIlAra.Enabled = true;
                cmbIlAra.Text = "İl Seciniz";
            }
            if (chkDYeri.Checked == false)
            {
                cmbIlAra.Enabled = false;
                cmbIlAra.Text = "";
            }
        }

        private void chkBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBirim.Checked == true)
            {
                cmbBirimAra.Enabled = true;
                cmbBirimAra.Text = "Birim Seçiniz";
            }
            if (chkBirim.Checked == false)
            {
                cmbBirimAra.Enabled = false;
                cmbBirimAra.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            PersonelKayitDuzenleForm frmDuzenle = new PersonelKayitDuzenleForm();
            frmDuzenle.txtPerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzenle.txtTCno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzenle.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzenle.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmDuzenle.radErkek.Checked = true;
            else
                frmDuzenle.radKadin.Checked = true;
            frmDuzenle.cmbBirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmDuzenle.dtpIseBaslamaTar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "True")
                frmDuzenle.chkAktif.Checked = true;
            frmDuzenle.txtEMail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmDuzenle.txtCepTel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmDuzenle.txtSabitTel.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmDuzenle.txtNetMaas.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value).ToString();
            frmDuzenle.txtPrim.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[12].Value).ToString();
            frmDuzenle.txtIskonto.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[13].Value).ToString();
            frmDuzenle.cmbIl.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frmDuzenle.cmbIlce.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frmDuzenle.txtAdres.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frmDuzenle.ShowDialog();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void radTCno_CheckedChanged(object sender, EventArgs e)
        {
            if(radTCno.Checked == true)
            {
                txtAra.Text = "";
                lblArananAlan.Text = "TCno:";
                txtAra.Focus();
            }
        }

        private void radSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoyad.Checked == true)
            {
                txtAra.Text = "";
                lblArananAlan.Text = "Soyad:";
                txtAra.Focus();
            }
        }
    }
}
