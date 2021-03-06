<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="HomeTabelas.aspx.cs" Inherits="Adm_HomeTabelas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <div class="card mt-1 ">
                <div class="card-header bg-primary text-white p-0">
                    <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Cadastro de Usuários"></asp:Label>
                </div>
                <!-- card-body -->
                <div class="card-body mt-3">
                    <div class="form-group">
                        <!-- Tabela -->
                        <table id="tblMain" class="display" style="width: 100%">
                            <thead class="bg-primary text-white">
                                <tr>
                                    <th>Editar</th>
                                    <th>Excluir</th>
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
                                            <td>
                                                <asp:LinkButton ID="btnRptEditar" CssClass="text-center mx-2" runat="server"  onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                                                    <br />
                                                   <%-- <asp:Label ID="lblEditar" runat="server" Text="Editar"></asp:Label>--%>
                                                </asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="btnRptExcluir" CssClass="text-center mx-2" runat="server"  onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                                                    <br />
                                                   <%-- <asp:Label ID="lblExcluir" runat="server" Text="Excluir"></asp:Label>--%>
                                                </asp:LinkButton>
                                            </td>
                                            <td><%#Eval("Nome")%></td>
                                            <td><%#Eval("Email")%></td>
                                            <td><%#Eval("Data de Cadastro")%></td>
                                            <td><%#Eval("Perfil")%></td>
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
                    <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        <%--<form class="form-inline">--%>
                        <asp:LinkButton ID="btnAdicionar" CssClass="text-center mx-2" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/ico32/add-blue-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Adicionar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnEditar" CssClass="text-center mx-2" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="lblEditar" runat="server" Text="Editar"></asp:Label>
                        </asp:LinkButton>
                        <asp:LinkButton ID="btnExcluir" CssClass="text-center mx-2" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                            <br />
                            <asp:Label ID="lblExcluir" runat="server" Text="Excluir"></asp:Label>
                        </asp:LinkButton>
                        <%--</form>--%>
                    </asp:Panel>
                </div>
                <!--./ card-footer -->
            </div>
            <!-- /.card -->
        </div>
    </div>
</asp:Content>

