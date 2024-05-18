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
    public partial class UrunEkleEkrani : Form
    {
        public UrunEkleEkrani()
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

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO Urun_Tablosu (UrunAd,Kategori,BarkodNo,MinStok,AlisFiyati,AlisKDV,SatisFiyat,SatisKDV,Tartilabilir,OlcuBirim,Aciklama) Values (@UrunAd,@Kategori,@BarkodNo,@MinStok,@AlisFiyati,@AlisKDV,@SatisFiyat,@SatisKDV,@Tartilabilir,@OlcuBirim,@Aciklama)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@UrunAd", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                EkleKomut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
                EkleKomut.Parameters.AddWithValue("@MinStok", txtMinStok.Text);
                EkleKomut.Parameters.AddWithValue("@AlisFiyati", (Convert.ToDouble(txtAlisFiy.Text) + Convert.ToDouble(txtAlisOndalik.Text) / 100));
                EkleKomut.Parameters.AddWithValue("@AlisKDV", txtAKDV.Text);
                EkleKomut.Parameters.AddWithValue("@SatisFiyat", (Convert.ToDouble(txtSatisFiy.Text) + Convert.ToDouble(txtSatisOndalik.Text) / 100));
                EkleKomut.Parameters.AddWithValue("@SatisKDV", txtSKDV.Text);
                if (checkBoxTartilabilir.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Tartilabilir", true);
                else
                    EkleKomut.Parameters.AddWithValue("@Tartilabilir", false);
                EkleKomut.Parameters.AddWithValue("@OlcuBirim", cmbOlcuBirim.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtxtAciklama.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Kayit Ekle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitEkle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BoslukKontrol()
        {
            bool Bos = false;

            lblUrunAdiUyar.Visible = false;
            lblKategoriUyar.Visible = false;
            lblBarkodUyar.Visible = false;
            lblAlisFiyUyar.Visible = false;
            lblAKDVUyar.Visible = false;
            lblSatisFiyUyar.Visible = false;
            lblSKDVUyar.Visible = false;

            if (cmbOlcuBirim.Text == ""||cmbOlcuBirim.Text == "Ölçü Birimi Seçiniz")
            {
                yildizOlcuBirim.Visible = true;
                Bos = true;
            }
            if (txtSKDV.Text == "")
            {
                txtSKDV.Focus();
                lblSKDVUyar.Visible = true;
                Bos = true;
            }
            if (txtSatisFiy.Text == "")
            {
                txtSatisFiy.Focus();
                lblSatisFiyUyar.Visible = true;
                Bos = true;
            }
            if (txtAKDV.Text == "")
            {
                txtAKDV.Focus();
                lblAKDVUyar.Visible = true;
                Bos = true;
            }
            if (txtAlisFiy.Text == "")
            {
                txtAlisFiy.Focus();
                lblAlisFiyUyar.Visible = true;
                Bos = true;
            }
            if (txtBarkod.Text.Length < 11)
            {
                txtBarkod.Focus();
                lblBarkodUyar.Visible = true;
                Bos = true;
            }
            if (cmbKategori.Text == "" || cmbKategori.Text == "Kategori Seçiniz")
            {
                lblKategoriUyar.Visible = true;
                Bos = true;
            }
            if (txtAd.Text == "")
            {
                txtAd.Focus();
                lblUrunAdiUyar.Visible = true;
                Bos = true;
            }

            return Bos;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if(txtSatisOndalik.Text=="" && txtAlisOndalik.Text=="")
            {
                txtSatisOndalik.Text = "00";
                txtAlisOndalik.Text = "00";
            }
            else if(txtSatisOndalik.Text=="")
                txtSatisOndalik.Text = "00";
            else if(txtAlisOndalik.Text == "")
                txtAlisOndalik.Text = "00";

            if (BoslukKontrol()==false)
            {
                KayitEkle();
            }
            else
                MessageBox.Show("Lütfen Yıldızlı Alanları Doldurunuz!", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UrunEkleEkrani_Load(object sender, EventArgs e)
        {
            KategoriYukle();
        }
    }
}
