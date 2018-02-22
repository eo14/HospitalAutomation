namespace HospitalAutomation
{
    partial class FrmDoktor
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
            this.components = new System.ComponentModel.Container();
            this.tabControlDoktor = new System.Windows.Forms.TabControl();
            this.drOzlukTab = new System.Windows.Forms.TabPage();
            this.DrkisiselBilgilerUserControl = new HospitalAutomation.KisiselBilgiler();
            this.drBransTab = new System.Windows.Forms.TabPage();
            this.listViewDrBransTab = new System.Windows.Forms.ListView();
            this.tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogumTrh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDrBranslar = new System.Windows.Forms.Panel();
            this.btnBransKaydet = new System.Windows.Forms.Button();
            this.lstDrBranslar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDrSecBransTab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drMaasTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDrSecMaasTab = new System.Windows.Forms.ComboBox();
            this.btnMaasKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.listViewDrMaasTab = new System.Windows.Forms.ListView();
            this.tcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bransi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgmtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maili = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drHemsireTab = new System.Windows.Forms.TabPage();
            this.labeldrHemsireleri = new System.Windows.Forms.Label();
            this.listViewDrHemsireleri = new System.Windows.Forms.ListView();
            this.hemsireBrans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HemsireTc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hemsireAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hemsireSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hemsireCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calistigiDr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripHemsireyiSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbServisSecHemsireTab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHemsireSec = new System.Windows.Forms.Button();
            this.lstHemsireler = new System.Windows.Forms.ListBox();
            this.cmbDoktorSecHemsireTab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hemsireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDoktormenuStrip = new System.Windows.Forms.MenuStrip();
            this.CiktiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AktarmaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLdisariAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIceriiAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.tabControlDoktor.SuspendLayout();
            this.drOzlukTab.SuspendLayout();
            this.drBransTab.SuspendLayout();
            this.pnlDrBranslar.SuspendLayout();
            this.drMaasTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.drHemsireTab.SuspendLayout();
            this.contextMenuStripHemsireyiSil.SuspendLayout();
            this.frmDoktormenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDoktor
            // 
            this.tabControlDoktor.Controls.Add(this.drOzlukTab);
            this.tabControlDoktor.Controls.Add(this.drBransTab);
            this.tabControlDoktor.Controls.Add(this.drMaasTab);
            this.tabControlDoktor.Controls.Add(this.drHemsireTab);
            this.tabControlDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDoktor.Location = new System.Drawing.Point(0, 24);
            this.tabControlDoktor.Name = "tabControlDoktor";
            this.tabControlDoktor.SelectedIndex = 0;
            this.tabControlDoktor.Size = new System.Drawing.Size(664, 358);
            this.tabControlDoktor.TabIndex = 0;
            this.tabControlDoktor.SelectedIndexChanged += new System.EventHandler(this.tabControlDoktor_SelectedIndexChanged);
            // 
            // drOzlukTab
            // 
            this.drOzlukTab.Controls.Add(this.DrkisiselBilgilerUserControl);
            this.drOzlukTab.Location = new System.Drawing.Point(4, 22);
            this.drOzlukTab.Name = "drOzlukTab";
            this.drOzlukTab.Padding = new System.Windows.Forms.Padding(3);
            this.drOzlukTab.Size = new System.Drawing.Size(656, 332);
            this.drOzlukTab.TabIndex = 0;
            this.drOzlukTab.Text = "Özlük İşlemleri";
            this.drOzlukTab.UseVisualStyleBackColor = true;
            // 
            // DrkisiselBilgilerUserControl
            // 
            this.DrkisiselBilgilerUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DrkisiselBilgilerUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrkisiselBilgilerUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrkisiselBilgilerUserControl.Location = new System.Drawing.Point(3, 3);
            this.DrkisiselBilgilerUserControl.Name = "DrkisiselBilgilerUserControl";
            this.DrkisiselBilgilerUserControl.Size = new System.Drawing.Size(650, 326);
            this.DrkisiselBilgilerUserControl.TabIndex = 0;
            // 
            // drBransTab
            // 
            this.drBransTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.drBransTab.Controls.Add(this.listViewDrBransTab);
            this.drBransTab.Controls.Add(this.pnlDrBranslar);
            this.drBransTab.Controls.Add(this.cmbDrSecBransTab);
            this.drBransTab.Controls.Add(this.label3);
            this.drBransTab.Location = new System.Drawing.Point(4, 22);
            this.drBransTab.Name = "drBransTab";
            this.drBransTab.Size = new System.Drawing.Size(656, 332);
            this.drBransTab.TabIndex = 2;
            this.drBransTab.Text = "Branş İşlemleri";
            // 
            // listViewDrBransTab
            // 
            this.listViewDrBransTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tc,
            this.ad,
            this.soyad,
            this.brans,
            this.cinsiyet,
            this.dogumTrh,
            this.tel,
            this.mail,
            this.maasi});
            this.listViewDrBransTab.FullRowSelect = true;
            this.listViewDrBransTab.GridLines = true;
            this.listViewDrBransTab.Location = new System.Drawing.Point(10, 196);
            this.listViewDrBransTab.Name = "listViewDrBransTab";
            this.listViewDrBransTab.Size = new System.Drawing.Size(481, 126);
            this.listViewDrBransTab.TabIndex = 5;
            this.listViewDrBransTab.UseCompatibleStateImageBehavior = false;
            this.listViewDrBransTab.View = System.Windows.Forms.View.Details;
            // 
            // tc
            // 
            this.tc.Text = "TC No";
            // 
            // ad
            // 
            this.ad.Text = "Ad";
            // 
            // soyad
            // 
            this.soyad.Text = "Soyad";
            // 
            // brans
            // 
            this.brans.Text = "Branş";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Text = "Cinsiyet";
            // 
            // dogumTrh
            // 
            this.dogumTrh.Text = "Doğum Tarihi";
            this.dogumTrh.Width = 70;
            // 
            // tel
            // 
            this.tel.Text = "Telefon";
            // 
            // mail
            // 
            this.mail.Text = "Email";
            // 
            // maasi
            // 
            this.maasi.Text = "Maaş";
            // 
            // pnlDrBranslar
            // 
            this.pnlDrBranslar.Controls.Add(this.btnBransKaydet);
            this.pnlDrBranslar.Controls.Add(this.lstDrBranslar);
            this.pnlDrBranslar.Controls.Add(this.label4);
            this.pnlDrBranslar.Location = new System.Drawing.Point(10, 42);
            this.pnlDrBranslar.Name = "pnlDrBranslar";
            this.pnlDrBranslar.Size = new System.Drawing.Size(481, 148);
            this.pnlDrBranslar.TabIndex = 5;
            // 
            // btnBransKaydet
            // 
            this.btnBransKaydet.Location = new System.Drawing.Point(13, 117);
            this.btnBransKaydet.Name = "btnBransKaydet";
            this.btnBransKaydet.Size = new System.Drawing.Size(463, 23);
            this.btnBransKaydet.TabIndex = 4;
            this.btnBransKaydet.Text = "Kaydet";
            this.btnBransKaydet.UseVisualStyleBackColor = true;
            this.btnBransKaydet.Click += new System.EventHandler(this.btnBransKaydet_Click);
            // 
            // lstDrBranslar
            // 
            this.lstDrBranslar.FormattingEnabled = true;
            this.lstDrBranslar.Location = new System.Drawing.Point(10, 16);
            this.lstDrBranslar.Name = "lstDrBranslar";
            this.lstDrBranslar.Size = new System.Drawing.Size(466, 95);
            this.lstDrBranslar.TabIndex = 3;
            this.lstDrBranslar.SelectedIndexChanged += new System.EventHandler(this.lstDrBranslar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branş Seçiniz:";
            // 
            // cmbDrSecBransTab
            // 
            this.cmbDrSecBransTab.FormattingEnabled = true;
            this.cmbDrSecBransTab.Location = new System.Drawing.Point(105, 16);
            this.cmbDrSecBransTab.Name = "cmbDrSecBransTab";
            this.cmbDrSecBransTab.Size = new System.Drawing.Size(381, 21);
            this.cmbDrSecBransTab.TabIndex = 1;
            this.cmbDrSecBransTab.SelectedIndexChanged += new System.EventHandler(this.cmbDrSecBrans_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doktor Seçiniz:";
            // 
            // drMaasTab
            // 
            this.drMaasTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.drMaasTab.Controls.Add(this.groupBox1);
            this.drMaasTab.Controls.Add(this.listViewDrMaasTab);
            this.drMaasTab.Location = new System.Drawing.Point(4, 22);
            this.drMaasTab.Name = "drMaasTab";
            this.drMaasTab.Size = new System.Drawing.Size(656, 332);
            this.drMaasTab.TabIndex = 3;
            this.drMaasTab.Text = "Maaş İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDrSecMaasTab);
            this.groupBox1.Controls.Add(this.btnMaasKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudMaas);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doktor Seçiniz:";
            // 
            // cmbDrSecMaasTab
            // 
            this.cmbDrSecMaasTab.FormattingEnabled = true;
            this.cmbDrSecMaasTab.Location = new System.Drawing.Point(91, 13);
            this.cmbDrSecMaasTab.Name = "cmbDrSecMaasTab";
            this.cmbDrSecMaasTab.Size = new System.Drawing.Size(388, 21);
            this.cmbDrSecMaasTab.TabIndex = 3;
            this.cmbDrSecMaasTab.SelectedIndexChanged += new System.EventHandler(this.cmbDrSecMaasTab_SelectedIndexChanged);
            // 
            // btnMaasKaydet
            // 
            this.btnMaasKaydet.Location = new System.Drawing.Point(5, 82);
            this.btnMaasKaydet.Name = "btnMaasKaydet";
            this.btnMaasKaydet.Size = new System.Drawing.Size(474, 24);
            this.btnMaasKaydet.TabIndex = 6;
            this.btnMaasKaydet.Text = "Kaydet";
            this.btnMaasKaydet.UseVisualStyleBackColor = true;
            this.btnMaasKaydet.Click += new System.EventHandler(this.btnMaasKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Maaş:";
            // 
            // nudMaas
            // 
            this.nudMaas.Location = new System.Drawing.Point(91, 45);
            this.nudMaas.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(137, 20);
            this.nudMaas.TabIndex = 5;
            this.nudMaas.ValueChanged += new System.EventHandler(this.nudMaas_ValueChanged);
            // 
            // listViewDrMaasTab
            // 
            this.listViewDrMaasTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tcNo,
            this.adi,
            this.soyadi,
            this.bransi,
            this.cinsiyeti,
            this.dgmtarihi,
            this.telefon,
            this.maili,
            this.maas});
            this.listViewDrMaasTab.FullRowSelect = true;
            this.listViewDrMaasTab.GridLines = true;
            this.listViewDrMaasTab.Location = new System.Drawing.Point(10, 139);
            this.listViewDrMaasTab.Name = "listViewDrMaasTab";
            this.listViewDrMaasTab.Size = new System.Drawing.Size(603, 183);
            this.listViewDrMaasTab.TabIndex = 7;
            this.listViewDrMaasTab.UseCompatibleStateImageBehavior = false;
            this.listViewDrMaasTab.View = System.Windows.Forms.View.Details;
            // 
            // tcNo
            // 
            this.tcNo.Text = "TC No";
            // 
            // adi
            // 
            this.adi.Text = "Ad";
            this.adi.Width = 56;
            // 
            // soyadi
            // 
            this.soyadi.Text = "Soyad";
            // 
            // bransi
            // 
            this.bransi.Text = "Branş";
            // 
            // cinsiyeti
            // 
            this.cinsiyeti.Text = "Cinsiyet";
            // 
            // dgmtarihi
            // 
            this.dgmtarihi.Text = "Doğum Tarihi";
            this.dgmtarihi.Width = 70;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            // 
            // maili
            // 
            this.maili.Text = "Email";
            // 
            // maas
            // 
            this.maas.Text = "Maaş";
            // 
            // drHemsireTab
            // 
            this.drHemsireTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.drHemsireTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drHemsireTab.Controls.Add(this.labeldrHemsireleri);
            this.drHemsireTab.Controls.Add(this.listViewDrHemsireleri);
            this.drHemsireTab.Controls.Add(this.cmbServisSecHemsireTab);
            this.drHemsireTab.Controls.Add(this.label2);
            this.drHemsireTab.Controls.Add(this.btnHemsireSec);
            this.drHemsireTab.Controls.Add(this.lstHemsireler);
            this.drHemsireTab.Controls.Add(this.cmbDoktorSecHemsireTab);
            this.drHemsireTab.Controls.Add(this.label1);
            this.drHemsireTab.Location = new System.Drawing.Point(4, 22);
            this.drHemsireTab.Name = "drHemsireTab";
            this.drHemsireTab.Padding = new System.Windows.Forms.Padding(3);
            this.drHemsireTab.Size = new System.Drawing.Size(656, 332);
            this.drHemsireTab.TabIndex = 1;
            this.drHemsireTab.Text = "Hemşire İşlemleri";
            // 
            // labeldrHemsireleri
            // 
            this.labeldrHemsireleri.AutoSize = true;
            this.labeldrHemsireleri.Location = new System.Drawing.Point(13, 208);
            this.labeldrHemsireleri.Name = "labeldrHemsireleri";
            this.labeldrHemsireleri.Size = new System.Drawing.Size(35, 13);
            this.labeldrHemsireleri.TabIndex = 7;
            this.labeldrHemsireleri.Text = "label7";
            // 
            // listViewDrHemsireleri
            // 
            this.listViewDrHemsireleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hemsireBrans,
            this.HemsireTc,
            this.hemsireAd,
            this.hemsireSoyad,
            this.hemsireCinsiyet,
            this.calistigiDr});
            this.listViewDrHemsireleri.ContextMenuStrip = this.contextMenuStripHemsireyiSil;
            this.listViewDrHemsireleri.FullRowSelect = true;
            this.listViewDrHemsireleri.GridLines = true;
            this.listViewDrHemsireleri.Location = new System.Drawing.Point(11, 227);
            this.listViewDrHemsireleri.Name = "listViewDrHemsireleri";
            this.listViewDrHemsireleri.Size = new System.Drawing.Size(572, 97);
            this.listViewDrHemsireleri.TabIndex = 6;
            this.listViewDrHemsireleri.UseCompatibleStateImageBehavior = false;
            this.listViewDrHemsireleri.View = System.Windows.Forms.View.Details;
            // 
            // hemsireBrans
            // 
            this.hemsireBrans.Text = "Branş";
            // 
            // HemsireTc
            // 
            this.HemsireTc.Text = "Hemşire Tc";
            this.HemsireTc.Width = 111;
            // 
            // hemsireAd
            // 
            this.hemsireAd.Text = "Hemşire Ad";
            this.hemsireAd.Width = 101;
            // 
            // hemsireSoyad
            // 
            this.hemsireSoyad.Text = "HemşireSoyad";
            this.hemsireSoyad.Width = 114;
            // 
            // hemsireCinsiyet
            // 
            this.hemsireCinsiyet.Text = "Cinsiyet";
            // 
            // calistigiDr
            // 
            this.calistigiDr.Text = "Çalıştığı Doktor";
            this.calistigiDr.Width = 106;
            // 
            // contextMenuStripHemsireyiSil
            // 
            this.contextMenuStripHemsireyiSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİlToolStripMenuItem});
            this.contextMenuStripHemsireyiSil.Name = "contextMenuStripHemsireyiSil";
            this.contextMenuStripHemsireyiSil.Size = new System.Drawing.Size(87, 26);
            // 
            // sİlToolStripMenuItem
            // 
            this.sİlToolStripMenuItem.Name = "sİlToolStripMenuItem";
            this.sİlToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.sİlToolStripMenuItem.Text = "Sİl";
            this.sİlToolStripMenuItem.Click += new System.EventHandler(this.sİlToolStripMenuItem_Click);
            // 
            // cmbServisSecHemsireTab
            // 
            this.cmbServisSecHemsireTab.FormattingEnabled = true;
            this.cmbServisSecHemsireTab.Location = new System.Drawing.Point(102, 25);
            this.cmbServisSecHemsireTab.Name = "cmbServisSecHemsireTab";
            this.cmbServisSecHemsireTab.Size = new System.Drawing.Size(481, 21);
            this.cmbServisSecHemsireTab.TabIndex = 5;
            this.cmbServisSecHemsireTab.SelectedIndexChanged += new System.EventHandler(this.cmbServisSecHemsireTab_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servis Seçiniz:";
            // 
            // btnHemsireSec
            // 
            this.btnHemsireSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHemsireSec.Location = new System.Drawing.Point(11, 177);
            this.btnHemsireSec.Name = "btnHemsireSec";
            this.btnHemsireSec.Size = new System.Drawing.Size(572, 28);
            this.btnHemsireSec.TabIndex = 3;
            this.btnHemsireSec.Text = "HEMŞİRE SEÇ";
            this.btnHemsireSec.UseVisualStyleBackColor = true;
            this.btnHemsireSec.Click += new System.EventHandler(this.btnHemsireSec_Click);
            // 
            // lstHemsireler
            // 
            this.lstHemsireler.FormattingEnabled = true;
            this.lstHemsireler.Location = new System.Drawing.Point(11, 89);
            this.lstHemsireler.Name = "lstHemsireler";
            this.lstHemsireler.Size = new System.Drawing.Size(572, 82);
            this.lstHemsireler.TabIndex = 2;
            this.lstHemsireler.SelectedIndexChanged += new System.EventHandler(this.lstHemsireler_SelectedIndexChanged);
            // 
            // cmbDoktorSecHemsireTab
            // 
            this.cmbDoktorSecHemsireTab.FormattingEnabled = true;
            this.cmbDoktorSecHemsireTab.Location = new System.Drawing.Point(102, 53);
            this.cmbDoktorSecHemsireTab.Name = "cmbDoktorSecHemsireTab";
            this.cmbDoktorSecHemsireTab.Size = new System.Drawing.Size(481, 21);
            this.cmbDoktorSecHemsireTab.TabIndex = 1;
            this.cmbDoktorSecHemsireTab.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorSecHemsireTab_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Seçiniz:";
            // 
            // hemsireToolStripMenuItem
            // 
            this.hemsireToolStripMenuItem.Name = "hemsireToolStripMenuItem";
            this.hemsireToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hemsireToolStripMenuItem.Text = "Hemsire";
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hemşireToolStripMenuItem.Text = "Hemsire";
            // 
            // frmDoktormenuStrip
            // 
            this.frmDoktormenuStrip.BackColor = System.Drawing.Color.LightBlue;
            this.frmDoktormenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmDoktormenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CiktiToolStripMenuItem});
            this.frmDoktormenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmDoktormenuStrip.Name = "frmDoktormenuStrip";
            this.frmDoktormenuStrip.Size = new System.Drawing.Size(664, 24);
            this.frmDoktormenuStrip.TabIndex = 1;
            this.frmDoktormenuStrip.Text = "frmDoktormenuStrip";
            // 
            // CiktiToolStripMenuItem
            // 
            this.CiktiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AktarmaIslemleriToolStripMenuItem});
            this.CiktiToolStripMenuItem.Name = "CiktiToolStripMenuItem";
            this.CiktiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.CiktiToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // AktarmaIslemleriToolStripMenuItem
            // 
            this.AktarmaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLdisariAktarToolStripMenuItem,
            this.XMLIceriiAktarToolStripMenuItem});
            this.AktarmaIslemleriToolStripMenuItem.Name = "AktarmaIslemleriToolStripMenuItem";
            this.AktarmaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.AktarmaIslemleriToolStripMenuItem.Text = "İşlemler";
            // 
            // XMLdisariAktarToolStripMenuItem
            // 
            this.XMLdisariAktarToolStripMenuItem.Name = "XMLdisariAktarToolStripMenuItem";
            this.XMLdisariAktarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.XMLdisariAktarToolStripMenuItem.Text = "Dışarı Aktar";
            this.XMLdisariAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLdisariAktarToolStripMenuItem_Click);
            // 
            // XMLIceriiAktarToolStripMenuItem
            // 
            this.XMLIceriiAktarToolStripMenuItem.Name = "XMLIceriiAktarToolStripMenuItem";
            this.XMLIceriiAktarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.XMLIceriiAktarToolStripMenuItem.Text = "İçeri Aktar";
            this.XMLIceriiAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLIceriiAktarToolStripMenuItem_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.tabControlDoktor);
            this.Controls.Add(this.frmDoktormenuStrip);
            this.MainMenuStrip = this.frmDoktormenuStrip;
            this.Name = "FrmDoktor";
            this.Text = "DOKTOR İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            this.tabControlDoktor.ResumeLayout(false);
            this.drOzlukTab.ResumeLayout(false);
            this.drBransTab.ResumeLayout(false);
            this.drBransTab.PerformLayout();
            this.pnlDrBranslar.ResumeLayout(false);
            this.pnlDrBranslar.PerformLayout();
            this.drMaasTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.drHemsireTab.ResumeLayout(false);
            this.drHemsireTab.PerformLayout();
            this.contextMenuStripHemsireyiSil.ResumeLayout(false);
            this.frmDoktormenuStrip.ResumeLayout(false);
            this.frmDoktormenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDoktor;
        private System.Windows.Forms.TabPage drOzlukTab;
        private System.Windows.Forms.TabPage drHemsireTab;
        private System.Windows.Forms.Button btnHemsireSec;
        private System.Windows.Forms.ListBox lstHemsireler;
        private System.Windows.Forms.ComboBox cmbDoktorSecHemsireTab;
        private System.Windows.Forms.Label label1;
        private KisiselBilgiler DrkisiselBilgilerUserControl;
        private System.Windows.Forms.ComboBox cmbServisSecHemsireTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemsireToolStripMenuItem;
        private System.Windows.Forms.MenuStrip frmDoktormenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CiktiToolStripMenuItem;
        private System.Windows.Forms.TabPage drBransTab;
        private System.Windows.Forms.TabPage drMaasTab;
        private System.Windows.Forms.Button btnBransKaydet;
        private System.Windows.Forms.ListBox lstDrBranslar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDrSecBransTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMaasKaydet;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDrBranslar;
        private System.Windows.Forms.ComboBox cmbDrSecMaasTab;
        private System.Windows.Forms.ListView listViewDrBransTab;
        private System.Windows.Forms.ColumnHeader tc;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader brans;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ColumnHeader dogumTrh;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewDrMaasTab;
        private System.Windows.Forms.ColumnHeader tcNo;
        private System.Windows.Forms.ColumnHeader adi;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader maas;
        private System.Windows.Forms.ColumnHeader bransi;
        private System.Windows.Forms.ColumnHeader cinsiyeti;
        private System.Windows.Forms.ColumnHeader dgmtarihi;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader maili;
        private System.Windows.Forms.ColumnHeader maasi;
        private System.Windows.Forms.ToolStripMenuItem AktarmaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLdisariAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIceriiAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.ListView listViewDrHemsireleri;
        private System.Windows.Forms.ColumnHeader hemsireBrans;
        private System.Windows.Forms.ColumnHeader HemsireTc;
        private System.Windows.Forms.ColumnHeader hemsireAd;
        private System.Windows.Forms.ColumnHeader hemsireSoyad;
        private System.Windows.Forms.ColumnHeader hemsireCinsiyet;
        private System.Windows.Forms.Label labeldrHemsireleri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHemsireyiSil;
        private System.Windows.Forms.ToolStripMenuItem sİlToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader calistigiDr;
    }
}