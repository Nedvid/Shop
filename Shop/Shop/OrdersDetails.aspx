<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdersDetails.aspx.cs" Inherits="Shop.OrdersDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Produkty</h1>
    <hr />
    <table class="table table-striped table-hover ">
        <thead>
            <tr class="success">
                <th>Id</th>
                <th>Nazwa</th>
                <th>Cena</th>
                <th>Klucz</th>
            </tr>
        </thead>
        <tbody>
            <asp:ListView ID="SzczegolyList" runat="server"
                ItemType="Shop.Models.SzczegolyZamowienie" SelectMethod="GetSzczegoly">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.id_szczegoly_zamowienie%></td>
                        <td><%#:Item.produkt%></td>
                        <td><%#:Item.cena%></td>
                        <td style="color: greenyellow"><%#:Item.klucz_egzemplarz%></td>
                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>
</asp:Content>