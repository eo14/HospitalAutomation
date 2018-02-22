namespace HospitalAutomation
{
    partial class RandevuSaatleriBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaat
            // 
            this.btnSaat.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaat.Location = new System.Drawing.Point(0, 0);
            this.btnSaat.Name = "btnSaat";
            this.btnSaat.Size = new System.Drawing.Size(80, 35);
            this.btnSaat.TabIndex = 0;
            this.btnSaat.Text = "button1";
            this.btnSaat.UseVisualStyleBackColor = false;
            this.btnSaat.Click += new System.EventHandler(this.btnSaat_Click);
            // 
            // RandevuSaatleriBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaat);
            this.Name = "RandevuSaatleriBtn";
            this.Size = new System.Drawing.Size(80, 35);
            this.Load += new System.EventHandler(this.RandevuSaatleriBtn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSaat;
    }
}
