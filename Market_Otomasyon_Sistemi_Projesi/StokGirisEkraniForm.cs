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
    public partial class StokGirisEkraniForm : Form
    {
        public StokGirisEkraniForm()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO StokTablosu (UrunID,TedarikciID,PersonelID,Miktar,SonGuncellemeTarihi,SKT,Aciklama) Values (@UrunID,@TedarikciID,@PersonelID,@Miktar,@SonGuncellemeTarihi,@SKT,@Aciklama)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@UrunID", cmbUrun.Text);
                EkleKomut.Parameters.AddWithValue("@TedarikciID", cmbTedarikci.Text);
                EkleKomut.Parameters.AddWithValue("@PersonelID", cmbPersonel.Text);
                EkleKomut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                EkleKomut.Parameters.AddWithValue("@SonGuncellemeTarihi", DateTime.Now);
                EkleKomut.Parameters.AddWithValue("@SKT", dtpSKT.Value);
                EkleKomut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
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

            yildizUrunID.Visible = false;
            yildizTedarikciID.Visible = false;
            yildizMiktar.Visible = false;
            yildizSKT.Visible = false;
            yildizAciklama.Visible = false;
            yildizPersonelID.Visible = false;

            if (cmbPersonel.Text == ""|| cmbPersonel.Text == "Personel Seçin")
            {
                yildizPersonelID.Visible = true;
                Bos = true;
            }
            if (txtAciklama.Text == "")
            {
                txtAciklama.Focus();
                yildizAciklama.Visible = true;
                Bos = true;
            }
            if (txtMiktar.Text == "")
            {
                txtMiktar.Focus();
                yildizMiktar.Visible = true;
                Bos = true;
            }
            if (cmbTedarikci.Text == ""||cmbTedarikci.Text == "Tedarikçi Seçin")
            {
                yildizTedarikciID.Visible = true;
                Bos = true;
            }
            if (cmbUrun.Text == ""||cmbUrun.Text == "Ürün Seçiniz")
            {
                cmbUrun.Focus();
                yildizUrunID.Visible = true;
                Bos = true;
            }
            return Bos;
        }

        private void StokGirisEkraniForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStokGirisi_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }
    }
}
