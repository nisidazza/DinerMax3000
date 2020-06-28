<%@ Page Title="" Language="C#" MasterPageFile="~/DinerMax3000MasterPage.master" AutoEventWireup="true" CodeFile="Menus.aspx.cs" Inherits="Menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="Server">
    <asp:GridView ID="gvMenu" DataSourceID="odsMenu" runat="server" Height="106px" Width="600px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="MenuHeadings"><%#Eval("Name") %> </div>
                    <asp:GridView CssClass="MenuGridViews" ID="gvMenuItems" runat="server"></asp:GridView>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsMenu" runat="server" SelectMethod="GetAllMenus" TypeName="DinerMax3000.Business.Menu"></asp:ObjectDataSource>
</asp:Content>

