
namespace Bimbem_App
{
    partial class FormInputUjian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUjian = new System.Windows.Forms.DataGridView();
            this.kodeUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtJam = new System.Windows.Forms.MaskedTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurasi = new System.Windows.Forms.MaskedTextBox();
            this.txtKodePelajaran = new System.Windows.Forms.TextBox();
            this.txtNamaUjian = new System.Windows.Forms.TextBox();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblJamMulai = new System.Windows.Forms.Label();
            this.lblTanggalUjian = new System.Windows.Forms.Label();
            this.lblKodePelajaran = new System.Windows.Forms.Label();
            this.lblNamaUjian = new System.Windows.Forms.Label();
            this.lblKodeUjian = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.MaskedTextBox();
            this.txtKodeUjian = new System.Windows.Forms.TextBox();
            this.lblInputJadwalUjian = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnMenuUtama = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjian)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(993, 667);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvUjian);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(284, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 299);
            this.panel1.TabIndex = 54;
            // 
            // dgvUjian
            // 
            this.dgvUjian.AllowUserToAddRows = false;
            this.dgvUjian.AllowUserToDeleteRows = false;
            this.dgvUjian.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgvUjian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUjian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUjian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUjian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeUjian,
            this.namaUjian,
            this.kodePelajaran,
            this.tanggalUjian,
            this.jamMulai,
            this.durasi});
            this.dgvUjian.Location = new System.Drawing.Point(15, 14);
            this.dgvUjian.Name = "dgvUjian";
            this.dgvUjian.ReadOnly = true;
            this.dgvUjian.RowHeadersWidth = 51;
            this.dgvUjian.RowTemplate.Height = 25;
            this.dgvUjian.Size = new System.Drawing.Size(554, 268);
            this.dgvUjian.TabIndex = 1;
            // 
            // kodeUjian
            // 
            this.kodeUjian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeUjian.DataPropertyName = "kodeUjian";
            this.kodeUjian.HeaderText = "Kode Ujian";
            this.kodeUjian.MinimumWidth = 6;
            this.kodeUjian.Name = "kodeUjian";
            this.kodeUjian.ReadOnly = true;
            // 
            // namaUjian
            // 
            this.namaUjian.DataPropertyName = "namaUjian";
            this.namaUjian.HeaderText = "Nama Ujian";
            this.namaUjian.MinimumWidth = 6;
            this.namaUjian.Name = "namaUjian";
            this.namaUjian.ReadOnly = true;
            this.namaUjian.Width = 125;
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodePelajaran.DataPropertyName = "kodePelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.MinimumWidth = 6;
            this.kodePelajaran.Name = "kodePelajaran";
            this.kodePelajaran.ReadOnly = true;
            this.kodePelajaran.Width = 123;
            // 
            // tanggalUjian
            // 
            this.tanggalUjian.DataPropertyName = "tanggalUjian";
            this.tanggalUjian.HeaderText = "Tanggal Ujian";
            this.tanggalUjian.MinimumWidth = 6;
            this.tanggalUjian.Name = "tanggalUjian";
            this.tanggalUjian.ReadOnly = true;
            this.tanggalUjian.Width = 125;
            // 
            // jamMulai
            // 
            this.jamMulai.DataPropertyName = "jamMulai";
            this.jamMulai.HeaderText = "Jam Mulai";
            this.jamMulai.MinimumWidth = 6;
            this.jamMulai.Name = "jamMulai";
            this.jamMulai.ReadOnly = true;
            this.jamMulai.Width = 125;
            // 
            // durasi
            // 
            this.durasi.DataPropertyName = "durasi";
            this.durasi.HeaderText = "Durasi";
            this.durasi.MinimumWidth = 6;
            this.durasi.Name = "durasi";
            this.durasi.ReadOnly = true;
            this.durasi.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(332, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 0;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Control;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(192, 433);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 23);
            this.btnBatal.TabIndex = 56;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtJam
            // 
            this.txtJam.BackColor = System.Drawing.Color.DarkOrange;
            this.txtJam.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJam.Location = new System.Drawing.Point(41, 328);
            this.txtJam.Mask = "90:00";
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(224, 25);
            this.txtJam.TabIndex = 67;
            this.txtJam.ValidatingType = typeof(System.DateTime);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(103, 433);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(73, 23);
            this.btnSimpan.TabIndex = 55;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(187, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "menit";
            // 
            // txtDurasi
            // 
            this.txtDurasi.BackColor = System.Drawing.Color.DarkOrange;
            this.txtDurasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDurasi.Location = new System.Drawing.Point(41, 389);
            this.txtDurasi.Mask = "00000";
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(140, 25);
            this.txtDurasi.TabIndex = 65;
            this.txtDurasi.ValidatingType = typeof(int);
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.Location = new System.Drawing.Point(41, 218);
            this.txtKodePelajaran.MaxLength = 5;
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(224, 25);
            this.txtKodePelajaran.TabIndex = 64;
            // 
            // txtNamaUjian
            // 
            this.txtNamaUjian.BackColor = System.Drawing.Color.DarkOrange;
            this.txtNamaUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNamaUjian.Location = new System.Drawing.Point(41, 163);
            this.txtNamaUjian.MaxLength = 10;
            this.txtNamaUjian.Name = "txtNamaUjian";
            this.txtNamaUjian.Size = new System.Drawing.Size(224, 25);
            this.txtNamaUjian.TabIndex = 63;
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDurasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDurasi.Location = new System.Drawing.Point(41, 363);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(49, 19);
            this.lblDurasi.TabIndex = 62;
            this.lblDurasi.Text = "Durasi";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblJamMulai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJamMulai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJamMulai.Location = new System.Drawing.Point(41, 304);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(74, 19);
            this.lblJamMulai.TabIndex = 61;
            this.lblJamMulai.Text = "Jam Mulai";
            // 
            // lblTanggalUjian
            // 
            this.lblTanggalUjian.AutoSize = true;
            this.lblTanggalUjian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTanggalUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTanggalUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTanggalUjian.Location = new System.Drawing.Point(41, 250);
            this.lblTanggalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalUjian.Name = "lblTanggalUjian";
            this.lblTanggalUjian.Size = new System.Drawing.Size(95, 19);
            this.lblTanggalUjian.TabIndex = 60;
            this.lblTanggalUjian.Text = "Tanggal Ujian";
            // 
            // lblKodePelajaran
            // 
            this.lblKodePelajaran.AutoSize = true;
            this.lblKodePelajaran.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKodePelajaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKodePelajaran.Location = new System.Drawing.Point(42, 196);
            this.lblKodePelajaran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodePelajaran.Name = "lblKodePelajaran";
            this.lblKodePelajaran.Size = new System.Drawing.Size(102, 19);
            this.lblKodePelajaran.TabIndex = 59;
            this.lblKodePelajaran.Text = "Kode Pelajaran";
            // 
            // lblNamaUjian
            // 
            this.lblNamaUjian.AutoSize = true;
            this.lblNamaUjian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNamaUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNamaUjian.Location = new System.Drawing.Point(42, 139);
            this.lblNamaUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaUjian.Name = "lblNamaUjian";
            this.lblNamaUjian.Size = new System.Drawing.Size(83, 19);
            this.lblNamaUjian.TabIndex = 58;
            this.lblNamaUjian.Text = "Nama Ujian";
            // 
            // lblKodeUjian
            // 
            this.lblKodeUjian.AutoSize = true;
            this.lblKodeUjian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKodeUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKodeUjian.Location = new System.Drawing.Point(42, 85);
            this.lblKodeUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodeUjian.Name = "lblKodeUjian";
            this.lblKodeUjian.Size = new System.Drawing.Size(78, 19);
            this.lblKodeUjian.TabIndex = 57;
            this.lblKodeUjian.Text = "Kode Ujian";
            // 
            // txtTanggal
            // 
            this.txtTanggal.BackColor = System.Drawing.Color.DarkOrange;
            this.txtTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTanggal.Location = new System.Drawing.Point(41, 273);
            this.txtTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTanggal.Mask = "00/00/0000";
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(224, 25);
            this.txtTanggal.TabIndex = 56;
            this.txtTanggal.ValidatingType = typeof(System.DateTime);
            // 
            // txtKodeUjian
            // 
            this.txtKodeUjian.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeUjian.Location = new System.Drawing.Point(42, 108);
            this.txtKodeUjian.Margin = new System.Windows.Forms.Padding(4);
            this.txtKodeUjian.MaxLength = 5;
            this.txtKodeUjian.Name = "txtKodeUjian";
            this.txtKodeUjian.Size = new System.Drawing.Size(224, 25);
            this.txtKodeUjian.TabIndex = 55;
            // 
            // lblInputJadwalUjian
            // 
            this.lblInputJadwalUjian.AutoSize = true;
            this.lblInputJadwalUjian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInputJadwalUjian.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputJadwalUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInputJadwalUjian.Location = new System.Drawing.Point(402, 53);
            this.lblInputJadwalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputJadwalUjian.Name = "lblInputJadwalUjian";
            this.lblInputJadwalUjian.Size = new System.Drawing.Size(171, 30);
            this.lblInputJadwalUjian.TabIndex = 54;
            this.lblInputJadwalUjian.Text = "JADWAL UJIAN";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(878, 105);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(74, 23);
            this.btnTambah.TabIndex = 68;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(878, 142);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 23);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(878, 179);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 23);
            this.btnHapus.TabIndex = 70;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnMenuUtama
            // 
            this.btnMenuUtama.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMenuUtama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUtama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuUtama.Location = new System.Drawing.Point(886, 12);
            this.btnMenuUtama.Name = "btnMenuUtama";
            this.btnMenuUtama.Size = new System.Drawing.Size(74, 33);
            this.btnMenuUtama.TabIndex = 71;
            this.btnMenuUtama.Text = "HOME";
            this.btnMenuUtama.UseVisualStyleBackColor = false;
            this.btnMenuUtama.Click += new System.EventHandler(this.btnMenuUtama_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(878, 216);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormInputUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 496);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMenuUtama);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtJam);
            this.Controls.Add(this.lblInputJadwalUjian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeUjian);
            this.Controls.Add(this.txtDurasi);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.txtKodePelajaran);
            this.Controls.Add(this.lblKodeUjian);
            this.Controls.Add(this.txtNamaUjian);
            this.Controls.Add(this.lblNamaUjian);
            this.Controls.Add(this.lblKodePelajaran);
            this.Controls.Add(this.lblJamMulai);
            this.Controls.Add(this.lblTanggalUjian);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputUjian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputUjian";
            this.Load += new System.EventHandler(this.FormInputUjian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtJam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDurasi;
        private System.Windows.Forms.TextBox txtKodePelajaran;
        private System.Windows.Forms.TextBox txtNamaUjian;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Label lblJamMulai;
        private System.Windows.Forms.Label lblTanggalUjian;
        private System.Windows.Forms.Label lblKodePelajaran;
        private System.Windows.Forms.Label lblNamaUjian;
        private System.Windows.Forms.Label lblKodeUjian;
        private System.Windows.Forms.MaskedTextBox txtTanggal;
        private System.Windows.Forms.TextBox txtKodeUjian;
        private System.Windows.Forms.Label lblInputJadwalUjian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvUjian;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnMenuUtama;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasi;
    }
}