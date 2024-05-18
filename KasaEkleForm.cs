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
    public partial class KasaEkleForm : Form
    {
        public KasaEkleForm()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Insert Into KasaTablosu (KasaAd,Durum) Values (@KasaAd,@Durum)";
                SqlCommand KayitEkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                KayitEkleKomut.Parameters.AddWithValue("@KasaAd", txtKasaAd.Text);
                if (radAktif.Checked == true)
                    KayitEkleKomut.Parameters.AddWithValue("@Durum", 1);
                if (radPasif.Checked == true)
                    KayitEkleKomut.Parameters.AddWithValue("@Durum", 0);
                if(KayitEkleKomut.ExecuteNonQuery()==1)
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
            bool bos = false;
            YildizAd.Visible = false;
            YildizDurum.Visible = false;
            if (radAktif.Checked == false && radPasif.Checked == false)
            {
                YildizDurum.Visible = true;
                bos = true;
            }
            if (txtKasaAd.Text == "")
            {
                txtKasaAd.Focus();
                YildizAd.Visible = true;
                bos = true;
            }

            return bos;
        }

        private void KasaEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }
    }
}
