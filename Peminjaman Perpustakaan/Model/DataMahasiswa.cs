using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peminjaman_Perpustakaan.Model
{
    class DataMahasiswa
    {
        private int id;
        private string noIDMahasiswa;
        private string namaMahasiswa;
        private string kelasMahasiswa;

        public DataMahasiswa()
        {

        }

        public DataMahasiswa(int id, string noIDMahasiswa, string namaMahasiswa, string kelasMahasiswa)
        {
            this.id = id;
            this.noIDMahasiswa = noIDMahasiswa;
            this.namaMahasiswa = namaMahasiswa;
            this.kelasMahasiswa = kelasMahasiswa;
        }

        public int Id { get => id; set => id = value; }
        public string NoIDMahasiswa { get => noIDMahasiswa; set => noIDMahasiswa = value; }
        public string NamaMahasiswa { get => namaMahasiswa; set => namaMahasiswa = value; }
        public string KelasMahasiswa { get => kelasMahasiswa; set => kelasMahasiswa = value; }
    }
}
