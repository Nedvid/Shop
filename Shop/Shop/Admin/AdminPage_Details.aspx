<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage_Details.aspx.cs" Inherits="Shop.Admin.AdminPage_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Panel Administratora</h1>
    <hr />
    <h4>Produkt: </h4>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <asp:ListView ID="ListView2" runat="server"
                    DataKeyNames="id_produkt"
                    ItemType="Shop.Models.Produkt" SelectMethod="GetProdukty">
                    <ItemTemplate>
                        <p><strong>ID: </strong><%#: Item.id_produkt %></p>
                        <p><strong>Nazwa: </strong><%#: Item.nazwa_produkt %></p>
                        <p><strong>Ilość: </strong><%#: Item.Ilosc %></p>
                        <p><strong>Cena: </strong><%#: Item.cena %> zł</p>
                        <p><strong>Poprzednia Cena: </strong><%#: Item.poprzednia_cena %> zł</p>
                        <p><strong>VAT: </strong><%#GetNameVAT(Item.id_VAT)%>%</p>
                        <p><strong>Kategoria: </strong><%#GetNameKategoria(Item.id_Kategoria)%></p>
                        <p><strong>Platforma: </strong><%#GetNamePlatforma(Item.id_Platforma)%></p>
                        <p><strong>Opis: </strong><%#: Item.opis %></p>
                    </ItemTemplate>
                    <ItemSeparatorTemplate></ItemSeparatorTemplate>
                </asp:ListView>
            </div>
        </div>
    </div>
    <hr />

    <h4>Edytuj Produkt:</h4>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label1" runat="server">Nazwa:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductName" runat="server" Text=""></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator2" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
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
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator3" runat="server" Text="* Description required." ControlToValidate="AddProductDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddPrice" runat="server">Cena:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductPrice" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator4" runat="server" Text="* Price required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator CssClass="text-danger" ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\,)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label4" runat="server">Obrazek:</asp:Label>
                    <div class="col-md-10">
                        <asp:FileUpload ID="ProductImage" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* Image path required." ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <p></p>
                        <p></p>
                        <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Edytuj" OnClick="EditButton_Click" CausesValidation="true" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />


    <h4>Dodaj Egzmeplarz:</h4>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddName" runat="server">Klucz:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddKlucz" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <p></p>
                        <p></p>
                        <asp:Button CssClass="btn btn-success" ID="AddProductButton" runat="server" Text="Dodaj Egzemplarz" OnClick="AddEgzemplarzButton_Click" CausesValidation="true" />
                        <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
                <th>Akcje</th>
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
                        <td>
                            <asp:Button CssClass="btn btn-danger btn-sm" ID="RemoveButton" runat="server" Text="Usuń Egzemplarz" OnClick="RemoveProductButton_Click" CommandArgument='<%#:Item.id_egzemplarz%>' CausesValidation="false" /></td>

                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>

</asp:Content>
