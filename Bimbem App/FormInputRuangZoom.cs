using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputRuangZoom : Form
    {
        public bool isEdit;
        public FormInputRuangZoom()
        {
            InitializeComponent();
        }

        // General syntax

        // Load data, ganti dgv sama getnya!

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvRuangZoom.AutoGenerateColumns = false;
            dgvRuangZoom.DataSource = da.getAllZoom();
        }
        
        // Kosongin textbox
        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            txtKodeZoom.Text = "";
            txtLinkRuangZoom.Text = "";
            txtIdMeetingRuangZoom.Text = "";
            txtPasscodeRuangZoom.Text = "";
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            txtKodeZoom.Enabled = true;
            txtLinkRuangZoom.Enabled = true;
            txtIdMeetingRuangZoom.Enabled = true;
            txtPasscodeRuangZoom.Enabled = true;

            // Ini jangan diganti
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            txtKodeZoom.Enabled = false;
            txtLinkRuangZoom.Enabled = false;
            txtIdMeetingRuangZoom.Enabled = false;
            txtPasscodeRuangZoom.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        /// <summary>
        ///  Mulai data Load
        /// </summary>

        // Load Form
        private void FormInputRuangZoom_Load(object sender, EventArgs e)
        {
            // Copy
            LoadData();
            btnDisable();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataRuangZoom(txtKodeZoom.Text, txtLinkRuangZoom.Text, txtIdMeetingRuangZoom.Text, txtPasscodeRuangZoom.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataRuang(txtKodeZoom.Text, txtLinkRuangZoom.Text, txtIdMeetingRuangZoom.Text, txtPasscodeRuangZoom.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        // Button Edit

        // boleh diganti
        public string selectedKodeZoom;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvRuangZoom.SelectedRows.Count > 0)
            {
                selectedKodeZoom = dgvRuangZoom.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableRuangZoomByID(selectedKodeZoom);

                txtKodeZoom.Text = dt.Rows[0]["kodezoom"].ToString();
                txtLinkRuangZoom.Text = dt.Rows[0]["link"].ToString();
                txtIdMeetingRuangZoom.Text = dt.Rows[0]["meetingid"].ToString();
                txtPasscodeRuangZoom.Text = dt.Rows[0]["passcode"].ToString();
            }
            txtKodeZoom.ReadOnly = true;
            this.btnEnable();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        // Button Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvRuangZoom.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedKodeZoom = dgvRuangZoom.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataRuangZoom(selectedKodeZoom);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // Button tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }

        // Button batal
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }


    }
}
