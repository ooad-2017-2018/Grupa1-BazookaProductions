using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel.Models
{
    class RegistrovaniKorisnik : Korisnik
    {
        public RegistrovaniKorisnik(string id, string ime, string prezime, string username, string password, string email) : base(id, ime, prezime, username, password, email)
        {
        }
    }
}
