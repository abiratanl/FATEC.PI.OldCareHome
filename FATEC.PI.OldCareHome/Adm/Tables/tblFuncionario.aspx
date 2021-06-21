<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="tblFuncionario.aspx.cs" Inherits="Adm_Tables_Patologia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <div class="card mt-1 ">
                <div class="card-header bg-primary text-white p-0">
                    <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text=""></asp:Label>
                </div>
                <!-- card-body -->
                <div class="card-body mt-3">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-12 col-md-6">
                                <asp:Label ID="lblCódigo" runat="server" Text="Código"></asp:Label>
                                <asp:DropDownList ID="ddlIdFuncionario" CssClass="form-control" runat="server"></asp:DropDownList>

                            </div>
                            <div class="col-6">
                                <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
                                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-12 col-md-3">
                                <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento:"></asp:Label>
                                <asp:TextBox ID="txtDataNascimento" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="lblSituacao" runat="server" Text="Situação:"></asp:Label>
                                <asp:TextBox ID="txtSituacao" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-12 col-md-3">
                                <asp:Label ID="lblDataAdmissao" runat="server" Text="Data de Admissão"></asp:Label>
                                <asp:TextBox ID="txtDataAdmissao" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="ltlDataSituacao" runat="server" Text="Data da Situação:"></asp:Label>
                                <asp:TextBox ID="txtDataSituacao" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-12 col-md-3">
                                <asp:Label ID="Label6" runat="server" Text="Sexo:"></asp:Label>
                                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-12 col-md-3">
                                <asp:Label ID="Label8" runat="server" Text="Salário:"></asp:Label>
                                <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-12 col-md-3">
                                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                           
                        </div>
                    </div>


                </div>
            </div>

            <!-- Tabela
                        <table id="tblMain" class="display" style="width: 100%">
                            <thead class="bg-primary text-white">
                                <tr>
                                    <th>Código</th>
                                    <th>Nome</th>
                                    <th>Data de Admissão</th>                                    
                                    <th>Situação</th>   
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTableBody" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Código")%></td>
                                            <td><%#Eval("Nome")%></td>                                           
                                            <td><%#Eval("Admissão")%></td>
                                            <td><%#Eval("Situação")%></td>
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

