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
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        public void KullaniciAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Select * From Kullanicilar where KAdi = @KAdi AND KSifre = @KSifre";

                SqlCommand KullaniciKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                KullaniciKomut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
                KullaniciKomut.Parameters.AddWithValue("@KSifre", txtSifre.Text);

                SqlDataReader dr = KullaniciKomut.ExecuteReader();

                if (dr.Read())      //kullanici adi ve şifre doğru
                {
                    Ana_Ekran.Baglanti.Close();
                    MessageBox.Show("Giriş Başarılı", "Giriş Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ana_Ekran frmAna = new Ana_Ekran();
                    frmAna.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre hatalı", "Kullanici Girisi Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanici Girişi Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKAdi.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Kullanıcı Adı veya Şifre boş geçilemez", "Boşluk Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KullaniciAra();
        }
    }
}
