using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Responsavel
/// </summary>
public class Responsavel
{
    private int      res_id;
    private string   res_nome;
    private string   res_parentesco;
    private string   res_cpf;
    private string   res_rg;
    private Endereco end_id;

    public int Res_id { get => res_id; set => res_id = value; }
    public string Res_nome { get => res_nome; set => res_nome = value; }
    public string Res_parentesco { get => res_parentesco; set => res_parentesco = value; }
    public string Res_cpf { get => res_cpf; set => res_cpf = value; }
    public string Res_rg { get => res_rg; set => res_rg = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
}