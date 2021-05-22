using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    private int usu_id;
    private string usu_nome;
    private string usu_email;
    private string usu_senha;
    private string usu_situacao;
    private DateTime usu_datacadastro;
    private DateTime usu_datasituacao;
    private Boolean usu_trocarsenha;
    private Perfil per_codigo;

    public int Usu_codigo { get => usu_id; set => usu_id = value; }
    public string Usu_nome { get => usu_nome; set => usu_nome = value; }
    public string Usu_email { get => usu_email; set => usu_email = value; }
    public string Usu_senha { get => usu_senha; set => usu_senha = value; }
    public DateTime Usu_datacadastro { get => usu_datacadastro; set => usu_datacadastro = value; }
    public global::Perfil Per_codigo { get => per_codigo; set => per_codigo = value; }
    public DateTime Usu_datasituacao { get => usu_datasituacao; set => usu_datasituacao = value; }
    public bool Usu_trocarsenha { get => usu_trocarsenha; set => usu_trocarsenha = value; }
    public string Usu_situacao { get => usu_situacao; set => usu_situacao = value; }
}