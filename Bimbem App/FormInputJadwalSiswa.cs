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
        public bool isEditJadwal = false;

        public FormInputJadwalSiswa()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalSiswa.AutoGenerateColumns = false;
            dgvJadwalSiswa.DataSource = da.getAllJadwalSiswa();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(dgvJadwalSiswa.SelectedRows.Count>0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeJadwalSiswa = dgvJadwalSiswa.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalSiswa(SelectedKodeJadwalSiswa);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditJadwal)
            {
                da.updateDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
            } else
            {
                da.insertDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
