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

        public IQueryable<Produkt> GetProdukty([QueryString("id")] int? id_kategoria)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Produkt> query = _db.Produkty;
            if (id_kategoria.HasValue && id_kategoria > 0)
            {
                query = query.Where(p => p.id_Kategoria == id_kategoria && p.Ilosc>0);
            }
            return query;
        }

        public IQueryable<Produkt> GetAll()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Produkt> query = _db.Produkty;
            query = query.Where(p => p.Ilosc>0);
            return query;
        }
    }
}