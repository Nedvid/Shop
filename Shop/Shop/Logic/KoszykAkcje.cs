using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Models;


/*to do:
- w updacie sprawdzać ilosc
- jak liczony jest koszyk
*/
namespace Shop.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        public string ShoppingCartId { get; set; }
        private EgzemplarzContext _db = new EgzemplarzContext();
        public const string CartSessionKey = "CartId";

        public void AddToCart(int id_prd)
        {
            // Retrieve the product from the database.           
            ShoppingCartId = GetCartId();

            var cartItem = _db.ElementyKoszyka.SingleOrDefault(
                c => c.id_koszyk == ShoppingCartId
                && c.id_produkt == id_prd);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new ElementKoszyka
                {
                    id_item = Guid.NewGuid().ToString(),
                    id_produkt = id_prd,
                    id_koszyk = ShoppingCartId,
                    Produkt = _db.Produkty.SingleOrDefault(
                    p => p.id_produkt == id_prd),
                    ilosc = 1,
                    data_utworzenia = DateTime.Now
                };

                _db.ElementyKoszyka.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.ilosc++;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<ElementKoszyka> GetCartItems()
        {
            ShoppingCartId = GetCartId();

            return _db.ElementyKoszyka.Where(
                c => c.id_koszyk == ShoppingCartId).ToList();
        }

        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            // Multiply product price by quantity of that product to get        
            // the current price for each of those products in the cart.  
            // Sum all product price totals to get the cart total.   
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _db.ElementyKoszyka
                               where cartItems.id_koszyk == ShoppingCartId
                               select (int?)cartItems.ilosc *
                               cartItems.Produkt.cena).Sum();
            return total ?? decimal.Zero;
        }

        public ShoppingCartActions GetCart(HttpContext context)
        {
            using (var cart = new ShoppingCartActions())
            {
                cart.ShoppingCartId = cart.GetCartId();
                return cart;
            }
        }

        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[] CartItemUpdates)
        {
            using (var db = new Shop.Models.EgzemplarzContext())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<ElementKoszyka> myCart = GetCartItems();
                    foreach (var cartItem in myCart)
                    {
                        // Iterate through all rows within shopping cart list
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (cartItem.Produkt.id_produkt == CartItemUpdates[i].ProductId)
                            {
                                if (CartItemUpdates[i].PurchaseQuantity < 1 || CartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, cartItem.id_produkt);
                                }
                                else
                                {
                                    UpdateItem(cartId, cartItem.id_produkt, CartItemUpdates[i].PurchaseQuantity);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void RemoveItem(string removeCartID, int removeProductID)
        {
            using (var _db = new Shop.Models.EgzemplarzContext())
            {
                try
                {
                    var myItem = (from c in _db.ElementyKoszyka where c.id_koszyk == removeCartID && c.Produkt.id_produkt == removeProductID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Remove Item.
                        _db.ElementyKoszyka.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void UpdateItem(string updateCartID, int updateProductID, int quantity)
        {
            using (var _db = new Shop.Models.EgzemplarzContext())
            {
                try
                {
                    var myItem = (from c in _db.ElementyKoszyka where c.id_koszyk == updateCartID && c.Produkt.id_produkt == updateProductID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.ilosc = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void EmptyCart()
        {
            ShoppingCartId = GetCartId();
            var cartItems = _db.ElementyKoszyka.Where(
                c => c.id_koszyk == ShoppingCartId);
            foreach (var cartItem in cartItems)
            {
                _db.ElementyKoszyka.Remove(cartItem);
            }
            // Save changes.             
            _db.SaveChanges();
        }

        public int GetCount()
        {
            ShoppingCartId = GetCartId();

            // Get the count of each item in the cart and sum them up          
            int? count = (from cartItems in _db.ElementyKoszyka
                          where cartItems.id_koszyk == ShoppingCartId
                          select (int?)cartItems.ilosc).Sum();
            // Return 0 if all entries are null         
            return count ?? 0;
        }

        public struct ShoppingCartUpdates
        {
            public int ProductId;
            public int PurchaseQuantity;
            public bool RemoveItem;
        }

        public void MigrateCart(string cartId, string userName)
        {
            var shoppingCart = _db.ElementyKoszyka.Where(c => c.id_koszyk == cartId);
            foreach (ElementKoszyka item in shoppingCart)
            {
                item.id_koszyk = userName;
            }
            HttpContext.Current.Session[CartSessionKey] = userName;
            _db.SaveChanges();
        }
    }
}