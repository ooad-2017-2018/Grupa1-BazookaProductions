using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using System.ComponentModel;

namespace SarajevoTravel1._0.Models
{
    public class RegistrovaniKorisnik : Korisnik
    {
        public RegistrovaniKorisnik(string id, string ime, string prezime, string username, string password, string email, int tipKorisnika) : base(id, ime, prezime, username, password, email, tipKorisnika)
        {

        }
        
    }
}
