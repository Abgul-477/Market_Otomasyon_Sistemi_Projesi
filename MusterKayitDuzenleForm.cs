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
    public partial class MusterKayitDuzenleForm : Form
    {
        public MusterKayitDuzenleForm()
        {
            InitializeComponent();
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

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Update MusteriTablosu set TCno=@TCno,Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,email=@email,CepTel=@CepTel,SabitTel=@SabitTel,il=@il,ilce=@ilce,Adres=@Adres where MusteriID=@MusteriID";
                SqlCommand DuzenleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@TCno", txtTCno.Text);
                DuzenleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                DuzenleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                if (radErkek.Checked == true)
                    DuzenleKomut.Parameters.AddWithValue("@Cinsiyet", radErkek.Text);
                if (radKadin.Checked == true)
                    DuzenleKomut.Parameters.AddWithValue("@Cinsiyet", radKadin.Text);
                DuzenleKomut.Parameters.AddWithValue("@email", txtEMail.Text);
                DuzenleKomut.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                DuzenleKomut.Parameters.AddWithValue("@SabitTel", txtSabitTel.Text);
                DuzenleKomut.Parameters.AddWithValue("@il", cmbIl.Text);
                DuzenleKomut.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                DuzenleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                DuzenleKomut.Parameters.AddWithValue("@MusteriID", txtID.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Düzenlendi", "Kayit Duzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitDuzenle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusterKayitDuzenleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Lütfen Yıldızlı Alanları Doldurunuz!", "Kayıt Butonu Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitDuzenle();
        }
    }
}
