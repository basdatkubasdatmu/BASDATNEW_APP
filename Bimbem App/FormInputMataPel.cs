using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputMatpel : Form
    {
        public bool isEditMaPel = false;

        public FormInputMatpel()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditMaPel)
            {
                da.updateDataMatPel(txtKodeMapel.Text, textNamaMapel.Text);
            }
            else
            {
                da.insertDataMapel(txtKodeMapel.Text, textNamaMapel.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvMatpel.AutoGenerateColumns = false;
            dgvMatpel.DataSource = da.getAllMatpel();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvMatpel.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodePelajaran = dgvMatpel.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataMatpel(SelectedKodePelajaran);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
