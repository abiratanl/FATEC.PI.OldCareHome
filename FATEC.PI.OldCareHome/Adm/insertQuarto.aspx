<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="insertQuarto.aspx.cs" Inherits="Adm_insertQuarto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="text-right mr-3">
        <asp:Label ID="lblUsuario"  runat="server" Text="Usuário:"></asp:Label>            
        <asp:Label ID="lblSessao" CssClass="text-primary font-weight-bold" runat="server" Text="---"></asp:Label>
    </div>
     <div class="card card-primary">
                            <div class="card-header bg-primary text-white">
                                <h3 class="card-title " >Cadastramento de Quartos</h3>
                            </div>
                            <!-- /.card-header -->
                            <!-- form start -->

                            <div class="card-body">
                                <div class="form-group" >
                                    <label for="txtInsertQuartoDescricao">Descrição:</label>
                                    <asp:TextBox ID="txtInsertQuartoDescricao" type="text" required="required" class="form-control" placeholder="Digite Descrição do quarto" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <label for="txtInsertQuartoTipo">Tipo:</label>
                                    <asp:TextBox ID="txtInsertQuartoTipo" type="text" required="required" class="form-control" placeholder="Digite tipo" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtInsertQuartoCapacidade">Capacidade:</label>
                                     <asp:TextBox ID="txtInsertQuartoCapacidade" type="text" Width="50%" required="required" class="form-control" placeholder="Digite capacidade" runat="server"></asp:TextBox>
                                </div>                               
                            </div>
                            <!-- /.card-body -->

                            <div class="card-footer text-right">
                                <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        <%--<form class="form-inline">--%>                            
                            <asp:LinkButton ID="btnInsertQuartoVoltar" CssClass="text-center mx-3" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;" OnClick="btnInsertQuartoVoltar_Click">
                                <asp:Image ID="Image1" runat="server" Width="48px" ImageUrl="~/img/back.png" BackColor="Transparent" />
                                <br />
                                <asp:Label ID="Label5" runat="server" Text="Voltar"></asp:Label>
                            </asp:LinkButton>
                            <asp:LinkButton ID="btnInsertQuartoCadastrar" CssClass="text-center mx-3" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;" OnClick="btnInsertQuartoCadastrar_Click" >
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

