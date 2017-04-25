using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Produkt
    {
        [ScaffoldColumn(false)]
        public int id_produkt { get; set; }

        [Required, StringLength(100), Display(Name = "NazwaProdukt")]
        public string nazwa_produkt { get; set; }

        [Required, StringLength(10000), Display(Name = "Opis"), DataType(DataType.MultilineText)]
        public string opis { get; set; }

        public string foto { get; set; }
        [Required, Display(Name = "Cena")]
        public double? cena { get; set; }

        [Display(Name = "Poprzednia Cena")]
        public double? poprzednia_cena { get; set; }

        //klucze obce

        public int? id_Kategoria { get; set; }

        public virtual Kategoria kategoria { get; set; }

        public int? id_Platforma { get; set; }

        public virtual Platforma platforma { get; set; }

        public int? id_VAT { get; set; }

        public virtual VAT VAT { get; set; }
    }
}