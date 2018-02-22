namespace HospitalAutomation
{
    partial class FrmContainer
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
            this.frmDoktormenuStrip = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciktiIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDoktormenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmDoktormenuStrip
            // 
            this.frmDoktormenuStrip.BackColor = System.Drawing.Color.LightBlue;
            this.frmDoktormenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmDoktormenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.hemsireToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.ciktiIslemleriToolStripMenuItem});
            this.frmDoktormenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmDoktormenuStrip.Name = "frmDoktormenuStrip";
            this.frmDoktormenuStrip.Size = new System.Drawing.Size(934, 24);
            this.frmDoktormenuStrip.TabIndex = 3;
            this.frmDoktormenuStrip.Text = "frmDoktormenuStrip";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.personelToolStripMenuItem.Text = "PERSONEL İŞLEMLERİ";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.toolstripMenuItemClik);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.doktorToolStripMenuItem.Text = "DOKTOR İŞLEMLERİ";
            // 
            // hemsireToolStripMenuItem
            // 
            this.hemsireToolStripMenuItem.Name = "hemsireToolStripMenuItem";
            this.hemsireToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.hemsireToolStripMenuItem.Text = "HEMŞİRE İŞLEMLERİ";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.hastaToolStripMenuItem.Text = "HASTA İŞLEMLERİ";
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.randevuToolStripMenuItem.Text = "RANDEVU İŞLEMLERİ";
            // 
            // ciktiIslemleriToolStripMenuItem
            // 
            this.ciktiIslemleriToolStripMenuItem.Name = "ciktiIslemleriToolStripMenuItem";
            this.ciktiIslemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.ciktiIslemleriToolStripMenuItem.Text = "ÇIKTI İŞLEMLERİ";
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.frmDoktormenuStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTANE RANDEVU OTOMASYON SİSTEMİ";
            this.frmDoktormenuStrip.ResumeLayout(false);
            this.frmDoktormenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmDoktormenuStrip;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemsireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciktiIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
    }
}