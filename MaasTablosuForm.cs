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
    public partial class MaasTablosuForm : Form
    {
        public MaasTablosuForm()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                Ana_Ekran.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM MaasTablosu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Ana_Ekran.Baglanti);
                da.Fill(ds, "MaasTablosu");
                dataGridView1.DataSource = ds.Tables["MaasTablosu"];
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
                string SorguTum = "SELECT * FROM MaasTablosu";
                string SorguTutar = "SELECT * FROM MaasTablosu where MaasTutar='" + txtMaasTutar.Text + "'";
                string SorguDurum;
                string SorguTutarDurum;
                if (radAktif.Checked == true)
                {
                    SorguDurum = "SELECT * FROM MaasTablosu where Durum='True'";
                    SorguTutarDurum = "SELECT * FROM MaasTablosu where MaasTutar='" + txtMaasTutar.Text + "' AND Durum='True'";
                }
                else
                {
                    SorguDurum = "SELECT * FROM MaasTablosu where Durum='False'";
                    SorguTutarDurum = "SELECT * FROM MaasTablosu where MaasTutar='" + txtMaasTutar.Text + "' AND Durum='False'";
                }
                if (chkTutar.Checked == true && chkDurum.Checked == true)
                    SorguTum = SorguTutarDurum;
                else if (chkDurum.Checked == true)
                    SorguTum = SorguDurum;
                else if (chkTutar.Checked == true)
                    SorguTum = SorguTutar;
                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Ana_Ekran.Baglanti);
                da.Fill(ds, "MaasTablosu");
                dataGridView1.DataSource = ds.Tables["MaasTablosu"];
                Ana_Ekran.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "KayitAra Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaasTablosuForm_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            KayitSilForm1.ID = "MaasID";
            KayitSilForm1.Tablo = "MaasTablosu";
            KayitSilForm1 FrmSil = new KayitSilForm1();
            FrmSil.Text = "Maas Kayıt Sil";
            FrmSil.lbl1.Text = "MaasID";
            FrmSil.lbl2.Text = "PersonelID";
            FrmSil.lbl3.Text = "MaasTutar";
            FrmSil.lbl4.Text = "OdemeGun";
            FrmSil.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmSil.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FrmSil.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FrmSil.txt4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            FrmSil.ShowDialog();
        }

        private void btnKayitDüzenle_Click(object sender, EventArgs e)
        {
            MaasKayitDuzenleForm frmDuzen = new MaasKayitDuzenleForm();
            frmDuzen.txtMaasID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDuzen.cmbPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDuzen.txtMaasTutar.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value));
            frmDuzen.txtPrim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmDuzen.txtIskonto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "True")
                frmDuzen.radAktif.Checked = true;
            else
                frmDuzen.radPasif.Checked = true;
            frmDuzen.cmbOdemeGunu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmDuzen.ShowDialog();
        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
            MaasKayitEkleForm frmEkle = new MaasKayitEkleForm();
            frmEkle.ShowDialog();
        }

        private void MaasTablosuForm_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkTutar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTutar.Checked == true)
            {
                txtMaasTutar.Text = "";
                txtMaasTutar.Enabled = true;
            }
            else
            {
                txtMaasTutar.Text = "";
                txtMaasTutar.Enabled = false;
            }
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDurum.Checked == true)
            {
                radAktif.Enabled = true;
                radPasif.Enabled = true;
            }
            else
            {
                radAktif.Checked = false;
                radPasif.Checked = false;
                radAktif.Enabled = false;
                radPasif.Enabled = false;
            }
        }
    }
}
