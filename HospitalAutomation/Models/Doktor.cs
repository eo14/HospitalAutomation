using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.models
{
    public class Doktor:Person,IMaasAlabilen
    {
        public Branslar DoktorBrans { get; set; }
        private decimal _drMaas;
        public decimal Maas
        {
            get
            {
                return _drMaas;
            }

            set
            {
                _drMaas = value;
            }
        }

        public List<Hemsire> DrHemsireleri = new List<Hemsire>();
        public  List<RandevuBilgileri> DrRandevulari = new List<RandevuBilgileri>();

        public override string ToString()
        {
            return $" {this.personTCNo} - Dr. {this.personAd} {this.personSoyad} ";
        }

    }
    
    public enum Branslar
    {
        BransYok = 0,
        KBB = 1,
        Göz = 2,
        Ortopedi = 3,
        GenelCerrahi = 4,
        Dahiliye = 5,
        Diş = 6,
        Dermatoloji = 7,
        Noroloji = 8,
        Psikiatri = 9,
    }
}
