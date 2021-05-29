using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Bimbem_App
{
    public class DataAccess
    {
        string strConnString = "Server = localhost; Port = 5432; User id = postgres; Password = kiwkiwbgtlho; Database = bimbel";

        // Jadwal Kelas Siswa

        public DataTable getNilaiByID(string nosiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT s.nama as nama, s.kodekelas as kodekelas, u.nama as namaujian, n.nilai as nilai, u.tanggal as tanggal  FROM ((siswa s FULL OUTER JOIN nilai n USING(nosiswa)) FULL OUTER JOIN pengajar p USING(nopengajar))  FULL OUTER JOIN pegawai pw USING(nopegawai)  FULL OUTER JOIN matapelajaran m ON n.kodepelajaran = m.kodepelajaran FULL OUTER JOIN ujian u USING(kodeujian) WHERE s.nosiswa = '" + nosiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        public DataTable getJadwalKelasByID(string nosiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT jp.tanggal as tanggal, p.nama as pengajar , mp.pelajaran as pelajaran, jp.jammulai as jammulai, jp.durasi as durasi, rz.link as zoom, s.nosiswa as nosiswa FROM(jadwalpengajar jp JOIN jadwalsiswa js USING(kodejadwalpengajar) JOIN matapelajaran mp USING(kodepelajaran)) JOIN (jadwalsiswa JOIN siswa s USING(nosiswa)) USING(kodejadwalpengajar) JOIN ruangzoom rz USING(kodezoom) JOIN pengajar USING(nopengajar) JOIN pegawai p USING(nopegawai) WHERE s.nosiswa = '" + nosiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        // Get siswa by id
        public DataTable getSiswaByID(string nosiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from siswa where nosiswa = '" + nosiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        // Get pegawai By ID

        public DataTable getPegawaiByID(string nopegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pegawai where nopegawai = '" + nopegawai + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        public DataTable getPegawaiSiswa()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT pj.nopengajar as nopengajar, pw.nama as nama, pw.nohp, pw.email FROM pengajar pj JOIN pegawai pw USING(nopegawai);";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data pegawai gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // GET ALLLLL

        public DataTable getAllJadwalSiswa()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalsiswa";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jadwal siswa gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllJadwalPengajar()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalpengajar";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jadwal pengajar gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllKelas()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from kelas";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kelas gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllMatpel()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from matapelajaran";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar mata pelajaran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllNilai()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT n.kodeujian, s.nosiswa, s.nama, p.nama, n.kodepelajaran, n.nilai FROM (nilai n JOIN siswa s USING(nosiswa)) JOIN (nilai JOIN(pegawai p JOIN pengajar png USING(nopegawai)) USING(nopengajar))  USING(kodeujian)";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data nilai gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPegawai()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pegawai";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data pegawai gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPembayaran()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pembayaran";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data transaksi pembayaran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPengajar()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pengajar";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar pengajar gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPresensi()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select p.kodejadwalsiswa, p.nosiswa, s.nama, p.waktupresensi From(presensisiswa p JOIN siswa s USING(nosiswa))";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar kehadiran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllZoom()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ruangzoom";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar ruang zoom gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllSiswa()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from siswa";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllUjian()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ujian";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar ujian gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        // Get .... ByID

        public DataTable getTablePembayaranByID(string kodepembayaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pembayaran where kodepembayaran = '" + kodepembayaran + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableJadwalPengajarByID(string kodejadwalpengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalpengajar where kodejadwalpengajar = '" + kodejadwalpengajar + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableJadwalSiswaByID(string kodejadwalsiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalsiswa where kodejadwalsiswa = '" + kodejadwalsiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableJadwalUjianByID(string kodeujian)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ujian where kodeujian = '" + kodeujian + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableJadwalKelasByID(string kodekelas)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from kelas where kodekelas = '" + kodekelas + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableMatPelByID(string kodepelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from matapelajaran where kodepelajaran = '" + kodepelajaran + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableDataNilaiByID(string kodeujian)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from nilai where kodeujian = '" + kodeujian + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableDataPegawaiByID(string nopegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pegawai where nopegawai = '" + nopegawai + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableRuangZoomByID(string kodezoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ruangzoom where kodezoom = '" + kodezoom + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTablePengajarByID(string nopengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * pengajar where nopengajar = '" + nopengajar + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable getTableSiswaByID(string nosiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from siswa where nosiswa = '" + nosiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        //get data presensi
        public DataTable getTablePresensiByID(string kodejadwalsiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from presensisiswa where kodejadwalsiswa = '" + kodejadwalsiswa + "';";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();


                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        // HAPUS DATA

        public void hapusDataJadwalPengajar(string kodejadwalpengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from jadwalpengajar 
                                where kodejadwalpengajar = '{0}'", kodejadwalpengajar);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataJadwalSiswa(string kodejadwalsiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from jadwalsiswa 
                                where kodejadwalsiswa = '{0}'", kodejadwalsiswa);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataSiswa(string nosiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from siswa 
                                where nosiswa = '{0}'", nosiswa);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataPengajar(string nopengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from pengajar 
                                where nopengajar = '{0}';", nopengajar);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataPegawai(string nopegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from pegawai 
                                where nopegawai = '{0}';", nopegawai);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataKelas(string kodekelas)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from kelas 
                                where kodekelas = '{0}';", kodekelas);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        //hapus data presensi
        public void hapusDataPresensi(string kodejadwalsiswa)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from presensisiswa 
                                where kodejadwalsiswa = '{0}';", kodejadwalsiswa);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataJadwalUjian(string kodeujian)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from ujian 
                                where kodeujian = '{0}';", kodeujian);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataNilai(string kodeujian)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from nilai 
                                where kodeujian = '{0}';", kodeujian);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataRuangZoom(string kodezoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from ruangzoom 
                                where kodezoom = '{0}';", kodezoom);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataMatpel(string kodepelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from matapelajaran 
                                where kodepelajaran = '{0}';", kodepelajaran);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void hapusDataPembayaran(string kodepembayaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"delete from pembayaran 
                                where kodepembayaran = '{0}';", kodepembayaran);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        //UPDATE DATA
        //update data presensi
        public void updateDataPresensi(string kodejadwalsiswa, string nosiswa, string waktupresensi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update presensisiswa set
                                nosiswa = '{0}', waktupresensi = '{1}' 
                                where kodejadwalsiswa = '{2}';", nosiswa, waktupresensi, kodejadwalsiswa);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataPengajar(string nopengajar, string kodepelajaran, string nopegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update pengajar set
                            nopegawai = '{0}', kodepelajaran  = '{1}' 
                            where nopengajar = '{2}';", nopegawai, kodepelajaran, nopengajar);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataSiswa(string nosiswa, string nama, string jeniskelamin, string kodekelas, string nohp, string email, string asaldaerah)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update siswa set
                            nama = '{0}', jeniskelamin = '{1}', kodekelas = '{2}', nohp = '{3}', email = '{4}', asaldaerah = '{5}' 
                            where nosiswa = '{6}';", nama, jeniskelamin, kodekelas, nohp, email, asaldaerah, nosiswa);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataJadwalPengajar(string kodejadwalpengajar, string kodekelas, string nopengajar, string kodepelajaran, string tanggal, string jammulai, string durasi, string kodezoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update jadwalpengajar set
                           kodekelas = '{0}', nopengajar = '{1}', kodepelajaran = '{2}', tanggal = '{3}', jammulai = '{4}', durasi = '{5}', kodezoom = '{6}' 
                           where kodejadwalpengajar = '{7}';", kodekelas, nopengajar, kodepelajaran, tanggal, jammulai, durasi, kodezoom, kodejadwalpengajar);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataJadwalSiswa(string kodejadwalsiswa, string nosiswa, string kodejadwalpengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update jadwalsiswa set
                            nosiswa = '{0}', kodejadwalpengajar = '{1}' 
                            where kodejadwalsiswa = '" + kodejadwalsiswa + "';", nosiswa, kodejadwalpengajar);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataJadwalUjian(string kodeujian, string nama, string kodepelajaran, string tanggal, string jammulai, string durasi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update ujian set
                            nama = '{0}', kodepelajaran = '{1}', tanggal = '{2}', jammulai = '{3}', durasi = '{4}' 
                            where kodeujian = '" + kodeujian + "';", nama, kodepelajaran, tanggal, jammulai, durasi);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataKelas(string kodekelas, string nama, string biaya, string kuota, string fasilitas)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update kelas set
                            nama = '{0}', biaya = '{1}', kuota = '{2}', fasilitas = '{3}' 
                            where kodekelas = '" + kodekelas + "';", nama, biaya, kuota, fasilitas);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataMatPel(string kodepelajaran, string pelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update matapelajaran set
                            pelajaran = '{0}' 
                            where kodepelajaran = '" + kodepelajaran + "';", pelajaran);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataNilai(string kodeujian, string nosiswa, string nopengajar, string kodepelajaran, string nilai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update nilai set
                            nosiswa = '{0}', nopengajar = '{1}', kodepelajaran = '{2}', nilai = '{3}' 
                            where kodeujian = '" + kodeujian + "';", nosiswa, nopengajar, kodepelajaran, nilai);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataPegawai(string nopegawai, string nama, string jeniskelamin, string nohp, string email, string posisi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update pegawai set
                            nama = '{0}', jeniskelamin = '{1}', nohp = '{2}', email = '{3}', posisi = '{4}' 
                            where nopegawai = '" + nopegawai + "';", nama, jeniskelamin, nohp, email, posisi);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataRuangZoom(string kodezoom, string link, string meetingid, string passcode)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update ruangzoom set
                            link = '{0}', meetingid = '{1}', kodepelajaran = '{2}', nilai = '{3}' 
                            where kodezoom = '" + kodezoom + "';", link, meetingid, passcode);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDataPembayaran(string kodepembayaran, string nosiswa, string kodekelas, string tanggalpembayaran, string status, string jumlah)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"update pembayaran set nosiswa = '{0}', kodekelas = '{1}', tanggalpembayaran = '{2}',
                                status = '{3}', jumlah = '{4}' where kodepembayaran = '" + kodepembayaran + "';", nosiswa, kodekelas,
                                    tanggalpembayaran, status, jumlah);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        //insert
        public void insertDataJadwalPengajar(string kodeJadwalPengajar, string kodeKelas, string noPengajar, string kodePelajaran, string tanggal, string jamMulai, string durasi, string kodeZoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into jadwalpengajar(kodejadwalpengajar, kodekelas, nopengajar, kodepelajaran, tanggal, jammulai, durasi, kodezoom) values('" + kodeJadwalPengajar + "', '" + kodeKelas + "', '" + noPengajar + "', '" + kodePelajaran + "', '" + tanggal + "', '" + jamMulai + "', '" + durasi + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataJadwalSiswa(string kodeJadwalSiswa, string noSiswa, string kodeJadwalPengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into jadwalsiswa(kodejadwalsiswa, nosiswa, kodejadwalpengajar) values('" + kodeJadwalSiswa + "', '" + noSiswa + "', '" + kodeJadwalPengajar + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataKelas(string kodeKelas, string nama, string biaya, string kuota, string fasilitas)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into kelas(kodekelas, nama, biaya, kuota, fasilitas) values('" + kodeKelas + "', '" + nama + "', '" + biaya + "', '" + kuota + "', '" + fasilitas + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataMapel(string kodePelajaran, string pelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into matpel(kodepelajaran, pelajaran) values('" + kodePelajaran + "', '" + pelajaran + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataNilai(string kodeUjian, string nosiswa, string noPengajar, string kodePelajaran, string nilai)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into nilai(kodeujian, nosiswa, nopengajar, kodepelajaran, nilai) values('" + kodeUjian + "', '" + nosiswa + "', '" + noPengajar + "', '" + kodePelajaran + "', '" + nilai + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataPegawai(string noPegawai, string nama, string jenisKelamin, string noHP, string email, string posisi)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into pegawai(nopegawai, nama, jeniskelamin, nohp, email, posisi) values('" + noPegawai + "', '" + nama + "', '" + jenisKelamin + "', '" + noHP + "', '" + email + "', '" + posisi + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataPengajar(string noPengajar, string nopegawai, string kodePelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into pengajar(nopengajar, nopegawai, kodePelajaran) values('" + noPengajar + "', '" + nopegawai + "', '" + kodePelajaran + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataPresensi(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into presensi(kodejadwalsiswa, nosiswa, waktupresensi) values('" + kodeJadwalSiswa + "', '" + noSiswa + "', '" + waktuPresensi + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataRuang(string kodeZoom, string link, string idMeeting, string passcode)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into ruangzoom(kodezoom, link, meetingid, passcode) values('" + kodeZoom + "', '" + link + "', '" + idMeeting + "', '" + passcode + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataSiswa(string noSiswa, string nama, string jenisKelamin, string kodeKelas, string noHP, string email, string asalDaerah)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into siswa(nosiswa, nama, jeniskelamin, kodekelas, nohp, email, asaldaerah) values('" + noSiswa + "', '" + nama + "', '" + jenisKelamin + "', '" + kodeKelas + "', '" + noHP + "', '" + email + "', '" + asalDaerah + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataPembayaran(string kodePembayaran, string noSiswa, string kodeKelas, string tanggalPembayaran, string status, string jumlah)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into pembayaran(kodepembayaran, nosiswa, kodekelas, tanggalpembayaran, status, jumlah) values('" + kodePembayaran + "', '" + noSiswa + "', '" + kodeKelas + "', '" + tanggalPembayaran + "', '" + status + "', '" + jumlah + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertDataJadwalUjian(string kodeUjian, string nama, string kodePelajaran, string tanggal, string jamMulai, string durasi)
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into ujian(kodeujian, nama, kodepelajaran, tanggal, jammulai, durasi) values('" + kodeUjian + "', '" + nama + "', '" + kodePelajaran + "', '" + tanggal + "', '" + jamMulai + "', '" + durasi + "');";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silahkan coba lagi. Error : '" + ex.Message.ToString() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
