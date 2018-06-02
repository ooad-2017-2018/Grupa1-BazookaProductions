using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;


namespace SarajevoTravel1._0.Models
{
    public class Komentar
    {
        public string id { get => id; set => id = value; }
        public string komentar { get => komentar; set => komentar = value; }
        public int ocjena { get => ocjena; set => ocjena = value; }
        public string username { get => username; set => username = value; }
        public string idObjekta { get => idObjekta; set => idObjekta = value; }
        public BitmapImage image { get => image; set => image = value; }
        public DateTime datum { get => datum; set => datum = value; }
        public int vrsta = 1;


        //Samo komentar
        public Komentar(string id, string komentar, string username, string idObjekta, DateTime datum)
        {
            this.id = id;
            this.komentar = komentar;
            this.ocjena = -1;
            this.username = username;
            this.idObjekta = idObjekta;
            this.datum = datum;
            image = null;
        }
        //komentar + ocjena 
        public Komentar(string id, string komentar, int ocjena, string username, string idObjekta, DateTime datum)
        {
            this.id = id;
            this.komentar = komentar;
            this.ocjena = ocjena;
            this.username = username;
            this.idObjekta = idObjekta;
            this.datum = datum;
            image = null;
            vrsta = 2;
        }
        //kom+ocjena+slika
        public Komentar(string id, string komentar, int ocjena, string username, string idObjekta, DateTime datum, BitmapImage image)
        {
            this.id = id;
            this.komentar = komentar;
            this.ocjena = ocjena;
            this.username = username;
            this.idObjekta = idObjekta;
            this.datum = datum;
            this.image = image;
            vrsta = 3;
        }

    }
}
