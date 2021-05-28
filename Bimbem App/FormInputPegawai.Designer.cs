
namespace Bimbem_App
{
    partial class FormInputPegawai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPegawai = new System.Windows.Forms.DataGridView();
            this.noPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBatal = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLakiLaki = new System.Windows.Forms.RadioButton();
            this.tbPosisi = new System.Windows.Forms.TextBox();
            this.lbPosisi = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbNomorHP = new System.Windows.Forms.TextBox();
            this.lbNomorHP = new System.Windows.Forms.Label();
            this.lbJenisKelamin = new System.Windows.Forms.Label();
            this.tbNamaPegawai = new System.Windows.Forms.TextBox();
            this.lbNamaPegawai = new System.Windows.Forms.Label();
            this.tbKodePegawai = new System.Windows.Forms.TextBox();
            this.lbKodePegawai = new System.Windows.Forms.Label();
            this.lbJudulInputPegawai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgvPegawai);
            this.panel1.Location = new System.Drawing.Point(39, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 366);
            this.panel1.TabIndex = 3;
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPegawai,
            this.namaPegawai,
            this.jenisKelaminPegawai,
            this.noHPPegawai,
            this.emailPegawai,
            this.posisi});
            this.dgvPegawai.Location = new System.Drawing.Point(26, 35);
            this.dgvPegawai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.RowHeadersWidth = 51;
            this.dgvPegawai.RowTemplate.Height = 25;
            this.dgvPegawai.Size = new System.Drawing.Size(736, 309);
            this.dgvPegawai.TabIndex = 0;
            // 
            // noPegawai
            // 
            this.noPegawai.HeaderText = "No. Pegawai";
            this.noPegawai.MinimumWidth = 6;
            this.noPegawai.Name = "noPegawai";
            this.noPegawai.Width = 125;
            // 
            // namaPegawai
            // 
            this.namaPegawai.HeaderText = "Nama ";
            this.namaPegawai.MinimumWidth = 6;
            this.namaPegawai.Name = "namaPegawai";
            this.namaPegawai.Width = 125;
            // 
            // jenisKelaminPegawai
            // 
            this.jenisKelaminPegawai.HeaderText = "Jenis Kelamin";
            this.jenisKelaminPegawai.MinimumWidth = 6;
            this.jenisKelaminPegawai.Name = "jenisKelaminPegawai";
            this.jenisKelaminPegawai.Width = 125;
            // 
            // noHPPegawai
            // 
            this.noHPPegawai.HeaderText = "Nomor HP";
            this.noHPPegawai.MinimumWidth = 6;
            this.noHPPegawai.Name = "noHPPegawai";
            this.noHPPegawai.Width = 125;
            // 
            // emailPegawai
            // 
            this.emailPegawai.HeaderText = "Email";
            this.emailPegawai.MinimumWidth = 6;
            this.emailPegawai.Name = "emailPegawai";
            this.emailPegawai.Width = 125;
            // 
            // posisi
            // 
            this.posisi.HeaderText = "Posisi";
            this.posisi.MinimumWidth = 6;
            this.posisi.Name = "posisi";
            this.posisi.Width = 125;
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.SeaShell;
            this.btBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBatal.Location = new System.Drawing.Point(735, 423);
            this.btBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(95, 40);
            this.btBatal.TabIndex = 20;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = false;
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.SeaShell;
            this.btSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSimpan.Location = new System.Drawing.Point(622, 423);
            this.btSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(95, 40);
            this.btSimpan.TabIndex = 19;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = false;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(189, 352);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(104, 24);
            this.rbPerempuan.TabIndex = 14;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.AutoSize = true;
            this.rbLakiLaki.Location = new System.Drawing.Point(316, 352);
            this.rbLakiLaki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.Size = new System.Drawing.Size(85, 24);
            this.rbLakiLaki.TabIndex = 13;
            this.rbLakiLaki.TabStop = true;
            this.rbLakiLaki.Text = "Laki-laki";
            this.rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // tbPosisi
            // 
            this.tbPosisi.BackColor = System.Drawing.Color.Salmon;
            this.tbPosisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPosisi.Location = new System.Drawing.Point(551, 349);
            this.tbPosisi.Name = "tbPosisi";
            this.tbPosisi.Size = new System.Drawing.Size(279, 27);
            this.tbPosisi.TabIndex = 12;
            this.tbPosisi.TextChanged += new System.EventHandler(this.tbPosisi_TextChanged);
            // 
            // lbPosisi
            // 
            this.lbPosisi.AutoSize = true;
            this.lbPosisi.BackColor = System.Drawing.Color.Wheat;
            this.lbPosisi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPosisi.Location = new System.Drawing.Point(553, 317);
            this.lbPosisi.Name = "lbPosisi";
            this.lbPosisi.Size = new System.Drawing.Size(63, 28);
            this.lbPosisi.TabIndex = 11;
            this.lbPosisi.Text = "Posisi";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Salmon;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(555, 272);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(279, 27);
            this.tbEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Wheat;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(555, 241);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 28);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // tbNomorHP
            // 
            this.tbNomorHP.BackColor = System.Drawing.Color.Salmon;
            this.tbNomorHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomorHP.Location = new System.Drawing.Point(553, 195);
            this.tbNomorHP.Name = "tbNomorHP";
            this.tbNomorHP.Size = new System.Drawing.Size(279, 27);
            this.tbNomorHP.TabIndex = 8;
            // 
            // lbNomorHP
            // 
            this.lbNomorHP.AutoSize = true;
            this.lbNomorHP.BackColor = System.Drawing.Color.Wheat;
            this.lbNomorHP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNomorHP.Location = new System.Drawing.Point(555, 164);
            this.lbNomorHP.Name = "lbNomorHP";
            this.lbNomorHP.Size = new System.Drawing.Size(109, 28);
            this.lbNomorHP.TabIndex = 7;
            this.lbNomorHP.Text = "Nomor HP";
            // 
            // lbJenisKelamin
            // 
            this.lbJenisKelamin.AutoSize = true;
            this.lbJenisKelamin.BackColor = System.Drawing.Color.Wheat;
            this.lbJenisKelamin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJenisKelamin.Location = new System.Drawing.Point(189, 317);
            this.lbJenisKelamin.Name = "lbJenisKelamin";
            this.lbJenisKelamin.Size = new System.Drawing.Size(136, 28);
            this.lbJenisKelamin.TabIndex = 5;
            this.lbJenisKelamin.Text = "Jenis Kelamin";
            this.lbJenisKelamin.Click += new System.EventHandler(this.lbJenisKelamin_Click);
            // 
            // tbNamaPegawai
            // 
            this.tbNamaPegawai.BackColor = System.Drawing.Color.Salmon;
            this.tbNamaPegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamaPegawai.Location = new System.Drawing.Point(192, 272);
            this.tbNamaPegawai.Name = "tbNamaPegawai";
            this.tbNamaPegawai.Size = new System.Drawing.Size(279, 27);
            this.tbNamaPegawai.TabIndex = 4;
            this.tbNamaPegawai.TextChanged += new System.EventHandler(this.tbNamaPegawai_TextChanged);
            // 
            // lbNamaPegawai
            // 
            this.lbNamaPegawai.AutoSize = true;
            this.lbNamaPegawai.BackColor = System.Drawing.Color.Wheat;
            this.lbNamaPegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNamaPegawai.Location = new System.Drawing.Point(192, 241);
            this.lbNamaPegawai.Name = "lbNamaPegawai";
            this.lbNamaPegawai.Size = new System.Drawing.Size(145, 28);
            this.lbNamaPegawai.TabIndex = 3;
            this.lbNamaPegawai.Text = "Nama Pegawai";
            this.lbNamaPegawai.Click += new System.EventHandler(this.lbNamaPegawai_Click);
            // 
            // tbKodePegawai
            // 
            this.tbKodePegawai.BackColor = System.Drawing.Color.Salmon;
            this.tbKodePegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKodePegawai.Location = new System.Drawing.Point(192, 195);
            this.tbKodePegawai.Name = "tbKodePegawai";
            this.tbKodePegawai.Size = new System.Drawing.Size(279, 27);
            this.tbKodePegawai.TabIndex = 2;
            this.tbKodePegawai.TextChanged += new System.EventHandler(this.tbKodePegawai_TextChanged);
            // 
            // lbKodePegawai
            // 
            this.lbKodePegawai.AutoSize = true;
            this.lbKodePegawai.BackColor = System.Drawing.Color.Wheat;
            this.lbKodePegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKodePegawai.Location = new System.Drawing.Point(192, 164);
            this.lbKodePegawai.Name = "lbKodePegawai";
            this.lbKodePegawai.Size = new System.Drawing.Size(139, 28);
            this.lbKodePegawai.TabIndex = 1;
            this.lbKodePegawai.Text = "Kode Pegawai";
            this.lbKodePegawai.Click += new System.EventHandler(this.lbKodePegawai_Click);
            // 
            // lbJudulInputPegawai
            // 
            this.lbJudulInputPegawai.AutoSize = true;
            this.lbJudulInputPegawai.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulInputPegawai.Location = new System.Drawing.Point(440, 61);
            this.lbJudulInputPegawai.Name = "lbJudulInputPegawai";
            this.lbJudulInputPegawai.Size = new System.Drawing.Size(144, 38);
            this.lbJudulInputPegawai.TabIndex = 0;
            this.lbJudulInputPegawai.Text = "PEGAWAI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 915);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SeaShell;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(906, 553);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(95, 40);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaShell;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(906, 623);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 40);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SeaShell;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(906, 695);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(95, 40);
            this.btnTambah.TabIndex = 23;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(906, 759);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 40);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(906, 16);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 43);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormInputPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 901);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.lbJudulInputPegawai);
            this.Controls.Add(this.rbLakiLaki);
            this.Controls.Add(this.lbKodePegawai);
            this.Controls.Add(this.tbPosisi);
            this.Controls.Add(this.tbKodePegawai);
            this.Controls.Add(this.lbPosisi);
            this.Controls.Add(this.lbNamaPegawai);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNamaPegawai);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbJenisKelamin);
            this.Controls.Add(this.tbNomorHP);
            this.Controls.Add(this.lbNomorHP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputPegawai";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbKodePegawai;
        private System.Windows.Forms.Label lbKodePegawai;
        private System.Windows.Forms.Label lbJudulInputPegawai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNomorHP;
        private System.Windows.Forms.Label lbNomorHP;
        private System.Windows.Forms.Label lbJenisKelamin;
        private System.Windows.Forms.TextBox tbNamaPegawai;
        private System.Windows.Forms.Label lbNamaPegawai;
        private System.Windows.Forms.RadioButton rbLakiLaki;
        private System.Windows.Forms.TextBox tbPosisi;
        private System.Windows.Forms.Label lbPosisi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.DataGridView dgvPegawai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisi;
        private System.Windows.Forms.Button btnHome;
    }
}