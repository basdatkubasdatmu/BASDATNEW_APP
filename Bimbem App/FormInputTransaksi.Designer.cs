﻿
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
            this.txtKeteranganBayar = new System.Windows.Forms.TextBox();
            this.ktrPembayaran = new System.Windows.Forms.Label();
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenuUtama = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRuangZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRuangZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRuangZoom.Controls.Add(this.dgvTransaksi);
            this.pnlRuangZoom.Location = new System.Drawing.Point(27, 337);
            this.pnlRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(850, 302);
            this.pnlRuangZoom.TabIndex = 3;
            // 
            // txtKeteranganBayar
            // 
            this.txtKeteranganBayar.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKeteranganBayar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKeteranganBayar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKeteranganBayar.Location = new System.Drawing.Point(521, 182);
            this.txtKeteranganBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeteranganBayar.Name = "txtKeteranganBayar";
            this.txtKeteranganBayar.Size = new System.Drawing.Size(212, 29);
            this.txtKeteranganBayar.TabIndex = 10;
            this.txtKeteranganBayar.TextChanged += new System.EventHandler(this.txtKeteranganBayar_TextChanged);
            // 
            // ktrPembayaran
            // 
            this.ktrPembayaran.AutoSize = true;
            this.ktrPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ktrPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ktrPembayaran.Location = new System.Drawing.Point(521, 159);
            this.ktrPembayaran.Name = "ktrPembayaran";
            this.ktrPembayaran.Size = new System.Drawing.Size(94, 21);
            this.ktrPembayaran.TabIndex = 9;
            this.ktrPembayaran.Text = "Keterangan";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Control;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBatal.Location = new System.Drawing.Point(661, 290);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 33);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimpan.Location = new System.Drawing.Point(581, 290);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(74, 33);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // txtTglPembayaran
            // 
            this.txtTglPembayaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtTglPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTglPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTglPembayaran.Location = new System.Drawing.Point(521, 116);
            this.txtTglPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTglPembayaran.Name = "txtTglPembayaran";
            this.txtTglPembayaran.Size = new System.Drawing.Size(212, 29);
            this.txtTglPembayaran.TabIndex = 4;
            // 
            // txtKodeKelas
            // 
            this.txtKodeKelas.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodeKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeKelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKodeKelas.Location = new System.Drawing.Point(283, 246);
            this.txtKodeKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeKelas.Name = "txtKodeKelas";
            this.txtKodeKelas.Size = new System.Drawing.Size(212, 29);
            this.txtKodeKelas.TabIndex = 6;
            // 
            // tanggalPembayaran
            // 
            this.tanggalPembayaran.AutoSize = true;
            this.tanggalPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tanggalPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tanggalPembayaran.Location = new System.Drawing.Point(521, 94);
            this.tanggalPembayaran.Name = "tanggalPembayaran";
            this.tanggalPembayaran.Size = new System.Drawing.Size(158, 21);
            this.tanggalPembayaran.TabIndex = 3;
            this.tanggalPembayaran.Text = "Tanggal Pembayaran";
            // 
            // kodeKelas
            // 
            this.kodeKelas.AutoSize = true;
            this.kodeKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodeKelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kodeKelas.Location = new System.Drawing.Point(283, 223);
            this.kodeKelas.Name = "kodeKelas";
            this.kodeKelas.Size = new System.Drawing.Size(91, 21);
            this.kodeKelas.TabIndex = 5;
            this.kodeKelas.Text = "Kode Kelas";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.DarkOrange;
            this.txtNoSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoSiswa.Location = new System.Drawing.Point(283, 182);
            this.txtNoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(212, 29);
            this.txtNoSiswa.TabIndex = 4;
            // 
            // noSiswa
            // 
            this.noSiswa.AutoSize = true;
            this.noSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noSiswa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noSiswa.Location = new System.Drawing.Point(283, 159);
            this.noSiswa.Name = "noSiswa";
            this.noSiswa.Size = new System.Drawing.Size(76, 21);
            this.noSiswa.TabIndex = 3;
            this.noSiswa.Text = "No Siswa";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPembayaran.Location = new System.Drawing.Point(283, 116);
            this.txtPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(212, 29);
            this.txtPembayaran.TabIndex = 2;
            // 
            // kodePembayaran
            // 
            this.kodePembayaran.AutoSize = true;
            this.kodePembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodePembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kodePembayaran.Location = new System.Drawing.Point(283, 94);
            this.kodePembayaran.Name = "kodePembayaran";
            this.kodePembayaran.Size = new System.Drawing.Size(141, 21);
            this.kodePembayaran.TabIndex = 1;
            this.kodePembayaran.Text = "Kode Pembayaran";
            // 
            // inputPembayaran
            // 
            this.inputPembayaran.AutoSize = true;
            this.inputPembayaran.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputPembayaran.Location = new System.Drawing.Point(338, 40);
            this.inputPembayaran.Name = "inputPembayaran";
            this.inputPembayaran.Size = new System.Drawing.Size(317, 32);
            this.inputPembayaran.TabIndex = 0;
            this.inputPembayaran.Text = "TRANSAKSI PEMBAYARAN";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Control;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(883, 337);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(74, 33);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(883, 374);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 33);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Control;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(883, 411);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 33);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.keterangan});
            this.dgvTransaksi.Location = new System.Drawing.Point(21, 19);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowTemplate.Height = 25;
            this.dgvTransaksi.Size = new System.Drawing.Size(809, 264);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kodePembayaran";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode Pembayaran";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "noSiswa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nomor Siswa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kodeKelas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kode Kelas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tanggalPembayaran";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanggal Pembayaran";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // keterangan
            // 
            this.keterangan.DataPropertyName = "keterangan";
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            // 
            // btnMenuUtama
            // 
            this.btnMenuUtama.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenuUtama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuUtama.Location = new System.Drawing.Point(892, 12);
            this.btnMenuUtama.Name = "btnMenuUtama";
            this.btnMenuUtama.Size = new System.Drawing.Size(74, 33);
            this.btnMenuUtama.TabIndex = 72;
            this.btnMenuUtama.Text = "Home";
            this.btnMenuUtama.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(883, 448);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 33);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // FormInputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 665);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMenuUtama);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtKeteranganBayar);
            this.Controls.Add(this.ktrPembayaran);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.inputPembayaran);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.kodePembayaran);
            this.Controls.Add(this.txtTglPembayaran);
            this.Controls.Add(this.txtPembayaran);
            this.Controls.Add(this.txtKodeKelas);
            this.Controls.Add(this.noSiswa);
            this.Controls.Add(this.tanggalPembayaran);
            this.Controls.Add(this.txtNoSiswa);
            this.Controls.Add(this.kodeKelas);
            this.Controls.Add(this.pnlRuangZoom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRuangZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
        private System.Windows.Forms.Button btnMenuUtama;
        private System.Windows.Forms.Button btnRefresh;
    }
}