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
    public partial class FrmHemsire : Form
    {
        public FrmHemsire()
        {
            InitializeComponent();
        }
      public HemsireServis HemsireServis = new HemsireServis();
        private void FrmHemsire_Load(object sender, EventArgs e)
        {
            HemsirekisiselBilgilerUserCntrl.KimBuKisi = UserControlKimBuKisi.Hemsire;
            HemsireServis.HemsireBranslariGetir(cmbBrans);
            HemsirekisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hemsire);
            btnMaasKaydet.Enabled = false;
            btnKaydet.Enabled = false;
        }
        private void cmbHemsire_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hemsire secilen = (Hemsire)cmbHemsire.SelectedItem;
            HemsireServis.HemsireyiDrListVieweGetir(secilen, lstViewHemsire);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Branslar brans = (Branslar)Enum.Parse(typeof(Branslar), cmbBrans.SelectedItem.ToString());
            Hemsire secilen = (Hemsire)cmbHemsire.SelectedItem;
            HemsireServis.HemsireyeBransAta(secilen, brans);
            HemsireServis.HemsireyiDrListVieweGetir(secilen, lstViewHemsire);
        }
        private void HemsireTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            HemsireServis.HemsireleriComboyaGetir(HemsirekisiselBilgilerUserCntrl, cmbHemsire);
            HemsireServis.HemsireleriComboyaGetir(HemsirekisiselBilgilerUserCntrl, cmbHemsireSecMaasTab);
            HemsirekisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hemsire);
        }
        private void cmbHemsireSecMaasTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            HemsireServis.HemsireyiMaasListVieweGetir((Hemsire)cmbHemsireSecMaasTab.SelectedItem, listViewHemsireMaasTab);
            nudMaas.Value = 0;
            if(cmbHemsireSecMaasTab.SelectedIndex!=-1) btnMaasKaydet.Enabled = true;
        }

        private void btnMaasKaydet_Click(object sender, EventArgs e)
        {
            HemsireServis.HemsireMaasAta((Hemsire)cmbHemsireSecMaasTab.SelectedItem, nudMaas.Value);
            HemsireServis.HemsireyiMaasListVieweGetir((Hemsire)cmbHemsireSecMaasTab.SelectedItem, listViewHemsireMaasTab);
        }
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreDisariAktar(HemsirekisiselBilgilerUserCntrl.KimBuKisi
                , dosyaKaydet);
        }
        private void XMLIceriiAktarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreIceriAktar(HemsirekisiselBilgilerUserCntrl, dosyayiAc);
            HemsirekisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hemsire);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHemsire.SelectedIndex != -1 && cmbBrans.SelectedIndex != -1)
                btnKaydet.Enabled = true;
        }
    }
}
