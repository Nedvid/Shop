<%@ Page Title="ProduktDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduktDetails.aspx.cs" Inherits="Shop.ProduktDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="Szczegoly" runat="server" ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty" RenderOuterTable="false">
        <ItemTemplate>
            <div id="content">
                <div class="container">
                    <div class="row">
                        <div class="header">
                            <div class="header-black">
                                <div class="header-text">
                                    <div class="campaign__offer-description" style="margin-top: 10px;">
                                        <h3 class="campaign__offer-name">
                                            <span><%#: Item.nazwa_produkt %>
                                            </span>
                                        </h3>
                                        <p style="word-spacing: 5px;">
                                            <span><i class="fa fa-gamepad" aria-hidden="true"></i> <%#GetNameKategoria(Item.id_Kategoria)%> </span>
                                            <span><i class="fa fa-desktop" aria-hidden="true"></i> <%#GetNamePlatforma(Item.id_Platforma)%> 
                                            </span>
                                        </p>
                                    </div>
                                    <div class="campaign__offer-pricebox" style="margin-top: 22px; margin-left: 470px;">
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
                                    <div class="campaign__offer-buybox" style="margin-top: 30px;">
                                        <a href="/DodajDoKoszyka.aspx?id_produkt=<%#:Item.id_produkt %>" style="text-decoration: none;">
                                            <span class="campaign__offer-buybox--button js-add-to-cart">
                                                <span><i class="fa fa-shopping-cart" aria-hidden="true" style="margin-right: 5px;"></i>
                                                    Kup Teraz
                                                </span>
                                            </span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div>
                            <p><%#:Item.opis %></p>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>

    </asp:FormView>
</asp:Content>

