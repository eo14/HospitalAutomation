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
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
            doktorToolStripMenuItem.Click += toolstripMenuItemClik;
            hemsireToolStripMenuItem.Click += toolstripMenuItemClik;
            hastaToolStripMenuItem.Click += toolstripMenuItemClik;
            randevuToolStripMenuItem.Click += toolstripMenuItemClik;
            ciktiIslemleriToolStripMenuItem.Click += toolstripMenuItemClik;
        }

        private void toolstripMenuItemClik(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "personelToolStripMenuItem":
                    FormlarArasiGecis(new FrmPersonel());
                    break;
                case "doktorToolStripMenuItem":
                    FormlarArasiGecis(new FrmDoktor());

                    break;
                case "hemsireToolStripMenuItem":
                    FormlarArasiGecis(new FrmHemsire());
                    break;
                case "hastaToolStripMenuItem":
                    FormlarArasiGecis(new FrmHasta());
                    break;
                case "randevuToolStripMenuItem":
                    FormlarArasiGecis(new FrmRandevu());
                    break;
                case "ciktiIslemleriToolStripMenuItem":
                    FormlarArasiGecis(new FrmCiktiIslemleri());
                    break;
                default:
                    break;
            }
        }
        private void FormlarArasiGecis(Form frm)
        {
            //açık form varsa kapat
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            
            //Tıklanan formu aç
            frm.MdiParent = this;
            frm.LayoutMdi(MdiLayout.TileVertical);
            frm.Show();
            //form içinde form boyutlarında göster
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
