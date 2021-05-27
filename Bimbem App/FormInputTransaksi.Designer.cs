
namespace Bimbem_App
{
    partial class FormInputTransaksi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRuangZoom = new System.Windows.Forms.Panel();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTglPembayaran = new System.Windows.Forms.TextBox();
            this.txtKodeKelas = new System.Windows.Forms.TextBox();
            this.tanggalPembayaran = new System.Windows.Forms.Label();
            this.kodeKelas = new System.Windows.Forms.Label();
            this.txtNoSiswa = new System.Windows.Forms.TextBox();
            this.noSiswa = new System.Windows.Forms.Label();
            this.txtPembayaran = new System.Windows.Forms.TextBox();
            this.kodePembayaran = new System.Windows.Forms.Label();
            this.inputPembayaran = new System.Windows.Forms.Label();
            this.txtKeteranganBayar = new System.Windows.Forms.TextBox();
            this.ktrPembayaran = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRuangZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRuangZoom.Controls.Add(this.txtKeteranganBayar);
            this.pnlRuangZoom.Controls.Add(this.ktrPembayaran);
            this.pnlRuangZoom.Controls.Add(this.btnBatal);
            this.pnlRuangZoom.Controls.Add(this.btnSimpan);
            this.pnlRuangZoom.Controls.Add(this.txtTglPembayaran);
            this.pnlRuangZoom.Controls.Add(this.txtKodeKelas);
            this.pnlRuangZoom.Controls.Add(this.tanggalPembayaran);
            this.pnlRuangZoom.Controls.Add(this.kodeKelas);
            this.pnlRuangZoom.Controls.Add(this.txtNoSiswa);
            this.pnlRuangZoom.Controls.Add(this.noSiswa);
            this.pnlRuangZoom.Controls.Add(this.txtPembayaran);
            this.pnlRuangZoom.Controls.Add(this.kodePembayaran);
            this.pnlRuangZoom.Controls.Add(this.inputPembayaran);
            this.pnlRuangZoom.Location = new System.Drawing.Point(44, 26);
            this.pnlRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(300, 403);
            this.pnlRuangZoom.TabIndex = 3;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(192, 351);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(65, 23);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(119, 351);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(67, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // txtTglPembayaran
            // 
            this.txtTglPembayaran.BackColor = System.Drawing.Color.Salmon;
            this.txtTglPembayaran.Location = new System.Drawing.Point(45, 260);
            this.txtTglPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTglPembayaran.Name = "txtTglPembayaran";
            this.txtTglPembayaran.Size = new System.Drawing.Size(212, 23);
            this.txtTglPembayaran.TabIndex = 4;
            // 
            // txtKodeKelas
            // 
            this.txtKodeKelas.BackColor = System.Drawing.Color.Salmon;
            this.txtKodeKelas.Location = new System.Drawing.Point(45, 207);
            this.txtKodeKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeKelas.Name = "txtKodeKelas";
            this.txtKodeKelas.Size = new System.Drawing.Size(212, 23);
            this.txtKodeKelas.TabIndex = 6;
            // 
            // tanggalPembayaran
            // 
            this.tanggalPembayaran.AutoSize = true;
            this.tanggalPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tanggalPembayaran.Location = new System.Drawing.Point(43, 243);
            this.tanggalPembayaran.Name = "tanggalPembayaran";
            this.tanggalPembayaran.Size = new System.Drawing.Size(118, 15);
            this.tanggalPembayaran.TabIndex = 3;
            this.tanggalPembayaran.Text = "Tanggal Pembayaran";
            // 
            // kodeKelas
            // 
            this.kodeKelas.AutoSize = true;
            this.kodeKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodeKelas.Location = new System.Drawing.Point(43, 190);
            this.kodeKelas.Name = "kodeKelas";
            this.kodeKelas.Size = new System.Drawing.Size(64, 15);
            this.kodeKelas.TabIndex = 5;
            this.kodeKelas.Text = "Kode Kelas";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.Salmon;
            this.txtNoSiswa.Location = new System.Drawing.Point(43, 159);
            this.txtNoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(212, 23);
            this.txtNoSiswa.TabIndex = 4;
            // 
            // noSiswa
            // 
            this.noSiswa.AutoSize = true;
            this.noSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noSiswa.Location = new System.Drawing.Point(43, 142);
            this.noSiswa.Name = "noSiswa";
            this.noSiswa.Size = new System.Drawing.Size(56, 15);
            this.noSiswa.TabIndex = 3;
            this.noSiswa.Text = "No Siswa";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.BackColor = System.Drawing.Color.Salmon;
            this.txtPembayaran.Location = new System.Drawing.Point(43, 111);
            this.txtPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(212, 23);
            this.txtPembayaran.TabIndex = 2;
            // 
            // kodePembayaran
            // 
            this.kodePembayaran.AutoSize = true;
            this.kodePembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodePembayaran.Location = new System.Drawing.Point(43, 94);
            this.kodePembayaran.Name = "kodePembayaran";
            this.kodePembayaran.Size = new System.Drawing.Size(103, 15);
            this.kodePembayaran.TabIndex = 1;
            this.kodePembayaran.Text = "Kode Pembayaran";
            // 
            // inputPembayaran
            // 
            this.inputPembayaran.AutoSize = true;
            this.inputPembayaran.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputPembayaran.Location = new System.Drawing.Point(43, 31);
            this.inputPembayaran.Name = "inputPembayaran";
            this.inputPembayaran.Size = new System.Drawing.Size(204, 30);
            this.inputPembayaran.TabIndex = 0;
            this.inputPembayaran.Text = "Input Pembayaran";
            // 
            // txtKeteranganBayar
            // 
            this.txtKeteranganBayar.BackColor = System.Drawing.Color.Salmon;
            this.txtKeteranganBayar.Location = new System.Drawing.Point(45, 314);
            this.txtKeteranganBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeteranganBayar.Name = "txtKeteranganBayar";
            this.txtKeteranganBayar.Size = new System.Drawing.Size(212, 23);
            this.txtKeteranganBayar.TabIndex = 10;
            // 
            // ktrPembayaran
            // 
            this.ktrPembayaran.AutoSize = true;
            this.ktrPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ktrPembayaran.Location = new System.Drawing.Point(43, 297);
            this.ktrPembayaran.Name = "ktrPembayaran";
            this.ktrPembayaran.Size = new System.Drawing.Size(67, 15);
            this.ktrPembayaran.TabIndex = 9;
            this.ktrPembayaran.Text = "Keterangan";
            // 
            // FormInputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 461);
            this.Controls.Add(this.pnlRuangZoom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInputTransaksi";
            this.Text = "FormInputTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRuangZoom.ResumeLayout(false);
            this.pnlRuangZoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRuangZoom;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtTglPembayaran;
        private System.Windows.Forms.TextBox txtKodeKelas;
        private System.Windows.Forms.Label tanggalPembayaran;
        private System.Windows.Forms.Label kodeKelas;
        private System.Windows.Forms.TextBox txtNoSiswa;
        private System.Windows.Forms.Label noSiswa;
        private System.Windows.Forms.TextBox txtPembayaran;
        private System.Windows.Forms.Label kodePembayaran;
        private System.Windows.Forms.Label inputPembayaran;
        private System.Windows.Forms.TextBox txtKeteranganBayar;
        private System.Windows.Forms.Label ktrPembayaran;
    }
}