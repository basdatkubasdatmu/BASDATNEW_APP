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
        public bool isEditSiswa = false;

        public string selectednosiswa;

        public formInputSiswa()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            dgvSiswa.AutoGenerateColumns = false;
            dgvSiswa.DataSource = da.getAllSiswa();
        }


        // Kosongin textbox
        public void txtKosong()
        {
            txtNoSiswa.Text = "";
            txtKodeKelas.Text = "";
            txtAsalDaerah.Text = "";
            txtEmailSiswa.Text = "";
            txtNoHPSiswa.Text = "";
            textBox1.Text = "";
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

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btnEnable()
        {
            txtNoSiswa.Enabled = true;
            txtNoHPSiswa.Enabled = true;
            txtKodeKelas.Enabled = true;
            txtEmailSiswa.Enabled = true;
            txtAsalDaerah.Enabled = true;
            textBox1.Enabled = true;

            btSimpan.Enabled = true;
            btBatal.Enabled = true;
        }

        private void btnDisable()
        {
            txtNoSiswa.Enabled = false;
            txtNoHPSiswa.Enabled = false;
            txtKodeKelas.Enabled = false;
            txtEmailSiswa.Enabled = false;
            txtAsalDaerah.Enabled = false;
            textBox1.Enabled = false;

            btSimpan.Enabled = false;
            btBatal.Enabled = false;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            string jnsKelamin = " ";
            if (rdLakilaki.Checked)
            {
                jnsKelamin = "Laki-laki";
            }
            else if (rdPerempuan.Checked)
            {
                jnsKelamin = "Perempuan";
            }

            if (isEditSiswa)
            {
                da.updateDataSiswa(txtNoSiswa.Text, textBox1.Text, jnsKelamin, txtKodeKelas.Text, txtNoHPSiswa.Text, txtEmailSiswa.Text, txtAsalDaerah.Text);
            }
            else
            {
                da.insertDataSiswa(txtNoSiswa.Text, textBox1.Text, jnsKelamin, txtKodeKelas.Text, txtNoHPSiswa.Text, txtEmailSiswa.Text, txtAsalDaerah.Text);
            }
        }

        private void btnMenuUtama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formInputSiswa_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            isEditSiswa = false;
            this.btnEnable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditSiswa = true;
            DataAccess da = new DataAccess();

            if (dgvSiswa.SelectedRows.Count > 0)
            {
                selectednosiswa = dgvSiswa.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalSiswaByID(selectednosiswa);

                txtAsalDaerah.Text = dt.Rows[0]["asaldaerah"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtEmailSiswa.Text = dt.Rows[0]["email"].ToString();
                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNoHPSiswa.Text = dt.Rows[0]["nohp"].ToString();
                textBox1.Text = dt.Rows[0]["nama"].ToString();
            }
            txtNoSiswa.ReadOnly = true;
            this.btnEnable();
        }
    }
}
