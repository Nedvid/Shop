using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;
using System.Web.ModelBinding;

namespace Shop
{
    public partial class ProduktDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Produkt> GetProdukty([QueryString("productID")] int? id_produkt)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Produkt> query = _db.Produkty;
            if (id_produkt.HasValue && id_produkt > 0)
            {
                query = query.Where(p => p.id_produkt == id_produkt);
            }
            else
            {
                query = null;
            }
            return query;
        }

        public string GetNameKategoria(int? id)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            var item = (from c in _db.Kategorie where c.id_kategoria == id select c).FirstOrDefault();


            return item.nazwa_kategoria.ToString();
        }

        public string GetNamePlatforma(int? id)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            var item = (from c in _db.Platformy where c.id_platforma == id select c).FirstOrDefault();
            if (item != null)
            {
                return item.nazwa_platforma.ToString();
            }
            else
            {
                return "Brak Platformy";
            }




        }
    }
}