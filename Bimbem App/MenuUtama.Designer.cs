
namespace Bimbem_App
{
    partial class MenuUtama
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
            this.mnAplikasi = new System.Windows.Forms.MenuStrip();
            this.pemesanan = new System.Windows.Forms.ToolStripMenuItem();
            this.pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAplikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnAplikasi
            // 
            this.mnAplikasi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pemesanan,
            this.pelanggan});
            this.mnAplikasi.Location = new System.Drawing.Point(0, 0);
            this.mnAplikasi.Name = "mnAplikasi";
            this.mnAplikasi.Size = new System.Drawing.Size(800, 24);
            this.mnAplikasi.TabIndex = 0;
            this.mnAplikasi.Text = "Aplikasi Pemesanan Tiket";
            // 
            // pemesanan
            // 
            this.pemesanan.Name = "pemesanan";
            this.pemesanan.Size = new System.Drawing.Size(80, 20);
            this.pemesanan.Text = "Pemesanan";
            // 
            // pelanggan
            // 
            this.pelanggan.Name = "pelanggan";
            this.pelanggan.Size = new System.Drawing.Size(75, 20);
            this.pelanggan.Text = "Pelanggan";
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnAplikasi);
            this.MainMenuStrip = this.mnAplikasi;
            this.Name = "MenuUtama";
            this.Text = "Aplikasi Pemesanan Tolet";
            this.mnAplikasi.ResumeLayout(false);
            this.mnAplikasi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnAplikasi;
        private System.Windows.Forms.ToolStripMenuItem pemesanan;
        private System.Windows.Forms.ToolStripMenuItem pelanggan;
    }
}