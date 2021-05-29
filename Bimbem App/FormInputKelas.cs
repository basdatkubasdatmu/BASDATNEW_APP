using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormInputKelas : Form
    {
        public FormInputKelas()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataAccess da = new DataAccess();
            // Ganti yg ini (dgv sama da.get)
            dgvKelas.AutoGenerateColumns = false;
            dgvKelas.DataSource = da.getAllKelas();
        }

        public void txtKosong()
        {
            // Ganti atau tambah yg ini
            tbNomorKelas.Text = "";
            tbNamaKelas.Text = "";
            tbKuotaKelas.Text = "";
            tbBiayaKelas.Text = "";
            checkedListBox1.Text = "";
        }

        // Enable Button simpan, batal, dan textbox
        private void btnEnable()
        {
            // Ganti atau tambah yg ini
            tbNomorKelas.Enabled = true;
            tbNamaKelas.Enabled = true;
            tbKuotaKelas.Enabled = true;
            tbBiayaKelas.Enabled = true;
            checkedListBox1.Enabled = true;

            // Ini jangan diganti
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
        }

        // Disable Button simpan, batal, dan textbox

        private void btnDisable()
        {
            // Ganti atau tambah yg ini
            tbNomorKelas.Enabled = false;
            tbNamaKelas.Enabled = false;
            tbKuotaKelas.Enabled = false;
            tbBiayaKelas.Enabled = false;
            checkedListBox1.Enabled = false;

            // Ini jangan diganti
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
        }

        // Load Form
        private void FormInputKelas_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDisable();
        }

        //button home
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEdit)
            {
                // Sesuaiin sama form temen-temen
                da.updateDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, checkedListBox1.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sesuaiin sama form temen-temen
                da.insertDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, checkedListBox1.Text);

                // Ini jangan diganti
                this.txtKosong();
                MessageBox.Show("Data telah ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnDisable();
            this.LoadData();
        }

        // Button Edit

        public bool isEdit;

        // boleh diganti
        public string selectedKodeKelas;

        //button edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            DataAccess da = new DataAccess();

            // Edit ini (dgv, da.get, txtBOX nya, dan yang didalam dt.Rows)
            if (dgvKelas.SelectedRows.Count > 0)
            {
                selectedKodeKelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = da.getTableJadwalKelasByID(selectedKodeKelas);

                tbNomorKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                tbNamaKelas.Text = dt.Rows[0]["nama"].ToString();
                tbBiayaKelas.Text = dt.Rows[0]["biaya"].ToString();
                tbKuotaKelas.Text = dt.Rows[0]["kuota"].ToString();
                checkedListBox1.Text = dt.Rows[0]["fasilitas"].ToString();
            }
            tbNomorKelas.ReadOnly = true;
            this.btnEnable();
        }

        //button hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (dgvKelas.SelectedRows.Count > 0)
            {
                // Sesuaiin sama yang diatas
                selectedKodeKelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataKelas(selectedKodeKelas);

                MessageBox.Show("Data telah dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
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
            this.LoadData();
        }     
    }
}
