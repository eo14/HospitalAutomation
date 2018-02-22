using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.models
{
    public class Hasta:Person
    {
       public  static List<RandevuBilgileri> HastaRandevulari = new List<RandevuBilgileri>();
        public override string ToString()
        {
            return $" {this.personTCNo} - {this.personAd} {this.personSoyad} - {this.personCinsiyet}";
               
        }
    }
}
