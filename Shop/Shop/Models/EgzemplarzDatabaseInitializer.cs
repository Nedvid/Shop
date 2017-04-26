using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop.Models
{
    public class EgzemplarzDatabaseInitializer : DropCreateDatabaseIfModelChanges<EgzemplarzContext>
    {
        protected override void Seed(EgzemplarzContext context)
        {
            GetEgzemplarze().ForEach(c => context.Egzemplarze.Add(c));
            GetVATy().ForEach(c => context.VATy.Add(c));
            GetPlatformy().ForEach(c => context.Platformy.Add(c));
            GetKategorie().ForEach(c => context.Kategorie.Add(c));
            GetProdukty().ForEach(p => context.Produkty.Add(p));
        }

        private static List<Egzemplarz> GetEgzemplarze()
        {
            var Egzemplarze = new List<Egzemplarz> {
                new Egzemplarz
                {
                    id_egzemplarz=1,
                    klucz_egzemplarz=RandomString(),
                    data_zakup = new DateTime(2017, 3, 1), //6/1/2008,
                    czy_sprzedano = false,

                    //klucze obce
                    id_produkt=1,
               },
               new Egzemplarz
                {
                    id_egzemplarz=2,
                    klucz_egzemplarz=RandomString(),
                    data_zakup = new DateTime(2017, 3, 1), //6/1/2008,
                    czy_sprzedano = false,

                    //klucze obce
                    id_produkt=1,
               },
            };

            return Egzemplarze;
        }

        private static List<VAT> GetVATy()
        {
            var VATy = new List<VAT> {
                new VAT
                {
                    id_vat = 1,
                    vat=21,
                    date = new DateTime(2008, 6, 1), //6/1/2008
        },
            };

            return VATy;
        }

        private static List<Platforma> GetPlatformy()
        {
            var Platformy = new List<Platforma> {
                new Platforma
                {
                    id_platforma = 1,
                    nazwa_platforma = "Steam"
                },
                new Platforma
                {
                    id_platforma = 2,
                    nazwa_platforma = "Origin"
                },
            };

            return Platformy;
        }

        private static List<Kategoria> GetKategorie()
        {
            var Kategorie = new List<Kategoria> {
                new Kategoria
                {
                    id_kategoria = 1,
                    nazwa_kategoria = "Akcja"
                },
                new Kategoria
                {
                    id_kategoria = 2,
                    nazwa_kategoria = "Bijatyka"
                },
            };

            return Kategorie;

        }

        private static List<Produkt> GetProdukty()
        {
            var Produkty = new List<Produkt> {
                new Produkt
                {
                    id_produkt = 1,
                    nazwa_produkt = "Gra1",
                    opis = "Opis",
                    foto="Gra1.jpg", //sciezka do zdjecia
                    cena = 22.50,
                    poprzednia_cena=24.50,

                    //klucze obce
                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
               },
               new Produkt
                {
                    id_produkt = 2,
                    nazwa_produkt = "Gra2",
                    opis = "Opis2",
                    foto="Gra2.jpg", //sciezka do zdjecia
                    cena = 22.50,
                    poprzednia_cena=24.50,

                    //klucze obce
                    id_Kategoria = 2,
                    id_Platforma=2,
                    id_VAT=1,
               },
            };

            return Produkty;
        }

        //Generator kluczy (dlugosc = 25)
        private static Random random = new Random();
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 25)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}