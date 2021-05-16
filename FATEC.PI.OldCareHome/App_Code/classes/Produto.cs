using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Produto
/// </summary>
public class Produto{
    private int pro_codigo;
    private string pro_nome;
    private DateTime pro_datacadastro;
    private string pro_imagem;
    private Usuario usu_codigo;
    private Categoria cat_codigo;

    public int Pro_codigo { get => pro_codigo; set => pro_codigo = value; }
    public string Pro_nome { get => pro_nome; set => pro_nome = value; }
    public DateTime Pro_datacadastro { get => pro_datacadastro; set => pro_datacadastro = value; }
    public string Pro_imagem { get => pro_imagem; set => pro_imagem = value; }
    public global::Usuario Usu_codigo { get => usu_codigo; set => usu_codigo = value; }
    public global::Categoria Cat_codigo { get => cat_codigo; set => cat_codigo = value; }
}