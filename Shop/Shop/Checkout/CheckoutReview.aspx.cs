using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Models;
using System.Web.SessionState;

namespace Shop.Checkout
{
    public partial class CheckoutReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) 
        {
            if (!IsPostBack)
            {
                NVPAPICaller payPalCaller = new NVPAPICaller();
                string retMsg = "";
                string token = "";
                string PayerID = "";
                NVPCodec decoder = new NVPCodec();
                token = Session["token"].ToString();


                bool ret = payPalCaller.GetCheckoutDetails(token, ref PayerID, ref decoder, ref retMsg);
                if (ret)
                {
                    Session["payerId"] = PayerID;

                    var myOrder = new Zamowienie();
                    myOrder.data_zamowienie = Convert.ToDateTime(decoder["TIMESTAMP"].ToString());
                    myOrder.Login = User.Identity.Name;
                    myOrder.Email = decoder["EMAIL"].ToString();
                    myOrder.Suma = Convert.ToDecimal(decoder["AMT"].ToString());

                    // Verify total payment amount as set on CheckoutStart.aspx.
                    try
                    {
                        decimal paymentAmountOnCheckout = Convert.ToDecimal(Session["payment_amt"].ToString());
                        decimal paymentAmoutFromPayPal = Convert.ToDecimal(decoder["AMT"].ToString());
                        if (paymentAmountOnCheckout != paymentAmoutFromPayPal)
                        {
                            Response.Redirect("CheckoutError.aspx?" + "Desc=Amount%20total%20mismatch.");
                        }
                    }
                    catch (Exception)
                    {
                        Response.Redirect("CheckoutError.aspx?" + "Desc=Amount%20total%20mismatch.");
                    }

                    // Get DB context.
                    EgzemplarzContext _db = new EgzemplarzContext();

                    // Add order to DB.
                    _db.Zamowienia.Add(myOrder);
                    _db.SaveChanges();

                    // Get the shopping cart items and process them.
                    using (Shop.Logic.ShoppingCartActions usersShoppingCart = new Shop.Logic.ShoppingCartActions())
                    {
                        List<ElementKoszyka> myOrderList = usersShoppingCart.GetCartItems();

                        // Add OrderDetail information to the DB for each product purchased.
                        for (int i = 0; i < myOrderList.Count; i++)
                        {
                            // Create a new OrderDetail object.
                            var myOrderDetail = new SzczegolyZamowienie();
                            myOrderDetail.id_szczegoly_zamowienie = myOrder.id_zamowienie;
                            myOrderDetail.Login = User.Identity.Name;
                            myOrderDetail.id_produkt = myOrderList[i].id_produkt;
                            myOrderDetail.id_egzemplacz = myOrderList[i].id_egzemplarz;
                            myOrderDetail.ilosc = myOrderList[i].ilosc;
                            myOrderDetail.cena = myOrderList[i].Produkt.cena;

                            // Add OrderDetail to DB.
                            _db.SzczegolyZamowienia.Add(myOrderDetail);
                            _db.SaveChanges();
                        }

                        // Set OrderId.
                        Session["currentOrderId"] = myOrder.id_zamowienie;

                        // Display Order information.
                        List<Zamowienie> orderList = new List<Zamowienie>();
                        orderList.Add(myOrder);
                        ShipInfo.DataSource = orderList;
                        ShipInfo.DataBind();

                        // Display OrderDetails.
                        OrderItemList.DataSource = myOrderList;
                        OrderItemList.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
        }

        protected void CheckoutConfirm_Click(object sender, EventArgs e)
        {
            Session["userCheckoutCompleted"] = "true";
            Response.Redirect("~/Checkout/CheckoutComplete.aspx");
        }
    }
}