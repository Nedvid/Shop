using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Kategoria
    {
        [ScaffoldColumn(false)]
        public int id_kategoria { get; set; }

        [Required, StringLength(100), Display(Name = "Kategoria")]
        public string nazwa_kategoria { get; set; }

        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}