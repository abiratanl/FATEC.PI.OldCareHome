using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for Lar
/// </summary>
public class Lar
{
    private int lar_id;
    private string lar_nome;
    private string lar_nomefantasia;
    private string lar_cnpj;
    private string lar_registro;
    private Endereco end_id;
    private string lar_descricao;

    public int Lar_id { get => lar_id; set => lar_id = value; }
    public string Lar_nome { get => lar_nome; set => lar_nome = value; }
    public string Lar_nomefantasia { get => lar_nomefantasia; set => lar_nomefantasia = value; }
    public string Lar_cnpj { get => lar_cnpj; set => lar_cnpj = value; }
    public string Lar_registro { get => lar_registro; set => lar_registro = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
    public string Lar_descricao { get => lar_descricao; set => lar_descricao = value; }
}