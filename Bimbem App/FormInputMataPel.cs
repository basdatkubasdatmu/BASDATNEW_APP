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
        public FormInputMatpel()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
