using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Peminjaman_Perpustakaan.Model;
using System.Data.OleDb;

namespace Peminjaman_Perpustakaan
{
    public partial class FormMahasiswa : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        private int DataMahasiswa = 0;
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            ViewMahasiswa(String.Empty);
        }

        private void btnHalamanUtama_Click(object sender, EventArgs e)
        {
            string peringatan = "Apakah kamu yakin ingin kembali ke Form Utama???";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                FormUtama fu = new FormUtama();
                fu.Show();
                this.Hide();
            }
            
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            if (DataMahasiswa == 1)
            {                
                FormPeminjaman fp1 = new FormPeminjaman(txtNoID.Text);
                fp1.Show();
                this.Hide();

            }
            else
            {
                string peringatan = "DATA ANDA SALAH";
                MessageBox.Show(peringatan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoID.Text = "";
            }
            
        }
        private void Populate(DataMahasiswa Datamhs)
        {
            dgvDataMahasiswa.Rows.Add(Datamhs.Id, Datamhs.NoIDMahasiswa, Datamhs.NamaMahasiswa,Datamhs.KelasMahasiswa);
        }

        private void ViewMahasiswa(string ParameterValue)
        {
            dgvDataMahasiswa.Rows.Clear();
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

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            if (DataMahasiswa == 1)
            {
                FormPengembalian fp2 = new FormPengembalian(txtNoID.Text);
                fp2.Show();
                this.Hide();

            }
            else
            {
                string peringatan = "DATA ANDA SALAH";
                MessageBox.Show(peringatan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoID.Text = "";
            }
        }

        private void txtNoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoID_KeyUp(object sender, KeyEventArgs e)
        {
            int rowIndex; string noID;

            if (e.KeyCode == Keys.Enter)
            {
                if (dgvDataMahasiswa.Rows.Count > 1 && !txtNoID.Text.Equals(String.Empty))
                {
                    // Cek apakah ada di Database atau tidak
                    for (rowIndex = 0; rowIndex < dgvDataMahasiswa.Rows.Count ; rowIndex++)
                    {
                        DataGridViewRow dgvmhs = dgvDataMahasiswa.Rows[rowIndex];
                        noID = dgvmhs.Cells[1].Value.ToString();

                        // Bila nama makanan sudah ditemukan dalam menu
                        if (noID.Equals(txtNoID.Text))
                        {
                            txtNama.Text = dgvmhs.Cells[2].Value.ToString();
                            txtKelas.Text = dgvmhs.Cells[3].Value.ToString();
                            txtNoID.Enabled = false;
                            DataMahasiswa = 1;
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNoID.Text = "";
            txtNama.Text = "";
            txtKelas.Text = "";
            txtNoID.Enabled = true;
        }

        private void lblDataTransaksi_Click(object sender, EventArgs e)
        {

        }
    }
}
