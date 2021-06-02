<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="insertPerfil.aspx.cs" Inherits="Adm_insertPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class ="container">
        <div class="row">
            <div class="col-12">
                <h2>Insert Perfil</h2>
            </div>
            <div class="col-12 mb-3">
                <asp:HiddenField ID="per_codigo" runat="server" />
                <label>Perfil:</label>
                <asp:TextBox ID="txtPerfil" runat="server"></asp:TextBox>
                 <hr />
               
            </div>
            <div class="col-12 mb-3">
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar"  OnClick="btnCadastrar_Click"/>
            </div>
            <hr />
            
            <asp:Literal ID="ltlMensagem" runat="server"></asp:Literal>
        </div>

        <!-- Button trigger modal 
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#modCadastrarPerfil">
  Cadastrar Perfil
</button>

<!-- Modal 
<div class="modal fade" id="modCadastrarPerfil" tabindex="-1" role="dialog" aria-labelledby="Cadastramento de Perfil" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Cadastrar Perfil</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div> -->



    </div>

</asp:Content>

