<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
   CodeBehind="Produkt.aspx.cs" Inherits="Shop.Produkty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <section>
      <div class="header">
         <h1>the story</h1>
      </div>
      <div class="container body-content">
      <hgroup>
         <h2><%: Page.Title %></h2>
      </hgroup>
      <div id="all">
         <div id="content">
            <div class="container">
               <div class="row">
                  <!-- Panele boczne -->
                  <div class="col-sm-3">
                     <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                           <h3 class="panel-title">Kategorie</h3>
                        </div>
                        <div class="panel-body">
                           <ul class="nav nav-pills nav-stacked category-menu">
                              <asp:ListView ID="KategoriaList"  
                                 ItemType="Shop.Models.Kategoria" 
                                 runat="server"
                                 SelectMethod="GetKategorie" >
                                 <ItemTemplate>
                                    <li>
                                       <a href="/Produkty.aspx?id=<%#: Item.id_kategoria %>"><%#: Item.nazwa_kategoria %><span class="badge pull-right"></span></a>
                                    </li>
                                 </ItemTemplate>
                                 <ItemSeparatorTemplate>  </li>  </ItemSeparatorTemplate>
                              </asp:ListView>
                           </ul>
                        </div>
                     </div>
                     <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                           <h3 class="panel-title">Platformy</h3>
                        </div>
                        <div class="panel-body">
                           <form>
                              <div class="form-group">
                                 <div class="checkbox">
                                    <label>
                                        <asp:ListView ID="ListView1"  
                                        ItemType="Shop.Models.Platforma" 
                                        runat="server"
                                        SelectMethod="GetPlatformy" >
                                        <ItemTemplate>

                                        <input type="checkbox"><%#: Item.nazwa_platforma %></br>

                                                </ItemTemplate>
                                        <ItemSeparatorTemplate>  </br>  </ItemSeparatorTemplate>
                                        </asp:ListView>
                                    </label>
                                 </div>
                              </div>
                              <button class="btn btn-default btn-sm btn-template-main"><i class="fa fa-pencil"></i>Zastosuj</button>
                           </form>
                        </div>
                     </div>
                     <div class="panel panel-default sidebar-menu">
                        <div class="panel-heading">
                           <h3 class="panel-title clearfix">Cena</h3>
                        </div>
                        <div class="panel-body">
                           <form>
                              <div class="form-group">
                                 <div class="checkbox">
                                    <label>
                                    <input type="checkbox">
                                    <span class="colour white"></span>> 50zł
                                    </label>
                                 </div>
                                 <div class="checkbox">
                                    <label>
                                    <input type="checkbox">
                                    <span class="colour blue"></span>> 100zł (10)
                                    </label>
                                 </div>
                                 <div class="checkbox">
                                    <label>
                                    <input type="checkbox">
                                    <span class="colour green"></span>> 150zł (20)
                                    </label>
                                 </div>
                                 <div class="checkbox">
                                    <label>
                                    <input type="checkbox">
                                    <span class="colour yellow"></span>> 200zł (13)
                                    </label>
                                 </div>
                                 <div class="checkbox">
                                    <label>
                                    <input type="checkbox">
                                    <span class="colour red"></span>Red (10)
                                    </label>
                                 </div>
                              </div>
                              <button class="btn btn-default btn-sm btn-template-main"><i class="fa fa-pencil"></i>Zastosuj</button>
                           </form>
                        </div>
                     </div>
                  </div>
                  <!--PRODUKTY-->
                  <div class="col-sm-9">
                     <div class="row products">
                        <asp:ListView ID="Produkty" runat="server"
                           DataKeyNames="id_produkt" GroupItemCount="4"
                           ItemType="Shop.Models.Produkt" SelectMethod="GetAll">
                           <EmptyDataTemplate>
                              <table>
                                 <tr>
                                    <td>No data was returned.</td>
                                 </tr>
                              </table>
                           </EmptyDataTemplate>
                           <EmptyItemTemplate>
                              <td />
                           </EmptyItemTemplate>
                           <GroupTemplate>
                           <tr id="itemPlaceholderContainer" runat="server">
                           <td id="itemPlaceholder" runat="server"></td>
                           </tr>
                           </GroupTemplate>
                           <ItemTemplate>
                              <td runat="server">
                                 <div class="campaign__offer-box">
                                    <div class="campaign__offer-row">
                                       <div class="campaign__offer-thumb">
                                          <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                          <img src="/Images/<%#:Item.foto%>">
                                          width="100" height="50" style="border: solid" /></a>
                                          </a>
                                       </div>
                                       <div class="campaign__offer-description">
                                          <h3 class="campaign__offer-name">
                                             <a href="ProduktDetails.aspx?productID=<%#:Item.id_produkt%>">
                                             <span>
                                             <%#:Item.nazwa_produkt%>
                                             </span>
                                             </a>
                                          </h3>
                                          <h4 class="campaign__offer-name"
                                          <span>
                                          Ilosc: <%#: Item.Ilosc %>
                                          </span>
                                          </h4>
                                       </div>
                                       <div class="campaign__offer-pricebox">
                                          <div class="campaign__offer-pricetop">
                                             <!-- Cena przekreślona i wielkość zniżki: START -->
                                             <div class="campaign__offer-official-price">
                                                <span class="campaign__offer-official-price--value">
                                                <strike>
                                                <span class="price"><%#:String.Format("{0:c}", Item.poprzednia_cena)%><span class="super"></span></span>                                                        </strike>
                                                </span>
                                             </div>
                                             <div class="campaign__offer-percent-price">
                                                <span class="campaign__offer-percent-price--value">
                                                <%#:String.Format("{0:p}" , (1-(Item.cena/Item.poprzednia_cena)))%>
                                                </span>
                                             </div>
                                             <!-- Cena przekreślona i wielkość zniżki: END -->
                                             <div style="clear: both;"></div>
                                          </div>
                                          <div class="campaign__offer-pricebottom">
                                             <div class="campaign__offer-price-container">
                                                <%#:String.Format("{0:c}", Item.cena)%>
                                             </div>
                                          </div>
                                       </div>
                                       <div class="campaign__offer-buybox">
                                          <A style="text-decoration: none; "a href="/DodajDoKoszyka.aspx?id_produkt=<%#:Item.id_produkt %>"">
                                          <span class="campaign__offer-buybox--button js-add-to-cart">
                                          <span>KUP TERAZ</span>
                                          </span>
                                          </A>
                                       </div>
                                    </div>
                                 </div>
                                 </br>
                              <tr />
                                 </td>
                           </ItemTemplate>
                           <LayoutTemplate>
                           <table style="width: 100%;">
                           <tbody>
                           <tr>
                           <td>
                           <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
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
                     <!-- /.products -->
                     <div class="pages">
                     <p class="loadMore">
                     <a href="#" class="btn btn-template-main"><i class="fa fa-chevron-down"></i>Load more</a>
                     </p>
                     <ul class="pagination">
                     <li><a href="#">&laquo;</a>
                     </li>
                     <li class="active"><a href="#">1</a>
                     </li>
                     <li><a href="#">2</a>
                     </li>
                     <li><a href="#">3</a>
                     </li>
                     <li><a href="#">4</a>
                     </li>
                     <li><a href="#">5</a>
                     </li>
                     <li><a href="#">&raquo;</a>
                     </li>
                     </ul>
                     </div>
                  </div>
               </div>
            </div>
         </div>
   </section>
   </div>
</asp:Content>