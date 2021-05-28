
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataSiswa = new System.Windows.Forms.Label();
            this.dgvPegawaiSiswa = new System.Windows.Forms.DataGridView();
            this.noPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawaiSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.parent_form;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDataSiswa
            // 
            this.lblDataSiswa.AutoSize = true;
            this.lblDataSiswa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataSiswa.Location = new System.Drawing.Point(429, 127);
            this.lblDataSiswa.Name = "lblDataSiswa";
            this.lblDataSiswa.Size = new System.Drawing.Size(130, 37);
            this.lblDataSiswa.TabIndex = 4;
            this.lblDataSiswa.Text = "Pengajar";
            this.lblDataSiswa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPegawaiSiswa
            // 
            this.dgvPegawaiSiswa.AllowUserToAddRows = false;
            this.dgvPegawaiSiswa.AllowUserToDeleteRows = false;
            this.dgvPegawaiSiswa.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvPegawaiSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPegawaiSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPegawaiSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawaiSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPengajar,
            this.dataGridViewTextBoxColumn4,
            this.nohp,
            this.email});
            this.dgvPegawaiSiswa.GridColor = System.Drawing.Color.Orange;
            this.dgvPegawaiSiswa.Location = new System.Drawing.Point(219, 227);
            this.dgvPegawaiSiswa.Name = "dgvPegawaiSiswa";
            this.dgvPegawaiSiswa.ReadOnly = true;
            this.dgvPegawaiSiswa.RowHeadersWidth = 51;
            this.dgvPegawaiSiswa.RowTemplate.Height = 29;
            this.dgvPegawaiSiswa.Size = new System.Drawing.Size(553, 298);
            this.dgvPegawaiSiswa.TabIndex = 23;
            this.dgvPegawaiSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPegawaiSiswa_CellContentClick);
            // 
            // noPengajar
            // 
            this.noPengajar.DataPropertyName = "nopengajar";
            this.noPengajar.HeaderText = "Nomor Pengajar";
            this.noPengajar.MinimumWidth = 6;
            this.noPengajar.Name = "noPengajar";
            this.noPengajar.ReadOnly = true;
            this.noPengajar.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nama Pengajar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // nohp
            // 
            this.nohp.DataPropertyName = "nohp";
            this.nohp.HeaderText = "No HP";
            this.nohp.MinimumWidth = 6;
            this.nohp.Name = "nohp";
            this.nohp.ReadOnly = true;
            this.nohp.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(859, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 671);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPegawaiSiswa);
            this.Controls.Add(this.lblDataSiswa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formPengajar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.formPengajar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawaiSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataSiswa;
        private System.Windows.Forms.DataGridView dgvPegawaiSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnClose;
    }
}