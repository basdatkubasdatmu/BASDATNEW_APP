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

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
