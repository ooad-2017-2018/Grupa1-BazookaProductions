using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel1._0.Models
{
    class Rezervacija
    {
        string id;
        string idOsobe;
        string idObjekta;
        DateTime datum;

        public Rezervacija(string idR, string idOsobe, string idObjekta, DateTime datum)
        {
            this.id = id; ;
            this.idOsobe = idOsobe;
            this.idObjekta = idObjekta;
            this.datum = datum;
        }

        public string Id { get => id; set => id = value; }
        public string IdOsobe { get => idOsobe; set => idOsobe = value; }
        public string IdObjekta { get => idObjekta; set => idObjekta = value; }
        public DateTime Datum { get => datum; set => datum = value; }

    }
}
