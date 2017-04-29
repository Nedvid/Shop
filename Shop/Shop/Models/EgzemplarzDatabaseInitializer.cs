using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop.Models
{
    public class EgzemplarzDatabaseInitializer : DropCreateDatabaseAlways<EgzemplarzContext>
    {
        protected override void Seed(EgzemplarzContext context)
        {
            GetVATy().ForEach(c => context.VATy.Add(c));
            GetPlatformy().ForEach(c => context.Platformy.Add(c));
            GetKategorie().ForEach(c => context.Kategorie.Add(c));
            UpdatedProdukty().ForEach(c => context.Produkty.Add(c));
            GetEgzemplarze().ForEach(c => context.Egzemplarze.Add(c));

        }

        private static List<Egzemplarz> GetEgzemplarze()
        {
            var Egzemplarze = new List<Egzemplarz> {
               new Egzemplarz
                {
                    id_egzemplarz = 3,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 3,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 4,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 3,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 5,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 3,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 6,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 3,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 7,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 3,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 8,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 4,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 9,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 4,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 10,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 4,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 11,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 4,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 12,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 4,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 13,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 5,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 14,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 5,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 15,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 5,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 16,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 5,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 17,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 5,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 18,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 6,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 19,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 6,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 20,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 6,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 21,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 6,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 22,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 6,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 23,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 7,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 24,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 7,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 25,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 7,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 26,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 7,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 27,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 7,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 28,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 8,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 29,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 8,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 30,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 8,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 31,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 8,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 32,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 8,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 33,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 9,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 34,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 9,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 35,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 9,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 36,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 9,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 37,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 9,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 38,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 10,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 39,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 10,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 40,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 10,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 41,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 10,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 42,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 10,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 43,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 11,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 44,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 11,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 45,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 11,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 46,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 11,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 47,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 11,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 48,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 12,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 49,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 12,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 50,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 12,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 51,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 12,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 52,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 12,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 53,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 13,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 54,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 13,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 55,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 13,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 56,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 13,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 57,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 13,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 58,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 14,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 59,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 14,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 60,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 14,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 61,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 14,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 62,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 14,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 63,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 15,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 64,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 15,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 65,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 15,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 66,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 15,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 67,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 15,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 68,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 16,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 69,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 16,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 70,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 16,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 71,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 16,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 72,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 16,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 73,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 17,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 74,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 17,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 75,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 17,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 76,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 17,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 77,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 17,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 78,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 18,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 79,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 18,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 80,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 18,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 81,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 18,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 82,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 18,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 83,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 19,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 84,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 19,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 85,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 19,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 86,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 19,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 87,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 19,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 88,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 20,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 89,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 20,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 90,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 20,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 91,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 20,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 92,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 20,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 93,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 21,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 94,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 21,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 95,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 21,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 96,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 21,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 97,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 21,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 98,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 22,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 99,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 22,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 100,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 22,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 101,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 22,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 102,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 22,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 103,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 23,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 104,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 23,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 105,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 23,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 106,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 23,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 107,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 23,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 108,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 24,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 109,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 24,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 110,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 24,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 111,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 24,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 112,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 24,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 113,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 25,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 114,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 25,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 115,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 25,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 116,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 25,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 117,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 25,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 118,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 26,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 119,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 26,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 120,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 26,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 121,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 26,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 122,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 26,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 123,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 27,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 124,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 27,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 125,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 27,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 126,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 27,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 127,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 27,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 128,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 28,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 129,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 28,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 130,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 28,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 131,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 28,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 132,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 28,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 133,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 29,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 134,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 29,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 135,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 29,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 136,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 29,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 137,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 29,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 138,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 30,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 139,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 30,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 140,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 30,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 141,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 30,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 142,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 30,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 143,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 31,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 144,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 31,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 145,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 31,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 146,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 31,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 147,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 31,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 148,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 32,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 149,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 32,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 150,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 32,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 151,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 32,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 152,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 32,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 153,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 33,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 154,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 33,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 155,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 33,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 156,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 33,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 157,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 33,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 158,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 34,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 159,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 34,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 160,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 34,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 161,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 34,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 162,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 34,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 163,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 35,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 164,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 35,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 165,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 35,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 166,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 35,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 167,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 35,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 168,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 36,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 169,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 36,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 170,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 36,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 171,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 36,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 172,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 36,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 173,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 37,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 174,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 37,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 175,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 37,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 176,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 37,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 177,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 37,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 178,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 38,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 179,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 38,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 180,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 38,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 181,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 38,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 182,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 38,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 183,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 39,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 184,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 39,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 185,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 39,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 186,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 39,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 187,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 39,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 188,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 40,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 189,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 40,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 190,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 40,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 191,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 40,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 192,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 40,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 193,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 41,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 194,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 41,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 195,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 41,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 196,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 41,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 197,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 41,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 198,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 42,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 199,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 42,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 200,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 42,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 201,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 42,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 202,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 42,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 203,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 43,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 204,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 43,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 205,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 43,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 206,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 43,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 207,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 43,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 208,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 44,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 209,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 44,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 210,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 44,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 211,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 44,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 212,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 44,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 213,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 45,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 214,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 45,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 215,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 45,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 216,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 45,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 217,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 45,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 218,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 46,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 219,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 46,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 220,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 46,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 221,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 46,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 222,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 46,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 223,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 47,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 224,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 47,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 225,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 47,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 226,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 47,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 227,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 47,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 228,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 48,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 229,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 48,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 230,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 48,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 231,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 48,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 232,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 48,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 233,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 49,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 234,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 49,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 235,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 49,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 236,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 49,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 237,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 49,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 238,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 50,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 239,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 50,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 240,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 50,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 241,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 50,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 242,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 50,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 243,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 51,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 244,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 51,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 245,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 51,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 246,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 51,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 247,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 51,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 248,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 52,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 249,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 52,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 250,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 52,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 251,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 52,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 252,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 52,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 253,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 53,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 254,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 53,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 255,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 53,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 256,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 53,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 257,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 53,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 258,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 54,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 259,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 54,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 260,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 54,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 261,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 54,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 262,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 54,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 263,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 55,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 264,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 55,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 265,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 55,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 266,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 55,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 267,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 55,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 268,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 56,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 269,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 56,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 270,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 56,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 271,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 56,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 272,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 56,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 273,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 57,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 274,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 57,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 275,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 57,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 276,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 57,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 277,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 57,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 278,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 58,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 279,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 58,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 280,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 58,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 281,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 58,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 282,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 58,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 283,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 59,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 284,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 59,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 285,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 59,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 286,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 59,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 287,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 59,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 288,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 60,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 289,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 60,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 290,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 60,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 291,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 60,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 292,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 60,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 293,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 61,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 294,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 61,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 295,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 61,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 296,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 61,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 297,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 61,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 298,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 62,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 299,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 62,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 300,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 62,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 301,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 62,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 302,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 62,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 303,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 63,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 304,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 63,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 305,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 63,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 306,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 63,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 307,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 63,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 308,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 64,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 309,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 64,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 310,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 64,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 311,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 64,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 312,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 64,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 313,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 65,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 314,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 65,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 315,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 65,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 316,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 65,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 317,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 65,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 318,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 66,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 319,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 66,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 320,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 66,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 321,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 66,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 322,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 66,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 323,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 67,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 324,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 67,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 325,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 67,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 326,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 67,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 327,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 67,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 328,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 68,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 329,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 68,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 330,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 68,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 331,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 68,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 332,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 68,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 333,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 69,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 334,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 69,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 335,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 69,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 336,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 69,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 337,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 69,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 338,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 70,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 339,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 70,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 340,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 70,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 341,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 70,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 342,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 70,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 343,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 71,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 344,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 71,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 345,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 71,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 346,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 71,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 347,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 71,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 348,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 72,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 349,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 72,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 350,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 72,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 351,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 72,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 352,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 72,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 353,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 73,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 354,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 73,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 355,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 73,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 356,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 73,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 357,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 73,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 358,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 74,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 359,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 74,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 360,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 74,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 361,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 74,
                },
                new Egzemplarz
                {
                    id_egzemplarz = 362,
                    klucz_egzemplarz = RandomString(),
                    data_zakup = new DateTime(2017, 3, 1),
                    czy_sprzedano = false,

                    id_produkt = 74,
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
                new Platforma
                {
                    id_platforma = 3,
                    nazwa_platforma = "Battle.net"
                },
                new Platforma
                {
                    id_platforma = 4,
                    nazwa_platforma = "NCSOFT"
                },
                new Platforma
                {
                    id_platforma = 5,
                    nazwa_platforma = "Microsoft"
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
                new Kategoria
                {
                    id_kategoria = 3,
                    nazwa_kategoria = "Strzelanina"
                },
                new Kategoria
                {
                    id_kategoria = 4,
                    nazwa_kategoria = "Strategia"
                },
                new Kategoria
                {
                    id_kategoria = 5,
                    nazwa_kategoria = "Fantasy"
                },
                new Kategoria
                {
                    id_kategoria = 6,
                    nazwa_kategoria = "Przygodowa"
                },
                new Kategoria
                {
                    id_kategoria = 7,
                    nazwa_kategoria = "Software"
                },
            };

            return Kategorie;

        }

        private static List<Produkt> GetProdukty()
        {
            var Produkty = new List<Produkt> {
               new Produkt
                {
                    id_produkt = 3,
                    nazwa_produkt = "World of Warcraft 60 DAYS PrePaid Time Card",
                    opis = "Requires European version of the base game World of Warcraft on Battle.net in order to play. This product can be activated only on European account! Experience the World of Warcraft! World of Warcraft is an online role-playing experience set in the award-winning Warcraft universe. Players assume the roles of Warcraft heroes as they explore, adventure, and quest across a vast world. Being Massively Multiplayer, World of Warcraft allows thousands of players to interact within the same world. Whether adventuring together or fighting against each other in epic battles, players will form friendships, forge alliances, and compete with enemies for power and glory. System Requirements OS: Windows® XP / Windows Vista® / Windows® 7 / Windows® 8 / Windows® 8.1 with the latest service pack Windows® 7 / Windows® 8 / Windows® 8.1 64-bit with latest service pack Processor: Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750Intel® Core™ i5 2400, AMD FX™ 4100, or better Video: NVIDIA® GeForce® 8800 GT,  ATI Radeon™ HD 4850, or Intel® HD Graphics 3000 NVIDIA® GeForce® GTX 470, ATI Radeon™ HD 5870, or better Memory: 2 GB RAM (1 GB Windows® XP), 4 GB RAM Storage: 35 GB available hard drive space Internet: Broadband internet connection ",
                    foto = "p1_41022152827563_1_2.JPG",
                    cena = 107.67,

                    id_Kategoria = 5,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 4,
                    nazwa_produkt = "Call of Duty: Black Ops II  ",
                    opis = "COD: Black Ops II on PC is the follow-up to the hugely successful and award-winning Call of Duty: Black Ops. With a focus on stealth and covert missions, Black Ops II promises more of the same, suitably upping the ante for an improved Call of Duty experience.  COD: Black Ops II will boast improved graphics, making it the most visually stunning game in the entire Call of Duty series. The setting is no longer the Cold War, but the near future, a 21st Century where technology and weapons have merged and a new generation of warfare has been born.  Single-player mode will now include a branching campaign that will be based on the choices you make, giving you more opportunity to re-visit your missions, making different choices for different outcomes each time. The multiplayer mode promises one thing - the same, but better! Features Pushing the boundaries of what fans have come to expect from the record-setting entertainment franchise, Call of Duty: Black Ops II propels players into a near future, 21st Century Cold War, where technology and weapons have converged to create a new generation of warfare. Set in the near future, Call of Duty Black Ops 2 will take place in both the 80's and 2025 and will bring you inside a conflict between the U.S. and China. The task will be made more difficult for the simple reason that the former CIA agent Raul Menendez simply decided to betray his employer and take control of U.S. military infrastructure. He is now equipped with an army of drones belonging to the U.S. Army Raul Menendez will attack the United States of America on its own territory! In this second installment of Call of Duty Black Ops we will portray two different characters depending on the time, Alex Mason and his son David. The missions will take place in various environments such as Central America, Afghanistan, Singapore, Yemen or Los Angeles ... During his adventure in 2025 the player will use the best of the best in terms of futuristic military weaponry. About the multiplayer, the game developers of Call of Duty Black Ops 2 worked hard. Firstly, a new Create a class system is born and with it you can make up to 10 different combinations of objects, which pushes the customization to a new level. Players will also have access to a competition mode, the possibility of streaming and various tools to broadcast the game all around the world. All that new developments show that Call of Duty Black Ops 2 want to be one of the biggest actors of the e-sport scene in the next years. Regarding the zombie mode, developers have announced three different game modes. The first mode is called Tranzit, in this mode it is possible to play up to four players on a large map with full of things to see and discover...and of course a lot zombies ... It is also possible to take bus to go faster from one sector to another, which will also increase your chances of getting caught by a horde of zombies. Tranzit offers in some ways an adventure in the same style as Left 4 Dead but on a bigger map. The second game mode is the classic Survival in which we will have to fight hordes of zombies in closed levels. It is good to know that the levels are actually parts of the large map mode Tranzit cut and adapted to this game mode. Finally the last big news is the mode Grief is like the «Survival» mode but this time between two teams of 4 players and hordes of zombies. In this game mode, players can't kill each other but they can try to trap the other team in order to help them to die. A lot of fun is coming! System Requirements  OS: Windows Vista SP2 or Windows 7 Processor: Intel Core2 Duo E8200 2.66 GHz or AMD Phenom X3 8750 2.4 GHz Memory: 2 GB for 32-bit OS or 4 GB for 64-bit OS Graphics: Nvidia GeForce 8800GT 512 MB or ATI Radeon HD 3870 512 MB DirectX®: 9.0c Hard Drive: 16 GB HD space Sound: DirectX 11.0c compatible Additional: Broadband connection required for activation and multiplayer gameplay Note: Windows XP Operating System is not supported ",
                    foto = "bo2_1_2_1.jpg",
                    cena = 60.35,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 5,
                    nazwa_produkt = "The Tenth Line  ",
                    opis = "The Tenth Line is the first commercial game project from Sungazer Software. During your adventure, you'll guide the princess of the tiny nation of Easania, far from home and desperate to escape the clutches of a mysterious cult in hot pursuit. Along with her unusual but reliable companions, you'll explore a vibrant world of humans, beasts, and dragons, all struggling to coexist in the tension following the assassination of the king of the nation of Skyweather. Troubled times are ahead, indeed - the long-prophesied end of the world is fast approaching, and with only her wits, her blade, and her royal upbringing to guide her, can she make it home to her family before the end of days Features A completely original, unique RPG experience that takes inspiration from the 32-bit era of gaming. Explore the world through fast-paced 2D platforming by controlling three separate characters, each with unique movement mechanics and ways of interacting with the world. Take on dozens of foes at one time through turn-based RPG battles with an active timing element. High quality background and sprite artwork, a grand, varied soundtrack, and voice acting for each major character during battles. Unique progression and leveling mechanics for your characters. Multiple hours of gameplay, plus post-game challenges and a New Game Plus mode. Optional story-focused mode available that removes all enemy encounters and simplifies story-based battles. Play Quad Pro Quo (an in-universe collectible card game) against multiple characters and inhabitants of the world to win unique prizes and complete your collection! System Requirements PC System Requirements: OS: Windows 7 or newer, 64-bit Processor: SSE2 or better, 64-bit architecture Memory: 4 GB RAM Graphics: At least DX9 (shader model 3.0) or DX11, at least 1GB VRAM DirectX: Version 9.0c Storage: 2000 MB available space Additional Notes: 16:9 resolution display required Mac System Requirements: OS: Mac OS X 10.8+ Processor: SSE2 or better Memory: 4 GB RAM Graphics: At least DX9 (shader model 3.0) or DX11, at least 1GB VRAM Storage: 2100 MB available space Additional Notes: 16:9 resolution display required ",
                    foto = "header_11554.jpg",
                    cena = 23.94,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 6,
                    nazwa_produkt = "Prey",
                    opis = "This is a PRE-ORDER, the key will be delivered upon the game's release date: 5th May 2017! Bonuses, if included, may differ from offers on other stores! Prey is a first-person sci-fi action game from Arkane Studios, the award-winning creators of the 2012 'Game of the Year', Dishonored. Known for their creative gameplay, distinctive worlds and immersive stories, Arkane reimagines this franchise from the ground up, with an added psychological twist. In Prey, you are the first human enhanced with alien powers aboard a desolate space station under assault. Improvise and innovate in order to survive as you search for answers. Prey is a bold new story set in a dangerous universe. In Prey, you awaken aboard Talos I, a space station orbiting the moon in the year 2032. You are the key subject of an experiment meant to alter humanity forever – but things have gone terribly wrong. The space station has been overrun by hostile aliens and you are now being hunted. As you dig into the dark secrets of Talos I and your own past, you must survive using the tools found on the station, your wits, weapons, and mind-bending abilities. The fate of the Talos I and everyone aboard is in your hands. Features Sci-fi Thriller - Nothing is as it seems aboard Talos I. As Morgan Yu, set out to unravel the clues you've left behind for yourself, and discover the truth about your past. What role will you play in TranStar's plans, and the mysterious threat ravaging the station? Singular Setting - Orbiting the Moon, the Talos I space station symbolizes the height of private space enterprise. Explore a lavish craft designed to reflect corporate luxury of the 1960s, and navigate interconnected, non-linear pathways built to hide countless secrets. Unimaginable Threat - The shadowy extraterrestrial presence infesting Talos I is a living ecology bent on annihilating its prey. It's up to you, one of the last remaining survivors aboard the station, to end the deadly attack of these haunting predators. Play Your Way - Gain alien abilities to develop a distinct combination of powers and upgrade your unique skills. Craft increasingly useful items with the blueprints, gadgets and tools on board the station to overcome dangerous obstacles in your way. Survive unprecedented threats with your wits and ability to improvise.  System Requirements TBA",
                    foto = "header_7042.jpg",
                    cena = 173.93,
                    poprzednia_cena = 42.51,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 7,
                    nazwa_produkt = "Victor Vran RoW  ",
                    opis = "This is a restricted product and it CANNOT be activated nor played in Japan and South Korea. Victor Vran is an isometric Action-RPG with a massive selection of weapons, items, outfits, demon powers and destiny cards. Experience intense combat action with dozens of enemies attacking you from all sides and unleash powerful skills to finish them off! Victor Vran lets you decide how to play the game. Forge your own personal version of Victor thanks to a vast array of powerful weapons, game-changing outfits, wicked demon powers and destiny cards. Use special moves, combine skills and weapons to wipe out hordes of hideous beasts and clever boss monsters. Slaying demons doesn’t have to be a lonely affair – team up with friends online and explore the story of the dark world together in a full co-op experience. Local co-op is also available. Features Dynamic action – dive down on enemies, dodge attacks and stand against hordes of monsters Extensive character development – choose your weapons, items, outfits, destiny cards and demon powers to create your ultimate monster-slaying build Invite friends to defeat a vile monster or fight alongside players from all over the world. Do you want to find out who is more powerful? Try out the PvP Arena. Randomly generated items in addition to the hand-crafted ones. Improve every item to perfection by using transmutation. Huge variety in monster behavior Customize your difficulty with cursed hex items Xbox controller support System Requirements Windows: OS: Windows Vista SP2, Windows 7, Windows 8 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: GeForce 8800 or higher, AMD Radeon HD 4000 or higher, Intel HD 4000 or higher (min. 512 MB VRAM) DirectX: Version 9.0c Storage: 4 GB available space Sound Card: DirectX compatible Mac OS X: OS: OSX 10.9 (Mavericks) Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher, Intel HD 4000 or higher) Storage: 4 GB available space SteamOS + Linux: OS: Ubuntu 12.04 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher) Storage: 4 GB available space ",
                    foto = "header_9181.jpg",
                    cena = 5.32,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 8,
                    nazwa_produkt = "Rise of the Tomb Raider: 20 Year Celebrati",
                    opis = "Rise of the Tomb Raider: 20 Year Celebration includes the critically acclaimed Rise of the Tomb Raider, nominated for over 75 “Best Of” awards, in which Lara Croft becomes more than a survivor as she embarks on her first Tomb Raiding expedition to the most treacherous and remote regions of Siberia. Rise of the Tomb Raider: 20 Year Celebration also includes the new “Blood Ties” single player content, new Co-Op play for Endurance mode, “Extreme Survivor” difficulty setting for the main campaign, 20 Year Celebration outfit and gun, and 5 classic Lara skins. Also includes all previously released Downloadable Content including: Baba Yaga: The Temple of the Witch, Endurance Mode, Cold Darkness Awakened, 12 outfits, 7 weapons, and 35 expedition cards. With over 50 hours of gameplay, this is the most comprehensive version of the award-winning experience. Features The Critically Acclaimed Action Adventure - In Rise of the Tomb Raider, Lara uncovers an ancient mystery that places her in the cross-hairs of a ruthless organization known as Trinity. As she races to find the secret before Trinity, the trail leads to a myth about the Lost City of Kitezh. Lara knows she must reach the Lost City and its hidden secrets before Trinity as she sets out for Siberia on her first Tomb Raiding expedition. NEW “Blood Ties” Single Player Story – In the wake of her father’s death, Lara’s uncle challenges her ownership of Croft Manor. Lara is determined to reclaim her legacy and prove that she is the rightful heir, but to do that she will need to confront her past head on. Explore Lara’s childhood home in an hour of new Story Mode gameplay, and uncover a family mystery that will change her life forever. NEW “Blood Ties” Nightmare - Lara’s worst nightmares come alive as hordes of the undead overrun her childhood home. Defeat hordes of infectious zombies to become the ultimate zombie slayer, before the nightmare overwhelms you! Compete with friends and create community challenges with card modifiers in an all new Nightmare Mode. NEW Endurance Mode Co-Op - You and a friend must scrounge, scavenge and craft to survive the harsh elements by day, as well as lethal threats from enemies, both man and beast, by night. This is the ultimate test to see how long you and a friend can survive the sprawling, unforgiving landscapes. Fire takes fuel, cold kills the unprepared, food restores health, and everything must be caught, collected, or crafted. You start with nothing and must find everything. Work together and challenge others to your longest survival run and battle to the top of the leaderboards. NEW 20 Year Celebration Content - Five classic Lara Croft skins as well as a reimagined outfit that pays tribute to Lara’s trip to Antarctica in Tomb Raider III. New content also includes the “Extreme Survivor” difficulty setting in Rise of the Tomb Raider that will severely limit your save points, crafting materials, resources, ammunition, and health – only the most resourceful and capable will survive this new extreme difficulty. Includes all DLC - Includes all downloadable content that will extend your single-player campaign and will allow you to compete with friends. Three major releases will challenge you to survive the extreme conditions of Endurance Mode, explore a new tomb that houses an ancient terror in Baba Yaga: The Temple of the Witch, and combat waves of infected predators in Cold Darkness Awakened. In addition, new outfits, weapons, and Expedition Cards will keep you customizing, expanding, and challenging your friends to new adventures. Current Season Pass owners on Xbox One and PC will automatically receive the content for free, and moving forward the existing Season Pass will be updated to include the new content. System Requirements OS: Windows 7 64bit Processor: Intel Core i3-2100 or AMD equivalent Memory: 6 GB RAM Graphics: NVIDIA GTX 650 2GB or AMD HD7770 2GB DirectX: Version 11 Storage: 25 GB available space ",
                    foto = "header_7793.jpg",
                    cena = 82.51,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 9,
                    nazwa_produkt = "Minecraft Windows 10  ",
                    opis = "Worlds/saves from the Java PC/Mac version of Minecraft are not compatible with the Minecraft: Windows 10 Edition! Explore randomly generated worlds and build amazing things from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons and armor to fend off the dangerous mobs. Craft, create, and explore alone, or with friends on mobile devices or Windows 10. Millions of crafters around the world have smashed billions of blocks - now you can join in the fun on Windows 10! Join in the development process with beta access to Minecraft: Windows 10 Edition and provide your feedback to shape the game in future updates! Features Skins, texture, and mash-up packs! We have biome settlers, city folk, town folk, and more! ADD-ONS! Learn more at minecraft.net/addons, where you can try some examples for free or learn to create your own. Realms! Play with up to 10 friends cross-platform in worlds that exist anytime, anywhere. The Nether and all its inhabitants. Fight Ghasts and make friends with Pigmen Cross platform play for up to five players between Pocket Edition and Windows 10 Redstone! Pistons, comparators, repeaters, dispensers, droppers, and more! Spooky witches and their huts, complete with cauldrons filled with random potions and the ability to dye armor Ocelots! And bunnies! Slash commands to let you tweak how the game plays - you can give items away, summon mobs, change the time of day, and more. System Requirements OS: Windows 10 x64, x86 ",
                    foto = "logo_1940.jpg",
                    cena = 13.06,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 10,
                    nazwa_produkt = "Victor Vran RoW  ",
                    opis = "This is a restricted product and it CANNOT be activated nor played in Japan and South Korea. Victor Vran is an isometric Action-RPG with a massive selection of weapons, items, outfits, demon powers and destiny cards. Experience intense combat action with dozens of enemies attacking you from all sides and unleash powerful skills to finish them off! Victor Vran lets you decide how to play the game. Forge your own personal version of Victor thanks to a vast array of powerful weapons, game-changing outfits, wicked demon powers and destiny cards. Use special moves, combine skills and weapons to wipe out hordes of hideous beasts and clever boss monsters. Slaying demons doesn’t have to be a lonely affair – team up with friends online and explore the story of the dark world together in a full co-op experience. Local co-op is also available. Features Dynamic action – dive down on enemies, dodge attacks and stand against hordes of monsters Extensive character development – choose your weapons, items, outfits, destiny cards and demon powers to create your ultimate monster-slaying build Invite friends to defeat a vile monster or fight alongside players from all over the world. Do you want to find out who is more powerful? Try out the PvP Arena. Randomly generated items in addition to the hand-crafted ones. Improve every item to perfection by using transmutation. Huge variety in monster behavior Customize your difficulty with cursed hex items Xbox controller support System Requirements Windows: OS: Windows Vista SP2, Windows 7, Windows 8 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: GeForce 8800 or higher, AMD Radeon HD 4000 or higher, Intel HD 4000 or higher (min. 512 MB VRAM) DirectX: Version 9.0c Storage: 4 GB available space Sound Card: DirectX compatible Mac OS X: OS: OSX 10.9 (Mavericks) Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher, Intel HD 4000 or higher) Storage: 4 GB available space SteamOS + Linux: OS: Ubuntu 12.04 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher) Storage: 4 GB available space ",
                    foto = "header_9181.jpg",
                    cena = 5.32,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 11,
                    nazwa_produkt = "Final Fantasy XIV: Stormblood  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. Requires the base game Final Fantasy XIV: A Realm Reborn in order to play. This is a PRE-ORDER, the key will be delivered upon the game's release date: 20th June 2017! Bonuses, if included, may differ from offers on other stores! Game features online multiplayer mode only. Monthly subscription required to play. Dive into the next chapter of the critically acclaimed game FINAL FANTASY XIV Online with its epic next expansion pack - Stormblood! Explore vast, new lands, including Ala Mhigo, and challenge new Primal threats across Eorzea as you embark on hundreds of new quests as the Warrior of Light! With over six million adventurers worldwide, there is no better time to join the resistance than now! Features The expansion automatically increases the level cap to 70 for all disciplines. The battle system will be revamped. One change is that cross-class skills will now be determined by role rather than specific classes. New jobs Red Mage and Samurai. New areas are said to be comparable to Heavensward areas in size. Flying mounts supported. Players will be able to go swimming and diving in bodies of water. The story begins in a place called Rhalgr's Reach. A new continent to explore: far eastern Othard. New locations, including the island chain of Hingashi; the Ruby Sea, home to pirates and the Kojin beast tribe; Yanxia, home to the Garlean-occupied Doma; and the Azim Steppe, ancestral home of the Au Ra. A new city, the port town of Kugane, in Hingashi. A new far eastern styped housing area, Shirogane. Two new Beast Tribes, the Ananta, a serpentine tribe, and the Kojin, a tortoise-like tribe. New Primals, including the Ananta primal Lakshmi, Lady of Bliss, and the Kojin primal Susano, Lord of the Revel. A new high-end raid: Interdimensional Rift - Omega, the Bend of Time. A new 24-man raid series: Return to Ivalice, with a story written by Yasumi Matsuno. Exploratory missions set in The Forbidden Land of Eureka. The inventory system will be expanded. System Requirements OS: Windows 7 32/64 bit, Windows 8 32/64 bit, Windows 8.1 32/64 bit, Windows 10 32/64 bit Processor: Intel Core i5 2.4GHz or higher Memory: 4 GB RAM Graphics: 1280 x 720: NVIDIA Geforce GTX750 or higher DirectX: Version 9.0c Network: Broadband Internet connection Storage: 60 GB available space Sound Card: DirectSound sound card (DirectX 9.0c or higher) Additional Notes: The Minimum System Requirements (tentative) listed above are the anticipated minimum system requirements to run this software. However, please be aware that this information is still subject to change. AMD graphic cards are currently being tested and will be updated at a later time. ",
                    foto = "header_10959.jpg",
                    cena = 134.01,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 5,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 12,
                    nazwa_produkt = "Prey + Cosmaut Shotgun Pack DLC",
                    opis = "This is a PRE-ORDER, the key will be delivered upon the game's release date: 5th May 2017! Bonuses, if included, may differ from offers on other stores! Includes 2 items: Prey and Cosmonaut Shotgun Pack DLC. Prey is a first-person sci-fi action game from Arkane Studios, the award-winning creators of the 2012 'Game of the Year', Dishonored. Known for their creative gameplay, distinctive worlds and immersive stories, Arkane reimagines this franchise from the ground up, with an added psychological twist. In Prey, you are the first human enhanced with alien powers aboard a desolate space station under assault. Improvise and innovate in order to survive as you search for answers. Prey is a bold new story set in a dangerous universe. In Prey, you awaken aboard Talos I, a space station orbiting the moon in the year 2032. You are the key subject of an experiment meant to alter humanity forever – but things have gone terribly wrong. The space station has been overrun by hostile aliens and you are now being hunted. As you dig into the dark secrets of Talos I and your own past, you must survive using the tools found on the station, your wits, weapons, and mind-bending abilities. The fate of the Talos I and everyone aboard is in your hands. Features Sci-fi Thriller - Nothing is as it seems aboard Talos I. As Morgan Yu, set out to unravel the clues you've left behind for yourself, and discover the truth about your past. What role will you play in TranStar's plans, and the mysterious threat ravaging the station? Singular Setting - Orbiting the Moon, the Talos I space station symbolizes the height of private space enterprise. Explore a lavish craft designed to reflect corporate luxury of the 1960s, and navigate interconnected, non-linear pathways built to hide countless secrets. Unimaginable Threat - The shadowy extraterrestrial presence infesting Talos I is a living ecology bent on annihilating its prey. It's up to you, one of the last remaining survivors aboard the station, to end the deadly attack of these haunting predators. Play Your Way - Gain alien abilities to develop a distinct combination of powers and upgrade your unique skills. Craft increasingly useful items with the blueprints, gadgets and tools on board the station to overcome dangerous obstacles in your way. Survive unprecedented threats with your wits and ability to improvise.  System Requirements TBA",
                    foto = "header_10084.jpg",
                    cena = 179.21,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 13,
                    nazwa_produkt = "Killing Floor 2  ",
                    opis = "In KILLING FLOOR 2, players descend into continental Europe where the outbreak caused by Horzine Biotech’s failed experiment has quickly spread and gained unstoppable momentum, essentially paralyzing the European Union— Just one month after the events in the original KILLING FLOOR, the specimen clones are everywhere and civilization is in disarray; communications have failed, governments have collapsed, and military forces have been systematically eradicated. The people of Europe know survival and self-preservation too well and lucky survivors have gone into hiding. Not all have given up hope though... A group of civilians and mercenaries have banded together to combat the outbreak and established privately funded operation bases across Europe. Upon tracking specimen clone outbreaks, players will descend into zed-laden hot zones and exterminate them. Features Visceral Gore — KILLING FLOOR 2 ramps up the gore with a proprietary, high powered persistent blood system bringing new levels of fidelity to the genre. Players will send entrails, severed limbs, and blood flying as they wade through hordes of enemies. But they need to watch out! If caught, enemies will rip them, and their entire party limb from limb. 6 player co-op or solo play — A multitude of varied playable characters await for players to choose from as they enter the fray in online co-op mode or solo mode for those willing to brave the horrific specimens alone. Versus survival game mode — Be the Zed! A 12 player PvP mode where two teams take turns playing Humans vs. Zeds in a pair of short matches. In the first match, one team plays Humans and the other Zeds until the humans all die during a single round or they beat the boss. For the second match the teams switch sides and when the battle is completed both teams receive a score based on their performance and the higher score wins! Terrifying zeds — ew enemies and fan favorites from the original game are back with expanded and smarter artificial intelligence, dishing out powerful attacks, working as a group to weaken the player’s party and pushing the challenge level and fear factor to new levels. Unique blend of weaponry — From modern militaristic assault rifles, brutal improvised makeshift weapons, classic historical guns, and off the wall “Mad Scientist” weapons, KILLING FLOOR 2 has a unique blend of killing tools that will satisfy any gamer. Expanded perk system — Perks from the original game have been reimagined with more added to the fold. All perks now progress with meaningful talent choices that amplify different play styles, giving players a progression path that is expansive and full of rewarding milestones. Brutal melee combat — KILLING FLOOR 2 reinvents melee combat completely. Players now have control over the type of melee attacks they can perform, enabling them to deliver bone-breaking crippling attacks to Zeds.  System Requirements OS: Win7 64-bit, Win8/8.1 64-bit Processor: Core 2 Duo E8200 2.66GHz or Phenom II X2 545 Memory: 3 GB RAM Graphics: GeForce GTS 250 or Radeon HD 4830 DirectX: Version 10 Network: Broadband Internet connection Storage: 20 GB available space Additional Notes: UNSUPPORTED HARDWARE: IntelHD Integrated Graphics Chips, 32-bit Operating Systems, NVIDIA FleX features require a GeForce GTX 770 or higher (GeForce GTX 980 recommended). ",
                    foto = "Xd7FOj9_1.jpg",
                    cena = 53.32,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 14,
                    nazwa_produkt = "Call of Duty: Infinite Warfare",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe, but it CANNOT be activated nor played in Turkey. Call of Duty is back with Call of Duty: Infinite Warfare! This title will be the most futuristic one yet, with battles happening in space across our entire solar system. With no more resources available on Earth, our citizens have started to depend on colonies on other planets that provide us with resources. Play as Captain Nick Reyes, a member of the United Nations Space Alliance as he does his part to ensure a safe galaxy against the Settlement Defense Front. Whether you fight in the spaceship, in outer space itself or in a more classical foot-on-ground setting, your skills as an FPS player will be put to the test! Features MULTIPLE GAME MODES - Whether you prefer single player or multiplayer, you’re completely covered by Call of Duty: Infinite Warfare. Decide whether you prefer playing the single player campaign or if you want to jump into the highly competitive multiplayer mode immediately! NEW GAMEPLAY MECHANICS - With the introduction of outer space as a battleground, new gameplay mechanics have inevitably been made available. You can now fight in zero gravity, adding a multitude of new options available to creative fighters! In addition to this, the transition from zero gravity gameplay to the more classical on the ground gameplay is completely seamless. TOP-NOTCH GRAPHICS AND CINEMATIC CONTENT - Something we’ve come to expect from the Call of Duty franchise is not only outstanding gameplay but also additional in-game content. Take part in enormous battles and wars with a lot of action going on in the background. Beautiful cinematics throughout the game will enhance your gaming experience as well.  System Requirements OS: Windows 7 64-Bit or later   Processor: Intel Core i3-3225 @ 3.30GHz or equivalent Memory: 8 GB RAM Graphics: NVIDIA GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB DirectX: Version 11 Network: Broadband Internet connection Storage: 70 GB available space Sound Card: DirectX 11 Compatible Additional Notes: Disk space requirement may change over time. ",
                    foto = "header_6265.jpg",
                    cena = 75.88,
                    poprzednia_cena = 114.86,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 15,
                    nazwa_produkt = "Call of Duty: Modern Warfare 3 ",
                    opis = "The best-selling first person action series of all-time returns with the epic sequel to multiple “Game of the Year” award winner, Call of Duty®: Modern Warfare® 2. In the world’s darkest hour, are you willing to do what is necessary? Prepare yourself for a cinematic thrill-ride only Call of Duty can deliver. The definitive Multiplayer experience returns bigger and better than ever, loaded with new maps, modes and features. Co-Op play has evolved with all-new Spec-Ops missions and leaderboards, as well as Survival Mode, an action-packed combat progression unlike any other. System Requriements OS: Windows® XP/ Windows® Vista / Windows® 7 Processor: Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better Memory: 2 GB RAM Graphics: Shader 3.0 or better 256 MB NVIDIA® GeForce™ 8600GT / ATI® Radeon™ X1950 or better DirectX®: DirectX® 9.0c or later Hard Drive: 16 GB free hard drive space Sound: DirectX® 9.0c or later Internet: Broadband connection and service required for Multiplayer Connectivity. Internet connection required for activation. ",
                    foto = "modernwarfare_1.jpg",
                    cena = 58.22,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 16,
                    nazwa_produkt = "Fallout 4 ",
                    opis = "Get a game that's made by the best. Bethesda Game Studios has won awards for their famous Fallout and Elder Scrolls game series. Fallout 4 is an epic continuation of the post-apocalyptic story which left off in Fallout 3. As The Lone Survivor it's up to you to bring some order to the Commonwealth. You managed to survive the nuclear apocalypse, but that doesn't make life any easier. Waking up inside Vault 111 you learn that society has limped on in the years you've been asleep. Find out how much things have changed and then take control. Get Fallout 4 and start exploring! Features Sweet, sweet freedom - Fallout 4 features a massive open world called the Commonwealth which occupies the same space as modern day Boston and Massachusetts. Create your character how you would like and then roam freely. Play in first-person or zoom out into third-person as you explore the nuclear wasteland. Combat can be slowed down using the new V.A.T.S. system allowing you to target the weakest points of your enemies. Take on a horde of zombies or a mighty deathclaw. How you adventure is up to you. You and your settlement - It's been a long time since you entered Vault 111 and the world has changed. Nuclear war ravaged the land but society has already been rebuilt. Finding out what life means in the year 2287 is your main mission. Your adventure will take a long time and you'll need a place to relax. Your settlement is your home base and you decide how to build it. Collect souvenirs from missions to decorate or get supplies and build to the skies. Your settlement is a private piece of paradise in the middle of the desolate wasteland. So make sure it's styled how you want it. Fallout 4 is all about creating a unique experience in the incredible post-apocalyptic world. 2287 is your year! Buy your copy and get started. Crafted quality - This time around, Fallout has an upgraded graphics and lighting engine so you can see the landscape in higher quality than ever before. Every location is full of incredible details for you to enjoy. If you're more interested in function than fashion, try the new and improved crafting system. Make new weapons from different pieces, experiment with strange chemicals, and build your impenetrable suit of power armor. Fallout 4 is made to be enjoyed for a very long time because it has so much content. Even if you make it through the main storyline there is still tons of items to find, missions to complete, and easter eggs to hunt down. When you play Fallout 4 you are playing a game that has been carefully designed in every way.  System Requirements PC System Requirements: OS: Windows 7/8/10 (64-bit OS required) Processor: Intel Core i5-2300 2.8 GHz/AMD Phenom II X4 945 3.0 GHz or equivalent Memory: 8 GB RAM Graphics: NVIDIA GTX 550 Ti 2GB/AMD Radeon HD 7870 2GB or equivalent Storage: 30 GB available space ",
                    foto = "fallout_5.jpg",
                    cena = 89.33,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 17,
                    nazwa_produkt = "StarCraft II: Legacy of the Void  Battle ",
                    opis = "Product has been restricted to Europe! You are Hierarch Artanis, leader of the mighty protoss race. Years ago, your homeworld of Aiur fell to the merciless zerg Swarm. Now, at long last, you have raised a powerful fleet of warships known as the Golden Armada, and are poised to reclaim your world. But an ancient evil—Amon—threatens this destiny and the fate of the entire galaxy. Only you can reunite the protoss factions and defeat the coming darkness before it consumes all life in the sector. The protoss were being systematically exterminated and were dying out from sheer age even before the Great War.  The protoss have been picked off one-by-one, and their shattered civilization will fracture as something even worse happens, forcing a leader to save them from annihilation. Various protoss factions will be united for a last stand against Amon The Protoss are desperate...and dangerous. Legacy of the Void’s campaign shines a light on the flickering light of Protoss culture, placing pathos at the front of the humanoid alien race’s conclusive story. Before diving into my first Protoss mission, I explored the Spear of Adun, the warship led by primary character and leader of the lost and last of the Protoss. Hierarch Artanis... Features Automated Tournaments - Daily Competition - Come prove your might against participants from around the world in no-holds-barred tournaments that run once per day at specific times. Entries are open to players of all skill levels. Sign up, survive the elimination rounds, and face off against the best for ultimate dominance! Archon Mode - Two Player Single Base Control - Two heads are better than one: you and an ally share control over a single base to battle against two enemies in multiplayer action. Learn basic tactics from a seasoned veteran or amplify the power of a burgeoning all-star. Embody the spirit of the Archon and merge together to become a greater, unified force. Allied Commanders - Objective Based Co-Op - Join the battle with a friend in an open-ended cooperative experience. Choose a powerful commander from your favorite race and fight in diverse scenarios with dynamic, campaign-style objectives. Level up your commander to gain access to new units, abilities, and customization options for your army. The time is now. The theater of war awaits, commander. System Requirements OSWindows® XP/Windows Vista®/Windows® 7/Windows® 8 (Updated with the latest Service Packs) with DirectX® 9.0c PROCESSORIntel® Pentium® D or AMD Athlon™ 64 X2 MEMORY1.5 GB GRAPHICS CARDNVIDIA® GeForce® 7600 GT or ATI™ Radeon™ X800 XT or better HARD DRIVE20 GB ",
                    foto = "starcraft_3.PNG",
                    cena = 90.13,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 4,
                    id_Platforma=3,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 18,
                    nazwa_produkt = "MiddleEarth: Shadow of Mordor GOTY",
                    opis = "The GOTY Edition of Middle-Earth: Shadow of Mordor and the previously available Premium Edition are the same product. Includes 31 items: base game, The Lord of the Hunt Story Pack, The Bright Lord Story Pack, Test of Power Challenge Mode, Test of Speed Challenge Mode, Test of Wisdom Challenge Mode, Test of the Wild Challenge Mode, Test of the Ring Challenge Mode, Endless Challenge Mode, Test of Defiance, The Dark Ranger Skin, Captain of the Watch Skin, Lord of the Hunt Skin, The Bright Lord Skin, Power of Shadow Skin, Lithariel Skin, Hidden Blade Rune, Deadly Archer Rune, Flame of Anor Rune, Rising Storm Rune, Orc Slayer Rune, Defiant to the End Rune, Elven Grace Rune, Ascendant Rune, One with Nature Rune, Guardians of the Flaming Eye Warband Mission, The Berserks Warband Mission -The Skull Crushers Warband Mission, The Bloodhunters Mission, The Flesh Burners Mission and Photo Mode. In Middle-earth: Shadow of Mordor, gamers take on the role of Talion, a valiant ranger whose family is slain in front of him the night Sauron and his army return to Mordor, moments before his own life is taken. Resurrected by a Spirit of vengeance and empowered with Wraith abilities, Talion ventures into Mordor and vows to destroy those who have wronged him. Through the course of his personal vendetta, Talion uncovers the truth of the Spirit that compels him, learns the origins of the Rings of Power and ultimately confronts his true nemesis. Every enemy that players face is a unique individual, differentiated by their personality, strengths and weaknesses. Through the Nemesis System, enemy relationships and characteristics are shaped by player actions and decisions to create personal archenemies that remember and adapt to the player and are distinct to every gameplay session. Gamers are able to craft their own battles, enemies and rewards within the dynamic world that remembers and adapts to their choices, delivering a unique experience to every player. System Requirements PC System Requirements: OS: 64-bit: Vista SP2, Win 7 SP1, Win 8.1 Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 3 GB RAM Graphics: NVIDIA GeForce GTX 460 | AMD Radeon HD 5850 DirectX: Version 11 Network: Broadband Internet connection Storage: 44 GB available space Mac System Requirements: OS: Mac OS X 10.10.3 Processor: 2.4 GHz Intel Memory: 8 GB RAM Graphics: 1GB Nvidia 650M or later, AMD 7xxx series or later and Intel Iris Pro. Network: Broadband Internet connection Storage: 67 GB available space Additional Notes: Requires Keyboard & Multi-button Mouse Linux / SteamOS System Requirements: OS: Ubuntu 14.04.2 64-bit / SteamOS Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 4 GB RAM Graphics: 1GB NVIDIA 640 or better with driver version 352.21 or later Network: Broadband Internet connection Storage: 47 GB available space Additional Notes: AMD and Intel cards are NOT supported. If you wish to play the game using an AMD graphics card, you should update your graphics driver to version Catalyst 15.7 or higher. You should be able to run the game without experiencing stability issues or graphical glitches, but you may still experience poor performance. ",
                    foto = "header_10682.jpg",
                    cena = 27.19,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 19,
                    nazwa_produkt = "CS:GO TeasyCat Case",
                    opis = "Requires Counter Strike: Global Offensive on Steam in order to use. Want to support your favorite content creator in ways that benefit you too? Kinguin gives you this opportunity with partner cases! If you’re a fan of TeasyCat, here’s a chance to grab some awesome skins from our random skin case and show your support at the same time. What can you get for your money? Well, suffice it to say that there is a pretty good chance that the skin you’ll get will be valued around or even above the price of the case and of course some of you will be lucky enough to get a knife! You can even get StatTrak™ technology on your drops. Buy it now while our supplies last. You won’t get a better deal anywhere else! Delivery time may differ in case of technical difficulties beyond our control, like Steam inventory delays or server issues. Sent trade offers are not subject to return or exchange. Feel free to try your luck on skinz.gg, you have a chance to receive much better items!",
                    foto = "teasycat_pimg_173x120_1.jpg",
                    cena = 14.85,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 20,
                    nazwa_produkt = "Battle Chasers: Nightwar",
                    opis = "This is a PRE-ORDER, the key will be delivered upon release. Released in 2017. Battle Chasers: Nightwar is an RPG inspired by the classic console greats, featuring deep dungeon diving, turn-based combat presented in a classic JRPG format, and a rich story driven by exploration of the world. The best-selling comic book Battle Chasers was first released in the late 90s and quickly generated a passionate cult following. Features Classic JRPG-style combat with randomly generated dungeons, loot and skillshots Story driven by item and lore discovery Player-driven dungeon difficulty – give them tools for playing with dungeon generation Randomly generated dungeons with traps, puzzles and secrets High difficulty ceiling Town upgrading System Requirements PC System Requirements OS: Windows 7 / 8 / 10 32 or 64 bit Processor: 2.0 GHz CPU Memory: 2 GB RAM Graphics: DirectX compatible graphic card with 512 MB RAM DirectX: Version 11 Storage: 5 GB available space Sound Card: DirectX compatible Additional Notes: These are preliminary system specs that can and will change! Mac System Requirements OS: OSX 10.9+ Processor: 2.0 GHz CPU Memory: 2 GB RAM Graphics: Open GL 3.2+ Compliant Storage: 5 GB available space Additional Notes: These are preliminary system specs that can and will change! Linux / SteamOS System Requirements OS: SteamOS or Ubuntu Processor: 2.0 GHz CPU Memory: 2 GB RAM Graphics: NVIDIA GeForce 8 Series or higher/ATI X1600 or higher Storage: 5 GB available space Additional Notes: These are preliminary system specs that can and will change! ",
                    foto = "images_334.jpg",
                    cena = 172.57,

                    id_Kategoria = 5,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 21,
                    nazwa_produkt = "Victor Vran RoW  ",
                    opis = "This is a restricted product and it CANNOT be activated nor played in Japan and South Korea. Victor Vran is an isometric Action-RPG with a massive selection of weapons, items, outfits, demon powers and destiny cards. Experience intense combat action with dozens of enemies attacking you from all sides and unleash powerful skills to finish them off! Victor Vran lets you decide how to play the game. Forge your own personal version of Victor thanks to a vast array of powerful weapons, game-changing outfits, wicked demon powers and destiny cards. Use special moves, combine skills and weapons to wipe out hordes of hideous beasts and clever boss monsters. Slaying demons doesn’t have to be a lonely affair – team up with friends online and explore the story of the dark world together in a full co-op experience. Local co-op is also available. Features Dynamic action – dive down on enemies, dodge attacks and stand against hordes of monsters Extensive character development – choose your weapons, items, outfits, destiny cards and demon powers to create your ultimate monster-slaying build Invite friends to defeat a vile monster or fight alongside players from all over the world. Do you want to find out who is more powerful? Try out the PvP Arena. Randomly generated items in addition to the hand-crafted ones. Improve every item to perfection by using transmutation. Huge variety in monster behavior Customize your difficulty with cursed hex items Xbox controller support System Requirements Windows: OS: Windows Vista SP2, Windows 7, Windows 8 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: GeForce 8800 or higher, AMD Radeon HD 4000 or higher, Intel HD 4000 or higher (min. 512 MB VRAM) DirectX: Version 9.0c Storage: 4 GB available space Sound Card: DirectX compatible Mac OS X: OS: OSX 10.9 (Mavericks) Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher, Intel HD 4000 or higher) Storage: 4 GB available space SteamOS + Linux: OS: Ubuntu 12.04 Processor: 2 GHz Dual Core CPU Memory: 4 GB RAM Graphics: OpenGL 4.1 (GeForce 600 or higher, AMD Radeon 5000 or higher) Storage: 4 GB available space ",
                    foto = "header_9181.jpg",
                    cena = 5.32,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 22,
                    nazwa_produkt = "CS:GO TeasyCat Case",
                    opis = "Requires Counter Strike: Global Offensive on Steam in order to use. Want to support your favorite content creator in ways that benefit you too? Kinguin gives you this opportunity with partner cases! If you’re a fan of TeasyCat, here’s a chance to grab some awesome skins from our random skin case and show your support at the same time. What can you get for your money? Well, suffice it to say that there is a pretty good chance that the skin you’ll get will be valued around or even above the price of the case and of course some of you will be lucky enough to get a knife! You can even get StatTrak™ technology on your drops. Buy it now while our supplies last. You won’t get a better deal anywhere else! Delivery time may differ in case of technical difficulties beyond our control, like Steam inventory delays or server issues. Sent trade offers are not subject to return or exchange. Feel free to try your luck on skinz.gg, you have a chance to receive much better items!",
                    foto = "teasycat_pimg_173x120_1.jpg",
                    cena = 14.85,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 23,
                    nazwa_produkt = "Outlast 2 ",
                    opis = "This is a restricted product and it CANNOT be activated nor played in Australia. Outlast 2 is the sequel to the acclaimed survival horror game Outlast. Set in the same universe as the first game, but with different characters and a different setting, Outlast 2 is a twisted new journey into the depths of the human mind and its dark secrets. No conflict is ever black and white. But once the dust has settled, the victors get to decide who was right and who was wrong. Who is good and who is evil. Human nature pushes us to extremes of violence and depravity, which we then justify by divine inspiration and a promise of paradise to come. Horror rises from desperation and blind faith. OUTLAST 2 will test your faith, pushing players to a place where going mad is the only sane thing to do. System Requirements PC System Requirements: OS: Windows Vista / 7 / 8 / 10, 64-bits Processor: Core i3-530 Memory: 4 GB RAM Graphics: 1GB VRAM NVIDIA Geforce GTX 260 / ATI Radeaon HD 4xxx DirectX: Version 10 Storage: 30 GB available space Sound Card: DirectX Compatible Additional Notes: Specs could be modified prior to release. ",
                    foto = "thumbnail_312.jpg",
                    cena = 112.90,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 24,
                    nazwa_produkt = "Sudden Strike 4",
                    opis = "This is a PRE-ORDER, the key will be delivered upon the game's release date: Spring 2017! Additional bonuses may differ from offers on other stores! Sudden Strike 4 sends you off on three extensive campaigns set amongst the battlefields of World War II. Commanding the Allied, German or Soviet troops, you will lead over 100 different units into battle; like the German bomber Heinkel He111, the Russian T-34 tank, the British Hawker Typhoon fighter plane and the notorious German Panzerkampfwagen VI Tiger.  In a first for the Sudden Strike series, you can now choose from one of nine individual commanders, such as George Patton or Bernard Montgomery, who will each allow for different approaches to combat and boast unique abilities.  Prove your strategic expertise in over 20 demanding singleplayer scenarios, the challenge-focused skirmish mode and the ultra-competitive multiplayer mode.  Exploit the weak spots of tanks, set up an ambush, occupy buildings with infantry,outmaneuver the enemy with clever positioning or unleash devastating air strikes – how you approach each mission is up to you!  System Requirements PC System Requirements OS: Windows 10  Processor: Intel® Core™ i5-4590  Memory: 8 GB RAM  Graphics: Nvidia Geforce GTX 980  Network: Broadband Internet connection  Storage: 12 GB available space Mac System Requirements OS: MacOS 10  Processor: Intel® Core™ i5-4590  Memory: 8 GB RAM  Graphics: AMD Radeon R9 390X  Network: Broadband Internet connection  Storage: 12 GB available space Linux/SteamOS System Requirements OS: SteamOS, Ubuntu 15.10  Processor: Intel® Core™ i5-4590  Memory: 8 GB RAM  Graphics: Nvidia Geforce GTX 980  Network: Broadband Internet connection  Storage: 12 GB available space ",
                    foto = "thumbnail_73.png",
                    cena = 134.01,
                    poprzednia_cena = 119.12,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 25,
                    nazwa_produkt = "The Tenth Line  ",
                    opis = "The Tenth Line is the first commercial game project from Sungazer Software. During your adventure, you'll guide the princess of the tiny nation of Easania, far from home and desperate to escape the clutches of a mysterious cult in hot pursuit. Along with her unusual but reliable companions, you'll explore a vibrant world of humans, beasts, and dragons, all struggling to coexist in the tension following the assassination of the king of the nation of Skyweather. Troubled times are ahead, indeed - the long-prophesied end of the world is fast approaching, and with only her wits, her blade, and her royal upbringing to guide her, can she make it home to her family before the end of days Features A completely original, unique RPG experience that takes inspiration from the 32-bit era of gaming. Explore the world through fast-paced 2D platforming by controlling three separate characters, each with unique movement mechanics and ways of interacting with the world. Take on dozens of foes at one time through turn-based RPG battles with an active timing element. High quality background and sprite artwork, a grand, varied soundtrack, and voice acting for each major character during battles. Unique progression and leveling mechanics for your characters. Multiple hours of gameplay, plus post-game challenges and a New Game Plus mode. Optional story-focused mode available that removes all enemy encounters and simplifies story-based battles. Play Quad Pro Quo (an in-universe collectible card game) against multiple characters and inhabitants of the world to win unique prizes and complete your collection! System Requirements PC System Requirements: OS: Windows 7 or newer, 64-bit Processor: SSE2 or better, 64-bit architecture Memory: 4 GB RAM Graphics: At least DX9 (shader model 3.0) or DX11, at least 1GB VRAM DirectX: Version 9.0c Storage: 2000 MB available space Additional Notes: 16:9 resolution display required Mac System Requirements: OS: Mac OS X 10.8+ Processor: SSE2 or better Memory: 4 GB RAM Graphics: At least DX9 (shader model 3.0) or DX11, at least 1GB VRAM Storage: 2100 MB available space Additional Notes: 16:9 resolution display required ",
                    foto = "header_11554.jpg",
                    cena = 23.94,
                    poprzednia_cena = 212.74,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 26,
                    nazwa_produkt = "Tricky Towers  ",
                    opis = "With your brilliant robe and magic powers, it’s time to build some Tricky Towers!  Stack your bricks to create a stable tower and try to topple those of your opponents. Cast magic to support your structure and fend off the dark spells of your rivals in this frantic physics party game.  Play with up to 4 friends in local multiplayer or challenge players around the world in an online battle. Train your skills with the extensive single player trials and set a high score on the leaderboards.  With spells flying everywhere and bricks tumbling down, Tricky Towers makes for a chaotically good time! Features Frantic physics action puzzle gameplay  Local and online multiplayer with 2-4 players  3 different multiplayer modes; race, survival and puzzle  Challenging single player trials  Leaderboard mode: compare how you stack up  17 Powerful light and dark magic spells System Requirements PC: OS: Windows XP  Processor: 1.73 GHz Intel Pentium M or higher  Memory: 1 GB RAM  DirectX: Version 10  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer Mac OS X: OS: OSX 10.8  Processor: Dual core or higher  Memory: 2 GB RAM  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer SteamOS + Linux: OS: Steam OS  Processor: 2GHZ or higher  Memory: 2 GB RAM  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer ",
                    foto = "header_7473.jpg",
                    cena = 16.94,
                    poprzednia_cena = 42.51,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 27,
                    nazwa_produkt = "Call of Duty: World at War DE  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Germany. Call of Duty is back, redefining war like you've never experienced before. Building on the Call of Duty 4®: Modern Warfare engine, Call of Duty: World at War immerses players into the most gritty and chaotic WWII combat ever experienced. Players band together to survive the most harrowing and climactic battles that led to the demise of the Axis powers on the European and Pacific fronts. The title offers an uncensored experience with unique enemies and combat variety, including Kamikaze fighters, ambush attacks, Banzai charges and cunning cover tactics, as well as explosive on-screen action through the all new four-player cooperative campaign. The addictive competitive multiplayer has also been enhanced with new infantry and vehicle-based action, a higher level cap, more weapons, and a host of new Perks, maps and challenges. Features Harsh New Enemies, Environments and Tactics: Face off against ruthless and tactically advanced enemies that will stop at nothing to defend their homelands, from swamp ambushes and tree-top snipers to fearless Kamikaze attacks. Play as a U.S. Marine and Russian conscript across a variety of Pacific and European locations against the fearless Imperial Japanese and elite German soldiers in epic adrenaline-filled infantry, vehicle and airborne missions. Co-Op Campaign Mode, Call of Duty Style: For the first time in the franchise, Call of Duty: World at War introduces co-op play, bringing fresh meaning to “No One Fights Alone”. Campaign co-op features up to four-players online, allowing gamers to experience harrowing campaign missions together for greater camaraderie and tactical execution. Co-op mode incorporates innovative multiplayer components such as challenges, rankings and online stats for deeper re-playability and multiplayer experience bonuses. Co-op mode also features Competitive Co-Op that will show who is really the best player on your team. Enhanced Innovative Multiplayer: Call of Duty: World at War continues the addictive class-based multiplayer action the series is famous for. The addition of vehicle combat with tanks rounds out the highly-successful Call of Duty 4: Modern Warfare multiplayer experience, and features such as persistent stats, player rankings, upgradeable weapons, squad-based gameplay, customizable classes and Perks, have been further enhanced to set a new standard in Call of Duty online warfare. Unprecedented Cinematic Quality in a World at War: Built using the Call of Duty 4: Modern Warfare engine, Call of Duty: World at War utilizes cutting-edge technology including highly-detailed character models, self-shadowing, environmental lighting and amazing special effects to deliver jaw-dropping visuals. Depth of field, rim-lighting and texture-streaming technology bring the adrenaline-pumping combat to life, while physics-enabled battlefields and fire that spreads through environments realistically, immerses players into the harrowing and dynamic combat.  System Requirements Supported OS: Windows XP/Vista/7 Processor: Pentium 4 @ 3 GHz/AMD 64 3200+ Memory: 512 MB (1 GB for Vista) Hard Drive: 8 GB Free DirectX version: DirectX 9.0c Sound: on-board or better Graphics Card: 256 MB (nVidia GeForce 6600/ATI Radeon X1600) ",
                    foto = "call-of-duty-world-at-war_1.jpg",
                    cena = 55.75,
                    poprzednia_cena = 63.79,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 28,
                    nazwa_produkt = "Outlast 2 ",
                    opis = "This is a restricted product and it CANNOT be activated nor played in Australia. Outlast 2 is the sequel to the acclaimed survival horror game Outlast. Set in the same universe as the first game, but with different characters and a different setting, Outlast 2 is a twisted new journey into the depths of the human mind and its dark secrets. No conflict is ever black and white. But once the dust has settled, the victors get to decide who was right and who was wrong. Who is good and who is evil. Human nature pushes us to extremes of violence and depravity, which we then justify by divine inspiration and a promise of paradise to come. Horror rises from desperation and blind faith. OUTLAST 2 will test your faith, pushing players to a place where going mad is the only sane thing to do. System Requirements PC System Requirements: OS: Windows Vista / 7 / 8 / 10, 64-bits Processor: Core i3-530 Memory: 4 GB RAM Graphics: 1GB VRAM NVIDIA Geforce GTX 260 / ATI Radeaon HD 4xxx DirectX: Version 10 Storage: 30 GB available space Sound Card: DirectX Compatible Additional Notes: Specs could be modified prior to release. ",
                    foto = "thumbnail_312.jpg",
                    cena = 112.90,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 29,
                    nazwa_produkt = "Guild Wars 2: Heart of Thorns",
                    opis = "Includes 2 items: Guild Wars 2, Guild wars 2: Heart of Thorns Guild Wars 2: Heart of Thorns is the first expansion for Guild Wars 2. Founded on the idea that the journey is the goal, the Heart of Thorns expansion continues the Guild Wars 2 tradition of challenging the conventions of MMOs to fulfill the promise of what online worlds should be. Features The Mastery System - Explore new training opportunities for your character beyond level 80 and master abilities like hang gliding in the jungle, tearing the bark off of heavily armored Mordrem, or building new collections that earn precursors to a legendary weapon. The Hear of Maguuma - New adventures await you in the heart of the Maguuma Jungle. Confront the growing hordes of Mordremoth's minions, discover allies from ancient civilizations, and battle new enemies. Tackle challenging group content. Explore new open world jungle maps. Experience new events and storylines. Test your mettle in new boss battles. Specializations - Evolve your gameplay. With profession specializations, you'll unlock access to a weapon previously unavailable to your profession as well as new traits, skills, and unique mechanics - all of which will transform your profession into something new. New profession: Revenant - Channel legendary powers to slaughter foes and unleash chaos on the battlefield with our brand new profession: the revenant. Enter the field of battle heavily armored and equipped with the otherworldly powers of the Mists. Guild Halls - Your guild has roamed the world together. Now, it's time to claim a piece of it. Work with fellow guild members to claim and grow your own guild hall in the heart of Maguuma. PVP: New Stronghold Game Mode - Gather supply to hire soldiers. Battle for control of heroes. Man the trebuchet to defend your stronghold, and storm the enemy gates to defeat the guild lord! Use our new guild team feature to team up and battle to the top of the leaderboards. Stronghold offers an entirely new way to play competitive PvP in Guild Wars 2! WvW: New Borderland - Experience epic battlefield combat like never before in World vs. World's latest core addition, the new Borderlands map. Navigate treacherous heights with traps that blow your foes to the depths below and ferocious defenders to help keep the enemy at bay. Map objectives will be more important than ever before, as they'll unlock new strategies, tactics, and play mechanics that you'll want to use to your world's advantage! System Requirements Windows XP Service Pack 3 or better Intel Core 2 Duo 2.0 GHz, Core i3, AMD Athlon 64 X2 or better 2 GB RAM NVIDIA GeForce 7800, ATI Radeon X1800, Intel HD 3000 or better (256MB of video RAM and shader model 3.0 or better) 35 GB available HDD space Broadband Internet connection Keyboard and mouse ",
                    foto = "Bez_tytu_u_19.png",
                    cena = 128.18,
                    poprzednia_cena = 119.12,

                    id_Kategoria = 5,
                    id_Platforma=4,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 30,
                    nazwa_produkt = "Call of Duty: Infinite Warfare Day e ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe, but it CANNOT be activated nor played in Turkey. Includes: The Reimagined, fan-favorite Terminal Bonus Map Zombies in Spaceland Pack of in-game digital items: weapon camo, animated player card, Fate & Fortune card pack Call of Duty is back with Call of Duty: Infinite Warfare! This title will be the most futuristic one yet, with battles happening in space across our entire solar system. With no more resources available on Earth, our citizens have started to depend on colonies on other planets that provide us with resources. Play as Captain Nick Reyes, a member of the United Nations Space Alliance as he does his part to ensure a safe galaxy against the Settlement Defense Front. Whether you fight in the spaceship, in outer space itself or in a more classical foot-on-ground setting, your skills as an FPS player will be put to the test! Features MULTIPLE GAME MODES - Whether you prefer single player or multiplayer, you’re completely covered by Call of Duty: Infinite Warfare. Decide whether you prefer playing the single player campaign or if you want to jump into the highly competitive multiplayer mode immediately! NEW GAMEPLAY MECHANICS - With the introduction of outer space as a battleground, new gameplay mechanics have inevitably been made available. You can now fight in zero gravity, adding a multitude of new options available to creative fighters! In addition to this, the transition from zero gravity gameplay to the more classical on the ground gameplay is completely seamless. TOP-NOTCH GRAPHICS AND CINEMATIC CONTENT - Something we’ve come to expect from the Call of Duty franchise is not only outstanding gameplay but also additional in-game content. Take part in enormous battles and wars with a lot of action going on in the background. Beautiful cinematics throughout the game will enhance your gaming experience as well.  System Requirements OS: Windows 7 64-Bit or later   Processor: Intel Core i3-3225 @ 3.30GHz or equivalent Memory: 8 GB RAM Graphics: NVIDIA GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB DirectX: Version 11 Network: Broadband Internet connection Storage: 70 GB available space Sound Card: DirectX 11 Compatible Additional Notes: Disk space requirement may change over time. ",
                    foto = "header_6265.jpg",
                    cena = 59.28,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 31,
                    nazwa_produkt = "Playerunknown's Battlegrounds ",
                    opis = "PLAYERUNKNOWN'S BATTLEGROUNDS is a last-man-standing shooter being developed with community feedback. Starting with nothing, players must fight to locate weapons and supplies in a battle to be the lone survivor. This realistic, high tension game is set on a massive 8x8 km island with a level of detail that showcases Unreal Engine 4's capabilities. PLAYERUNKNOWN aka Brendan Greene, is a pioneer of the Battle Royale genre. As the creator of the Battle Royale game-mode found in the ARMA series and H1Z1 : King of the Kill, Greene is co-developing the game with veteran team at Bluehole to create the most diverse and robust Battle Royale experience to dateNot Just a Game. This is BATTLE ROYALE System Requirements OS: 64-bit Windows 7, Windows 8.1, Windows 10 Processor: Intel Core i3-4340 / AMD FX-6300 Memory: 6 GB RAM Graphics: nVidia GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB DirectX: Version 11 Network: Broadband Internet connection Storage: 30 GB available space ",
                    foto = "movie.293x165_14_2.jpg",
                    cena = 127.63,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 32,
                    nazwa_produkt = "Call of Duty: Modern Warfare 3 Collecti 2 DLC",
                    opis = "Requires Call of Duty: Modern Warfare 3 on Steam in order to use. Product has been restricted to Europe. COLLECTION 2: TEAM UP. FACE OFF. The second Modern Warfare® 3 DLC Collection launches with all-new Multiplayer/Survival Mode Maps, Special Ops Missions and the debut of Face Off maps. Totally new to the franchise, Face Off distills all the fun and intensity of multiplayer into a new breed of 1 vs. 1 and 2 vs. 2 close combat. In addition to this all-new game-play experience, Collection 2 deploys with 3 multiplayer maps and 2 Special Ops Missions, offering fans new venues to test their Multiplayer and Special Ops skills. Experience an all-new way to play multiplayer with your friends. Totally new to the franchise, Face Off distills all the fun and intensity of multiplayer into a new breed of 1 vs. 1 and 2 vs. 2 close combat. Featuring smaller, super-concentrated multiplayer maps that are specially designed to encourage strategy, skill, and teamwork like never before. Features Sanctuary: Suspended in the air one thousand feet up, you'll battle more than altitude in the towering sandstone monasteries of Central Greece. Formed over millions of years, this sanctuary's natural rock pillars have repelled invading armies and withstood the ravages of time but now they'll face your deployment. Test your skills—and the ancient monks' craftsmanship—with your arsenal of SMG's, assault rifles and shotguns. Just remember: don't look down. Foundation: Journey into the heart of South Korea for a decommissioned concrete factory where the cement flows and bullets fly. After decades of constructing roads and buildings, the towering facility is now a perfectly-constructed combat zone for sniping and run-and-gun rules of engagement. Don't stand in awe of the towering concrete crusher at the center of the factory unless you want to see your kill ratio meet the same fate. Oasis: Though once a picturesque escape for vacationers, the sprawling Hotel Oasis is now a Multiplayer paradise, with multiple lanes of combat built atop an ancient fortress. Kill Switch: An intense new Special Ops Mission that places your two-man team deep in enemy territory. Your mission - cripple a Russian carrier by detonating an Electromagnetic Pulse. Be the soldier on the ground, making your way to the detonation site, or play the sniper providing vital cover fire from a vantage point high above the city. Work together or risk getting overrun by a horde of hostile forces. Iron Clad: With one player helming an Abrams-class tank and the other escorting it on foot, you’ll clear beaches and take cover in plane wreckage as you escape Hamburg from behind enemy lines in this all-new Special Ops Mission. Getaway: The first “Face Off” map in Modern Warfare® franchise history, what once was a tropical beach getaway boasting exotic aquariums and oversized pools is now a haven for ruthless run-and-gun violence. Lookout: Carved into a combat-weary mountainside, this new “Face Off” map pits you against your opposition in a forward observation base littered in chokepoints and tight corridors. Erosion: Make your way through Mediterranean ruins and ancient aqueducts, using leftover Roman masonry for thousand-year-old cover in this new “Face Off” map. Aground: Head to Scotland’s Orkney Islands for the latest “Face Off” map, where treacherous cliff faces, networks of caves and the rusted and ruined remains of a grounded transport ship provide for constant combat.  System Requirements OS: Windows® XP/ Windows® Vista / Windows® 7 Processor: Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better Memory: 2 GB RAM Hard Disk Space: 16 GB free hard drive space Video Card: Shader 3.0 or better 256 MB NVIDIA® GeForce™ 8600GT / ATI® Radeon™ X1950 or better DirectX®: DirectX® 9.0c or later Internet: Broadband connection and service required for Multiplayer Connectivity. Internet connection required for activation. ",
                    foto = "bli_1_4.jpg",
                    cena = 23.89,
                    poprzednia_cena = 27.63,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 33,
                    nazwa_produkt = "Playerunknown's Battlegrounds ",
                    opis = "PLAYERUNKNOWN'S BATTLEGROUNDS is a last-man-standing shooter being developed with community feedback. Starting with nothing, players must fight to locate weapons and supplies in a battle to be the lone survivor. This realistic, high tension game is set on a massive 8x8 km island with a level of detail that showcases Unreal Engine 4's capabilities. PLAYERUNKNOWN aka Brendan Greene, is a pioneer of the Battle Royale genre. As the creator of the Battle Royale game-mode found in the ARMA series and H1Z1 : King of the Kill, Greene is co-developing the game with veteran team at Bluehole to create the most diverse and robust Battle Royale experience to dateNot Just a Game. This is BATTLE ROYALE System Requirements OS: 64-bit Windows 7, Windows 8.1, Windows 10 Processor: Intel Core i3-4340 / AMD FX-6300 Memory: 6 GB RAM Graphics: nVidia GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB DirectX: Version 11 Network: Broadband Internet connection Storage: 30 GB available space ",
                    foto = "movie.293x165_14_2.jpg",
                    cena = 127.63,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 34,
                    nazwa_produkt = "Call of Duty: Modern Warfare 3 Collecti 2 DLC",
                    opis = "Requires Call of Duty: Modern Warfare 3 on Steam in order to use. Product has been restricted to Europe. COLLECTION 2: TEAM UP. FACE OFF. The second Modern Warfare® 3 DLC Collection launches with all-new Multiplayer/Survival Mode Maps, Special Ops Missions and the debut of Face Off maps. Totally new to the franchise, Face Off distills all the fun and intensity of multiplayer into a new breed of 1 vs. 1 and 2 vs. 2 close combat. In addition to this all-new game-play experience, Collection 2 deploys with 3 multiplayer maps and 2 Special Ops Missions, offering fans new venues to test their Multiplayer and Special Ops skills. Experience an all-new way to play multiplayer with your friends. Totally new to the franchise, Face Off distills all the fun and intensity of multiplayer into a new breed of 1 vs. 1 and 2 vs. 2 close combat. Featuring smaller, super-concentrated multiplayer maps that are specially designed to encourage strategy, skill, and teamwork like never before. Features Sanctuary: Suspended in the air one thousand feet up, you'll battle more than altitude in the towering sandstone monasteries of Central Greece. Formed over millions of years, this sanctuary's natural rock pillars have repelled invading armies and withstood the ravages of time but now they'll face your deployment. Test your skills—and the ancient monks' craftsmanship—with your arsenal of SMG's, assault rifles and shotguns. Just remember: don't look down. Foundation: Journey into the heart of South Korea for a decommissioned concrete factory where the cement flows and bullets fly. After decades of constructing roads and buildings, the towering facility is now a perfectly-constructed combat zone for sniping and run-and-gun rules of engagement. Don't stand in awe of the towering concrete crusher at the center of the factory unless you want to see your kill ratio meet the same fate. Oasis: Though once a picturesque escape for vacationers, the sprawling Hotel Oasis is now a Multiplayer paradise, with multiple lanes of combat built atop an ancient fortress. Kill Switch: An intense new Special Ops Mission that places your two-man team deep in enemy territory. Your mission - cripple a Russian carrier by detonating an Electromagnetic Pulse. Be the soldier on the ground, making your way to the detonation site, or play the sniper providing vital cover fire from a vantage point high above the city. Work together or risk getting overrun by a horde of hostile forces. Iron Clad: With one player helming an Abrams-class tank and the other escorting it on foot, you’ll clear beaches and take cover in plane wreckage as you escape Hamburg from behind enemy lines in this all-new Special Ops Mission. Getaway: The first “Face Off” map in Modern Warfare® franchise history, what once was a tropical beach getaway boasting exotic aquariums and oversized pools is now a haven for ruthless run-and-gun violence. Lookout: Carved into a combat-weary mountainside, this new “Face Off” map pits you against your opposition in a forward observation base littered in chokepoints and tight corridors. Erosion: Make your way through Mediterranean ruins and ancient aqueducts, using leftover Roman masonry for thousand-year-old cover in this new “Face Off” map. Aground: Head to Scotland’s Orkney Islands for the latest “Face Off” map, where treacherous cliff faces, networks of caves and the rusted and ruined remains of a grounded transport ship provide for constant combat.  System Requirements OS: Windows® XP/ Windows® Vista / Windows® 7 Processor: Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better Memory: 2 GB RAM Hard Disk Space: 16 GB free hard drive space Video Card: Shader 3.0 or better 256 MB NVIDIA® GeForce™ 8600GT / ATI® Radeon™ X1950 or better DirectX®: DirectX® 9.0c or later Internet: Broadband connection and service required for Multiplayer Connectivity. Internet connection required for activation. ",
                    foto = "bli_1_4.jpg",
                    cena = 23.89,
                    poprzednia_cena = 127.63,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 35,
                    nazwa_produkt = "MiddleEarth: Shadow of War ",
                    opis = "Available to play on 25th August 2017! Go behind enemy lines to forge your army, conquer Fortresses and dominate Mordor from within. Experience how the award-winning Nemesis System creates unique personal stories with every enemy and follower, and confront the full power of the Dark Lord Sauron and his Ringwraiths in this epic new story of Middle-earth. In Middle-earth: Shadow of War, nothing will be forgotten. System Requirements PC System Requirements: OS: Windows 7 SP1 with Platform Update for Windows 7 Processor: Intel i5- 2550K, 3.4 GHz Memory: 8 GB RAM Graphics: GeForce 670 | Radeon HD 7950 DirectX: Version 11 Network: Broadband Internet connection Storage: 60 GB available space ",
                    foto = "header2_72.jpg",
                    cena = 237.73,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 36,
                    nazwa_produkt = "Minecraft Windows 10  ",
                    opis = "Worlds/saves from the Java PC/Mac version of Minecraft are not compatible with the Minecraft: Windows 10 Edition! Explore randomly generated worlds and build amazing things from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons and armor to fend off the dangerous mobs. Craft, create, and explore alone, or with friends on mobile devices or Windows 10. Millions of crafters around the world have smashed billions of blocks - now you can join in the fun on Windows 10! Join in the development process with beta access to Minecraft: Windows 10 Edition and provide your feedback to shape the game in future updates! Features Skins, texture, and mash-up packs! We have biome settlers, city folk, town folk, and more! ADD-ONS! Learn more at minecraft.net/addons, where you can try some examples for free or learn to create your own. Realms! Play with up to 10 friends cross-platform in worlds that exist anytime, anywhere. The Nether and all its inhabitants. Fight Ghasts and make friends with Pigmen Cross platform play for up to five players between Pocket Edition and Windows 10 Redstone! Pistons, comparators, repeaters, dispensers, droppers, and more! Spooky witches and their huts, complete with cauldrons filled with random potions and the ability to dye armor Ocelots! And bunnies! Slash commands to let you tweak how the game plays - you can give items away, summon mobs, change the time of day, and more. System Requirements OS: Windows 10 x64, x86",
                    foto = "logo_1940.jpg",
                    cena = 13.06,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 37,
                    nazwa_produkt = "MiddleEarth: Shadow of Mordor  GOTY  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. Requires the base game Middle-Earth: Shadow of Mordor on Steam in order to play. Middle-Earth: Shadow of Mordor - GOTY Edition Upgrade and the previously available Season Pass are the same product. If you had previously purchased Middle-earth: Shadow of Mordor Premium Edition, you are already entitled to all the content of the Upgrade. Includes 30 items: The Lord of the Hunt Story Pack, The Bright Lord Story Pack, Test of Power Challenge Mode, Test of Speed Challenge Mode, Test of Wisdom Challenge Mode, Test of the Wild Challenge Mode, Test of the Ring Challenge Mode, Endless Challenge Mode, Test of Defiance, The Dark Ranger Skin, Captain of the Watch Skin, Lord of the Hunt Skin, The Bright Lord Skin, Power of Shadow Skin, Lithariel Skin, Hidden Blade Rune, Deadly Archer Rune, Flame of Anor Rune, Rising Storm Rune, Orc Slayer Rune, Defiant to the End Rune, Elven Grace Rune, Ascendant Rune, One with Nature Rune, Guardians of the Flaming Eye Warband Mission, The Berserks Warband Mission -The Skull Crushers Warband Mission, The Bloodhunters Mission, The Flesh Burners Mission and Photo Mode. In Middle-earth: Shadow of Mordor, gamers take on the role of Talion, a valiant ranger whose family is slain in front of him the night Sauron and his army return to Mordor, moments before his own life is taken. Resurrected by a Spirit of vengeance and empowered with Wraith abilities, Talion ventures into Mordor and vows to destroy those who have wronged him. Through the course of his personal vendetta, Talion uncovers the truth of the Spirit that compels him, learns the origins of the Rings of Power and ultimately confronts his true nemesis. Every enemy that players face is a unique individual, differentiated by their personality, strengths and weaknesses. Through the Nemesis System, enemy relationships and characteristics are shaped by player actions and decisions to create personal archenemies that remember and adapt to the player and are distinct to every gameplay session. Gamers are able to craft their own battles, enemies and rewards within the dynamic world that remembers and adapts to their choices, delivering a unique experience to every player. System Requirements PC System Requirements: OS: 64-bit: Vista SP2, Win 7 SP1, Win 8.1 Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 3 GB RAM Graphics: NVIDIA GeForce GTX 460 | AMD Radeon HD 5850 DirectX: Version 11 Network: Broadband Internet connection Storage: 44 GB available space Mac System Requirements: OS: Mac OS X 10.10.3 Processor: 2.4 GHz Intel Memory: 8 GB RAM Graphics: 1GB Nvidia 650M or later, AMD 7xxx series or later and Intel Iris Pro. Network: Broadband Internet connection Storage: 67 GB available space Additional Notes: Requires Keyboard & Multi-button Mouse Linux / SteamOS System Requirements: OS: Ubuntu 14.04.2 64-bit / SteamOS Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 4 GB RAM Graphics: 1GB NVIDIA 640 or better with driver version 352.21 or later Network: Broadband Internet connection Storage: 47 GB available space Additional Notes: AMD and Intel cards are NOT supported. If you wish to play the game using an AMD graphics card, you should update your graphics driver to version Catalyst 15.7 or higher. You should be able to run the game without experiencing stability issues or graphical glitches, but you may still experience poor performance. ",
                    foto = "header_2740_2.jpg",
                    cena = 23.89,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 38,
                    nazwa_produkt = "10 x Random  ",
                    opis = "METACRITIC SCORE 60 AND UP - we give you only good games! MONEY BACK GUARANTEE - if you already own the game, you can return it (if you have Buyer Protection included). Random Steam Key - it's something for anyone who likes surprises and good games. Why? Because we guarantee that the game you purchase with Random Steam Key will be at least of a score of 60 on Metacritic and if the title does not have metascore, it will have 50% or more positive overall reviews on Steam! But that's not all - we know you love cheap games and we are here to deliver. Prices of Random Steam games start at €2.99 (Steam sales are not considered) and if the game you get is cheaper on Steam, you will get the price difference in store balance. If you already have the game in your Library, you will be able to return the Random Steam Key to the shop and get your money back for the game in question (applies only to orders that include Buyer Protection). System Requirements Every game has different requirements!",
                    foto = "random_1__2.jpg",
                    cena = 18.13,
                    poprzednia_cena = 42.51,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 39,
                    nazwa_produkt = "Killing Floor 2  Deluxe ",
                    opis = "Requires Killing Floor 2 in order to use! KILLING FLOOR 2 Digital Deluxe Upgrade adds the following to the base game:  DJ Scully character, with unique voice pack and set of face/body skins  Additional cosmetic items (each with multiple selectable variants):  “Scullyphones” headphones for DJ Scully, Mr Foster, Hayato Tanaka and Donovan Neal  3D Glasses for Ana Larive and Hayato Tanaka  Bowler Hat for Mr. Foster and Reverend Alberts  Killing Floor 2 Soundtrack  Killing Floor 2 Digital Artbook AND a copy of the first Killing Floor! In KILLING FLOOR 2 players descend into continental Europe where the outbreak caused by Horzine Biotech’s failed experiment has quickly spread and gained unstoppable momentum, essentially paralyzing the European Union. Just one month after the conclusion of the events in the original KILLING FLOOR, the specimen clones are everywhere and civilization is in disarray; communications have failed, governments have collapsed, and military forces have been systematically eradicated. The people of Europe know survival and self-preservation too well and lucky survivors have gone into hiding. Not all have given up hope though... A group of civilians and mercenaries have banded together, paid for by Horzine, to combat the outbreak and established privately funded operation bases across Europe. Upon tracking specimen clone outbreaks, players will descend into zed-laden hot zones and exterminate them. Features Visceral Gore - KILLING FLOOR 2 ramps up the gore with a proprietary, high powered persistent blood system bringing new levels of fidelity to the genre. Players will send entrails, severed limbs, and blood flying as they wade through hordes of enemies. But they need to watch out! If caught, enemies will rip them, and their entire party limb from limb 6 player co-op or solo play - A multitude of varied playable characters await for players to choose from as they enter the fray in online co-op mode or solo mode for those willing to brave the horrific specimens alone. Terrifying Zeds - New enemies and fan favorites from the original game are back with expanded and smarter artificial intelligence, dishing out powerful attacks, attacking in mobs to weaken the player’s party and pushing the challenge level and fear factor to new levels. New take on Difficulty - Most games just ramp up health and damage for the enemies. In KF2, the Zeds will start to behave differently as you work through the difficulty levels. New attack moves. New ways to get at you. New strategies. Be prepared for surprises! Unique Blend Of Weaponry - Modern military assault rifles, brutal improvised makeshift weapons, classic historical guns, and off the wall “Mad Scientist” weapons, KILLING FLOOR 2 has a unique blend of killing tools that will satisfy any gamer. Expanded Perk System - Perks from the original game have been reimagined with more added to the fold. All perks now progress with meaningful talent choices that amplify different play styles, giving players a progression path that is expansive and full of rewarding milestones. Brutal Melee Combat - KILLING FLOOR 2 reinvents melee combat completely. Players now have control over the type of melee attacks they can perform, enabling them to deliver bone-breaking crippling attacks to Zeds. SDK - as always with our games, the tools to create maps and so much more! With Early Access, this will allow the creation of new levels. The full SDK support will be rolled out through the Early Access period. System Requirements PC System Requirements OS: Win7 64-bit, Win8/8.1 64-bit Processor: Core 2 Duo E8200 2.66GHz or Phenom II X2 545 Memory: 3 GB RAM Graphics: GeForce GTS 250 or Radeon HD 4830 DirectX: Version 10 Network: Broadband Internet connection Hard Drive: 10 GB available space Additional Notes: UNSUPPORTED HARDWARE: IntelHD Integrated Graphics Chips, 32-bit Operating Systems ",
                    foto = "Killing-Floor-2_1.jpg",
                    cena = 33.47,
                    poprzednia_cena = 127.63,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 40,
                    nazwa_produkt = "Diablo 3 Battlechest  Battle ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. The Diablo III: Battle Chest includes Diablo III and the Reaper of Souls expansion to provide the ultimate Diablo III experience. Shake the earth, blast your enemies with fire and ice, and summon otherworldly minions as you wield the powers of your heroic birthright. Features The Hells AwaitNow is the time for you to conquer evil and save all of Sanctuary. Defeat the Prime Evils and the Angel of Death in five epic acts with six formidable character classes. Once you're finished with the campaign, take on Adventure Mode for unlimited challenges and rewards. Vanquish infinite evilsLay waste to the wicked legions in unique 3D environments. Face innumerable demonic villains, uncover quests in new locations, and claim different loot every time you play. No two games are ever the same. Dare Sanctuary’s dark worldFrom the fabled spires of Caldeum to the besieged walls of Bastion’s Keep, the mortal world has fallen under the corrupting influence of infernal powers. Come to Sanctuary’s defense as it teeters on the brink of demonic annihilation. Amass untold richesCollect a dizzying array of treasures as you defeat the minions of Diablo. Equip, upgrade, and craft powerful weapons and armor as you grow into a legendary hero. Fight alongside your friendsTake on the demonic horde with up to three other friends on Battle.net, Blizzard’s free online gaming service. Scale the difficulty (and the loot) to as much as you and your party can handle. Conquer new gameplay modesAfter you finish the campaign, Adventure Mode opens up all of Sanctuary by allowing access to any waypoint in any Act. It also introduces Bounties and Nephalem Rifts, two new game features with boundless replay value.  System Requirements PC System Requirements: OS: Windows® XP/Windows Vista/Windows 7/Windows 8 (latest service packs) with DX 9.0c Processor: Intel Pentium® D 2.8 GHz or AMD Athlon™ 64 X2 4400+ Video: NVIDIA® GeForce® 7800 GT or ATI Radeon™ X1950 Pro or better Memory: 1 GB RAM (XP), 1.5 GB (Windows Vista/Windows 7/Windows 8) Storage: 12 GB available HD space Internet: Broadband Internet connection Media: DVD-ROM (required for retail disc versions only) Resolution: 1024x768 minimum display resolution Mac System Requirements: OS: Mac® OS X 10.8 Processor: Intel® Core 2 Duo Video: NVIDIA® GeForce® 8600M GT or ATI Radeon™ HD 2600 or better Memory: 2 GB RAM Storage: 12 GB available HD space Internet: Broadband Internet connection Media: DVD-ROM (required for retail disc versions only) Resolution: 1024x768 minimum display resolution ",
                    foto = "logo_1349_2.jpg",
                    cena = 112.56,
                    poprzednia_cena = 42.56,

                    id_Kategoria = 5,
                    id_Platforma=3,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 41,
                    nazwa_produkt = "Killing Floor + Defence Alliance 2 ",
                    opis = "Includes 2 items: Killing Floor and Defence Alliance 2 Killing FloorKilling Floor is a Co-op Survival Horror FPS set in the devastated cities and countryside of England after a series of cloning experiments for the military goes horribly wrong. You and your friends are members of the military dropped into these locations with a simple mission: Survive long enough to cleanse the area of the failed experiments! Defence Alliance 2Defence Alliance 2 is a total conversion mod for Killing Floor featuring team based futuristic FPS game play. DA2 blends fast paced action with class based tactics to create an experience that is instantly enjoyable while still offering very deep gameplay. Two teams face off in attack/defend scenarios where the attackers must complete their objectives before time runs out. The mod features six different classes: Medic, Mechanic, Rocketeer, Machine Gunner, Sniper and the Rifleman, each with their own special abilities. Players can set up their own turrets such as cannons, miniguns, and rocket turrets, place ammo boxes, heal other players, use EMP grenades and rocket launchers against turrets, and more.In addition to the regular DA2 gameplay mode, Defence Alliance 2 for Killing Floor now features a new gameplay mod called Co-op Specimen Survival. A small group of players are set against waves of specimens. Players can use turrets and mines to build up their defense then have a limited amount of respawns with which to defeat the waves of incoming specimens. System Requirements OS: Windows XP/Vista Processor: 1.2 GHZ or Equivalent Memory: 1 GB RAM Graphics: 64 MB DX9 Compliant Hard Drive: 2 GB free hard drive space Sound: DX 8.1 Compatible Audio ",
                    foto = "logo_99.png",
                    cena = 14.63,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 42,
                    nazwa_produkt = "MiddleEarth: Shadow of Mordor  GOTY  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. Requires the base game Middle-Earth: Shadow of Mordor on Steam in order to play. Middle-Earth: Shadow of Mordor - GOTY Edition Upgrade and the previously available Season Pass are the same product. If you had previously purchased Middle-earth: Shadow of Mordor Premium Edition, you are already entitled to all the content of the Upgrade. Includes 30 items: The Lord of the Hunt Story Pack, The Bright Lord Story Pack, Test of Power Challenge Mode, Test of Speed Challenge Mode, Test of Wisdom Challenge Mode, Test of the Wild Challenge Mode, Test of the Ring Challenge Mode, Endless Challenge Mode, Test of Defiance, The Dark Ranger Skin, Captain of the Watch Skin, Lord of the Hunt Skin, The Bright Lord Skin, Power of Shadow Skin, Lithariel Skin, Hidden Blade Rune, Deadly Archer Rune, Flame of Anor Rune, Rising Storm Rune, Orc Slayer Rune, Defiant to the End Rune, Elven Grace Rune, Ascendant Rune, One with Nature Rune, Guardians of the Flaming Eye Warband Mission, The Berserks Warband Mission -The Skull Crushers Warband Mission, The Bloodhunters Mission, The Flesh Burners Mission and Photo Mode. In Middle-earth: Shadow of Mordor, gamers take on the role of Talion, a valiant ranger whose family is slain in front of him the night Sauron and his army return to Mordor, moments before his own life is taken. Resurrected by a Spirit of vengeance and empowered with Wraith abilities, Talion ventures into Mordor and vows to destroy those who have wronged him. Through the course of his personal vendetta, Talion uncovers the truth of the Spirit that compels him, learns the origins of the Rings of Power and ultimately confronts his true nemesis. Every enemy that players face is a unique individual, differentiated by their personality, strengths and weaknesses. Through the Nemesis System, enemy relationships and characteristics are shaped by player actions and decisions to create personal archenemies that remember and adapt to the player and are distinct to every gameplay session. Gamers are able to craft their own battles, enemies and rewards within the dynamic world that remembers and adapts to their choices, delivering a unique experience to every player. System Requirements PC System Requirements: OS: 64-bit: Vista SP2, Win 7 SP1, Win 8.1 Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 3 GB RAM Graphics: NVIDIA GeForce GTX 460 | AMD Radeon HD 5850 DirectX: Version 11 Network: Broadband Internet connection Storage: 44 GB available space Mac System Requirements: OS: Mac OS X 10.10.3 Processor: 2.4 GHz Intel Memory: 8 GB RAM Graphics: 1GB Nvidia 650M or later, AMD 7xxx series or later and Intel Iris Pro. Network: Broadband Internet connection Storage: 67 GB available space Additional Notes: Requires Keyboard & Multi-button Mouse Linux / SteamOS System Requirements: OS: Ubuntu 14.04.2 64-bit / SteamOS Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 4 GB RAM Graphics: 1GB NVIDIA 640 or better with driver version 352.21 or later Network: Broadband Internet connection Storage: 47 GB available space Additional Notes: AMD and Intel cards are NOT supported. If you wish to play the game using an AMD graphics card, you should update your graphics driver to version Catalyst 15.7 or higher. You should be able to run the game without experiencing stability issues or graphical glitches, but you may still experience poor performance. ",
                    foto = "header_2740_2.jpg",
                    cena = 23.89,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 43,
                    nazwa_produkt = "Diablo 3 Battlechest  Battle ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. The Diablo III: Battle Chest includes Diablo III and the Reaper of Souls expansion to provide the ultimate Diablo III experience. Shake the earth, blast your enemies with fire and ice, and summon otherworldly minions as you wield the powers of your heroic birthright. Features The Hells AwaitNow is the time for you to conquer evil and save all of Sanctuary. Defeat the Prime Evils and the Angel of Death in five epic acts with six formidable character classes. Once you're finished with the campaign, take on Adventure Mode for unlimited challenges and rewards. Vanquish infinite evilsLay waste to the wicked legions in unique 3D environments. Face innumerable demonic villains, uncover quests in new locations, and claim different loot every time you play. No two games are ever the same. Dare Sanctuary’s dark worldFrom the fabled spires of Caldeum to the besieged walls of Bastion’s Keep, the mortal world has fallen under the corrupting influence of infernal powers. Come to Sanctuary’s defense as it teeters on the brink of demonic annihilation. Amass untold richesCollect a dizzying array of treasures as you defeat the minions of Diablo. Equip, upgrade, and craft powerful weapons and armor as you grow into a legendary hero. Fight alongside your friendsTake on the demonic horde with up to three other friends on Battle.net, Blizzard’s free online gaming service. Scale the difficulty (and the loot) to as much as you and your party can handle. Conquer new gameplay modesAfter you finish the campaign, Adventure Mode opens up all of Sanctuary by allowing access to any waypoint in any Act. It also introduces Bounties and Nephalem Rifts, two new game features with boundless replay value.  System Requirements PC System Requirements: OS: Windows® XP/Windows Vista/Windows 7/Windows 8 (latest service packs) with DX 9.0c Processor: Intel Pentium® D 2.8 GHz or AMD Athlon™ 64 X2 4400+ Video: NVIDIA® GeForce® 7800 GT or ATI Radeon™ X1950 Pro or better Memory: 1 GB RAM (XP), 1.5 GB (Windows Vista/Windows 7/Windows 8) Storage: 12 GB available HD space Internet: Broadband Internet connection Media: DVD-ROM (required for retail disc versions only) Resolution: 1024x768 minimum display resolution Mac System Requirements: OS: Mac® OS X 10.8 Processor: Intel® Core 2 Duo Video: NVIDIA® GeForce® 8600M GT or ATI Radeon™ HD 2600 or better Memory: 2 GB RAM Storage: 12 GB available HD space Internet: Broadband Internet connection Media: DVD-ROM (required for retail disc versions only) Resolution: 1024x768 minimum display resolution ",
                    foto = "logo_1349_2.jpg",
                    cena = 112.56,
                    poprzednia_cena = 42.51,

                    id_Kategoria = 5,
                    id_Platforma=3,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 44,
                    nazwa_produkt = "10 x Random  ",
                    opis = "METACRITIC SCORE 60 AND UP - we give you only good games! MONEY BACK GUARANTEE - if you already own the game, you can return it (if you have Buyer Protection included). Random Steam Key - it's something for anyone who likes surprises and good games. Why? Because we guarantee that the game you purchase with Random Steam Key will be at least of a score of 60 on Metacritic and if the title does not have metascore, it will have 50% or more positive overall reviews on Steam! But that's not all - we know you love cheap games and we are here to deliver. Prices of Random Steam games start at €2.99 (Steam sales are not considered) and if the game you get is cheaper on Steam, you will get the price difference in store balance. If you already have the game in your Library, you will be able to return the Random Steam Key to the shop and get your money back for the game in question (applies only to orders that include Buyer Protection). System Requirements Every game has different requirements!",
                    foto = "random_1__2.jpg",
                    cena = 18.13,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 45,
                    nazwa_produkt = "Killing Floor 2  Deluxe ",
                    opis = "Requires Killing Floor 2 in order to use! KILLING FLOOR 2 Digital Deluxe Upgrade adds the following to the base game:  DJ Scully character, with unique voice pack and set of face/body skins  Additional cosmetic items (each with multiple selectable variants):  “Scullyphones” headphones for DJ Scully, Mr Foster, Hayato Tanaka and Donovan Neal  3D Glasses for Ana Larive and Hayato Tanaka  Bowler Hat for Mr. Foster and Reverend Alberts  Killing Floor 2 Soundtrack  Killing Floor 2 Digital Artbook AND a copy of the first Killing Floor! In KILLING FLOOR 2 players descend into continental Europe where the outbreak caused by Horzine Biotech’s failed experiment has quickly spread and gained unstoppable momentum, essentially paralyzing the European Union. Just one month after the conclusion of the events in the original KILLING FLOOR, the specimen clones are everywhere and civilization is in disarray; communications have failed, governments have collapsed, and military forces have been systematically eradicated. The people of Europe know survival and self-preservation too well and lucky survivors have gone into hiding. Not all have given up hope though... A group of civilians and mercenaries have banded together, paid for by Horzine, to combat the outbreak and established privately funded operation bases across Europe. Upon tracking specimen clone outbreaks, players will descend into zed-laden hot zones and exterminate them. Features Visceral Gore - KILLING FLOOR 2 ramps up the gore with a proprietary, high powered persistent blood system bringing new levels of fidelity to the genre. Players will send entrails, severed limbs, and blood flying as they wade through hordes of enemies. But they need to watch out! If caught, enemies will rip them, and their entire party limb from limb 6 player co-op or solo play - A multitude of varied playable characters await for players to choose from as they enter the fray in online co-op mode or solo mode for those willing to brave the horrific specimens alone. Terrifying Zeds - New enemies and fan favorites from the original game are back with expanded and smarter artificial intelligence, dishing out powerful attacks, attacking in mobs to weaken the player’s party and pushing the challenge level and fear factor to new levels. New take on Difficulty - Most games just ramp up health and damage for the enemies. In KF2, the Zeds will start to behave differently as you work through the difficulty levels. New attack moves. New ways to get at you. New strategies. Be prepared for surprises! Unique Blend Of Weaponry - Modern military assault rifles, brutal improvised makeshift weapons, classic historical guns, and off the wall “Mad Scientist” weapons, KILLING FLOOR 2 has a unique blend of killing tools that will satisfy any gamer. Expanded Perk System - Perks from the original game have been reimagined with more added to the fold. All perks now progress with meaningful talent choices that amplify different play styles, giving players a progression path that is expansive and full of rewarding milestones. Brutal Melee Combat - KILLING FLOOR 2 reinvents melee combat completely. Players now have control over the type of melee attacks they can perform, enabling them to deliver bone-breaking crippling attacks to Zeds. SDK - as always with our games, the tools to create maps and so much more! With Early Access, this will allow the creation of new levels. The full SDK support will be rolled out through the Early Access period. System Requirements PC System Requirements OS: Win7 64-bit, Win8/8.1 64-bit Processor: Core 2 Duo E8200 2.66GHz or Phenom II X2 545 Memory: 3 GB RAM Graphics: GeForce GTS 250 or Radeon HD 4830 DirectX: Version 10 Network: Broadband Internet connection Hard Drive: 10 GB available space Additional Notes: UNSUPPORTED HARDWARE: IntelHD Integrated Graphics Chips, 32-bit Operating Systems ",
                    foto = "Killing-Floor-2_1.jpg",
                    cena = 33.47,
                    poprzednia_cena = 127.63,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 46,
                    nazwa_produkt = "Tricky Towers  ",
                    opis = "With your brilliant robe and magic powers, it’s time to build some Tricky Towers!  Stack your bricks to create a stable tower and try to topple those of your opponents. Cast magic to support your structure and fend off the dark spells of your rivals in this frantic physics party game.  Play with up to 4 friends in local multiplayer or challenge players around the world in an online battle. Train your skills with the extensive single player trials and set a high score on the leaderboards.  With spells flying everywhere and bricks tumbling down, Tricky Towers makes for a chaotically good time! Features Frantic physics action puzzle gameplay  Local and online multiplayer with 2-4 players  3 different multiplayer modes; race, survival and puzzle  Challenging single player trials  Leaderboard mode: compare how you stack up  17 Powerful light and dark magic spells System Requirements PC: OS: Windows XP  Processor: 1.73 GHz Intel Pentium M or higher  Memory: 1 GB RAM  DirectX: Version 10  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer Mac OS X: OS: OSX 10.8  Processor: Dual core or higher  Memory: 2 GB RAM  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer SteamOS + Linux: OS: Steam OS  Processor: 2GHZ or higher  Memory: 2 GB RAM  Network: Broadband Internet connection  Storage: 400 MB available space  Additional Notes: Controllers needed for local multiplayer ",
                    foto = "header_7473.jpg",
                    cena = 16.94,
                    poprzednia_cena = 42.56,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 47,
                    nazwa_produkt = "Sid Meier's Civilizati VI",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. After a long wait, the Civilization series is back with Civilization VI, promising to break new territory as it always does. The king of turn-based strategy video games looks to grow on its past releases by releasing a re-worked version of the fan favorite game. In addition to new civilizations, there will be completely new artwork, a big part of any Civilization release. With this fresh look, the developers look to bring back not only seasoned veterans of the series, but new players as well Features EXPAND YOUR CITY - Cities will now span over more than one tile! More planning will be required but the rewards will be well worth it. Make sure that the building you decide to build is on the best corresponding terrain tile; take advantage of new special bonuses. ACTIVE PROGRESSION - The technology tree has also undergone some tweaking. The environment you explore and where you begin in Civilization VI affects you! Have a more active say in the direction your civilization develops. Be sure to explore and be much more active in all facets of the game to ensure quick and steady growth. CONTROL THE BATTLE WITH COMBINED ARMS - You are now given more control of your armies and can better take advantage of their unique skills to benefit your civilization as a whole. Units can now be used together to help support each other such as combining anti-tank support with infantry. Units which are the same can also be combined to create more powerful units! System Requirements OS: Windows 7x64 / Windows 8.1x64 / Windows 10x64 Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater Memory: 4 GB RAM Graphics: 1 GB & AMD 5570 or nVidia 450 DirectX: Version 11 Storage: 12 GB available space Sound Card: DirectX Compatible Sound Device Additional Notes: Initial installation requires one-time Internet connection for Steam authentication; software installations required (included with the game) include Steam Client, Microsoft Visual C++ 2012 and 2015 Runtime Libraries, and Microsoft DirectX. Internet connection and acceptance of Steam™ Subscriber Agreement required for activation. ",
                    foto = "header_6393.jpg",
                    cena = 140.01,
                    poprzednia_cena = 63.79,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 48,
                    nazwa_produkt = "SpellForce 3",
                    opis = "This is a PRE-ORDER, the key will be delivered upon release. Released in 2017. SpellForce 3 - The perfect blend between RTS and RPG! SpellForce 3 goes back to the roots of the SpellForce saga. The story takes place before the acclaimed SpellForce: The Order of Dawn and the players becomes a part of a rich high fantasy world named Eo. Features RTS/RPG Mix: Unique gameplay combining RTS and Top Down RPG genres Create & Customize: Create your own hero and develop his skillset as you prefer! Build to Fight: Build your own army and fight epic mass battles with it. Epic Storyline: Unravel a deep and epic story in the SpellForce universe that doesnt require having played any of the former SpellForce games. Fans will still find a lot of interesting connections. Rich universe & lore: Explore the world Eo and discover intrigues, secrets and a lot of loot for your hero. Apply some tactics: Use advance tactics with your RTS army to defeat your enemies Play on your own: Long Single Player Campaign of 30+ hours Multiplayer: Strong multiplayer component with various modes - Play cooperatively or compete against each other System Requirements OS: Windows 7, 8, Windows 10 (64 bit) Processor: Intel Core 2 Duo @ 2Ghz / AMD Athlon 64 X2 equivalent Memory: 2 GB RAM Graphics: 1024 MB Direct3D 11 capable video card (GeForce GTX 470 or Radeon HD 5850) DirectX: Version 11 Storage: 10 GB available space Sound Card: DirectX compatible Sound card Additional Notes: These are preliminary system specs that can and will change! ",
                    foto = "images_332.jpg",
                    cena = 168.14,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 1,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 49,
                    nazwa_produkt = "Dead Rising 4 ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe, the Middle East and Africa. Dead Rising 4 marks the return of photojournalist Frank West in an all-new chapter of one of the most popular zombie game franchises of all time. All of the classic hallmarks of the ground breaking series return, including a huge array of weapons and vehicles players can combine to combat the horde ranging from the practical - to the practically insane. Players will also enjoy ambitious new features including new zombie classes, EXO Suits, and 4-player co-op multiplayer. With intense action and an unmatched level of weapon and character customization, Dead Rising 4 delivers a heart-pounding experience as players explore, scavenge and fight to survive in an epic open world sandbox. System Requirements PC System Requirements: OS: Windows 7 64-bit Processor: Intel i5-2400 or AMD FX 6300 Memory: 6 GB RAM Graphics: NVIDIA GeForce GTX 760 (2 GB) or AMD Radeon HD 7850 (2 GB) DirectX: Version 11 Network: Broadband Internet connection Storage: 50 GB available space Sound Card: DX11-compatible sound card ",
                    foto = "header_10254.jpg",
                    cena = 76.82,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 50,
                    nazwa_produkt = "Call of Duty: Infinite Warfare  Calling Card Pack",
                    opis = "Requires an active account with the base game Call of Duty: Infinite Warfare in order to redeem. Activated on all platforms, limited to one use per account! Call of Duty: Infinite Warfare Card Pack is a collection of in-game calling cards. Items included in the pack: 1 animated calling card ­ World Eater 5 static calling cards ­ Solar System I, II, III, IV, V (Calling Cards are like emblems that appear beside the player’s name) System Requirements OS: Windows 7 64-Bit or later  Processor: Intel Core i3-3225 @ 3.30GHz or equivalent  Memory: 8 GB RAM  Graphics: NVIDIA GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB  DirectX: Version 11  Network: Broadband Internet connection  Storage: 70 GB available space  Sound Card: DirectX 11 Compatible  Additional Notes: Disk space requirement may change over time. ",
                    foto = "header_6265_2.jpg",
                    cena = 23.94,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 51,
                    nazwa_produkt = "Call of Duty Infinite Warfare  Terminal Bus Map + Spaceland Pack DLC US PS4  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in the United States and Canada. Requires the base game Call of Duty: Infinite Warfare on Playstation 4 in order to play. Includes 2 Items: Terminal Bonus Map and Zombies in Spaceland Pack. Zombies in Spaceland Pack contains: Weapon camo Calling card Fate and Fortune Card Pack Infinite Warfare delivers three unique game modes: Campaign, Multiplayer, and Zombies.  In Campaign, players play as Captain Reyes, a pilot turned Commander, who must lead the remaining coalition forces against a relentless, fanatical enemy, while trying to overcome the deadly, extreme environments of space. Multiplayer combines a fluid momentum based movement system, player focused map design, deep customization, and a brand new combat rig system to create an intense gameplay experience where every second counts. Combat Rigs (Rigs) are the ultimate combat systems. Each Rig is a cutting-edge, tactical combat suit worn by the player and is built for totally different styles of play. Players will also join one of four brand-new Mission Teams to unlock calling cards, camos, emblems, and weapons unique to that team.  In Zombies, go back in time to fight the undead in a 1980s amusement park, complete with a plethora of rides, an awesome arcade, and a funky, functioning rollercoaster. Embrace previously beloved aspects of the mode like easter eggs, power ups, and novel weapons while experiencing innovations like brand-new team mechanics, the After Life Arcade, and Fate and Fortune Cards.",
                    foto = "header_6265_4.jpg",
                    cena = 46.77,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 52,
                    nazwa_produkt = "Dead Rising 4 ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe, the Middle East and Africa. Dead Rising 4 marks the return of photojournalist Frank West in an all-new chapter of one of the most popular zombie game franchises of all time. All of the classic hallmarks of the ground breaking series return, including a huge array of weapons and vehicles players can combine to combat the horde ranging from the practical - to the practically insane. Players will also enjoy ambitious new features including new zombie classes, EXO Suits, and 4-player co-op multiplayer. With intense action and an unmatched level of weapon and character customization, Dead Rising 4 delivers a heart-pounding experience as players explore, scavenge and fight to survive in an epic open world sandbox. System Requirements PC System Requirements: OS: Windows 7 64-bit Processor: Intel i5-2400 or AMD FX 6300 Memory: 6 GB RAM Graphics: NVIDIA GeForce GTX 760 (2 GB) or AMD Radeon HD 7850 (2 GB) DirectX: Version 11 Network: Broadband Internet connection Storage: 50 GB available space Sound Card: DX11-compatible sound card ",
                    foto = "header_10254.jpg",
                    cena = 76.82,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 53,
                    nazwa_produkt = "Call of Duty: Infinite Warfare  Calling Card Pack",
                    opis = "Requires an active account with the base game Call of Duty: Infinite Warfare in order to redeem. Activated on all platforms, limited to one use per account! Call of Duty: Infinite Warfare Card Pack is a collection of in-game calling cards. Items included in the pack: 1 animated calling card ­ World Eater 5 static calling cards ­ Solar System I, II, III, IV, V (Calling Cards are like emblems that appear beside the player’s name) System Requirements OS: Windows 7 64-Bit or later  Processor: Intel Core i3-3225 @ 3.30GHz or equivalent  Memory: 8 GB RAM  Graphics: NVIDIA GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB  DirectX: Version 11  Network: Broadband Internet connection  Storage: 70 GB available space  Sound Card: DirectX 11 Compatible  Additional Notes: Disk space requirement may change over time. ",
                    foto = "header_6265_2.jpg",
                    cena = 23.94,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 54,
                    nazwa_produkt = "Call of Duty Infinite Warfare  Terminal Bus Map + Spaceland Pack DLC US PS4  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in the United States and Canada. Requires the base game Call of Duty: Infinite Warfare on Playstation 4 in order to play. Includes 2 Items: Terminal Bonus Map and Zombies in Spaceland Pack. Zombies in Spaceland Pack contains: Weapon camo Calling card Fate and Fortune Card Pack Infinite Warfare delivers three unique game modes: Campaign, Multiplayer, and Zombies.  In Campaign, players play as Captain Reyes, a pilot turned Commander, who must lead the remaining coalition forces against a relentless, fanatical enemy, while trying to overcome the deadly, extreme environments of space. Multiplayer combines a fluid momentum based movement system, player focused map design, deep customization, and a brand new combat rig system to create an intense gameplay experience where every second counts. Combat Rigs (Rigs) are the ultimate combat systems. Each Rig is a cutting-edge, tactical combat suit worn by the player and is built for totally different styles of play. Players will also join one of four brand-new Mission Teams to unlock calling cards, camos, emblems, and weapons unique to that team.  In Zombies, go back in time to fight the undead in a 1980s amusement park, complete with a plethora of rides, an awesome arcade, and a funky, functioning rollercoaster. Embrace previously beloved aspects of the mode like easter eggs, power ups, and novel weapons while experiencing innovations like brand-new team mechanics, the After Life Arcade, and Fate and Fortune Cards.",
                    foto = "header_6265_4.jpg",
                    cena = 46.77,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 55,
                    nazwa_produkt = "Dead Rising 4 ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe, the Middle East and Africa. Dead Rising 4 marks the return of photojournalist Frank West in an all-new chapter of one of the most popular zombie game franchises of all time. All of the classic hallmarks of the ground breaking series return, including a huge array of weapons and vehicles players can combine to combat the horde ranging from the practical - to the practically insane. Players will also enjoy ambitious new features including new zombie classes, EXO Suits, and 4-player co-op multiplayer. With intense action and an unmatched level of weapon and character customization, Dead Rising 4 delivers a heart-pounding experience as players explore, scavenge and fight to survive in an epic open world sandbox. System Requirements PC System Requirements: OS: Windows 7 64-bit Processor: Intel i5-2400 or AMD FX 6300 Memory: 6 GB RAM Graphics: NVIDIA GeForce GTX 760 (2 GB) or AMD Radeon HD 7850 (2 GB) DirectX: Version 11 Network: Broadband Internet connection Storage: 50 GB available space Sound Card: DX11-compatible sound card ",
                    foto = "header_10254.jpg",
                    cena = 76.82,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 56,
                    nazwa_produkt = "Sid Meier's Civilizati: Beyd Earth + Exoplanets Map Pack DLC  ",
                    opis = "Includes 2 items: Sid Meier's Civilization: Beyond Earth and Exoplanets Map Pack DLC. Sid Meier's Civilization: Beyond Earth is a new science-fiction-themed entry into the award-winning Civilization series. Set in the future, global events have destabilized the world leading to a collapse of modern society, a new world order and an uncertain future for humanity. As the human race struggles to recover, the re-developed nations focus their resources on deep space travel to chart a new beginning for mankind. As part of an expedition sent to find a home beyond Earth, you will write the next chapter for humanity as you lead your people into a new frontier and create a new civilization in space. Explore and colonize an alien planet, research new technologies, amass mighty armies, build incredible Wonders and shape the face of your new world. As you embark on your journey you must make critical decisions. From your choice of sponsor and the make-up of your colony, to the ultimate path you choose for your civilization, every decision opens up new possibilities. Exoplanets Map Pack DLC: The Exoplanets map pack includes six custom maps inspired by real-world exoplanets. Specialized scripts produce randomized geographic layouts each time a new game begins, allowing for even more replayability on new alien worlds. Features Seed the Adventure: Establish your cultural identity by choosing one of eight different expedition sponsors, each with its own leader and unique gameplay benefits. Assemble your spacecraft, cargo & colonists through a series of choices that directly seed the starting conditions when arriving at the new planet. Colonize an Alien World: Explore the dangers and benefits of a new planet filled with dangerous terrain, mystical resources, and hostile life forms unlike those of Earth. Build outposts, unearth ancient alien relics, tame new forms of life, develop flourishing cities and establish trade routes to create prosperity for your people. Technology Web: To reflect progress forward into an uncertain future, technology advancement occurs through a series of nonlinear choices that affect the development of mankind. The technology web is organized around three broad themes, each with a distinct victory condition. Orbital Layer: Build and deploy advanced military, economic and scientific satellites that provide strategic offensive, defensive and support capabilities from orbit. Unit Customization: Unlock different upgrades through the tech web and customize your units to reflect your play style. Multiplayer: Up to 8 players can compete for dominance of a new alien world. Mod support: Robust mod support allows you to customize and extend your game experience.  System Requirements Windows: OS: Windows® Vista SP2/ Windows® 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2 GB RAM Graphics: 256 MB ATI HD3650 or better, 256 MB nVidia 8800 GT or better, or Intel HD 3000 or better integrated graphics DirectX: Version 11 Storage: 8 GB available space Sound Card: DirectX 9.0c‐compatible sound card Additional Notes: Other Requirements: Initial installation requires one-time Internet connection for Steam authentication; software installations required (included with the game) include Steam Client, Microsoft Visual C++2012 Runtime Libraries and Microsoft DirectX. Mac OS X: OS: 10.9.5 (Mavericks), 10.10 (Yosemite) Processor: Intel Core i3 (2.2 ghz) Memory: 4 GB RAM Graphics: ATI Radeon 4850 / nVidia 640M /Intel HD 4000 Storage: 8 GB available space Additional Notes: NOTICE: It is possible for Mac and PC to become out of sync during updates or patches. Within this short time period, Mac users will only be able to play other Mac users. NOTICE: The following video chipsets are unsupported for Civilization: Beyond Earth (Mac) • ATI Radeon X1000 series, HD 2400, 2600, 3870, 4670, 6490, 6630 • NVIDIA GeForce 7000 series, 8600, 8800, 9400, 9600, 320, 330, GT 120 • Intel GMA series, HD 3000 SteamOS + Linux: OS: SteamOS, Ubuntu 14.04 Processor: Intel Core i3, AMD A10 Memory: 4 GB RAM Graphics: NVIDIA GeForce 260 Storage: 8 GB available space ",
                    foto = "header_8267_6.jpg",
                    cena = 32.94,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 57,
                    nazwa_produkt = "Sid Meier's Civilizati V Complete  ",
                    opis = "Includes 14 items:Civilization V, Civilization V: Gods and Kings, Civilization V: Brave New World, Civilization Pack: Babylon (Nebuchadnezzar III), Civilization and Scenario Pack: Polynesia, Civilization and Scenario Pack: Denmark - The Vikings, Civilization and Scenario Pack: Korea, Double Civilization and Scenario Pack: Spain and Inca, Wonders of the Ancient World Scenario Pack, 4 Cradle of Civilization Map Packs (Mediterranean, Asia, Americas, Mesopotamia), Explorer's Map Pack, Scrambled Continents Map Pack, Scrambled Nations Map Pack and Conquest of the New World Deluxe Scenario.The Flagship Turn-Based Strategy Game Returns Become Ruler of the World by establishing and leading a civilization from the dawn of man into the space age: Wage war, conduct diplomacy, discover new technologies, go head-to-head with some of history’s greatest leaders and build the most powerful empire the world has ever known. Features INVITING PRESENTATION: Jump right in and play at your own pace with an intuitive interface that eases new players into the game. Civ veterans will appreciate the depth, detail and control that are highlights of the series. BELIEVABLE WORLD: Ultra realistic graphics showcase lush landscapes for you to explore, battle over and claim as your own. Art deco influences abound in the menus and icons in the most well-designed Civ ever developed. COMMUNITY & MULTIPLAYER: Compete with Civ players all over the world or locally in LAN matches, mod* the game in unprecedented ways, and install mods directly from an in-game community hub without ever leaving the game. Civilization V brings community to the forefront. WIDE SYSTEM COMPATIBILITY: Civilization V operates on many different systems, from high end DX11 desktops to many laptops. Enjoy unlimited installations on multiple PCs with your Steam account and take your Civ V experience with you everywhere you go. ALL NEW FEATURES: A new hex-based gameplay grid opens up exciting new combat and build strategies. City States become a new resource in your diplomatic battleground. An improved diplomacy system allows you to negotiate with fully interactive leaders. Custom music scores and orchestral recordings give Civ V the level of polish and quality you expect from the series. SOCIALLY RESPONSIBLE: 2K Games is donating a total of $250,000 to four education based charities, and users' choices will determine how the money is dispersed: simply select your choice from the pre-selected charities during the install process.  System requirements Windows: OS: Windows XP SP3/ Windows Vista SP2/ Windows 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2GB RAM Hard Disk Space: 8 GB Free Video Card: 256 MB ATI HD2600 XT or better, 256 MB nVidia 7900 GS or better, or Core i3 or better integrated graphics DirectX®: 9.0c Sound: DirectX 9.0c-compatible sound card Mac OS X: OS: 10.8.5 (Mountain Lion), 10.9.5 (Mavericks), 10.10.5 (Yosemite), 10.11.1 (El Capitan)  Processor: Intel Core 2 Duo (Dual-Core) CPU Speed: 2.4 GHz  Memory: 2 GB RAM  Hard Disk Space: 8 GB  Video Card: (ATI) Radeon HD 2600, (NVidia) Geforce 8600, (Intel) HD 4000  Video Memory: 256MB Multiplayer: Internet (TCP/IP) and LAN (TCP/IP) play supported. Please note, it is possible for Mac and PC to become out of sync during updates. Within this short time period, Mac users will only be able to play other Mac users.  Notice:This game is not supported on volumes formatted as Mac OS Extended (Case Sensitive)  Notice: The following video chipsets are not supported for Civilization V: ATI Radeon X1000 series, HD 2400, Nvidia GeForce 7000 series, 8600, 9400, Intel GMA (950/X3100), HD 3000 Notice: The Mac and Linux + SteamOS versions of Sid Meier's Civilization V are available in English, French, Italian, German and Spanish only. SteamOS + Linux: OS: SteamOS, Ubuntu  Processor: Intel Core i3, AMD A10 2.4GHz  Memory: 4 GB RAM  Hard Disk Space: 10 GB  Video Card: (ATI) Radeon HD 6450, (NVIDIA) Geforce 640M, (INTEL) Iris Pro  Video Memory: 1GB Notice: Intel Integrated video chipsets (GMA 9XX, HD 3XXX) will not run Civilization V for SteamOS and Linux, and are unsupported. Notice: The Mac and Linux + SteamOS versions of Sid Meier's Civilization V are available in English, French, Italian, German and Spanish only. ",
                    foto = "CiV_1.png",
                    cena = 84.35,
                    poprzednia_cena = 182.95,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 58,
                    nazwa_produkt = "Sid Meier's Civilizati: Beyd Earth + Exoplanets Map Pack DLC ASIA  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Taiwan, Hong Kong, China, Singapore, Malaysia, Philippines, Vietnam, Thailand, Indonesia, Sri Lanka, Cambodia, Laos, Brunei and Macau. Includes 2 items: Sid Meier's Civilization: Beyond Earth and Exoplanets Map Pack DLC. Sid Meier's Civilization: Beyond Earth is a new science-fiction-themed entry into the award-winning Civilization series. Set in the future, global events have destabilized the world leading to a collapse of modern society, a new world order and an uncertain future for humanity. As the human race struggles to recover, the re-developed nations focus their resources on deep space travel to chart a new beginning for mankind. As part of an expedition sent to find a home beyond Earth, you will write the next chapter for humanity as you lead your people into a new frontier and create a new civilization in space. Explore and colonize an alien planet, research new technologies, amass mighty armies, build incredible Wonders and shape the face of your new world. As you embark on your journey you must make critical decisions. From your choice of sponsor and the make-up of your colony, to the ultimate path you choose for your civilization, every decision opens up new possibilities. Exoplanets Map Pack DLC: The Exoplanets map pack includes six custom maps inspired by real-world exoplanets. Specialized scripts produce randomized geographic layouts each time a new game begins, allowing for even more replayability on new alien worlds. Features Seed the Adventure: Establish your cultural identity by choosing one of eight different expedition sponsors, each with its own leader and unique gameplay benefits. Assemble your spacecraft, cargo & colonists through a series of choices that directly seed the starting conditions when arriving at the new planet. Colonize an Alien World: Explore the dangers and benefits of a new planet filled with dangerous terrain, mystical resources, and hostile life forms unlike those of Earth. Build outposts, unearth ancient alien relics, tame new forms of life, develop flourishing cities and establish trade routes to create prosperity for your people. Technology Web: To reflect progress forward into an uncertain future, technology advancement occurs through a series of nonlinear choices that affect the development of mankind. The technology web is organized around three broad themes, each with a distinct victory condition. Orbital Layer: Build and deploy advanced military, economic and scientific satellites that provide strategic offensive, defensive and support capabilities from orbit. Unit Customization: Unlock different upgrades through the tech web and customize your units to reflect your play style. Multiplayer: Up to 8 players can compete for dominance of a new alien world. Mod support: Robust mod support allows you to customize and extend your game experience.  System Requirements Windows: OS: Windows® Vista SP2/ Windows® 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2 GB RAM Graphics: 256 MB ATI HD3650 or better, 256 MB nVidia 8800 GT or better, or Intel HD 3000 or better integrated graphics DirectX: Version 11 Storage: 8 GB available space Sound Card: DirectX 9.0c‐compatible sound card Additional Notes: Other Requirements: Initial installation requires one-time Internet connection for Steam authentication; software installations required (included with the game) include Steam Client, Microsoft Visual C++2012 Runtime Libraries and Microsoft DirectX. Mac OS X: OS: 10.9.5 (Mavericks), 10.10 (Yosemite) Processor: Intel Core i3 (2.2 ghz) Memory: 4 GB RAM Graphics: ATI Radeon 4850 / nVidia 640M /Intel HD 4000 Storage: 8 GB available space Additional Notes: NOTICE: It is possible for Mac and PC to become out of sync during updates or patches. Within this short time period, Mac users will only be able to play other Mac users. NOTICE: The following video chipsets are unsupported for Civilization: Beyond Earth (Mac) • ATI Radeon X1000 series, HD 2400, 2600, 3870, 4670, 6490, 6630 • NVIDIA GeForce 7000 series, 8600, 8800, 9400, 9600, 320, 330, GT 120 • Intel GMA series, HD 3000 SteamOS + Linux: OS: SteamOS, Ubuntu 14.04 Processor: Intel Core i3, AMD A10 Memory: 4 GB RAM Graphics: NVIDIA GeForce 260 Storage: 8 GB available space ",
                    foto = "header_8267_10.jpg",
                    cena = 68.62,
                    poprzednia_cena = 170.19,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 59,
                    nazwa_produkt = "Sid Meier's Civilizati: Beyd Earth and Starships Bundle ",
                    opis = "Includes: Sid Meier's Civilization: Beyond Earth and Sid Meier's Starships. Sid Meier's Civilization: Beyond Earth  Sid Meier's Civilization: Beyond Earth is a new science-fiction-themed entry into the award-winning Civilization series. Set in the future, global events have destabilized the world leading to a collapse of modern society, a new world order and an uncertain future for humanity. As the human race struggles to recover, the re-developed nations focus their resources on deep space travel to chart a new beginning for mankind. As part of an expedition sent to find a home beyond Earth, you will write the next chapter for humanity as you lead your people into a new frontier and create a new civilization in space. Explore and colonize an alien planet, research new technologies, amass mighty armies, build incredible Wonders and shape the face of your new world. As you embark on your journey you must make critical decisions. From your choice of sponsor and the make-up of your colony, to the ultimate path you choose for your civilization, every decision opens up new possibilities. Sid Meier's Starships Take command of a fleet of powerful starships in this adventure-driven strategy game from legendary designer Sid Meier. Travel to new worlds, completing missions to help save and protect the planets and their people from dangerous Space Pirates, to powerful Marauders and other hostile factions. Build a planetary federation as you strengthen your fleet and secure your homeworld as you attempt to preserve intergalactic peace and your vision of humanity. Set in the universe of Civilization: Beyond Earth after the age of the Seeding, Sid Meier’s Starships offers sci-fi/strategy fans a full stand-alone game experience that also features cross-connectivity with Beyond Earth, expanding the depth of both games. See if you have what it takes to rule the universe! System Requirements OS: Windows® Vista SP2/ Windows® 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2 GB RAM Graphics: 256 MB ATI HD3650 or better, 256 MB nVidia 8800 GT or better, or Intel HD 3000 or better integrated graphics DirectX: Version 11 Hard Drive: 8 GB available space Sound Card: DirectX 9.0c‐compatible sound card Additional Notes: Other Requirements: Initial installation requires one-time Internet connection for Steam authentication; software installations required (included with the game) include Steam Client, Microsoft Visual C++2012 Runtime Libraries and Microsoft DirectX. ",
                    foto = "header_3571.jpg",
                    cena = 85.48,
                    poprzednia_cena = 182.95,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 60,
                    nazwa_produkt = "Sid Meier's Civilizati: Beyd Earth + Exoplanets Map Pack DLC  ",
                    opis = "Includes 2 items: Sid Meier's Civilization: Beyond Earth and Exoplanets Map Pack DLC. Sid Meier's Civilization: Beyond Earth is a new science-fiction-themed entry into the award-winning Civilization series. Set in the future, global events have destabilized the world leading to a collapse of modern society, a new world order and an uncertain future for humanity. As the human race struggles to recover, the re-developed nations focus their resources on deep space travel to chart a new beginning for mankind. As part of an expedition sent to find a home beyond Earth, you will write the next chapter for humanity as you lead your people into a new frontier and create a new civilization in space. Explore and colonize an alien planet, research new technologies, amass mighty armies, build incredible Wonders and shape the face of your new world. As you embark on your journey you must make critical decisions. From your choice of sponsor and the make-up of your colony, to the ultimate path you choose for your civilization, every decision opens up new possibilities. Exoplanets Map Pack DLC: The Exoplanets map pack includes six custom maps inspired by real-world exoplanets. Specialized scripts produce randomized geographic layouts each time a new game begins, allowing for even more replayability on new alien worlds. Features Seed the Adventure: Establish your cultural identity by choosing one of eight different expedition sponsors, each with its own leader and unique gameplay benefits. Assemble your spacecraft, cargo & colonists through a series of choices that directly seed the starting conditions when arriving at the new planet. Colonize an Alien World: Explore the dangers and benefits of a new planet filled with dangerous terrain, mystical resources, and hostile life forms unlike those of Earth. Build outposts, unearth ancient alien relics, tame new forms of life, develop flourishing cities and establish trade routes to create prosperity for your people. Technology Web: To reflect progress forward into an uncertain future, technology advancement occurs through a series of nonlinear choices that affect the development of mankind. The technology web is organized around three broad themes, each with a distinct victory condition. Orbital Layer: Build and deploy advanced military, economic and scientific satellites that provide strategic offensive, defensive and support capabilities from orbit. Unit Customization: Unlock different upgrades through the tech web and customize your units to reflect your play style. Multiplayer: Up to 8 players can compete for dominance of a new alien world. Mod support: Robust mod support allows you to customize and extend your game experience.  System Requirements Windows: OS: Windows® Vista SP2/ Windows® 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2 GB RAM Graphics: 256 MB ATI HD3650 or better, 256 MB nVidia 8800 GT or better, or Intel HD 3000 or better integrated graphics DirectX: Version 11 Storage: 8 GB available space Sound Card: DirectX 9.0c‐compatible sound card Additional Notes: Other Requirements: Initial installation requires one-time Internet connection for Steam authentication; software installations required (included with the game) include Steam Client, Microsoft Visual C++2012 Runtime Libraries and Microsoft DirectX. Mac OS X: OS: 10.9.5 (Mavericks), 10.10 (Yosemite) Processor: Intel Core i3 (2.2 ghz) Memory: 4 GB RAM Graphics: ATI Radeon 4850 / nVidia 640M /Intel HD 4000 Storage: 8 GB available space Additional Notes: NOTICE: It is possible for Mac and PC to become out of sync during updates or patches. Within this short time period, Mac users will only be able to play other Mac users. NOTICE: The following video chipsets are unsupported for Civilization: Beyond Earth (Mac) • ATI Radeon X1000 series, HD 2400, 2600, 3870, 4670, 6490, 6630 • NVIDIA GeForce 7000 series, 8600, 8800, 9400, 9600, 320, 330, GT 120 • Intel GMA series, HD 3000 SteamOS + Linux: OS: SteamOS, Ubuntu 14.04 Processor: Intel Core i3, AMD A10 Memory: 4 GB RAM Graphics: NVIDIA GeForce 260 Storage: 8 GB available space ",
                    foto = "header_8267_6.jpg",
                    cena = 32.94,
                    poprzednia_cena = 212.74,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 61,
                    nazwa_produkt = "Guild Wars 2: Heart of Thorns",
                    opis = "Includes 2 items: Guild Wars 2, Guild wars 2: Heart of Thorns Guild Wars 2: Heart of Thorns is the first expansion for Guild Wars 2. Founded on the idea that the journey is the goal, the Heart of Thorns expansion continues the Guild Wars 2 tradition of challenging the conventions of MMOs to fulfill the promise of what online worlds should be. Features The Mastery System - Explore new training opportunities for your character beyond level 80 and master abilities like hang gliding in the jungle, tearing the bark off of heavily armored Mordrem, or building new collections that earn precursors to a legendary weapon. The Hear of Maguuma - New adventures await you in the heart of the Maguuma Jungle. Confront the growing hordes of Mordremoth's minions, discover allies from ancient civilizations, and battle new enemies. Tackle challenging group content. Explore new open world jungle maps. Experience new events and storylines. Test your mettle in new boss battles. Specializations - Evolve your gameplay. With profession specializations, you'll unlock access to a weapon previously unavailable to your profession as well as new traits, skills, and unique mechanics - all of which will transform your profession into something new. New profession: Revenant - Channel legendary powers to slaughter foes and unleash chaos on the battlefield with our brand new profession: the revenant. Enter the field of battle heavily armored and equipped with the otherworldly powers of the Mists. Guild Halls - Your guild has roamed the world together. Now, it's time to claim a piece of it. Work with fellow guild members to claim and grow your own guild hall in the heart of Maguuma. PVP: New Stronghold Game Mode - Gather supply to hire soldiers. Battle for control of heroes. Man the trebuchet to defend your stronghold, and storm the enemy gates to defeat the guild lord! Use our new guild team feature to team up and battle to the top of the leaderboards. Stronghold offers an entirely new way to play competitive PvP in Guild Wars 2! WvW: New Borderland - Experience epic battlefield combat like never before in World vs. World's latest core addition, the new Borderlands map. Navigate treacherous heights with traps that blow your foes to the depths below and ferocious defenders to help keep the enemy at bay. Map objectives will be more important than ever before, as they'll unlock new strategies, tactics, and play mechanics that you'll want to use to your world's advantage! System Requirements Windows XP Service Pack 3 or better Intel Core 2 Duo 2.0 GHz, Core i3, AMD Athlon 64 X2 or better 2 GB RAM NVIDIA GeForce 7800, ATI Radeon X1800, Intel HD 3000 or better (256MB of video RAM and shader model 3.0 or better) 35 GB available HDD space Broadband Internet connection Keyboard and mouse ",
                    foto = "Bez_tytu_u_19.png",
                    cena = 128.18,
                    poprzednia_cena = 182.95,

                    id_Kategoria = 5,
                    id_Platforma=4,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 62,
                    nazwa_produkt = "MiddleEarth: Shadow of War ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. This is a PRE-ORDER, the key will be delivered upon the game's release date: 25th August 2017! Bonuses, if included, may differ from offers on other stores! Go behind enemy lines to forge your army, conquer Fortresses and dominate Mordor from within. Experience how the award-winning Nemesis System creates unique personal stories with every enemy and follower, and confront the full power of the Dark Lord Sauron and his Ringwraiths in this epic new story of Middle-earth. In Middle-earth: Shadow of War, nothing will be forgotten. System Requirements PC System Requirements: OS: Windows 7 SP1 with Platform Update for Windows 7 Processor: Intel i5- 2550K, 3.4 GHz Memory: 8 GB RAM Graphics: GeForce 670 | Radeon HD 7950 DirectX: Version 11 Network: Broadband Internet connection Storage: 60 GB available space ",
                    foto = "header2_72.jpg",
                    cena = 199.12,

                    id_Kategoria = 6,
                    id_Platforma=2,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 63,
                    nazwa_produkt = "MiddleEarth: Shadow of Mordor  ",
                    opis = "In Middle-earth: Shadow of Mordor, gamers take on the role of Talion, a valiant ranger whose family is slain in front of him the night Sauron and his army return to Mordor, moments before his own life is taken. Resurrected by a Spirit of vengeance and empowered with Wraith abilities, Talion ventures into Mordor and vows to destroy those who have wronged him. Through the course of his personal vendetta, Talion uncovers the truth of the Spirit that compels him, learns the origins of the Rings of Power and ultimately confronts his true nemesis. Every enemy that players face is a unique individual, differentiated by their personality, strengths and weaknesses. Through the Nemesis System, enemy relationships and characteristics are shaped by player actions and decisions to create personal archenemies that remember and adapt to the player and are distinct to every gameplay session. Gamers are able to craft their own battles, enemies and rewards within the dynamic world that remembers and adapts to their choices, delivering a unique experience to every player. System Requirements PC System Requirements: OS: 64-bit: Vista SP2, Win 7 SP1, Win 8.1 Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 3 GB RAM Graphics: NVIDIA GeForce GTX 460 | AMD Radeon HD 5850 DirectX: Version 11 Network: Broadband Internet connection Storage: 44 GB available space Mac System Requirements: OS: Mac OS X 10.10.3 Processor: 2.4 GHz Intel Memory: 8 GB RAM Graphics: 1GB Nvidia 650M or later, AMD 7xxx series or later and Intel Iris Pro. Network: Broadband Internet connection Storage: 67 GB available space Additional Notes: Requires Keyboard & Multi-button Mouse Linux / SteamOS System Requirements: OS: Ubuntu 14.04.2 64-bit / SteamOS Processor: Intel Core i5-750, 2.67 GHz | AMD Phenom II X4 965, 3.4 GHz Memory: 4 GB RAM Graphics: 1GB NVIDIA 640 or better with driver version 352.21 or later Network: Broadband Internet connection Storage: 47 GB available space Additional Notes: AMD and Intel cards are NOT supported. If you wish to play the game using an AMD graphics card, you should update your graphics driver to version Catalyst 15.7 or higher. You should be able to run the game without experiencing stability issues or graphical glitches, but you may still experience poor performance. ",
                    foto = "header1_189.jpg",
                    cena = 33.45,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 6,
                    id_Platforma=2,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 64,
                    nazwa_produkt = "Escape This  ",
                    opis = "Escape Thisis a casual puzzle game where the main objective is for the player to complete the given stage. Each stage is selected at random. All maps can be edited and you are also able to create your own unique maps and share them with the rest of the community. System Requirements PC System Requirements OS: Windows 7,8,10 Processor: AMD FX 6300 Memory: 500 MB RAM Graphics: GTX 750TI DirectX: Version 11 Storage: 60 MB available space Mac System Requirements OS: Universal Memory: 500 MB RAM Storage: 60 MB available space ",
                    foto = "thumbnail_2050.jpg",
                    cena = 5.27,
                    poprzednia_cena = 85.07,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 65,
                    nazwa_produkt = "MiddleEarth: Shadow of War ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Europe. This is a PRE-ORDER, the key will be delivered upon the game's release date: 25th August 2017! Bonuses, if included, may differ from offers on other stores! Go behind enemy lines to forge your army, conquer Fortresses and dominate Mordor from within. Experience how the award-winning Nemesis System creates unique personal stories with every enemy and follower, and confront the full power of the Dark Lord Sauron and his Ringwraiths in this epic new story of Middle-earth. In Middle-earth: Shadow of War, nothing will be forgotten. System Requirements PC System Requirements: OS: Windows 7 SP1 with Platform Update for Windows 7 Processor: Intel i5- 2550K, 3.4 GHz Memory: 8 GB RAM Graphics: GeForce 670 | Radeon HD 7950 DirectX: Version 11 Network: Broadband Internet connection Storage: 60 GB available space ",
                    foto = "header2_72.jpg",
                    cena = 199.12,

                    id_Kategoria = 6,
                    id_Platforma=2,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 66,
                    nazwa_produkt = "Call of Duty: Modern Warfare 3 ",
                    opis = "The best-selling first person action series of all-time returns with the epic sequel to multiple “Game of the Year” award winner, Call of Duty®: Modern Warfare® 2. In the world’s darkest hour, are you willing to do what is necessary? Prepare yourself for a cinematic thrill-ride only Call of Duty can deliver. The definitive Multiplayer experience returns bigger and better than ever, loaded with new maps, modes and features. Co-Op play has evolved with all-new Spec-Ops missions and leaderboards, as well as Survival Mode, an action-packed combat progression unlike any other. System Requriements OS: Windows® XP/ Windows® Vista / Windows® 7 Processor: Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better Memory: 2 GB RAM Graphics: Shader 3.0 or better 256 MB NVIDIA® GeForce™ 8600GT / ATI® Radeon™ X1950 or better DirectX®: DirectX® 9.0c or later Hard Drive: 16 GB free hard drive space Sound: DirectX® 9.0c or later Internet: Broadband connection and service required for Multiplayer Connectivity. Internet connection required for activation. ",
                    foto = "modernwarfare_1.jpg",
                    cena = 58.22,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 67,
                    nazwa_produkt = "5 x Random  ",
                    opis = "METACRITIC SCORE 60 AND UP - we give you only good games! MONEY BACK GUARANTEE - if you already own the game, you can return it (if you have Buyer Protection included). Random Steam Key - it's something for anyone who likes surprises and good games. Why? Because we guarantee that the game you purchase with Random Steam Key will be at least of a score of 60 on Metacritic and if the title does not have metascore, it will have 50% or more positive overall reviews on Steam! But that's not all - we know you love cheap games and we are here to deliver. Prices of Random Steam games start at €2.99 (Steam sales are not considered) and if the game you get is cheaper on Steam, you will get the price difference in store balance. If you already have the game in your Library, you will be able to return the Random Steam Key to the shop and get your money back for the game in question (applies only to orders that include Buyer Protection). System Requirements Every game has different requirements!",
                    foto = "random_1__2.jpg",
                    cena = 14.30,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 68,
                    nazwa_produkt = "Escape This  ",
                    opis = "Escape Thisis a casual puzzle game where the main objective is for the player to complete the given stage. Each stage is selected at random. All maps can be edited and you are also able to create your own unique maps and share them with the rest of the community. System Requirements PC System Requirements OS: Windows 7,8,10 Processor: AMD FX 6300 Memory: 500 MB RAM Graphics: GTX 750TI DirectX: Version 11 Storage: 60 MB available space Mac System Requirements OS: Universal Memory: 500 MB RAM Storage: 60 MB available space ",
                    foto = "thumbnail_2050.jpg",
                    cena = 5.27,
                    poprzednia_cena = 63.79,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 69,
                    nazwa_produkt = "Call of Duty: Infinite Warfare Day e  MIDDLE EAST  ",
                    opis = "This is a restricted product and it can be activated and played ONLY in Bahrain, Egypt, Iraq, Israel, Jordan, Kuwait, Lebanon, Oman, Palestinian, Qatar, Saudi Arabia, Turkey, United Arab Emirates and Yemen. Includes: The Reimagined, fan-favorite Terminal Bonus Map Zombies in Spaceland Pack of in-game digital items: weapon camo, animated player card, Fate & Fortune card pack Call of Duty is back with Call of Duty: Infinite Warfare! This title will be the most futuristic one yet, with battles happening in space across our entire solar system. With no more resources available on Earth, our citizens have started to depend on colonies on other planets that provide us with resources. Play as Captain Nick Reyes, a member of the United Nations Space Alliance as he does his part to ensure a safe galaxy against the Settlement Defense Front. Whether you fight in the spaceship, in outer space itself or in a more classical foot-on-ground setting, your skills as an FPS player will be put to the test! Features MULTIPLE GAME MODES - Whether you prefer single player or multiplayer, you’re completely covered by Call of Duty: Infinite Warfare. Decide whether you prefer playing the single player campaign or if you want to jump into the highly competitive multiplayer mode immediately! NEW GAMEPLAY MECHANICS - With the introduction of outer space as a battleground, new gameplay mechanics have inevitably been made available. You can now fight in zero gravity, adding a multitude of new options available to creative fighters! In addition to this, the transition from zero gravity gameplay to the more classical on the ground gameplay is completely seamless. TOP-NOTCH GRAPHICS AND CINEMATIC CONTENT - Something we’ve come to expect from the Call of Duty franchise is not only outstanding gameplay but also additional in-game content. Take part in enormous battles and wars with a lot of action going on in the background. Beautiful cinematics throughout the game will enhance your gaming experience as well.  System Requirements OS: Windows 7 64-Bit or later   Processor: Intel Core i3-3225 @ 3.30GHz or equivalent Memory: 8 GB RAM Graphics: NVIDIA GeForce GTX 660 2GB / AMD Radeon HD 7850 2GB DirectX: Version 11 Network: Broadband Internet connection Storage: 70 GB available space Sound Card: DirectX 11 Compatible Additional Notes: Disk space requirement may change over time. ",
                    foto = "header_6265.jpg",
                    cena = 115.96,
                    poprzednia_cena = 4.21,

                    id_Kategoria = 3,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 70,
                    nazwa_produkt = "Random  ",
                    opis = "METACRITIC SCORE 60 AND UP - we give you only good games! MONEY BACK GUARANTEE - if you already own the game, you can return it (if you have Buyer Protection included). Random Steam Key - it's something for anyone who likes surprises and good games. Why? Because we guarantee that the game you purchase with Random Steam Key will be at least of a score of 60 on Metacritic and if the title does not have metascore, it will have 50% or more positive overall reviews on Steam! But that's not all - we know you love cheap games and we are here to deliver. Prices of Random Steam games start at €2.99 (Steam sales are not considered) and if the game you get is cheaper on Steam, you will get the price difference in store balance. If you already have the game in your Library, you will be able to return the Random Steam Key to the shop and get your money back for the game in question (applies only to orders that include Buyer Protection). System Requirements Every game has different requirements!",
                    foto = "random_1__2.jpg",
                    cena = 4.72,
                    poprzednia_cena = 255.30,

                    id_Kategoria = 4,
                    id_Platforma=2,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 71,
                    nazwa_produkt = "Premium Random  ",
                    opis = "METACRITIC SCORE 70 AND UP - we give you only good games! MONEY BACK GUARANTEE - if you already own the game, you can return it (if you have Buyer Protection included). Premium Random Steam Key - it's something for anyone who likes surprises and good games. Why? Because we guarantee that the game you purchase with Premium Random Steam Key will be at least of a score of 70 on Metacritic and if the title does not have metascore, it will have 70% or more positive overall reviews on Steam! But that's not all - we know you love cheap games and we are here to deliver. Prices of Premium Random Steam games start at €8.99 (Steam sales are not considered) and if the game you get is cheaper on Steam, you will get the price difference in store balance. If you already have the game in your Library, you will be able to return the Premium Random Steam Key to the shop and get your money back for the game in question (applies only to orders that include Buyer Protection). System Requirements Every game has different requirements!",
                    foto = "prod-banner_1.jpg",
                    cena = 12.17,
                    poprzednia_cena = 12.72,

                    id_Kategoria = 4,
                    id_Platforma=2,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 72,
                    nazwa_produkt = "Sid Meier's Civilizati V Gold",
                    opis = "Includes 11 items: Civilization V, Gods & Kings Expansion, Civilization and Scenario Pack: Korea, Wonders of the Ancient World Scenario Pack, 4 Cradle of Civilization Map Packs (Mediterranean, Asia, Americas, Mesopotamia), Civilization Pack: Babylon (Nebuchadnezzar II), Double Civilization and Scenario Pack: Spain and Inca, Civilization and Scenario Pack: Polynesia, Civilization and Scenario Pack: Denmark - The Vikings, Explorer's Map Pack and Official Digital Soundtrack.The Flagship Turn-Based Strategy Game Returns Become Ruler of the World by establishing and leading a civilization from the dawn of man into the space age: Wage war, conduct diplomacy, discover new technologies, go head-to-head with some of history’s greatest leaders and build the most powerful empire the world has ever known. Features INVITING PRESENTATION: Jump right in and play at your own pace with an intuitive interface that eases new players into the game. Civ veterans will appreciate the depth, detail and control that are highlights of the series. BELIEVABLE WORLD: Ultra realistic graphics showcase lush landscapes for you to explore, battle over and claim as your own. Art deco influences abound in the menus and icons in the most well-designed Civ ever developed. COMMUNITY & MULTIPLAYER: Compete with Civ players all over the world or locally in LAN matches, mod* the game in unprecedented ways, and install mods directly from an in-game community hub without ever leaving the game. Civilization V brings community to the forefront. WIDE SYSTEM COMPATIBILITY: Civilization V operates on many different systems, from high end DX11 desktops to many laptops. Enjoy unlimited installations on multiple PCs with your Steam account and take your Civ V experience with you everywhere you go. ALL NEW FEATURES: A new hex-based gameplay grid opens up exciting new combat and build strategies. City States become a new resource in your diplomatic battleground. An improved diplomacy system allows you to negotiate with fully interactive leaders. Custom music scores and orchestral recordings give Civ V the level of polish and quality you expect from the series. SOCIALLY RESPONSIBLE: 2K Games is donating a total of $250,000 to four education based charities, and users' choices will determine how the money is dispersed: simply select your choice from the pre-selected charities during the install process.  System requirements Windows: OS: Windows XP SP3/ Windows Vista SP2/ Windows 7 Processor: Intel Core 2 Duo 1.8 GHz or AMD Athlon X2 64 2.0 GHz Memory: 2GB RAM Hard Disk Space: 8 GB Free Video Card: 256 MB ATI HD2600 XT or better, 256 MB nVidia 7900 GS or better, or Core i3 or better integrated graphics DirectX®: 9.0c Sound: DirectX 9.0c-compatible sound card Mac OS X: OS: 10.8.5 (Mountain Lion), 10.9.5 (Mavericks), 10.10.5 (Yosemite), 10.11.1 (El Capitan)  Processor: Intel Core 2 Duo (Dual-Core) CPU Speed: 2.4 GHz  Memory: 2 GB RAM  Hard Disk Space: 8 GB  Video Card: (ATI) Radeon HD 2600, (NVidia) Geforce 8600, (Intel) HD 4000  Video Memory: 256MB Multiplayer: Internet (TCP/IP) and LAN (TCP/IP) play supported. Please note, it is possible for Mac and PC to become out of sync during updates. Within this short time period, Mac users will only be able to play other Mac users.  Notice:This game is not supported on volumes formatted as Mac OS Extended (Case Sensitive)  Notice: The following video chipsets are not supported for Civilization V: ATI Radeon X1000 series, HD 2400, Nvidia GeForce 7000 series, 8600, 9400, Intel GMA (950/X3100), HD 3000 Notice: The Mac and Linux + SteamOS versions of Sid Meier's Civilization V are available in English, French, Italian, German and Spanish only. SteamOS + Linux: OS: SteamOS, Ubuntu  Processor: Intel Core i3, AMD A10 2.4GHz  Memory: 4 GB RAM  Hard Disk Space: 10 GB  Video Card: (ATI) Radeon HD 6450, (NVIDIA) Geforce 640M, (INTEL) Iris Pro  Video Memory: 1GB Notice: Intel Integrated video chipsets (GMA 9XX, HD 3XXX) will not run Civilization V for SteamOS and Linux, and are unsupported. Notice: The Mac and Linux + SteamOS versions of Sid Meier's Civilization V are available in English, French, Italian, German and Spanish only. ",
                    foto = "civ5_2.jpg",
                    cena = 69.03,
                    poprzednia_cena = 38.26,

                    id_Kategoria = 4,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 73,
                    nazwa_produkt = "Outlast 2 RU VPN Required ",
                    opis = "This is the Russian version of the game and a VPN service is required to activate and play the game. Outlast 2 is the sequel to the acclaimed survival horror game Outlast. Set in the same universe as the first game, but with different characters and a different setting, Outlast 2 is a twisted new journey into the depths of the human mind and its dark secrets. No conflict is ever black and white. But once the dust has settled, the victors get to decide who was right and who was wrong. Who is good and who is evil. Human nature pushes us to extremes of violence and depravity, which we then justify by divine inspiration and a promise of paradise to come. Horror rises from desperation and blind faith. OUTLAST 2 will test your faith, pushing players to a place where going mad is the only sane thing to do. System Requirements PC System Requirements: OS: Windows Vista / 7 / 8 / 10, 64-bits Processor: Core i3-530 Memory: 4 GB RAM Graphics: 1GB VRAM NVIDIA Geforce GTX 260 / ATI Radeaon HD 4xxx DirectX: Version 10 Storage: 30 GB available space Sound Card: DirectX Compatible Additional Notes: Specs could be modified prior to release. ",
                    foto = "thumbnail_312.jpg",
                    cena = 64.00,

                    id_Kategoria = 6,
                    id_Platforma=1,
                    id_VAT=1,
                },
                new Produkt
                {
                    id_produkt = 74,
                    nazwa_produkt = "Windows 10 Home OEM",
                    opis = "We suggest using the automated phone system in order to activate your code. Microsoft Windows 10 Home is your guarantee of easy access. Get an Operating System that starts up and resumes fast, has more built-in security to help keep you safe, and is designed to work with the software and hardware you already own. Windows 10 Home is a modern OS that comes from a long line of popular, functional releases from Microsoft. Windows is perfect for gamers, office computers, and everything in between. Organize everything with great built-in apps like Maps, Photos, Music, Mail & Calendar, and Movies & TV. Windows 10 Home helps you store what you need, find it when you need it, and clean things up to save space. And your files will never be lost thanks to automatic backup from Microsoft OneDrive. With Windows 10 Home, you're never far from what you need. This version of Windows is designed for increased functionality. It offers support for encryption, remote log-in, and virtual machine creation. Windows 10 Home is a perfect option for any and all computing needs. Windows 10 Home helps you work and helps you play. Transfer your favorite XBOX games from console to computer. Your gaming friends and other contacts transfer between platforms as well. It's great for intense gamers and first time users alike. Try Windows 10 Home now! Features Master multitasking - snap four things together on your screen or create virtual desktops for additional space. Windows 10 manage your notifications so you can focus on what you want. Hello, you are the password - Windows Hello is the password-free sign-in that gives you the fastest, most secure way to unlock your Windows devices. Go beyond browsing - Microsoft Edge is the browser built for Windows 10. Go beyond browsing—enjoy a web experience that's personal, responsive and all about getting things done online. Your truly personal digital assistant - By learning over time, Cortana becomes more useful as you go. Count on Cortana to help you find things, complete tasks, set reminders and work across your devices more productively. The best Windows ever for gaming - Play great new XBOX games on Windows 10 in native 4K resolution. Stay connected to your gaming community with the XBOX app. And play where you want with in-home streaming and XBOX Play Anywhere. Best apps built for doing - Get your favorites fast in the Windows Store, your one-stop shop on your PC, tablet, phone and XBOX One. Easily find and acquire popular free and paid apps, desktop software, PC and XBOX games, movies, TV shows and the latest music. Most comprehensive security - As the most secure Windows ever built, Windows 10 delivers comprehensive protection – including anti-virus, firewall, Windows Defender and anti-phishing technologies – all delivered built-in at no extra cost to you.  System Requirements Processor: 1 gigahertz (GHz) or faster processor or SoC RAM: 1 gigabyte (GB) for 32-bit or 2 GB for 64-bit Hard disk space: 16 GB for 32-bit OS, 20 GB for 64-bit OS Graphics card: DirectX 9 or later with WDDM 1.0 driver Display: 800x600 screen resolution or higher ",
                    foto = "header_home_1.jpg",
                    cena = 125.93,
                    poprzednia_cena = 119.12,

                    id_Kategoria = 7,
                    id_Platforma=5,
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

        public static List<Produkt> UpdatedProdukty()
        {
            List<Produkt> p = GetProdukty();
            List<Egzemplarz> e = GetEgzemplarze();

            foreach (Produkt p_item in p)
            {
                foreach (Egzemplarz e_item in e)
                {
                    if(e_item.id_produkt==p_item.id_produkt && e_item.czy_sprzedano==false)
                    {
                        p_item.Ilosc++;
                    }
                }
            }

            return p;
            
        }

    }
}
