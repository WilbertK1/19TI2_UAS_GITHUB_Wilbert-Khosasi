using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peminjaman_Perpustakaan.Model
{
    class DataPeminjamanBuku
    {
        private DateTime tanggal;
        private string noIDMahasiswa;        
        private string noSeriBuku;
        private string namaBuku;
        private string namaPenulis;        

        public DataPeminjamanBuku()
        {

        }

        public DataPeminjamanBuku(DateTime tanggal, string noIDMahasiswa, string noSeriBuku, string namaBuku, string namaPenulis)
        {
            this.tanggal = tanggal;
            this.noIDMahasiswa = noIDMahasiswa;
            this.noSeriBuku = noSeriBuku;
            this.namaBuku = namaBuku;
            this.namaPenulis = namaPenulis;
        }

        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string NoIDMahasiswa { get => noIDMahasiswa; set => noIDMahasiswa = value; }
        public string NoSeriBuku { get => noSeriBuku; set => noSeriBuku = value; }
        public string NamaBuku { get => namaBuku; set => namaBuku = value; }
        public string NamaPenulis { get => namaPenulis; set => namaPenulis = value; }
    }
}
