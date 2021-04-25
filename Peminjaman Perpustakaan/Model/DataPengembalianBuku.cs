using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peminjaman_Perpustakaan.Model
{
    class DataPengembalianBuku
    {
        private DateTime tanggal;
        private string noIDMahasiswa;
        private string noSeriBuku;
        private string namaBuku;
        private string namaPenulis;

        public DataPengembalianBuku()
        {

        }

        public DataPengembalianBuku(DateTime tanggal, string noIDMahasiswa, string noSeriBuku, string namaBuku, string namaPenulis)
        {
            this.Tanggal = tanggal;
            this.NoIDMahasiswa = noIDMahasiswa;
            this.NoSeriBuku = noSeriBuku;
            this.NamaBuku = namaBuku;
            this.NamaPenulis = namaPenulis;
        }

        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string NoIDMahasiswa { get => noIDMahasiswa; set => noIDMahasiswa = value; }
        public string NoSeriBuku { get => noSeriBuku; set => noSeriBuku = value; }
        public string NamaBuku { get => namaBuku; set => namaBuku = value; }
        public string NamaPenulis { get => namaPenulis; set => namaPenulis = value; }
    }
}
