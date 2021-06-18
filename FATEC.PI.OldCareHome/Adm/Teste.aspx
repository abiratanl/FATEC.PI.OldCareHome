<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="Teste.aspx.cs" Inherits="Adm_Teste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlTeste" AutoPostBack="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="OnSelectedIndexChanged" ></asp:DropDownList>
    <asp:GridView ID="gridTeste" runat="server" CellPadding="4" CssClass="display table table-striped thead-dark" ForeColor="#333333" GridLines="None" Width="100%">
        <%--<AlternatingRowStyle BackColor="White" />--%>
        <Columns>
            <asp:ButtonField ButtonType="Image" FooterText="Editar" ImageUrl="~/img/ico24/edit-orange-24.jpg" Text="Button" />
            <asp:ButtonField ButtonType="Image" ImageUrl="~/img/ico24/delete-red-24.jpg" Text="btnDelete" />
        </Columns>
        
    </asp:GridView> 
    </asp:Content>

