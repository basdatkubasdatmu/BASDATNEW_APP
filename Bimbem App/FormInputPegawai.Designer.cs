
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.Location = new System.Drawing.Point(330, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 274);
            this.panel1.TabIndex = 3;
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.AllowUserToAddRows = false;
            this.dgvPegawai.AllowUserToDeleteRows = false;
            this.dgvPegawai.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvPegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPegawai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPegawai,
            this.namaPegawai,
            this.jenisKelaminPegawai,
            this.noHPPegawai,
            this.emailPegawai,
            this.posisi});
            this.dgvPegawai.Location = new System.Drawing.Point(18, 22);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.ReadOnly = true;
            this.dgvPegawai.RowHeadersWidth = 51;
            this.dgvPegawai.RowTemplate.Height = 25;
            this.dgvPegawai.Size = new System.Drawing.Size(568, 232);
            this.dgvPegawai.TabIndex = 0;
            // 
            // noPegawai
            // 
            this.noPegawai.DataPropertyName = "noPegawai";
            this.noPegawai.HeaderText = "No. Pegawai";
            this.noPegawai.MinimumWidth = 6;
            this.noPegawai.Name = "noPegawai";
            this.noPegawai.ReadOnly = true;
            this.noPegawai.Width = 125;
            // 
            // namaPegawai
            // 
            this.namaPegawai.DataPropertyName = "namaPegawai";
            this.namaPegawai.HeaderText = "Nama ";
            this.namaPegawai.MinimumWidth = 6;
            this.namaPegawai.Name = "namaPegawai";
            this.namaPegawai.ReadOnly = true;
            this.namaPegawai.Width = 125;
            // 
            // jenisKelaminPegawai
            // 
            this.jenisKelaminPegawai.DataPropertyName = "jeniskelamin";
            this.jenisKelaminPegawai.HeaderText = "Jenis Kelamin";
            this.jenisKelaminPegawai.MinimumWidth = 6;
            this.jenisKelaminPegawai.Name = "jenisKelaminPegawai";
            this.jenisKelaminPegawai.ReadOnly = true;
            this.jenisKelaminPegawai.Width = 125;
            // 
            // noHPPegawai
            // 
            this.noHPPegawai.DataPropertyName = "nohp";
            this.noHPPegawai.HeaderText = "Nomor HP";
            this.noHPPegawai.MinimumWidth = 6;
            this.noHPPegawai.Name = "noHPPegawai";
            this.noHPPegawai.ReadOnly = true;
            this.noHPPegawai.Width = 125;
            // 
            // emailPegawai
            // 
            this.emailPegawai.DataPropertyName = "email";
            this.emailPegawai.HeaderText = "Email";
            this.emailPegawai.MinimumWidth = 6;
            this.emailPegawai.Name = "emailPegawai";
            this.emailPegawai.ReadOnly = true;
            this.emailPegawai.Width = 125;
            // 
            // posisi
            // 
            this.posisi.DataPropertyName = "posisi";
            this.posisi.HeaderText = "Posisi";
            this.posisi.MinimumWidth = 6;
            this.posisi.Name = "posisi";
            this.posisi.ReadOnly = true;
            this.posisi.Width = 125;
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.SeaShell;
            this.btBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBatal.Location = new System.Drawing.Point(225, 439);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(74, 23);
            this.btBatal.TabIndex = 20;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.SeaShell;
            this.btSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSimpan.Location = new System.Drawing.Point(145, 439);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(74, 23);
            this.btSimpan.TabIndex = 19;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(55, 247);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(86, 19);
            this.rbPerempuan.TabIndex = 14;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.AutoSize = true;
            this.rbLakiLaki.Location = new System.Drawing.Point(166, 247);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.Size = new System.Drawing.Size(69, 19);
            this.rbLakiLaki.TabIndex = 13;
            this.rbLakiLaki.TabStop = true;
            this.rbLakiLaki.Text = "Laki-laki";
            this.rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // tbPosisi
            // 
            this.tbPosisi.BackColor = System.Drawing.Color.Salmon;
            this.tbPosisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPosisi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPosisi.Location = new System.Drawing.Point(55, 406);
            this.tbPosisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPosisi.Name = "tbPosisi";
            this.tbPosisi.Size = new System.Drawing.Size(244, 25);
            this.tbPosisi.TabIndex = 12;
            
            // 
            // lbPosisi
            // 
            this.lbPosisi.AutoSize = true;
            this.lbPosisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPosisi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPosisi.Location = new System.Drawing.Point(56, 385);
            this.lbPosisi.Name = "lbPosisi";
            this.lbPosisi.Size = new System.Drawing.Size(45, 19);
            this.lbPosisi.TabIndex = 11;
            this.lbPosisi.Text = "Posisi";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Salmon;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(54, 352);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 25);
            this.tbEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(55, 331);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(43, 19);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // tbNomorHP
            // 
            this.tbNomorHP.BackColor = System.Drawing.Color.Salmon;
            this.tbNomorHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomorHP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNomorHP.Location = new System.Drawing.Point(54, 297);
            this.tbNomorHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomorHP.Name = "tbNomorHP";
            this.tbNomorHP.Size = new System.Drawing.Size(244, 25);
            this.tbNomorHP.TabIndex = 8;
            // 
            // lbNomorHP
            // 
            this.lbNomorHP.AutoSize = true;
            this.lbNomorHP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNomorHP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNomorHP.Location = new System.Drawing.Point(55, 276);
            this.lbNomorHP.Name = "lbNomorHP";
            this.lbNomorHP.Size = new System.Drawing.Size(75, 19);
            this.lbNomorHP.TabIndex = 7;
            this.lbNomorHP.Text = "Nomor HP";
            // 
            // lbJenisKelamin
            // 
            this.lbJenisKelamin.AutoSize = true;
            this.lbJenisKelamin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbJenisKelamin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJenisKelamin.Location = new System.Drawing.Point(55, 221);
            this.lbJenisKelamin.Name = "lbJenisKelamin";
            this.lbJenisKelamin.Size = new System.Drawing.Size(95, 19);
            this.lbJenisKelamin.TabIndex = 5;
            this.lbJenisKelamin.Text = "Jenis Kelamin";
           
            // 
            // tbNamaPegawai
            // 
            this.tbNamaPegawai.BackColor = System.Drawing.Color.Salmon;
            this.tbNamaPegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamaPegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNamaPegawai.Location = new System.Drawing.Point(54, 187);
            this.tbNamaPegawai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNamaPegawai.Name = "tbNamaPegawai";
            this.tbNamaPegawai.Size = new System.Drawing.Size(244, 25);
            this.tbNamaPegawai.TabIndex = 4;
            
            // 
            // lbNamaPegawai
            // 
            this.lbNamaPegawai.AutoSize = true;
            this.lbNamaPegawai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNamaPegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNamaPegawai.Location = new System.Drawing.Point(55, 165);
            this.lbNamaPegawai.Name = "lbNamaPegawai";
            this.lbNamaPegawai.Size = new System.Drawing.Size(102, 19);
            this.lbNamaPegawai.TabIndex = 3;
            this.lbNamaPegawai.Text = "Nama Pegawai";
          
            // 
            // tbKodePegawai
            // 
            this.tbKodePegawai.BackColor = System.Drawing.Color.Salmon;
            this.tbKodePegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKodePegawai.Location = new System.Drawing.Point(54, 134);
            this.tbKodePegawai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKodePegawai.Name = "tbKodePegawai";
            this.tbKodePegawai.Size = new System.Drawing.Size(244, 23);
            this.tbKodePegawai.TabIndex = 2;
            
            // 
            // lbKodePegawai
            // 
            this.lbKodePegawai.AutoSize = true;
            this.lbKodePegawai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbKodePegawai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKodePegawai.Location = new System.Drawing.Point(55, 112);
            this.lbKodePegawai.Name = "lbKodePegawai";
            this.lbKodePegawai.Size = new System.Drawing.Size(97, 19);
            this.lbKodePegawai.TabIndex = 1;
            this.lbKodePegawai.Text = "Kode Pegawai";
            
            // 
            // lbJudulInputPegawai
            // 
            this.lbJudulInputPegawai.AutoSize = true;
            this.lbJudulInputPegawai.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulInputPegawai.Location = new System.Drawing.Point(420, 58);
            this.lbJudulInputPegawai.Name = "lbJudulInputPegawai";
            this.lbJudulInputPegawai.Size = new System.Drawing.Size(112, 30);
            this.lbJudulInputPegawai.TabIndex = 0;
            this.lbJudulInputPegawai.Text = "PEGAWAI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SeaShell;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(621, 424);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 23);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaShell;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(701, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SeaShell;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(781, 424);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(74, 23);
            this.btnTambah.TabIndex = 23;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(861, 424);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Salmon;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(861, 34);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(83, 32);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormInputPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 496);
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisi;
    }
}