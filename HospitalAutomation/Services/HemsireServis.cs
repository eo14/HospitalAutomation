using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
    public class HemsireServis:Hemsire
    {
        public static List<Hemsire> HemsireListesi = new List<Hemsire>();

        public void HemsireBranslariGetir(ComboBox comboBx)
        {
            comboBx.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }
        public void HemsireleriComboyaGetir(KisiselBilgiler userCntrl, ComboBox comboBx)
        {
            comboBx.Items.Clear();
            foreach (Hemsire item in HemsireListesi)
            {
                comboBx.Items.Add(item);
            }

        }
        public void HemsireyeBransAta(Hemsire hemsire, Branslar brans)
        {
            if (hemsire.HemsireBrans==Branslar.BransYok)
            {
                hemsire.HemsireBrans = brans;
                MessageBox.Show("Branş atandı");
            }
            else
            {
                if (hemsire.HemsireDR == null) // doktoru yoksa
                {
                    {
                        DialogResult cevap = MessageBox.Show($"Birlikte çalıştığı doktoru olmayan, Hemşire-> {hemsire.personAd + " " + hemsire.personSoyad} {hemsire.HemsireBrans} servisindedir. Hemşirenin branşını yine de değiştirmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                        {
                            hemsire.HemsireBrans = brans;
                            MessageBox.Show("Branş atandı");
                        }
                    }
                }
                else // doktoru varsa 
                {
                    MessageBox.Show($" {hemsire.HemsireBrans} servisindeki {hemsire.personAd + " " + hemsire.personSoyad} isimli hemşire {hemsire.HemsireDR.personAd + " " + hemsire.HemsireDR.personSoyad} isimli doktorla çalışmaktadır. Bu hemşirenin branşını değiştiremezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }
        public void HemsireyiDrListVieweGetir(Hemsire hemsire, ListView lst)
        {
            lst.Items.Clear();
            ListViewItem li = new ListViewItem();
            li.Text = hemsire.personTCNo;
            li.SubItems.Add(hemsire.personAd);
            li.SubItems.Add(hemsire.personSoyad);
            li.SubItems.Add(hemsire.HemsireBrans.ToString());
            li.SubItems.Add(hemsire.personCinsiyet.ToString());
            if (hemsire.HemsireDR == null)
                li.SubItems.Add("Doktor henüz atanmamış");
            else
                li.SubItems.Add(hemsire.HemsireDR.ToString());
            lst.Items.Add(li);
            li.Tag = hemsire;

        }
        public void HemsireyiMaasListVieweGetir(Hemsire hemsire, ListView lst)
        {
            lst.Items.Clear();
            ListViewItem li = new ListViewItem();
            li.Text = hemsire.personTCNo;
            li.SubItems.Add(hemsire.personAd);
            li.SubItems.Add(hemsire.personSoyad);
            li.SubItems.Add(hemsire.HemsireBrans.ToString());
            li.SubItems.Add(hemsire.Maas.ToString());
            li.SubItems.Add(hemsire.personCinsiyet.ToString());
            li.SubItems.Add(hemsire.personDogumTarihi.ToString());
            li.SubItems.Add(hemsire.personTel);
            lst.Items.Add(li);
            li.Tag = hemsire;

        }

        public void HemsireMaasAta(Hemsire hemsire, decimal maas)
        {
           hemsire.Maas = maas;
            MessageBox.Show("Maaş belirlendi");
        }
        public static void HemsireyeDoktorunuBelirle(Doktor dr, Hemsire hemsire)
        {
            hemsire.HemsireDR = dr;
            MessageBox.Show($"Hemşire {hemsire.personAd + " " +hemsire.personSoyad} " +
                $"Dr {dr.personAd + " " + dr.personSoyad} atandı.");
            dr.DrHemsireleri.Add(hemsire);
        }


    }
}
