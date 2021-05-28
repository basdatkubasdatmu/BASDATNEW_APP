using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormJadwalSiswa : Form
    {
        public FormJadwalSiswa()
        {
            InitializeComponent();
        }

        private void dgvJadwalUjian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public string noSiswaLogin;

        public void getValue(string a)
        {
            noSiswaLogin = a.ToString();
        }

        private void FormJadwalSiswa_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalKelasSiswa.AutoGenerateColumns = false;
            dgvJadwalKelasSiswa.DataSource = da.getJadwalKelasByID(noSiswaLogin);
            dgvJadwalUjian.AutoGenerateColumns = false;
            dgvJadwalUjian.DataSource = da.getAllUjian();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
