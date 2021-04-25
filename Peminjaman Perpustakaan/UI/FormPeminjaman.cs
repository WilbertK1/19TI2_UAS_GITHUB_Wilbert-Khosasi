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
    public partial class FormPeminjaman : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ERIC/OneDrive/Desktop/Peminjaman Perpustakaan/Database/UAS_03082190025_03082190019.accdb; Persist Security Info = False";
        readonly OleDbConnection dbConnection = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();

        private DataMahasiswa datamahasiswa = new DataMahasiswa();
        private string namaMahasiswa;        
        public string NamaMahasiswa { get => namaMahasiswa; set => namaMahasiswa = value; }
        
        int indeksTabel = 0;

        public FormPeminjaman(string NamaMahasiswa)
        {
            this.NamaMahasiswa = NamaMahasiswa;
            InitializeComponent();
        }       

        private void btnTambah_Click(object sender, EventArgs e)
        {            
            int jumlah = 1;
            int idx = 0;
            int totalbuku = 0;
            if (txtNoSeriBuku.Text.Equals(String.Empty))
            {                
                string peringatan = "No seri buku tidak boleh kosong";
                MessageBox.Show(peringatan, "PERHATIAN!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(txtJumlah.Text == "1")
            {
                string peringatan = "Maaf, 1x peminjaman untuk 1 buku";
                MessageBox.Show(peringatan, "PERHATIAN!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {                      
                DataPeminjamanBuku datapeminjamanbuku = new DataPeminjamanBuku();
                datapeminjamanbuku.Tanggal = dtpTanggal.Value;
                datapeminjamanbuku.NoSeriBuku = txtNoSeriBuku.Text;
                datapeminjamanbuku.NamaBuku = txtNamaBuku.Text;
                datapeminjamanbuku.NamaPenulis = txtPenulisBuku.Text;                 
                dgvPeminjaman.Rows.Add(datapeminjamanbuku.Tanggal, datapeminjamanbuku.NoSeriBuku, datapeminjamanbuku.NamaBuku, datapeminjamanbuku.NamaPenulis, jumlah);                
                dgvPeminjaman.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy";                
                btnHapusData.Enabled = false;                                
            }
            for (idx = 0; idx < dgvPeminjaman.Rows.Count; idx++)
            {
                DataGridViewRow tableRecord = dgvPeminjaman.Rows[idx];
                totalbuku += Int32.Parse(tableRecord.Cells[4].Value.ToString());
                txtJumlah.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0}", Int32.Parse(totalbuku.ToString()));               
            }                        
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Ingin Batalkan Peminjaman Buku ?", "Keluar Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                FormMahasiswa fm = new FormMahasiswa();
                fm.Show();
                this.Hide();
            }                
        }
        private void Populatebuku(DataBuku databuku)
        {
            dgvCekBuku.Rows.Add(databuku.Id, databuku.NoSeriBuku, databuku.NamaBuku, databuku.NamaPenulis, databuku.Sisa);
        }

        private void ViewBuku(string ParameterValue)
        {
            dgvCekBuku.Rows.Clear();
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
                    DataBuku Databuku = new DataBuku();
                    Databuku.Id = Int32.Parse(barisTabel[0].ToString());
                    Databuku.NoSeriBuku = barisTabel[1].ToString();
                    Databuku.NamaBuku = barisTabel[2].ToString();
                    Databuku.NamaPenulis = barisTabel[3].ToString();
                    Databuku.Sisa = Int32.Parse(barisTabel[4].ToString());
                    Populatebuku(Databuku);
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
        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            ViewBuku(String.Empty);
            txtIDMahasiswa.Text = NamaMahasiswa;

        }

        private void populatepinjam(DataPeminjamanBuku datapeminjamanbuku)
        {
            dgvPeminjaman.Rows.Add(datapeminjamanbuku.NoIDMahasiswa, datapeminjamanbuku.NoSeriBuku, datapeminjamanbuku.NamaBuku, datapeminjamanbuku.NamaPenulis);
        }

        private void txtNoSeriBuku_KeyUp(object sender, KeyEventArgs e)
        {
            int rowIndex; string noSeriBuku;

            if (e.KeyCode == Keys.Enter)
            {
                if (dgvCekBuku.Rows.Count > 1 && !txtNoSeriBuku.Text.Equals(String.Empty))
                {
                    // Cek apakah ada di Database atau tidak
                    for (rowIndex = 0; rowIndex < dgvCekBuku.Rows.Count ; rowIndex++)
                    {
                        DataGridViewRow dgvbuku = dgvCekBuku.Rows[rowIndex];
                        noSeriBuku = dgvbuku.Cells[1].Value.ToString();

                        // Bila nama makanan sudah ditemukan dalam menu
                        if (noSeriBuku.Equals(txtNoSeriBuku.Text))
                        {                            
                            txtNamaBuku.Text = dgvbuku.Cells[2].Value.ToString();
                            txtPenulisBuku.Text = dgvbuku.Cells[3].Value.ToString();                            
                            txtNoSeriBuku.Enabled = false;
                            btnResetList.Enabled = true;
                            btnTambahData.Enabled = true;
                            btnHapusData.Enabled = true;
                            btnPinjam.Enabled = true;

                        }                       
                    }
                }
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            dgvCekBuku.Visible = true;
        }        

        private void dgvPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
        private void btnHapus_Click(object sender, EventArgs e)
        {            
            int choose = dgvPeminjaman.CurrentRow.Index;            
            dgvPeminjaman.Rows.RemoveAt(choose);
            txtJumlah.Text = "0";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {           
            txtNoSeriBuku.Text = "";
            txtNamaBuku.Text = "";
            txtPenulisBuku.Text = "";
            txtNoSeriBuku.Enabled = true;
            btnResetList.Enabled = false;            
            btnTambahData.Enabled = false;
        }

        private void txtNoSeriBuku_TextChanged(object sender, EventArgs e)
        {

        }
                

        private void dgvPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int indeksTabel = 0;               
                // Bila user click cell
                DataGridViewRow tableRecord = dgvPeminjaman.Rows[e.RowIndex];
                object noseribuku = tableRecord.Cells[1].Value;
                object namabuku = tableRecord.Cells[2].Value;
                object penulisbuku = tableRecord.Cells[3].Value;
                txtNoSeriBuku.Enabled = false;
                btnTambahData.Enabled = false;
                btnResetList.Enabled = true;
                btnHapusData.Enabled = true;

                if (noseribuku != null && namabuku != null && penulisbuku!= null)
                {                    
                    indeksTabel = e.RowIndex;                   

                    txtNoSeriBuku.Text = noseribuku.ToString();
                    txtNamaBuku.Text = namabuku.ToString();
                    txtPenulisBuku.Text = penulisbuku.ToString();
                }
                else
                {
                    indeksTabel = -1;                    

                    txtNoSeriBuku.Text = txtNamaBuku.Text = txtPenulisBuku.Text = String.Empty;
                }
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {            
            Pinjam();            
        }
        private void Pinjam()
        {
            string SQLCommand;

            // Masukkan ke database
            SQLCommand = "INSERT INTO DataPeminjamanBuku(Tanggal, No_ID_Mahasiswa, No_Seri_Buku, Nama_Buku, Nama_Penulis) VALUES("+
                "DateValue('" + dtpTanggal.Value.ToString("dd/MM/yyyy") + "'), '" + txtIDMahasiswa.Text.Trim() + "', '" + txtNoSeriBuku.Text.Trim() + "', '" + txtNamaBuku.Text.Trim() + "', '" + txtPenulisBuku.Text.Trim()+"')";            

            cmd = new OleDbCommand(SQLCommand, dbConnection);
            string peringatan = "Apakah anda yakin ingin meminjam buku ini?";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Peminjaman", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dbConnection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        peringatan = "Anda berhasil melakukan peminjaman. \n" + "Silahkan ambil struk ini dan ambil bukunya dari kasir. \n" + "Terimakasih telah melakukan peminjaman !!!";
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
                peringatan = "Peminjaman dibatalkan";
                MessageBox.Show(peringatan, "Peminjaman dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
        }

        private void dgvCekBuku_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbPilihan_Enter(object sender, EventArgs e)
        {

        }
    }
}

