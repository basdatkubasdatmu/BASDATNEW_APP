using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputPegawai : Form
    {
        public FormInputPegawai()
        {
            InitializeComponent();
        }

        private void lbKodePegawai_Click(object sender, EventArgs e)
        {

        }

        private void tbKodePegawai_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNamaPegawai_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaPegawai_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbJenisKelamin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbPosisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPegawai.AutoGenerateColumns = false;
            dgvPegawai.DataSource = da.getAllPegawai();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPegawai.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedNoPegawai = dgvPegawai.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPegawai(SelectedNoPegawai);
            }
        }
    }
}
