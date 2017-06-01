using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;
using Shop.Logic;
using System.Web.ModelBinding;

namespace Shop.Admin
{
    public partial class AdminPage_Details : System.Web.UI.Page
    {
        public static int? id_prd { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "add")
            {
                LabelAddStatus.Text = "Egzemplarz dodany!";
            }
        }

        protected void AddEgzemplarzButton_Click(object sender, EventArgs e)
        {
            // Add product data to DB.
            AddProducts products = new AddProducts();
            bool addSuccess = products.AddEgz(AddKlucz.Text, id_prd);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProductAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new product to database.";
            }
        }

        public IQueryable<Produkt> GetProdukty([QueryString("productID")] int? id_produkt)
        {
            id_prd = id_produkt;
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
            id_prd = id_produkt;
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