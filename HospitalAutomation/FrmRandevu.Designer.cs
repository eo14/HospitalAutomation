namespace HospitalAutomation
{
    partial class FrmRandevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstHasta = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaArama = new System.Windows.Forms.TextBox();
            this.RandevutabControl = new System.Windows.Forms.TabControl();
            this.RandevuAlTabPage = new System.Windows.Forms.TabPage();
            this.lstViewHastaRandevuları = new System.Windows.Forms.ListView();
            this.tckimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuTrh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRndIslemleri = new System.Windows.Forms.GroupBox();
            this.btnRandevuSec = new System.Windows.Forms.Button();
            this.flowLayoutPanelSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btn0900 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn0915 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn0930 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn0945 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1000 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1015 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1030 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1045 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1100 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1115 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1130 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1145 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1300 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1315 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1330 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1345 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1400 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1415 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1430 = new HospitalAutomation.RandevuSaatleriBtn();
            this.btn1445 = new HospitalAutomation.RandevuSaatleriBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHasta = new System.Windows.Forms.GroupBox();
            this.servisDrtabPage = new System.Windows.Forms.TabPage();
            this.listViewDr = new System.Windows.Forms.ListView();
            this.rndTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogumtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxDr = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxSrvs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaRandevutabPage = new System.Windows.Forms.TabPage();
            this.lblHastaKim = new System.Windows.Forms.Label();
            this.listViewHastaRandevulari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxHastaTabPage = new System.Windows.Forms.ListBox();
            this.txtTcAramaTabPage = new System.Windows.Forms.TextBox();
            this.menuStripRandevu = new System.Windows.Forms.MenuStrip();
            this.dosyaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disariAktarRndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceriAktarRndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetDosya = new System.Windows.Forms.SaveFileDialog();
            this.acDosya = new System.Windows.Forms.OpenFileDialog();
            this.RandevutabControl.SuspendLayout();
            this.RandevuAlTabPage.SuspendLayout();
            this.gbRndIslemleri.SuspendLayout();
            this.flowLayoutPanelSaatler.SuspendLayout();
            this.gbHasta.SuspendLayout();
            this.servisDrtabPage.SuspendLayout();
            this.HastaRandevutabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStripRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHasta
            // 
            this.lstHasta.FormattingEnabled = true;
            this.lstHasta.Location = new System.Drawing.Point(8, 55);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(292, 225);
            this.lstHasta.TabIndex = 0;
            this.lstHasta.SelectedIndexChanged += new System.EventHandler(this.lstHasta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HastaTC NO:";
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(90, 14);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(119, 21);
            this.cmbServis.TabIndex = 2;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.Location = new System.Drawing.Point(11, 57);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(198, 225);
            this.lstDoktor.TabIndex = 3;
            this.lstDoktor.SelectedIndexChanged += new System.EventHandler(this.lstDoktor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servis Seçiniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor Seçiniz:";
            // 
            // txtHastaArama
            // 
            this.txtHastaArama.Location = new System.Drawing.Point(81, 20);
            this.txtHastaArama.Name = "txtHastaArama";
            this.txtHastaArama.Size = new System.Drawing.Size(218, 20);
            this.txtHastaArama.TabIndex = 6;
            this.txtHastaArama.TextChanged += new System.EventHandler(this.txtHastaArama_TextChanged);
            // 
            // RandevutabControl
            // 
            this.RandevutabControl.Controls.Add(this.RandevuAlTabPage);
            this.RandevutabControl.Controls.Add(this.servisDrtabPage);
            this.RandevutabControl.Controls.Add(this.HastaRandevutabPage);
            this.RandevutabControl.Location = new System.Drawing.Point(0, 24);
            this.RandevutabControl.Name = "RandevutabControl";
            this.RandevutabControl.SelectedIndex = 0;
            this.RandevutabControl.Size = new System.Drawing.Size(911, 480);
            this.RandevutabControl.TabIndex = 51;
            this.RandevutabControl.SelectedIndexChanged += new System.EventHandler(this.RandevutabControl_SelectedIndexChanged);
            // 
            // RandevuAlTabPage
            // 
            this.RandevuAlTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RandevuAlTabPage.Controls.Add(this.lstViewHastaRandevuları);
            this.RandevuAlTabPage.Controls.Add(this.gbRndIslemleri);
            this.RandevuAlTabPage.Controls.Add(this.gbHasta);
            this.RandevuAlTabPage.Location = new System.Drawing.Point(4, 22);
            this.RandevuAlTabPage.Name = "RandevuAlTabPage";
            this.RandevuAlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RandevuAlTabPage.Size = new System.Drawing.Size(903, 454);
            this.RandevuAlTabPage.TabIndex = 0;
            this.RandevuAlTabPage.Text = "Randevu Al";
            // 
            // lstViewHastaRandevuları
            // 
            this.lstViewHastaRandevuları.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tckimlik,
            this.hastAdi,
            this.hastaSoyadi,
            this.cinsiyeti,
            this.tel,
            this.bolum,
            this.randevuTrh,
            this.randevuSaat,
            this.doktor});
            this.lstViewHastaRandevuları.FullRowSelect = true;
            this.lstViewHastaRandevuları.GridLines = true;
            this.lstViewHastaRandevuları.Location = new System.Drawing.Point(12, 315);
            this.lstViewHastaRandevuları.Name = "lstViewHastaRandevuları";
            this.lstViewHastaRandevuları.Size = new System.Drawing.Size(880, 131);
            this.lstViewHastaRandevuları.TabIndex = 53;
            this.lstViewHastaRandevuları.UseCompatibleStateImageBehavior = false;
            this.lstViewHastaRandevuları.View = System.Windows.Forms.View.Details;
            // 
            // tckimlik
            // 
            this.tckimlik.Text = "Tc Kimlik No";
            this.tckimlik.Width = 92;
            // 
            // hastAdi
            // 
            this.hastAdi.Text = "Hast aAdi";
            this.hastAdi.Width = 89;
            // 
            // hastaSoyadi
            // 
            this.hastaSoyadi.Text = "Hasta Soyadi";
            this.hastaSoyadi.Width = 91;
            // 
            // cinsiyeti
            // 
            this.cinsiyeti.Text = "Cinsiyet";
            // 
            // tel
            // 
            this.tel.Text = "Telefon";
            this.tel.Width = 72;
            // 
            // bolum
            // 
            this.bolum.Text = "Bölüm";
            this.bolum.Width = 73;
            // 
            // randevuTrh
            // 
            this.randevuTrh.Text = "Randevu Tarih";
            this.randevuTrh.Width = 105;
            // 
            // randevuSaat
            // 
            this.randevuSaat.Text = "Randevu Saat";
            this.randevuSaat.Width = 97;
            // 
            // doktor
            // 
            this.doktor.Text = "Doktor";
            this.doktor.Width = 83;
            // 
            // gbRndIslemleri
            // 
            this.gbRndIslemleri.Controls.Add(this.btnRandevuSec);
            this.gbRndIslemleri.Controls.Add(this.flowLayoutPanelSaatler);
            this.gbRndIslemleri.Controls.Add(this.cmbServis);
            this.gbRndIslemleri.Controls.Add(this.lstDoktor);
            this.gbRndIslemleri.Controls.Add(this.label4);
            this.gbRndIslemleri.Controls.Add(this.label5);
            this.gbRndIslemleri.Controls.Add(this.label1);
            this.gbRndIslemleri.Location = new System.Drawing.Point(345, 16);
            this.gbRndIslemleri.Name = "gbRndIslemleri";
            this.gbRndIslemleri.Size = new System.Drawing.Size(547, 293);
            this.gbRndIslemleri.TabIndex = 52;
            this.gbRndIslemleri.TabStop = false;
            this.gbRndIslemleri.Text = "Randevu İşlemleri:";
            // 
            // btnRandevuSec
            // 
            this.btnRandevuSec.Location = new System.Drawing.Point(231, 259);
            this.btnRandevuSec.Name = "btnRandevuSec";
            this.btnRandevuSec.Size = new System.Drawing.Size(295, 28);
            this.btnRandevuSec.TabIndex = 7;
            this.btnRandevuSec.Text = "RANDEVU SEÇ";
            this.btnRandevuSec.UseVisualStyleBackColor = true;
            this.btnRandevuSec.Click += new System.EventHandler(this.btnRandevuSec_Click);
            // 
            // flowLayoutPanelSaatler
            // 
            this.flowLayoutPanelSaatler.Controls.Add(this.btn0900);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn0915);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn0930);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn0945);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1000);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1015);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1030);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1045);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1100);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1115);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1130);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1145);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1300);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1315);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1330);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1345);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1400);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1415);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1430);
            this.flowLayoutPanelSaatler.Controls.Add(this.btn1445);
            this.flowLayoutPanelSaatler.Location = new System.Drawing.Point(230, 40);
            this.flowLayoutPanelSaatler.Name = "flowLayoutPanelSaatler";
            this.flowLayoutPanelSaatler.Size = new System.Drawing.Size(295, 215);
            this.flowLayoutPanelSaatler.TabIndex = 75;
            // 
            // btn0900
            // 
            this.btn0900.BtnText = "09:00";
            this.btn0900.Location = new System.Drawing.Point(3, 3);
            this.btn0900.Name = "btn0900";
            this.btn0900.RandevuAlindi = false;
            this.btn0900.Size = new System.Drawing.Size(67, 36);
            this.btn0900.TabIndex = 51;
            this.btn0900.Click += new System.EventHandler(this.FrmRandevu_Load);
            // 
            // btn0915
            // 
            this.btn0915.BtnText = "09:15";
            this.btn0915.Location = new System.Drawing.Point(76, 3);
            this.btn0915.Name = "btn0915";
            this.btn0915.RandevuAlindi = false;
            this.btn0915.Size = new System.Drawing.Size(67, 36);
            this.btn0915.TabIndex = 52;
            this.btn0915.Click += new System.EventHandler(this.UserCntrlBtn_Click);
            // 
            // btn0930
            // 
            this.btn0930.BtnText = "09:30";
            this.btn0930.Location = new System.Drawing.Point(149, 3);
            this.btn0930.Name = "btn0930";
            this.btn0930.RandevuAlindi = false;
            this.btn0930.Size = new System.Drawing.Size(67, 36);
            this.btn0930.TabIndex = 53;
            this.btn0930.Click += new System.EventHandler(this.UserCntrlBtn_Click);
            // 
            // btn0945
            // 
            this.btn0945.BtnText = "09:45";
            this.btn0945.Location = new System.Drawing.Point(222, 3);
            this.btn0945.Name = "btn0945";
            this.btn0945.RandevuAlindi = false;
            this.btn0945.Size = new System.Drawing.Size(67, 36);
            this.btn0945.TabIndex = 54;
            this.btn0945.Click += new System.EventHandler(this.UserCntrlBtn_Click);
            // 
            // btn1000
            // 
            this.btn1000.BtnText = "10:00";
            this.btn1000.Location = new System.Drawing.Point(3, 45);
            this.btn1000.Name = "btn1000";
            this.btn1000.RandevuAlindi = false;
            this.btn1000.Size = new System.Drawing.Size(67, 36);
            this.btn1000.TabIndex = 55;
            // 
            // btn1015
            // 
            this.btn1015.BtnText = "10:15";
            this.btn1015.Location = new System.Drawing.Point(76, 45);
            this.btn1015.Name = "btn1015";
            this.btn1015.RandevuAlindi = false;
            this.btn1015.Size = new System.Drawing.Size(67, 36);
            this.btn1015.TabIndex = 56;
            // 
            // btn1030
            // 
            this.btn1030.BtnText = "10:30";
            this.btn1030.Location = new System.Drawing.Point(149, 45);
            this.btn1030.Name = "btn1030";
            this.btn1030.RandevuAlindi = false;
            this.btn1030.Size = new System.Drawing.Size(67, 36);
            this.btn1030.TabIndex = 57;
            // 
            // btn1045
            // 
            this.btn1045.BtnText = "10:45";
            this.btn1045.Location = new System.Drawing.Point(222, 45);
            this.btn1045.Name = "btn1045";
            this.btn1045.RandevuAlindi = false;
            this.btn1045.Size = new System.Drawing.Size(67, 36);
            this.btn1045.TabIndex = 58;
            // 
            // btn1100
            // 
            this.btn1100.BtnText = "11:00";
            this.btn1100.Location = new System.Drawing.Point(3, 87);
            this.btn1100.Name = "btn1100";
            this.btn1100.RandevuAlindi = false;
            this.btn1100.Size = new System.Drawing.Size(67, 36);
            this.btn1100.TabIndex = 59;
            // 
            // btn1115
            // 
            this.btn1115.BtnText = "11:15";
            this.btn1115.Location = new System.Drawing.Point(76, 87);
            this.btn1115.Name = "btn1115";
            this.btn1115.RandevuAlindi = false;
            this.btn1115.Size = new System.Drawing.Size(67, 36);
            this.btn1115.TabIndex = 60;
            // 
            // btn1130
            // 
            this.btn1130.BtnText = "11:30";
            this.btn1130.Location = new System.Drawing.Point(149, 87);
            this.btn1130.Name = "btn1130";
            this.btn1130.RandevuAlindi = false;
            this.btn1130.Size = new System.Drawing.Size(67, 36);
            this.btn1130.TabIndex = 61;
            // 
            // btn1145
            // 
            this.btn1145.BtnText = "11:45";
            this.btn1145.Location = new System.Drawing.Point(222, 87);
            this.btn1145.Name = "btn1145";
            this.btn1145.RandevuAlindi = false;
            this.btn1145.Size = new System.Drawing.Size(67, 36);
            this.btn1145.TabIndex = 62;
            // 
            // btn1300
            // 
            this.btn1300.BtnText = "13:00";
            this.btn1300.Location = new System.Drawing.Point(3, 129);
            this.btn1300.Name = "btn1300";
            this.btn1300.RandevuAlindi = false;
            this.btn1300.Size = new System.Drawing.Size(67, 36);
            this.btn1300.TabIndex = 63;
            // 
            // btn1315
            // 
            this.btn1315.BtnText = "13:15";
            this.btn1315.Location = new System.Drawing.Point(76, 129);
            this.btn1315.Name = "btn1315";
            this.btn1315.RandevuAlindi = false;
            this.btn1315.Size = new System.Drawing.Size(67, 36);
            this.btn1315.TabIndex = 64;
            // 
            // btn1330
            // 
            this.btn1330.BtnText = "13:30";
            this.btn1330.Location = new System.Drawing.Point(149, 129);
            this.btn1330.Name = "btn1330";
            this.btn1330.RandevuAlindi = false;
            this.btn1330.Size = new System.Drawing.Size(67, 36);
            this.btn1330.TabIndex = 65;
            // 
            // btn1345
            // 
            this.btn1345.BtnText = "13:45";
            this.btn1345.Location = new System.Drawing.Point(222, 129);
            this.btn1345.Name = "btn1345";
            this.btn1345.RandevuAlindi = false;
            this.btn1345.Size = new System.Drawing.Size(67, 36);
            this.btn1345.TabIndex = 66;
            // 
            // btn1400
            // 
            this.btn1400.BtnText = "14:00";
            this.btn1400.Location = new System.Drawing.Point(3, 171);
            this.btn1400.Name = "btn1400";
            this.btn1400.RandevuAlindi = false;
            this.btn1400.Size = new System.Drawing.Size(67, 36);
            this.btn1400.TabIndex = 71;
            // 
            // btn1415
            // 
            this.btn1415.BtnText = "14:15";
            this.btn1415.Location = new System.Drawing.Point(76, 171);
            this.btn1415.Name = "btn1415";
            this.btn1415.RandevuAlindi = false;
            this.btn1415.Size = new System.Drawing.Size(67, 36);
            this.btn1415.TabIndex = 72;
            // 
            // btn1430
            // 
            this.btn1430.BtnText = "14:30";
            this.btn1430.Location = new System.Drawing.Point(149, 171);
            this.btn1430.Name = "btn1430";
            this.btn1430.RandevuAlindi = false;
            this.btn1430.Size = new System.Drawing.Size(67, 36);
            this.btn1430.TabIndex = 73;
            // 
            // btn1445
            // 
            this.btn1445.BtnText = "14:45";
            this.btn1445.Location = new System.Drawing.Point(222, 171);
            this.btn1445.Name = "btn1445";
            this.btn1445.RandevuAlindi = false;
            this.btn1445.Size = new System.Drawing.Size(67, 36);
            this.btn1445.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Randevu Saatleri:";
            // 
            // gbHasta
            // 
            this.gbHasta.Controls.Add(this.label3);
            this.gbHasta.Controls.Add(this.lstHasta);
            this.gbHasta.Controls.Add(this.txtHastaArama);
            this.gbHasta.Location = new System.Drawing.Point(12, 16);
            this.gbHasta.Name = "gbHasta";
            this.gbHasta.Size = new System.Drawing.Size(309, 293);
            this.gbHasta.TabIndex = 51;
            this.gbHasta.TabStop = false;
            this.gbHasta.Text = "Hasta Seçim İşlemleri";
            // 
            // servisDrtabPage
            // 
            this.servisDrtabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.servisDrtabPage.Controls.Add(this.listViewDr);
            this.servisDrtabPage.Controls.Add(this.listBoxDr);
            this.servisDrtabPage.Controls.Add(this.label6);
            this.servisDrtabPage.Controls.Add(this.cmbBoxSrvs);
            this.servisDrtabPage.Controls.Add(this.label2);
            this.servisDrtabPage.Location = new System.Drawing.Point(4, 22);
            this.servisDrtabPage.Name = "servisDrtabPage";
            this.servisDrtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.servisDrtabPage.Size = new System.Drawing.Size(903, 454);
            this.servisDrtabPage.TabIndex = 1;
            this.servisDrtabPage.Text = "Servisteki Randevular";
            // 
            // listViewDr
            // 
            this.listViewDr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rndTarih,
            this.saat,
            this.hastaAdi,
            this.hastaSoyad,
            this.cinsiyet,
            this.dogumtarihi});
            this.listViewDr.FullRowSelect = true;
            this.listViewDr.GridLines = true;
            this.listViewDr.Location = new System.Drawing.Point(338, 37);
            this.listViewDr.Name = "listViewDr";
            this.listViewDr.Size = new System.Drawing.Size(557, 435);
            this.listViewDr.TabIndex = 9;
            this.listViewDr.UseCompatibleStateImageBehavior = false;
            this.listViewDr.View = System.Windows.Forms.View.Details;
            // 
            // rndTarih
            // 
            this.rndTarih.Text = "Randevu Tarih";
            this.rndTarih.Width = 118;
            // 
            // saat
            // 
            this.saat.Text = "Randevu Saati";
            this.saat.Width = 126;
            // 
            // hastaAdi
            // 
            this.hastaAdi.Text = "Hasta Adi";
            this.hastaAdi.Width = 91;
            // 
            // hastaSoyad
            // 
            this.hastaSoyad.Text = "Hasta Soyadı";
            this.hastaSoyad.Width = 93;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Text = "Cinsiyet";
            this.cinsiyet.Width = 66;
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.Text = "Doğum Tarihi";
            this.dogumtarihi.Width = 90;
            // 
            // listBoxDr
            // 
            this.listBoxDr.FormattingEnabled = true;
            this.listBoxDr.Location = new System.Drawing.Point(11, 90);
            this.listBoxDr.Name = "listBoxDr";
            this.listBoxDr.Size = new System.Drawing.Size(310, 381);
            this.listBoxDr.TabIndex = 7;
            this.listBoxDr.SelectedIndexChanged += new System.EventHandler(this.listBoxDr_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doktor Seçiniz:";
            // 
            // cmbBoxSrvs
            // 
            this.cmbBoxSrvs.FormattingEnabled = true;
            this.cmbBoxSrvs.Location = new System.Drawing.Point(90, 37);
            this.cmbBoxSrvs.Name = "cmbBoxSrvs";
            this.cmbBoxSrvs.Size = new System.Drawing.Size(231, 21);
            this.cmbBoxSrvs.TabIndex = 5;
            this.cmbBoxSrvs.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSrvs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Servis Seçiniz:";
            // 
            // HastaRandevutabPage
            // 
            this.HastaRandevutabPage.Controls.Add(this.lblHastaKim);
            this.HastaRandevutabPage.Controls.Add(this.listViewHastaRandevulari);
            this.HastaRandevutabPage.Controls.Add(this.groupBox1);
            this.HastaRandevutabPage.Location = new System.Drawing.Point(4, 22);
            this.HastaRandevutabPage.Name = "HastaRandevutabPage";
            this.HastaRandevutabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HastaRandevutabPage.Size = new System.Drawing.Size(903, 454);
            this.HastaRandevutabPage.TabIndex = 2;
            this.HastaRandevutabPage.Text = "Hastanın Randevuları";
            this.HastaRandevutabPage.UseVisualStyleBackColor = true;
            // 
            // lblHastaKim
            // 
            this.lblHastaKim.AutoSize = true;
            this.lblHastaKim.Location = new System.Drawing.Point(335, 6);
            this.lblHastaKim.Name = "lblHastaKim";
            this.lblHastaKim.Size = new System.Drawing.Size(35, 13);
            this.lblHastaKim.TabIndex = 54;
            this.lblHastaKim.Text = "label8";
            // 
            // listViewHastaRandevulari
            // 
            this.listViewHastaRandevulari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.servis,
            this.dr});
            this.listViewHastaRandevulari.FullRowSelect = true;
            this.listViewHastaRandevulari.GridLines = true;
            this.listViewHastaRandevulari.Location = new System.Drawing.Point(338, 22);
            this.listViewHastaRandevulari.Name = "listViewHastaRandevulari";
            this.listViewHastaRandevulari.Size = new System.Drawing.Size(557, 444);
            this.listViewHastaRandevulari.TabIndex = 53;
            this.listViewHastaRandevulari.UseCompatibleStateImageBehavior = false;
            this.listViewHastaRandevulari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Randevu Tarih";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Randevu Saati";
            this.columnHeader2.Width = 97;
            // 
            // servis
            // 
            this.servis.Text = "Servis Bilgisi";
            this.servis.Width = 132;
            // 
            // dr
            // 
            this.dr.Text = "Doktor Bilgisi";
            this.dr.Width = 192;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBoxHastaTabPage);
            this.groupBox1.Controls.Add(this.txtTcAramaTabPage);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 466);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Seçim İşlemleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "HastaTC NO:";
            // 
            // listBoxHastaTabPage
            // 
            this.listBoxHastaTabPage.FormattingEnabled = true;
            this.listBoxHastaTabPage.Location = new System.Drawing.Point(8, 55);
            this.listBoxHastaTabPage.Name = "listBoxHastaTabPage";
            this.listBoxHastaTabPage.Size = new System.Drawing.Size(292, 394);
            this.listBoxHastaTabPage.TabIndex = 0;
            this.listBoxHastaTabPage.SelectedIndexChanged += new System.EventHandler(this.listBoxHasta_SelectedIndexChanged);
            // 
            // txtTcAramaTabPage
            // 
            this.txtTcAramaTabPage.Location = new System.Drawing.Point(81, 20);
            this.txtTcAramaTabPage.Name = "txtTcAramaTabPage";
            this.txtTcAramaTabPage.Size = new System.Drawing.Size(218, 20);
            this.txtTcAramaTabPage.TabIndex = 6;
            this.txtTcAramaTabPage.TextChanged += new System.EventHandler(this.txtTcAramaTabPage_TextChanged);
            // 
            // menuStripRandevu
            // 
            this.menuStripRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStripRandevu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaIslemleriToolStripMenuItem});
            this.menuStripRandevu.Location = new System.Drawing.Point(0, 0);
            this.menuStripRandevu.Name = "menuStripRandevu";
            this.menuStripRandevu.Size = new System.Drawing.Size(911, 24);
            this.menuStripRandevu.TabIndex = 52;
            this.menuStripRandevu.Text = "menuStrip1";
            // 
            // dosyaIslemleriToolStripMenuItem
            // 
            this.dosyaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandevularToolStripMenuItem});
            this.dosyaIslemleriToolStripMenuItem.Name = "dosyaIslemleriToolStripMenuItem";
            this.dosyaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dosyaIslemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // RandevularToolStripMenuItem
            // 
            this.RandevularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disariAktarRndToolStripMenuItem,
            this.iceriAktarRndToolStripMenuItem});
            this.RandevularToolStripMenuItem.Name = "RandevularToolStripMenuItem";
            this.RandevularToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.RandevularToolStripMenuItem.Text = "Randevular";
            // 
            // disariAktarRndToolStripMenuItem
            // 
            this.disariAktarRndToolStripMenuItem.Name = "disariAktarRndToolStripMenuItem";
            this.disariAktarRndToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.disariAktarRndToolStripMenuItem.Text = "Dışarı Aktar";
            this.disariAktarRndToolStripMenuItem.Click += new System.EventHandler(this.disariAktarDrToolStripMenuItem_Click);
            // 
            // iceriAktarRndToolStripMenuItem
            // 
            this.iceriAktarRndToolStripMenuItem.Name = "iceriAktarRndToolStripMenuItem";
            this.iceriAktarRndToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.iceriAktarRndToolStripMenuItem.Text = "İçeri Aktar";
            this.iceriAktarRndToolStripMenuItem.Click += new System.EventHandler(this.iceriAktarDrToolStripMenuItem_Click);
            // 
            // acDosya
            // 
            this.acDosya.FileName = "openFileDialog1";
            // 
            // FrmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 504);
            this.Controls.Add(this.RandevutabControl);
            this.Controls.Add(this.menuStripRandevu);
            this.MainMenuStrip = this.menuStripRandevu;
            this.Name = "FrmRandevu";
            this.Text = "RANDEVU İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmRandevu_Load);
            this.RandevutabControl.ResumeLayout(false);
            this.RandevuAlTabPage.ResumeLayout(false);
            this.gbRndIslemleri.ResumeLayout(false);
            this.gbRndIslemleri.PerformLayout();
            this.flowLayoutPanelSaatler.ResumeLayout(false);
            this.gbHasta.ResumeLayout(false);
            this.gbHasta.PerformLayout();
            this.servisDrtabPage.ResumeLayout(false);
            this.servisDrtabPage.PerformLayout();
            this.HastaRandevutabPage.ResumeLayout(false);
            this.HastaRandevutabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripRandevu.ResumeLayout(false);
            this.menuStripRandevu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ListBox lstHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ListBox lstDoktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHastaArama;
        private System.Windows.Forms.TabControl RandevutabControl;
        private System.Windows.Forms.TabPage RandevuAlTabPage;
        private System.Windows.Forms.GroupBox gbRndIslemleri;
        private System.Windows.Forms.GroupBox gbHasta;
        private RandevuSaatleriBtn btn0945;
        private RandevuSaatleriBtn btn0930;
        private RandevuSaatleriBtn btn0915;
        private RandevuSaatleriBtn btn0900;
        private RandevuSaatleriBtn btn1400;
        private RandevuSaatleriBtn btn1445;
        private RandevuSaatleriBtn btn1430;
        private RandevuSaatleriBtn btn1415;
        private RandevuSaatleriBtn btn1300;
        private RandevuSaatleriBtn btn1345;
        private RandevuSaatleriBtn btn1330;
        private RandevuSaatleriBtn btn1315;
        private RandevuSaatleriBtn btn1100;
        private RandevuSaatleriBtn btn1145;
        private RandevuSaatleriBtn btn1130;
        private RandevuSaatleriBtn btn1115;
        private RandevuSaatleriBtn btn1000;
        private RandevuSaatleriBtn btn1045;
        private RandevuSaatleriBtn btn1030;
        private RandevuSaatleriBtn btn1015;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSaatler;
        private System.Windows.Forms.ListView lstViewHastaRandevuları;
        private System.Windows.Forms.Button btnRandevuSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader tckimlik;
        private System.Windows.Forms.ColumnHeader hastAdi;
        private System.Windows.Forms.ColumnHeader hastaSoyadi;
        private System.Windows.Forms.ColumnHeader cinsiyeti;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader bolum;
        private System.Windows.Forms.ColumnHeader randevuTrh;
        private System.Windows.Forms.ColumnHeader randevuSaat;
        private System.Windows.Forms.ColumnHeader doktor;
        private System.Windows.Forms.TabPage servisDrtabPage;
        private System.Windows.Forms.ListView listViewDr;
        private System.Windows.Forms.ColumnHeader rndTarih;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.ColumnHeader hastaAdi;
        private System.Windows.Forms.ColumnHeader hastaSoyad;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ColumnHeader dogumtarihi;
        private System.Windows.Forms.ListBox listBoxDr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxSrvs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage HastaRandevutabPage;
        private System.Windows.Forms.Label lblHastaKim;
        private System.Windows.Forms.ListView listViewHastaRandevulari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxHastaTabPage;
        private System.Windows.Forms.TextBox txtTcAramaTabPage;
        private System.Windows.Forms.ColumnHeader servis;
        private System.Windows.Forms.ColumnHeader dr;
        private System.Windows.Forms.MenuStrip menuStripRandevu;
        private System.Windows.Forms.ToolStripMenuItem dosyaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disariAktarRndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iceriAktarRndToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog kaydetDosya;
        private System.Windows.Forms.OpenFileDialog acDosya;
    }
}