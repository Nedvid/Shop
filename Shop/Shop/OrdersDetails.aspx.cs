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
    public partial class OrdersDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<SzczegolyZamowienie> GetSzczegoly([QueryString("OrderID")] int? id_zam)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable<SzczegolyZamowienie> query = _db.SzczegolyZamowienia;

            query = query.Where(p => p.id_zamowienie == id_zam);

            return query;
        }
    }
}