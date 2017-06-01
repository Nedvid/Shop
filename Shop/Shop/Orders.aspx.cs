using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable GetSzczegoly()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.SzczegolyZamowienia.Where(p => p.Login == User.Identity.Name);
            return query;
        }

        public string GetNameProdukt(int? id)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            var item = (from c in _db.Produkty where c.id_produkt == id select c).FirstOrDefault();


            return item.nazwa_produkt.ToString();
        }
    }
}