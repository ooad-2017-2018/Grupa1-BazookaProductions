using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel1._0.Models
{
    public static class SarajevoTravel
    {
        public static List<Korisnik> korisnici = new List<Korisnik>();
        public static List<Objekat> objekti = new List<Objekat>();
        public static List<Rezervacija> rezervacije = new List<Rezervacija>();
        public static List<Komentar> komentari = new List<Komentar>();
        public static Korisnik ulogovaniKorisnik;
        public static Admin admin;
    }
}
