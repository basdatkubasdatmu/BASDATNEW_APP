
namespace Bimbem_App
{
    partial class formPengajar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDataPengajar = new System.Windows.Forms.Label();
            this.noPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPengajar,
            this.kodePelajaran,
            this.noPegawai});
            this.dataGridView1.Location = new System.Drawing.Point(45, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 341);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblDataPengajar
            // 
            this.lblDataPengajar.AutoSize = true;
            this.lblDataPengajar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataPengajar.Location = new System.Drawing.Point(45, 23);
            this.lblDataPengajar.Name = "lblDataPengajar";
            this.lblDataPengajar.Size = new System.Drawing.Size(159, 30);
            this.lblDataPengajar.TabIndex = 5;
            this.lblDataPengajar.Text = "Data Pengajar";
            // 
            // noPengajar
            // 
            this.noPengajar.DataPropertyName = "nopengajar";
            this.noPengajar.HeaderText = "No. Pengajar";
            this.noPengajar.MaxInputLength = 10;
            this.noPengajar.Name = "noPengajar";
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodepelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.MaxInputLength = 5;
            this.kodePelajaran.Name = "kodePelajaran";
            // 
            // noPegawai
            // 
            this.noPegawai.DataPropertyName = "nopegawai";
            this.noPegawai.HeaderText = "No. Pegawai";
            this.noPegawai.MaxInputLength = 10;
            this.noPegawai.Name = "noPegawai";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(332, 432);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(413, 432);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 35);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(494, 432);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(575, 432);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 35);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // formPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 525);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDataPengajar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPengajar";
            this.Text = "Pengajar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawai;
        private System.Windows.Forms.Label lblDataPengajar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
    }
}