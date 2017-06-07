<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Koszyk.aspx.cs" Inherits="Shop.Koszyk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="content">
        <div class="container">

            <div class="row">
                <div id="ShoppingCartTitle" runat="server" class="ContentHead">
                    <h1>Koszyk</h1>
                </div>
                <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
                    ItemType="Shop.Models.ElementKoszyka" SelectMethod="GetShoppingCartItems"
                    CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="id_produkt" HeaderText="ID" SortExpression="id_produkt" />
                        <asp:BoundField DataField="Produkt.nazwa_produkt" HeaderText="Nazwa" />
                        <asp:BoundField DataField="Produkt.cena" HeaderText="Cena" DataFormatString="{0:c}" />
                        <asp:TemplateField HeaderText="Ilość">
                            <ItemTemplate>
                                <asp:TextBox CssClass="text-muted" ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.ilosc %>"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Razem">
                            <ItemTemplate>
                                <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.ilosc)) *  Convert.ToDouble(Item.Produkt.cena)))%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Usuń Produkt">
                            <ItemTemplate>
                                <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <div>
                    <p></p>
                    <strong>
                        <asp:Label ID="LabelTotalText" runat="server" Text="Razem: "></asp:Label>
                        <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
                    </strong>
                </div>
                <br />
                <div class="button-koszyk">
                    <asp:Button CssClass="btn btn-success" ID="UpdateBtn" runat="server" Text="Zaaktualizuj" OnClick="UpdateBtn_Click" />
                </div>
                <div class="button-koszyk">
                    <asp:ImageButton ID="CheckoutImageBtn" runat="server"
                        ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif"
                        Width="145" AlternateText="Check out with PayPal"
                        OnClick="CheckoutBtn_Click"
                        BackColor="Transparent" BorderWidth="0" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
