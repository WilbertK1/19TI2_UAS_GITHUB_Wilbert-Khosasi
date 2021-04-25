using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peminjaman_Perpustakaan
{
    public partial class FormAdmin : Form
    {
        Controller.LoginController cekUser = new Controller.LoginController();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (cekUser.loginUser(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Berhasil Login");
                btnCekDataMahasiswa.Enabled = true;
                btnCekDataBuku.Enabled = true;
                btnCekDataPeminjamanPengembalian.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Login Gagal");
                MessageBox.Show("Username dan Password Tidak Benar");
                MessageBox.Show("Username: " + txtUsername.Text + "Password: " + txtPassword.Text);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormUtama fu = new FormUtama();
            fu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCekDataMahasiswa_Click(object sender, EventArgs e)
        {
            FormCekMahasiswa fcm = new FormCekMahasiswa();
            fcm.Show();
            this.Hide();

        }

        private void btnCekDataBuku_Click(object sender, EventArgs e)
        {
            FormCekBuku fcb = new FormCekBuku();
            fcb.Show();
            this.Hide();
        }

        private void btnCekDataPeminjamanPengembalian_Click(object sender, EventArgs e)
        {
            FormCekPeminjamanPengembalian fcp = new FormCekPeminjamanPengembalian();
            fcp.Show();
            this.Hide();
        }
    }
}
