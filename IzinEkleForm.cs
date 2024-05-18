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
    public partial class IzinEkleForm : Form
    {
        public IzinEkleForm()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO IzinTablosu (PersonelID,IzinBaslangicTar,IzinBitisTar,Gerekce,Durum,Aciklama) Values (@PersonelID,@IzinBaslangicTar,@IzinBitisTar,@Gerekce,@Durum,@Aciklama)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@PersonelID", cmbPersonel.Text);
                EkleKomut.Parameters.AddWithValue("@IzinBaslangicTar", dtpBasTar.Value);
                EkleKomut.Parameters.AddWithValue("@IzinBitisTar", dtpBitTar.Value);
                EkleKomut.Parameters.AddWithValue("@Gerekce", txtGerekce.Text);
                if (radKabul.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", true);
                else if (radRet.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", false);
                EkleKomut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "KayitEkle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            yildizPersonel.Visible = false;
            yildizBitTar.Visible = false;
            yildizGerekce.Visible = false;
            yildizDurum.Visible = false;
            yildizAciklama.Visible = false;

            if (txtAciklama.Text == "")
            {
                txtAciklama.Focus();
                yildizAciklama.Visible = true;
                Bos = true;
            }
            if (radKabul.Checked == false && radRet.Checked == false)
            {
                yildizDurum.Visible = true;
                Bos = true;
            }
            if (txtGerekce.Text == "")
            {
                yildizGerekce.Visible = true;
                Bos = true;
            }
            if (dtpBitTar.Value.Date   == DateTime.Today.Date)
            {
                yildizBitTar.Visible = true;
                Bos = true;
            }
            if (cmbPersonel.Text == "" || cmbPersonel.Text == "Personel Seçin")
            {
                yildizPersonel.Visible = true;
                Bos = true;
            }
            return Bos;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Boşluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }
    }
}
