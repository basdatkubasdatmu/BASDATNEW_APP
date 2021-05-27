
namespace Bimbem_App
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.jadwalSiswa = new System.Windows.Forms.TabControl();
            this.jadwalKelasSiswa = new System.Windows.Forms.TabPage();
            this.dgvJadwalKelasSiswa = new System.Windows.Forms.DataGridView();
            this.tanggalJadwalKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengajarKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelajaranKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulaiKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurasiKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoomKelasSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalUjianSiswa = new System.Windows.Forms.TabPage();
            this.dgvJadwalUjian = new System.Windows.Forms.DataGridView();
            this.kodeUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalUjianSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulaiUjianSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiUjianSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.jadwalSiswa.SuspendLayout();
            this.jadwalKelasSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalKelasSiswa)).BeginInit();
            this.jadwalUjianSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalUjian)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1038, 696);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 616);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(66, 567);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bimbem_App.Properties.Resources.schedule;
            this.pictureBox3.Location = new System.Drawing.Point(34, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selamat datang,";
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.Transparent;
            this.lblGreetings.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreetings.Location = new System.Drawing.Point(466, 25);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(0, 31);
            this.lblGreetings.TabIndex = 5;
            // 
            // jadwalSiswa
            // 
            this.jadwalSiswa.Controls.Add(this.jadwalKelasSiswa);
            this.jadwalSiswa.Controls.Add(this.jadwalUjianSiswa);
            this.jadwalSiswa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jadwalSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jadwalSiswa.Location = new System.Drawing.Point(285, 86);
            this.jadwalSiswa.Name = "jadwalSiswa";
            this.jadwalSiswa.SelectedIndex = 0;
            this.jadwalSiswa.Size = new System.Drawing.Size(656, 555);
            this.jadwalSiswa.TabIndex = 8;
            this.jadwalSiswa.SelectedIndexChanged += new System.EventHandler(this.jadwalSiswa_SelectedIndexChanged);
            // 
            // jadwalKelasSiswa
            // 
            this.jadwalKelasSiswa.Controls.Add(this.dgvJadwalKelasSiswa);
            this.jadwalKelasSiswa.Location = new System.Drawing.Point(4, 29);
            this.jadwalKelasSiswa.Name = "jadwalKelasSiswa";
            this.jadwalKelasSiswa.Padding = new System.Windows.Forms.Padding(3);
            this.jadwalKelasSiswa.Size = new System.Drawing.Size(648, 522);
            this.jadwalKelasSiswa.TabIndex = 0;
            this.jadwalKelasSiswa.Text = "Jadwal Kelas";
            this.jadwalKelasSiswa.UseVisualStyleBackColor = true;
            this.jadwalKelasSiswa.Click += new System.EventHandler(this.jadwalKelasSiswa_Click);
            // 
            // dgvJadwalKelasSiswa
            // 
            this.dgvJadwalKelasSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalKelasSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanggalJadwalKelasSiswa,
            this.pengajarKelasSiswa,
            this.pelajaranKelasSiswa,
            this.jamMulaiKelasSiswa,
            this.DurasiKelasSiswa,
            this.zoomKelasSiswa});
            this.dgvJadwalKelasSiswa.Location = new System.Drawing.Point(3, 3);
            this.dgvJadwalKelasSiswa.Name = "dgvJadwalKelasSiswa";
            this.dgvJadwalKelasSiswa.RowHeadersWidth = 51;
            this.dgvJadwalKelasSiswa.RowTemplate.Height = 29;
            this.dgvJadwalKelasSiswa.Size = new System.Drawing.Size(642, 516);
            this.dgvJadwalKelasSiswa.TabIndex = 0;
            this.dgvJadwalKelasSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tanggalJadwalKelasSiswa
            // 
            this.tanggalJadwalKelasSiswa.DataPropertyName = "tanggal";
            this.tanggalJadwalKelasSiswa.HeaderText = "Tanggal";
            this.tanggalJadwalKelasSiswa.MinimumWidth = 6;
            this.tanggalJadwalKelasSiswa.Name = "tanggalJadwalKelasSiswa";
            this.tanggalJadwalKelasSiswa.Width = 125;
            // 
            // pengajarKelasSiswa
            // 
            this.pengajarKelasSiswa.DataPropertyName = "pengajar";
            this.pengajarKelasSiswa.HeaderText = "Pengajar";
            this.pengajarKelasSiswa.MinimumWidth = 6;
            this.pengajarKelasSiswa.Name = "pengajarKelasSiswa";
            this.pengajarKelasSiswa.Width = 125;
            // 
            // pelajaranKelasSiswa
            // 
            this.pelajaranKelasSiswa.DataPropertyName = "pelajaran";
            this.pelajaranKelasSiswa.HeaderText = "Pelajaran";
            this.pelajaranKelasSiswa.MinimumWidth = 6;
            this.pelajaranKelasSiswa.Name = "pelajaranKelasSiswa";
            this.pelajaranKelasSiswa.Width = 125;
            // 
            // jamMulaiKelasSiswa
            // 
            this.jamMulaiKelasSiswa.DataPropertyName = "jammulai";
            this.jamMulaiKelasSiswa.HeaderText = "Jam Mulai";
            this.jamMulaiKelasSiswa.MinimumWidth = 6;
            this.jamMulaiKelasSiswa.Name = "jamMulaiKelasSiswa";
            this.jamMulaiKelasSiswa.Width = 125;
            // 
            // DurasiKelasSiswa
            // 
            this.DurasiKelasSiswa.DataPropertyName = "durasi";
            this.DurasiKelasSiswa.HeaderText = "Durasi";
            this.DurasiKelasSiswa.MinimumWidth = 6;
            this.DurasiKelasSiswa.Name = "DurasiKelasSiswa";
            this.DurasiKelasSiswa.Width = 125;
            // 
            // zoomKelasSiswa
            // 
            this.zoomKelasSiswa.DataPropertyName = "zoom";
            this.zoomKelasSiswa.HeaderText = "Link Zoom";
            this.zoomKelasSiswa.MinimumWidth = 6;
            this.zoomKelasSiswa.Name = "zoomKelasSiswa";
            this.zoomKelasSiswa.Width = 125;
            // 
            // jadwalUjianSiswa
            // 
            this.jadwalUjianSiswa.Controls.Add(this.dgvJadwalUjian);
            this.jadwalUjianSiswa.Location = new System.Drawing.Point(4, 29);
            this.jadwalUjianSiswa.Name = "jadwalUjianSiswa";
            this.jadwalUjianSiswa.Padding = new System.Windows.Forms.Padding(3);
            this.jadwalUjianSiswa.Size = new System.Drawing.Size(648, 522);
            this.jadwalUjianSiswa.TabIndex = 1;
            this.jadwalUjianSiswa.Text = "Jadwal Ujian";
            this.jadwalUjianSiswa.UseVisualStyleBackColor = true;
            // 
            // dgvJadwalUjian
            // 
            this.dgvJadwalUjian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalUjian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeUjian,
            this.namaUjian,
            this.kodePelajaran,
            this.tanggalUjianSiswa,
            this.jamMulaiUjianSiswa,
            this.durasiUjianSiswa});
            this.dgvJadwalUjian.Location = new System.Drawing.Point(3, 3);
            this.dgvJadwalUjian.Name = "dgvJadwalUjian";
            this.dgvJadwalUjian.RowHeadersWidth = 51;
            this.dgvJadwalUjian.RowTemplate.Height = 29;
            this.dgvJadwalUjian.Size = new System.Drawing.Size(642, 516);
            this.dgvJadwalUjian.TabIndex = 1;
            // 
            // kodeUjian
            // 
            this.kodeUjian.DataPropertyName = "kodeujian";
            this.kodeUjian.HeaderText = "Kode Ujian";
            this.kodeUjian.MinimumWidth = 6;
            this.kodeUjian.Name = "kodeUjian";
            this.kodeUjian.Width = 125;
            // 
            // namaUjian
            // 
            this.namaUjian.DataPropertyName = "nama";
            this.namaUjian.HeaderText = "Nama Ujian";
            this.namaUjian.MinimumWidth = 6;
            this.namaUjian.Name = "namaUjian";
            this.namaUjian.Width = 125;
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodepelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.MinimumWidth = 6;
            this.kodePelajaran.Name = "kodePelajaran";
            this.kodePelajaran.Width = 125;
            // 
            // tanggalUjianSiswa
            // 
            this.tanggalUjianSiswa.DataPropertyName = "tanggal";
            this.tanggalUjianSiswa.HeaderText = "Tanggal";
            this.tanggalUjianSiswa.MinimumWidth = 6;
            this.tanggalUjianSiswa.Name = "tanggalUjianSiswa";
            this.tanggalUjianSiswa.Width = 125;
            // 
            // jamMulaiUjianSiswa
            // 
            this.jamMulaiUjianSiswa.DataPropertyName = "jammulai";
            this.jamMulaiUjianSiswa.HeaderText = "Jam Mulai";
            this.jamMulaiUjianSiswa.MinimumWidth = 6;
            this.jamMulaiUjianSiswa.Name = "jamMulaiUjianSiswa";
            this.jamMulaiUjianSiswa.Width = 125;
            // 
            // durasiUjianSiswa
            // 
            this.durasiUjianSiswa.DataPropertyName = "durasi";
            this.durasiUjianSiswa.HeaderText = "Durasi";
            this.durasiUjianSiswa.MinimumWidth = 6;
            this.durasiUjianSiswa.Name = "durasiUjianSiswa";
            this.durasiUjianSiswa.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // Pengajar
            // 
            this.Pengajar.HeaderText = "pengajar";
            this.Pengajar.MinimumWidth = 6;
            this.Pengajar.Name = "Pengajar";
            this.Pengajar.Width = 125;
            // 
            // Pelajaran
            // 
            this.Pelajaran.HeaderText = "pelajaran";
            this.Pelajaran.MinimumWidth = 6;
            this.Pelajaran.Name = "Pelajaran";
            this.Pelajaran.Width = 125;
            // 
            // jamMulai
            // 
            this.jamMulai.HeaderText = "JamMulai";
            this.jamMulai.MinimumWidth = 6;
            this.jamMulai.Name = "jamMulai";
            this.jamMulai.Width = 125;
            // 
            // Durasi
            // 
            this.Durasi.HeaderText = "durasi";
            this.Durasi.MinimumWidth = 6;
            this.Durasi.Name = "Durasi";
            this.Durasi.Width = 125;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 666);
            this.Controls.Add(this.jadwalSiswa);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.jadwalSiswa.ResumeLayout(false);
            this.jadwalKelasSiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalKelasSiswa)).EndInit();
            this.jadwalUjianSiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalUjian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl jadwalSiswa;
        private System.Windows.Forms.TabPage jadwalKelasSiswa;
        private System.Windows.Forms.DataGridView dgvJadwalKelasSiswa;
        private System.Windows.Forms.TabPage jadwalUjianSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalJadwalKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengajarKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelajaranKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulaiKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurasiKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoomKelasSiswa;
        private System.Windows.Forms.DataGridView dgvJadwalUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalUjianSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulaiUjianSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiUjianSiswa;
        private System.Windows.Forms.Button btnLogOut;
    }
}