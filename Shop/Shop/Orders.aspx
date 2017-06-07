<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Shop.Orders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Zamówienia</h1>
    <hr />
    <table class="table table-striped table-hover ">
        <thead>
            <tr class="success">
                <th>Id Zamowienia</th>
                <th>Suma</th>
                <th>Data</th>
                <th>Akcje</th>
            </tr>
        </thead>
        <tbody>
            <asp:ListView ID="ZamowieniaList" runat="server"
                ItemType="Shop.Models.Zamowienie" SelectMethod="GetZamowienia">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.id_zamowienie%></td>
                        <td><%#:Item.Suma%></td>
                        <td><%#:Item.data_zamowienie%></td>
                        <td><a href="OrdersDetails.aspx?OrderID=<%#:Item.id_zamowienie%>" class="btn btn-success btn-sm">Szczegóły</a></td>
                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>
</asp:Content>

