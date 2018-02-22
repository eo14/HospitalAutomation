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
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }
        public DoktorServis DoktorServisi = new DoktorServis();

        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            DrkisiselBilgilerUserControl.KimBuKisi = UserControlKimBuKisi.Doktor;
            DoktorServisi.DoktorlariGetir(DrkisiselBilgilerUserControl, cmbDrSecBransTab);
            DoktorServisi.DrBranslariListeyeGetir(lstDrBranslar);
            DoktorServisi.DoktorlariGetir(DrkisiselBilgilerUserControl, cmbDrSecMaasTab);
            DoktorServisi.DrBanslariComboyaGetir(cmbServisSecHemsireTab);
            DoktorServisi.DoktorlariGetir(DrkisiselBilgilerUserControl, cmbDoktorSecHemsireTab);
            DrkisiselBilgilerUserControl.LstBoxYenile(UserControlKimBuKisi.Doktor);
            lstHemsireler.Enabled = false;
            btnHemsireSec.Enabled = false;
            listViewDrHemsireleri.Enabled = false;
            btnBransKaydet.Enabled = false;
            btnMaasKaydet.Enabled = false;
        }

        private void cmbDrSecBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrBranslar.Visible = true;
            DoktorServisi.DoktoruListVieweGetir((Doktor)cmbDrSecBransTab.SelectedItem, listViewDrBransTab);
        }

        private void btnBransKaydet_Click(object sender, EventArgs e)
        {
            Branslar brans = (Branslar)Enum.Parse(typeof(Branslar), lstDrBranslar.SelectedItem.ToString());

            DoktorServisi.DoktoraBransAta((Doktor)cmbDrSecBransTab.SelectedItem, brans);
            Doktor secilen = (Doktor)cmbDrSecBransTab.SelectedItem;
            DoktorServisi.DoktoruListVieweGetir(secilen, listViewDrBransTab);
        }

        private void btnMaasKaydet_Click(object sender, EventArgs e)
        {
            DoktorServisi.DoktoraMaasAta((Doktor)cmbDrSecMaasTab.SelectedItem, nudMaas.Value);
            DoktorServisi.DoktoruListVieweGetir((Doktor)cmbDrSecMaasTab.SelectedItem, listViewDrMaasTab);
        }

        private void tabControlDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewDrBransTab.Items.Clear();
            listViewDrMaasTab.Items.Clear();
            cmbDrSecBransTab.Items.Clear();
            cmbDrSecMaasTab.Items.Clear();
            cmbServisSecHemsireTab.Items.Clear();
            cmbDoktorSecHemsireTab.Items.Clear();
            lstDrBranslar.Items.Clear();
            DoktorServisi.DoktorlariGetir(DrkisiselBilgilerUserControl, cmbDrSecBransTab);
            DoktorServisi.DrBranslariListeyeGetir(lstDrBranslar);
            DoktorServisi.DoktorlariGetir(DrkisiselBilgilerUserControl, cmbDrSecMaasTab);
            DoktorServisi.DrBanslariComboyaGetir(cmbServisSecHemsireTab);
            DrkisiselBilgilerUserControl.LstBoxYenile(UserControlKimBuKisi.Doktor);
        }

        private void cmbDrSecMaasTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorServisi.DoktoruListVieweGetir((Doktor)cmbDrSecMaasTab.SelectedItem, listViewDrMaasTab);
            nudMaas.Value = 0;

        }

        private void cmbServisSecHemsireTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbDoktorSecHemsireTab.Items.Clear();
                cmbDoktorSecHemsireTab.SelectedIndex = -1;
                Branslar secilenBrans = (Branslar)Enum.Parse(typeof(Branslar), cmbServisSecHemsireTab.SelectedItem.ToString());
                lstHemsireler.Items.Clear();
                btnHemsireSec.Enabled = false;
                DoktorServisi.SecilenBranstakiTumDrGetir(secilenBrans, cmbDoktorSecHemsireTab);
                lstHemsireler.Enabled = true;
                listViewDrHemsireleri.Items.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Doktor seçimi yapınız."); ;
            }
        }

        private void cmbDoktorSecHemsireTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorServisi.DoktorlaAyniBranstakiBosHemsireleriGetir(lstHemsireler,
                (Doktor)cmbDoktorSecHemsireTab.SelectedItem);
            listViewDrHemsireleri.Items.Clear();
            DoktorServis.DrninTumHemsireleriniGetir((Doktor)cmbDoktorSecHemsireTab.SelectedItem, listViewDrHemsireleri, labeldrHemsireleri);
            listViewDrHemsireleri.Enabled = true;

        }

        private void btnHemsireSec_Click(object sender, EventArgs e)
        {
            try
            {
                listViewDrHemsireleri.Enabled = true;
                HemsireServis.HemsireyeDoktorunuBelirle((Doktor)cmbDoktorSecHemsireTab.SelectedItem, (Hemsire)lstHemsireler.SelectedItem);
                DoktorServis.DrninTumHemsireleriniGetir((Doktor)cmbDoktorSecHemsireTab.SelectedItem, listViewDrHemsireleri, labeldrHemsireleri);
                lstHemsireler.Items.Remove(lstHemsireler.SelectedItem);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen listeden seçim yapınız"); ;
            }
        }
        private void XMLdisariAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreDisariAktar(DrkisiselBilgilerUserControl.KimBuKisi
                , dosyaKaydet);
        }

        private void XMLIceriiAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreIceriAktar(DrkisiselBilgilerUserControl, dosyaAc);

            DrkisiselBilgilerUserControl.LstBoxYenile(UserControlKimBuKisi.Doktor);
        }

        private void lstHemsireler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHemsireSec.Enabled = true;
        }

        private void sİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hemsire secilenHemsire = (Hemsire)listViewDrHemsireleri.FocusedItem.Tag;
            Doktor secilenDoktor = (Doktor)cmbDoktorSecHemsireTab.SelectedItem;
            try
            {
                if (listViewDrHemsireleri.Items.Count > 0)
                {
                    DoktorServis.DrninHemsiresiniSil(secilenDoktor, secilenHemsire);
                    DoktorServis.DrninTumHemsireleriniGetir(secilenDoktor, listViewDrHemsireleri, labeldrHemsireleri);
                    lstHemsireler.Items.Add(secilenHemsire);
                }
                else
                    throw new Exception("Listede hemşire bulunmamaktadır.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lstDrBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrSecBransTab.SelectedIndex != -1 && lstDrBranslar.SelectedIndex != -1)
                btnBransKaydet.Enabled = true;
        }

        private void nudMaas_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDrSecMaasTab.SelectedIndex != -1)
                btnMaasKaydet.Enabled = true;
        }
    }
}
