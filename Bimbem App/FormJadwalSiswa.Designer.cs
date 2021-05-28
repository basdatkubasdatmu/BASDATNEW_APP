
namespace Bimbem_App
{
    partial class FormJadwalSiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lblDataSiswa = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // jadwalSiswa
            // 
            this.jadwalSiswa.Controls.Add(this.jadwalKelasSiswa);
            this.jadwalSiswa.Controls.Add(this.jadwalUjianSiswa);
            this.jadwalSiswa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jadwalSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jadwalSiswa.Location = new System.Drawing.Point(101, 222);
            this.jadwalSiswa.Name = "jadwalSiswa";
            this.jadwalSiswa.SelectedIndex = 0;
            this.jadwalSiswa.Size = new System.Drawing.Size(815, 337);
            this.jadwalSiswa.TabIndex = 9;
            // 
            // jadwalKelasSiswa
            // 
            this.jadwalKelasSiswa.Controls.Add(this.dgvJadwalKelasSiswa);
            this.jadwalKelasSiswa.Location = new System.Drawing.Point(4, 29);
            this.jadwalKelasSiswa.Name = "jadwalKelasSiswa";
            this.jadwalKelasSiswa.Padding = new System.Windows.Forms.Padding(3);
            this.jadwalKelasSiswa.Size = new System.Drawing.Size(807, 304);
            this.jadwalKelasSiswa.TabIndex = 0;
            this.jadwalKelasSiswa.Text = "Jadwal Kelas";
            this.jadwalKelasSiswa.UseVisualStyleBackColor = true;
            // 
            // dgvJadwalKelasSiswa
            // 
            this.dgvJadwalKelasSiswa.AllowUserToAddRows = false;
            this.dgvJadwalKelasSiswa.AllowUserToDeleteRows = false;
            this.dgvJadwalKelasSiswa.AllowUserToOrderColumns = true;
            this.dgvJadwalKelasSiswa.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvJadwalKelasSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalKelasSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJadwalKelasSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalKelasSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanggalJadwalKelasSiswa,
            this.pengajarKelasSiswa,
            this.pelajaranKelasSiswa,
            this.jamMulaiKelasSiswa,
            this.DurasiKelasSiswa,
            this.zoomKelasSiswa});
            this.dgvJadwalKelasSiswa.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvJadwalKelasSiswa.Location = new System.Drawing.Point(3, 3);
            this.dgvJadwalKelasSiswa.Name = "dgvJadwalKelasSiswa";
            this.dgvJadwalKelasSiswa.ReadOnly = true;
            this.dgvJadwalKelasSiswa.RowHeadersWidth = 51;
            this.dgvJadwalKelasSiswa.RowTemplate.Height = 29;
            this.dgvJadwalKelasSiswa.Size = new System.Drawing.Size(808, 298);
            this.dgvJadwalKelasSiswa.TabIndex = 0;
            // 
            // tanggalJadwalKelasSiswa
            // 
            this.tanggalJadwalKelasSiswa.DataPropertyName = "tanggal";
            this.tanggalJadwalKelasSiswa.HeaderText = "Tanggal";
            this.tanggalJadwalKelasSiswa.MinimumWidth = 6;
            this.tanggalJadwalKelasSiswa.Name = "tanggalJadwalKelasSiswa";
            this.tanggalJadwalKelasSiswa.ReadOnly = true;
            this.tanggalJadwalKelasSiswa.Width = 125;
            // 
            // pengajarKelasSiswa
            // 
            this.pengajarKelasSiswa.DataPropertyName = "pengajar";
            this.pengajarKelasSiswa.HeaderText = "Pengajar";
            this.pengajarKelasSiswa.MinimumWidth = 6;
            this.pengajarKelasSiswa.Name = "pengajarKelasSiswa";
            this.pengajarKelasSiswa.ReadOnly = true;
            this.pengajarKelasSiswa.Width = 125;
            // 
            // pelajaranKelasSiswa
            // 
            this.pelajaranKelasSiswa.DataPropertyName = "pelajaran";
            this.pelajaranKelasSiswa.HeaderText = "Pelajaran";
            this.pelajaranKelasSiswa.MinimumWidth = 6;
            this.pelajaranKelasSiswa.Name = "pelajaranKelasSiswa";
            this.pelajaranKelasSiswa.ReadOnly = true;
            this.pelajaranKelasSiswa.Width = 125;
            // 
            // jamMulaiKelasSiswa
            // 
            this.jamMulaiKelasSiswa.DataPropertyName = "jammulai";
            this.jamMulaiKelasSiswa.HeaderText = "Jam Mulai";
            this.jamMulaiKelasSiswa.MinimumWidth = 6;
            this.jamMulaiKelasSiswa.Name = "jamMulaiKelasSiswa";
            this.jamMulaiKelasSiswa.ReadOnly = true;
            this.jamMulaiKelasSiswa.Width = 125;
            // 
            // DurasiKelasSiswa
            // 
            this.DurasiKelasSiswa.DataPropertyName = "durasi";
            this.DurasiKelasSiswa.HeaderText = "Durasi";
            this.DurasiKelasSiswa.MinimumWidth = 6;
            this.DurasiKelasSiswa.Name = "DurasiKelasSiswa";
            this.DurasiKelasSiswa.ReadOnly = true;
            this.DurasiKelasSiswa.Width = 125;
            // 
            // zoomKelasSiswa
            // 
            this.zoomKelasSiswa.DataPropertyName = "zoom";
            this.zoomKelasSiswa.HeaderText = "Link Zoom";
            this.zoomKelasSiswa.MinimumWidth = 6;
            this.zoomKelasSiswa.Name = "zoomKelasSiswa";
            this.zoomKelasSiswa.ReadOnly = true;
            this.zoomKelasSiswa.Width = 125;
            // 
            // jadwalUjianSiswa
            // 
            this.jadwalUjianSiswa.Controls.Add(this.dgvJadwalUjian);
            this.jadwalUjianSiswa.Location = new System.Drawing.Point(4, 29);
            this.jadwalUjianSiswa.Name = "jadwalUjianSiswa";
            this.jadwalUjianSiswa.Padding = new System.Windows.Forms.Padding(3);
            this.jadwalUjianSiswa.Size = new System.Drawing.Size(807, 304);
            this.jadwalUjianSiswa.TabIndex = 1;
            this.jadwalUjianSiswa.Text = "Jadwal Ujian";
            this.jadwalUjianSiswa.UseVisualStyleBackColor = true;
            // 
            // dgvJadwalUjian
            // 
            this.dgvJadwalUjian.AllowUserToAddRows = false;
            this.dgvJadwalUjian.AllowUserToDeleteRows = false;
            this.dgvJadwalUjian.AllowUserToOrderColumns = true;
            this.dgvJadwalUjian.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvJadwalUjian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalUjian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJadwalUjian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalUjian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeUjian,
            this.namaUjian,
            this.kodePelajaran,
            this.tanggalUjianSiswa,
            this.jamMulaiUjianSiswa,
            this.durasiUjianSiswa});
            this.dgvJadwalUjian.GridColor = System.Drawing.Color.Orange;
            this.dgvJadwalUjian.Location = new System.Drawing.Point(3, 3);
            this.dgvJadwalUjian.Name = "dgvJadwalUjian";
            this.dgvJadwalUjian.ReadOnly = true;
            this.dgvJadwalUjian.RowHeadersWidth = 51;
            this.dgvJadwalUjian.RowTemplate.Height = 29;
            this.dgvJadwalUjian.Size = new System.Drawing.Size(804, 298);
            this.dgvJadwalUjian.TabIndex = 1;
            this.dgvJadwalUjian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwalUjian_CellContentClick);
            // 
            // kodeUjian
            // 
            this.kodeUjian.DataPropertyName = "kodeujian";
            this.kodeUjian.HeaderText = "Kode Ujian";
            this.kodeUjian.MinimumWidth = 6;
            this.kodeUjian.Name = "kodeUjian";
            this.kodeUjian.ReadOnly = true;
            this.kodeUjian.Width = 125;
            // 
            // namaUjian
            // 
            this.namaUjian.DataPropertyName = "nama";
            this.namaUjian.HeaderText = "Nama Ujian";
            this.namaUjian.MinimumWidth = 6;
            this.namaUjian.Name = "namaUjian";
            this.namaUjian.ReadOnly = true;
            this.namaUjian.Width = 125;
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodepelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.MinimumWidth = 6;
            this.kodePelajaran.Name = "kodePelajaran";
            this.kodePelajaran.ReadOnly = true;
            this.kodePelajaran.Width = 125;
            // 
            // tanggalUjianSiswa
            // 
            this.tanggalUjianSiswa.DataPropertyName = "tanggal";
            this.tanggalUjianSiswa.HeaderText = "Tanggal";
            this.tanggalUjianSiswa.MinimumWidth = 6;
            this.tanggalUjianSiswa.Name = "tanggalUjianSiswa";
            this.tanggalUjianSiswa.ReadOnly = true;
            this.tanggalUjianSiswa.Width = 125;
            // 
            // jamMulaiUjianSiswa
            // 
            this.jamMulaiUjianSiswa.DataPropertyName = "jammulai";
            this.jamMulaiUjianSiswa.HeaderText = "Jam Mulai";
            this.jamMulaiUjianSiswa.MinimumWidth = 6;
            this.jamMulaiUjianSiswa.Name = "jamMulaiUjianSiswa";
            this.jamMulaiUjianSiswa.ReadOnly = true;
            this.jamMulaiUjianSiswa.Width = 125;
            // 
            // durasiUjianSiswa
            // 
            this.durasiUjianSiswa.DataPropertyName = "durasi";
            this.durasiUjianSiswa.HeaderText = "Durasi";
            this.durasiUjianSiswa.MinimumWidth = 6;
            this.durasiUjianSiswa.Name = "durasiUjianSiswa";
            this.durasiUjianSiswa.ReadOnly = true;
            this.durasiUjianSiswa.Width = 125;
            // 
            // lblDataSiswa
            // 
            this.lblDataSiswa.AutoSize = true;
            this.lblDataSiswa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataSiswa.Location = new System.Drawing.Point(443, 130);
            this.lblDataSiswa.Name = "lblDataSiswa";
            this.lblDataSiswa.Size = new System.Drawing.Size(147, 37);
            this.lblDataSiswa.TabIndex = 5;
            this.lblDataSiswa.Text = "Jadwalmu";
            this.lblDataSiswa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(869, 44);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormJadwalSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 667);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDataSiswa);
            this.Controls.Add(this.jadwalSiswa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJadwalSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJadwalSiswa";
            this.Load += new System.EventHandler(this.FormJadwalSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabControl jadwalSiswa;
        private System.Windows.Forms.TabPage jadwalKelasSiswa;
        private System.Windows.Forms.DataGridView dgvJadwalKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalJadwalKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengajarKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelajaranKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulaiKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurasiKelasSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoomKelasSiswa;
        private System.Windows.Forms.TabPage jadwalUjianSiswa;
        private System.Windows.Forms.DataGridView dgvJadwalUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalUjianSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulaiUjianSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiUjianSiswa;
        private System.Windows.Forms.Label lblDataSiswa;
        private System.Windows.Forms.Button btnClose;
    }
}