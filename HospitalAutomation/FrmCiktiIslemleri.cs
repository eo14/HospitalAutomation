using HospitalAutomation.models;
using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FrmCiktiIslemleri : Form
    {
        public FrmCiktiIslemleri()
        {
            InitializeComponent();
        }
        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void FrmCiktiIslemleri_Load(object sender, EventArgs e)
        {
            RandevuServis.ComboyaTumDrleriGetir(comboBoxDrSeciniz);
            printPreviewDialog1.Document = printDocument1; // Preview'in Documenti >> PrintDocument'ten alması gerekiyormuş! 
        }
        private void comboBoxDrSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor secilenDr = (Doktor)comboBoxDrSeciniz.SelectedItem;
            listViewDktr.Items.Clear();
            RandevuServis.DoktorunTumRandevulariniGetir(secilenDr, listViewDktr);
            Form frm = printPreviewDialog1 as Form;
            printPreviewDialog1.Document = printDocument1;
            // Start maximized.
            frm.WindowState = FormWindowState.Maximized;
            // Start at 100% scale.
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            // Display.
            if (secilenDr.DrRandevulari.Count > 0)
                     printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the ListView.
            Doktor secilenDr = (Doktor)comboBoxDrSeciniz.SelectedItem;

            Bitmap bmp = Properties.Resources.doktorRandevularıResim;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 10, resim.Height / 10);
            e.Graphics.DrawString($"{secilenDr.DoktorBrans} Servisi - Dr. {secilenDr.personAd + " " + secilenDr.personSoyad} - {DateTime.Today.ToShortDateString()} Tarihine Ait Randevuları:", new Font("Arial", 10, FontStyle.Bold),Brushes.Black,new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString("Tarih ve Saat", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("Hasta Adı Soyadı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString("Yaş", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 200));
            e.Graphics.DrawString("Cinsiyeti", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(400, 200));

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumTarih = new Point(50, 235);
            Point konumHasta = new Point(200, 235);
            Point konumCinsiyet = new Point(400, 235);
            Point konumYas = new Point(600, 235);
            string[] saatler = { "09:00", "09:15", "09:30", "09:45","10:00","10:15","10:30","10:45",
                "11:00","11:15","11:30","11:45",             "13:00","13:15","13:30","13:45","14:00","14:15","14:30","14:45" };
            RandevuBilgileri[] SiraliRandevular = new RandevuBilgileri[saatler.Length];
            foreach (RandevuBilgileri item in secilenDr.DrRandevulari)
            {
                for (int i = 0; i < saatler.Length; i++)
                {
                    if (saatler[i] == item.RandevuSaat)
                        SiraliRandevular[i] = item;
                }
            }
            foreach (RandevuBilgileri item in SiraliRandevular)
            {
                if (item != null)
                {
                    konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                    e.Graphics.DrawString($"{item.RandevuZamani.ToShortDateString() + " " + item.RandevuSaat}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);
                    konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                    e.Graphics.DrawString($"{item.HastaBilgisi.personAd + " " + item.HastaBilgisi.personAd}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
                    konumCinsiyet = new Point(konumCinsiyet.X, konumCinsiyet.Y + 25);
                    e.Graphics.DrawString($"{item.HastaBilgisi.personCinsiyet}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumCinsiyet);
                    konumYas = new Point(konumYas.X, konumYas.Y + 25);
                    e.Graphics.DrawString($"{item.HastaBilgisi.Yas}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumYas);
                }
            }
        }
    }
}
