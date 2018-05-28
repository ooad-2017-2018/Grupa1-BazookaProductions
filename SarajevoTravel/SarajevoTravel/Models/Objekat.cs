using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel.Models
{
    public class Objekat
    {
        string id;
        string idVlasnika;
        string naziv, about, tip;
        int brMjesta;
        int brSlobodnihMjesta;
        int ocjena;

        public Objekat(string id, string idVlasnika, string naziv, string opis, string tipObjekta, int brMijesta, int brSlobodnihMijesta, int ocjena)
        {
            Id = id;
            IdVlasnika = idVlasnika;
            Naziv = naziv;
            About = opis;
            Tip = tipObjekta;
            BrMjesta = brMijesta;
            BrSlobodnihMjesta = brSlobodnihMijesta;
            Ocjena = ocjena;
        }

        public string Id { get => id; set => id = value; }
        public string IdVlasnika { get => idVlasnika; set => idVlasnika = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string About { get => about; set => about = value; }
        public string Tip { get => tip; set => tip = value; }
        public int BrMjesta { get => brMjesta; set => brMjesta = value; }
        public int BrSlobodnihMjesta { get => brSlobodnihMjesta; set => brSlobodnihMjesta = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }

        public override bool Equals(object obj)
        {
            var objekat = obj as Objekat;
            return objekat != null &&
                   id == objekat.id &&
                   idVlasnika == objekat.idVlasnika &&
                   naziv == objekat.naziv &&
                   about == objekat.about &&
                   tip == objekat.tip &&
                   brMjesta == objekat.brMjesta &&
                   brSlobodnihMjesta == objekat.brSlobodnihMjesta &&
                   ocjena == objekat.ocjena;
        }
    }
}
