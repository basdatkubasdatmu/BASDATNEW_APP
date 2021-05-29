
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRuangZoom = new System.Windows.Forms.Panel();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRuangZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRuangZoom.Controls.Add(this.dgvTransaksi);
            this.pnlRuangZoom.Location = new System.Drawing.Point(93, 239);
            this.pnlRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(705, 302);
            this.pnlRuangZoom.TabIndex = 3;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.keterangan});
            this.dgvTransaksi.Location = new System.Drawing.Point(21, 19);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 51;
            this.dgvTransaksi.RowTemplate.Height = 25;
            this.dgvTransaksi.Size = new System.Drawing.Size(662, 264);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kodePembayaran";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode Pembayaran";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 146;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "noSiswa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nomor Siswa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kodeKelas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kode Kelas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tanggalPembayaran";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanggal Pembayaran";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // keterangan
            // 
            this.keterangan.DataPropertyName = "keterangan";
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.MinimumWidth = 6;
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            this.keterangan.Width = 125;
            // 
            // txtKeteranganBayar
            // 
            this.txtKeteranganBayar.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKeteranganBayar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKeteranganBayar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKeteranganBayar.Location = new System.Drawing.Point(396, 184);
            this.txtKeteranganBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeteranganBayar.Name = "txtKeteranganBayar";
            this.txtKeteranganBayar.Size = new System.Drawing.Size(212, 26);
            this.txtKeteranganBayar.TabIndex = 10;
            this.txtKeteranganBayar.TextChanged += new System.EventHandler(this.txtKeteranganBayar_TextChanged);
            // 
            // ktrPembayaran
            // 
            this.ktrPembayaran.AutoSize = true;
            this.ktrPembayaran.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ktrPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ktrPembayaran.Location = new System.Drawing.Point(396, 161);
            this.ktrPembayaran.Name = "ktrPembayaran";
            this.ktrPembayaran.Size = new System.Drawing.Size(86, 19);
            this.ktrPembayaran.TabIndex = 9;
            this.ktrPembayaran.Text = "Keterangan";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBatal.Location = new System.Drawing.Point(794, 184);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 28);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimpan.Location = new System.Drawing.Point(701, 184);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(88, 28);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtTglPembayaran
            // 
            this.txtTglPembayaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtTglPembayaran.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTglPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTglPembayaran.Location = new System.Drawing.Point(396, 118);
            this.txtTglPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTglPembayaran.Name = "txtTglPembayaran";
            this.txtTglPembayaran.Size = new System.Drawing.Size(212, 26);
            this.txtTglPembayaran.TabIndex = 4;
            // 
            // txtKodeKelas
            // 
            this.txtKodeKelas.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodeKelas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeKelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKodeKelas.Location = new System.Drawing.Point(656, 118);
            this.txtKodeKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeKelas.Name = "txtKodeKelas";
            this.txtKodeKelas.Size = new System.Drawing.Size(212, 26);
            this.txtKodeKelas.TabIndex = 6;
            // 
            // tanggalPembayaran
            // 
            this.tanggalPembayaran.AutoSize = true;
            this.tanggalPembayaran.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tanggalPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tanggalPembayaran.Location = new System.Drawing.Point(396, 96);
            this.tanggalPembayaran.Name = "tanggalPembayaran";
            this.tanggalPembayaran.Size = new System.Drawing.Size(151, 19);
            this.tanggalPembayaran.TabIndex = 3;
            this.tanggalPembayaran.Text = "Tanggal Pembayaran";
            // 
            // kodeKelas
            // 
            this.kodeKelas.AutoSize = true;
            this.kodeKelas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodeKelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kodeKelas.Location = new System.Drawing.Point(656, 95);
            this.kodeKelas.Name = "kodeKelas";
            this.kodeKelas.Size = new System.Drawing.Size(83, 19);
            this.kodeKelas.TabIndex = 5;
            this.kodeKelas.Text = "Kode Kelas";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.DarkOrange;
            this.txtNoSiswa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoSiswa.Location = new System.Drawing.Point(136, 184);
            this.txtNoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(212, 26);
            this.txtNoSiswa.TabIndex = 4;
            // 
            // noSiswa
            // 
            this.noSiswa.AutoSize = true;
            this.noSiswa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noSiswa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noSiswa.Location = new System.Drawing.Point(136, 161);
            this.noSiswa.Name = "noSiswa";
            this.noSiswa.Size = new System.Drawing.Size(70, 19);
            this.noSiswa.TabIndex = 3;
            this.noSiswa.Text = "No Siswa";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtPembayaran.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPembayaran.Location = new System.Drawing.Point(136, 118);
            this.txtPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(212, 26);
            this.txtPembayaran.TabIndex = 2;
            // 
            // kodePembayaran
            // 
            this.kodePembayaran.AutoSize = true;
            this.kodePembayaran.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodePembayaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kodePembayaran.Location = new System.Drawing.Point(136, 96);
            this.kodePembayaran.Name = "kodePembayaran";
            this.kodePembayaran.Size = new System.Drawing.Size(133, 19);
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
            this.btnTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(803, 239);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(93, 33);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(803, 277);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 33);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(803, 314);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(93, 33);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnMenuUtama
            // 
            this.btnMenuUtama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuUtama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuUtama.Location = new System.Drawing.Point(883, 12);
            this.btnMenuUtama.Name = "btnMenuUtama";
            this.btnMenuUtama.Size = new System.Drawing.Size(74, 33);
            this.btnMenuUtama.TabIndex = 72;
            this.btnMenuUtama.Text = "Home";
            this.btnMenuUtama.UseVisualStyleBackColor = false;
            this.btnMenuUtama.Click += new System.EventHandler(this.btnMenuUtama_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(803, 350);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 33);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormInputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 582);
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
            this.Load += new System.EventHandler(this.FormInputTransaksi_Load);
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
        private System.Windows.Forms.Button btnMenuUtama;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
    }
}