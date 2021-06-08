<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/myStyle.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
        <!-- Main content -->
        <section class="content mt-4 grad">
            <div class="container mt-5">
                <div class="row mt-3">
                    <div class="col-12 col-sm-6 mb-5">
                        <asp:Image ID="imgLogin" ImageUrl="~/img/hand.png" CssClass="img-fluid rounded" runat="server" />
                    </div>
                    <div class="col-12 col-sm-6">
                        <!-- general form elements -->
                        <div class="card card-primary mt-5 bgCinza">
                            <div class="card-header bg-primary">
                                <h3 class="card-title">OldCareHome - Controle de Acesso</h3>
                            </div>
                            <!-- /.card-header -->
                            <div class="card-body mt-3">
                                <div class="form-group">
                                    <label for="exampleInputEmail1"><strong>Email</strong></label>
                                    <asp:TextBox ID="txtEmail" required="required" type="email" runat="server" placeholder="Digite email cadastrado" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group mt-3">
                                    <label for="exampleInputPassword1"><strong>Senha</strong></label>
                                    <asp:TextBox ID="txtSenha" required="required" type="password" runat="server" placeholder="Digite sua senha" CssClass="form-control mb-4"></asp:TextBox>
                                </div>
                                <div class="form-group mt-2 text-right">
                                    <asp:LinkButton ID="btnEsqueciSenha" runat="server">Esqueci minha senha</asp:LinkButton>
                                </div>
                            </div>
                            <!-- /.card-body -->

                            <div class="card-footer text-right">
                                <asp:Button ID="btnCancelar" CssClass="btn btn-secondary font-weight-bold mr-5" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                                <asp:Button ID="btnEntrar" CssClass="btn btn-primary font-weight-bold" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />

                            </div>
                        </div>
                        <!-- /.card -->
                    </div>
                </div>
            </div>
        </section>
        <!-- /.content -->

        <!-- Modal erro login-->
        <div class="modal fade " id="modalErroLogin" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="title">Acesso ao Sistema</h5>
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
                                <p><strong>Email ou senha não confere!</strong></p>
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
        <!-- Modal -->
        <div class="modal fade " id="modalCancelarLogin" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title  text-center" id="ModalLabel">Redirecionamento</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-danger  text-center">
                        <p><strong>Volta para Home pública quando for implementado</strong></p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->
        <script src="Scripts/jquery-3.5.1.min.js"></script>        
        <script src="Scripts/bootstrap.bundle.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
