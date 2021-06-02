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
        <section class="content mt-4 grad" >
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
                                <asp:Button ID="btnCancelar" CssClass="mr-5" runat="server" Text="Cancelar" Onclick="btnCancelar_Click"/>
                                <asp:Button ID="btnEntrar" Cssclass="btn btn-primary" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
                                
                            </div>
                        </div>
                        <!-- /.card -->
                    </div>                   
                 </div>
              </div>        
        </section>
        <!-- /.content -->

        <!-- modal -->


        <!-- /.modal -->
    </form>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
