using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    private int usu_codigo;
    private string usu_nome;
    private string usu_email;
    private string usu_senha;
    private DateTime usu_datacadastro;
    private Perfil per_codigo;

    public int Usu_codigo { get => usu_codigo; set => usu_codigo = value; }
    public string Usu_nome { get => usu_nome; set => usu_nome = value; }
    public string Usu_email { get => usu_email; set => usu_email = value; }
    public string Usu_senha { get => usu_senha; set => usu_senha = value; }
    public DateTime Usu_datacadastro { get => usu_datacadastro; set => usu_datacadastro = value; }
    public global::Perfil Per_codigo { get => per_codigo; set => per_codigo = value; }
}