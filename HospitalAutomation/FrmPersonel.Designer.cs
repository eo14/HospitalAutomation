namespace HospitalAutomation
{
    partial class FrmPersonel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PersonelTabControl = new System.Windows.Forms.TabControl();
            this.PersonelOzlukTab = new System.Windows.Forms.TabPage();
            this.PersonelkisiselBilgilerUserCntrl = new HospitalAutomation.KisiselBilgiler();
            this.PersonelBransTab = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstViewPersonel = new System.Windows.Forms.ListView();
            this.tcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelMaasTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPersonelSecMaasTab = new System.Windows.Forms.ComboBox();
            this.btnMaasKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.listViewPersonelMaasTab = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bransi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgmtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maili = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosyayiAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.frmPersonelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CiktiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AktarimIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLDisariAktartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIceriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PersonelTabControl.SuspendLayout();
            this.PersonelOzlukTab.SuspendLayout();
            this.PersonelBransTab.SuspendLayout();
            this.PersonelMaasTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.frmPersonelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.PersonelTabControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel İşlemleri:";
            // 
            // PersonelTabControl
            // 
            this.PersonelTabControl.Controls.Add(this.PersonelOzlukTab);
            this.PersonelTabControl.Controls.Add(this.PersonelBransTab);
            this.PersonelTabControl.Controls.Add(this.PersonelMaasTab);
            this.PersonelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonelTabControl.Location = new System.Drawing.Point(3, 3);
            this.PersonelTabControl.Name = "PersonelTabControl";
            this.PersonelTabControl.SelectedIndex = 0;
            this.PersonelTabControl.Size = new System.Drawing.Size(572, 391);
            this.PersonelTabControl.TabIndex = 1;
            this.PersonelTabControl.SelectedIndexChanged += new System.EventHandler(this.PersonelTabControl_SelectedIndexChanged);
            // 
            // PersonelOzlukTab
            // 
            this.PersonelOzlukTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PersonelOzlukTab.Controls.Add(this.PersonelkisiselBilgilerUserCntrl);
            this.PersonelOzlukTab.Location = new System.Drawing.Point(4, 22);
            this.PersonelOzlukTab.Name = "PersonelOzlukTab";
            this.PersonelOzlukTab.Size = new System.Drawing.Size(564, 365);
            this.PersonelOzlukTab.TabIndex = 0;
            this.PersonelOzlukTab.Text = "Özlük İşlemleri";
            // 
            // PersonelkisiselBilgilerUserCntrl
            // 
            this.PersonelkisiselBilgilerUserCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PersonelkisiselBilgilerUserCntrl.Location = new System.Drawing.Point(8, 8);
            this.PersonelkisiselBilgilerUserCntrl.Name = "PersonelkisiselBilgilerUserCntrl";
            this.PersonelkisiselBilgilerUserCntrl.Size = new System.Drawing.Size(521, 326);
            this.PersonelkisiselBilgilerUserCntrl.TabIndex = 0;
            // 
            // PersonelBransTab
            // 
            this.PersonelBransTab.Controls.Add(this.btnKaydet);
            this.PersonelBransTab.Controls.Add(this.lstViewPersonel);
            this.PersonelBransTab.Controls.Add(this.cmbBirim);
            this.PersonelBransTab.Controls.Add(this.label2);
            this.PersonelBransTab.Controls.Add(this.cmbPersonel);
            this.PersonelBransTab.Controls.Add(this.label1);
            this.PersonelBransTab.Location = new System.Drawing.Point(4, 22);
            this.PersonelBransTab.Name = "PersonelBransTab";
            this.PersonelBransTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonelBransTab.Size = new System.Drawing.Size(564, 365);
            this.PersonelBransTab.TabIndex = 1;
            this.PersonelBransTab.Text = "Branş İşlemleri";
            this.PersonelBransTab.UseVisualStyleBackColor = true;
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
            // lstViewPersonel
            // 
            this.lstViewPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tcNo,
            this.ad,
            this.soyad,
            this.brans,
            this.cinsiyet});
            this.lstViewPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewPersonel.FullRowSelect = true;
            this.lstViewPersonel.GridLines = true;
            this.lstViewPersonel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewPersonel.Location = new System.Drawing.Point(8, 82);
            this.lstViewPersonel.Name = "lstViewPersonel";
            this.lstViewPersonel.Size = new System.Drawing.Size(492, 152);
            this.lstViewPersonel.TabIndex = 4;
            this.lstViewPersonel.UseCompatibleStateImageBehavior = false;
            this.lstViewPersonel.View = System.Windows.Forms.View.Details;
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
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(110, 45);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(342, 21);
            this.cmbBirim.TabIndex = 3;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
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
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(110, 15);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(342, 21);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Seçiniz:";
            // 
            // PersonelMaasTab
            // 
            this.PersonelMaasTab.Controls.Add(this.groupBox1);
            this.PersonelMaasTab.Controls.Add(this.listViewPersonelMaasTab);
            this.PersonelMaasTab.Location = new System.Drawing.Point(4, 22);
            this.PersonelMaasTab.Name = "PersonelMaasTab";
            this.PersonelMaasTab.Size = new System.Drawing.Size(564, 365);
            this.PersonelMaasTab.TabIndex = 3;
            this.PersonelMaasTab.Text = "Maaş İşlemleri";
            this.PersonelMaasTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbPersonelSecMaasTab);
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
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Personel Seçiniz:";
            // 
            // cmbPersonelSecMaasTab
            // 
            this.cmbPersonelSecMaasTab.FormattingEnabled = true;
            this.cmbPersonelSecMaasTab.Location = new System.Drawing.Point(100, 13);
            this.cmbPersonelSecMaasTab.Name = "cmbPersonelSecMaasTab";
            this.cmbPersonelSecMaasTab.Size = new System.Drawing.Size(433, 21);
            this.cmbPersonelSecMaasTab.TabIndex = 3;
            this.cmbPersonelSecMaasTab.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelSecMaasTab_SelectedIndexChanged);
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
            this.nudMaas.Location = new System.Drawing.Point(100, 45);
            this.nudMaas.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(128, 20);
            this.nudMaas.TabIndex = 5;
            this.nudMaas.ValueChanged += new System.EventHandler(this.nudMaas_ValueChanged);
            // 
            // listViewPersonelMaasTab
            // 
            this.listViewPersonelMaasTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.adi,
            this.soyadi,
            this.bransi,
            this.cinsiyeti,
            this.dgmtarihi,
            this.telefon,
            this.maili,
            this.maas});
            this.listViewPersonelMaasTab.FullRowSelect = true;
            this.listViewPersonelMaasTab.GridLines = true;
            this.listViewPersonelMaasTab.Location = new System.Drawing.Point(6, 142);
            this.listViewPersonelMaasTab.Name = "listViewPersonelMaasTab";
            this.listViewPersonelMaasTab.Size = new System.Drawing.Size(603, 183);
            this.listViewPersonelMaasTab.TabIndex = 9;
            this.listViewPersonelMaasTab.UseCompatibleStateImageBehavior = false;
            this.listViewPersonelMaasTab.View = System.Windows.Forms.View.Details;
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
            // dosyayiAc
            // 
            this.dosyayiAc.FileName = "openFileDialog1";
            // 
            // frmPersonelMenuStrip
            // 
            this.frmPersonelMenuStrip.BackColor = System.Drawing.Color.LightBlue;
            this.frmPersonelMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmPersonelMenuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.frmPersonelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CiktiToolStripMenuItem});
            this.frmPersonelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmPersonelMenuStrip.Name = "frmPersonelMenuStrip";
            this.frmPersonelMenuStrip.Size = new System.Drawing.Size(586, 24);
            this.frmPersonelMenuStrip.TabIndex = 3;
            this.frmPersonelMenuStrip.Text = "frmDoktormenuStrip";
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
            this.XMLDisariAktartoolStripMenuItem,
            this.XMLIceriAktarToolStripMenuItem});
            this.AktarimIslemleriToolStripMenuItem.Name = "AktarimIslemleriToolStripMenuItem";
            this.AktarimIslemleriToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.AktarimIslemleriToolStripMenuItem.Text = "İşlemler";
            // 
            // XMLDisariAktartoolStripMenuItem
            // 
            this.XMLDisariAktartoolStripMenuItem.Name = "XMLDisariAktartoolStripMenuItem";
            this.XMLDisariAktartoolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.XMLDisariAktartoolStripMenuItem.Text = "Dışarı Aktar";
            this.XMLDisariAktartoolStripMenuItem.Click += new System.EventHandler(this.XMLDisariAktartoolStripMenuItem_Click);
            // 
            // XMLIceriAktarToolStripMenuItem
            // 
            this.XMLIceriAktarToolStripMenuItem.Name = "XMLIceriAktarToolStripMenuItem";
            this.XMLIceriAktarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.XMLIceriAktarToolStripMenuItem.Text = "İçeri Aktar";
            this.XMLIceriAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLIceriAktarToolStripMenuItem_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 423);
            this.Controls.Add(this.frmPersonelMenuStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPersonel";
            this.Text = "PERSONEL İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PersonelTabControl.ResumeLayout(false);
            this.PersonelOzlukTab.ResumeLayout(false);
            this.PersonelBransTab.ResumeLayout(false);
            this.PersonelBransTab.PerformLayout();
            this.PersonelMaasTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.frmPersonelMenuStrip.ResumeLayout(false);
            this.frmPersonelMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.OpenFileDialog dosyayiAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.MenuStrip frmPersonelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CiktiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AktarimIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLDisariAktartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIceriAktarToolStripMenuItem;
        private System.Windows.Forms.TabControl PersonelTabControl;
        private System.Windows.Forms.TabPage PersonelOzlukTab;
        private KisiselBilgiler PersonelkisiselBilgilerUserCntrl;
        private System.Windows.Forms.TabPage PersonelBransTab;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView lstViewPersonel;
        private System.Windows.Forms.ColumnHeader tcNo;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader brans;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PersonelMaasTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPersonelSecMaasTab;
        private System.Windows.Forms.Button btnMaasKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.ListView listViewPersonelMaasTab;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader adi;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader bransi;
        private System.Windows.Forms.ColumnHeader cinsiyeti;
        private System.Windows.Forms.ColumnHeader dgmtarihi;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader maili;
        private System.Windows.Forms.ColumnHeader maas;
    }
}