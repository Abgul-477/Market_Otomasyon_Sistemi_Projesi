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
    public partial class TedarikciTemsilcikayitDuzenleForm : Form
    {
        public TedarikciTemsilcikayitDuzenleForm()
        {
            InitializeComponent();
        }

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "UPDATE TedTemsilciTablosu set TCno=@TCno,Ad=@Ad,Soyad=@Soyad,email=@email,CepTel=@CepTel,SabitTel=@SabitTel,Adres=@Adres,Tedarikci=@Tedarikci where TemsilciID=@TemsilciID";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@TCno", txtTCno.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@email", txtEMail.Text);
                EkleKomut.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                EkleKomut.Parameters.AddWithValue("@SabitTel", txtSabitTel.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                EkleKomut.Parameters.AddWithValue("@Tedarikci", cmbTedarikci.Text);
                EkleKomut.Parameters.AddWithValue("@TemsilciID", txtTemsilciID.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Düzenlendi", "Kayit Düzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitDuzenle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BoslukKontrol()
        {
            bool Bos = false;

            YildizTc.Visible = false;
            YildizAd.Visible = false;
            YildizSoyad.Visible = false;
            YildizCepTel.Visible = false;
            YildizSabitTel.Visible = false;
            YildizAdres.Visible = false;

            if (txtAdres.Text == "")
            {
                txtAdres.Focus();
                YildizAdres.Visible = true;
                Bos = true;
            }
            if (cmbTedarikci.Text == "Tedarikçi Seçiniz" || cmbTedarikci.Text == "")
            {
                YildizTedarikci.Visible = true;
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

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitDuzenle();
        }
    }
}
