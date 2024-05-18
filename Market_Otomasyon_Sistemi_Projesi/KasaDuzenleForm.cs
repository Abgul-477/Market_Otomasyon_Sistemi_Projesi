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
    public partial class KasaDuzenleForm : Form
    {
        public KasaDuzenleForm()
        {
            InitializeComponent();
        }

        public bool BoslukKontrol()
        {
            bool Bos = false;

            YildizAd.Visible = false;
            YildizDurum.Visible = false;

            if (radAktif.Checked == false && radPasif.Checked == false)
            {
                YildizDurum.Visible = true;
                Bos = true;
            }
            if (txtKasaAd.Text == "")
            {
                YildizAd.Visible = true;
                txtKasaAd.Focus();
                Bos = true;
            }
            return Bos;
        }

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Update KasaTablosu set KasaAd=@KasaAd,Durum=@Durum where KasaID=@KasaID";
                SqlCommand DuzenleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@KasaAd", txtKasaAd.Text);
                if (radPasif.Checked == true)
                    DuzenleKomut.Parameters.AddWithValue("@Durum", false);
                if (radAktif.Checked == true)
                    DuzenleKomut.Parameters.AddWithValue("@Durum", true);
                DuzenleKomut.Parameters.AddWithValue("@KasaID", txtKasaID.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Düzenlendi", "Kayit Duzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitDuzenle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitDuzenle();
        }
    }
}
