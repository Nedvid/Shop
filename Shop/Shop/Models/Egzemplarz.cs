using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Egzemplarz
    {
        [Key]
        public int id_egzemplarz { get; set; }

        [Required, StringLength(100), Display(Name = "Klucz")]
        public string klucz_egzemplarz { get; set; }

        [Required, Display(Name = "DataZakup")]
        public DateTime? data_zakup { get; set; }

        [Display(Name = "DataSprzedaz")]
        public DateTime? data_sprzedaz { get; set; }

        [Required, Display(Name = "CzySprzedano")]
        public Boolean? czy_sprzedano { get; set; }

        //klucze obce

        public int? id_produkt { get; set; }

        public virtual Produkt produkt { get; set; }

    }
}