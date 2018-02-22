using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.models;
using HospitalAutomation.Services;

namespace HospitalAutomation
{
    public partial class KisiselBilgiler : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserControlKimBuKisi KimBuKisi { get; set; }
        public KisiselBilgiler()
        {
            InitializeComponent();
            rbYeniKayit.CheckedChanged += RadioBtn_CheckedChanged;
            rbGuncelle.CheckedChanged += RadioBtn_CheckedChanged;
            rbSil.CheckedChanged += RadioBtn_CheckedChanged;
        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;

            switch (radioBtn.Name)
            {
                case "rbYeniKayit":
                    btnKaydet.Enabled = true;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    textleriTemizle();
                    break;
                case "rbGuncelle":
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = false;
                    txtTcNo.Enabled = false;

                    break;
                case "rbSil":
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = true;
                    break;
                default:
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    break;
            }

        }

        private void textleriTemizle()
        {
            txtTcNo.Enabled = true;
            txtTcNo.Text = String.Empty;
            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtTelefon.Text = String.Empty;
            dtpDogumTarihi.Value = DateTime.Now;
            //cmbCinsiyet.SelectedIndex = -1;
        }

        public void GelenButonaGoreIslemleriYap(string btnName)
        {
            switch (btnName)
            {
                case "btnKaydet":
                    KaydetmeIslemi();
                    break;
                case "btnGuncelle":
                    GuncellemeIslemi();
                    break;
                case "btnSil":
                    SilmeIslemi();
                    break;
                default:
                    break;
            }
        }
        private void butunlara_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GelenButonaGoreIslemleriYap(btn.Name);
        }
        public void KaydetmeIslemi()
        {
            //UserControl Doktor işlemleri formundan mı Hemşire formundan mı? 
            //Ona göre yönlendirmeler yapılacak.
            try
            {
                switch (KimBuKisi)
                {
                    case UserControlKimBuKisi.Personel:
                        VeriIslemleri.YeniPersonelKaydet(txtTcNo.Text, txtAd.Text, txtSoyad.Text, dtpDogumTarihi.Value, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtMail.Text, txtTelefon.Text);
                        break;
                    case UserControlKimBuKisi.Doktor:
                        VeriIslemleri.YeniDoktorKaydet(txtTcNo.Text, txtAd.Text, txtSoyad.Text, dtpDogumTarihi.Value, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtMail.Text, txtTelefon.Text);
                        break;
                    case UserControlKimBuKisi.Hemsire:
                        VeriIslemleri.YeniHemsireKaydet(txtTcNo.Text, txtAd.Text, txtSoyad.Text, dtpDogumTarihi.Value, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtMail.Text, txtTelefon.Text);
                        break;
                    case UserControlKimBuKisi.Hasta:
                        VeriIslemleri.YeniHastaKaydet(txtTcNo.Text, txtAd.Text, txtSoyad.Text, dtpDogumTarihi.Value, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtMail.Text, txtTelefon.Text);
                        break;
                    default:
                        break;
                }
                LstBoxYenile(KimBuKisi);
                textleriTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LstBoxYenile(UserControlKimBuKisi kimBu)
        {
            lstKisiler.Items.Clear();
            if (kimBu == UserControlKimBuKisi.Doktor)
            {
                foreach (Doktor item in DoktorServis.DoktorListesi)
                {
                    lstKisiler.Items.Add(item);
                }
            }
            else if (kimBu == UserControlKimBuKisi.Hemsire)
            {
                foreach (Hemsire item in HemsireServis.HemsireListesi)
                {
                    lstKisiler.Items.Add(item);

                }
            }
            else if (kimBu == UserControlKimBuKisi.Hasta)
            {
                foreach (Hasta item in HastaServis.HastaListesi)
                {
                    lstKisiler.Items.Add(item);
                }
            }
            else if (kimBu == UserControlKimBuKisi.Personel)
            {
                foreach (Personel item in PersonelServis.PersonelListesi)
                {
                    lstKisiler.Items.Add(item);

                }
            }

        }
        public void GuncellemeIslemi()
        {
            //UserControl Doktor işlemleri formundan mı Hemşire formundan mı? 
            //Ona göre yönlendirmeler yapılacak.
            try
            {
                if (lstKisiler.SelectedIndex == -1)
                    MessageBox.Show("Güncelleme yapmak için Listeden kişi seçiniz");
                else
                {
                    switch (KimBuKisi)
                    {
                        case UserControlKimBuKisi.Personel:
                            VeriIslemleri.PersoneliGuncelle((Personel)lstKisiler.SelectedItem, txtAd.Text, txtSoyad.Text, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtTelefon.Text, dtpDogumTarihi.Value, txtMail.Text);
                            break;
                        case UserControlKimBuKisi.Doktor:
                            VeriIslemleri.DoktoruGuncelle((Doktor)lstKisiler.SelectedItem, txtAd.Text, txtSoyad.Text, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtTelefon.Text, dtpDogumTarihi.Value, txtMail.Text);
                            break;
                        case UserControlKimBuKisi.Hemsire:
                            VeriIslemleri.HemsireyiGuncelle((Hemsire)lstKisiler.SelectedItem, txtAd.Text, txtSoyad.Text, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtTelefon.Text, dtpDogumTarihi.Value, txtMail.Text);
                            break;
                        case UserControlKimBuKisi.Hasta:
                            VeriIslemleri.HastayiGuncelle((Hasta)lstKisiler.SelectedItem, txtAd.Text, txtSoyad.Text, (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()), txtTelefon.Text, dtpDogumTarihi.Value, txtMail.Text);
                            break;
                        default:
                            break;
                    }
                    LstBoxYenile(KimBuKisi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uygun olmayan veri girişi nedeniyle Güncelleme işlemi yapılamadı. Lütfen tekrar deneyiniz"); ;
            }
        }
        public void SilmeIslemi()
        {
            //UserControl Doktor işlemleri formundan mı Hemşire formundan mı? 
            //Ona göre yönlendirmeler yapılacak.
            try
            {
                if (lstKisiler.SelectedIndex == -1)
                    MessageBox.Show("Silme işlemi için listeden kişi seçiniz.");
                else
                {
                    switch (KimBuKisi)
                    {
                        case UserControlKimBuKisi.Personel:
                            VeriIslemleri.PersoneliSil((Personel)lstKisiler.SelectedItem);
                            break;
                        case UserControlKimBuKisi.Doktor:
                            VeriIslemleri.DoktoruSil((Doktor)lstKisiler.SelectedItem);
                            break;
                        case UserControlKimBuKisi.Hemsire:
                            VeriIslemleri.HemsireyiSil((Hemsire)lstKisiler.SelectedItem);
                            break;
                        case UserControlKimBuKisi.Hasta:
                            VeriIslemleri.HastayiSil((Hasta)lstKisiler.SelectedItem);
                            break;
                        default:
                            break;
                    }
                    LstBoxYenile(KimBuKisi);
                    textleriTemizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işleminde bir hata oluştu. Lütfen daha sonra tekrar deneyiniz"); ;
            }

        }
        private void KisiselBilgiler_Load(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbCinsiyet.SelectedIndex = 0;
            txtTcNo.MaxLength = 11;
        }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KimBuKisi == UserControlKimBuKisi.Doktor)
                LstBoxtanSecileniTexteDoldur((Doktor)(lstKisiler.SelectedItem));
            else if (KimBuKisi == UserControlKimBuKisi.Hemsire)
                LstBoxtanSecileniTexteDoldur((Hemsire)(lstKisiler.SelectedItem));
            else if (KimBuKisi == UserControlKimBuKisi.Hasta)
                LstBoxtanSecileniTexteDoldur((Hasta)(lstKisiler.SelectedItem));
            else if (KimBuKisi == UserControlKimBuKisi.Personel)
                LstBoxtanSecileniTexteDoldur((Personel)(lstKisiler.SelectedItem));
        }
        private void LstBoxtanSecileniTexteDoldur(Doktor secilenDr)
        {
            try
            {
                txtTcNo.Text = secilenDr.personTCNo;
                txtAd.Text = secilenDr.personAd;
                txtSoyad.Text = secilenDr.personSoyad;
                txtTelefon.Text = secilenDr.personTel;
                txtMail.Text = secilenDr.personMail;
                dtpDogumTarihi.Value = secilenDr.personDogumTarihi;
                cmbCinsiyet.SelectedItem = secilenDr.personCinsiyet.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız.");
            }

        }
        private void LstBoxtanSecileniTexteDoldur(Hemsire secilenHemsire)
        {

            try
            {
                txtTcNo.Text = secilenHemsire.personTCNo;
                txtAd.Text = secilenHemsire.personAd;
                txtSoyad.Text = secilenHemsire.personSoyad;
                txtTelefon.Text = secilenHemsire.personTel;
                txtMail.Text = secilenHemsire.personMail;
                dtpDogumTarihi.Value = secilenHemsire.personDogumTarihi;
                cmbCinsiyet.SelectedItem = secilenHemsire.personCinsiyet.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Listeden seçim yapınız.");
            }

        }
        private void LstBoxtanSecileniTexteDoldur(Hasta secilenHasta)
        {
            try
            {
                txtTcNo.Text = secilenHasta.personTCNo;
                txtAd.Text = secilenHasta.personAd;
                txtSoyad.Text = secilenHasta.personSoyad;
                txtTelefon.Text = secilenHasta.personTel;
                txtMail.Text = secilenHasta.personMail;
                dtpDogumTarihi.Value = secilenHasta.personDogumTarihi;
                cmbCinsiyet.SelectedItem = secilenHasta.personCinsiyet.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız.");
            }
        }
        private void LstBoxtanSecileniTexteDoldur(Personel secilenPersonel)
        {

            try
            {
                txtTcNo.Text = secilenPersonel.personTCNo;
                txtAd.Text = secilenPersonel.personAd;
                txtSoyad.Text = secilenPersonel.personSoyad;
                txtTelefon.Text = secilenPersonel.personTel;
                txtMail.Text = secilenPersonel.personMail;
                dtpDogumTarihi.Value = secilenPersonel.personDogumTarihi;
                cmbCinsiyet.SelectedItem = secilenPersonel.personCinsiyet.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Listeden seçim yapınız.");
            }

        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            LstBoxYenile(KimBuKisi);
            VeriIslemleri.AramaIslemi(txtArama.Text, lstKisiler);
        }
    }
    public enum UserControlKimBuKisi
    {
        Personel = 0,
        Doktor = 1,
        Hemsire = 2,
        Hasta = 3
    }

}
