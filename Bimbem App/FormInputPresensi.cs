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
        public FormInputPresensi()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPresensi.AutoGenerateColumns = false;
            dgvPresensi.DataSource = da.getAllPresensi();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPresensi.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeJadwalSiswa = dgvPresensi.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPresensi(SelectedKodeJadwalSiswa);
            }
        }
    }
}
