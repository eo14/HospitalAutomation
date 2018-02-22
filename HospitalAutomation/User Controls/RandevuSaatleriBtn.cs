using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class RandevuSaatleriBtn : UserControl
    {
        public RandevuSaatleriBtn()
        {
            InitializeComponent();
        }

        private bool _randevuAlindi;
        public bool RandevuAlindi

        {
            get
            {
                return _randevuAlindi;
            }
            set
            {
                _randevuAlindi = value;
                if (_randevuAlindi)
                {
                    //btnSaat.Enabled = false;
                    btnSaat.BackColor = Color.DarkGray;
                    this.Enabled = false;
                }
                else
                {
                    this.Enabled = true;
                    btnSaat.Enabled = true;
                    btnSaat.BackColor = Color.White;

                }

            }

        }
        
        public string BtnText
        {
            get {
                return btnSaat.Text;
            }
                
                set
            {
               
               this.btnSaat.Text = value;
                
            }

        }

        private void btnSaat_Click(object sender, EventArgs e)
        {
            btnSaat.BackColor = Color.LightPink;
            BtnText = btnSaat.Text;
        }

        private void RandevuSaatleriBtn_Load(object sender, EventArgs e)
        {
            btnSaat.BackColor = Color.GhostWhite;
            btnSaat.ForeColor = Color.Black;
        }

    }
}
