
namespace Bimbem_App
{
    partial class FormInputPresensi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInputPresensiSiswa = new System.Windows.Forms.Label();
            this.txtNoSiswa = new System.Windows.Forms.TextBox();
            this.txtNamaSiswa = new System.Windows.Forms.TextBox();
            this.txtkodeJadwalSiswa = new System.Windows.Forms.TextBox();
            this.dtpPresensi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblInputPresensiSiswa);
            this.panel1.Controls.Add(this.txtNoSiswa);
            this.panel1.Controls.Add(this.txtNamaSiswa);
            this.panel1.Controls.Add(this.txtkodeJadwalSiswa);
            this.panel1.Controls.Add(this.dtpPresensi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 408);
            this.panel1.TabIndex = 2;
            // 
            // lblInputPresensiSiswa
            // 
            this.lblInputPresensiSiswa.AutoSize = true;
            this.lblInputPresensiSiswa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputPresensiSiswa.ForeColor = System.Drawing.Color.Black;
            this.lblInputPresensiSiswa.Location = new System.Drawing.Point(41, 29);
            this.lblInputPresensiSiswa.Name = "lblInputPresensiSiswa";
            this.lblInputPresensiSiswa.Size = new System.Drawing.Size(259, 30);
            this.lblInputPresensiSiswa.TabIndex = 24;
            this.lblInputPresensiSiswa.Text = "INPUT PRESENSI SISWA";
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.BackColor = System.Drawing.Color.SlateBlue;
            this.txtNoSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoSiswa.Location = new System.Drawing.Point(38, 171);
            this.txtNoSiswa.MaxLength = 10;
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(262, 22);
            this.txtNoSiswa.TabIndex = 23;
            // 
            // txtNamaSiswa
            // 
            this.txtNamaSiswa.BackColor = System.Drawing.Color.SlateBlue;
            this.txtNamaSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNamaSiswa.Location = new System.Drawing.Point(38, 232);
            this.txtNamaSiswa.MaxLength = 30;
            this.txtNamaSiswa.Name = "txtNamaSiswa";
            this.txtNamaSiswa.ReadOnly = true;
            this.txtNamaSiswa.Size = new System.Drawing.Size(262, 22);
            this.txtNamaSiswa.TabIndex = 22;
            // 
            // txtkodeJadwalSiswa
            // 
            this.txtkodeJadwalSiswa.BackColor = System.Drawing.Color.SlateBlue;
            this.txtkodeJadwalSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkodeJadwalSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtkodeJadwalSiswa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtkodeJadwalSiswa.Location = new System.Drawing.Point(38, 110);
            this.txtkodeJadwalSiswa.MaxLength = 10;
            this.txtkodeJadwalSiswa.Name = "txtkodeJadwalSiswa";
            this.txtkodeJadwalSiswa.Size = new System.Drawing.Size(262, 22);
            this.txtkodeJadwalSiswa.TabIndex = 21;
            // 
            // dtpPresensi
            // 
            this.dtpPresensi.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPresensi.CalendarMonthBackground = System.Drawing.Color.SeaShell;
            this.dtpPresensi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpPresensi.Location = new System.Drawing.Point(38, 293);
            this.dtpPresensi.Name = "dtpPresensi";
            this.dtpPresensi.Size = new System.Drawing.Size(262, 29);
            this.dtpPresensi.TabIndex = 20;
            this.dtpPresensi.Value = new System.DateTime(2021, 5, 17, 20, 44, 13, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Waktu Kehadiran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nama Siswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "No Siswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kode Jadwal Siswa";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.SeaShell;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(226, 345);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 30);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SeaShell;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(137, 345);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(83, 30);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // FormInputPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputPresensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputPresensi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputPresensiSiswa;
        private System.Windows.Forms.TextBox txtNoSiswa;
        private System.Windows.Forms.TextBox txtNamaSiswa;
        private System.Windows.Forms.TextBox txtkodeJadwalSiswa;
        private System.Windows.Forms.DateTimePicker dtpPresensi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}