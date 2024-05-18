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
    public partial class GelirGiderKayitEkleForm : Form
    {
        public GelirGiderKayitEkleForm()
        {
            InitializeComponent();
        }

        public void KategoriYükle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT Ad From GGKategoriTable";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKategori.Items.Add(dr["Ad"]);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kategori Yükle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Insert Into GelirGiderTablosu (KategoriID,Miktar,KisiSinif,KisiID,Vergi,Tarih) Values (@KategoriID,@Miktar,@KisiSinif,@KisiID,@Vergi,@Tarih)";
                SqlCommand KayitEkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                KayitEkleKomut.Parameters.AddWithValue("@KategoriID", cmbKategori.Text);
                KayitEkleKomut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                KayitEkleKomut.Parameters.AddWithValue("@KisiSinif", cmbKisiSinif.Text);
                KayitEkleKomut.Parameters.AddWithValue("@KisiID", cmbKisiID.Text);
                KayitEkleKomut.Parameters.AddWithValue("@Vergi", txtVergi.Text);
                KayitEkleKomut.Parameters.AddWithValue("@Tarih", dtpTarih.Value);
                if (KayitEkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Kayit Ekle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Ekle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false;
            yildizKategori.Visible = false;
            yildizTutar.Visible = false;
            yildizVergi.Visible = false;
            yildizKisiID.Visible = false;
            yildizKisiSinif.Visible = false;

            if (txtVergi.Text == "")
            {
                txtVergi.Focus();
                yildizVergi.Visible = true;
                bos = true;
            }
            if (cmbKisiID.Text == "Kişi Seçiniz" || cmbKisiID.Text == "")
            {
                yildizKisiID.Visible = true;
                bos = true;
            }
            if (cmbKisiSinif.Text == "Sınıf Seçiniz" || cmbKisiSinif.Text == "")
            {
                yildizKisiSinif.Visible = true;
                bos = true;
            }
            if (txtMiktar.Text == "")
            {
                txtMiktar.Focus();
                yildizTutar.Visible = true;
                bos = true;
            }
            if (cmbKategori.Text == "Kategori Seçiniz" || cmbKategori.Text == "")
            {
                yildizKategori.Visible = true;
                bos = true;
            }

            return bos;

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }

        private void GelirGiderKayitEkleForm_Load(object sender, EventArgs e)
        {
            KategoriYükle();
        }
    }
}
