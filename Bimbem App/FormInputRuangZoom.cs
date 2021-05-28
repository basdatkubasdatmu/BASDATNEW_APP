using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputRuangZoom : Form
    {
        public FormInputRuangZoom()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvRuangZoom.AutoGenerateColumns = false;
            dgvRuangZoom.DataSource = da.getAllZoom();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvRuangZoom.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeZoom = dgvRuangZoom.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataRuangZoom(SelectedKodeZoom);
            }
        }
    }
}
