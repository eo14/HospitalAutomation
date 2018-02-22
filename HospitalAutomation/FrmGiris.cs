using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        string kullaniciAdi, parola;
   
        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtKullanici.Clear();
            txtParola.Clear();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                kullaniciAdi = txtKullanici.Text;
                parola = txtParola.Text;
                if (kullaniciAdi.ToLower() == "admin" && parola == "1234")
                {
                    //MessageBox.Show("Giriş Başarılı!");
                    new FrmContainer().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız veya Parolanız Hatalı!", "..::HATA::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

