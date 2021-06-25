<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="tblQuarto.aspx.cs" Inherits="Adm_HomeTabelas" %>

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
                                <asp:LinkButton ID="btnIncluirUsuario" runat="server" data-toggle="tooltip" data-placement="top" title="Incluir um usuário" OnClick="btnIncluirUsuario_Click" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/img/ico24/add-blue-24.jpg" BackColor="Transparent" />
                                </asp:LinkButton>
                            </div>
                            <div class="col-11 bg-primary text-white">
                                <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Cadastro de Produtos"></asp:Label>
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
                                    <th>Descrição</th>
                                    <th>Capacidade</th>
                                    <th>Sexo</th>
                                    <th>Editar</th>
                                    <th>Excluir</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Código")%></td>
                                            <td><%#Eval("Descrição")%></td>
                                            <td><%#Eval("Capacidade")%></td>
                                            <td><%#Eval("Gênero")%></td>
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
                <div class="card-footer text-right">
                </div>
                <!--./ card-footer -->
            </div>
            <!-- /.card -->
            <asp:Label ID="lblUsuario" CssClass="mr-1" runat="server" Text="Usuário:"></asp:Label>
            <asp:Label ID="lblSessao" runat="server" CssClass="text-primary mr-2" Text=""></asp:Label>
        </div>
    </div>
    <!-- Modal UpDate -->
    <div class="modal fade modal-md" id="modalUpdate" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header bg-primary">
                    <h5 class="modal-title  text-center" id="title3">Cadastro de Usuários - Atualização</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body ">
                    <div class="row px-4" >
                        <div class="col-12">
                            <div class="cemPorCento mt-2">
                                <asp:Label ID="lblUpdateNome" runat="server" Text="Descrição"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtDescricao" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                            </div>
                            <div class="row">
                                <div class="col-6">
                                    <div class="mt-4 ">
                                        <asp:Label ID="lblUpdateEmail" runat="server" Text="Capacidade:"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtCapacidade" Type="number" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="mt-2">
                                    <div class="mt-3 ">
                                        <asp:Label ID="Label2" runat="server" Text="Sexo:"></asp:Label>
                                        <br />
                                        <div>
                                            <asp:RadioButtonList ID="rbtnSexo" RepeatDirection="Vertical" runat="server">
                                                <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                                                <asp:ListItem Value="F">Feminino</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <div class="mr-2 pr-2">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                    
                    <div class="pl-2 mr-5">
                        <asp:Button ID="btnUpdate" type="button" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnUpdate_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /.modal UpDate usuários-->  
</asp:Content>

