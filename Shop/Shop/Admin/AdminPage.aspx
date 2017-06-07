<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Shop.Admin.AdminPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Panel Administratora</h1>
    <hr />

    <h4>Dodaj Produkt:</h4>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddName" runat="server">Nazwa:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddCategory" runat="server">Kategoria: </asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownAddCategory" runat="server"
                            ItemType="Shop.Models.Kategoria"
                            SelectMethod="GetCategories" DataTextField="nazwa_kategoria"
                            DataValueField="id_kategoria">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label2" runat="server">Platforma: </asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownAddPlatform" runat="server"
                            ItemType="Shop.Models.Platforma"
                            SelectMethod="GetPlatformy" DataTextField="nazwa_platforma"
                            DataValueField="id_platforma">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label3" runat="server">VAT: </asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownAddVAT" runat="server"
                            ItemType="Shop.Models.VAT"
                            SelectMethod="GetVAT" DataTextField="VAT"
                            DataValueField="id_VAT">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddDescription" runat="server">Opis:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductDescription" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator2" runat="server" Text="* Description required." ControlToValidate="AddProductDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddPrice" runat="server">Cena:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductPrice" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator CssClass="text-danger" ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\,)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label1" runat="server">Obrazek:</asp:Label>
                    <div class="col-md-10">
                        <asp:FileUpload ID="ProductImage" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <p></p>
                        <p></p>
                        <asp:Button CssClass="btn btn-success" ID="AddProductButton" runat="server" Text="Dodaj Produkt" OnClick="AddProductButton_Click" CausesValidation="true" />
                        <asp:Label ID="LabelAddStatusSuccess" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelAddStatusDanger" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />

    <h4>Produkty :</h4>
    <table class="table table-striped table-hover ">
        <thead>
            <tr class="success">
                <th>Id_Produkt</th>
                <th>Nazwa</th>
                <th>Cena</th>
                <th>Poprzednia Cena</th>
                <th>Ilosc</th>
                <th>Akcje</th>
            </tr>
        </thead>
        <tbody>
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="id_produkt"
                ItemType="Shop.Models.Produkt" SelectMethod="GetProducts">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.id_produkt%></td>
                        <td><%#:Item.nazwa_produkt%></td>
                        <td><%#:Item.cena%></td>
                        <td><%#:Item.poprzednia_cena%></td>
                        <td><%#:Item.Ilosc%></td>
                        <td>
                            <asp:Button CssClass="btn btn-danger btn-sm" ID="RemoveButton" runat="server" Text="Usuń Produkt" OnClick="RemoveProductButton_Click" CommandArgument='<%#:Item.id_produkt%>' CausesValidation="false" />
                            <a href="AdminPage_Details.aspx?productID=<%#:Item.id_produkt%>" class="btn btn-success btn-sm">Szczegóły</a>
                        </td>
                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>
</asp:Content>
