
namespace Bimbem_App
{
    partial class formNilaiUjian
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataPengajar = new System.Windows.Forms.Label();
            this.dgvNilaiSiswa = new System.Windows.Forms.DataGridView();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilaiSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDataPengajar
            // 
            this.lblDataPengajar.AutoSize = true;
            this.lblDataPengajar.BackColor = System.Drawing.Color.White;
            this.lblDataPengajar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataPengajar.Location = new System.Drawing.Point(422, 161);
            this.lblDataPengajar.Name = "lblDataPengajar";
            this.lblDataPengajar.Size = new System.Drawing.Size(151, 37);
            this.lblDataPengajar.TabIndex = 5;
            this.lblDataPengajar.Text = "Nilai Ujian";
            // 
            // dgvNilaiSiswa
            // 
            this.dgvNilaiSiswa.AllowUserToAddRows = false;
            this.dgvNilaiSiswa.AllowUserToDeleteRows = false;
            this.dgvNilaiSiswa.AllowUserToOrderColumns = true;
            this.dgvNilaiSiswa.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvNilaiSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNilaiSiswa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNilaiSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNilaiSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilaiSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.kodeKelas,
            this.dataGridViewTextBoxColumn1,
            this.nilai,
            this.dataGridViewTextBoxColumn2});
            this.dgvNilaiSiswa.GridColor = System.Drawing.Color.MistyRose;
            this.dgvNilaiSiswa.Location = new System.Drawing.Point(153, 259);
            this.dgvNilaiSiswa.Name = "dgvNilaiSiswa";
            this.dgvNilaiSiswa.ReadOnly = true;
            this.dgvNilaiSiswa.RowHeadersWidth = 51;
            this.dgvNilaiSiswa.RowTemplate.Height = 29;
            this.dgvNilaiSiswa.Size = new System.Drawing.Size(678, 224);
            this.dgvNilaiSiswa.TabIndex = 25;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 125;
            // 
            // kodeKelas
            // 
            this.kodeKelas.DataPropertyName = "kodekelas";
            this.kodeKelas.HeaderText = "Kode Kelas";
            this.kodeKelas.MinimumWidth = 6;
            this.kodeKelas.Name = "kodeKelas";
            this.kodeKelas.ReadOnly = true;
            this.kodeKelas.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "namaujian";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nama Ujian";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tanggal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(854, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formNilaiUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 665);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvNilaiSiswa);
            this.Controls.Add(this.lblDataPengajar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formNilaiUjian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengajar";
            this.Load += new System.EventHandler(this.formSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilaiSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataPengajar;
        private System.Windows.Forms.DataGridView dgvNilaiSiswa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}