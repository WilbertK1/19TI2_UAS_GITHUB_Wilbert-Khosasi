using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peminjaman_Perpustakaan.Model
{
    class DataBuku
    {
        private int id;
        private string noSeriBuku;
        private string namaBuku;
        private string namaPenulis;
        private int sisa;

        public DataBuku()
        {

        }

        public DataBuku(int id, string noSeriBuku, string namaBuku, string namaPenulis, int sisa)
        {
            this.id = id;
            this.noSeriBuku = noSeriBuku;
            this.namaBuku = namaBuku;
            this.namaPenulis = namaPenulis;
            this.sisa = sisa;
        }

        public int Id { get => id; set => id = value; }
        public string NoSeriBuku { get => noSeriBuku; set => noSeriBuku = value; }
        public string NamaBuku { get => namaBuku; set => namaBuku = value; }
        public string NamaPenulis { get => namaPenulis; set => namaPenulis = value; }
        public int Sisa { get => sisa; set => sisa = value; }
    }
}