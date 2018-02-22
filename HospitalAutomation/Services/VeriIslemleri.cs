using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
   public static class VeriIslemleri
    {
        #region KaydetmeIslemleri
        public static void YeniDoktorKaydet(string tc, string ad, string soyad, DateTime dogumtrh, Cinsiyet cinsiyeti, string mail, string tel)
        {
            Doktor yeniDr = new Doktor()
            {
                KisiTipi = PersonKisiTipi.Doktor,
                personTCNo = tc,
                personAd = ad,
                personSoyad = soyad,
                personDogumTarihi = dogumtrh,
                personCinsiyet = cinsiyeti,
                personMail =mail,
                personTel = tel,
                DoktorBrans = Branslar.BransYok,
                Maas=0
            };
            DoktorServis.DoktorListesi.Add(yeniDr);
            MessageBox.Show("Yeni doktor eklendi");

        }
        public static void YeniHemsireKaydet(string tc, string ad, string soyad, DateTime  dogumtrh, Cinsiyet cinsiyeti, string mail, string tel)
        {
            Hemsire yeniHemsire = new Hemsire()
            {
                KisiTipi = PersonKisiTipi.Hemsire,
                personTCNo = tc,
                personAd = ad,
                personSoyad = soyad,
                personDogumTarihi = dogumtrh,
                personCinsiyet = cinsiyeti,
                personMail = mail,
                personTel = tel,
                HemsireBrans = Branslar.BransYok,
                Maas=0
            };
            HemsireServis.HemsireListesi.Add(yeniHemsire);
            MessageBox.Show("Yeni hemşire eklendi");
        }
        public static void YeniPersonelKaydet(string tc, string ad, string soyad, DateTime dogumtrh, Cinsiyet cinsiyeti, string mail, string tel)
        {
            Personel yeniPersonel = new Personel()
            {
                KisiTipi = PersonKisiTipi.Personel,
                personTCNo = tc,
                personAd = ad,
                personSoyad = soyad,
                personDogumTarihi = dogumtrh,
                personCinsiyet = cinsiyeti,
                personMail = mail,
                personTel = tel,
                PersonelBirim = Birimler.BirimYok,
                Maas = 0
            };
           PersonelServis.PersonelListesi.Add(yeniPersonel);
            MessageBox.Show("Yeni personel eklendi");


        }
        public static void YeniHastaKaydet(string tc, string ad, string soyad, DateTime dogumtrh, Cinsiyet cinsiyeti, string mail, string tel)
        {
            Hasta yeniHasta = new Hasta()
            {
                KisiTipi = PersonKisiTipi.Hasta,
                personTCNo = tc,
                personAd = ad,
                personSoyad = soyad,
                personDogumTarihi = dogumtrh,
                personCinsiyet = cinsiyeti,
                personMail = mail,
                personTel = tel
            };
            HastaServis.HastaListesi.Add(yeniHasta);
            MessageBox.Show("Yeni hasta eklendi");


        }
        #endregion
        #region GuncellemeIslemleri
        public static void DoktoruGuncelle(Doktor secilenDr, string ad, string soyad, Cinsiyet cinsiyeti, string tel, DateTime dogumtrh, string mail)
        {
            secilenDr.personAd = ad;
            secilenDr.personSoyad = soyad;
            secilenDr.personCinsiyet =cinsiyeti;
            secilenDr.personTel = tel;
            secilenDr.personDogumTarihi = dogumtrh;
            secilenDr.personMail = mail;
            MessageBox.Show("Güncellendi");
        }
        public static void HemsireyiGuncelle(Hemsire secilenHemsire, string ad, string soyad, Cinsiyet cinsiyeti, string tel, DateTime dogumtrh, string mail)
        {
            secilenHemsire.personAd = ad;
            secilenHemsire.personSoyad = soyad;
            secilenHemsire.personCinsiyet = cinsiyeti;
            secilenHemsire.personTel = tel;
            secilenHemsire.personDogumTarihi = dogumtrh;
            secilenHemsire.personMail = mail;
            MessageBox.Show("Güncellendi");
        }
        public static void HastayiGuncelle(Hasta secilenHasta, string ad, string soyad, Cinsiyet cinsiyeti, string tel, DateTime dogumtrh, string mail)
        {
            secilenHasta.personAd = ad;
            secilenHasta.personSoyad = soyad;
            secilenHasta.personCinsiyet = cinsiyeti;
            secilenHasta.personTel = tel;
            secilenHasta.personDogumTarihi = dogumtrh;
            secilenHasta.personMail = mail;
            MessageBox.Show("Güncellendi");
        }
        public static void PersoneliGuncelle(Personel secilenPersonel, string ad, string soyad, Cinsiyet cinsiyeti, string tel, DateTime dogumtrh, string mail)
        {
            secilenPersonel.personAd = ad;
            secilenPersonel.personSoyad = soyad;
            secilenPersonel.personCinsiyet = cinsiyeti;
            secilenPersonel.personTel = tel;
            secilenPersonel.personDogumTarihi = dogumtrh;
            secilenPersonel.personMail = mail;
            MessageBox.Show("Güncellendi");
        }
#endregion
        #region SilmeIslemleri
        public static void DoktoruSil(Doktor secilenDr)
        {
            DialogResult cevap = MessageBox.Show($"Dr. {secilenDr.personAd + " " + secilenDr.personSoyad} silmek istediğinizden emin misiniz?", "SİLME İŞLEMİ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                DoktorServis.DoktorListesi.Remove(secilenDr);
                MessageBox.Show("Doktor silinmiştir.");
            }
            else
                MessageBox.Show("Silme işlemi iptal edildi");

        }
        public static void HemsireyiSil(Hemsire secilenHemsire)
        {
            DialogResult cevap = MessageBox.Show($"Hemşire {secilenHemsire.personAd + " " + secilenHemsire.personSoyad} silmek istediğinizden emin misiniz?", "SİLME İŞLEMİ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                HemsireServis.HemsireListesi.Remove(secilenHemsire);
                MessageBox.Show("Hemşire silinmiştir.");
            }
            else
                MessageBox.Show("Silme işlemi iptal edildi");

        }
        public static void HastayiSil(Hasta secilenHasta)
        {
            DialogResult cevap = MessageBox.Show($"Hasta {secilenHasta.personAd + " " + secilenHasta.personSoyad} silmek istediğinizden emin misiniz?", "SİLME İŞLEMİ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                HastaServis.HastaListesi.Remove(secilenHasta);
                MessageBox.Show("Hasta silinmiştir.");
            }
            else
                MessageBox.Show("Silme işlemi iptal edildi");

        }
        public static void PersoneliSil(Personel secilenPersonel)
        {
            DialogResult cevap = MessageBox.Show($"Hemşire {secilenPersonel.personAd + " " + secilenPersonel.personSoyad} silmek istediğinizden emin misiniz?", "SİLME İŞLEMİ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                PersonelServis.PersonelListesi.Remove(secilenPersonel);
                MessageBox.Show("Personel silinmiştir.");
            }
            else
                MessageBox.Show("Silme işlemi iptal edildi");

        }
        #endregion
        #region AramaIslemleri
        public static void AramaIslemi(string arama, ListBox lstKisiler)
        {
            arama=arama.ToLower();
            List<Person> sonucList = new List<Person>();
            if (arama.Length > 2)
            {
                if (lstKisiler.Items.Count > 0)
                {
                    foreach (Person item in lstKisiler.Items)
                    {
                        if (item.personAd.ToLower().Contains(arama) || item.personSoyad.ToLower().Contains(arama))
                        {
                            sonucList.Add(item);
                        }

                    }
                    lstKisiler.Items.Clear();
                    foreach (Person item in sonucList)
                    {
                        lstKisiler.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Listede aranacak kişi bulunmamaktadır!");
                }

            }

        }
        #endregion
    }
}
