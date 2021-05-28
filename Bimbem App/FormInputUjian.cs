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

        public FormInputUjian()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditUjian)
            {
                da.updateDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, txtTanggal.Text, txtJam.Text, txtDurasi.Text);
            }
            else
            {
                da.insertDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, txtTanggal.Text, txtJam.Text, txtDurasi.Text);
            }
        }

        private void btnMenuUtama_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
