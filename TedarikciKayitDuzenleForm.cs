﻿using System;
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
    public partial class TedarikciKayitDuzenleForm : Form
    {
        public TedarikciKayitDuzenleForm()
        {
            InitializeComponent();
        }

        public void KayitDuzenle()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "UPDATE TedarikciTablosu set VergiNo=@VergiNo,Ad=@Ad,TelNo=@TelNo,eposta=@eposta,FaksNo=@FaksNo,Adres=@Adres,Durum=@Durum,TemsilciID=@TemsilciID where TedarikciID=@TedarikciID";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                EkleKomut.Parameters.AddWithValue("@VergiNo", txtVergiNo.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
                EkleKomut.Parameters.AddWithValue("@eposta", txtEMail.Text);
                EkleKomut.Parameters.AddWithValue("@FaksNo", txtFaksNo.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                if (radAktif.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", true);
                else if (radPasif.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Durum", false);
                EkleKomut.Parameters.AddWithValue("@TemsilciID", txtTemsilciID.Text);
                EkleKomut.Parameters.AddWithValue("@TedarikciID", txtTedID.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Duzenlendi", "Kayit Duzenle Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            yildizVergiNo.Visible = false;
            yildizAd.Visible = false;
            yildizTelNo.Visible = false;
            yildizEposta.Visible = false;
            yildizFaksNo.Visible = false;
            yildizAdres.Visible = false;
            yildizDurum.Visible = false;
            yildizTemID.Visible = false;

            if (txtTemsilciID.Text == "")
            {
                txtTemsilciID.Focus();
                yildizTemID.Visible = true;
                Bos = true;
            }
            if (radAktif.Checked == false && radPasif.Checked == false)
            {
                yildizDurum.Visible = true;
                Bos = true;
            }
            if (txtAdres.Text == "")
            {
                txtAdres.Focus();
                yildizAdres.Visible = true;
                Bos = true;
            }
            if (txtFaksNo.Text.Length < 14)
            {
                txtFaksNo.Focus();
                yildizFaksNo.Visible = true;
                Bos = true;
            }
            if (txtEMail.Text == "")
            {
                txtEMail.Focus();
                yildizEposta.Visible = true;
                Bos = true;
            }
            if (txtTelNo.Text.Length < 14)
            {
                txtTelNo.Focus();
                yildizTelNo.Visible = true;
                Bos = true;
            }
            if (txtAd.Text == "")
            {
                txtAd.Focus();
                yildizAd.Visible = true;
                Bos = true;
            }
            if (txtVergiNo.Text.Length < 10)
            {
                txtVergiNo.Focus();
                yildizVergiNo.Visible = true;
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
