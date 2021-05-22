using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Funcionario
/// </summary>
public class Funcionario
{
    private int     fun_id;
    private string  fun_nome;
    private decimal fun_salario;
    private DateTime fun_dataadmissao;
    private DateTime fun_datanascimento;
    private DateTime fun_datasituacao;
    private char     fun_sexo;
    private string   fun_cpf;
    private string   fun_rg;
    private string   fun_pis;
    private string   fun_ctps;
    private Situacao sit_id;
    private Endereco end_id;
    private Cargo    car_id;

    public int Fun_id { get => fun_id; set => fun_id = value; }
    public string Fun_nome { get => fun_nome; set => fun_nome = value; }
    public decimal Fun_salario { get => fun_salario; set => fun_salario = value; }
    public DateTime Fun_dataadmissao { get => fun_dataadmissao; set => fun_dataadmissao = value; }
    public DateTime Fun_datanascimento { get => fun_datanascimento; set => fun_datanascimento = value; }
    public DateTime Fun_datasituacao { get => fun_datasituacao; set => fun_datasituacao = value; }
    public char Fun_sexo { get => fun_sexo; set => fun_sexo = value; }
    public string Fun_cpf { get => fun_cpf; set => fun_cpf = value; }
    public string Fun_rg { get => fun_rg; set => fun_rg = value; }
    public string Fun_pis { get => fun_pis; set => fun_pis = value; }
    public string Fun_ctps { get => fun_ctps; set => fun_ctps = value; }
    public global::Situacao Sit_id { get => sit_id; set => sit_id = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
    public global::Cargo Car_id { get => car_id; set => car_id = value; }
}