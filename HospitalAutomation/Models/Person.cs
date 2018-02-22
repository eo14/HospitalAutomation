using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.models
{
    public abstract class Person
    {
        private string _tcNo;
        private string _ad;
        private string _soyad;
        private int _yas;
        private DateTime _dogumTrh;
        public int Yas {
            get
            {
                return _yas;
            }
        }
        public Guid personGuid { get; } = new Guid();
        public string personTCNo
        {
            get
            {
                return _tcNo;
            }
            set
            {
                _tcNo = TCKimlikValidaiton(value);
            }
        }
        public string personAd
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = AdSoyadValidation(value);
            }
        }
        public string personSoyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = AdSoyadValidation(value);
            }
        }
        public DateTime personDogumTarihi {
            get
            {
                return _dogumTrh;
            }
            set
            {
                _dogumTrh = YasHesapla(value);
            }
        }
        public Cinsiyet personCinsiyet { get; set; }
        public string personMail { get; set; }
        public string personTel { get; set; }
        public PersonKisiTipi KisiTipi { get; set; }

        #region Validationİslemleri
        private string AdSoyadValidation(string kelime)
        {

            
                kelime = kelime.Trim();
                foreach (char item in kelime)
                {
                    if (!char.IsLetter(item) || char.IsWhiteSpace(item))
                        throw new Exception("Ad veya soyadda geersiz karakter bulunmaktadır.");
                }
                if (kelime.Length < 2)
                    throw new Exception("Ad veya soyad en az 2 karakter olmalıdır.");

        
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);

        }

        private string TCKimlikValidaiton(string tc)
        {
            
                if (tc.Length != 11)
                    throw new Exception("TC numarası 11 haneli olmalıdır");
                foreach (char item in tc.ToArray())
                {
                    if (!char.IsDigit(item))
                        throw new Exception("TC numarası rakamlardan oluşmalıdır");
                }
                if (Convert.ToInt32(tc[10]) % 2 != 0)
                {
                    throw new Exception("TC numarasının son rakamı çift olmalıdır");
                }
            if (tc[0] == '0')
            {
                throw new Exception("TC numarası 0 ile başlayamaz");
            }

            return tc;
        }
        private DateTime YasHesapla(DateTime tarih)
        {
            TimeSpan aralik = DateTime.Now - tarih;
            double yil = aralik.TotalDays / 365;
            this._yas = (int)yil;
            return tarih;
        }
        #endregion
    }

    public enum PersonKisiTipi
    {
        Doktor = 0,
        Hemsire = 1,
        Hasta = 2,
        Personel = 3
    }
    public enum Cinsiyet
    {
        Bay = 0,
        Bayan = 1
    }
}
