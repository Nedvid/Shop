using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;

namespace Shop
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable GetSzczegoly(int id_zam)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            
            IQueryable <SzczegolyZamowienie> query = _db.SzczegolyZamowienia.Where(p => p.Login == User.Identity.Name);
            query = query.Where(p => p.id_zamowienie == id_zam);

            return query;
        }
        public IQueryable GetZamowienia()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.Zamowienia.Where(p => p.Login == User.Identity.Name);
            return query;
        }

    }
}