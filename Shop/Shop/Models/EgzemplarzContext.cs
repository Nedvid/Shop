using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop.Models
{
    public class EgzemplarzContext : DbContext
    {
        public EgzemplarzContext() : base("Shop")
        {
        }

        public DbSet<VAT> VATy { get; set; }
        public DbSet<Platforma> Platformy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Egzemplarz> Egzemplarze { get; set; }
    }
}