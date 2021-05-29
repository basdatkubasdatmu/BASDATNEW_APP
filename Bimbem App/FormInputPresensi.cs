using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputPresensi : Form
    {
        public bool isEdit;

        public FormInputPresensi()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvPresensi.AutoGenerateColumns = false;
            dgvPresensi.DataSource = da.getAllPresensi();
        }

        // Kosongin textbox
        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            txtkodeJadwalSiswa.Text = "";
            txtNoSiswa.Text = "";
            txtNamaSiswa.Text = "";
            dtpPresensi.Text = "";
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            txtkodeJadwalSiswa.Enabled = true;
            txtNoSiswa.Enabled = true;
            txtNamaSiswa.Enabled = true;
            dtpPresensi.Enabled = true;

            // Ini jangan diganti
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            txtkodeJadwalSiswa.Enabled = false;
            txtNoSiswa.Enabled = false;
            txtNamaSiswa.Enabled = false;
            dtpPresensi.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        /// <summary>
        ///  Mulai data Load
        /// </summary>

        // Load Form
        private void FormInputPresensi_Load(object sender, EventArgs e)
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
                da.updateDataPresensi(txtkodeJadwalSiswa.Text, txtNoSiswa.Text, txtNamaSiswa.Text, dtpPresensi.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataPresensi(txtkodeJadwalSiswa.Text, txtNoSiswa.Text, txtNamaSiswa.Text, dtpPresensi.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }
       
        // Button Edit

        // boleh diganti
        public string selectedKodeJadwalSiswa;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvPresensi.SelectedRows.Count > 0)
            {
                selectedKodeJadwalSiswa = dgvPresensi.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTablePresensiByID(selectedKodeJadwalSiswa);

                txtkodeJadwalSiswa.Text = dt.Rows[0]["kodejadwalsiswa"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtNamaSiswa.Text = dt.Rows[0]["namasiswa"].ToString();
                dtpPresensi.Text = dt.Rows[0]["waktupresensi"].ToString();
            }
            txtkodeJadwalSiswa.ReadOnly = true;
            this.btnEnable();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvPresensi.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedKodeJadwalSiswa = dgvPresensi.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPresensi(selectedKodeJadwalSiswa);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

    }
}
