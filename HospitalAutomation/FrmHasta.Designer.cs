namespace HospitalAutomation
{
    partial class FrmHasta
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
            this.HastatabControl = new System.Windows.Forms.TabControl();
            this.HastatabPage = new System.Windows.Forms.TabPage();
            this.HastakisiselBilgilerUserCntrl = new HospitalAutomation.KisiselBilgiler();
            this.frmDoktormenuStrip = new System.Windows.Forms.MenuStrip();
            this.CiktiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AktarimIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIceriiAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyayiAc = new System.Windows.Forms.OpenFileDialog();
            this.HastatabControl.SuspendLayout();
            this.HastatabPage.SuspendLayout();
            this.frmDoktormenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HastatabControl
            // 
            this.HastatabControl.Controls.Add(this.HastatabPage);
            this.HastatabControl.Location = new System.Drawing.Point(0, 31);
            this.HastatabControl.Name = "HastatabControl";
            this.HastatabControl.SelectedIndex = 0;
            this.HastatabControl.Size = new System.Drawing.Size(497, 355);
            this.HastatabControl.TabIndex = 0;
            this.HastatabControl.SelectedIndexChanged += new System.EventHandler(this.HastatabControl_SelectedIndexChanged);
            // 
            // HastatabPage
            // 
            this.HastatabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HastatabPage.Controls.Add(this.HastakisiselBilgilerUserCntrl);
            this.HastatabPage.Location = new System.Drawing.Point(4, 22);
            this.HastatabPage.Name = "HastatabPage";
            this.HastatabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HastatabPage.Size = new System.Drawing.Size(489, 329);
            this.HastatabPage.TabIndex = 0;
            this.HastatabPage.Text = "Hasta Özlük İşlemleri";
            // 
            // HastakisiselBilgilerUserCntrl
            // 
            this.HastakisiselBilgilerUserCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HastakisiselBilgilerUserCntrl.Location = new System.Drawing.Point(-14, 19);
            this.HastakisiselBilgilerUserCntrl.Name = "HastakisiselBilgilerUserCntrl";
            this.HastakisiselBilgilerUserCntrl.Size = new System.Drawing.Size(512, 326);
            this.HastakisiselBilgilerUserCntrl.TabIndex = 0;
            // 
            // frmDoktormenuStrip
            // 
            this.frmDoktormenuStrip.BackColor = System.Drawing.Color.LightBlue;
            this.frmDoktormenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmDoktormenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CiktiToolStripMenuItem});
            this.frmDoktormenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmDoktormenuStrip.Name = "frmDoktormenuStrip";
            this.frmDoktormenuStrip.Size = new System.Drawing.Size(497, 24);
            this.frmDoktormenuStrip.TabIndex = 2;
            this.frmDoktormenuStrip.Text = "frmDoktormenuStrip";
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
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 386);
            this.Controls.Add(this.frmDoktormenuStrip);
            this.Controls.Add(this.HastatabControl);
            this.Name = "FrmHasta";
            this.Text = "HASTA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmHasta_Load);
            this.HastatabControl.ResumeLayout(false);
            this.HastatabPage.ResumeLayout(false);
            this.frmDoktormenuStrip.ResumeLayout(false);
            this.frmDoktormenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl HastatabControl;
        private System.Windows.Forms.TabPage HastatabPage;
        private System.Windows.Forms.MenuStrip frmDoktormenuStrip;
        private KisiselBilgiler HastakisiselBilgilerUserCntrl;
        private System.Windows.Forms.ToolStripMenuItem CiktiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AktarimIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIceriiAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyayiAc;
    }
}