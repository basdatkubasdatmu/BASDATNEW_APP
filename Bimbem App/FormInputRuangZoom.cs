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
    }
}
