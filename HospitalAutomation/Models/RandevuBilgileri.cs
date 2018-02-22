using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.models
{
    public class RandevuBilgileri
    {
        public Doktor DoktorBilgisi { get; set; }
        public  Hasta HastaBilgisi { get; set; }
        public DateTime RandevuZamani { get; set; }
        public String RandevuSaat { get; set; }
    }
    public class RandevuBilgileriStringi //Json için oluşturduk. Çünkü içindeki classları string olarak alamadı. 
    {
       public static List<RandevuBilgileriStringi> Liste = new List<RandevuBilgileriStringi>();
        public string DoktorBilgisi { get; set; }
        public string HastaBilgisi { get; set; }
        public DateTime RandevuZamani { get; set; }
        public String RandevuSaat { get; set; }

    }
}
