using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.models
{
    public class Personel:Person, IMaasAlabilen
    {
        public Birimler PersonelBirim { get; set; }
        public decimal Maas { get; set; }
        public override string ToString()
        {
            return $" {this.personTCNo} - {this.personAd} {this.personSoyad} ";
        }
    }
   
    public enum Birimler
    {
        BirimYok=0,
        Hastabakıcı=1,
        GuvenlikGörevlisi=2,
        HalklaIliskiler=3,
        Muhasebe =4
        
    }
}
