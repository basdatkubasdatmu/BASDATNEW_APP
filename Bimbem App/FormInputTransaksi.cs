using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputTransaksi : Form
    {
        public FormInputTransaksi()
        {
            InitializeComponent();
        }

        private void txtKeteranganBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvTransaksi.AutoGenerateColumns = false;
            dgvTransaksi.DataSource = da.getAllPembayaran();
        }
    }
}
