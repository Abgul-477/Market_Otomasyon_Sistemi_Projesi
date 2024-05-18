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
    public partial class PersonelKayıtEkleForm : Form
    {
        public PersonelKayıtEkleForm()
        {
            InitializeComponent();
        }

        public void BirimYukle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "SELECT BirimAd From Birimler";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while(dr.Read())
                {
                    cmbBirim.Items.Add(dr["BirimAd"]);
                }
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Yükle Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void PersonelKayıtEkleForm_Load(object sender, EventArgs e)
        {
            BirimYukle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIskonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNetMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radPasif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radAktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblIskonto_Click(object sender, EventArgs e)
        {

        }

        private void lblPrim_Click(object sender, EventArgs e)
        {

        }

        private void lblNetMaas_Click(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblIseBaslamaTar_Click(object sender, EventArgs e)
        {

        }

        public void KayitEkle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "INSERT INTO PersonelTablosu (TCno,Ad,Soyad,Cinsiyet,Yetki,iseBaslamaTar,Durum,email,CepTel,SabitTel,NetMaas,Prim,Iskonto,il,ilce,Adres) Values (@TCno,@Ad,@Soyad,@Cinsiyet,@Yetki,@iseBaslamaTar,@Durum,@email,@CepTel,@SabitTel,@NetMaas,@Prim,@Iskonto,@il,@ilce,@Adres)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@TCno", txtTCno.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                if (radErkek.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radErkek.Text);
                if (radKadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", radKadin.Text);
                EkleKomut.Parameters.AddWithValue("@Yetki", cmbBirim.Text);
                EkleKomut.Parameters.AddWithValue("@iseBaslamaTar", dtpIseBaslamaTar.Value);
                if (chkAktif.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", 1);
                else
                    EkleKomut.Parameters.AddWithValue("@Durum", 0);
                EkleKomut.Parameters.AddWithValue("@email",txtEMail.Text);
                EkleKomut.Parameters.AddWithValue("@CepTel",txtCepTel.Text);
                EkleKomut.Parameters.AddWithValue("@SabitTel",txtSabitTel.Text);
                EkleKomut.Parameters.AddWithValue("@NetMaas", Convert.ToDouble(txtNetMaas.Text));
                EkleKomut.Parameters.AddWithValue("@Prim", Convert.ToDouble(txtPrim.Text));
                EkleKomut.Parameters.AddWithValue("@Iskonto",Convert.ToDouble(txtIskonto.Text));
                EkleKomut.Parameters.AddWithValue("@il",cmbIl.Text);
                EkleKomut.Parameters.AddWithValue("@ilce",cmbIlce.Text);
                EkleKomut.Parameters.AddWithValue("@Adres",txtAdres.Text);
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
            YildizIl.Visible = false;
            YildizIlce.Visible = false;
            YildizCepTel.Visible = false;
            YildizSabitTel.Visible = false;
            YildizIseBasTar.Visible = false;
            YildizYetki.Visible = false;
            YildizMaas.Visible = false;

            if (txtNetMaas.Text.Length < 4)
            {
                txtNetMaas.Focus();
                YildizMaas.Visible = true;
                Bos = true;
            }
            if (cmbBirim.Text == "Yetki Seçiniz" || cmbBirim.Text == "")
            {
                YildizYetki.Visible = true;
                Bos = true;
            }
            if (dtpIseBaslamaTar.Text == "")
            {
                YildizIseBasTar.Visible = true;
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
            if (txtAdres.Text == "")
            {
                txtAdres.Focus();
                YildizAdres.Visible = true;
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
            if (radErkek.Checked == false && radKadin.Checked == false)
            {
                YildizCinsiyet.Visible = true;
                Bos = true;
            }
            if (txtSoyad.Text=="")
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
             if (txtPrim.Text == "")
                txtPrim.Text = "00";
            if (txtIskonto.Text == "")
                txtIskonto.Text = "00";
            if (BoslukKontrol())
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılamaz", "Bosluk Kontrol Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTCno.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEMail.Text = "";
            txtCepTel.Text = "";
            txtSabitTel.Text = "";
            dtpIseBaslamaTar.Value = DateTime.Today.Date;
            cmbBirim.Text = "Yetki Seçiniz";
            txtNetMaas.Text = "";
            txtPrim.Text = "";
            txtIskonto.Text = "";
            chkAktif.Checked = false;
            cmbIl.Text = "İl Seçiniz";
            cmbIlce.Text = "İlçe Seçiniz";
            txtAdres.Text = "";
        }
    }
}