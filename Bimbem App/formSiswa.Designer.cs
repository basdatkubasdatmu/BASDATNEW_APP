
namespace Bimbem_App
{
    partial class formSiswa
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
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.noSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalDaerah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataSiswa = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.AllowUserToAddRows = false;
            this.dgvSiswa.AllowUserToDeleteRows = false;
            this.dgvSiswa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noSiswa,
            this.namaSiswa,
            this.jeniskelaminSiswa,
            this.kodeKelas,
            this.noHPSiswa,
            this.emailSiswa,
            this.asalDaerah});
            this.dgvSiswa.Location = new System.Drawing.Point(42, 72);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowTemplate.Height = 25;
            this.dgvSiswa.Size = new System.Drawing.Size(658, 379);
            this.dgvSiswa.TabIndex = 3;
            // 
            // noSiswa
            // 
            this.noSiswa.DataPropertyName = "nosiswa";
            this.noSiswa.HeaderText = "No. Siswa";
            this.noSiswa.MaxInputLength = 10;
            this.noSiswa.Name = "noSiswa";
            // 
            // namaSiswa
            // 
            this.namaSiswa.DataPropertyName = "nama";
            this.namaSiswa.HeaderText = "Nama Siswa";
            this.namaSiswa.MaxInputLength = 30;
            this.namaSiswa.Name = "namaSiswa";
            // 
            // jeniskelaminSiswa
            // 
            this.jeniskelaminSiswa.DataPropertyName = "jeniskelamin";
            this.jeniskelaminSiswa.HeaderText = "Jenis Kelamin";
            this.jeniskelaminSiswa.Name = "jeniskelaminSiswa";
            // 
            // kodeKelas
            // 
            this.kodeKelas.DataPropertyName = "kodekelas";
            this.kodeKelas.HeaderText = "Kode Kelas";
            this.kodeKelas.MaxInputLength = 5;
            this.kodeKelas.Name = "kodeKelas";
            // 
            // noHPSiswa
            // 
            this.noHPSiswa.DataPropertyName = "nohp";
            this.noHPSiswa.HeaderText = "No HP";
            this.noHPSiswa.Name = "noHPSiswa";
            // 
            // emailSiswa
            // 
            this.emailSiswa.DataPropertyName = "email";
            this.emailSiswa.HeaderText = "Email";
            this.emailSiswa.MaxInputLength = 30;
            this.emailSiswa.Name = "emailSiswa";
            // 
            // asalDaerah
            // 
            this.asalDaerah.DataPropertyName = "asaldaerah";
            this.asalDaerah.HeaderText = "Asal Daerah";
            this.asalDaerah.MaxInputLength = 20;
            this.asalDaerah.Name = "asalDaerah";
            // 
            // lblDataSiswa
            // 
            this.lblDataSiswa.AutoSize = true;
            this.lblDataSiswa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataSiswa.Location = new System.Drawing.Point(42, 19);
            this.lblDataSiswa.Name = "lblDataSiswa";
            this.lblDataSiswa.Size = new System.Drawing.Size(126, 30);
            this.lblDataSiswa.TabIndex = 4;
            this.lblDataSiswa.Text = "Data Siswa";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(393, 458);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(555, 458);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(474, 458);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 35);
            this.btnTambah.TabIndex = 21;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(636, 457);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 35);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // formSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 542);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDataSiswa);
            this.Controls.Add(this.dgvSiswa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSiswa";
            this.Text = "Siswa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Label lblDataSiswa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalDaerah;
    }
}