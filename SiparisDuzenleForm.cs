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
    public partial class SiparisDuzenleForm : Form
    {
        public SiparisDuzenleForm()
        {
            InitializeComponent();
        }

        public void SiparisDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "UPDATE SiparisTablosu set TedarikciID=@TedarikciID,UrunID=@UrunID,Miktar=@Miktar,Tarih=@Tarih,Aciklama=@Aciklama where SiparisID=@SiparisID";
                string Sorgu1 = "UPDATE SiparisTablosu set TedarikciID=@TedarikciID,UrunID=@UrunID,Miktar=@Miktar,Tarih=@Tarih,UlasmaTar=@UlasmaTar,Aciklama=@Aciklama where SiparisID=@SiparisID";
                if (radUlasti.Checked == true)
                    Sorgu = Sorgu1;
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@TedarikciID", cmbTedarikci.Text);
                EkleKomut.Parameters.AddWithValue("@UrunID", cmbUrun.Text);
                EkleKomut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                EkleKomut.Parameters.AddWithValue("@Tarih", dtpBekTar.Value);
                if (radUlasti.Checked==true)
                {
                    EkleKomut.Parameters.AddWithValue("@UlasmaTar", dtpUlasmaTar.Value);
                }
                EkleKomut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                EkleKomut.Parameters.AddWithValue("@SiparisID", txtSiparisID.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Sipariş Düzenlendi", "Sipariş Düzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Siparis Düzenle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SiparisDuzenle();
        }
    }
}
