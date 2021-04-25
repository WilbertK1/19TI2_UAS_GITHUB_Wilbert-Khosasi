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
    public partial class FormCekBuku : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        int indeksTabel = 0;
        string pemilihan;
        public FormCekBuku()
        {
            InitializeComponent();
        }        

        private void FormCekBuku_Load(object sender, EventArgs e)
        {
            ViewBuku(string.Empty);
        }

        private void Populate(DataBuku databuku)
        {
            dgvBuku.Rows.Add(databuku.Id, databuku.NoSeriBuku, databuku.NamaBuku, databuku.NamaPenulis, databuku.Sisa);
        }
        private void Insert(DataBuku databuku)
        {
            dgvBuku.Rows.Add(databuku.Id, databuku.NoSeriBuku, databuku.NamaBuku, databuku.NamaPenulis, databuku.Sisa);
        }
        private void ViewBuku(string ParameterValue)
        {
            dgvBuku.Rows.Clear();
            try
            {
                String sqlCommand = "SELECT ID, No_Seri_Buku, Nama_Buku, Nama_Penulis, Sisa FROM DataBuku";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow barisTabel in dataTable.Rows)
                {
                    DataBuku databuku = new DataBuku();
                    databuku.Id = Int32.Parse(barisTabel[0].ToString());
                    databuku.NoSeriBuku = barisTabel[1].ToString();
                    databuku.NamaBuku = barisTabel[2].ToString();
                    databuku.NamaPenulis = barisTabel[3].ToString();
                    databuku.Sisa = Int32.Parse(barisTabel[4].ToString());
                    Populate(databuku);
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            lblDataBuku.Visible = true;
            lblJumlah.Visible = true;
            lblNamaBuku.Visible = true;
            lblNamaPenulis.Visible = true;
            lblNoSeriBuku.Visible = true;
            txtJumlah.Visible = true;
            txtNamaBuku.Visible = true;
            txtNamaPenulis.Visible = true;
            txtNoSeriBuku.Visible = true;
            btnMasukkan.Visible = true;
        }

        private void btnMasukkan_Click(object sender, EventArgs e)
        {
            string SQLCommand;
            string peringatan = "Apakah anda sudah yakin dengan datanya???";

            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                SQLCommand = "INSERT INTO DataBuku (No_Seri_Buku, Nama_Buku, Nama_Penulis, Sisa) VALUES ('" + txtNoSeriBuku.Text + "', '" + txtNamaBuku.Text + "', '" + txtNamaPenulis.Text + "', '" + txtJumlah.Text + "')";

                cmd = new OleDbCommand(SQLCommand, dbConnection);

                try
                {
                    dbConnection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        DataBuku databuku = new DataBuku();
                        databuku.NoSeriBuku = txtNoSeriBuku.Text;
                        databuku.NamaBuku = txtNamaBuku.Text;
                        databuku.NamaPenulis = txtNamaPenulis.Text;
                        databuku.Sisa = Int32.Parse(txtJumlah.Text);

                        lblDataBuku.Visible = false;
                        lblJumlah.Visible = false;
                        lblNamaBuku.Visible = false;
                        lblNamaPenulis.Visible = false;
                        lblNoSeriBuku.Visible = false;
                        txtJumlah.Visible = false;
                        txtNamaBuku.Visible = false;
                        txtNamaPenulis.Visible = false;
                        txtNoSeriBuku.Visible = false;
                        btnMasukkan.Visible = false;

                        Insert(databuku);
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string SQLCommand;
            int choose = dgvBuku.CurrentRow.Index;
            DataGridViewRow tableRecord = dgvBuku.Rows[choose];
            pemilihan = tableRecord.Cells[1].Value.ToString();

            SQLCommand = "DELETE FROM DataBuku WHERE No_Seri_Buku = '" + pemilihan + "' ";
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
                        dgvBuku.Rows.RemoveAt(choose);
                        MessageBox.Show("Data berhasil dihapus dalam Database.");
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

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;
        }
    }
}
