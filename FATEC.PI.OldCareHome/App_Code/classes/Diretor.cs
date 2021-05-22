using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Diretor
/// </summary>
public class Diretor
{
    private int      dtr_id;
    private string   dtr_nome;
    private string   dtr_cpf;
    private string   dtr_rg;
    private Endereco end_id;

    public int Dtr_id { get => dtr_id; set => dtr_id = value; }
    public string Dtr_nome { get => dtr_nome; set => dtr_nome = value; }
    public string Dtr_cpf { get => dtr_cpf; set => dtr_cpf = value; }
    public string Dtr_rg { get => dtr_rg; set => dtr_rg = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
}