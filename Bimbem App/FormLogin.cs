using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(25, Color.Black);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }

        // Hide password

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                checkBox_Password.Text = "tutup";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                checkBox_Password.Text = "intip";
            }
        }

        // Img exit button
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string noSiswaLogin = "";
        

        public string noPegawaiLogin = "";

        public string isSiswa;

        public Boolean loginCek = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!rbPegawai.Checked && !rbSiswa.Checked) || (txtUsername.Text == "") || (txtPassword.Text == "") )
            {
                MessageBox.Show("Cek semua isian, masi ada yang kosong tuh!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(rbSiswa.Checked)
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    DataAccess da = new DataAccess();
                    DataTable dataSiswa = da.getSiswaByID(txtUsername.Text); //Msalkan loginnya pakai ID pegawai (bisa juga buat kolom username sendiri di database)

                    if (dataSiswa.Rows.Count == 0)
                    {
                        MessageBox.Show("Siswa tersebut tidak terdaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Jika ada pegawai tersebut di tabel pegawai
                        //Cek apakah password-nya benar
                        if (txtPassword.Text == dataSiswa.Rows[0]["nohp"].ToString()) //Misalnya passwordnya pakai nohp (bisa buat kolom password sendiri)
                        {
                            this.noSiswaLogin = txtUsername.Text;
                            this.DialogResult = DialogResult.OK;
                            this.isSiswa = "siswa";
                            this.loginCek = true;
                        }
                        else
                        {
                            MessageBox.Show("Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Silakan masukan username dan password terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            else if (rbPegawai.Checked)
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    DataAccess da = new DataAccess();
                    DataTable dataSiswa = da.getPegawaiByID(txtUsername.Text); //Msalkan loginnya pakai ID pegawai (bisa juga buat kolom username sendiri di database)

                    if (dataSiswa.Rows.Count == 0)
                    {
                        MessageBox.Show("Pegawai tersebut tidak terdaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Jika ada pegawai tersebut di tabel pegawai
                        //Cek apakah password-nya benar
                        if (txtPassword.Text == dataSiswa.Rows[0]["nohp"].ToString()) //Misalnya passwordnya pakai nohp (bisa buat kolom password sendiri)
                        {
                            this.noPegawaiLogin = txtUsername.Text;
                            this.DialogResult = DialogResult.OK;
                            this.isSiswa = "pegawai";
                            this.loginCek = true;
                        }
                        else
                        {
                            MessageBox.Show("Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Silakan masukan username dan password terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (loginCek)
            {
                MessageBox.Show("Log in berhasil!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void rbSiswa_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbPegawai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
