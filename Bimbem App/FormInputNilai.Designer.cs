
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
            this.pctrInputNilai = new System.Windows.Forms.PictureBox();
            this.pnlRuangZoom = new System.Windows.Forms.Panel();
            this.dgvNilai = new System.Windows.Forms.DataGridView();
            this.kodeujian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodepelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pctrInputNilai)).BeginInit();
            this.pnlRuangZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrInputNilai
            // 
            this.pctrInputNilai.Image = global::Bimbem_App.Properties.Resources.bimbel_ayy;
            this.pctrInputNilai.InitialImage = null;
            this.pctrInputNilai.Location = new System.Drawing.Point(0, 2);
            this.pctrInputNilai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctrInputNilai.Name = "pctrInputNilai";
            this.pctrInputNilai.Size = new System.Drawing.Size(978, 665);
            this.pctrInputNilai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrInputNilai.TabIndex = 0;
            this.pctrInputNilai.TabStop = false;
            this.pctrInputNilai.Click += new System.EventHandler(this.pctrInputNilai_Click);
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlRuangZoom.Controls.Add(this.dgvNilai);
            this.pnlRuangZoom.Location = new System.Drawing.Point(24, 307);
            this.pnlRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(832, 336);
            this.pnlRuangZoom.TabIndex = 3;
            // 
            // dgvNilai
            // 
            this.dgvNilai.AllowUserToAddRows = false;
            this.dgvNilai.AllowUserToDeleteRows = false;
            this.dgvNilai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeujian,
            this.nosiswa,
            this.nama,
            this.nopengajar,
            this.kodepelajaran,
            this.nilai});
            this.dgvNilai.Location = new System.Drawing.Point(19, 21);
            this.dgvNilai.Name = "dgvNilai";
            this.dgvNilai.RowTemplate.Height = 25;
            this.dgvNilai.Size = new System.Drawing.Size(792, 294);
            this.dgvNilai.TabIndex = 0;
            // 
            // kodeujian
            // 
            this.kodeujian.HeaderText = "Kode Ujian";
            this.kodeujian.Name = "kodeujian";
            // 
            // nosiswa
            // 
            this.nosiswa.HeaderText = "Nomer Siswa";
            this.nosiswa.Name = "nosiswa";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Siswa";
            this.nama.Name = "nama";
            // 
            // nopengajar
            // 
            this.nopengajar.HeaderText = "Nomer Pengajar";
            this.nopengajar.Name = "nopengajar";
            // 
            // kodepelajaran
            // 
            this.kodepelajaran.HeaderText = "Kode Pelajaran";
            this.kodepelajaran.Name = "kodepelajaran";
            // 
            // nilai
            // 
            this.nilai.HeaderText = "Nilai";
            this.nilai.Name = "nilai";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBatal.Location = new System.Drawing.Point(669, 263);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(72, 39);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSimpan.Location = new System.Drawing.Point(583, 263);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 39);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // txtNilai
            // 
            this.txtNilai.BackColor = System.Drawing.Color.Salmon;
            this.txtNilai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNilai.Location = new System.Drawing.Point(529, 226);
            this.txtNilai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(212, 22);
            this.txtNilai.TabIndex = 8;
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.BackColor = System.Drawing.Color.Salmon;
            this.txtKodePelajaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtKodePelajaran.Location = new System.Drawing.Point(530, 174);
            this.txtKodePelajaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(212, 22);
            this.txtKodePelajaran.TabIndex = 10;
            // 
            // nilaiInputNilai
            // 
            this.nilaiInputNilai.AutoSize = true;
            this.nilaiInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nilaiInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nilaiInputNilai.Location = new System.Drawing.Point(529, 204);
            this.nilaiInputNilai.Name = "nilaiInputNilai";
            this.nilaiInputNilai.Size = new System.Drawing.Size(42, 21);
            this.nilaiInputNilai.TabIndex = 7;
            this.nilaiInputNilai.Text = "Nilai";
            // 
            // kodePelajaranInputNilai
            // 
            this.kodePelajaranInputNilai.AutoSize = true;
            this.kodePelajaranInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodePelajaranInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kodePelajaranInputNilai.Location = new System.Drawing.Point(530, 153);
            this.kodePelajaranInputNilai.Name = "kodePelajaranInputNilai";
            this.kodePelajaranInputNilai.Size = new System.Drawing.Size(117, 21);
            this.kodePelajaranInputNilai.TabIndex = 9;
            this.kodePelajaranInputNilai.Text = "Kode Pelajaran";
            // 
            // txtNoPengajar
            // 
            this.txtNoPengajar.BackColor = System.Drawing.Color.Salmon;
            this.txtNoPengajar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoPengajar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNoPengajar.Location = new System.Drawing.Point(529, 123);
            this.txtNoPengajar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoPengajar.Name = "txtNoPengajar";
            this.txtNoPengajar.Size = new System.Drawing.Size(212, 22);
            this.txtNoPengajar.TabIndex = 4;
            // 
            // txtNamaSiswa
            // 
            this.txtNamaSiswa.BackColor = System.Drawing.Color.Salmon;
            this.txtNamaSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNamaSiswa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNamaSiswa.Location = new System.Drawing.Point(258, 226);
            this.txtNamaSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaSiswa.Name = "txtNamaSiswa";
            this.txtNamaSiswa.Size = new System.Drawing.Size(212, 22);
            this.txtNamaSiswa.TabIndex = 6;
            // 
            // noPengajarInputNilai
            // 
            this.noPengajarInputNilai.AutoSize = true;
            this.noPengajarInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noPengajarInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.noPengajarInputNilai.Location = new System.Drawing.Point(529, 103);
            this.noPengajarInputNilai.Name = "noPengajarInputNilai";
            this.noPengajarInputNilai.Size = new System.Drawing.Size(98, 21);
            this.noPengajarInputNilai.TabIndex = 3;
            this.noPengajarInputNilai.Text = "No Pengajar";
            // 
            // namaSiswaInputNilai
            // 
            this.namaSiswaInputNilai.AutoSize = true;
            this.namaSiswaInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namaSiswaInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.namaSiswaInputNilai.Location = new System.Drawing.Point(258, 203);
            this.namaSiswaInputNilai.Name = "namaSiswaInputNilai";
            this.namaSiswaInputNilai.Size = new System.Drawing.Size(96, 21);
            this.namaSiswaInputNilai.TabIndex = 5;
            this.namaSiswaInputNilai.Text = "Nama Siswa";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.Salmon;
            this.txtNoSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.Location = new System.Drawing.Point(258, 173);
            this.txtNoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(212, 22);
            this.txtNoSiswa.TabIndex = 4;
            // 
            // noSiswaInputNilai
            // 
            this.noSiswaInputNilai.AutoSize = true;
            this.noSiswaInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noSiswaInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.noSiswaInputNilai.Location = new System.Drawing.Point(258, 153);
            this.noSiswaInputNilai.Name = "noSiswaInputNilai";
            this.noSiswaInputNilai.Size = new System.Drawing.Size(76, 21);
            this.noSiswaInputNilai.TabIndex = 3;
            this.noSiswaInputNilai.Text = "No Siswa";
            // 
            // txtKodeUjian
            // 
            this.txtKodeUjian.BackColor = System.Drawing.Color.Salmon;
            this.txtKodeUjian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeUjian.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtKodeUjian.Location = new System.Drawing.Point(258, 123);
            this.txtKodeUjian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeUjian.Name = "txtKodeUjian";
            this.txtKodeUjian.Size = new System.Drawing.Size(213, 22);
            this.txtKodeUjian.TabIndex = 2;
            // 
            // kodeUjianInputNilai
            // 
            this.kodeUjianInputNilai.AutoSize = true;
            this.kodeUjianInputNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kodeUjianInputNilai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kodeUjianInputNilai.Location = new System.Drawing.Point(258, 102);
            this.kodeUjianInputNilai.Name = "kodeUjianInputNilai";
            this.kodeUjianInputNilai.Size = new System.Drawing.Size(89, 21);
            this.kodeUjianInputNilai.TabIndex = 1;
            this.kodeUjianInputNilai.Text = "Kode Ujian";
            // 
            // inputNilai
            // 
            this.inputNilai.AutoSize = true;
            this.inputNilai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputNilai.Location = new System.Drawing.Point(445, 34);
            this.inputNilai.Name = "inputNilai";
            this.inputNilai.Size = new System.Drawing.Size(79, 32);
            this.inputNilai.TabIndex = 0;
            this.inputNilai.Text = "NILAI";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(862, 452);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 42);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(862, 404);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(87, 42);
            this.btnTambah.TabIndex = 26;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(862, 356);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 42);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(862, 308);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(87, 42);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(879, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 42);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // FormInputNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 665);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputNilai";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nopengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
    }
}