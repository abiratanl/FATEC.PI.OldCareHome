<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="HomeRestrita.aspx.cs" Inherits="Adm_HomeRestrita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .container-fluid {
            margin-top: 34px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-6 text-left">
               
            </div>           
            <div class="col-6 text-right">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuário:"></asp:Label>
                <asp:Label ID="lblSessao" CssClass="text-primary font-weight-bold" runat="server" Text="---"></asp:Label>
            </div>
        </div>
        <asp:Panel ID="pnlCard" CssClass="bg-secundary" runat="server">

            <!-- Card -->
            <div class="card mt-1 ">
                <div class="card-header bg-primary text-white p-0">
                     <asp:DropDownList Width="100%" ID="ddlTabelas" AutoPostBack="true" runat="server" CssClass="m-0 px-3 form-control bg-Cinza" OnSelectedIndexChanged="ddlTabelas_SelectedIndexChanged" Font-Bold="True" Font-Size="X-Large" ForeColor="White" BackColor="#0066FF"></asp:DropDownList>
                    <%--<asp:Label ID="lblTitle" CssClass="h4" runat="server" Text=""></asp:Label>--%>
                </div>
                <!-- card-body -->
                <div class="card-body mt-3">
                    <div class="form-group">

                        <asp:GridView ID="gridMain" runat="server" CellPadding="4" CssClass="display table table-striped thead-dark" ForeColor="#333333" GridLines="None" Width="100%" AllowSorting="True">
                            
                            <Columns>
                                <asp:ButtonField ButtonType="Image" FooterText="Editar" ImageUrl="~/img/ico24/edit-orange-24.jpg" Text="btnEditar" HeaderText="Editar" ShowHeader="True" />
                                <asp:ButtonField ButtonType="Image" ImageUrl="~/img/ico24/delete-red-24.jpg" Text="btnDelete" HeaderText="Excluir" />
                            </Columns>

                        </asp:GridView>



                        <!-- Tabela
                        <table id="tblMain" class="display" style="width: 100%">
                            <thead class="bg-primary text-white">
                                <tr>
                                    <th>Nome</th>
                                    <th>Email</th>                                    
                                    <th>Nascimento</th>
                                    <th>Perfil</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Nome")%></td>
                                            <td><%#Eval("Email")%></td>                                           
                                            <td><%#Eval("Data de Cadastro")%></td>
                                            <td><%#Eval("Perfil")%></td>
                                             
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <tbody>
                        </table>
                        ./ Tabela -->
                    </div>
                </div>
                <!-- /.card-body -->
                <!-- card-footer -->
                <div class="card-footer text-right">
                    <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        <%--<form class="form-inline">--%>
                        <asp:LinkButton ID="btnAdicionar" CssClass="text-center mx-2" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;" OnClick="btnAdicionar_Click">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/ico32/add-blue-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Adicionar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnEditar" CssClass="text-center mx-2" OnClick="btnEditar_Click" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Editar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnExcluir" CssClass="text-center mx-2"  runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Excluir"></asp:Label>
                        </asp:LinkButton>
                        <%--</form>--%>
                    </asp:Panel>
                </div>
                <!--./ card-footer -->
            </div>
            <!-- /.card -->
        </asp:Panel>
        <!-- Modal Cadastrar Usuarios-->
        <div class="modal fade modal-md" id="modalInsertUsuario" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="title">Cadastro de Usuários</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body ">
                        <div class="row">
                            <div class="col-12">
                                <div class="cemPorCento mt-2">
                                    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtUsuarioNome" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtUsuarioEmail" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtUsuarioSenha" CssClass="form-control" Required="Required" Width="100%" Type="password" runat="server"></asp:TextBox>
                                </div>
                                <div class="row">
                                    <div class="col-6 mt-2">
                                        <asp:Label ID="lblDataCadastro" runat="server" Text="Data de Cadastro:"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtUsuarioDataCadastro" Type="Date" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6 mt-2">
                                        <asp:Label ID="Label7" runat="server" Text="Perfil"></asp:Label>
                                        <br />

                                        <asp:DropDownList ID="ddlPerfil" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="btnSalvarUsuario" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvarUsuario_Click" />
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal Cadastrar usuários-->
        <!-- Modal Cadastrar Patologia-->
        <div class="modal fade modal-md" id="modalPatologia" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="">Cadastro de Patologias</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-left">
                        <div class="row">
                            <div class="col-12">
                                <div class="cemPorCento mt-2">
                                    <asp:Label ID="lblPatologia" runat="server" Text="Patologia:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPatologia" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblRestricao" runat="server" Text="Restrição:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtRestricao" Width="100%" Type="text" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblCid" runat="server" Text="CID:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtCid" Width="50%" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <asp:LinkButton ID="btnSalvarPatologia" type="btn-button" CssClass="btn btn-primary" runat="server" OnClick="btnSalvarPatologia_Click">Cadastrar</asp:LinkButton>

                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal Cadastrar Patologias-->
        <!-- Modal Cadastrar Quarto-->
        <div class="modal fade modal-md" id="modalInsertQuarto" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="">Cadastro de Quartos</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-center">
                        <div class="row">
                            <div class="col-12">
                                <div class="cemPorCento mt-2">
                                    <asp:Label ID="lblQuartoDescricao" runat="server" Text="Descrição:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtQuartoDescricao" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblCapacidade" runat="server" Text="Capacidade:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtQuartoCapacidade" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="lblQuartoTipo" runat="server" Text="Tipo:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtQuartoTipo" Width="100%" Type="text" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="btnInsertQuarto" class="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnInsertQuarto_Click" />
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal Cadastrar Patologias-->


        <!-- Modal erro Banco de Dados-->
        <div class="modal fade " id="modalErroBanco" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="">Acesso ao Banco</h5>
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
                                <asp:Literal ID="ltlMensagem" runat="server" Text="<strong>Ocorreu um erro ao acessar o banco de dados. Verifique a conexão e tente novamente.</strong>"></asp:Literal>
                                
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
         <!-- Modal Editar Usuarios-->
        <div class="modal fade modal-md" id="modalEditUsuario" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="titleEdit">Cadastro de Usuários</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-center">
                        <div class="row">
                            <div class="col-12">
                                <div class="cemPorCento mt-2">
                                    <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtEditNome" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtEditEmail" Type="email" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <asp:Label ID="Label6" runat="server" Text="Senha:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtEditSenha" CssClass="form-control" Required="Required" Width="100%" Type="password" runat="server"></asp:TextBox>
                                </div>
                                <div class="row">
                                    <div class="col-6 mt-2">
                                        <asp:Label ID="Label8" runat="server" Text="Data de Cadastro:"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtEditDataCadastro" Type="Date" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6 mt-2">
                                        <asp:Label ID="Label9" runat="server" Text="Perfil"></asp:Label>
                                        <br />

                                        <asp:DropDownList ID="ddlEditUsuarioPerfil" CssClass="form-control" Required="Required" Width="100%" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvarUsuario_Click" />
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal Cadastrar usuários-->



    </div>
</asp:Content>

