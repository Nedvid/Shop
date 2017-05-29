<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage_Details.aspx.cs" Inherits="Shop.Admin.AdminPage_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Panel Administratora</h1>
    <hr />
    <h4>Produkt: </h4>
        <table class="table table-striped table-hover ">
            <thead>
                <tr class="success">
                    <th>Id_Produkt</th>
                    <th>Nazwa</th>
                    <th>Cena</th>
                    <th>Poprzednia Cena</th>
                    <th>Ilosc</th>

                </tr>
            </thead>
            <tbody>
                <asp:ListView ID="productList" runat="server"
                    DataKeyNames="id_produkt"
                    ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty">
                    <ItemTemplate>
                        <tr>
                            <td><%#:Item.id_produkt%></td>
                            <td><%#:Item.nazwa_produkt%></td>
                            <td><%#:Item.cena%></td>
                            <td><%#:Item.poprzednia_cena%></td>
                            <td><%#:Item.Ilosc%></td>

                        </tr>
                    </ItemTemplate>
                    <ItemSeparatorTemplate></ItemSeparatorTemplate>
                </asp:ListView>
            </tbody>
        </table>
    <hr />

    <h4>Egzemplarze: </h4>
        <table class="table table-striped table-hover ">
            <thead>
                <tr class="success">
                    <th>Id_Egzemplarz</th>
                    <th>Klucz</th>
                    <th>Data Sprzedaż</th>
                    <th>Data Zakup</th>
                    <th>Sprzedano</th>
                </tr>
            </thead>
            <tbody>
                <asp:ListView ID="ListView1" runat="server"
                    DataKeyNames="id_produkt"
                    ItemType="Shop.Models.Egzemplarz" SelectMethod="GetEgzemplarze">
                    <ItemTemplate>
                        <tr>
                            <td><%#:Item.id_egzemplarz%></td>
                            <td><%#:Item.klucz_egzemplarz%></td>
                            <td><%#:Item.data_sprzedaz%></td>
                            <td><%#:Item.data_zakup%></td>
                            <td><%#:Item.czy_sprzedano%></td>

                        </tr>
                    </ItemTemplate>
                    <ItemSeparatorTemplate></ItemSeparatorTemplate>
                </asp:ListView>
            </tbody>
        </table>

</asp:Content>
