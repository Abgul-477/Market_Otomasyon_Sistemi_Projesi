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
    public partial class KayitSilForm1 : Form
    {
        public KayitSilForm1()
        {
            InitializeComponent();
        }

        public static string Tablo;
        public static string ID;

        public void KayitSil()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                string Sorgu = "Delete From "+Tablo+" Where "+ID+" = " + txt1.Text;
                SqlCommand SilKomut = new SqlCommand(Sorgu, Ana_Ekran.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayit Silindi", "Kayit Sil Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayit Sil Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitSilForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            DialogResult ElCevap = MessageBox.Show("Kayıtlı veriyi silmek istiyor musunuz?", "Kayıt Sil Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ElCevap == DialogResult.Yes)
                KayitSil();
        }
    }
}
