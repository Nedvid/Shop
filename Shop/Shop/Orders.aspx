<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Shop.Orders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Zamówienia</h1>
    <hr />

    <h4>Klucze :</h4>
    <table class="table table-striped table-hover ">
        <thead>
            <tr class="success">
                <th>Id Zamowienia</th>
                <th>Nazwa</th>
                <th>Klucz</th>
                <th>Akcje</th>
            </tr>
        </thead>
        <tbody>
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="id_produkt"
                ItemType="Shop.Models.SzczegolyZamowienie" SelectMethod="GetSzczegoly">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.id_zamowienie%></td>
                        <td><%#GetNameProdukt(Item.id_produkt)%> </td>
                        <td style="color: #77b300"><%#:Item.klucz_egzemplarz%></td>
                        <td><asp:Button CssClass="btn btn-danger btn-sm" ID="Zgłoś" runat="server" Text="Zgłoś" CausesValidation="true" /></td>
                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>

</asp:Content>
