<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Produkt.aspx.cs" Inherits="Shop.Produkty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>

        <div id="content">
            <div class="container">

                <div class="row">
                    <div class="header">
                        <div class="header-black">
                            <div class="header-text">
                                <div class="campaign__offer-description" style="margin-top: 10px;">
                                    <h3 class="campaign__offer-name">
                                        <span>Mass Effect Andromeda
                                        </span>
                                    </h3>
                                    <p style="word-spacing: 5px;">
                                        <span><i class="fa fa-gamepad" aria-hidden="true"></i> Akcja
                                        </span>
                                         <span><i class="fa fa-desktop" aria-hidden="true"></i> Ubisoft
                                        </span>
                                    </p>
                                </div>
                                <div class="campaign__offer-pricebox"  style="margin-top: 22px; margin-left: 550px;">
                                    <div class="campaign__offer-pricetop">
                                        <!-- Cena przekreślona i wielkość zniżki: START -->
                                        <div class="campaign__offer-official-price">
                                            <span class="campaign__offer-official-price--value">
                                                <strike>
                                                                    <span class="price">300 zł<span class="super"></span></span>
                                                                </strike>
                                            </span>
                                        </div>
                                        <div class="campaign__offer-percent-price">
                                            <span class="campaign__offer-percent-price--value">50%
                                            </span>
                                        </div>
                                        <!-- Cena przekreślona i wielkość zniżki: END -->
                                        <div style="clear: both;"></div>
                                    </div>
                                    <div class="campaign__offer-pricebottom">
                                        <div class="campaign__offer-price-container">
                                            300 zł
                                        </div>
                                    </div>
                                </div>
                                <div class="campaign__offer-buybox"  style="margin-top: 30px;">
                                    <span class="campaign__offer-buybox--button js-add-to-cart">
                                        <span><i class="fa fa-shopping-cart" aria-hidden="true" style="margin-right: 5px;"></i>Kup Teraz</span>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Panele boczne -->
                <div class="col-sm-3">
                    <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                            <h3 class="panel-title"><i class="fa fa-gamepad" aria-hidden="true" style="margin-right: 5px;"></i>Kategorie</h3>
                        </div>
                        <div class="panel-body">
                            <ul class="nav nav-pills nav-stacked category-menu">
                                <asp:ListView ID="KategoriaList"
                                    ItemType="Shop.Models.Kategoria"
                                    runat="server"
                                    SelectMethod="GetKategorie">
                                    <ItemTemplate>
                                        <li class="active-category">
                                            <a href="/Produkty.aspx?id=<%#: Item.id_kategoria %>"><%#: Item.nazwa_kategoria %><span class="badge pull-right"></span>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                    <ItemSeparatorTemplate></li>  </ItemSeparatorTemplate>
                                </asp:ListView>
                            </ul>
                        </div>
                    </div>
                    <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                            <h3 class="panel-title"><i class="fa fa-laptop" aria-hidden="true" style="margin-right: 5px;"></i>Platformy</h3>
                        </div>
                        <div class="panel-body">
                            <ul class="nav nav-pills nav-stacked category-menu">
                                <asp:ListView ID="ListView2"
                                    ItemType="Shop.Models.Platforma"
                                    runat="server"
                                    SelectMethod="GetPlatformy">
                                    <ItemTemplate>
                                        <li class="active-category">
                                            <a href="/Produkty.aspx?idp=<%#: Item.id_platforma%>"><%#: Item.nazwa_platforma%><span class="badge pull-right"></span>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                    <ItemSeparatorTemplate></li>  </ItemSeparatorTemplate>
                                </asp:ListView>
                            </ul>
                        </div>
                    </div>
                    <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                            <h3 class="panel-title clearfix"><i class="fa fa-usd" aria-hidden="true" style="margin-right: 5px;"></i>Cena</h3>
                        </div>
                        <div class="panel-body">
                            <ul class="nav nav-pills nav-stacked category-menu">
                                <li class="active-category">
                                    <a href="/Produkty.aspx?price=50">> 50zł <span class="badge pull-right"></span></a>
                                </li>
                                <li class="active-category">
                                    <a href="/Produkty.aspx?price=100">> 100zł <span class="badge pull-right"></span></a>
                                </li>
                                <li class="active-category">
                                    <a href="/Produkty.aspx?price=150">> 150zł <span class="badge pull-right"></span></a>
                                </li>
                                <li class="active-category">
                                    <a href="/Produkty.aspx?price=200">> 200zł <span class="badge pull-right"></span></a>
                                </li>
                                <li class="active-category">
                                    <a href="/Produkty.aspx?price=250">> 250zł <span class="badge pull-right"></span></a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>

                <!--PRODUKTY-->
                <div class="col-sm-9">
                    <div class="row products">

                        <div class="form-group">
                            <label class="control-label">Wyszukiwarka</label>
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-search" aria-hidden="true"></i></span>
                                <input type="text" id="myText" value="Szukaj..." class="form-control">
                                <span class="input-group-btn">
                                    <button class="btn btn-success" type="button" onclick="search()"><i class="fa fa-search" aria-hidden="true" style="margin-right: 5px;"></i>Szukaj</button>
                                    <script>
                                        function search() {
                                            var x = document.getElementById("myText").value;
                                            window.open("/Produkty.aspx?name=" + x, "_self");
                                        }
                                    </script>
                                </span>
                            </div>
                        </div>



                        <asp:ListView ID="productList" runat="server"
                            DataKeyNames="id_produkt"
                            ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty">
                            <ItemTemplate>
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
                                        <!--
                                            <h4 class="campaign__offer-name">
                                                <span>Ilosc: <%#: Item.Ilosc %>
                                                </span>
                                            </h4>
                                            -->
                                        <p>
                                            <span><i class="fa fa-gamepad" aria-hidden="true"></i> <%#GetNameKategoria(Item.id_Kategoria)%> 
                                            </span>
                                        </p>
                                        <p>
                                            <span><i class="fa fa-desktop" aria-hidden="true"></i> <%#GetNamePlatforma(Item.id_Platforma)%> 
                                            </span>
                                        </p>
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
                                                <span><i class="fa fa-shopping-cart" aria-hidden="true" style="margin-right: 5px;"></i>Kup Teraz</span>
                                            </span>
                                        </a>
                                    </div>
                                </div>
                            </ItemTemplate>
                            <ItemSeparatorTemplate></ItemSeparatorTemplate>
                        </asp:ListView>
                    </div>
                </div>

            </div>
        </div>
        </div>


    </section>
</asp:Content>
