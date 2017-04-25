using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Platforma
    {
        [ScaffoldColumn(false)]
        public int id_platforma { get; set; }

        [Required, StringLength(100), Display(Name = "Platforma")]
        public string nazwa_platforma { get; set; }

        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}