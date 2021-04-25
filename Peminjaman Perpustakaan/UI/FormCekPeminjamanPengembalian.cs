using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Peminjaman_Perpustakaan.Model;


namespace Peminjaman_Perpustakaan
{
    public partial class FormCekPeminjamanPengembalian : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        string pemilihan;
        public FormCekPeminjamanPengembalian()
        {
            InitializeComponent();
        }

        private void FormCekPeminjamanPengembalian_Load(object sender, EventArgs e)
        { 
             ViewPeminjaman(string.Empty);
             ViewPengembalian(string.Empty);
        }
        private void PopulatePeminjaman(DataPeminjamanBuku datapeminjamanbuku)
        {
            dgvPeminjaman.Rows.Add(datapeminjamanbuku.Tanggal, datapeminjamanbuku.NoIDMahasiswa, datapeminjamanbuku.NoSeriBuku, datapeminjamanbuku.NamaBuku, datapeminjamanbuku.NamaPenulis);
        }
        private void PopulatePengembalian(DataPengembalianBuku datapengembalianbuku)
        {
            dgvPengembalian.Rows.Add(datapengembalianbuku.Tanggal, datapengembalianbuku.NoIDMahasiswa, datapengembalianbuku.NoSeriBuku, datapengembalianbuku.NamaBuku, datapengembalianbuku.NamaPenulis);
        }
        private void ViewPeminjaman(string ParameterValue)
        {
            dgvPeminjaman.Rows.Clear();
            try
            {
                String sqlCommand = "SELECT Tanggal, No_ID_Mahasiswa, No_Seri_Buku, Nama_Buku, Nama_Penulis FROM DataPeminjamanBuku";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow barisTabel in dataTable.Rows)
                {
                    DataPeminjamanBuku datapeminjamanbuku = new DataPeminjamanBuku();
                    datapeminjamanbuku.Tanggal = DateTime.Parse(barisTabel[0].ToString());
                    datapeminjamanbuku.NoIDMahasiswa = barisTabel[1].ToString();
                    datapeminjamanbuku.NoSeriBuku = barisTabel[2].ToString();
                    datapeminjamanbuku.NamaBuku = barisTabel[3].ToString();
                    datapeminjamanbuku.NamaPenulis = barisTabel[4].ToString();
                    PopulatePeminjaman(datapeminjamanbuku);
                    dgvPeminjaman.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                dataTable.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void ViewPengembalian(string ParameterValue)
        {
            dgvPengembalian.Rows.Clear();
            try
            {
                String sqlCommand = "SELECT Tanggal, No_ID_Mahasiswa, No_Seri_Buku, Nama_Buku, Nama_Penulis FROM DataPengembalianBuku";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow barisTabel in dataTable.Rows)
                {
                    DataPengembalianBuku datapengembalianbuku = new DataPengembalianBuku();
                    datapengembalianbuku.Tanggal = DateTime.Parse(barisTabel[0].ToString());
                    datapengembalianbuku.NoIDMahasiswa = barisTabel[1].ToString();
                    datapengembalianbuku.NoSeriBuku = barisTabel[2].ToString();
                    datapengembalianbuku.NamaBuku = barisTabel[3].ToString();
                    datapengembalianbuku.NamaPenulis = barisTabel[4].ToString();
                    PopulatePengembalian(datapengembalianbuku);
                    dgvPengembalian.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                dataTable.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void dgvPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHapusPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusPeminjaman_Click_1(object sender, EventArgs e)
        {
            string SQLCommand;
            int choose = dgvPeminjaman.CurrentRow.Index;
            DataGridViewRow tableRecord = dgvPeminjaman.Rows[choose];
            pemilihan = tableRecord.Cells[1].Value.ToString();

            SQLCommand = "DELETE FROM DataPeminjamanBuku WHERE No_ID_Mahasiswa = '" + pemilihan + "' ";
            cmd = new OleDbCommand(SQLCommand, dbConnection);
            string peringatan = "Apakah anda ingin menghapus peminjaman " + pemilihan + " dari data?";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dbConnection.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    adapter.DeleteCommand = dbConnection.CreateCommand();
                    adapter.DeleteCommand.CommandText = SQLCommand;

                    if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus dalam Database.");
                        dgvPeminjaman.Rows.RemoveAt(choose);
                        btnHapusPeminjaman.Enabled = false;
                        lblDataPeminjaman.Visible = false;
                        dgvPeminjaman.Visible = false;
                        btnPeminjaman.Visible = false;
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dbConnection.Close();
                }
            }            
        }

        private void btnHalamanUtama_Click(object sender, EventArgs e)
        {
            string peringatan = "Apakah kamu yakin ingin kembali ke form admin???";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Kembali", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                FormAdmin fa = new FormAdmin();
                fa.Show();
                this.Hide();
            }
        }

        private void btnHapusPengembalian_Click(object sender, EventArgs e)
        {
            string SQLCommand;
            int choose = dgvPengembalian.CurrentRow.Index;
            DataGridViewRow tableRecord = dgvPengembalian.Rows[choose];
            pemilihan = tableRecord.Cells[1].Value.ToString();

            SQLCommand = "DELETE FROM DataPengembalianBuku WHERE No_ID_Mahasiswa = '" + pemilihan + "' ";
            cmd = new OleDbCommand(SQLCommand, dbConnection);
            string peringatan = "Apakah anda ingin menghapus pengembalian " + pemilihan + " dari data?";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dbConnection.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    adapter.DeleteCommand = dbConnection.CreateCommand();
                    adapter.DeleteCommand.CommandText = SQLCommand;

                    if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus dalam Database.");
                        dgvPengembalian.Rows.RemoveAt(choose);
                        btnHapusPengembalian.Enabled = false;
                        lblDataPengembalian.Visible = false;
                        dgvPengembalian.Visible = false;
                        btnPengembalian.Visible = false;
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dbConnection.Close();
                }
            }
        }

        private void dgvPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapusPeminjaman.Enabled = true;
        }

        private void dgvPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapusPengembalian.Enabled = true;
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            lblDataPeminjaman.Visible = true;
            dgvPeminjaman.Visible = true;
            btnHapusPeminjaman.Visible = true;
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            lblDataPengembalian.Visible = true;
            dgvPengembalian.Visible = true;
            btnHapusPengembalian.Visible = true;
        }
    }
}
