﻿
namespace Bimbem_App
{
    partial class FormInputNilai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pctrInputNilai = new System.Windows.Forms.PictureBox();
            this.pnlRuangZoom = new System.Windows.Forms.Panel();
            this.dgvNilai = new System.Windows.Forms.DataGridView();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.txtKodePelajaran = new System.Windows.Forms.TextBox();
            this.nilaiInputNilai = new System.Windows.Forms.Label();
            this.kodePelajaranInputNilai = new System.Windows.Forms.Label();
            this.txtNoPengajar = new System.Windows.Forms.TextBox();
            this.txtNamaSiswa = new System.Windows.Forms.TextBox();
            this.noPengajarInputNilai = new System.Windows.Forms.Label();
            this.namaSiswaInputNilai = new System.Windows.Forms.Label();
            this.txtNoSiswa = new System.Windows.Forms.TextBox();
            this.noSiswaInputNilai = new System.Windows.Forms.Label();
            this.txtKodeUjian = new System.Windows.Forms.TextBox();
            this.kodeUjianInputNilai = new System.Windows.Forms.Label();
            this.inputNilai = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.kodeujian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrInputNilai)).BeginInit();
            this.pnlRuangZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrInputNilai
            // 
            this.pctrInputNilai.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pctrInputNilai.InitialImage = null;
            this.pctrInputNilai.Location = new System.Drawing.Point(-1, -29);
            this.pctrInputNilai.Name = "pctrInputNilai";
            this.pctrInputNilai.Size = new System.Drawing.Size(1158, 760);
            this.pctrInputNilai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrInputNilai.TabIndex = 0;
            this.pctrInputNilai.TabStop = false;
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlRuangZoom.Controls.Add(this.dgvNilai);
            this.pnlRuangZoom.Location = new System.Drawing.Point(296, 157);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(719, 448);
            this.pnlRuangZoom.TabIndex = 3;
            // 
            // dgvNilai
            // 
            this.dgvNilai.AllowUserToAddRows = false;
            this.dgvNilai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvNilai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNilai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeujian,
            this.nosiswa,
            this.nama,
            this.namapengajar,
            this.namapelajaran,
            this.nilai});
            this.dgvNilai.Location = new System.Drawing.Point(22, 28);
            this.dgvNilai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNilai.Name = "dgvNilai";
            this.dgvNilai.ReadOnly = true;
            this.dgvNilai.RowHeadersWidth = 51;
            this.dgvNilai.RowTemplate.Height = 25;
            this.dgvNilai.Size = new System.Drawing.Size(675, 392);
            this.dgvNilai.TabIndex = 0;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBatal.Location = new System.Drawing.Point(189, 548);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(85, 31);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSimpan.Location = new System.Drawing.Point(90, 548);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 31);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNilai
            // 
            this.txtNilai.BackColor = System.Drawing.Color.Salmon;
            this.txtNilai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNilai.Location = new System.Drawing.Point(29, 499);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(242, 23);
            this.txtNilai.TabIndex = 8;
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.BackColor = System.Drawing.Color.Salmon;
            this.txtKodePelajaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtKodePelajaran.Location = new System.Drawing.Point(30, 429);
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(242, 23);
            this.txtKodePelajaran.TabIndex = 10;
            // 
            // nilaiInputNilai
            // 
            this.nilaiInputNilai.AutoSize = true;
            this.nilaiInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nilaiInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nilaiInputNilai.Location = new System.Drawing.Point(29, 471);
            this.nilaiInputNilai.Name = "nilaiInputNilai";
            this.nilaiInputNilai.Size = new System.Drawing.Size(44, 23);
            this.nilaiInputNilai.TabIndex = 7;
            this.nilaiInputNilai.Text = "Nilai";
            // 
            // kodePelajaranInputNilai
            // 
            this.kodePelajaranInputNilai.AutoSize = true;
            this.kodePelajaranInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodePelajaranInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kodePelajaranInputNilai.Location = new System.Drawing.Point(30, 401);
            this.kodePelajaranInputNilai.Name = "kodePelajaranInputNilai";
            this.kodePelajaranInputNilai.Size = new System.Drawing.Size(123, 23);
            this.kodePelajaranInputNilai.TabIndex = 9;
            this.kodePelajaranInputNilai.Text = "Kode Pelajaran";
            // 
            // txtNoPengajar
            // 
            this.txtNoPengajar.BackColor = System.Drawing.Color.Salmon;
            this.txtNoPengajar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoPengajar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNoPengajar.Location = new System.Drawing.Point(29, 361);
            this.txtNoPengajar.Name = "txtNoPengajar";
            this.txtNoPengajar.Size = new System.Drawing.Size(242, 23);
            this.txtNoPengajar.TabIndex = 4;
            // 
            // txtNamaSiswa
            // 
            this.txtNamaSiswa.BackColor = System.Drawing.Color.Salmon;
            this.txtNamaSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNamaSiswa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNamaSiswa.Location = new System.Drawing.Point(29, 295);
            this.txtNamaSiswa.Name = "txtNamaSiswa";
            this.txtNamaSiswa.Size = new System.Drawing.Size(242, 23);
            this.txtNamaSiswa.TabIndex = 6;
            // 
            // noPengajarInputNilai
            // 
            this.noPengajarInputNilai.AutoSize = true;
            this.noPengajarInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noPengajarInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.noPengajarInputNilai.Location = new System.Drawing.Point(29, 335);
            this.noPengajarInputNilai.Name = "noPengajarInputNilai";
            this.noPengajarInputNilai.Size = new System.Drawing.Size(104, 23);
            this.noPengajarInputNilai.TabIndex = 3;
            this.noPengajarInputNilai.Text = "No Pengajar";
            // 
            // namaSiswaInputNilai
            // 
            this.namaSiswaInputNilai.AutoSize = true;
            this.namaSiswaInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namaSiswaInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.namaSiswaInputNilai.Location = new System.Drawing.Point(29, 264);
            this.namaSiswaInputNilai.Name = "namaSiswaInputNilai";
            this.namaSiswaInputNilai.Size = new System.Drawing.Size(103, 23);
            this.namaSiswaInputNilai.TabIndex = 5;
            this.namaSiswaInputNilai.Text = "Nama Siswa";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.Salmon;
            this.txtNoSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.Location = new System.Drawing.Point(29, 225);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(242, 27);
            this.txtNoSiswa.TabIndex = 4;
            // 
            // noSiswaInputNilai
            // 
            this.noSiswaInputNilai.AutoSize = true;
            this.noSiswaInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noSiswaInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.noSiswaInputNilai.Location = new System.Drawing.Point(29, 197);
            this.noSiswaInputNilai.Name = "noSiswaInputNilai";
            this.noSiswaInputNilai.Size = new System.Drawing.Size(80, 23);
            this.noSiswaInputNilai.TabIndex = 3;
            this.noSiswaInputNilai.Text = "No Siswa";
            // 
            // txtKodeUjian
            // 
            this.txtKodeUjian.BackColor = System.Drawing.Color.Salmon;
            this.txtKodeUjian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeUjian.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtKodeUjian.Location = new System.Drawing.Point(29, 157);
            this.txtKodeUjian.Name = "txtKodeUjian";
            this.txtKodeUjian.Size = new System.Drawing.Size(243, 23);
            this.txtKodeUjian.TabIndex = 2;
            // 
            // kodeUjianInputNilai
            // 
            this.kodeUjianInputNilai.AutoSize = true;
            this.kodeUjianInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodeUjianInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kodeUjianInputNilai.Location = new System.Drawing.Point(29, 129);
            this.kodeUjianInputNilai.Name = "kodeUjianInputNilai";
            this.kodeUjianInputNilai.Size = new System.Drawing.Size(93, 23);
            this.kodeUjianInputNilai.TabIndex = 1;
            this.kodeUjianInputNilai.Text = "Kode Ujian";
            // 
            // inputNilai
            // 
            this.inputNilai.AutoSize = true;
            this.inputNilai.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputNilai.Location = new System.Drawing.Point(518, 85);
            this.inputNilai.Name = "inputNilai";
            this.inputNilai.Size = new System.Drawing.Size(90, 37);
            this.inputNilai.TabIndex = 0;
            this.inputNilai.Text = "NILAI";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(1022, 311);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 31);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(1022, 260);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 31);
            this.btnTambah.TabIndex = 26;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(1022, 208);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 31);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(1022, 157);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 31);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Salmon;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1000, 47);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 40);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // kodeujian
            // 
            this.kodeujian.DataPropertyName = "kodeujian";
            this.kodeujian.HeaderText = "Kode Ujian";
            this.kodeujian.MinimumWidth = 6;
            this.kodeujian.Name = "kodeujian";
            this.kodeujian.ReadOnly = true;
            this.kodeujian.Width = 125;
            // 
            // nosiswa
            // 
            this.nosiswa.DataPropertyName = "nosiswa";
            this.nosiswa.HeaderText = "Nomer Siswa";
            this.nosiswa.MinimumWidth = 6;
            this.nosiswa.Name = "nosiswa";
            this.nosiswa.ReadOnly = true;
            this.nosiswa.Width = 125;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "namasiswa";
            this.nama.HeaderText = "Nama Siswa";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 125;
            // 
            // namapengajar
            // 
            this.namapengajar.DataPropertyName = "namapengajar";
            this.namapengajar.HeaderText = "Nama Pengajar";
            this.namapengajar.MinimumWidth = 6;
            this.namapengajar.Name = "namapengajar";
            this.namapengajar.ReadOnly = true;
            this.namapengajar.Width = 125;
            // 
            // namapelajaran
            // 
            this.namapelajaran.DataPropertyName = "namapelajaran";
            this.namapelajaran.HeaderText = "Nama Pelajaran";
            this.namapelajaran.MinimumWidth = 6;
            this.namapelajaran.Name = "namapelajaran";
            this.namapelajaran.ReadOnly = true;
            this.namapelajaran.Width = 125;
            // 
            // nilai
            // 
            this.nilai.DataPropertyName = "nilai";
            this.nilai.HeaderText = "Nilai";
            this.nilai.MinimumWidth = 6;
            this.nilai.Name = "nilai";
            this.nilai.ReadOnly = true;
            this.nilai.Width = 125;
            // 
            // FormInputNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKodeUjian);
            this.Controls.Add(this.txtKodePelajaran);
            this.Controls.Add(this.inputNilai);
            this.Controls.Add(this.nilaiInputNilai);
            this.Controls.Add(this.kodeUjianInputNilai);
            this.Controls.Add(this.kodePelajaranInputNilai);
            this.Controls.Add(this.noSiswaInputNilai);
            this.Controls.Add(this.txtNoPengajar);
            this.Controls.Add(this.txtNoSiswa);
            this.Controls.Add(this.txtNamaSiswa);
            this.Controls.Add(this.namaSiswaInputNilai);
            this.Controls.Add(this.noPengajarInputNilai);
            this.Controls.Add(this.pnlRuangZoom);
            this.Controls.Add(this.pctrInputNilai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputNilai";
            this.Load += new System.EventHandler(this.FormInputNilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrInputNilai)).EndInit();
            this.pnlRuangZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrInputNilai;
        private System.Windows.Forms.Panel pnlRuangZoom;
        private System.Windows.Forms.TextBox txtNoPengajar;
        private System.Windows.Forms.TextBox txtNamaSiswa;
        private System.Windows.Forms.Label noPengajarInputNilai;
        private System.Windows.Forms.Label namaSiswaInputNilai;
        private System.Windows.Forms.TextBox txtNoSiswa;
        private System.Windows.Forms.Label noSiswaInputNilai;
        private System.Windows.Forms.TextBox txtKodeUjian;
        private System.Windows.Forms.Label kodeUjianInputNilai;
        private System.Windows.Forms.Label inputNilai;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.TextBox txtKodePelajaran;
        private System.Windows.Forms.Label nilaiInputNilai;
        private System.Windows.Forms.Label kodePelajaranInputNilai;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvNilai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeujian;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
    }
}