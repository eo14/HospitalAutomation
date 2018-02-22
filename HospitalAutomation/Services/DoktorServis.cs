using HospitalAutomation;
using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
    public class DoktorServis : Doktor
    {
        public static List<Doktor> DoktorListesi = new List<Doktor>();
        public void DrBranslariListeyeGetir(ListBox listBx)
        {
            listBx.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }
        public void DrBanslariComboyaGetir(ComboBox comboBx)
        {
            comboBx.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }
        public void DoktorlariGetir(KisiselBilgiler userCntrl, ComboBox comboBx)
        {

            foreach (Doktor item in DoktorListesi)
            {
                comboBx.Items.Add(item);
            }
        }

        public void DoktoruListVieweGetir(Doktor dr, ListView lst)
        {
            lst.Items.Clear();
            ListViewItem li = new ListViewItem();
            li.Text = dr.personTCNo;
            li.SubItems.Add(dr.personAd);
            li.SubItems.Add(dr.personSoyad);
            li.SubItems.Add(dr.DoktorBrans.ToString());
            li.SubItems.Add(dr.personCinsiyet.ToString());
            li.SubItems.Add(dr.personDogumTarihi.ToString());
            li.SubItems.Add(dr.personTel);
            li.SubItems.Add(dr.personMail);
            li.SubItems.Add(dr.Maas.ToString());
            lst.Items.Add(li);
            li.Tag = dr;

        }
        public static bool DoktrounHemsiresiVarMi(Doktor dr)
        {
            //Doktorun hemşire listesinde doktorun hemşiresi varmı? Var:True - Yok:False
            bool durum = false;
            foreach (Hemsire item in dr.DrHemsireleri)
            {
                if (item == null)
                    durum = false;
                else
                    durum = true;
            }

            return durum;
        }

        public void DoktoraBransAta(Doktor dr, Branslar brans)
        {
            //Eğer drnin randevu listesi dolu ise
            if(dr.DrRandevulari.Count >0)
            {
                MessageBox.Show($"Dr. {dr.personAd + " "+ dr.personSoyad}'ın {dr.DrRandevulari.Count} adet randevusu bulunmaktadır. Branş değişikliği yapılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else // Eğer Dr-nin randevu listesinde kimse yoksa...
            {
                if(dr.DrHemsireleri.Count > 0) // Dr'nin hemşiresi/hemşireleri varsa...
                {
                    MessageBox.Show($"Dr. {dr.personAd + " " + dr.personSoyad}'ın {dr.DrHemsireleri.Count} adet hemşiresi bulunmaktadır. Branş değişikliği yapılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else //Dr'nin henüz hiç hemşiresi yoksa...
                {
                    if(!(dr.DoktorBrans == Branslar.BransYok)) //Dr'nin daha önceden atanmış başka branşı varsa... 
                    {
                        DialogResult cevap = MessageBox.Show($"Birlikte çalıştığı hemşireleri olmayan, Dr {dr.personAd + " " + dr.personSoyad} {dr.DoktorBrans} servisindedir. <{dr.DrHemsireleri.Count} adet hemşire>" +
                        $"Doktorun branşını yine de değiştirmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                        {
                            dr.DoktorBrans = brans;
                            MessageBox.Show("Başka bir branş atandı");
                        }
                    }
                    else 
                    {
                        dr.DoktorBrans = brans;
                        MessageBox.Show("Yeni Branş atandı");
                    }

                }
            }
            /////
        }

        public void DoktoraMaasAta(Doktor dr, decimal maas)
        {
            dr.Maas = maas;
            MessageBox.Show("Maaş belirlendi");
        }
        public void DoktorlaAyniBranstakiBosHemsireleriGetir(ListBox lstBx, Doktor dr)
        {
            lstBx.Items.Clear();
            if(HemsireServis.HemsireListesi.Count!=0)
            {
                foreach (Hemsire item in HemsireServis.HemsireListesi)
                {
                    if (item.HemsireDR == null && item.HemsireBrans == dr.DoktorBrans)
                        lstBx.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Şu anda görüntülenecek hemşire bulunmuyor.");
            }
        }
        public void SecilenBranstakiTumDrGetir(Branslar brans, ComboBox cmbBx)
        {
            cmbBx.SelectedIndex = -1;
            cmbBx.Items.Clear();
            foreach (Doktor item in DoktorServis.DoktorListesi)
            {
                if (item.DoktorBrans == brans)
                    cmbBx.Items.Add(item);
            }

        }
        public static void DrninTumHemsireleriniGetir(Doktor dr, ListView listview, Label lbl)
        {
            try
            {
                listview.Items.Clear();
                foreach (Hemsire item in dr.DrHemsireleri)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.HemsireBrans.ToString();
                    li.SubItems.Add(item.personTCNo);
                    li.SubItems.Add(item.personAd);
                    li.SubItems.Add(item.personSoyad);
                    li.SubItems.Add(item.personCinsiyet.ToString());
                    li.SubItems.Add("Dr. " + item.HemsireDR.personAd + " " + item.HemsireDR.personSoyad);
                    listview.Items.Add(li);
                    li.Tag = item;
                    lbl.Text = $"Dr.{dr.personAd + " " + dr.personSoyad} ile çalışan hemşireler";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Doktorun hemşireleri henüz atanmamış");;
            }
        }
        public static void DrninHemsiresiniSil(Doktor dr, Hemsire hemsire)
        {
            try
            {
                DialogResult cevap = MessageBox.Show($"Dr.{dr.personAd + " "+ dr.personSoyad } ile çalışan {hemsire.personAd + " " + hemsire.personSoyad} isimli hemşireyi bu doktordan silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cevap==DialogResult.Yes)
                {
                    hemsire.HemsireDR = null;
                    dr.DrHemsireleri.Remove(hemsire);
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

} 

       


