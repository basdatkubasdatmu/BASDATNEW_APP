﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bimbem_App
{
    public partial class FormMenuPegawai : Form
    {
        public FormMenuPegawai()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDataPegawai_Click(object sender, EventArgs e)
        {
            FormInputJadwalPengajar frmInputJadwalPengajar = new FormInputJadwalPengajar();
            frmInputJadwalPengajar.ShowDialog();
        }
    }
}
