<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="InsertPatologia.aspx.cs" Inherits="Adm_InsertPatologia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="text-right mr-3">
        <asp:Label ID="lblUsuario"  runat="server" Text="Usuário:"></asp:Label>            
        <asp:Label ID="lblSessao" CssClass="text-primary font-weight-bold" runat="server" Text="---"></asp:Label>
    </div>
     <div class="card card-primary">
                            <div class="card-header bg-primary text-white">
                                <h3 class="card-title " >Cadastramento de Patologias</h3>
                            </div>
                            <!-- /.card-header -->
                            <!-- form start -->

                            <div class="card-body">
                                <div class="form-group" >
                                    <label for="txtInsertPatologiaDescricao">Patologia:</label>
                                    <asp:TextBox ID="txtInsertPatologiaDescricao" type="text" required="required" class="form-control" placeholder="Digite Patologia" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <label for="txtInsertPatologiaRestricao">Restrição:</label>
                                    <asp:TextBox ID="txtInsertPatologiaRestricao" type="text" required="required" class="form-control" placeholder="Digite email" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtInsertPatologiaCid">Cid:</label>
                                     <asp:TextBox ID="txtInsertPatologiaCid" type="text" required="required" class="form-control" placeholder="Digite CID" runat="server"></asp:TextBox>
                                </div>                               
                            </div>
                            <!-- /.card-body -->

                            <div class="card-footer text-right">
                                <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        <%--<form class="form-inline">--%>                            
                            <asp:LinkButton ID="btnInsertPatologiaVoltar" CssClass="text-center mx-3" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;" OnClick="btnInsertPatologiaVoltar_Click">
                                <asp:Image ID="Image1" runat="server" Width="48px" ImageUrl="~/img/back.png" BackColor="Transparent" />
                                <br />
                                <asp:Label ID="Label5" runat="server" Text="Voltar"></asp:Label>
                            </asp:LinkButton>
                            <asp:LinkButton ID="btnInsertPatologiaCadastrar" CssClass="text-center mx-3" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;" OnClick="btnInsertPatologiaCadastrar_Click" >
                                <asp:Image ID="Image2" runat="server" Width="48px" ImageUrl="~/img/ok_user.jpg " BackColor="Transparent" />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Cadastrar"></asp:Label>
                            </asp:LinkButton>
                        <%--</form>--%>
                    </asp:Panel>
                            </div>

                        </div>
                        <!-- /.card -->

    <!-- Modal erro Banco de Dados-->
        <div class="modal fade " id="modalErroBanco" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="">Problema na Conexão</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-danger  text-center">
                        <div class="row">
                            <div class="col-3">
                                <asp:Image ID="imgErro" class="img-80-80" ImageUrl="~/img/erro1.png" runat="server" />
                            </div>
                            <div class="col-9 mt-4">
                                <p><strong>Ocorreu um erro ao acessar o banco de dados. Verifique a conexão e tente novamente.</strong></p>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->
    <!-- Modal Cadastro OK-->
        <div class="modal fade " id="modalCadastroOk" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="">Confirmação</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-danger  text-center">
                        <div class="row">
                            <div class="col-3">
                                <asp:Image ID="Image3" class="img-80-80" ImageUrl="~/img/success.jpeg" runat="server" />
                            </div>
                            <div class="col-9 mt-4">
                                <p><strong>Um Registro Incluído com Sucesso.</strong></p>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->
</asp:Content>

