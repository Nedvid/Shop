using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class VAT
    {
        [ScaffoldColumn(false)]
        public int id_vat { get; set; }

        [Required, Display(Name = "VAT")]
        public double? vat { get; set; }

        [Required, Display(Name = "Data")]
        public DateTime? date { get; set; }

        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}