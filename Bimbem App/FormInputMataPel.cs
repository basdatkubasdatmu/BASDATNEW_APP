using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputMatpel : Form
    {
        public FormInputMatpel()
        {
            InitializeComponent();
        }

        public bool isEdit;

        public string selected;

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            
            dgvMatpel.AutoGenerateColumns = false;
            dgvMatpel.DataSource = da.getAllMatpel();
        }

        public void txtKosong()
        {
            txtKodeMapel.Text = "";
            textNamaMapel.Text = "";
        }

        private void btnEnable()
        {
            txtKodeMapel.Enabled = true;
            textNamaMapel.Enabled = true;

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            textNamaMapel.Enabled = false;
            txtKodeMapel.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                da.updateDataMatPel(txtKodeMapel.Text, textNamaMapel.Text);

                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                da.insertDataMapel(txtKodeMapel.Text, textNamaMapel.Text);

                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvMatpel.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selected = dgvMatpel.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalSiswa(selected);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputMatpel_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvMatpel.SelectedRows.Count > 0)
            {
                selected = dgvMatpel.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableMatPelByID(selected);

                txtKodeMapel.Text = dt.Rows[0]["kodejadwalsiswa"].ToString();
                textNamaMapel.Text = dt.Rows[0]["nosiswa"].ToString();
            }
            txtKodeMapel.ReadOnly = true;
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
