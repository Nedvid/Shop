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
    public partial class Produkty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Produkt> GetProdukty([QueryString("id")] int? categoryId, [QueryString("price")] int? price)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Produkt> query = _db.Produkty;
            query = query.Where(p => p.Ilosc > 0);
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.id_Kategoria == categoryId);
            }
            if(price.HasValue)
            {
                query = query.Where(p => p.cena < price);
            }
            return query;
        }

        public IQueryable<Kategoria> GetKategorie()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Kategoria> query = _db.Kategorie;
            return query;
        }

        public IQueryable<Platforma> GetPlatformy()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Platforma> query = _db.Platformy;
            return query;
        }
    }
}