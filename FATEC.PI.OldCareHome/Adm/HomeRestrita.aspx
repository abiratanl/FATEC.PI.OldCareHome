<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="HomeRestrita.aspx.cs" Inherits="Adm_HomeRestrita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="text-right">
            <asp:Literal ID="ltlUsuarioLogado" runat="server">Usuário:</asp:Literal>
            <asp:Label ID="lblSessao" CssClass="text-primary font-weight-bold" runat="server" Text="---"></asp:Label>
        </div>
        <div>
            <div>
                <asp:Panel ID="Panel1" CssClass="bg-secundary" runat="server">
                         <!-- Card -->
                        <div class="card mt-5 ">
                            <div class="card-header bg-primary text-white">
                                <h3 class="card-title">OldCareHome - Cadastro de Internos</h3>
                            </div>                            
                            <!-- /.card-body -->
                            <div class="card-body mt-3">
                                <div class="form-group">
                                    <asp:GridView ID="gridMain" runat="server" BackColor="Silver" HorizontalAlign="Center" Width="364px">
                                        <HeaderStyle BackColor="#0066FF" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#0000CC" />
                                    </asp:GridView>   
                                </div>
                                <div>
                                    
                                </div>
                                
                            </div>
                            <!-- /.card-body -->
                            <div class="card-footer text-right">
                                <asp:Panel ID="panBotoes" runat="server" CssClass="btn-group text-right" role="group">
                                    <div class="container ">
                                        <div class="row text-right" >
                                            <div class="m-2 text-center">
                                                <asp:LinkButton ID="btnAdicionar" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;"  onMouseOut="window.status='Menu ready'; return true;" OnClick="btnAdicionar_Click">
                                                   <asp:Image ID="Image1" runat="server" ImageUrl="~/img/ico32/add-blue-32.jpg" BackColor="Transparent" />
                                                    <br />
                                                    <asp:Label ID="Label5" runat="server"  Text="Adicionar"></asp:Label>
                                                </asp:LinkButton>                                               
                                            </div>
                                            <div class="m-2 text-center">
                                                <asp:LinkButton ID="btnEditar" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;"  onMouseOut="window.status='Menu ready'; return true;">
                                                   <asp:Image ID="Image2" runat="server" ImageUrl="~/img/ico32/edit-orange-32.jpg" BackColor="Transparent" />
                                                    <br />
                                                    <asp:Label ID="Label1" runat="server" Text="Editar"></asp:Label>
                                                </asp:LinkButton>                                                
                                            </div>
                                            <div class="m-2 text-center">
                                                <asp:LinkButton ID="btnExcluir" runat="server" Width="100%" onMouseOver="window.status='New Panel'; return true;"  onMouseOut="window.status='Menu ready'; return true;">
                                                   <asp:Image ID="Image3" runat="server" ImageUrl="~/img/ico32/delete-red-32.jpg" BackColor="Transparent" />
                                                    <br />
                                                    <asp:Label ID="Label2" runat="server" Text="Excluir"></asp:Label>
                                                </asp:LinkButton>                                               
                                            </div>
                                        </div> 
                                    </div>                                         
                                </asp:Panel>
                            </div>
                        </div>
                        <!-- /.card -->
                </asp:Panel>                 
            </div>
        </div>
    </div>
    <!-- Modal -->
        <div class="modal fade modal-md" id="modalUsuarios" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="title">Cadastro de Usuários</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-danger  text-center">
                        <div class="row">
                            <div class="col-12">
                                <div class="form-group mt-3 text-left"> 
                                    <div class="cemPorCento mt-2">
                                        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtNome" width="100%" runat="server"></asp:TextBox>
                                    </div>                                    
                                    <div class="cemPorCento mt-2">
                                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtEmail" width="100%" runat="server"></asp:TextBox>
                                    </div >  
                                    <div class="cemPorCento mt-2">
                                        <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtSenha" width="100%" Type="password" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="cemPorCento mt-2">  
                                        <asp:Label ID="Label7" runat="server" Text="Perfil"></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="ddlPerfil" width="100%" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="col-12 mt-4">
                                <%--<p><strong>Email ou senha não confere!</strong></p>--%>
                            </div>
                        </div>
                        
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="btnSalvar" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->
</asp:Content>

