using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SarajevoTravel1._0.Models;

namespace SarajevoTravel1._0
{
    class LoginViewModel
    {
        public LoginViewModel() { }
        public int DajTipLogina (string username, string password)
        {
            try
            {
                SarajevoTravel.ulogovaniKorisnik = null;
                SarajevoTravel.admin = null;
                Baza.logInKorisnik(username, password);
                Baza.logInAdmin(username, password);
                if (SarajevoTravel.ulogovaniKorisnik != null)
                {
                    return SarajevoTravel.ulogovaniKorisnik.TipKorisnika;
                }
                if (SarajevoTravel.admin != null)
                {
                    return 3;
                }
                return 4;
            }
            catch
            {
                return 4;
            }
        }
    }
}
