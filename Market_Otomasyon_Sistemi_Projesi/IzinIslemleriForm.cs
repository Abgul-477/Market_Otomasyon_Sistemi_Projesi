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
    public partial class IzinIslemleriForm : Form
    {
        public IzinIslemleriForm()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM IzinTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "IzinTablosu");
                dataGridView1.DataSource = ds.Tables["IzinTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitListele Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KayitAra()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "SELECT * FROM IzinTablosu";
                string SorguPerID = "SELECT * FROM IzinTablosu where PersonelID='" + txtPerID.Text + "'";
                string SorguDurum;
                string SorguPerIDDurum;
                if (radOnay.Checked == true)
                {
                    SorguDurum = "SELECT * FROM IzinTablosu where Durum='True'";
                    SorguPerIDDurum = "SELECT * FROM IzinTablosu where PersonelID='" + txtPerID.Text + "' AND Durum='True'";
                }
                else
                {
                    SorguDurum = "SELECT * FROM IzinTablosu where Durum='False'";
                    SorguPerIDDurum = "SELECT * FROM IzinTablosu where PersonelID='" + txtPerID.Text + "' AND Durum='False'";
                }
                if (chkDurum.Checked == true && chkPerID.Checked == true)
                    SorguTum = SorguPerIDDurum;
                else if (chkPerID.Checked == true)
                    SorguTum = SorguPerID;
                else if (chkDurum.Checked == true)
                    SorguTum = SorguDurum;
                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "IzinTablosu");
                dataGridView1.DataSource = ds.Tables["IzinTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IzinIslemleriForm_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void IzinIslemleriForm_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnIzinEkle_Click(object sender, EventArgs e)
        {
            IzinEkleForm frmEkle = new IzinEkleForm();
            frmEkle.ShowDialog();
        }

        private void btnIzınDegistir_Click(object sender, EventArgs e)
        {
            IzinDuzenleForm frmDuzen = new IzinDuzenleForm();

            frmDuzen.txtIzinID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.cmbPersonel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzen.dtpBasTar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDuzen.dtpBitTar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzen.txtGerekce.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "True")
                frmDuzen.radKabul.Checked = true;
            else
                frmDuzen.radRet.Checked = true;
            frmDuzen.txtAciklama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            frmDuzen.ShowDialog();
        }

        private void btnIzinSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "IzinID";
            KayitSilForm1.Tablo = "IzinTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Alacak Verecek Kayıt Sil";
            FrmSil.lbl1.Text = "IzinID";
            FrmSil.lbl2.Text = "PersonelID";
            FrmSil.lbl3.Text = "BasTar";
            FrmSil.lbl4.Text = "BitTar";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkPerID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerID.Checked == true)
            {
                txtPerID.Text = "";
                txtPerID.Enabled = true;
            }
            else
            {
                txtPerID.Text = "";
                txtPerID.Enabled = false;
            }
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDurum.Checked == true)
            {
                radOnay.Enabled = true;
                RadIptal.Enabled = true;
            }
            else
            {
                radOnay.Enabled = false;
                radOnay.Checked = false;
                RadIptal.Checked = false;
                RadIptal.Enabled = false;
            }
        }
    }
}
