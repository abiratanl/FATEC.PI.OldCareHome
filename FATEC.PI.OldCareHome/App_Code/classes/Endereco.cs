using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Endereco
/// </summary>
public class Endereco
{
    private int end_id;
    private string end_tipo;
    private string end_logradouro;
    private string end_descricao;
    private string end_numero;
    private string end_bairro;
    private string end_cidade;
    private string end_cep;
    private char end_estado;
    private string end_complemento;

    public int End_id { get => end_id; set => end_id = value; }
    public string End_tipo { get => end_tipo; set => end_tipo = value; }
    public string End_logradouro { get => end_logradouro; set => end_logradouro = value; }
    public string End_descricao { get => end_descricao; set => end_descricao = value; }
    public string End_numero { get => end_numero; set => end_numero = value; }
    public string End_bairro { get => end_bairro; set => end_bairro = value; }
    public string End_cidade { get => end_cidade; set => end_cidade = value; }
    public string End_cep { get => end_cep; set => end_cep = value; }
    public char End_estado { get => end_estado; set => end_estado = value; }
    public string End_complemento { get => end_complemento; set => end_complemento = value; }
}