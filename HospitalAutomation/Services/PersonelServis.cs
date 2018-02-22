using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
    public class PersonelServis : Personel
    {
        public static List<Personel> PersonelListesi = new List<Personel>();

        public void PersonelBirimleriGetir(ComboBox comboBx)
        {
            comboBx.Items.AddRange(Enum.GetNames(typeof(Birimler)));
        }
        public void PersoneliComboyaGetir(KisiselBilgiler userCntrl, ComboBox comboBx)
        {
            comboBx.Items.Clear();
            if (PersonelListesi.Count > 0)
            {
                foreach (Personel item in PersonelListesi)
                    comboBx.Items.Add(item);
            }
        }
        public void PersoneliListVieweGetir(Personel personel, ListView lst)
        {
            lst.Items.Clear();
            ListViewItem li = new ListViewItem();
            li.Text = personel.personTCNo;
            li.SubItems.Add(personel.personAd);
            li.SubItems.Add(personel.personSoyad);
            li.SubItems.Add(personel.PersonelBirim.ToString());
            li.SubItems.Add(personel.personCinsiyet.ToString());
            li.SubItems.Add(personel.personDogumTarihi.ToString());
            li.SubItems.Add(personel.personTel);
            li.SubItems.Add(personel.personMail);
            li.SubItems.Add(personel.Maas.ToString());

            lst.Items.Add(li);
            li.Tag = personel;
        }
        public void PersonelBirimAta(Personel personel, Birimler birim)
        {
            if(personel.PersonelBirim==Birimler.BirimYok)
            {
                personel.PersonelBirim = birim;
                MessageBox.Show("Birim atandı");
            }
            else
            {
                DialogResult cevap = MessageBox.Show($"{personel.personAd + " " + personel.personSoyad} isimli personel {personel.PersonelBirim} birimdedir. Bu personelin birimini değiştirmek istediğinize emin misiniz? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cevap==DialogResult.Yes)
                {
                    personel.PersonelBirim = birim;
                    MessageBox.Show("Birim atandı");
                }
            }
        }
        public void PersonelMaasAta(Personel personel, decimal maas)
        {
            personel.Maas = maas;
            MessageBox.Show("Maaş belirlendi");
        }

    }
}
