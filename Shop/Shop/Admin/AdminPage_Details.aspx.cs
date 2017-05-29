using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;
using System.Web.ModelBinding;

namespace Shop.Admin
{
    public partial class AdminPage_Details : System.Web.UI.Page
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

        public IQueryable<Egzemplarz> GetEgzemplarze([QueryString("productID")] int? id_produkt)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<Egzemplarz> query = _db.Egzemplarze;
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
    }
}