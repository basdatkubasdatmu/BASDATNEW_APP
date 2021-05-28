using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class formNilaiUjian : Form
    {
        public formNilaiUjian()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string noSiswaLogin;

        public void getValue(string a)
        {
            noSiswaLogin = a.ToString();
        }

        private void formSiswa_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvNilaiSiswa.AutoGenerateColumns = false;
            dgvNilaiSiswa.DataSource = da.getNilaiByID(noSiswaLogin);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
