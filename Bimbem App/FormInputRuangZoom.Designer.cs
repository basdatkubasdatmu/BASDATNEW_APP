
namespace Bimbem_App
{
    partial class FormInputRuangZoom
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
            this.pnlRuangZoom = new System.Windows.Forms.Panel();
            this.dgvRuangZoom = new System.Windows.Forms.DataGridView();
            this.kodezoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtPasscodeRuangZoom = new System.Windows.Forms.TextBox();
            this.txtIdMeetingRuangZoom = new System.Windows.Forms.TextBox();
            this.passcodeRuangZoom = new System.Windows.Forms.Label();
            this.idMeetingRuangZoom = new System.Windows.Forms.Label();
            this.txtLinkRuangZoom = new System.Windows.Forms.TextBox();
            this.linkRuangZoom = new System.Windows.Forms.Label();
            this.txtKodeZoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputRuangZoom = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRuangZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuangZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bimbem_App.Properties.Resources.bimbel_ayy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRuangZoom
            // 
            this.pnlRuangZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRuangZoom.Controls.Add(this.dgvRuangZoom);
            this.pnlRuangZoom.Location = new System.Drawing.Point(26, 284);
            this.pnlRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRuangZoom.Name = "pnlRuangZoom";
            this.pnlRuangZoom.Size = new System.Drawing.Size(830, 353);
            this.pnlRuangZoom.TabIndex = 2;
            // 
            // dgvRuangZoom
            // 
            this.dgvRuangZoom.AllowUserToAddRows = false;
            this.dgvRuangZoom.AllowUserToDeleteRows = false;
            this.dgvRuangZoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRuangZoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRuangZoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuangZoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodezoom,
            this.link,
            this.meetingid,
            this.passcode});
            this.dgvRuangZoom.Location = new System.Drawing.Point(22, 24);
            this.dgvRuangZoom.Name = "dgvRuangZoom";
            this.dgvRuangZoom.RowTemplate.Height = 25;
            this.dgvRuangZoom.Size = new System.Drawing.Size(784, 308);
            this.dgvRuangZoom.TabIndex = 0;
            // 
            // kodezoom
            // 
            this.kodezoom.DataPropertyName = "kodezoom";
            this.kodezoom.HeaderText = "Kode Zoom";
            this.kodezoom.Name = "kodezoom";
            // 
            // link
            // 
            this.link.DataPropertyName = "link";
            this.link.HeaderText = "Link Zoom";
            this.link.Name = "link";
            // 
            // meetingid
            // 
            this.meetingid.DataPropertyName = "meetingid";
            this.meetingid.HeaderText = "Meeting ID";
            this.meetingid.Name = "meetingid";
            // 
            // passcode
            // 
            this.passcode.DataPropertyName = "passcode";
            this.passcode.HeaderText = "Passcode";
            this.passcode.Name = "passcode";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(673, 235);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(72, 37);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(593, 235);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(74, 37);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtPasscodeRuangZoom
            // 
            this.txtPasscodeRuangZoom.BackColor = System.Drawing.Color.Salmon;
            this.txtPasscodeRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPasscodeRuangZoom.Location = new System.Drawing.Point(533, 192);
            this.txtPasscodeRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasscodeRuangZoom.Name = "txtPasscodeRuangZoom";
            this.txtPasscodeRuangZoom.Size = new System.Drawing.Size(212, 29);
            this.txtPasscodeRuangZoom.TabIndex = 4;
            // 
            // txtIdMeetingRuangZoom
            // 
            this.txtIdMeetingRuangZoom.BackColor = System.Drawing.Color.Salmon;
            this.txtIdMeetingRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIdMeetingRuangZoom.Location = new System.Drawing.Point(533, 123);
            this.txtIdMeetingRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMeetingRuangZoom.Name = "txtIdMeetingRuangZoom";
            this.txtIdMeetingRuangZoom.Size = new System.Drawing.Size(212, 29);
            this.txtIdMeetingRuangZoom.TabIndex = 6;
            // 
            // passcodeRuangZoom
            // 
            this.passcodeRuangZoom.AutoSize = true;
            this.passcodeRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passcodeRuangZoom.Location = new System.Drawing.Point(533, 169);
            this.passcodeRuangZoom.Name = "passcodeRuangZoom";
            this.passcodeRuangZoom.Size = new System.Drawing.Size(78, 21);
            this.passcodeRuangZoom.TabIndex = 3;
            this.passcodeRuangZoom.Text = "Passcode";
            // 
            // idMeetingRuangZoom
            // 
            this.idMeetingRuangZoom.AutoSize = true;
            this.idMeetingRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idMeetingRuangZoom.Location = new System.Drawing.Point(534, 100);
            this.idMeetingRuangZoom.Name = "idMeetingRuangZoom";
            this.idMeetingRuangZoom.Size = new System.Drawing.Size(92, 21);
            this.idMeetingRuangZoom.TabIndex = 5;
            this.idMeetingRuangZoom.Text = "Meeting ID";
            // 
            // txtLinkRuangZoom
            // 
            this.txtLinkRuangZoom.BackColor = System.Drawing.Color.Salmon;
            this.txtLinkRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLinkRuangZoom.Location = new System.Drawing.Point(255, 192);
            this.txtLinkRuangZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLinkRuangZoom.Name = "txtLinkRuangZoom";
            this.txtLinkRuangZoom.Size = new System.Drawing.Size(212, 29);
            this.txtLinkRuangZoom.TabIndex = 4;
            // 
            // linkRuangZoom
            // 
            this.linkRuangZoom.AutoSize = true;
            this.linkRuangZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkRuangZoom.Location = new System.Drawing.Point(257, 169);
            this.linkRuangZoom.Name = "linkRuangZoom";
            this.linkRuangZoom.Size = new System.Drawing.Size(39, 21);
            this.linkRuangZoom.TabIndex = 3;
            this.linkRuangZoom.Text = "Link";
            // 
            // txtKodeZoom
            // 
            this.txtKodeZoom.BackColor = System.Drawing.Color.Salmon;
            this.txtKodeZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKodeZoom.Location = new System.Drawing.Point(255, 123);
            this.txtKodeZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeZoom.Name = "txtKodeZoom";
            this.txtKodeZoom.Size = new System.Drawing.Size(212, 29);
            this.txtKodeZoom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(256, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Zoom";
            // 
            // inputRuangZoom
            // 
            this.inputRuangZoom.AutoSize = true;
            this.inputRuangZoom.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputRuangZoom.Location = new System.Drawing.Point(389, 41);
            this.inputRuangZoom.Name = "inputRuangZoom";
            this.inputRuangZoom.Size = new System.Drawing.Size(188, 35);
            this.inputRuangZoom.TabIndex = 0;
            this.inputRuangZoom.Text = "RUANG ZOOM";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(879, 284);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(87, 42);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(879, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 42);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(879, 380);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(87, 42);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(879, 428);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 42);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(879, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 42);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // FormInputRuangZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 665);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtPasscodeRuangZoom);
            this.Controls.Add(this.txtKodeZoom);
            this.Controls.Add(this.txtIdMeetingRuangZoom);
            this.Controls.Add(this.inputRuangZoom);
            this.Controls.Add(this.passcodeRuangZoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idMeetingRuangZoom);
            this.Controls.Add(this.linkRuangZoom);
            this.Controls.Add(this.txtLinkRuangZoom);
            this.Controls.Add(this.pnlRuangZoom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputRuangZoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputRuangZoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRuangZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuangZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRuangZoom;
        private System.Windows.Forms.TextBox txtPasscodeRuangZoom;
        private System.Windows.Forms.TextBox txtIdMeetingRuangZoom;
        private System.Windows.Forms.Label passcodeRuangZoom;
        private System.Windows.Forms.Label idMeetingRuangZoom;
        private System.Windows.Forms.TextBox txtLinkRuangZoom;
        private System.Windows.Forms.Label linkRuangZoom;
        private System.Windows.Forms.TextBox txtKodeZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inputRuangZoom;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvRuangZoom;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodezoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passcode;
    }
}