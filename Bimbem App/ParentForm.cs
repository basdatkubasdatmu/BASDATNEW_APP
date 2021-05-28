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
        public string noPegawaiLogin;

        public string noSiswaLogin;

        public string isSiswa;

        public ParentForm()
        {
            InitializeComponent();
            
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            LoginAplikasi();
            if (isSiswa == "pegawai")
            {
                FormMenuPegawai frmMenuPegawai = new FormMenuPegawai();
                frmMenuPegawai.ShowDialog();
            }
            
        }

        private void LoginAplikasi()
        {
            
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                isSiswa = frmLogin.isSiswa;
                DataAccess da = new DataAccess();
                if (isSiswa == "siswa")
                {
                    noSiswaLogin = frmLogin.noSiswaLogin;
                    DataTable dt = da.getSiswaByID(noSiswaLogin);
                    this.lblGreetings.Text = dt.Rows[0]["nama"].ToString() + "!";
                    this.pnlMenuSiswa.Visible = true;
                } 
                else if (isSiswa == "pegawai")
                {
                    noPegawaiLogin = frmLogin.noPegawaiLogin;
                    DataTable ds = da.getPegawaiByID(noPegawaiLogin);
                    this.lblGreetings.Text = ds.Rows[0]["nama"].ToString() + "!";
                    this.pnlMenuSiswa.Visible = false;
                }
            } 
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
       

        private void jadwalKelasSiswa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isSiswa = "";
            DialogResult dialogResult = MessageBox.Show("Yakin log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.LoginAplikasi();
                this.pnlMenuSiswa.Visible = false;
                this.closeAllMenuSiswa();
            }
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

        private void menuSiswaIn()
        {
            this.pnlMenuSiswa.Visible = true;
        }

        

        private void closeAllMenuSiswa()
        {
            this.pnlAkademikSiswa.Visible = false;
            this.jadwalSiswa.Visible = false;
            this.pnlPengajar.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isSiswa == "siswa" && this.pnlMenuSiswa.Visible == false)
            {
                this.pnlMenuSiswa.Visible = true;
            }
        }

        private void btnFasilitasPegawai_Click(object sender, EventArgs e)
        {

        }

        private void pnlDataPegawai_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnDataPegawai_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
