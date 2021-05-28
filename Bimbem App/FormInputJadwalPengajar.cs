using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputJadwalPengajar : Form
    {
        public bool isEditJadwal = false;

        public FormInputJadwalPengajar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvJadwalPengajar.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeJadwalPengajar = dgvJadwalPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalPengajar(SelectedKodeJadwalPengajar);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditJadwal)
            {
                da.updateDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);
            }
            else
            {
                da.insertDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
