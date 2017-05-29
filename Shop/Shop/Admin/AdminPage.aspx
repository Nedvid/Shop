<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Shop.Admin.AdminPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Panel Administratora</h1>
    <hr />

    <h4>Dodaj Produkt:</h4>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
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
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelAddName" runat="server">Nazwa:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox CssClass="form-control" ID="AddProductName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
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
                        <asp:RegularExpressionValidator CssClass="text-danger" ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
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
                        <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
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
                        <td><asp:Button CssClass="btn btn-info btn-sm" ID="Edytuj" runat="server" Text="Edytuj" OnClick="AddProductButton_Click" CausesValidation="true" />
                            <asp:Button CssClass="btn btn-danger btn-sm" ID="RemoveProductButton" runat="server" Text="Usuń Produkt" OnClick="RemoveProductButton_Click" CausesValidation="false" />
                            <a href="AdminPage_Details.aspx?productID=<%#:Item.id_produkt%>" class="btn btn-info btn-sm">Szczegóły</a>
                        </td>
                    </tr>
                </ItemTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
            </asp:ListView>
        </tbody>
    </table>


    <!-- 
    

    <hr />
    <h3>Usuń Produkt:</h3>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="LabelRemoveProduct" runat="server">Produkt:</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownRemoveProduct" runat="server" ItemType="Shop.Models.Produkt"
                            SelectMethod="GetProducts" AppendDataBoundItems="true"
                            DataTextField="nazwa_produkt" DataValueField="id_produkt">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <p></p>
                        <asp:Button CssClass="btn btn-danger" ID="RemoveProductButton" runat="server" Text="Usuń Produkt" OnClick="RemoveProductButton_Click" CausesValidation="false" />
                        <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <hr />
    <h3>Usuń Egzemplarz:</h3>
    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label2" runat="server">Produkt:</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" ItemType="Shop.Models.Produkt"
                            SelectMethod="GetProducts" AppendDataBoundItems="true"
                            DataTextField="nazwa_produkt" DataValueField="id_produkt">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-2 control-label" ID="Label4" runat="server">Egzemplarz:</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList CssClass="form-control" ID="DropDownList2" runat="server" ItemType="Shop.Models.Egzemplarz"
                            SelectMethod="GetEgzemplarze" AppendDataBoundItems="true"
                            DataTextField="klucz_egzemplarz" DataValueField="id_egzemplarz">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <p></p>
                        <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Usuń Egzemplarz" OnClick="RemoveProductButton_Click" CausesValidation="false" />
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
        -->









</asp:Content>
