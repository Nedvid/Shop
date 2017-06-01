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

        public bool AddEgz(string klucz, int? id_prd)
        {
            var myEgz = new Egzemplarz();
            myEgz.klucz_egzemplarz = klucz;
            myEgz.id_produkt = id_prd;
            myEgz.data_zakup = DateTime.Now;
            myEgz.czy_sprzedano = false;

            using (EgzemplarzContext _db = new EgzemplarzContext())
            {
                //update ilosc
                var myPrd = _db.Produkty.First(p => p.id_produkt == id_prd);
                myPrd.Ilosc++;

                // Add product to DB.
                _db.Egzemplarze.Add(myEgz);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}