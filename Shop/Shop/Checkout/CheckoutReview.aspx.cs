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
        EgzemplarzContext _db = new EgzemplarzContext();

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
                    string tmp = decoder["AMT"].ToString();
                    tmp = tmp.Replace('.', ',');
                    myOrder.Suma = Convert.ToDecimal(tmp);

                    // Get DB context.
                    

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
                            myOrderDetail.id_zamowienie = myOrder.id_zamowienie;
                            myOrderDetail.Login = User.Identity.Name;
                            myOrderDetail.id_produkt = myOrderList[i].id_produkt;
                            myOrderDetail.id_egzemplarz = WolnyEgzemplarz(myOrderList[i].id_produkt);
                            myOrderDetail.klucz_egzemplarz = GetKlucz(myOrderDetail.id_egzemplarz);
                            myOrderDetail.cena = myOrderList[i].Produkt.cena;

                            // Add OrderDetail to DB.
                            _db.SzczegolyZamowienia.Add(myOrderDetail);
                            _db.SaveChanges();
                        }

                        // Clear order id.
                        Session["currentOrderId"] = string.Empty;

                        // Set OrderId.
                        Session["currentOrderId"] = myOrder.id_zamowienie;

                        // Clear shopping cart.
                        usersShoppingCart.EmptyCart();

                        // Display Order information.
                        //List<Zamowienie> orderList = new List<Zamowienie>();
                        //orderList.Add(myOrder);
                        //ShipInfo.DataSource = orderList;
                        //ShipInfo.DataBind();

                        // Display OrderDetails.
                        //OrderItemList.DataSource = myOrderList;
                        //OrderItemList.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
        }
 
        protected int WolnyEgzemplarz(int? id_prd)
        {
            var Egz = _db.Egzemplarze.First(
                c => c.id_produkt == id_prd
                && c.czy_sprzedano == false);

            Egz.data_sprzedaz = DateTime.Now;
            Egz.czy_sprzedano = true;

            var Prd = _db.Produkty.First(
                c => c.id_produkt == id_prd);

            Prd.Ilosc -= 1;

            _db.SaveChanges();

            return Egz.id_egzemplarz;
        }

        protected string GetKlucz(int? id_prd)
        {
            var Egz = _db.Egzemplarze.First(
                 c => c.id_produkt == id_prd);

            return Egz.klucz_egzemplarz;
        }


        protected void CheckoutConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Produkty.aspx");
        }
    }
}