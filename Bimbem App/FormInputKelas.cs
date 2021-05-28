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
        public bool isEditKelas = false;

        public FormInputKelas()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvKelas.AutoGenerateColumns = false;
            dgvKelas.DataSource = da.getAllKelas();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKelas.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string SelectedKodeKelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataKelas(SelectedKodeKelas);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            string fasilitas = "";

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    if (x == 0)
                    {
                        fasilitas = checkedListBox1.CheckedItems[x].ToString();
                    }
                    else
                    {
                        fasilitas = fasilitas + ", " + checkedListBox1.CheckedItems[x].ToString();
                    }
                }
            }

            if (isEditKelas)
            {
                da.updateDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, fasilitas);
            }
            else
            {
                da.insertDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, fasilitas);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
