
namespace Bimbem_App
{
    partial class formInputPengajar
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
            this.panelInputPengajar = new System.Windows.Forms.Panel();
            this.dgvPengajar = new System.Windows.Forms.DataGridView();
            this.nopengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodepelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtKodePelajaran = new System.Windows.Forms.TextBox();
            this.txtNoPegawai = new System.Windows.Forms.TextBox();
            this.txtNoPengajar = new System.Windows.Forms.TextBox();
            this.lblKodePelajaran = new System.Windows.Forms.Label();
            this.lblNoPegawai = new System.Windows.Forms.Label();
            this.lblNoPengajar = new System.Windows.Forms.Label();
            this.lblInputPengajar = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInputPengajar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengajar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-58, -68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 880);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelInputPengajar
            // 
            this.panelInputPengajar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputPengajar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInputPengajar.Controls.Add(this.dgvPengajar);
            this.panelInputPengajar.Location = new System.Drawing.Point(401, 185);
            this.panelInputPengajar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInputPengajar.Name = "panelInputPengajar";
            this.panelInputPengajar.Size = new System.Drawing.Size(548, 391);
            this.panelInputPengajar.TabIndex = 2;
            // 
            // dgvPengajar
            // 
            this.dgvPengajar.AllowUserToAddRows = false;
            this.dgvPengajar.AllowUserToDeleteRows = false;
            this.dgvPengajar.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvPengajar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengajar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPengajar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengajar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nopengajar,
            this.nopegawai,
            this.kodepelajaran});
            this.dgvPengajar.Location = new System.Drawing.Point(39, 29);
            this.dgvPengajar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPengajar.Name = "dgvPengajar";
            this.dgvPengajar.ReadOnly = true;
            this.dgvPengajar.RowHeadersWidth = 51;
            this.dgvPengajar.RowTemplate.Height = 25;
            this.dgvPengajar.Size = new System.Drawing.Size(468, 335);
            this.dgvPengajar.TabIndex = 0;
            // 
            // nopengajar
            // 
            this.nopengajar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nopengajar.HeaderText = "No Pengajar";
            this.nopengajar.MinimumWidth = 6;
            this.nopengajar.Name = "nopengajar";
            this.nopengajar.ReadOnly = true;
            this.nopengajar.Width = 133;
            // 
            // nopegawai
            // 
            this.nopegawai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nopegawai.HeaderText = "No Pegawai";
            this.nopegawai.MinimumWidth = 6;
            this.nopegawai.Name = "nopegawai";
            this.nopegawai.ReadOnly = true;
            this.nopegawai.Width = 130;
            // 
            // kodepelajaran
            // 
            this.kodepelajaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodepelajaran.HeaderText = "Kode Pelajaran";
            this.kodepelajaran.MinimumWidth = 6;
            this.kodepelajaran.Name = "kodepelajaran";
            this.kodepelajaran.ReadOnly = true;
            this.kodepelajaran.Width = 152;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.SeaShell;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(288, 459);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(85, 31);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SeaShell;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(182, 459);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 31);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.BackColor = System.Drawing.Color.SlateBlue;
            this.txtKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.Location = new System.Drawing.Point(70, 401);
            this.txtKodePelajaran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(302, 30);
            this.txtKodePelajaran.TabIndex = 12;
            // 
            // txtNoPegawai
            // 
            this.txtNoPegawai.BackColor = System.Drawing.Color.SlateBlue;
            this.txtNoPegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoPegawai.Location = new System.Drawing.Point(70, 308);
            this.txtNoPegawai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoPegawai.Name = "txtNoPegawai";
            this.txtNoPegawai.Size = new System.Drawing.Size(302, 30);
            this.txtNoPegawai.TabIndex = 11;
            // 
            // txtNoPengajar
            // 
            this.txtNoPengajar.BackColor = System.Drawing.Color.SlateBlue;
            this.txtNoPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoPengajar.Location = new System.Drawing.Point(70, 216);
            this.txtNoPengajar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoPengajar.Name = "txtNoPengajar";
            this.txtNoPengajar.Size = new System.Drawing.Size(302, 30);
            this.txtNoPengajar.TabIndex = 10;
            // 
            // lblKodePelajaran
            // 
            this.lblKodePelajaran.AutoSize = true;
            this.lblKodePelajaran.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKodePelajaran.Location = new System.Drawing.Point(72, 371);
            this.lblKodePelajaran.Name = "lblKodePelajaran";
            this.lblKodePelajaran.Size = new System.Drawing.Size(123, 23);
            this.lblKodePelajaran.TabIndex = 5;
            this.lblKodePelajaran.Text = "Kode Pelajaran";
            // 
            // lblNoPegawai
            // 
            this.lblNoPegawai.AutoSize = true;
            this.lblNoPegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoPegawai.Location = new System.Drawing.Point(72, 277);
            this.lblNoPegawai.Name = "lblNoPegawai";
            this.lblNoPegawai.Size = new System.Drawing.Size(132, 23);
            this.lblNoPegawai.TabIndex = 4;
            this.lblNoPegawai.Text = "Nomor Pegawai";
            // 
            // lblNoPengajar
            // 
            this.lblNoPengajar.AutoSize = true;
            this.lblNoPengajar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoPengajar.Location = new System.Drawing.Point(72, 185);
            this.lblNoPengajar.Name = "lblNoPengajar";
            this.lblNoPengajar.Size = new System.Drawing.Size(135, 23);
            this.lblNoPengajar.TabIndex = 3;
            this.lblNoPengajar.Text = "Nomor Pengajar";
            // 
            // lblInputPengajar
            // 
            this.lblInputPengajar.AutoSize = true;
            this.lblInputPengajar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputPengajar.Location = new System.Drawing.Point(491, 105);
            this.lblInputPengajar.Name = "lblInputPengajar";
            this.lblInputPengajar.Size = new System.Drawing.Size(156, 37);
            this.lblInputPengajar.TabIndex = 2;
            this.lblInputPengajar.Text = "PENGAJAR";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SlateBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1003, 37);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 51);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(957, 352);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 31);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SeaShell;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(957, 299);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 31);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaShell;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(957, 240);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 31);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SeaShell;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(957, 185);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 31);
            this.btnHapus.TabIndex = 20;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // formInputPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKodePelajaran);
            this.Controls.Add(this.lblInputPengajar);
            this.Controls.Add(this.txtNoPegawai);
            this.Controls.Add(this.lblNoPengajar);
            this.Controls.Add(this.txtNoPengajar);
            this.Controls.Add(this.lblNoPegawai);
            this.Controls.Add(this.lblKodePelajaran);
            this.Controls.Add(this.panelInputPengajar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formInputPengajar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Pengajar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInputPengajar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInputPengajar;
        private System.Windows.Forms.Label lblInputPengajar;
        private System.Windows.Forms.Label lblKodePelajaran;
        private System.Windows.Forms.Label lblNoPegawai;
        private System.Windows.Forms.Label lblNoPengajar;
        private System.Windows.Forms.TextBox txtKodePelajaran;
        private System.Windows.Forms.TextBox txtNoPegawai;
        private System.Windows.Forms.TextBox txtNoPengajar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvPengajar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepelajaran;
    }
}