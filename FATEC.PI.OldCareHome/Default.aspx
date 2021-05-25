<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- HTML Gatilho modal -->
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlLogin">
                Entrar
            </button>
            <asp:Button ID="btnEntrar" runat="server" CssClass="btn btn-success" Text="Entrar" OnClick="btnEntrar_Click" />
        </div>
        <!-- Modal -->
        <div class="modal fade modal-lg" id="mdlLogin" tabindex="-1" aria-labelledby="exampleModalLabel"
            aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title text-center" id="exampleModalLabel">Controle de Acesso</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col-12">
                                </div>
                                <div class="col-6">
                                    <asp:Image ID="Image1" runat="server" />
                                    <span>Imagem</span>
                                    <span>Teste de Modal</span>
                                </div>
                                <div class="col-6">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                                    <asp:TextBox ID="txtEmail" type="email" CssClass="form-control mb-3" runat="server"  required="required"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="lblSenha" runat="server"  required="required" Text="Senha:"></asp:Label>
                                    <asp:TextBox ID="txtSenha" runat="server"  type="password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Text="Login" OnClick="btnLogin_Click"/>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                        <button type="button" class="btn btn-primary">Save changes</button>
                    </div>
                </div>
            </div>
        </div>        
    </form>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
