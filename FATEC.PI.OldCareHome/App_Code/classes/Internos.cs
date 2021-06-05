using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Interno
/// </summary>
public class Internos{
    private int int_id;
    private string int_nome;
    private DateTime int_datanascimento;
    private char int_sexo;
    private string int_pai;
    private string int_mae;
    private string int_estadocivil;
    private string int_profissao;
    private string int_escolaridade;
    private string int_naturalidade;
    private int int_cpf;
    private string int_rg;
    private string int_tituloeleitor;
    private string int_beneficioinss;
    private string int_planosaude;    
    private string int_situacao;
    private DateTime int_dataentrada;
    private DateTime int_datasituacao;
    private string int_mobilidade;
    private Quarto qua_id;
    private Endereco end_id;

    public int Int_id { get => int_id; set => int_id = value; }
    public string Int_nome { get => int_nome; set => int_nome = value; }
    public DateTime Int_datanascimento { get => int_datanascimento; set => int_datanascimento = value; }
    public char Int_sexo { get => int_sexo; set => int_sexo = value; }
    public string Int_pai { get => int_pai; set => int_pai = value; }
    public string Int_mae { get => int_mae; set => int_mae = value; }
    public string Int_estadocivil { get => int_estadocivil; set => int_estadocivil = value; }
    public string Int_profissao { get => int_profissao; set => int_profissao = value; }
    public string Int_escolaridade { get => int_escolaridade; set => int_escolaridade = value; }
    public string Int_naturalidade { get => int_naturalidade; set => int_naturalidade = value; }
    public int Int_cpf { get => int_cpf; set => int_cpf = value; }
    public string Int_rg { get => int_rg; set => int_rg = value; }
    public string Int_tituloeleitor { get => int_tituloeleitor; set => int_tituloeleitor = value; }
    public string Int_beneficioinss { get => int_beneficioinss; set => int_beneficioinss = value; }
    public string Int_planosaude { get => int_planosaude; set => int_planosaude = value; }
    public string Int_situacao { get => int_situacao; set => int_situacao = value; }
    public DateTime Int_dataentrada { get => int_dataentrada; set => int_dataentrada = value; }
    public DateTime Int_datasituacao { get => int_datasituacao; set => int_datasituacao = value; }
    public string Int_mobilidade { get => int_mobilidade; set => int_mobilidade = value; }
    public global::Quarto Qua_id { get => qua_id; set => qua_id = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
}