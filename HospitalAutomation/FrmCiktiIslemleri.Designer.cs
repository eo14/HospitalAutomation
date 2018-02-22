namespace HospitalAutomation
{
    partial class FrmCiktiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCiktiIslemleri));
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.comboBoxDrSeciniz = new System.Windows.Forms.ComboBox();
            this.DoktorSeciniz = new System.Windows.Forms.Label();
            this.listViewDktr = new System.Windows.Forms.ListView();
            this.rndTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rndSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hastaSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogumtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.Location = new System.Drawing.Point(15, 311);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(547, 25);
            this.btnCiktiAl.TabIndex = 0;
            this.btnCiktiAl.Text = "ÇIKTI AL";
            this.btnCiktiAl.UseVisualStyleBackColor = true;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // comboBoxDrSeciniz
            // 
            this.comboBoxDrSeciniz.FormattingEnabled = true;
            this.comboBoxDrSeciniz.Location = new System.Drawing.Point(97, 17);
            this.comboBoxDrSeciniz.Name = "comboBoxDrSeciniz";
            this.comboBoxDrSeciniz.Size = new System.Drawing.Size(465, 21);
            this.comboBoxDrSeciniz.TabIndex = 1;
            this.comboBoxDrSeciniz.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrSeciniz_SelectedIndexChanged);
            // 
            // DoktorSeciniz
            // 
            this.DoktorSeciniz.AutoSize = true;
            this.DoktorSeciniz.Location = new System.Drawing.Point(12, 20);
            this.DoktorSeciniz.Name = "DoktorSeciniz";
            this.DoktorSeciniz.Size = new System.Drawing.Size(79, 13);
            this.DoktorSeciniz.TabIndex = 2;
            this.DoktorSeciniz.Text = "Doktor Seçiniz:";
            // 
            // listViewDktr
            // 
            this.listViewDktr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rndTarih,
            this.rndSaat,
            this.hastaAd,
            this.hastaSoyad,
            this.cinsiyet,
            this.dogumtarihi});
            this.listViewDktr.FullRowSelect = true;
            this.listViewDktr.GridLines = true;
            this.listViewDktr.Location = new System.Drawing.Point(15, 44);
            this.listViewDktr.Name = "listViewDktr";
            this.listViewDktr.Size = new System.Drawing.Size(547, 261);
            this.listViewDktr.TabIndex = 3;
            this.listViewDktr.UseCompatibleStateImageBehavior = false;
            this.listViewDktr.View = System.Windows.Forms.View.Details;
            // 
            // rndTarih
            // 
            this.rndTarih.Text = "Randevu Tarih";
            this.rndTarih.Width = 86;
            // 
            // rndSaat
            // 
            this.rndSaat.Text = "Randevu Saat";
            this.rndSaat.Width = 86;
            // 
            // hastaAd
            // 
            this.hastaAd.Text = "Hasta Adı";
            this.hastaAd.Width = 65;
            // 
            // hastaSoyad
            // 
            this.hastaSoyad.Text = "Hasta Soyad";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Text = "Cinsiyeti";
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.Text = "Doğum Tarihi";
            this.dogumtarihi.Width = 95;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmCiktiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.listViewDktr);
            this.Controls.Add(this.DoktorSeciniz);
            this.Controls.Add(this.comboBoxDrSeciniz);
            this.Controls.Add(this.btnCiktiAl);
            this.Name = "FrmCiktiIslemleri";
            this.Text = "ÇIKTI İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmCiktiIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCiktiAl;
        private System.Windows.Forms.ComboBox comboBoxDrSeciniz;
        private System.Windows.Forms.Label DoktorSeciniz;
        private System.Windows.Forms.ListView listViewDktr;
        private System.Windows.Forms.ColumnHeader rndTarih;
        private System.Windows.Forms.ColumnHeader rndSaat;
        private System.Windows.Forms.ColumnHeader hastaAd;
        private System.Windows.Forms.ColumnHeader hastaSoyad;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ColumnHeader dogumtarihi;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}