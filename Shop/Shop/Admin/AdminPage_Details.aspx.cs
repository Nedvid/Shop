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
                LabelAddStatus.Text = "Egzemplarz Dodany";
            }

            if (productAction == "remove")
            {
                LabelAddStatus.Text = "Egzemplarz Usunięty";
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
                LabelAddStatus.Text = "Nie można dodać egzemplarza do bazy.";
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

        public string GetNameVAT(int? id)
        {
            var _db = new Shop.Models.EgzemplarzContext();
            var item = (from c in _db.VATy where c.id_vat == id select c).FirstOrDefault();
            if (item != null)
            {
                return item.vat.ToString();
            }
            else
            {
                return "Brak VATu";
            }
        }

        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new Shop.Models.EgzemplarzContext())
            {
                var button = (Button)sender;

                int egzemplarzId = Convert.ToInt16(button.CommandArgument);
                var myItem = (from c in _db.Egzemplarze where c.id_egzemplarz == egzemplarzId select c).FirstOrDefault();

                if (myItem != null)
                {
                    _db.Egzemplarze.Remove(myItem);
                    _db.SaveChanges();

                    //update ilosc
                    var myPrd = _db.Produkty.First(p => p.id_produkt == id_prd);
                    myPrd.Ilosc--;

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelAddStatus.Text = "Nie można usunąć egzemplarza.";
                }
            }
        }

        protected void EditButton_Click(object sender, EventArgs e)
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

                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Update Item
                var _db = new Shop.Models.EgzemplarzContext();
                var item = (from c in _db.Produkty where c.id_produkt == id_prd select c).FirstOrDefault();

                if (AddProductName.Text != "")
                    item.nazwa_produkt = AddProductName.Text;

                if (AddProductDescription.Text != "")
                    item.opis = AddProductDescription.Text;

                if (AddProductPrice.Text != "")
                {
                    var tmp = item.cena;
                    item.poprzednia_cena = tmp;
                    item.cena = Convert.ToDouble(AddProductPrice.Text);
                }
               
                item.id_Kategoria = Convert.ToInt32(DropDownAddCategory.SelectedValue); 
                item.id_Platforma = Convert.ToInt32(DropDownAddPlatform.SelectedValue); 
                item.id_VAT = Convert.ToInt32(DropDownAddVAT.SelectedValue); 
                item.foto = ProductImage.FileName;

                _db.SaveChanges();
            }
            else
            {
                LabelAddStatus.Text = "Niedopuszczalne rozszerzenie.";
            }
        }
    }
}