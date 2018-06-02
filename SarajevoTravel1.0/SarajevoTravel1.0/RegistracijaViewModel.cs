using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel1._0
{
    class RegistracijaViewModel
    {
        public RegistracijaViewModel() { }
        public bool uspjesnaRegistracija (string ime, string prezime, string username, string password, string email, int tipKorisnika)
        {
            try
            {
                Baza.registrujKorisnika(ime, prezime, username, password, email, tipKorisnika);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
