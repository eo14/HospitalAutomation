using HospitalAutomation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Services
{
    public class HastaServis : Hasta
    {
        public static List<Hasta> HastaListesi = new List<Hasta>();
        public static void TumHastalariListBoxaGetir(ListBox lstHasta)
        {
            foreach (Hasta item in HastaServis.HastaListesi)
            {
                lstHasta.Items.Add(item);
            }

        }
        public static void TCnumarasinaGoreHastaAra(string arama, ListBox listHasta)
        {
            List<Hasta> sonucList = new List<Hasta>();

            try
            {
                if (arama.Length >=3)
                {
                    if (listHasta.Items.Count > 0)
                    {
                        foreach (char item in arama)
                        {
                            if (!char.IsDigit(item))
                            {
                                throw new Exception("Lütfen geçerli bir Tc Kimlik numarası giriniz.");

                            }
                        }
                        foreach (Hasta item in listHasta.Items)
                        {
                            if (item.personTCNo.Contains(arama))
                            {
                                sonucList.Add(item);
                            }

                        }
                        listHasta.Items.Clear();
                        foreach (Hasta item in sonucList)
                        {
                            listHasta.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Listede aranacak kişi bulunmamaktadır!");
                    }

                }
                else
                {
                    listHasta.Items.Clear();
                    TumHastalariListBoxaGetir(listHasta);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
    }


}

