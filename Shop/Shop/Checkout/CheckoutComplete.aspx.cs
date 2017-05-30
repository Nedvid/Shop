using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;

namespace Shop.Checkout
{
    public partial class CheckoutComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Clear shopping cart.
            using (Shop.Logic.ShoppingCartActions usersShoppingCart =
                new Shop.Logic.ShoppingCartActions())
            {
                usersShoppingCart.EmptyCart();
            }

            // Clear order id.
            Session["currentOrderId"] = string.Empty;
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Produkty.aspx");
        }
    }
}