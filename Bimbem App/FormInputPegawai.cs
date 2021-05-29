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

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvPegawai.AutoGenerateColumns = false;
            dgvPegawai.DataSource = da.getAllPegawai();
        }


        // Kosongin textbox
        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            tbKodePegawai.Text = "";
            tbNamaPegawai.Text = "";
           
            tbNomorHP.Text = "";
            tbEmail.Text = "";
            tbPosisi.Text = "";
            string jeniskelamin = "";

            if (jeniskelamin == "Laki-laki")
            {
                rbLakiLaki.Checked = true;
            }
            else if (jeniskelamin == "Perempuan")
            {
                rbPerempuan.Checked = true;
            }
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            tbKodePegawai.Enabled = true;
            tbNamaPegawai.Enabled = true;
            rbPerempuan.Enabled = true;
            rbLakiLaki.Enabled = true;
            tbNomorHP.Enabled = true;
            tbEmail.Enabled = true;
            tbPosisi.Enabled = true;

            // Ini jangan diganti
            btSimpan.Enabled = true;
            btBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            tbKodePegawai.Enabled = false;
            tbNamaPegawai.Enabled = false;
            rbPerempuan.Enabled = false;
            rbLakiLaki.Enabled = false;
            tbNomorHP.Enabled = false;
            tbEmail.Enabled = false;
            tbPosisi.Enabled = false;

            // Ini jangan diganti
            btSimpan.Enabled = false;
            btBatal.Enabled = false;
        }


       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvPegawai.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedNoPegawai = dgvPegawai.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPegawai(selectedNoPegawai);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputPegawai_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        public bool isEdit;

        // boleh diganti
        public string selectedNoPegawai;
        private void btSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string jeniskelamin = " ";
            if (rbLakiLaki.Checked)
            {
                jeniskelamin = "Laki-laki";
            }
            else if (rbPerempuan.Checked)
            {
                jeniskelamin = "Perempuan";
            }

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jeniskelamin, tbNomorHP.Text, tbEmail.Text, tbPosisi.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jeniskelamin, tbNomorHP.Text, tbEmail.Text, tbPosisi.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvPegawai.SelectedRows.Count > 0)
            {
                selectedNoPegawai = dgvPegawai.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableDataPegawaiByID(selectedNoPegawai);

                tbKodePegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                tbNamaPegawai.Text = dt.Rows[0]["nama"].ToString();
                tbNomorHP.Text = dt.Rows[0]["nohp"].ToString();
                tbEmail.Text = dt.Rows[0]["email"].ToString();
                tbPosisi.Text = dt.Rows[0]["posisi"].ToString();
                string jeniskelamin = dt.Rows[0]["jeniskelamin"].ToString();

                if (jeniskelamin == "Laki-laki")
                {
                    rbLakiLaki.Checked = true;
                }
                else if (jeniskelamin == "Perempuan")
                {
                    rbPerempuan.Checked = true;
                }
            }
            tbKodePegawai.ReadOnly = true;
            this.btnEnable();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }
    }
}
