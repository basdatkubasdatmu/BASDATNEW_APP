using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class formInputSiswa : Form
    {
        public formInputSiswa()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvSiswa.AutoGenerateColumns = false;
            dgvSiswa.DataSource = da.getAllSiswa();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (dgvSiswa.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedNoSiswa = dgvSiswa.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataSiswa(SelectedNoSiswa);
            }
        }
    }
}
