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
    }
}
