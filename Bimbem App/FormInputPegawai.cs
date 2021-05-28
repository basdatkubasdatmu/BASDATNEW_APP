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
        public bool isEditPegawai = false;

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

        private void btSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            string jnsKelamin = "";
            if (rbLakiLaki.Checked)
            {
                jnsKelamin = "Laki-laki";
            }
            else if (rbPerempuan.Checked)
            {
                jnsKelamin = "Perempuan";
            }

            if (isEditPegawai)
            {
                da.updateDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jnsKelamin, tbNomorHP.Text, tbEmail.Text, tbPosisi.Text);
            }
            else
            {
                da.insertDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jnsKelamin, tbNomorHP.Text, tbEmail.Text, tbPosisi.Text);
            }
        }
    }
}
