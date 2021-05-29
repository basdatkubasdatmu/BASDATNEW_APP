using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputUjian : Form
    {
        public bool isEditUjian = false;

        public string selectedkodeujian;

        public FormInputUjian()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            DataAccess da = new DataAccess();
            dgvUjian.AutoGenerateColumns = false;
            dgvUjian.DataSource = da.getAllUjian();
        }

        public void txtKosong()
        {
            txtKodeUjian.Text = "";
            txtNamaUjian.Text = "";
            txtKodePelajaran.Text = "";
            txtJam.Text = "";
            txtDurasi.Text = "";
            txtTanggal.Text = "";
        }

        private void btnEnable()
        {
            txtKodeUjian.Enabled = true;
            txtNamaUjian.Enabled = true;
            txtKodePelajaran.Enabled = true;
            txtJam.Enabled = true;
            txtDurasi.Enabled = true;
            txtTanggal.Enabled = true;

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnDisable()
        {
            txtKodeUjian.Enabled = false;
            txtNamaUjian.Enabled = false;
            txtKodePelajaran.Enabled = false;
            txtJam.Enabled = false;
            txtDurasi.Enabled = false;
            txtTanggal.Enabled = false;

            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvUjian.AutoGenerateColumns = false;
            dgvUjian.DataSource = da.getAllUjian();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvUjian.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeUjian = dgvUjian.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalUjian(SelectedKodeUjian);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditUjian)
            {
                da.updateDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, txtTanggal.Text, txtJam.Text, txtDurasi.Text);

                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                da.insertDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, txtTanggal.Text, txtJam.Text, txtDurasi.Text);

                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        private void btnMenuUtama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputUjian_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditUjian = true;
            DataAccess da = new DataAccess();

            if (dgvUjian.SelectedRows.Count > 0)
            {
                selectedkodeujian = dgvUjian.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalSiswaByID(selectedkodeujian);

                txtKodeUjian.Text = dt.Rows[0]["kodeujian"].ToString();
                txtNamaUjian.Text = dt.Rows[0]["nama"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                txtJam.Text = dt.Rows[0]["jammulai"].ToString();
                txtDurasi.Text = dt.Rows[0]["durasi"].ToString();
                txtTanggal.Text = dt.Rows[0]["tanggal"].ToString();
            }

            txtKodeUjian.ReadOnly = true;
            this.btnEnable();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEditUjian = false;
            this.btnEnable();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }
    }
}
