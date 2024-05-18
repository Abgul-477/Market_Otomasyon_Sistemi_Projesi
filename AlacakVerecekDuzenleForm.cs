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
    public partial class AlacakVerecekDuzenleForm : Form
    {
        public AlacakVerecekDuzenleForm()
        {
            InitializeComponent();
        }

        public void KategoriYukle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT KategoriAdi From AVKategoriTablosu";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKategoriID.Items.Add(dr["KategoriAdi"]);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kategori Yükle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Update AlacakVerecekTablosu set KategoriID = @KategoriID, Miktar = @Miktar, SonOdemeTarih = @SonOdemeTarih, A_VKisiSinif = @A_VKisiSinif, A_VKisiID = @A_VKisiID, KayitTarih = @KayitTarih where KayitID = @KayitID";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@KategoriID", cmbKategoriID.Text);
                EkleKomut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                EkleKomut.Parameters.AddWithValue("@SonOdemeTarih", dtpSonOdemeTarih.Value);
                EkleKomut.Parameters.AddWithValue("@A_VKisiSinif", cmbA_VKisiSinif.Text);
                EkleKomut.Parameters.AddWithValue("@A_VKisiID", cmbA_VKisiID.Text);
                EkleKomut.Parameters.AddWithValue("@KayitTarih", dtpKayitTarih.Value);
                EkleKomut.Parameters.AddWithValue("@KayitID", txtKayitID.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Düzenlendi", "Kayit Duzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            yildizKategoriID.Visible = false;
            yildizMiktar.Visible = false;
            yildizSonOdemeTarih.Visible = false;
            yildizKisiSinif.Visible = false;
            yildizKisiID.Visible = false;

            if (cmbA_VKisiID.Text == "" || cmbA_VKisiID.Text == "Kişi Seçin")
            {
                yildizKisiID.Visible = true;
                Bos = true;
            }
            if (cmbA_VKisiSinif.Text == "" || cmbA_VKisiSinif.Text == "Sınıf Seçin")
            {
                yildizKisiSinif.Visible = true;
                Bos = true;
            }
            if (dtpSonOdemeTarih.Value.Date == DateTime.Today.Date)
            {
                yildizSonOdemeTarih.Visible = true;
                Bos = true;
            }
            if (txtMiktar.Text == "")
            {
                txtMiktar.Focus();
                yildizMiktar.Visible = true;
                Bos = true;
            }
            if (cmbKategoriID.Text == "" || cmbKategoriID.Text == "Kategori Seçin")
            {
                yildizKategoriID.Visible = true;
                Bos = true;
            }
            return Bos;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Lütfen Yıldızlı Alanları Doldurunuz!", "Boşluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitDuzenle();
        }

        private void AlacakVerecekDuzenleForm_Load(object sender, EventArgs e)
        {
            KategoriYukle();
        }
    }
}
