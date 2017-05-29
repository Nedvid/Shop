﻿using System;
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
            if (!IsPostBack)
            {
                // Verify user has completed the checkout process.
                if ((string)Session["userCheckoutCompleted"] != "true")
                {
                    Session["userCheckoutCompleted"] = string.Empty;
                    Response.Redirect("CheckoutError.aspx?" + "Desc=Unvalidated%20Checkout.");
                }

                NVPAPICaller payPalCaller = new NVPAPICaller();

                string retMsg = "";
                string token = "";
                string finalPaymentAmount = "";
                string PayerID = "";
                NVPCodec decoder = new NVPCodec();

                token = Session["token"].ToString();
                PayerID = Session["payerId"].ToString();
                finalPaymentAmount = Session["payment_amt"].ToString();

                bool ret = payPalCaller.DoCheckoutPayment(finalPaymentAmount, token, PayerID, ref decoder, ref retMsg);
                if (ret)
                {
                    // Retrieve PayPal confirmation value.
                    string PaymentConfirmation = decoder["PAYMENTINFO_0_TRANSACTIONID"].ToString();
                    TransactionId.Text = PaymentConfirmation;

                    EgzemplarzContext _db = new EgzemplarzContext();
                    // Get the current order id.
                    int currentOrderId = -1;
                    if (Session["currentOrderId"] != string.Empty)
                    {
                        currentOrderId = Convert.ToInt32(Session["currentOrderID"]);
                    }
                    Zamowienie myCurrentOrder;
                    if (currentOrderId >= 0)
                    {
                        // Get the order based on order id.
                        myCurrentOrder = _db.Zamowienia.Single(o => o.id_zamowienie== currentOrderId);
                        // Update the order to reflect payment has been completed.
                        myCurrentOrder.id_transakcja_platnosci = PaymentConfirmation;
                        // Save to DB.
                        _db.SaveChanges();
                    }

                    // Clear shopping cart.
                    using (Shop.Logic.ShoppingCartActions usersShoppingCart =
                        new Shop.Logic.ShoppingCartActions())
                    {
                        usersShoppingCart.EmptyCart();
                    }

                    // Clear order id.
                    Session["currentOrderId"] = string.Empty;
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Produkty.aspx");
        }
    }
}