
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
            this.pnlMenuSiswa = new System.Windows.Forms.Panel();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAkademik = new System.Windows.Forms.Button();
            this.btnJadwalSiswa = new System.Windows.Forms.Button();
            this.btnPengajar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuPegawai = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnSiswa = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnMataPelajaran = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPresensiPgw = new System.Windows.Forms.Button();
            this.btnNilaiPgw = new System.Windows.Forms.Button();
            this.btnKelas = new System.Windows.Forms.Button();
            this.btnUjian = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPegaawai = new System.Windows.Forms.Button();
            this.btnJadwalPengajar = new System.Windows.Forms.Button();
            this.btnJadwalMenuSiswaPgw = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenuSiswa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenuPegawai.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-40, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1038, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlMenuSiswa
            // 
            this.pnlMenuSiswa.BackColor = System.Drawing.Color.White;
            this.pnlMenuSiswa.Controls.Add(this.lblGreetings);
            this.pnlMenuSiswa.Controls.Add(this.panel2);
            this.pnlMenuSiswa.Controls.Add(this.panel1);
            this.pnlMenuSiswa.Controls.Add(this.btnLogOut);
            this.pnlMenuSiswa.Controls.Add(this.pictureBox2);
            this.pnlMenuSiswa.Location = new System.Drawing.Point(116, 105);
            this.pnlMenuSiswa.Name = "pnlMenuSiswa";
            this.pnlMenuSiswa.Size = new System.Drawing.Size(339, 488);
            this.pnlMenuSiswa.TabIndex = 3;
            this.pnlMenuSiswa.Visible = false;
            this.pnlMenuSiswa.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.White;
            this.lblGreetings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreetings.Location = new System.Drawing.Point(63, 146);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(194, 23);
            this.lblGreetings.TabIndex = 5;
            this.lblGreetings.Text = "Selamat datang, Admin!";
            this.lblGreetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAkademik);
            this.panel2.Controls.Add(this.btnJadwalSiswa);
            this.panel2.Controls.Add(this.btnPengajar);
            this.panel2.Location = new System.Drawing.Point(66, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 242);
            this.panel2.TabIndex = 4;
            // 
            // btnAkademik
            // 
            this.btnAkademik.BackColor = System.Drawing.Color.Gold;
            this.btnAkademik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkademik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAkademik.ForeColor = System.Drawing.Color.White;
            this.btnAkademik.Location = new System.Drawing.Point(9, 17);
            this.btnAkademik.Name = "btnAkademik";
            this.btnAkademik.Size = new System.Drawing.Size(180, 50);
            this.btnAkademik.TabIndex = 1;
            this.btnAkademik.Text = "Akademik";
            this.btnAkademik.UseVisualStyleBackColor = false;
            this.btnAkademik.Click += new System.EventHandler(this.btnAkademik_Click);
            // 
            // btnJadwalSiswa
            // 
            this.btnJadwalSiswa.BackColor = System.Drawing.Color.Turquoise;
            this.btnJadwalSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwalSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJadwalSiswa.ForeColor = System.Drawing.Color.White;
            this.btnJadwalSiswa.Location = new System.Drawing.Point(9, 83);
            this.btnJadwalSiswa.Name = "btnJadwalSiswa";
            this.btnJadwalSiswa.Size = new System.Drawing.Size(180, 50);
            this.btnJadwalSiswa.TabIndex = 0;
            this.btnJadwalSiswa.Text = "Jadwalmu!";
            this.btnJadwalSiswa.UseVisualStyleBackColor = false;
            this.btnJadwalSiswa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPengajar
            // 
            this.btnPengajar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPengajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPengajar.ForeColor = System.Drawing.Color.White;
            this.btnPengajar.Location = new System.Drawing.Point(9, 149);
            this.btnPengajar.Name = "btnPengajar";
            this.btnPengajar.Size = new System.Drawing.Size(180, 50);
            this.btnPengajar.TabIndex = 2;
            this.btnPengajar.Text = "Pengajar";
            this.btnPengajar.UseVisualStyleBackColor = false;
            this.btnPengajar.Click += new System.EventHandler(this.btnPengajar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(66, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 10);
            this.panel1.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(118, 440);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(461, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // pnlMenuPegawai
            // 
            this.pnlMenuPegawai.BackColor = System.Drawing.Color.White;
            this.pnlMenuPegawai.Controls.Add(this.panel8);
            this.pnlMenuPegawai.Controls.Add(this.panel7);
            this.pnlMenuPegawai.Controls.Add(this.panel3);
            this.pnlMenuPegawai.Controls.Add(this.label2);
            this.pnlMenuPegawai.Controls.Add(this.panel4);
            this.pnlMenuPegawai.Controls.Add(this.panel5);
            this.pnlMenuPegawai.Controls.Add(this.button4);
            this.pnlMenuPegawai.Controls.Add(this.pictureBox3);
            this.pnlMenuPegawai.Location = new System.Drawing.Point(115, 105);
            this.pnlMenuPegawai.Name = "pnlMenuPegawai";
            this.pnlMenuPegawai.Size = new System.Drawing.Size(722, 488);
            this.pnlMenuPegawai.TabIndex = 6;
            this.pnlMenuPegawai.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Firebrick;
            this.panel8.Location = new System.Drawing.Point(655, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 300);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnZoom);
            this.panel7.Controls.Add(this.btnSiswa);
            this.panel7.Controls.Add(this.btnTransaksi);
            this.panel7.Controls.Add(this.btnMataPelajaran);
            this.panel7.Location = new System.Drawing.Point(443, 146);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 301);
            this.panel7.TabIndex = 6;
            // 
            // btnZoom
            // 
            this.btnZoom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.Location = new System.Drawing.Point(9, 215);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(180, 50);
            this.btnZoom.TabIndex = 5;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnSiswa
            // 
            this.btnSiswa.BackColor = System.Drawing.Color.Gold;
            this.btnSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiswa.ForeColor = System.Drawing.Color.White;
            this.btnSiswa.Location = new System.Drawing.Point(9, 17);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new System.Drawing.Size(180, 50);
            this.btnSiswa.TabIndex = 1;
            this.btnSiswa.Text = "Siswa";
            this.btnSiswa.UseVisualStyleBackColor = false;
            this.btnSiswa.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.Color.Turquoise;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Location = new System.Drawing.Point(9, 83);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(180, 50);
            this.btnTransaksi.TabIndex = 0;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnMataPelajaran
            // 
            this.btnMataPelajaran.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMataPelajaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMataPelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMataPelajaran.ForeColor = System.Drawing.Color.White;
            this.btnMataPelajaran.Location = new System.Drawing.Point(9, 149);
            this.btnMataPelajaran.Name = "btnMataPelajaran";
            this.btnMataPelajaran.Size = new System.Drawing.Size(180, 50);
            this.btnMataPelajaran.TabIndex = 2;
            this.btnMataPelajaran.Text = "Mata Pelajaran";
            this.btnMataPelajaran.UseVisualStyleBackColor = false;
            this.btnMataPelajaran.Click += new System.EventHandler(this.btnMataPelajaran_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPresensiPgw);
            this.panel3.Controls.Add(this.btnNilaiPgw);
            this.panel3.Controls.Add(this.btnKelas);
            this.panel3.Controls.Add(this.btnUjian);
            this.panel3.Location = new System.Drawing.Point(243, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 301);
            this.panel3.TabIndex = 5;
            // 
            // btnPresensiPgw
            // 
            this.btnPresensiPgw.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPresensiPgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresensiPgw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPresensiPgw.ForeColor = System.Drawing.Color.White;
            this.btnPresensiPgw.Location = new System.Drawing.Point(9, 215);
            this.btnPresensiPgw.Name = "btnPresensiPgw";
            this.btnPresensiPgw.Size = new System.Drawing.Size(180, 50);
            this.btnPresensiPgw.TabIndex = 4;
            this.btnPresensiPgw.Text = "Presensi";
            this.btnPresensiPgw.UseVisualStyleBackColor = false;
            this.btnPresensiPgw.Click += new System.EventHandler(this.btnPresensiPgw_Click);
            // 
            // btnNilaiPgw
            // 
            this.btnNilaiPgw.BackColor = System.Drawing.Color.Gold;
            this.btnNilaiPgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNilaiPgw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNilaiPgw.ForeColor = System.Drawing.Color.White;
            this.btnNilaiPgw.Location = new System.Drawing.Point(9, 17);
            this.btnNilaiPgw.Name = "btnNilaiPgw";
            this.btnNilaiPgw.Size = new System.Drawing.Size(180, 50);
            this.btnNilaiPgw.TabIndex = 1;
            this.btnNilaiPgw.Text = "Nilai";
            this.btnNilaiPgw.UseVisualStyleBackColor = false;
            this.btnNilaiPgw.Click += new System.EventHandler(this.btnNilaiPgw_Click);
            // 
            // btnKelas
            // 
            this.btnKelas.BackColor = System.Drawing.Color.Turquoise;
            this.btnKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKelas.ForeColor = System.Drawing.Color.White;
            this.btnKelas.Location = new System.Drawing.Point(9, 83);
            this.btnKelas.Name = "btnKelas";
            this.btnKelas.Size = new System.Drawing.Size(180, 50);
            this.btnKelas.TabIndex = 0;
            this.btnKelas.Text = "Kelas";
            this.btnKelas.UseVisualStyleBackColor = false;
            this.btnKelas.Click += new System.EventHandler(this.btnKelas_Click);
            // 
            // btnUjian
            // 
            this.btnUjian.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUjian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUjian.ForeColor = System.Drawing.Color.White;
            this.btnUjian.Location = new System.Drawing.Point(9, 149);
            this.btnUjian.Name = "btnUjian";
            this.btnUjian.Size = new System.Drawing.Size(180, 50);
            this.btnUjian.TabIndex = 2;
            this.btnUjian.Text = "Ujian";
            this.btnUjian.UseVisualStyleBackColor = false;
            this.btnUjian.Click += new System.EventHandler(this.btnUjian_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selamat datang, Admin!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPegaawai);
            this.panel4.Controls.Add(this.btnJadwalPengajar);
            this.panel4.Controls.Add(this.btnJadwalMenuSiswaPgw);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(43, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 301);
            this.panel4.TabIndex = 4;
            // 
            // btnPegaawai
            // 
            this.btnPegaawai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPegaawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegaawai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPegaawai.ForeColor = System.Drawing.Color.White;
            this.btnPegaawai.Location = new System.Drawing.Point(9, 215);
            this.btnPegaawai.Name = "btnPegaawai";
            this.btnPegaawai.Size = new System.Drawing.Size(180, 50);
            this.btnPegaawai.TabIndex = 3;
            this.btnPegaawai.Text = "Pegawai";
            this.btnPegaawai.UseVisualStyleBackColor = false;
            this.btnPegaawai.Click += new System.EventHandler(this.btnPegaawai_Click);
            // 
            // btnJadwalPengajar
            // 
            this.btnJadwalPengajar.BackColor = System.Drawing.Color.Gold;
            this.btnJadwalPengajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwalPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJadwalPengajar.ForeColor = System.Drawing.Color.White;
            this.btnJadwalPengajar.Location = new System.Drawing.Point(9, 17);
            this.btnJadwalPengajar.Name = "btnJadwalPengajar";
            this.btnJadwalPengajar.Size = new System.Drawing.Size(180, 50);
            this.btnJadwalPengajar.TabIndex = 1;
            this.btnJadwalPengajar.Text = "Jadwal Pengajar";
            this.btnJadwalPengajar.UseVisualStyleBackColor = false;
            this.btnJadwalPengajar.Click += new System.EventHandler(this.btnJadwalPengajar_Click);
            // 
            // btnJadwalMenuSiswaPgw
            // 
            this.btnJadwalMenuSiswaPgw.BackColor = System.Drawing.Color.Turquoise;
            this.btnJadwalMenuSiswaPgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwalMenuSiswaPgw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJadwalMenuSiswaPgw.ForeColor = System.Drawing.Color.White;
            this.btnJadwalMenuSiswaPgw.Location = new System.Drawing.Point(9, 83);
            this.btnJadwalMenuSiswaPgw.Name = "btnJadwalMenuSiswaPgw";
            this.btnJadwalMenuSiswaPgw.Size = new System.Drawing.Size(180, 50);
            this.btnJadwalMenuSiswaPgw.TabIndex = 0;
            this.btnJadwalMenuSiswaPgw.Text = "Jadwal Siswa";
            this.btnJadwalMenuSiswaPgw.UseVisualStyleBackColor = false;
            this.btnJadwalMenuSiswaPgw.Click += new System.EventHandler(this.btnJadwalMenuSiswaPgw_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(9, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pengajar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Location = new System.Drawing.Point(362, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 10);
            this.panel5.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(43, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(464, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Location = new System.Drawing.Point(195, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 276);
            this.panel6.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(9, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 50);
            this.button8.TabIndex = 1;
            this.button8.Text = "Akademik";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Turquoise;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(9, 83);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 50);
            this.button9.TabIndex = 0;
            this.button9.Text = "Jadwalmu!";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SandyBrown;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(9, 149);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(180, 50);
            this.button10.TabIndex = 2;
            this.button10.Text = "Pengajar";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 665);
            this.Controls.Add(this.pnlMenuPegawai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMenuSiswa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenuSiswa.ResumeLayout(false);
            this.pnlMenuSiswa.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenuPegawai.ResumeLayout(false);
            this.pnlMenuPegawai.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenuSiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durasi;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPengajar;
        private System.Windows.Forms.Button btnAkademik;
        private System.Windows.Forms.Button btnJadwalSiswa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenuPegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnMataPelajaran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPresensiPgw;
        private System.Windows.Forms.Button btnNilaiPgw;
        private System.Windows.Forms.Button btnKelas;
        private System.Windows.Forms.Button btnUjian;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPegaawai;
        private System.Windows.Forms.Button btnJadwalPengajar;
        private System.Windows.Forms.Button btnJadwalMenuSiswaPgw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}