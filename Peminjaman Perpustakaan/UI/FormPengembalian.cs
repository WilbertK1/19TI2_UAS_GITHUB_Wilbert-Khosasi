using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Peminjaman_Perpustakaan.Model;
using System.Data.OleDb;

namespace Peminjaman_Perpustakaan
{
    public partial class FormPengembalian : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();

        private DataMahasiswa datamahasiswa = new DataMahasiswa();
        private string namaMahasiswa;
        public string NamaMahasiswa { get => namaMahasiswa; set => namaMahasiswa = value; }

        public FormPengembalian(string NamaMahasiswa)
        {
            this.NamaMahasiswa = NamaMahasiswa;     
            InitializeComponent();            
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            txtIDMahasiswa.Text = namaMahasiswa;
            ViewCekPeminjaman(string.Empty);            
        }
        private void populate(DataPeminjamanBuku datapeminjamanbuku)
        {
            dgvCekPeminjaman.Rows.Add(datapeminjamanbuku.Tanggal, datapeminjamanbuku.NoIDMahasiswa, datapeminjamanbuku.NoSeriBuku, datapeminjamanbuku.NamaBuku, datapeminjamanbuku.NamaPenulis);
        }

        private void dgvCekBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow tableRecord = dgvCekPeminjaman.Rows[e.RowIndex];
            object isiNoIdMahasiswa = tableRecord.Cells[1].Value;
            if (txtIDMahasiswa.Text == isiNoIdMahasiswa.ToString())
            {
                object IsiNoSeriBuku = tableRecord.Cells[2].Value;
                object IsiNamaBuku = tableRecord.Cells[3].Value;
                object IsiNamaPenulis = tableRecord.Cells[4].Value;
                txtNoSeriBuku.Text = IsiNoSeriBuku.ToString();
                txtNamaBuku.Text = IsiNamaBuku.ToString();
                txtPenulisBuku.Text = IsiNamaPenulis.ToString();
                btnKembali.Enabled = true;
                btnResetData.Enabled = true;
            }            
        }
        private void Kembalikan()
        {
            string SQLCommand;

            // Masukkan ke database
            SQLCommand = "INSERT INTO DataPengembalianBuku(Tanggal, No_ID_Mahasiswa, No_Seri_Buku, Nama_Buku, Nama_Penulis) VALUES(" +
                "DateValue('" + dtpTanggal.Value.ToString("dd/MM/yyyy") + "'), '" + txtIDMahasiswa.Text.Trim() + "', '" + txtNoSeriBuku.Text.Trim() + "', '" + txtNamaBuku.Text.Trim() + "', '" + txtPenulisBuku.Text.Trim() + "')";

            cmd = new OleDbCommand(SQLCommand, dbConnection);
            string peringatan = "Apakah anda yakin ingin mengembalikan buku ini?";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Pengembalian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dbConnection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        peringatan = "Anda berhasil melakukan pengembalian. \n" + "Silahkan ambil struk ini dan kembalikkan bukunya ke kasir. \n" + "Terimakasih telah menggunakan buku kami!!!";
                        MessageBox.Show(peringatan, "Peminjaman Berhasil!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormUtama fu = new FormUtama();
                        fu.Show();
                        this.Hide();
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
            }
            else if (dr == DialogResult.No)
            {
                peringatan = "Pengembalian dibatalkan";
                MessageBox.Show(peringatan, "Pengembalian dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ViewCekPeminjaman(string ParameterValue)
        {
            dgvCekPeminjaman.Rows.Clear();
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
                    populate(datapeminjamanbuku);
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

        private void btnCek_Click(object sender, EventArgs e)
        {
            dgvCekPeminjaman.Visible = true;
            lblNB.Visible = true;
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            txtNoSeriBuku.Text = "";
            txtNamaBuku.Text = "";
            txtPenulisBuku.Text = "";
            btnKembali.Enabled = false;
            btnResetData.Enabled = false;

        }

        private void btnSebelumnya_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Ingin Batalkan Pengembalian Buku ?", "Keluar Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                FormMahasiswa fm = new FormMahasiswa();
                fm.Show();
                this.Hide();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Kembalikan();
        }
    }
}
