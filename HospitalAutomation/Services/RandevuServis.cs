using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
    public class RandevuServis : RandevuBilgileri
    {
        public static List<RandevuBilgileri> Randevular = new List<RandevuBilgileri>();

        public static void ComboyaTumDrleriGetir(ComboBox cmbBoxTumDr)
        {
            cmbBoxTumDr.Items.Clear();
            foreach (Doktor item in DoktorServis.DoktorListesi)
            {
                cmbBoxTumDr.Items.Add(item);
            }
        }

        public static void ListBoxaServistekiTumDrGetir(Branslar brans, ListBox lstBox)
        {
            lstBox.Items.Clear();
            foreach (Doktor item in DoktorServis.DoktorListesi)
            {
                if (item.DoktorBrans == brans)
                {
                    lstBox.Items.Add(item);
                }
            }

        }

        public static bool HastaninSecilenSaateBaskaRandevusuVarMi(Hasta hasta, Button btn)
        {
            bool durum = false;
            foreach (RandevuBilgileri item in HastaServis.HastaRandevulari)
            {
                if (item.HastaBilgisi == hasta)
                {
                    if (item.RandevuSaat == btn.Text)
                    {
                        durum = true;
                    }
                }
            }

            return durum;
        }

        public static void SecilenSaateRandevuAlmaDurumu(bool sonuc, Doktor dr, Hasta hasta, Button btnsaat)
        {
            RandevuBilgileri rndBilgi = new RandevuBilgileri();
            if (sonuc == false)
            {
                RandevuyuAl(dr, hasta, btnsaat);
            }
            else
                MessageBox.Show($"Bu Saatta başka bir servisten randevunuz bulunuyor. Randevu Alamazsınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private static void RandevuyuAl(Doktor dr, Hasta hasta, Button btn)
        {
            try
            {
            RandevuBilgileri yeniRandevu = new RandevuBilgileri()
            {
                DoktorBilgisi = dr,
                HastaBilgisi = hasta,
                RandevuSaat = btn.Text,
                RandevuZamani = DateTime.Today
            };
               
            DialogResult cevap = MessageBox.Show($"Sayın {hasta.personAd}  {hasta.personSoyad}, {dr.DoktorBrans} servisinden Dr. {dr.personAd} { dr.personSoyad} için {btn.Text} saatinde randevu alma işleminizi onaylıyor musunuz?", "RANDEVU ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show($"Randvu kaydedilmiştir. \n HASTA: {hasta.personAd + " " + hasta.personSoyad} " +
                    $"\n DOKTOR: {dr.personAd + " " + dr.personSoyad} " +
                    $" \n RANDEVU: {DateTime.Today:dd MM yyyy} - {btn.Text}");
                dr.DrRandevulari.Add(yeniRandevu);
                HastaServis.HastaRandevulari.Add(yeniRandevu);
                Randevular.Add(yeniRandevu);
            }
            else
                throw new Exception("Randevu işlemi gerçekleştirilemedi. Lütfen tekrar deneyiniz");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void SecilenDrRandevuSaatleriButonları(Doktor dr, FlowLayoutPanel panel)
        {
            try
            {

                if (dr.DrRandevulari.Count > 0) // Eğer dr'nin randevuları varsa
                {
                    foreach (RandevuBilgileri item in dr.DrRandevulari)
                    {
                        foreach (RandevuSaatleriBtn b in panel.Controls) // Paneldeki butonları dön
                        {
                            if (item.RandevuSaat == b.btnSaat.Text)
                            {
                                b.RandevuAlindi = true;
                            }
                        }
                    }

                }
                else // Dr'nin randevusu hiç yok.
                {
                    foreach (RandevuSaatleriBtn b in panel.Controls) // Paneldeki butonları dön
                    {
                        b.RandevuAlindi = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Doktor seçiniz");
            }
        }

        public static void HastaninRandevulariniGetir(Hasta hasta, ListView lst)
        {
            lst.Items.Clear();
            foreach (RandevuBilgileri item in HastaServis.HastaRandevulari)
            {
                if (item.HastaBilgisi == hasta)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = hasta.personTCNo;
                    li.SubItems.Add(hasta.personAd);
                    li.SubItems.Add(hasta.personSoyad);
                    li.SubItems.Add(hasta.personCinsiyet.ToString());
                    li.SubItems.Add(hasta.personTel);
                    li.SubItems.Add(item.DoktorBilgisi.DoktorBrans.ToString());
                    li.SubItems.Add(item.RandevuZamani.ToShortDateString());
                    li.SubItems.Add(item.RandevuSaat);
                    li.SubItems.Add("Dr." + item.DoktorBilgisi.personAd + " " + item.DoktorBilgisi.personSoyad);
                    lst.Items.Add(li);
                    li.Tag = item;
                }
            }
        }
        public static void HastaninSadeceRandevuBilgisiniGetir(Hasta hasta, ListView lst)
        {
            lst.Items.Clear();
            foreach (RandevuBilgileri item in HastaServis.HastaRandevulari)
            {
                if (item.HastaBilgisi == hasta)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.RandevuZamani.ToShortDateString();
                    li.SubItems.Add(item.RandevuSaat);
                    li.SubItems.Add(item.DoktorBilgisi.DoktorBrans.ToString());
                    li.SubItems.Add("Dr." + item.DoktorBilgisi.personAd + " " + item.DoktorBilgisi.personSoyad);
                    lst.Items.Add(li);
                    li.Tag = item;
                }
            }
        }

        public static void DoktorunTumRandevulariniGetir(Doktor dr, ListView lstView)
        {
            lstView.Items.Clear();
            try
            {
                if (dr.DrRandevulari.Count > 0)
                {
                    foreach (RandevuBilgileri item in dr.DrRandevulari)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = DateTime.Today.ToShortDateString();
                        li.SubItems.Add(item.RandevuSaat);
                        li.SubItems.Add(item.HastaBilgisi.personAd);
                        li.SubItems.Add(item.HastaBilgisi.personSoyad);
                        li.SubItems.Add(item.HastaBilgisi.personCinsiyet.ToString());
                        li.SubItems.Add(item.HastaBilgisi.personDogumTarihi.ToShortDateString());
                        lstView.Items.Add(li);
                        li.Tag = item;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Görüntülenecek bir randevu bulunmuyor.");
            }

            }
        }
    }


