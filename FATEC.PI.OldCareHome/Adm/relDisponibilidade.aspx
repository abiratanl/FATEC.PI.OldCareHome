<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="relDisponibilidade.aspx.cs" Inherits="Adm_Tables_Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <div class="card mt-1 ">
                <div class="card-header bg-primary text-white p-0">
                    <div class="ml-3">
                       <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Relatório de Disponibilidade"></asp:Label>
                    </div>
                </div> 
                <!-- card-body -->
                <div class="card-body mt-3">
                    <div class="form-group ml-5">
                        <!-- Tabela -->
                        <div class="text-center ml-5 pl-5">
                            <table id="tblMain2" class="display text-center" style="width: 70%">
                            <thead class="bg-primary text-white">
                                <tr >
                                    <th>Capacidade</th>
                                    <th>Ocupação</th>
                                    <th>Disponível</th>
                                    <th>Sexo</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody"  runat="server">
                                    <ItemTemplate >
                                        <tr>       
                                            <td><%#DataBinder.Eval(Container.DataItem, "Capacidade")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Ocupação")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Disponível")%></td>
                                            <td><%#DataBinder.Eval(Container.DataItem, "Sexo")%></td>                                               
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <tbody>
                        </table>
                        </div>
                        <!--  ./ Tabela -->
                    </div>
                </div>
                <!-- /.card-body -->
                <!-- card-footer -->
                <div class="card-footer text-right ">
                    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>  
                    <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                        <div class="text-right mr-5">
                            <asp:LinkButton ID="btnVoltar" CssClass="text-center mx-2" runat="server" Width="100%" OnClick="btnVoltar_Click" onMouseOver="window.status='New Panel'; return true;" onMouseOut="window.status='Menu ready'; return true;">
                            <asp:Image ID="Image1" runat="server" Width="80" ImageUrl="../img/voltar2.gif" BackColor="Transparent" />
                           
                           
                            </asp:LinkButton>  
                        </div> 
                        </asp:Panel>
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
