<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="tblInternos.aspx.cs" Inherits="Adm_Tables_Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <div class="card mt-1 ">
                <div class="card-header bg-primary text-white p-0">
                    <div class="mx-3">
                        <div class="row">
                            <div class="col-1 bg-primary text-right ">
                                <asp:LinkButton ID="btnAdicionar" runat="server" data-toggle="tooltip" data-placement="top" title="Incluir um usuário" OnClick="btnAdicionar_Click" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/img/ico24/add-blue-24.jpg" BackColor="Transparent" />
                                </asp:LinkButton>
                            </div>
                            <div class="col-11 bg-primary text-white">
                                <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Cadastro de Internos"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- card-body -->
                <div class="card-body mt-3">
                    <div class="form-group">
                        <!-- Tabela -->
                        <table id="tblMain" class="display" style="width: 100%">
                            <thead class="bg-primary text-white">
                                <tr>
                                    <th>Código</th>
                                    <th>Nome</th>
                                    <th>Sexo</th>
                                    <th>Entrada</th>
                                    <th>Situação</th>
                                    <th>Plano de Saúde</th>
                                    <th>Mobilidade</th>
                                    <th>Editar</th>
                                    <th>Excluir</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody"  runat="server">
                                    <ItemTemplate>
                                        <tr>                                                                                     
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Código")%>'></asp:Label>

                                            </td>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Nome")%>'></asp:Label>
                                            </td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Sexo")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Data de Entrada")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Situação")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Plano de Saúde")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Mobilidade")%></td>
                                            <td>
                                                <asp:LinkButton ID="btnRptEditar" CommandName="Editar" CommandArgument='<%#Eval("Código")%>' runat="server" OnClick="btnRptEditar_Click" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                                                </asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="btnRptExcluir" CommandName="Excluir" CommandArgument='<%#Eval("Código")%>' runat="server" OnClick="btnRptExcluir_Click" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                                                </asp:LinkButton>
                                            </td>  
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <tbody>
                        </table>
                        <!--  ./ Tabela -->
                    </div>
                </div>
                <!-- /.card-body -->
                <!-- card-footer -->
                <div class="card-footer ">
                    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
                </div>
                <!--./ card-footer -->
            </div>
            <!-- /.card -->
            <div class="text-right">
                <asp:Label ID="lblUsuario" CssClass="mr-1" runat="server" Text="Usuário:"></asp:Label>
                <asp:Label ID="lblSessao" runat="server" CssClass="text-primary mr-2" Text=""></asp:Label>
            </div>
        </div>
    </div>
     
    
    <!-- .modal Delete-->
    <div class="modal fade modal-md" id="modalDelete" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header bg-primary">
                    <h5 class="modal-title  text-center" id="title2">Confirmação de Exclusão</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body text-danger  mx-5">
                    <div class="row">                        
                        <div>
                            <p><strong>Deseja excluir o registro?</strong></p>

                            <div class="text-left text-dark">
                                <asp:Literal ID="ltlExcluir" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="btnDelete" type="button" class="btn btn-danger" runat="server" Text="Excluir" OnClick="btnDelete_Click" />
                </div>
            </div>
        </div>
    </div>
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
</asp:Content>
