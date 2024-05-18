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
    public partial class MusteriKayitForm : Form
    {
        public MusteriKayitForm()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO MusteriTablosu (TCno,Ad,Soyad,Cinsiyet,email,CepTel,SabitTel,il,ilce,Adres) Values (@TCno,@Ad,@Soyad,@Cinsiyet,@email,@CepTel,@SabitTel,@il,@ilce,@Adres)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@TCno", txtTCno.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                if (radErkek.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radErkek.Text);
                if (radKadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radKadin.Text);
                EkleKomut.Parameters.AddWithValue("@email", txtEMail.Text);
                EkleKomut.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                EkleKomut.Parameters.AddWithValue("@SabitTel", txtSabitTel.Text);
                EkleKomut.Parameters.AddWithValue("@il", cmbIl.Text);
                EkleKomut.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
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

            YildizTc.Visible = false;
            YildizAd.Visible = false;
            YildizSoyad.Visible = false;
            YildizCinsiyet.Visible = false;
            YildizEMail.Visible = false;
            YildizAdres.Visible = false;
            YildizIlce.Visible = false;
            YildizIl.Visible = false;
            YildizCepTel.Visible = false;
            YildizSabitTel.Visible = false;

            if (txtAdres.Text == "")
            {
                YildizAdres.Visible = true;
                txtAdres.Focus();
                Bos = true;
            }
            if (cmbIlce.Text == "İlçe Seçiniz" || cmbIlce.Text == "")
            {
                YildizIlce.Visible = true;
                Bos = true;
            }
            if (cmbIl.Text == "İl Seçiniz" || cmbIl.Text == "")
            {
                YildizIl.Visible = true;
                Bos = true;
            }
            if (txtSabitTel.Text.Length < 14)
            {
                txtSabitTel.Focus();
                YildizSabitTel.Visible = true;
                Bos = true;
            }
            if (txtCepTel.Text.Length < 14)
            {
                txtCepTel.Focus();
                YildizCepTel.Visible = true;
                Bos = true;
            }
            if (txtEMail.Text == "")
            {
                txtEMail.Focus();
                YildizEMail.Visible = true;
                Bos = true;
            }
            if (radErkek.Checked == false && radKadin.Checked == false)
            {
                YildizCinsiyet.Visible = true;
                Bos = true;
            }
            if (txtSoyad.Text == "")
            {
                txtSoyad.Focus();
                YildizSoyad.Visible = true;
                Bos = true;
            }
            if (txtAd.Text == "")
            {
                txtAd.Focus();
                YildizAd.Visible = true;
                Bos = true;
            }
            if (txtTCno.Text.Length < 11)
            {
                txtTCno.Focus();
                YildizTc.Visible = true;
                Bos = true;
            }
            return Bos;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }

        private void MusteriKayitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
