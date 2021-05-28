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
        public static string noPegawaiLogin;

        public static string noSiswaLogin;

        public string isSiswa;

        public ParentForm()
        {
            InitializeComponent();
            
        }

        public void ParentForm_Load(object sender, EventArgs e)
        {
            this.LoginAplikasi();
            if (isSiswa == "pegawai")
            {
                FormMenuPegawai frmMenuPegawai = new FormMenuPegawai();
                frmMenuPegawai.ShowDialog();
                this.pnlMenuSiswa.Visible = false;
                this.label1.Visible = false;
                this.lblGreetings.Visible = false;
                
            }
            else if (isSiswa == "siswa")
            {
                this.pnlMenuSiswa.Visible = true;
                this.label1.Visible = true;
                this.lblGreetings.Visible = true;
            }

            
        }

        public void LoginAplikasi()
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
                    this.lblGreetings.Text = "Selamat datang, " + dt.Rows[0]["nama"].ToString() + "!";
                    this.pnlMenuSiswa.Visible = true;
                    this.label1.Visible = true;
                    this.lblGreetings.Visible = true;
                } 
                else if (isSiswa == "pegawai")
                {
                    noPegawaiLogin = frmLogin.noPegawaiLogin;
                    DataTable ds = da.getPegawaiByID(noPegawaiLogin);
                    this.lblGreetings.Text = ds.Rows[0]["nama"].ToString() + "!";
                    this.pnlMenuSiswa.Visible = false;
                    FormMenuPegawai frmMenuPegawai = new FormMenuPegawai();
                    frmMenuPegawai.ShowDialog();
                    this.label1.Visible = false;
                    this.lblGreetings.Visible = false;
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
            FormJadwalSiswa frmJadwalSiswa = new FormJadwalSiswa();
            frmJadwalSiswa.getValue(noSiswaLogin.ToString());
            frmJadwalSiswa.Show();
        }

        private void dgvNilaiSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlAkademikSiswa_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAkademik_Click(object sender, EventArgs e)
        {
            formNilaiUjian frmNilaiUjian = new formNilaiUjian();
            frmNilaiUjian.getValue(noSiswaLogin.ToString());
            frmNilaiUjian.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DataAccess da = new DataAccess();
                
        }

        private void btnPengajar_Click(object sender, EventArgs e)
        {
            formPengajar frmPengajar = new formPengajar();
            frmPengajar.getValue(noSiswaLogin.ToString());
            frmPengajar.Show();
        }

        private void menuSiswaIn()
        {
            this.pnlMenuSiswa.Visible = true;
        }

        

        private void closeAllMenuSiswa()
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formNilaiUjian frmNilaiUjian = new formNilaiUjian();
            frmNilaiUjian.getValue(noSiswaLogin.ToString());
            frmNilaiUjian.Show();
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

        private void btnLogOut2_Click(object sender, EventArgs e)
        {
            isSiswa = "";
            DialogResult dialogResult = MessageBox.Show("Yakin log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                LoginAplikasi();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        public void getValue(string a)
        {

        }

        private void btnJadwalPengajar_Click(object sender, EventArgs e)
        {
            FormInputJadwalPengajar frmJadwalPengajar = new FormInputJadwalPengajar();
            frmJadwalPengajar.MdiParent = this;
            frmJadwalPengajar.Show();
        }
    }
}
