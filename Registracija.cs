using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaVojnoNovacenje_EM
{
    class Registracija
    {
        string username;
        string password;

        public Registracija(string password, string username)
        {
            this.password = password;
            this.username = username;

        }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
