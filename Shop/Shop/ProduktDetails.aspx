<%@ Page Title="ProduktDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ProduktDetails.aspx.cs" Inherits="Shop.ProduktDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="Szczegoly" runat="server" ItemType="Shop.Models.Produkt" SelectMethod ="GetProdukty" RenderOuterTable="false">
            <div class="container body-content">
        <ItemTemplate>
            <div>
                <h1><%#:Item.nazwa_produkt %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.foto %>" style="border:solid; height:120px" alt="<%#:Item.nazwa_produkt%>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Opis:</b><br /><%#:Item.opis%>
                        <br />
                        <span><b>Poprzednia Cena:</b>&nbsp;<%#: String.Format("{0:c}", Item.poprzednia_cena) %></span>
                        <br />
                        <span><b>Cena:</b>&nbsp;<%#: String.Format("{0:c}", Item.cena) %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
                </div>
    </asp:FormView>
</asp:Content>