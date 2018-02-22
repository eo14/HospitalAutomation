namespace HospitalAutomation
{
    partial class FrmHemsire
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
            this.HemsireTabControl = new System.Windows.Forms.TabControl();
            this.HemsireOzlukTab = new System.Windows.Forms.TabPage();
            this.HemsireBransTab = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstViewHemsire = new System.Windows.Forms.ListView();
            this.tcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drBilgi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHemsire = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HemsireMaasTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHemsireSecMaasTab = new System.Windows.Forms.ComboBox();
            this.btnMaasKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.listViewHemsireMaasTab = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bransi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgmtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frmHemsireMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CiktiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AktarimIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIceriiAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyayiAc = new System.Windows.Forms.OpenFileDialog();
            this.HemsirekisiselBilgilerUserCntrl = new HospitalAutomation.KisiselBilgiler();
            this.kisiselBilgiler1 = new HospitalAutomation.KisiselBilgiler();
            this.HemsireTabControl.SuspendLayout();
            this.HemsireOzlukTab.SuspendLayout();
            this.HemsireBransTab.SuspendLayout();
            this.HemsireMaasTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.frmHemsireMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HemsireTabControl
            // 
            this.HemsireTabControl.Controls.Add(this.HemsireOzlukTab);
            this.HemsireTabControl.Controls.Add(this.HemsireBransTab);
            this.HemsireTabControl.Controls.Add(this.HemsireMaasTab);
            this.HemsireTabControl.Location = new System.Drawing.Point(0, 27);
            this.HemsireTabControl.Name = "HemsireTabControl";
            this.HemsireTabControl.SelectedIndex = 0;
            this.HemsireTabControl.Size = new System.Drawing.Size(557, 377);
            this.HemsireTabControl.TabIndex = 0;
            this.HemsireTabControl.SelectedIndexChanged += new System.EventHandler(this.HemsireTabControl_SelectedIndexChanged);
            // 
            // HemsireOzlukTab
            // 
            this.HemsireOzlukTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HemsireOzlukTab.Controls.Add(this.HemsirekisiselBilgilerUserCntrl);
            this.HemsireOzlukTab.Location = new System.Drawing.Point(4, 22);
            this.HemsireOzlukTab.Name = "HemsireOzlukTab";
            this.HemsireOzlukTab.Size = new System.Drawing.Size(549, 351);
            this.HemsireOzlukTab.TabIndex = 0;
            this.HemsireOzlukTab.Text = "Özlük İşlemleri";
            // 
            // HemsireBransTab
            // 
            this.HemsireBransTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HemsireBransTab.Controls.Add(this.btnKaydet);
            this.HemsireBransTab.Controls.Add(this.lstViewHemsire);
            this.HemsireBransTab.Controls.Add(this.cmbBrans);
            this.HemsireBransTab.Controls.Add(this.label2);
            this.HemsireBransTab.Controls.Add(this.cmbHemsire);
            this.HemsireBransTab.Controls.Add(this.label1);
            this.HemsireBransTab.Location = new System.Drawing.Point(4, 22);
            this.HemsireBransTab.Name = "HemsireBransTab";
            this.HemsireBransTab.Padding = new System.Windows.Forms.Padding(3);
            this.HemsireBransTab.Size = new System.Drawing.Size(549, 351);
            this.HemsireBransTab.TabIndex = 1;
            this.HemsireBransTab.Text = "Branş İşlemleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(11, 240);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(489, 25);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstViewHemsire
            // 
            this.lstViewHemsire.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tcNo,
            this.ad,
            this.soyad,
            this.brans,
            this.cinsiyet,
            this.drBilgi});
            this.lstViewHemsire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewHemsire.FullRowSelect = true;
            this.lstViewHemsire.GridLines = true;
            this.lstViewHemsire.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewHemsire.Location = new System.Drawing.Point(8, 82);
            this.lstViewHemsire.Name = "lstViewHemsire";
            this.lstViewHemsire.Size = new System.Drawing.Size(492, 152);
            this.lstViewHemsire.TabIndex = 4;
            this.lstViewHemsire.UseCompatibleStateImageBehavior = false;
            this.lstViewHemsire.View = System.Windows.Forms.View.Details;
            // 
            // tcNo
            // 
            this.tcNo.Text = "Tc Numarası";
            this.tcNo.Width = 88;
            // 
            // ad
            // 
            this.ad.Text = "Adı";
            // 
            // soyad
            // 
            this.soyad.Text = "Soyadı";
            // 
            // brans
            // 
            this.brans.Text = "Branş";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Text = "Cinsiyet";
            this.cinsiyet.Width = 57;
            // 
            // drBilgi
            // 
            this.drBilgi.Text = "Çalıştığı Doktor";
            this.drBilgi.Width = 99;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(99, 45);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(336, 21);
            this.cmbBrans.TabIndex = 3;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branş Seçiniz:";
            // 
            // cmbHemsire
            // 
            this.cmbHemsire.FormattingEnabled = true;
            this.cmbHemsire.Location = new System.Drawing.Point(99, 15);
            this.cmbHemsire.Name = "cmbHemsire";
            this.cmbHemsire.Size = new System.Drawing.Size(336, 21);
            this.cmbHemsire.TabIndex = 1;
            this.cmbHemsire.SelectedIndexChanged += new System.EventHandler(this.cmbHemsire_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hemşire Seçiniz:";
            // 
            // HemsireMaasTab
            // 
            this.HemsireMaasTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HemsireMaasTab.Controls.Add(this.groupBox1);
            this.HemsireMaasTab.Controls.Add(this.listViewHemsireMaasTab);
            this.HemsireMaasTab.Location = new System.Drawing.Point(4, 22);
            this.HemsireMaasTab.Name = "HemsireMaasTab";
            this.HemsireMaasTab.Size = new System.Drawing.Size(549, 351);
            this.HemsireMaasTab.TabIndex = 3;
            this.HemsireMaasTab.Text = "Maaş İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbHemsireSecMaasTab);
            this.groupBox1.Controls.Add(this.btnMaasKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudMaas);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hemsire Seçiniz:";
            // 
            // cmbHemsireSecMaasTab
            // 
            this.cmbHemsireSecMaasTab.FormattingEnabled = true;
            this.cmbHemsireSecMaasTab.Location = new System.Drawing.Point(91, 13);
            this.cmbHemsireSecMaasTab.Name = "cmbHemsireSecMaasTab";
            this.cmbHemsireSecMaasTab.Size = new System.Drawing.Size(442, 21);
            this.cmbHemsireSecMaasTab.TabIndex = 3;
            this.cmbHemsireSecMaasTab.SelectedIndexChanged += new System.EventHandler(this.cmbHemsireSecMaasTab_SelectedIndexChanged);
            // 
            // btnMaasKaydet
            // 
            this.btnMaasKaydet.Location = new System.Drawing.Point(5, 82);
            this.btnMaasKaydet.Name = "btnMaasKaydet";
            this.btnMaasKaydet.Size = new System.Drawing.Size(528, 24);
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
            // 
            // listViewHemsireMaasTab
            // 
            this.listViewHemsireMaasTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.adi,
            this.soyadi,
            this.bransi,
            this.maas,
            this.cinsiyeti,
            this.dgmtarihi,
            this.telefon});
            this.listViewHemsireMaasTab.FullRowSelect = true;
            this.listViewHemsireMaasTab.GridLines = true;
            this.listViewHemsireMaasTab.Location = new System.Drawing.Point(6, 142);
            this.listViewHemsireMaasTab.Name = "listViewHemsireMaasTab";
            this.listViewHemsireMaasTab.Size = new System.Drawing.Size(535, 183);
            this.listViewHemsireMaasTab.TabIndex = 9;
            this.listViewHemsireMaasTab.UseCompatibleStateImageBehavior = false;
            this.listViewHemsireMaasTab.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC No";
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
            this.dgmtarihi.Width = 93;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            // 
            // maas
            // 
            this.maas.Text = "Maaş";
            // 
            // frmHemsireMenuStrip
            // 
            this.frmHemsireMenuStrip.BackColor = System.Drawing.Color.LightBlue;
            this.frmHemsireMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmHemsireMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CiktiToolStripMenuItem});
            this.frmHemsireMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmHemsireMenuStrip.Name = "frmHemsireMenuStrip";
            this.frmHemsireMenuStrip.Size = new System.Drawing.Size(557, 24);
            this.frmHemsireMenuStrip.TabIndex = 2;
            this.frmHemsireMenuStrip.Text = "frmDoktormenuStrip";
            // 
            // CiktiToolStripMenuItem
            // 
            this.CiktiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AktarimIslemleriToolStripMenuItem});
            this.CiktiToolStripMenuItem.Name = "CiktiToolStripMenuItem";
            this.CiktiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.CiktiToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // AktarimIslemleriToolStripMenuItem
            // 
            this.AktarimIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.XMLIceriiAktarToolStripMenuItem});
            this.AktarimIslemleriToolStripMenuItem.Name = "AktarimIslemleriToolStripMenuItem";
            this.AktarimIslemleriToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.AktarimIslemleriToolStripMenuItem.Text = "İşlemler";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem.Text = "Dışarı Aktar";
            this.toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // XMLIceriiAktarToolStripMenuItem
            // 
            this.XMLIceriiAktarToolStripMenuItem.Name = "XMLIceriiAktarToolStripMenuItem";
            this.XMLIceriiAktarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.XMLIceriiAktarToolStripMenuItem.Text = "İçeri Aktar";
            this.XMLIceriiAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLIceriiAktarToolStripMenuItem_Click_1);
            // 
            // dosyayiAc
            // 
            this.dosyayiAc.FileName = "openFileDialog1";
            // 
            // HemsirekisiselBilgilerUserCntrl
            // 
            this.HemsirekisiselBilgilerUserCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HemsirekisiselBilgilerUserCntrl.Location = new System.Drawing.Point(8, 8);
            this.HemsirekisiselBilgilerUserCntrl.Name = "HemsirekisiselBilgilerUserCntrl";
            this.HemsirekisiselBilgilerUserCntrl.Size = new System.Drawing.Size(521, 326);
            this.HemsirekisiselBilgilerUserCntrl.TabIndex = 0;
            // 
            // kisiselBilgiler1
            // 
            this.kisiselBilgiler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kisiselBilgiler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kisiselBilgiler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kisiselBilgiler1.Location = new System.Drawing.Point(3, 3);
            this.kisiselBilgiler1.Name = "kisiselBilgiler1";
            this.kisiselBilgiler1.Size = new System.Drawing.Size(543, 325);
            this.kisiselBilgiler1.TabIndex = 0;
            // 
            // FrmHemsire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(557, 404);
            this.Controls.Add(this.frmHemsireMenuStrip);
            this.Controls.Add(this.HemsireTabControl);
            this.Name = "FrmHemsire";
            this.Text = "HEMŞİRE İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmHemsire_Load);
            this.HemsireTabControl.ResumeLayout(false);
            this.HemsireOzlukTab.ResumeLayout(false);
            this.HemsireBransTab.ResumeLayout(false);
            this.HemsireBransTab.PerformLayout();
            this.HemsireMaasTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.frmHemsireMenuStrip.ResumeLayout(false);
            this.frmHemsireMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl HemsireTabControl;
        private System.Windows.Forms.TabPage HemsireOzlukTab;
        private KisiselBilgiler kisiselBilgiler1;
        private System.Windows.Forms.TabPage HemsireBransTab;
        private System.Windows.Forms.ListView lstViewHemsire;
        private System.Windows.Forms.ColumnHeader tcNo;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader brans;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHemsire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MenuStrip frmHemsireMenuStrip;
        private System.Windows.Forms.TabPage HemsireMaasTab;
        private KisiselBilgiler HemsirekisiselBilgilerUserCntrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHemsireSecMaasTab;
        private System.Windows.Forms.Button btnMaasKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.ListView listViewHemsireMaasTab;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader adi;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader bransi;
        private System.Windows.Forms.ColumnHeader cinsiyeti;
        private System.Windows.Forms.ColumnHeader dgmtarihi;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader maas;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ToolStripMenuItem CiktiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AktarimIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIceriiAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyayiAc;
        private System.Windows.Forms.ColumnHeader drBilgi;
    }
}