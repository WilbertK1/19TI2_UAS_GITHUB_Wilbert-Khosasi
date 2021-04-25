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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
            this.Hide();
        }

        private void btnMhs_Click(object sender, EventArgs e)
        {
            FormMahasiswa fm = new FormMahasiswa();
            fm.Show() ;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            string peringatan = "Apakah kamu yakin ingin keluar Perpustakaan Ini???";
            DialogResult dr = MessageBox.Show(peringatan, "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
    }
}
