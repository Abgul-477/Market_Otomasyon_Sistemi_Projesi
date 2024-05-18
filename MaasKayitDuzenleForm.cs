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
    public partial class MaasKayitDuzenleForm : Form
    {
        public MaasKayitDuzenleForm()
        {
            InitializeComponent();
        }

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "UPDATE MaasTablosu set PersonelID=@PersonelID,MaasTutar=@MaasTutar,Prim=@Prim,Iskonto=@Iskonto,Durum=@Durum,OdemeGunu=@OdemeGunu where MaasID=@MaasID";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@PersonelID", cmbPersonelID.Text);
                EkleKomut.Parameters.AddWithValue("@MaasTutar", txtMaasTutar.Text);
                EkleKomut.Parameters.AddWithValue("@Prim", txtPrim.Text);
                EkleKomut.Parameters.AddWithValue("@Iskonto", txtIskonto.Text);
                if (radAktif.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", true);
                if (radPasif.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", false);
                EkleKomut.Parameters.AddWithValue("@OdemeGunu", cmbOdemeGunu.Text);
                EkleKomut.Parameters.AddWithValue("@MaasID", txtMaasID.Text);
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

            yildizPersonelID.Visible = false;
            yildizMaasTutar.Visible = false;
            yildizPrim.Visible = false;
            yildizIskonto.Visible = false;
            yildizDurum.Visible = false;
            yildizOdemeGunu.Visible = false;

            if (cmbOdemeGunu.Text == "")
            {
                yildizOdemeGunu.Visible = true;
                Bos = true;
            }
            if (radAktif.Checked == false && radPasif.Checked == false)
            {
                yildizDurum.Visible = true;
                Bos = true;
            }
            if (txtIskonto.Text == "")
            {
                yildizIskonto.Visible = true;
                txtIskonto.Focus();
                Bos = true;
            }
            if (txtPrim.Text == "")
            {
                txtPrim.Focus();
                yildizPrim.Visible = true;
                Bos = true;
            }
            if (txtMaasTutar.Text == "")
            {
                txtMaasTutar.Focus();
                yildizMaasTutar.Visible = true;
                Bos = true;
            }
            if (cmbPersonelID.Text == "" || cmbPersonelID.Text == "Personel Seçiniz")
            {
                yildizPersonelID.Visible = true;
                Bos = true;
            }
            return Bos;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Lütfen Yıldızlı Alanları Doldurunuz!", "Boşluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitDuzenle();
        }
    }
}
