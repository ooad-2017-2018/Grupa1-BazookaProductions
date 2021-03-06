﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel1._0.Models
{
    public class Korisnik
    {
        string id;
        string ime;
        string prezime;
        string username;
        string password;
        string email;
        int tipKorisnika;

        public Korisnik(string id, string ime, string prezime, string username, string password, string email, int tipKorisnika)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Username = username;
            Password = password;
            Email = email;
            TipKorisnika = tipKorisnika;
        }

        public string Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string Ime
        {
            get => ime;
            set
            {
                /*if (value.Length == 0)
                    throw new Exception("Ime nevalidan!");*/
                ime = value;
            }
        }
        public string Prezime
        {
            get => prezime;
            set
            {
                /*if (value.Length == 0)
                    throw new Exception("Prezime nevalidan!");*/
                prezime = value;
            }
        }
        public string Username
        {
            get => username;
            set
            {
                /*if (value.Length == 0)
                    throw new Exception("Userrname nevalidan!");*/
                username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                /*if (value.Length == 0)
                    throw new Exception("Password nevalidan!");*/
                password = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                /*if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Email nevalidan");*/
                email = value;
            }
        }
        public int TipKorisnika
        {
            get => tipKorisnika;
            set
            {
                tipKorisnika = value;
            }
        }

        public string ispisiKorisnika()
        {
            string s = Ime + " " + Prezime + " " + email;
            return s;
        }
    }
}
