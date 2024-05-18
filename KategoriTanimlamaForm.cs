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
    public partial class KategoriTanimlamaForm : Form
    {
        public KategoriTanimlamaForm()
        {
            InitializeComponent();
        }

        public void OgeSil()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Delete From " + TabloAdi + " where " + KodAdi + " = '" + silKod + "'";
                SqlCommand SilKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(OgeAdi+" Silindi", OgeAdi + " Sil Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Öğe Sil Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OgeListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From "+TabloAdi;
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, TabloAdi);
                dataGridView1.DataSource = ds.Tables[TabloAdi];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Öğe Listele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OgeEkle() //Personel Tablosuna Formdaki Alanlarda Girilen Verileri Ekler
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Insert Into "+TabloAdi+" ("+AdAdi+") Values (@"+AdAdi+")";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@" + AdAdi, txtAd.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(OgeAdi + " Ekle İşlemi Başarılı", OgeAdi + " Ekle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Öğe Ekle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OgeDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Update " + TabloAdi + " set " + AdAdi + "=@" + AdAdi + " where " + KodAdi + "=@" + KodAdi + "";
                SqlCommand DuzenleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@" + AdAdi, txtAd.Text);
                DuzenleKomut.Parameters.AddWithValue("@" + KodAdi, txtKod.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(OgeAdi + " Düzenleme İşlemi Başarılı", OgeAdi + " Düzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Öğe Düzenle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string TabloAdi;
        public string KodAdi;
        public string AdAdi;
        public string OgeAdi;
        string silKod;

        private void KategoriTanimlamaForm_Load(object sender, EventArgs e)
        {
            OgeListele();
        }

        private void KategoriTanimlamaForm_Activated(object sender, EventArgs e)
        {
            Ana_Ekran.Baglanti.Close();
            OgeListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            OgeDuzenle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKod.Text != "")
                MessageBox.Show("Kayıt eklemeden önce 'Temizle' butonuna basınız", OgeAdi + " Ekle Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtAd.Text != "")
                OgeEkle();
            else
            {
                MessageBox.Show(OgeAdi + " Adını giriniz");
                txtAd.Focus();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKod.Text = "";
            txtAd.Text = "";
            txtAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            silKod = txtKod.Text;

            if (txtKod.Text == "")
                MessageBox.Show("Silmek istediğiniz " + OgeAdi + " seçiniz", OgeAdi + " Sil Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString() + " Kodlu kaydı silmek istediğinize emin misiniz?", OgeAdi + " Sil Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OgeSil();
                }
            }
        }
    }
}
