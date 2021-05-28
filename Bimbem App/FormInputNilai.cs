using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputNilai : Form
    {
        public FormInputNilai()
        {
            InitializeComponent();
        }

        private void pctrInputNilai_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvNilai.AutoGenerateColumns = false;
            dgvNilai.DataSource = da.getAllNilai();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvNilai.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeUjian = dgvNilai.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataNilai(SelectedKodeUjian);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
