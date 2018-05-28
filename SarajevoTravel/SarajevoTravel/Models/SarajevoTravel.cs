using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel.Models
{
    class SarajevoTravel
    {
        public List<Korisnik> korisnici = new List<Korisnik>();
        public List<Objekat> objekti = new List<Objekat>();
        public List<Rezervacija> rezervacije = new List<Rezervacija>();
        public List<Komentar> komentari = new List<Komentar>();
        public Admin admin = new Admin("admin","admin");

    }
}
