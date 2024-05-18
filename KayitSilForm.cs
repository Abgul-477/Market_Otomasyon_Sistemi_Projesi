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
    public partial class UrunKayitSilForm : Form
    {
        public UrunKayitSilForm()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Delete From Urun_Tablosu Where UrunID = " + txtUrunID.Text;
                SqlCommand SilKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayit Silindi");
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Sil Hata Penceresi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitSil();
        }
    }
}
