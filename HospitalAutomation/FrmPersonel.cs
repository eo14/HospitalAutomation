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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        PersonelServis personelServis = new PersonelServis();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            PersonelkisiselBilgilerUserCntrl.KimBuKisi = UserControlKimBuKisi.Personel;
            personelServis.PersonelBirimleriGetir(cmbBirim);
            PersonelkisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Personel);
            btnKaydet.Enabled = false;
            btnMaasKaydet.Enabled = false;
        }
        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel secilen = (Personel)cmbPersonel.SelectedItem;
            personelServis.PersoneliListVieweGetir(secilen, lstViewPersonel);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Birimler birim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            Personel secilen = (Personel)cmbPersonel.SelectedItem;
            personelServis.PersonelBirimAta(secilen, birim);
            personelServis.PersoneliListVieweGetir(secilen, lstViewPersonel);
        }
        private void PersonelTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelServis.PersoneliComboyaGetir(PersonelkisiselBilgilerUserCntrl, cmbPersonel);
            personelServis.PersoneliComboyaGetir(PersonelkisiselBilgilerUserCntrl, cmbPersonelSecMaasTab);
            PersonelkisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Personel);
        }
        private void cmbPersonelSecMaasTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelServis.PersoneliListVieweGetir((Personel)cmbPersonelSecMaasTab.SelectedItem, listViewPersonelMaasTab);
        }
        private void btnMaasKaydet_Click(object sender, EventArgs e)
        {
            personelServis.PersonelMaasAta((Personel)cmbPersonelSecMaasTab.SelectedItem, nudMaas.Value);
            personelServis.PersoneliListVieweGetir((Personel)cmbPersonelSecMaasTab.SelectedItem, listViewPersonelMaasTab);
        }
        private void XMLIceriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreIceriAktar(PersonelkisiselBilgilerUserCntrl, dosyayiAc);

            PersonelkisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Personel);
        }

        private void XMLDisariAktartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreDisariAktar(PersonelkisiselBilgilerUserCntrl.KimBuKisi
                , dosyaKaydet);
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex != -1 && cmbBirim.SelectedIndex != -1)
                btnKaydet.Enabled = true;
        }

        private void nudMaas_ValueChanged(object sender, EventArgs e)
        {
            if (cmbPersonelSecMaasTab.SelectedIndex != -1)
                btnMaasKaydet.Enabled = true;
        }
    }
}
