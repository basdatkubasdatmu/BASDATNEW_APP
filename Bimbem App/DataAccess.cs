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
                cmd.CommandText = "SELECT n.kodeujian, s.nosiswa, s.nama, png.nopengajar, p.nama, n.kodepelajaran, n.nilai FROM (nilai n JOIN siswa s USING(nosiswa)) JOIN (nilai JOIN(pegawai p JOIN pengajar png USING(nopegawai)) USING(nopengajar))  USING(kodeujian)";
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

        // sini bang

    }

    

}
