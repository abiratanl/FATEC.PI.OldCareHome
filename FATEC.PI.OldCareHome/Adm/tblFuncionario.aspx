<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="tblFuncionario.aspx.cs" Inherits="Adm_Tables_Patologia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Cadastro de Funcionários"></asp:Label>
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
                                    <th>Data de Admissão</th> 
                                    <th>Data de Nascimento</th> 
                                     <th>Sexo</th> 
                                    <th>Situação</th>   
                                    <th>Salário</th>   
                                    <th>Editar</th>
                                    <th>Excluir</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Código")%></td>
                                            <td><%#Eval("Nome")%></td>                                           
                                            <td><%#Eval("Data de Admissão")%></td>
                                            <td><%#Eval("Data de Nascimento")%></td>
                                            <td><%#Eval("Sexo")%></td>
                                            <td><%#Eval("Situação")%></td>
                                            <td><%#Eval("Salário")%></td>
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
                    <%--<asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        
                        <asp:LinkButton ID="btnAdicionar" CssClass="text-center mx-2" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/ico32/add-blue-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Adicionar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnEditar" CssClass="text-center mx-2"  runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="lblEditar" runat="server" Text="Editar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnExcluir" CssClass="text-center mx-2"  runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="lblExcluir" runat="server" Text="Excluir"></asp:Label>
                        </asp:LinkButton>
                       
                    </asp:Panel>--%>
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
</asp:Content>

