using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peminjaman_Perpustakaan.Controller
{
    class LoginController
    {
        public bool loginUser(string NamaUser, string PasswordUser)
        {
            NamaUser = "Admin";
            if(string.Equals(NamaUser, PasswordUser))
            {
                return true;
            }
            else
            {
                return !true;
            }
        }
    }
}
