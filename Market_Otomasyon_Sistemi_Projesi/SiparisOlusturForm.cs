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
    public partial class SiparisOlusturForm : Form
    {
        public SiparisOlusturForm()
        {
            InitializeComponent();
        }

        public void SiparisOlustur()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO SiparisTablosu (TedarikciID,UrunID,Miktar,OlusturmaTar,Tarih,Durum,Aciklama) Values (@TedarikciID,@UrunID,@Miktar,@OlusturmaTar,@Tarih,@Durum,@Aciklama)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@TedarikciID", cmbTedarikci.Text);
                EkleKomut.Parameters.AddWithValue("@UrunID", cmbUrun.Text);
                EkleKomut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                EkleKomut.Parameters.AddWithValue("@OlusturmaTar", DateTime.Now);
                EkleKomut.Parameters.AddWithValue("@Tarih", dtpBekTar.Value);
                EkleKomut.Parameters.AddWithValue("@Durum", "Ulasmadi");
                EkleKomut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Sipariş Oluşturuldu", "Siparis Olustur Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Siparis Olustur Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BoslukKontrol()
        {
            bool Bos = false;
            yildizTedarikci.Visible = false;
            yildizUrun.Visible = false;
            yildizBirim.Visible = false;
            yildizBekTar.Visible = false;
            yildizAciklama.Visible = false;

            if (dtpBekTar.Value == DateTime.Now.Date)
            {
                yildizBekTar.Visible = true;
                Bos = false;
            }
            if (txtMiktar.Text == "")
            {
                txtMiktar.Focus();
                yildizBirim.Visible = true;
                Bos = false;
            }
            if (cmbUrun.Text == "Ürün Seçiniz" || cmbUrun.Text == "")
            {
                yildizUrun.Visible = true;
                Bos = true;
            }
            if (cmbTedarikci.Text == "Tedarikçi Seçiniz" || cmbTedarikci.Text == "")
            {
                yildizTedarikci.Visible = true;
                Bos = true;
            }

            return Bos;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                SiparisOlustur();
        }
    }
}
