<%@ Page Title="ProduktDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduktDetails.aspx.cs" Inherits="Shop.ProduktDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="Szczegoly" runat="server" ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty" RenderOuterTable="false">
        <ItemTemplate>
            <div class="container body-content">
                <div>
                    <h1><%#:Item.nazwa_produkt %></h1>
                </div>

                <div class="produkt">
                    <div class="campaign__offer-thumb">
                        <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                            <img src="/Images/<%#:Item.foto%>">
                        </a>
                    </div>
                    <div class="campaign__offer-description">
                        <h3 class="campaign__offer-name">
                            <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                <span>
                                    <%#:Item.nazwa_produkt%>
                                </span>
                            </a>
                        </h3>
                        <h4 class="campaign__offer-name">
                            <span>Ilosc: <%#: Item.Ilosc %>
                            </span>
                        </h4>
                    </div>
                    <div class="campaign__offer-pricebox">
                        <div class="campaign__offer-pricetop">
                            <!-- Cena przekreślona i wielkość zniżki: START -->
                            <div class="campaign__offer-official-price">
                                <span class="campaign__offer-official-price--value">
                                    <strike>
                                                                    <span class="price"><%#:Item.poprzednia_cena != 0 ? String.Format("{0:c}", Item.poprzednia_cena): ""%><span class="super"></span></span>
                                                                </strike>
                                </span>
                            </div>
                            <div class="campaign__offer-percent-price">
                                <span class="campaign__offer-percent-price--value">
                                    <%#:Item.poprzednia_cena != 0 ? String.Format("{0:p}" , (1-(Item.cena/Item.poprzednia_cena))): ""%>
                                </span>
                            </div>
                            <!-- Cena przekreślona i wielkość zniżki: END -->
                            <div style="clear: both;"></div>
                        </div>
                        <div class="campaign__offer-pricebottom">
                            <div class="campaign__offer-price-container">
                                <%#:String.Format("{0:c}", Item.cena)%>
                            </div>
                        </div>
                    </div>
                    <div class="campaign__offer-buybox">
                        <a href="/DodajDoKoszyka.aspx?id_produkt=<%#:Item.id_produkt %>" style="text-decoration: none;">
                            <span class="campaign__offer-buybox--button js-add-to-cart">
                                 <span><i class="fa fa-shopping-cart" aria-hidden="true" style="margin-right: 5px;"></i> KUP TERAZ</span>
                            </span>
                        </a>
                    </div>
                </div>
                <div>
                    <h3>Opis:</h3>
                    <p><%#:Item.opis %></p>
                </div>
        </ItemTemplate>

    </asp:FormView>
</asp:Content>

