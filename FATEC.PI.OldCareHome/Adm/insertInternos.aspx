<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/adm.master" AutoEventWireup="true" CodeFile="insertInternos.aspx.cs" Inherits="Adm_insertInternos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
         <div class="card card-primary" id="modalCadastramentoInternos">
                            <div class="card-header">
                                <h3 class="card-title">Cadastramento de Internos</h3>
                            </div>
                            <!-- /.card-header -->
                            <!-- form start -->
                            <div class="row">
                                <div class="col-12 col-md-6">
                                    <div class="card-body">
                                    <div class="form-group">
                                        <label for="txtNomeUsuario">Nome:</label>
                                        <input type="text" class="form-control" required="required" id="txtNomeUsuario" placeholder="Ensira nome">
                                    </div>
                                    
                                    <div class="form-group">
                                        <label for="exampleInputFile">File input</label>
                                        <div class="input-group">
                                            <div class="custom-file">
                                                <input type="file" class="custom-file-input" id="exampleInputFile">
                                                <label class="custom-file-label" for="exampleInputFile">Choose file</label>
                                            </div>
                                            <div class="input-group-append">
                                                <span class="input-group-text">Upload</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-check">
                                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                                        <label class="form-check-label" for="exampleCheck1">Check me out</label>
                                    </div>
                                </div>
                                    <!-- /.card-body -->
                                </div>
                                <div class="col-12 col-md-6">
                                    <div class="form-group">
                                        <label for="txtPaiUsuario">Pai:</label>
                                        <input type="text" class="form-control" required="required" id="txtPaiUsuario" placeholder="Nome do Pai">
                                    </div>
                                    <div class="form-group">
                                        <label for="txtMaeUsuario">Mãe:</label>
                                        <input type="text" class="form-control" required="required" id="txtMaeUsuario" placeholder="Nome da Mãe">
                                    </div>
                                </div>
                            </div>
                            <div class="card-footer text-right">
                                <button type="submit" class="btn btn-primary">Cadastrar</button>
                            </div>

                        </div>
                        <!-- /.card -->
    </div>
</asp:Content>

