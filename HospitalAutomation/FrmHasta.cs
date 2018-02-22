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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        HastaServis hastaServisi = new HastaServis();
        private void FrmHasta_Load(object sender, EventArgs e)
        {
            HastakisiselBilgilerUserCntrl.KimBuKisi = UserControlKimBuKisi.Hasta;
            HastakisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hasta);

        }

        private void HastatabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastakisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hasta);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreDisariAktar(HastakisiselBilgilerUserCntrl.KimBuKisi
                , dosyaKaydet);
        }


        private void XMLIceriiAktarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DisariveIceriAktarServis.XMLPersonaGoreIceriAktar(HastakisiselBilgilerUserCntrl, dosyayiAc);
           HastakisiselBilgilerUserCntrl.LstBoxYenile(UserControlKimBuKisi.Hasta);

        }
    }


    }

