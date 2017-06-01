using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class ElementKoszyka
    {
        [Key]
        public string id_item { get; set; }

        public string id_koszyk { get; set; }

        public System.DateTime data_utworzenia { get; set; }

        public int ilosc { get; set; }

        //klucze obce

        public int id_produkt { get; set; }

        public virtual Produkt Produkt { get; set; }
    }
}