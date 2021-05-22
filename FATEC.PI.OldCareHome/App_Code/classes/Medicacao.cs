using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Medicacao
/// </summary>
public class Medicacao
{
    private int         med_id;
    private DateTime    med_data;
    private int         med_quantidade;
    private Prescricao  pre_id;
    private Funcionario fun_id;

    public int Med_id { get => med_id; set => med_id = value; }
    public DateTime Med_data { get => med_data; set => med_data = value; }
    public int Med_quantidade { get => med_quantidade; set => med_quantidade = value; }
    public global::Prescricao Pre_id { get => pre_id; set => pre_id = value; }
    public global::Funcionario Fun_id { get => fun_id; set => fun_id = value; }
}