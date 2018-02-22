using HospitalAutomation.models;
using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
            btn0900.btnSaat.Click += UserCntrlBtn_Click;
            btn0915.btnSaat.Click += UserCntrlBtn_Click;
            btn0930.btnSaat.Click += UserCntrlBtn_Click;
            btn0945.btnSaat.Click += UserCntrlBtn_Click;
            btn1000.btnSaat.Click += UserCntrlBtn_Click;
            btn1015.btnSaat.Click += UserCntrlBtn_Click;
            btn1030.btnSaat.Click += UserCntrlBtn_Click;
            btn1045.btnSaat.Click += UserCntrlBtn_Click;
            btn1100.btnSaat.Click += UserCntrlBtn_Click;
            btn1115.btnSaat.Click += UserCntrlBtn_Click;
            btn1130.btnSaat.Click += UserCntrlBtn_Click;
            btn1145.btnSaat.Click += UserCntrlBtn_Click;
            btn1300.btnSaat.Click += UserCntrlBtn_Click;
            btn1315.btnSaat.Click += UserCntrlBtn_Click;
            btn1330.btnSaat.Click += UserCntrlBtn_Click;
            btn1345.btnSaat.Click += UserCntrlBtn_Click;
            btn1400.btnSaat.Click += UserCntrlBtn_Click;
            btn1415.btnSaat.Click += UserCntrlBtn_Click;
            btn1430.btnSaat.Click += UserCntrlBtn_Click;
            btn1445.btnSaat.Click += UserCntrlBtn_Click;

        }
        Button tiklananBtn = new Button();

        private void UserCntrlBtn_Click(object sender, EventArgs e)
        {
            Button rndBtn = sender as Button;
            tiklananBtn = rndBtn;

            foreach (RandevuSaatleriBtn b in flowLayoutPanelSaatler.Controls)
            {
                if (!(b.btnSaat.Text == tiklananBtn.Text))
                    if (b.RandevuAlindi == false)
                        b.btnSaat.BackColor = Color.White;
            }
            //MessageBox.Show(tiklananBtn.btnSaat.Text);
        }

        RandevuServis randevuServis = new RandevuServis();
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            gbRndIslemleri.Enabled = false;
            txtHastaArama.MaxLength = 11;
            txtHastaArama.Enabled = false;
            txtTcAramaTabPage.Enabled = false;
            btnRandevuSec.Enabled = false;
            menuStripRandevu.Enabled = false;
            HastaServis.TumHastalariListBoxaGetir(lstHasta);
            HastaServis.TumHastalariListBoxaGetir(listBoxHastaTabPage);
            if (lstHasta.Items.Count > 0) txtHastaArama.Enabled = true;
            cmbServis.Items.AddRange(Enum.GetNames(typeof(Branslar)));
            cmbBoxSrvs.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }

        private void lstHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoktor.Items.Clear();
            txtHastaArama.Enabled = true;
            if (gbRndIslemleri.Enabled == true) gbRndIslemleri.Enabled = false;
            flowLayoutPanelSaatler.Enabled = false;
            RandevuServis.HastaninRandevulariniGetir((Hasta)lstHasta.SelectedItem, lstViewHastaRandevuları);
            if (!(lstHasta.Items.Count > 0))
                gbRndIslemleri.Enabled = false;
            else
                gbRndIslemleri.Enabled = true;
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServis.SelectedIndex != -1)
            {
                Branslar servis = (Branslar)Enum.Parse(typeof(Branslar), cmbServis.SelectedItem.ToString());
                RandevuServis.ListBoxaServistekiTumDrGetir(servis, lstDoktor);
            }
        }

        private void lstDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRandevuSec.Visible = true;
            btnRandevuSec.Enabled = true;
            flowLayoutPanelSaatler.Visible = true;
            flowLayoutPanelSaatler.Enabled = true;
            RandevuServis.SecilenDrRandevuSaatleriButonları((Doktor)lstDoktor.SelectedItem, flowLayoutPanelSaatler);
            if (lstDoktor.SelectedIndex != -1)
                MessageBox.Show("Randevu almak için saat seçimi yapınız.");
        }
        private void btnRandevuSec_Click(object sender, EventArgs e)
        {
            Hasta hasta = lstHasta.SelectedItem as Hasta;

            bool sonuc = RandevuServis.HastaninSecilenSaateBaskaRandevusuVarMi(hasta, tiklananBtn);
            RandevuServis.SecilenSaateRandevuAlmaDurumu(sonuc, (Doktor)lstDoktor.SelectedItem, (Hasta)lstHasta.SelectedItem, tiklananBtn);
            RandevuServis.HastaninRandevulariniGetir((Hasta)lstHasta.SelectedItem, lstViewHastaRandevuları);
            lstDoktor.Items.Clear();
            lstHasta.SelectedIndex = -1;
            flowLayoutPanelSaatler.Visible = false;
            btnRandevuSec.Visible = false;
            cmbServis.SelectedIndex = -1;
            gbRndIslemleri.Enabled = false;

        }

        private void txtHastaArama_TextChanged(object sender, EventArgs e)
        {
            HastaServis.TCnumarasinaGoreHastaAra(txtHastaArama.Text, lstHasta);
            if (!(lstHasta.Items.Count > 0))
                gbRndIslemleri.Enabled = false;
            else
                gbRndIslemleri.Enabled = true;

        }

        private void listBoxDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tıklanan doktorun randevularını getir.7
            Doktor secilenDr = (Doktor)listBoxDr.SelectedItem;
            listViewDr.Items.Clear();
            RandevuServis.DoktorunTumRandevulariniGetir(secilenDr, listViewDr);
        }

        private void cmbBoxSrvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branslar servis = (Branslar)Enum.Parse(typeof(Branslar), cmbBoxSrvs.SelectedItem.ToString());
            RandevuServis.ListBoxaServistekiTumDrGetir(servis, listBoxDr);

        }
        private void listBoxHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTcAramaTabPage.Enabled = true;
            RandevuServis.HastaninSadeceRandevuBilgisiniGetir((Hasta)listBoxHastaTabPage.SelectedItem, listViewHastaRandevulari);
        }

        private void txtTcAramaTabPage_TextChanged(object sender, EventArgs e)
        {
            HastaServis.TCnumarasinaGoreHastaAra(txtTcAramaTabPage.Text, listBoxHastaTabPage);
        }

        private void RandevutabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHastaTabPage.Items.Count > 0)
                txtTcAramaTabPage.Enabled = true;
            if (RandevutabControl.SelectedTab == servisDrtabPage || RandevutabControl.SelectedTab == HastaRandevutabPage)
            {
                menuStripRandevu.Enabled = true;
                RandevularToolStripMenuItem.Enabled = true;
            }
            else
            {
                menuStripRandevu.Enabled = false;
                RandevularToolStripMenuItem.Enabled = false;

            }
        }

        private void disariAktarDrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.JsonRandevulariDisariAktar(kaydetDosya);
        }

        private void iceriAktarDrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.JsonRandevulariIceriAktar(acDosya);
        }
    }
}
