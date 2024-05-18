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
using System.Configuration;

namespace Market_Otomasyon_Sistemi_Projesi
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        /*public static SqlConnection Baglanti;*/

        /*static Ana_Ekran()
        {
            string connectonString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Baglanti = new SqlConnection(connectonString);
        }*/

        public static SqlConnection Baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Market_Otomasyonu_VT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static void BaglantiAc()
        {
            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "BaglantiAc Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musteriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri_Islemleri_Menusu frmMusteri = new Musteri_Islemleri_Menusu();
            frmMusteri.ShowDialog();
        }

        private void personelIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kasaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasaYonetimEkranı frmKasa = new KasaYonetimEkranı();
            frmKasa.ShowDialog();
        }

        private void Ana_Ekran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gelirGiderTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderTablosu frmGelGit = new GelirGiderTablosu();
            frmGelGit.ShowDialog();
        }

        private void alacakVerecekTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlacakVerecekTablosu frmAlVer = new AlacakVerecekTablosu();
            frmAlVer.ShowDialog();
        }

        private void siparisIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisİslemleriForm frmSip = new SiparisİslemleriForm();
            frmSip.ShowDialog();
        }

        private void stokTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokTablosu frmStok = new StokTablosu();
            frmStok.ShowDialog();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Islemleri_Menusu frmPersonel = new Personel_Islemleri_Menusu();
            frmPersonel.ShowDialog();
        }

        private void personelGirisCikisKayitlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelG_CKayitlari frmGC = new PersonelG_CKayitlari();
            frmGC.ShowDialog();
        }

        private void Ana_Ekran_Load(object sender, EventArgs e)
        {
            lblSaat.Text = "Saat: " + DateTime.Now.ToLongTimeString();
            lblTarih.Text = "Tarih: " + DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = "Saat: " + DateTime.Now.ToLongTimeString();
            lblTarih.Text = "Tarih: " + DateTime.Now.ToLongDateString();
        }

        private void sariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun_Yonetimi_Menusu frmUrun = new Urun_Yonetimi_Menusu();
            frmUrun.ShowDialog();
        }

        private void tedarikciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tedarikci_Yonetim_Menusu frmTedarikci = new Tedarikci_Yonetim_Menusu();
            frmTedarikci.ShowDialog();
        }

        private void temsilciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciTemsilciForm frmTemsilci = new TedarikciTemsilciForm();
            frmTemsilci.ShowDialog();
        }

        private void personelMaaşlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaasTablosuForm frmMaas = new MaasTablosuForm();
            frmMaas.ShowDialog();
        }

        private void izinİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzinIslemleriForm frmIslem = new IzinIslemleriForm();
            frmIslem.ShowDialog();
        }

        private void Ana_Ekran_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Cevap = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Uygulanma Kapanış Onay Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Cevap == DialogResult.No)
                e.Cancel = true;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda frmHakkinda = new Hakkinda();
            frmHakkinda.ShowDialog();
        }

        private void birimTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frmBirimTanimlama = new KategoriTanimlamaForm();
            frmBirimTanimlama.TabloAdi = "Birimler";
            frmBirimTanimlama.AdAdi = "BirimAd";
            frmBirimTanimlama.KodAdi = "BirimNo";
            frmBirimTanimlama.OgeAdi = "Birim";
            frmBirimTanimlama.lbl2.Text = "Birim Adı";
            frmBirimTanimlama.lblKod.Text = "Birim Kodu";
            frmBirimTanimlama.Text = "Birim Tanımlama Formu";
            frmBirimTanimlama.ShowDialog();
        }

        private void aVKategoriTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frmAVKTanimlama = new KategoriTanimlamaForm();
            frmAVKTanimlama.TabloAdi = "AVKategoriTablosu";
            frmAVKTanimlama.AdAdi = "KategoriAdi";
            frmAVKTanimlama.KodAdi = "KategoriID";
            frmAVKTanimlama.OgeAdi = "A-V K.";
            frmAVKTanimlama.lbl2.Text = "A-V K. Adı";
            frmAVKTanimlama.lblKod.Text = "A-V K. Kodu";
            frmAVKTanimlama.Text = "A-V K. Tanımlama Formu";
            frmAVKTanimlama.ShowDialog();
        }

        private void gGKTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frmGGKTanimlama = new KategoriTanimlamaForm();
            frmGGKTanimlama.TabloAdi = "GGKategoriTable";
            frmGGKTanimlama.AdAdi = "Ad";
            frmGGKTanimlama.KodAdi = "KategoriID";
            frmGGKTanimlama.OgeAdi = "G-G K.";
            frmGGKTanimlama.lbl2.Text = "G-G K. Adı";
            frmGGKTanimlama.lblKod.Text = "G-G K. Kodu";
            frmGGKTanimlama.Text = "G-G K. Tanımlama Formu";
            frmGGKTanimlama.ShowDialog();
        }

        private void urunKategorisiTanimlanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frmUrunKTanimlama = new KategoriTanimlamaForm();
            frmUrunKTanimlama.TabloAdi = "UrunKategoriTablosu";
            frmUrunKTanimlama.AdAdi = "Ad";
            frmUrunKTanimlama.KodAdi = "ÜrünNo";
            frmUrunKTanimlama.OgeAdi = "ÜrünK.";
            frmUrunKTanimlama.lbl2.Text = "ÜrünK. Adı";
            frmUrunKTanimlama.lblKod.Text = "ÜrünK. Kodu";
            frmUrunKTanimlama.Text = "ÜrünK. Tanımlama Formu";
            frmUrunKTanimlama.ShowDialog();
        }

        private void odemeTipiTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frmOdemeTipiTanimlama = new KategoriTanimlamaForm();
            frmOdemeTipiTanimlama.TabloAdi = "OdemeTipiTablosu";
            frmOdemeTipiTanimlama.AdAdi = "Ad";
            frmOdemeTipiTanimlama.KodAdi = "OdemeTipiID";
            frmOdemeTipiTanimlama.OgeAdi = "Odeme T.";
            frmOdemeTipiTanimlama.lbl2.Text = "ÖdemeT. Adı";
            frmOdemeTipiTanimlama.lblKod.Text = "ÖdemeT. Kodu";
            frmOdemeTipiTanimlama.Text = "ÖdemeT. Tanımlama Formu";
            frmOdemeTipiTanimlama.ShowDialog();
        }
    }
}
