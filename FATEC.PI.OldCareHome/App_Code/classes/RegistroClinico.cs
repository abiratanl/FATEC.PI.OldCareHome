using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegistroClinico
/// </summary>
public class RegistroClinico
{
    private int       reg_id;
    private DateTime  reg_datainicio;
    private string    reg_grau;
    private string    reg_situacao;
    private DateTime  reg_datasituacao;
    private Patologia pat_id;
    private Interno   int_id;

    public int Reg_id { get => reg_id; set => reg_id = value; }
    public DateTime Reg_datainicio { get => reg_datainicio; set => reg_datainicio = value; }
    public string Reg_grau { get => reg_grau; set => reg_grau = value; }
    public string Reg_situacao { get => reg_situacao; set => reg_situacao = value; }
    public DateTime Reg_datasituacao { get => reg_datasituacao; set => reg_datasituacao = value; }
    public global::Patologia Pat_id { get => pat_id; set => pat_id = value; }
    public global::Interno Int_id { get => int_id; set => int_id = value; }
}