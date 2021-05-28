
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox2.Location = new System.Drawing.Point(-314, -39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(719, 625);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.txtJam);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDurasi);
            this.panel1.Controls.Add(this.txtKodePelajaran);
            this.panel1.Controls.Add(this.txtNamaUjian);
            this.panel1.Controls.Add(this.lblDurasi);
            this.panel1.Controls.Add(this.lblJamMulai);
            this.panel1.Controls.Add(this.lblTanggalUjian);
            this.panel1.Controls.Add(this.lblKodePelajaran);
            this.panel1.Controls.Add(this.lblNamaUjian);
            this.panel1.Controls.Add(this.lblKodeUjian);
            this.panel1.Controls.Add(this.txtTanggal);
            this.panel1.Controls.Add(this.txtKodeUjian);
            this.panel1.Controls.Add(this.lblInputJadwalUjian);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 518);
            this.panel1.TabIndex = 54;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(194, 462);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 33);
            this.btnBatal.TabIndex = 56;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // txtJam
            // 
            this.txtJam.BackColor = System.Drawing.Color.DarkOrange;
            this.txtJam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJam.Location = new System.Drawing.Point(44, 343);
            this.txtJam.Mask = "90:00";
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(224, 29);
            this.txtJam.TabIndex = 67;
            this.txtJam.ValidatingType = typeof(System.DateTime);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(105, 462);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(83, 33);
            this.btnSimpan.TabIndex = 55;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(201, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "menit";
            // 
            // txtDurasi
            // 
            this.txtDurasi.BackColor = System.Drawing.Color.DarkOrange;
            this.txtDurasi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDurasi.Location = new System.Drawing.Point(44, 408);
            this.txtDurasi.Mask = "00000";
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(140, 29);
            this.txtDurasi.TabIndex = 65;
            this.txtDurasi.ValidatingType = typeof(int);
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.Location = new System.Drawing.Point(44, 215);
            this.txtKodePelajaran.MaxLength = 5;
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(224, 29);
            this.txtKodePelajaran.TabIndex = 64;
            // 
            // txtNamaUjian
            // 
            this.txtNamaUjian.BackColor = System.Drawing.Color.DarkOrange;
            this.txtNamaUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNamaUjian.Location = new System.Drawing.Point(44, 152);
            this.txtNamaUjian.MaxLength = 10;
            this.txtNamaUjian.Name = "txtNamaUjian";
            this.txtNamaUjian.Size = new System.Drawing.Size(224, 29);
            this.txtNamaUjian.TabIndex = 63;
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDurasi.Location = new System.Drawing.Point(41, 384);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(55, 21);
            this.lblDurasi.TabIndex = 62;
            this.lblDurasi.Text = "Durasi";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJamMulai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJamMulai.Location = new System.Drawing.Point(41, 319);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(82, 21);
            this.lblJamMulai.TabIndex = 61;
            this.lblJamMulai.Text = "Jam Mulai";
            // 
            // lblTanggalUjian
            // 
            this.lblTanggalUjian.AutoSize = true;
            this.lblTanggalUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTanggalUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTanggalUjian.Location = new System.Drawing.Point(41, 255);
            this.lblTanggalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalUjian.Name = "lblTanggalUjian";
            this.lblTanggalUjian.Size = new System.Drawing.Size(106, 21);
            this.lblTanggalUjian.TabIndex = 60;
            this.lblTanggalUjian.Text = "Tanggal Ujian";
            // 
            // lblKodePelajaran
            // 
            this.lblKodePelajaran.AutoSize = true;
            this.lblKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKodePelajaran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKodePelajaran.Location = new System.Drawing.Point(41, 191);
            this.lblKodePelajaran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodePelajaran.Name = "lblKodePelajaran";
            this.lblKodePelajaran.Size = new System.Drawing.Size(117, 21);
            this.lblKodePelajaran.TabIndex = 59;
            this.lblKodePelajaran.Text = "Kode Pelajaran";
            // 
            // lblNamaUjian
            // 
            this.lblNamaUjian.AutoSize = true;
            this.lblNamaUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNamaUjian.Location = new System.Drawing.Point(41, 128);
            this.lblNamaUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaUjian.Name = "lblNamaUjian";
            this.lblNamaUjian.Size = new System.Drawing.Size(92, 21);
            this.lblNamaUjian.TabIndex = 58;
            this.lblNamaUjian.Text = "Nama Ujian";
            // 
            // lblKodeUjian
            // 
            this.lblKodeUjian.AutoSize = true;
            this.lblKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKodeUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKodeUjian.Location = new System.Drawing.Point(44, 64);
            this.lblKodeUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodeUjian.Name = "lblKodeUjian";
            this.lblKodeUjian.Size = new System.Drawing.Size(89, 21);
            this.lblKodeUjian.TabIndex = 57;
            this.lblKodeUjian.Text = "Kode Ujian";
            // 
            // txtTanggal
            // 
            this.txtTanggal.BackColor = System.Drawing.Color.DarkOrange;
            this.txtTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTanggal.Location = new System.Drawing.Point(44, 278);
            this.txtTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTanggal.Mask = "00/00/0000";
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(224, 29);
            this.txtTanggal.TabIndex = 56;
            this.txtTanggal.ValidatingType = typeof(System.DateTime);
            // 
            // txtKodeUjian
            // 
            this.txtKodeUjian.BackColor = System.Drawing.Color.DarkOrange;
            this.txtKodeUjian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeUjian.Location = new System.Drawing.Point(44, 89);
            this.txtKodeUjian.Margin = new System.Windows.Forms.Padding(4);
            this.txtKodeUjian.MaxLength = 5;
            this.txtKodeUjian.Name = "txtKodeUjian";
            this.txtKodeUjian.Size = new System.Drawing.Size(224, 29);
            this.txtKodeUjian.TabIndex = 55;
            // 
            // lblInputJadwalUjian
            // 
            this.lblInputJadwalUjian.AutoSize = true;
            this.lblInputJadwalUjian.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputJadwalUjian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInputJadwalUjian.Location = new System.Drawing.Point(31, 14);
            this.lblInputJadwalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputJadwalUjian.Name = "lblInputJadwalUjian";
            this.lblInputJadwalUjian.Size = new System.Drawing.Size(270, 32);
            this.lblInputJadwalUjian.TabIndex = 54;
            this.lblInputJadwalUjian.Text = "INPUT JADWAL UJIAN";
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
            // FormInputUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputUjian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputUjian";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}