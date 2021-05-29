using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputTransaksi : Form
    {
        public bool isEditBayar = false;

        public string selectedkodebayar;

        public FormInputTransaksi()
        {
            InitializeComponent();
        }

        private void txtKeteranganBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            dgvTransaksi.AutoGenerateColumns = false;
            dgvTransaksi.DataSource = da.getAllPembayaran();
        }


        public void txtKosong()
        {
            txtKodeKelas.Text = "";
            txtKeteranganBayar.Text = "";
            txtNoSiswa.Text = "";
            txtPembayaran.Text = "";
            txtTglPembayaran.Text = "";
        }

        private void btnEnable()
        {
            txtKodeKelas.Enabled = true;
            txtKeteranganBayar.Enabled = true;
            txtNoSiswa.Enabled = true;
            txtPembayaran.Enabled = true;
            txtTglPembayaran.Enabled = true;

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnDisable()
        {
            txtKodeKelas.Enabled = false;
            txtKeteranganBayar.Enabled = false;
            txtNoSiswa.Enabled = false;
            txtPembayaran.Enabled = false;
            txtTglPembayaran.Enabled = false;

            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvTransaksi.AutoGenerateColumns = false;
            dgvTransaksi.DataSource = da.getAllPembayaran();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTransaksi.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodePembayaran = dgvTransaksi.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPembayaran(SelectedKodePembayaran);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditBayar)
            {
                da.updateDataPembayaran(txtPembayaran.Text, txtNoSiswa.Text, txtKodeKelas.Text, txtTglPembayaran.Text, txtKeteranganBayar.Text, "1,000,000");

                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                da.insertDataPembayaran(txtPembayaran.Text, txtNoSiswa.Text, txtKodeKelas.Text, txtTglPembayaran.Text, txtKeteranganBayar.Text, "1,000,000");

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

        private void FormInputTransaksi_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEditBayar = false;
            this.btnEnable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditBayar = true;
            DataAccess da = new DataAccess();
            if (dgvTransaksi.SelectedRows.Count > 0)
            {
                selectedkodebayar = dgvTransaksi.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalSiswaByID(selectedkodebayar);

                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                txtKeteranganBayar.Text = dt.Rows[0]["status"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtPembayaran.Text = dt.Rows[0]["kodepembayaran"].ToString();
                txtTglPembayaran.Text = dt.Rows[0]["tanggalpembayaran"].ToString();
            }
            txtPembayaran.ReadOnly = true;
            this.btnEnable();
        }
    }
}
