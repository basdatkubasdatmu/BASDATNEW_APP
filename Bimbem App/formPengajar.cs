using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class formPengajar : Form
    {
        public formPengajar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPegawaiSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formPengajar_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPegawaiSiswa.AutoGenerateColumns = false;
            dgvPegawaiSiswa.DataSource = da.getPegawaiSiswa();
        }

        public string noSiswaLogin;

        public void getValue(string a)
        {
            noSiswaLogin = a.ToString();
        }
    }
}
