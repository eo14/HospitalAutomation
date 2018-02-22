using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.models
{
    public class Hemsire : Person,IMaasAlabilen
    {
        public Doktor HemsireDR { get; set; } = null;

        public Branslar HemsireBrans { get; set; }

        private decimal _hemsireMaas;
        public decimal Maas
        {
            get
            {
                return _hemsireMaas;
            }

            set
            {
                _hemsireMaas = value;
            }
        }
        public override string ToString()
        {
            string sonuc = string.Empty;
            if (this.HemsireDR == null)
                sonuc = $" {this.personTCNo} - {this.personAd} {this.personSoyad} - Doktoru henüz atanmamş";

            else
                sonuc = $" {this.personTCNo} - {this.personAd} {this.personSoyad} - Dr.{this.HemsireDR.personAd + this.HemsireDR.personSoyad}";

            return sonuc;

        }

    }
}
