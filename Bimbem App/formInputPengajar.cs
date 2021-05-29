using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class formInputPengajar : Form
    {
        public formInputPengajar()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvPengajar.AutoGenerateColumns = false;
            dgvPengajar.DataSource = da.getAllPengajar();
        }

        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            txtNoPengajar.Text = "";
            txtNoPegawai.Text = "";
            txtKodePelajaran.Text = "";
        }

        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            txtNoPengajar.Enabled = true;
            txtNoPegawai.Enabled = true;
            txtKodePelajaran.Enabled = true;

            // Ini jangan diganti
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            txtNoPengajar.Enabled = false;
            txtNoPegawai.Enabled = false;
            txtKodePelajaran.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void formInputPengajar_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvPengajar.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedNoPengajar = dgvPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPengajar(selectedNoPengajar);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        public bool isEdit;

        
        public string selectedNoPengajar;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvPengajar.SelectedRows.Count > 0)
            {
                selectedNoPengajar = dgvPengajar.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTablePengajarByID(selectedNoPengajar);

                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtNoPegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
            }
            txtNoPengajar.ReadOnly = true;
            this.btnEnable();
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
    }
}
