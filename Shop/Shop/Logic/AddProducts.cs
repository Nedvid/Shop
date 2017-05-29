using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Models;

namespace Shop.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            var myProduct = new Produkt();
            myProduct.nazwa_produkt = ProductName;
            myProduct.opis = ProductDesc;
            myProduct.cena = Convert.ToDouble(ProductPrice);
            myProduct.foto = ProductImagePath;
            myProduct.id_Kategoria= Convert.ToInt32(ProductCategory);

            using (EgzemplarzContext _db = new EgzemplarzContext())
            {
                // Add product to DB.
                _db.Produkty.Add(myProduct);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}