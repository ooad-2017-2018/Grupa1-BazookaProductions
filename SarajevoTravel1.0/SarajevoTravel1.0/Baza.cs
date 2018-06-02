using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SarajevoTravel1._0.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace SarajevoTravel1._0
{
    public static class Baza
    {
        public static async void registrujKorisnika(string ime, string prezime, string username, string password, string email, int tipKorisnika)
        {
            IMobileServiceTable<TabelaKorisnik> Korisnici = App.MobileService.GetTable<TabelaKorisnik>();
            TabelaKorisnik kor = new TabelaKorisnik();
            kor.ime = ime;
            kor.prezime = prezime;
            kor.username = username;
            kor.password = password;
            kor.email = email;
            kor.tipKorisnika = tipKorisnika;
            try
            {
                await Korisnici.InsertAsync(kor);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void logInKorisnik(string user, string pass)
        {
            Korisnik kor = null;
            IMobileServiceTable<TabelaKorisnik> tabela = App.MobileService.GetTable<TabelaKorisnik>();

            IMobileServiceTableQuery<TabelaKorisnik> query = tabela.Where(k => (k.username == user && k.password == pass)).IncludeTotalCount();
            IEnumerable<TabelaKorisnik> korisnik = await query.ToEnumerableAsync();
            long c = ((ITotalCountProvider)korisnik).TotalCount;

            if(c != 0)
            {
                foreach (var k in korisnik)
                {
                    if (k.tipKorisnika == 1)
                    {
                        kor = new RegistrovaniKorisnik(k.id, k.ime, k.prezime, k.username, k.password, k.email, k.tipKorisnika);
                    }
                    else
                    {
                        kor = new VlasnikObjekta(k.id, k.ime, k.prezime, k.username, k.password, k.email, k.tipKorisnika);
                    }
                }
            }
            SarajevoTravel.ulogovaniKorisnik = kor;
        }
        public static async void logInAdmin(string user, string pass)
        {
            Admin ad = null;
            IMobileServiceTable<TabelaAdmin> tabela = App.MobileService.GetTable<TabelaAdmin>();

            IMobileServiceTableQuery<TabelaAdmin> query = tabela.Where(k => (k.username == user && k.password == pass)).IncludeTotalCount();
            IEnumerable<TabelaAdmin> admin = await query.ToEnumerableAsync();
            long c = ((ITotalCountProvider)admin).TotalCount;

            if (c != 0)
            {
                foreach (var k in admin)
                {
                    ad = new Admin(k.username, k.password);
                }
            }
            SarajevoTravel.admin = ad;
        }
        public static async void popuniKorisnike()
        {
            SarajevoTravel.korisnici = new List<Korisnik>();

            IMobileServiceTable<TabelaKorisnik> tabela = App.MobileService.GetTable<TabelaKorisnik>();

            IMobileServiceTableQuery<TabelaKorisnik> query = tabela.IncludeTotalCount();
            IEnumerable<TabelaKorisnik> korisnici = await query.ToEnumerableAsync();
            long c = ((ITotalCountProvider)korisnici).TotalCount;

            if (c != 0)
            {
                foreach (var k in korisnici)
                {
                    Korisnik kor = new Korisnik(k.id, k.ime, k.prezime, k.username, k.password, k.email, k.tipKorisnika);
                    SarajevoTravel.korisnici.Add(kor);
                }
            }
        }
    }
}
