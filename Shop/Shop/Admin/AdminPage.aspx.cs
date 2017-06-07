using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;
using Shop.Logic;

namespace Shop.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "add")
            {
                LabelAddStatusSuccess.Text = "Produkt Dodany";
            }

            if (productAction == "remove")
            {
                LabelAddStatusSuccess.Text = "Produkt Usunięty";
            }
        }

        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/");
            if (ProductImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                    // Save to Images/Thumbs folder.
                    ProductImage.PostedFile.SaveAs(path + "Thumbs/" + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatusDanger.Text = ex.Message;
                }

                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(AddProductName.Text, AddProductDescription.Text,
                    AddProductPrice.Text, DropDownAddCategory.SelectedValue, DropDownAddPlatform.SelectedValue, DropDownAddVAT.SelectedValue, ProductImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=add");
                }
                else
                {
                    LabelAddStatusDanger.Text = "Nie można dodać produktu do bazy.";
                }
            }
            else
            {
                LabelAddStatusDanger.Text = "Niedopuszczalne rozszerzenie.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.Kategorie;
            return query;
        }

        public IQueryable GetPlatformy()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.Platformy;
            return query;
        }

        public IQueryable GetVAT()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.VATy;
            return query;
        }

        public IQueryable GetProducts()
        {
            var _db = new Shop.Models.EgzemplarzContext();
            IQueryable query = _db.Produkty;
            return query;
        }

        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new Shop.Models.EgzemplarzContext())
            {
                var button = (Button)sender;

                int productId = Convert.ToInt16(button.CommandArgument);
                var myItem = (from c in _db.Produkty where c.id_produkt == productId select c).FirstOrDefault();

                IQueryable<Egzemplarz> query = _db.Egzemplarze;
                query = query.Where(p => p.id_produkt == productId);

                if (myItem != null && query != null)
                {
                    foreach ( var item in query)
                    {
                        _db.Egzemplarze.Remove(item);
                    }

                    _db.Produkty.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelAddStatusDanger.Text = "Nie można usunąć produktu.";
                }
            }
        }
    }
}