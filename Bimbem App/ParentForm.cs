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
            this.lblGreetings.Text = "Kamu!";
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

        public Boolean isSiswa;

        private void jadwalKelasSiswa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.LoginAplikasi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.jadwalSiswa.Visible = true;
            this.pnlAkademikSiswa.Visible = false;
            this.pnlPengajar.Visible = false;
        }

        private void dgvNilaiSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlAkademikSiswa_Paint(object sender, PaintEventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvNilaiSiswa.AutoGenerateColumns = false;
            FormLogin frmLogin = new FormLogin();
            dgvNilaiSiswa.DataSource = da.getNilaiByID(frmLogin.noSiswaLogin);
            dgvMataPelajaran.AutoGenerateColumns = false;
            dgvMataPelajaran.DataSource = da.getAllMatpel();
        }

        private void btnAkademik_Click(object sender, EventArgs e)
        {
            this.pnlAkademikSiswa.Visible = true;
            this.jadwalSiswa.Visible = false;
            this.pnlPengajar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pnlAkademikSiswa.Visible = false;
            this.jadwalSiswa.Visible = false;
            this.pnlPengajar.Visible = false;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPegawaiSiswa.AutoGenerateColumns = false;
            dgvPegawaiSiswa.DataSource = da.getPegawaiSiswa();
        }

        private void btnPengajar_Click(object sender, EventArgs e)
        {
            this.pnlAkademikSiswa.Visible = false;
            this.jadwalSiswa.Visible = false;
            this.pnlPengajar.Visible = true;
        }
    }
}
