using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Zamowienie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_zamowienie { get; set; }

        public System.DateTime data_zamowienie { get; set; }

        public string Login { get; set; }
        
        [Required(ErrorMessage = "Email Address is required")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Suma { get; set; }

        [ScaffoldColumn(false)]
        public string id_transakcja_platnosci { get; set; }

        public List<SzczegolyZamowienie> SzczegolyZamowienia { get; set; }
    }
}