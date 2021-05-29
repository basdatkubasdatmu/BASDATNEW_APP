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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvNilai.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                if (dgvNilai.SelectedRows[0].Cells[0].Value.ToString() != null)
                {

                    selected = dgvNilai.SelectedRows[0].Cells[0].Value.ToString();
                }
                da.hapusDataNilai(selected);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputNilai_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvNilai.AutoGenerateColumns = false;
            dgvNilai.DataSource = da.getAllJadwalSiswa();
        }

        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            txtKodeUjian.Text = "";
            txtNoSiswa.Text = "";
            txtNamaSiswa.Text = "";
            txtNoPengajar.Text = "";
            txtKodePelajaran.Text = "";
            txtNilai.Text = "";
        }

        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            txtKodeUjian.Enabled = true;
            txtNamaSiswa.Enabled = true;
            txtNoSiswa.Enabled = true;
            txtNoPengajar.Enabled = true;
            txtKodePelajaran.Enabled = true;
            txtNilai.Enabled = true;

            // Ini jangan diganti
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            txtKodeUjian.Enabled = false;
            txtNamaSiswa.Enabled = false;
            txtNoSiswa.Enabled = false;
            txtNoPengajar.Enabled = false;
            txtKodePelajaran.Enabled = false;
            txtNilai.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        public bool isEdit;

        public string selected;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataNilai(txtKodeUjian.Text, txtNoSiswa.Text, txtNoPengajar.Text, txtKodePelajaran.Text, txtNilai.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataNilai(txtKodeUjian.Text, txtNoSiswa.Text, txtNoPengajar.Text, txtKodePelajaran.Text, txtNilai.Text);

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
            if (dgvNilai.SelectedRows.Count > 0)
            {
                selected = dgvNilai.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableDataNilaiByID(selected);

                txtKodeUjian.Text = dt.Rows[0]["kodeujian"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtNamaSiswa.Text = dt.Rows[0]["namasiswa"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtNilai.Text = dt.Rows[0]["nilai"].ToString();
            }
            txtKodeUjian.ReadOnly = true;
            this.btnEnable();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }
    }
}
