<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="Produkty.aspx.cs" Inherits="Shop.Produkty" %>
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
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                        <img src="/Images/<%#:Item.foto%>"
                                            width="173" height="120" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                        <span>
                                            <%#:Item.nazwa_produkt%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Poprzednia Cena: </b><%#:String.Format("{0:c}", Item.poprzednia_cena)%>
                                    </span>
                                    <br />
                                    <span>
                                        <b>Cena: </b><%#:String.Format("{0:c}", Item.cena)%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
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