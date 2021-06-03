<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="HomeRestrita.aspx.cs" Inherits="Adm_HomeRestrita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="text-right">
            <asp:Literal ID="ltlUsuarioLogado" runat="server">Usuário logado:</asp:Literal>
            <asp:Label ID="lblSessao" CssClass="text-primary font-weight-bold" runat="server" Text="---"></asp:Label>
        </div>
    </div>
</asp:Content>

