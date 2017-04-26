<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Produkt.aspx.cs" Inherits="Shop.Produkty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="Produkty" runat="server"
                DataKeyNames="id_produkt" GroupItemCount="4"
                ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <div class="campaign__offer-box">
                            <div class="campaign__offer-row">
                                <div class="campaign__offer-thumb">
                                    <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                        <img src="/Images/<%#:Item.foto%>">
                                        width="173" height="120" style="border: solid" /></a>
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

                                </div>
                                <div class="campaign__offer-pricebox">
                                    <div class="campaign__offer-pricetop">
                                        <!-- Cena przekreślona i wielkość zniżki: START -->
                                        <div class="campaign__offer-official-price">
                                            <span class="campaign__offer-official-price--value">
                                                <strike>
                                                           <span class="price"><%#:String.Format("{0:c}", Item.poprzednia_cena)%><span class="super"></span></span>                                                        </strike>
                                            </span>
                                        </div>
                                        <div class="campaign__offer-percent-price" data-first-price="59.99" data-second-price="39.9800">
                                            <span class="campaign__offer-percent-price--value">-33%
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
                                        <span class="campaign__offer-buybox--button js-add-to-cart">
                                            <span>KUP TERAZ</span>
                                        </span>
                                </div>
                            </div>
                        </div>
                        <tr />
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width: 100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>


