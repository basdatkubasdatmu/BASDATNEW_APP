using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputJadwalPengajar : Form
    {
        public FormInputJadwalPengajar()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
         
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Kosongin textbox
        public void txtKosong()
        {
            txtKodeJadwalPengajar.Text = "";
            txtKodeKelas.Text = "";
            txtNoPengajar.Text = "";
            txtKodeZoom.Text = "";
            txtKodePelajaran.Text = "";
            txtJamMulai.Text = "";
            maskedTextBox1.Text = " ";
            maskedTextBox2.Text = "";
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            txtKodeJadwalPengajar.Enabled = true;
            txtKodeKelas.Enabled = true;
            txtNoPengajar.Enabled = true;
            txtKodeZoom.Enabled = true;
            txtKodePelajaran.Enabled = true;
            txtJamMulai.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            txtKodeJadwalPengajar.Enabled = false;
            txtKodeKelas.Enabled = false;
            txtNoPengajar.Enabled = false;
            txtKodeZoom.Enabled = false;
            txtKodePelajaran.Enabled = false;
            txtJamMulai.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;

            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }
        
        // form load
        private void FormInputJadwalPengajar_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        //button home
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //button simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        // Button Edit

        public bool isEdit;

        public string selectedKodeJadwalPengajar;

        //button hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvJadwalPengajar.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedKodeJadwalPengajar = dgvJadwalPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalPengajar(selectedKodeJadwalPengajar);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        //button edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvJadwalPengajar.SelectedRows.Count > 0)
            {
                selectedKodeJadwalPengajar = dgvJadwalPengajar.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalPengajarByID(selectedKodeJadwalPengajar);

                txtKodeJadwalPengajar.Text = dt.Rows[0]["kodejadwalpengajar"].ToString();
                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["tanggal"].ToString();
                txtJamMulai.Text = dt.Rows[0]["jammulai"].ToString();
                maskedTextBox2.Text = dt.Rows[0]["durasi"].ToString();
                txtKodeZoom.Text = dt.Rows[0]["kodezoom"].ToString();

            }
            txtKodeJadwalPengajar.ReadOnly = true;
            this.btnEnable();
        }

        //button tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            isEdit = false;
            this.btnEnable();
        }

        //button batal
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.btnDisable();
            this.txtKosong();
        }

        //button refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }
    }
}
