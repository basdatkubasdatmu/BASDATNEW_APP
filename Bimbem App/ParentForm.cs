using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            this.lblGreetings.Text = "Admin!";
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            LoginAplikasi();
        }

        private void LoginAplikasi()
        {
           
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void jadwalSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalKelasSiswa.AutoGenerateColumns = false;
            dgvJadwalKelasSiswa.DataSource = da.getJadwalKelasByID(noSiswaLogin);
            dgvJadwalUjian.AutoGenerateColumns = false;
            dgvJadwalUjian.DataSource = da.getAllUjian();

        }
        public string noPegawaiLogin;

        public string noSiswaLogin;

        private void jadwalKelasSiswa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.LoginAplikasi();
        }
    }
}
