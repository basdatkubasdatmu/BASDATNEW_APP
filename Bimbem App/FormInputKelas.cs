using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputKelas : Form
    {
        public FormInputKelas()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvKelas.AutoGenerateColumns = false;
            dgvKelas.DataSource = da.getAllKelas();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKelas.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeKelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataKelas(SelectedKodeKelas);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
