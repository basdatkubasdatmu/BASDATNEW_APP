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
        public FormInputTransaksi()
        {
            InitializeComponent();
        }

        private void txtKeteranganBayar_TextChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditBayar)
            {
                da.updateDataPembayaran(txtPembayaran.Text, txtNoSiswa.Text, txtKodeKelas.Text, txtTglPembayaran.Text, txtKeteranganBayar.Text, "1,000,000");
            }
            else
            {
                da.insertDataPembayaran(txtPembayaran.Text, txtNoSiswa.Text, txtKodeKelas.Text, txtTglPembayaran.Text, txtKeteranganBayar.Text, "1,000,000");
            }
        }
    }
}
