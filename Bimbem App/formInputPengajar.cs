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
        public bool isEditPengajar = false;

        public formInputPengajar()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPengajar.AutoGenerateColumns = false;
            dgvPengajar.DataSource = da.getAllPengajar();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPengajar.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedNoPengajar = dgvPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPengajar(SelectedNoPengajar);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPengajar)
            {
                da.updateDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            }
            else
            {
                da.insertDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            }
        }
    }
}
