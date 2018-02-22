using HospitalAutomation.models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HospitalAutomation.Services
{
    public static class DisariveIceriAktarServis
    {

        public static void XMLPersonaGoreDisariAktar(UserControlKimBuKisi kisiKim, SaveFileDialog dosyaKaydet)
        {

            //XML ile dışarı aktarma işlemi yapılacak.

            switch (kisiKim)
            {
                case UserControlKimBuKisi.Personel:
                    if (PersonelServis.PersonelListesi.Count == 0)
                    {
                        MessageBox.Show("Dışarı aktarılacak bir lsite bulunmamaktadır.");
                        return;
                    }
                    dosyaKaydet.Title = $"{PersonelServis.PersonelListesi.Count} adet kadar kişi dışarı aktarılacak.";
                    dosyaKaydet.Filter = "XML FORMATI: | *.xml";
                    dosyaKaydet.FileName = string.Empty;
                    dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personel>));
                        using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                        {
                            xmlSerializer.Serialize(writer, PersonelServis.PersonelListesi);
                            writer.Close();
                        }
                        MessageBox.Show("XML aktarma işlemi başarılı");
                    }

                    break;
                case UserControlKimBuKisi.Doktor:
                    if (DoktorServis.DoktorListesi.Count == 0)
                    {
                        MessageBox.Show("Dışarı aktarılacak bir lsite bulunmamaktadır.");
                        return;
                    }
                    dosyaKaydet.Title = $"{DoktorServis.DoktorListesi.Count} adet kadar kişi dışarı aktarılacak.";
                    dosyaKaydet.Filter = "XML FORMATI: | *.xml";
                    dosyaKaydet.FileName = string.Empty;
                    dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Doktor>));
                        using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                        {
                            xmlSerializer.Serialize(writer, DoktorServis.DoktorListesi);
                            writer.Close();
                        }
                        MessageBox.Show("XML aktarma işlemi başarılı");
                    }

                    break;
                case UserControlKimBuKisi.Hemsire:
                    if (HemsireServis.HemsireListesi.Count == 0)
                    {
                        MessageBox.Show("Dışarı aktarılacak bir lsite bulunmamaktadır.");
                        return;
                    }
                    dosyaKaydet.Title = $"{HemsireServis.HemsireListesi.Count} adet kadar kişi dışarı aktarılacak.";
                    dosyaKaydet.Filter = "XML FORMATI: | *.xml";
                    dosyaKaydet.FileName = string.Empty;
                    dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Hemsire>));
                        using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                        {
                            xmlSerializer.Serialize(writer, HemsireServis.HemsireListesi);
                            writer.Close();
                        }
                        MessageBox.Show("XML aktarma işlemi başarılı");
                    }

                    break;
                case UserControlKimBuKisi.Hasta:
                    if (HastaServis.HastaListesi.Count == 0)
                    {
                        MessageBox.Show("Dışarı aktarılacak bir lsite bulunmamaktadır.");
                        return;
                    }
                    dosyaKaydet.Title = $"{HastaServis.HastaListesi.Count} adet kadar kişi dışarı aktarılacak.";
                    dosyaKaydet.Filter = "XML FORMATI: | *.xml";
                    dosyaKaydet.FileName = string.Empty;
                    dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Hasta>));
                        using (TextWriter writer = new StreamWriter(dosyaKaydet.FileName))
                        {
                            xmlSerializer.Serialize(writer, HastaServis.HastaListesi);
                            writer.Close();
                        }
                        MessageBox.Show("XML aktarma işlemi başarılı");
                    }

                    break;
                default:
                    break;
            }

        }
        public static void XMLPersonaGoreIceriAktar(KisiselBilgiler usercontrl, OpenFileDialog dosyaAc)
        {
            //Dışarıdaki XML dosyasını içeri aktarır.
            dosyaAc.Title = "Bir Kişi XML dosyası seçiniz";
            dosyaAc.Filter = "XML FORMATI: |*.xml";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
            if (usercontrl.KimBuKisi == UserControlKimBuKisi.Doktor)
            {
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Doktor>));
                    using (TextReader reader = new StreamReader(dosyaAc.FileName)) //Burada TextReader oluşturdu. StreamReader ile de aldı ve ismini de dosyaAcFilename ile aldı.
                    {
                        DoktorServis.DoktorListesi = xmlserializer.Deserialize(reader) as List<Doktor>;
                        reader.Close();
                        MessageBox.Show($"{DoktorServis.DoktorListesi.Count} kadar kişi listeye aktarıldı.");
                    }

                }

            }
            else if (usercontrl.KimBuKisi == UserControlKimBuKisi.Hemsire)
            {
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Hemsire>));
                    using (TextReader reader = new StreamReader(dosyaAc.FileName)) //Burada TextReader oluşturdu. StreamReader ile de aldı ve ismini de dosyaAcFilename ile aldı.
                    {
                        HemsireServis.HemsireListesi = xmlserializer.Deserialize(reader) as List<Hemsire>;
                        reader.Close();
                        MessageBox.Show($"{HemsireServis.HemsireListesi.Count} kadar kişi listeye aktarıldı.");
                    }
                }
            }
            else if (usercontrl.KimBuKisi == UserControlKimBuKisi.Hasta)
            {
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Hasta>));
                    using (TextReader reader = new StreamReader(dosyaAc.FileName)) //Burada TextReader oluşturdu. StreamReader ile de aldı ve ismini de dosyaAcFilename ile aldı.
                    {
                        HastaServis.HastaListesi = xmlserializer.Deserialize(reader) as List<Hasta>;
                        reader.Close();
                        MessageBox.Show($"{HastaServis.HastaListesi.Count} kadar kişi listeye aktarıldı.");
                    }
                }
            }
            else if (usercontrl.KimBuKisi == UserControlKimBuKisi.Personel)
            {
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Personel>));
                    using (TextReader reader = new StreamReader(dosyaAc.FileName)) //Burada TextReader oluşturdu. StreamReader ile de aldı ve ismini de dosyaAcFilename ile aldı.
                    {
                        PersonelServis.PersonelListesi = xmlserializer.Deserialize(reader) as List<Personel>;
                        reader.Close();
                        MessageBox.Show($"{PersonelServis.PersonelListesi.Count} kadar kişi listeye aktarıldı.");
                    }
                }
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen içeri aktarmak için uygun bir dosya seçniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop); ;
            }

        }
        public static void JsonRandevulariDisariAktar(SaveFileDialog dosyaKaydet)
        {
            if (RandevuServis.Randevular.Count > 0)
            {
                foreach (RandevuBilgileri item in RandevuServis.Randevular)
                {
                    RandevuBilgileriStringi Bilgi = new RandevuBilgileriStringi()
                    {
                        DoktorBilgisi = item.DoktorBilgisi.personAd + " " + item.DoktorBilgisi.personSoyad,
                        HastaBilgisi = item.HastaBilgisi.personAd + " " + item.HastaBilgisi.personSoyad,
                        RandevuSaat = item.RandevuSaat,
                        RandevuZamani = item.RandevuZamani
                    };
                    RandevuBilgileriStringi.Liste.Add(Bilgi);
                }

                dosyaKaydet.Filter = "JSON Format | *.json";
                dosyaKaydet.FileName = string.Empty;
                dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = File.Open(dosyaKaydet.FileName, FileMode.OpenOrCreate);
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        writer.Write(JsonConvert.SerializeObject(RandevuBilgileriStringi.Liste));
                        writer.Close();
                        file.Close();
                    }

                    MessageBox.Show("JSON aktarma işlemi başarılı");
                }
            }
            else
            {
                MessageBox.Show("Dışarı aktarılacak herhangi bir randevu bulunmuyor.");
            }

        }
        public static void JsonRandevulariIceriAktar(OpenFileDialog dosyaAc)
        {
            dosyaAc.Title = "Bir Randevu JSON dosyasını seçiniz";
            dosyaAc.Filter = "Json Format | *.json";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                if (dosyaAc.ShowDialog() == DialogResult.OK)
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string icerik = reader.ReadToEnd();
                    dosya.Close();
                    reader.Close();
                    RandevuBilgileriStringi.Liste = JsonConvert.DeserializeObject<List<RandevuBilgileriStringi>>(icerik);
                    // Dönüştürme //
                    foreach (RandevuBilgileriStringi item in RandevuBilgileriStringi.Liste)
                    {
                        RandevuBilgileri rnd = new RandevuBilgileri();
                        Doktor buDoktor = new Doktor();
                        rnd.RandevuSaat = item.RandevuSaat;
                        rnd.RandevuZamani = item.RandevuZamani;
                        foreach (Hasta hst in HastaServis.HastaListesi)
                        {
                            if (hst.personAd + " " + hst.personSoyad == item.HastaBilgisi)
                                rnd.HastaBilgisi = hst;

                            foreach (Doktor dr in DoktorServis.DoktorListesi)
                            {
                                if (dr.personAd + " " + dr.personSoyad == item.DoktorBilgisi)
                                {
                                    rnd.DoktorBilgisi = dr;
                                    buDoktor = dr;
                                }

                            }
                        }
                        buDoktor.DrRandevulari.Add(rnd);
                        HastaServis.HastaRandevulari.Add(rnd);
                        RandevuServis.Randevular.Add(rnd);


                    }
                    MessageBox.Show($"{RandevuServis.Randevular.Count} adet randevu programa aktarıldı");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen içeri aktarmak için uygun bir dosya seçniz.", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Stop);;
            }

        }



    }
}

