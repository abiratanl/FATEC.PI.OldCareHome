<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="insertPerfil.aspx.cs" Inherits="Adm_insertPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <div class="row">
            <div class="col-12">
                <h2>Insert Perfil</h2>
            </div>
            <div class="col-12">
                <asp:HiddenField ID="per_codigo" runat="server" />
                <label>Perfil:</label>
                <asp:TextBox ID="txtPerfil" runat="server"></asp:TextBox>
            </div>
            <div class="col-12">
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar"  OnClick="btnCadastrar_Click"/>
            </div>
            <hr />
            <asp:Literal ID="ltlMensagem" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>

