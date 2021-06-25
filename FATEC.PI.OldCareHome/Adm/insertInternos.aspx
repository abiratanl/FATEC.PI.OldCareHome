<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/Master.master" AutoEventWireup="true" CodeFile="insertInternos.aspx.cs" Inherits="Adm_insertInternos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="card card-primary" id="modalCadastramentoInternos">
            <!-- card-header -->
            <div class="card-header bg-primary text-white p-0 ">
                    <div class="mx-3"> 
                        <div class="bg-primary text-white">
                            <asp:Label ID="lblTitle" CssClass="h4" runat="server" Text="Cadastro de Internos - Inclusão"></asp:Label>
                        </div>
                    </div>
                </div>
            <!-- /.card-header -->
            <!-- form start -->
            <div class="card-body">
                <div class="row">
                    <!-- card-body -->
                    <div class="col-12 col-md-4">
                        <div class="form-group">
                            <label for="txtNome">Nome:</label>
                            <label class="text-danger" for=""><strong>*</strong></label>  
                            <asp:TextBox ID="txtNome" Required="required" CssClass="form-control" PlaceHolder="Nome do interno" runat="server"></asp:TextBox>
                        </div>
                        
                        <div class="row">
                            <div class="col-6">
                                <div >
                                    <asp:Label ID="lblSituacao" runat="server" Text="Situação:"></asp:Label>
                                    <label class="text-danger" for=""><strong>*</strong></label>  
                                    <br />
                                    <asp:DropDownList ID="ddlSituacao" CssClass="form-control" Width="100%" runat="server">
                                        <asp:ListItem>Ativo</asp:ListItem>
                                        <asp:ListItem>Hospitalizado</asp:ListItem>
                                        <asp:ListItem>Retirado</asp:ListItem>
                                        <asp:ListItem>Falecido</asp:ListItem>
                                        <asp:ListItem>Saída Temporária</asp:ListItem>
                                    </asp:DropDownList>
                                    <div class="mt-2">
                                        <asp:Label ID="lblDataSituacao" runat="server" Text="Data da Situação:"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtDataSituacao" Type="Date" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="mt-4 px-2">
                                    <asp:Label ID="lblSexo" runat="server" Text="Sexo:"></asp:Label>
                                    <br />
                                    <div>
                                        <asp:RadioButtonList ID="rbtnSexo" RepeatDirection="Vertical" runat="server" OnSelectedIndexChanged="rbtnSexo_SelectedIndexChanged">
                                            <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                                            <asp:ListItem Value="F">Feminino</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group mt-2">
                            <label for="txtProfissao">Profissão:</label>
                            <asp:TextBox ID="txtProfissao" CssClass="form-control"  runat="server"></asp:TextBox>
                                                 
                           
                        </div>
                        <div class="form-group mt-1">
                            <label  for="ddlQuarto">Quarto que ocupa: </label> 
                            <label class="text-danger" for=""><strong>*</strong></label>                             
                            <asp:DropDownList ID="ddlQuarto" CssClass="form-control" Width="100%" runat="server">                                
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-12 col-md-4">
                        <div class="form-group">
                            <label for="txtPai">Pai:</label>
                            <asp:TextBox ID="txtPai" CssClass="form-control" PlaceHolder="Nome do pai" runat="server"></asp:TextBox>
                        </div>
                        <div class="row">
                            <div class="col-6">
                                <div>
                                    <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtDataNascimento" Type="Date" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                
                            </div>
                            <div class="col-6">
                                <div>
                                    <asp:Label ID="lblDataEntrada" runat="server" Text="Data de Entrada:"></asp:Label>
                                    <label class="text-danger" for=""><strong>*</strong></label>  
                                    <br />
                                    <asp:TextBox ID="txtDataEntrada" Type="Date" required="required" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                                </div>                                
                            </div>
                        </div>
                        <div class="mt-2">
                                    <label for="ddlMobilidade">Mobilidade:</label>
                                    <asp:DropDownList ID="ddlMobilidade" CssClass="form-control" runat="server">
                                        <asp:ListItem>Ativo</asp:ListItem>
                                        <asp:ListItem>Andador</asp:ListItem>
                                        <asp:ListItem>Bengala</asp:ListItem>
                                        <asp:ListItem>Cadeirante</asp:ListItem>
                                        <asp:ListItem>Acamado</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                        <div class="form-group">
                            <label for="txtEscolaridade">Escolaridade:</label>
                            <asp:DropDownList ID="ddlEscolaridade" CssClass="form-control" Width="100%" runat="server">
                                <asp:ListItem>Fundamental Completo</asp:ListItem>
                                <asp:ListItem>Fundamental Completo</asp:ListItem>
                                <asp:ListItem>Fundamental Incompleto</asp:ListItem>
                                <asp:ListItem>Básico Completo</asp:ListItem>
                                <asp:ListItem>Básico Incompleto</asp:ListItem>
                                <asp:ListItem>Superior</asp:ListItem>
                                <asp:ListItem>Pós-graduação</asp:ListItem>
                                <asp:ListItem>Mestrado</asp:ListItem>
                                <asp:ListItem>Doutorado</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="txtNaturalidade">Naturalidade:</label>
                            <asp:TextBox ID="txtNaturalidade" CssClass="form-control"  runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-12 col-md-4">
                        <div class="form-group">
                            <label for="txtMae">Mãe:</label>
                            <asp:TextBox ID="txtMae" CssClass="form-control" PlaceHolder="Nome da mãe" runat="server"></asp:TextBox>
                        </div>
                        <div class="row">
                            <div class="col-6">
                                <div>
                                    <asp:Label ID="lblEstadoCivil" runat="server" Text="Estado Civil:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtEstadoCivil" Type="Text" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <label for="txtRg">RG:</label>
                                    <asp:TextBox ID="txtRg" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-6">
                                <div>
                                    <asp:Label ID="lblCpf" runat="server" Text="CPF:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtCpf" Type="Text" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-2">
                                    <label for="txtTitulo">Título de Eleitor:</label>
                                    <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtInss">Benefício INSS:</label>
                            <asp:TextBox ID="txtInss" CssClass="form-control"  runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtPlanoSaude">Plano de Saúde:</label>
                            <asp:TextBox ID="txtPlanoSaude" CssClass="form-control"  runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.card-body -->
            <!-- card-footer -->
            <div class="card-footer text-right">
                <asp:LinkButton ID="btnCancelar" CssClass="btn btn-secondary mr-3" Text="Cancelar" runat="server" OnClick="btnCancelar_Click"></asp:LinkButton>
                <asp:LinkButton ID="btnCadastrar" CssClass="btn btn-primary mx-3" runat="server" OnClick="btnCadastrar_Click"><strong>Cadastrar Interno</strong></asp:LinkButton>
            </div>
        </div>        
        <!-- /.card -->
    </div>
     <!-- Modal Insert OK-->
                 <div class="modal fade " id="modalInsertOk" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
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
                                <asp:Image ID="Image4" class="img-80-80" ImageUrl="~/img/success.jpeg" runat="server" />
                            </div>
                            <div class="col-9 mt-4">
                                <asp:Literal ID="ltlMensagem" Text="<strong>Um Registro Incluído com Sucesso!</strong>" runat="server"></asp:Literal>                                
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton ID="btnFecharModal" CssClass="btn btn-primary" runat="server" OnClick="btnFecharModal_Click">Fechar</asp:LinkButton>
                       
                    </div>
                </div>
            </div>
        </div>
                 <!-- /.modal -->
</asp:Content>

