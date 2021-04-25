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
    public partial class FormCekMahasiswa : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        string pemilihan;
        int indeksTabel = 0;
        public FormCekMahasiswa()
        {
            InitializeComponent();
        }

        private void FormCekMahasiswa_Load(object sender, EventArgs e)
        {
            ViewMahasiswa(String.Empty);
        }
        private void Populate(DataMahasiswa Datamhs)
        {
            dgvMahasiswa.Rows.Add(Datamhs.Id, Datamhs.NoIDMahasiswa, Datamhs.NamaMahasiswa, Datamhs.KelasMahasiswa);
        }

        private void Insert(DataMahasiswa Datamhs)
        {
            dgvMahasiswa.Rows.Add(Datamhs.Id, Datamhs.NoIDMahasiswa, Datamhs.NamaMahasiswa, Datamhs.KelasMahasiswa);
        }
        private void ViewMahasiswa(string ParameterValue)
        {
            dgvMahasiswa.Rows.Clear();
            try
            {
                String sqlCommand = "SELECT ID, No_ID_Mahasiswa, Nama_Mahasiswa, Kelas_Mahasiswa FROM DataMahasiswa";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow barisTabel in dataTable.Rows)
                {
                    DataMahasiswa Datamhs = new DataMahasiswa();
                    Datamhs.Id = Int32.Parse(barisTabel[0].ToString());
                    Datamhs.NoIDMahasiswa = barisTabel[1].ToString();
                    Datamhs.NamaMahasiswa = barisTabel[2].ToString();
                    Datamhs.KelasMahasiswa = barisTabel[3].ToString();
                    Populate(Datamhs);
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            lblIDMahasiswa.Visible = true;
            lblNamaMahasiswa.Visible = true;
            lblKelasMahasiswa.Visible = true;
            txtIDMahasiswa.Visible = true;
            txtNamaMahasiswa.Visible = true;
            txtKelasMahasiswa.Visible = true;
            btnHapus.Enabled = false;
            btnRegister.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string SQLCommand;
            string peringatan = "Apakah anda sudah yakin dengan datanya???";

            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Tambah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                SQLCommand = "INSERT INTO DataMahasiswa (No_ID_Mahasiswa, Nama_Mahasiswa, Kelas_Mahasiswa) VALUES ('" + txtIDMahasiswa.Text + "', '" + txtNamaMahasiswa.Text + "', '" + txtKelasMahasiswa.Text + "')";

                cmd = new OleDbCommand(SQLCommand, dbConnection);

                try
                {
                    dbConnection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        DataMahasiswa datamahasiswa = new DataMahasiswa();
                        datamahasiswa.NoIDMahasiswa = txtIDMahasiswa.Text;
                        datamahasiswa.NamaMahasiswa = txtNamaMahasiswa.Text;
                        datamahasiswa.KelasMahasiswa = txtKelasMahasiswa.Text;
                        lblIDMahasiswa.Visible = false;
                        lblNamaMahasiswa.Visible = false;
                        lblKelasMahasiswa.Visible = false;
                        txtIDMahasiswa.Visible = false;
                        txtNamaMahasiswa.Visible = false;
                        txtKelasMahasiswa.Visible = false;
                        btnHapus.Enabled = false;
                        btnRegister.Visible = false;

                        Insert(datamahasiswa);
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dbConnection.Close();
                }
                finally
                {
                    dbConnection.Close();
                }
                btnHapus.Visible = true;
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
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

        private void Delete(DataMahasiswa Datamhs)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string SQLCommand;
            int choose = dgvMahasiswa.CurrentRow.Index;
            DataGridViewRow tableRecord = dgvMahasiswa.Rows[choose];
            pemilihan = tableRecord.Cells[1].Value.ToString();

            SQLCommand = "DELETE FROM DataMahasiswa WHERE No_ID_Mahasiswa = '" + pemilihan + "' ";
            cmd = new OleDbCommand(SQLCommand, dbConnection);
            string peringatan = "Apakah anda ingin menghapus " + pemilihan + " dari data?";
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
                        dgvMahasiswa.Rows.RemoveAt(choose);
                        btnHapus.Enabled = false;
                    }
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dbConnection.Close();
                }
            }
            indeksTabel++;
        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;            
        }

        private void dgvMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
