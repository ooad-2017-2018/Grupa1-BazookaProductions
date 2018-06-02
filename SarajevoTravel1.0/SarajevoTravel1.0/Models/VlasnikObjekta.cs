using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel1._0.Models
{
    public class VlasnikObjekta:Korisnik
    {
        public VlasnikObjekta(string id, string ime, string prezime, string username, string password, string email, int tipKorisnika) : base(id, ime, prezime, username, password, email, tipKorisnika)
        {

        }
    }
}
