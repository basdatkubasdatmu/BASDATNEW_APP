using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputJadwalSiswa : Form
    {
        public FormInputJadwalSiswa()
        {
            InitializeComponent();
        }

        // General syntax
        public string selectedKodeJadwalSiswa;
        
        // Load data, ganti dgv sama getnya!

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            dgvJadwalSiswa.AutoGenerateColumns = false;
            dgvJadwalSiswa.DataSource = da.getAllJadwalSiswa();
        }


        // Kosongin textbox
        public void txtKosong()
        {
            txtKodeJadwalSiswa.Text = "";
            txtNoSiswa.Text = "";
            txtKodeJadwalPengajar.Text = "";
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            txtKodeJadwalPengajar.Enabled = true;
            txtKodeJadwalSiswa.Enabled = true;
            txtNoSiswa.Enabled = true;
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            txtKodeJadwalPengajar.Enabled = false;
            txtKodeJadwalSiswa.Enabled = false;
            txtNoSiswa.Enabled = false;
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        /// <summary>
        ///  Mulai data Load
        /// </summary>

        // Load Form

        
        private void FormInputJadwalSiswa_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        

        // Button Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save Button
                        
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                da.updateDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                da.insertDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        // Button Edit

        public bool isEdit;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();
            if (dgvJadwalSiswa.SelectedRows.Count > 0)
            {
                selectedKodeJadwalSiswa = dgvJadwalSiswa.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalSiswaByID(selectedKodeJadwalSiswa);

                txtKodeJadwalSiswa.Text = dt.Rows[0]["kodejadwalsiswa"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtKodeJadwalPengajar.Text = dt.Rows[0]["kodejadwalpengajar"].ToString();
            }
            txtKodeJadwalSiswa.ReadOnly = true;            
            this.btnEnable();
        }

        // Button tambah

        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }

        private void dgvJadwalSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        // Button Batal

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }

        // Button Refresh

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        // Button Hapus

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvJadwalSiswa.SelectedRows.Count > 0)
            {
                selectedKodeJadwalSiswa = dgvJadwalSiswa.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalSiswa(selectedKodeJadwalSiswa);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}
