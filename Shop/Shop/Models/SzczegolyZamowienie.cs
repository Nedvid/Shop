using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class SzczegolyZamowienie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_szczegoly_zamowienie { get; set; }

        public int id_zamowienie { get; set; }

        public string Login { get; set; }

        public int id_produkt { get; set; }

        public int id_egzemplarz { get; set; }

        public string produkt { get; set; }

        public string klucz_egzemplarz { get; set; }

        public double? cena { get; set; }

    }
}