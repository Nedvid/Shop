using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Shop.Models
{
    public class VAT
    {
        public class ProduktContext : DbContext
        {
            public ProduktContext() : base("Shop")
            {
            }
            public DbSet<Kategoria> Kategorie { get; set; }
            public DbSet<Produkt> Produkty { get; set; }
        }
    }
}