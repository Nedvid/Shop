<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutReview.aspx.cs" Inherits="Shop.Checkout.CheckoutReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>
    <h3>Dziękujemy!</h3>
    <p>Swój Klucz znajdziesz w zakładce: Klucze</p>
    <asp:Button CssClass="btn btn-success" ID="CheckoutConfirm" runat="server" Text="Wróć do Zakupów" OnClick="CheckoutConfirm_Click" />
</asp:Content>