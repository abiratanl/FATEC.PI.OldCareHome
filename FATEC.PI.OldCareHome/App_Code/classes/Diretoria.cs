using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Diretoria
/// </summary>
public class Diretoria
{
    private int      dir_id;
    private DateTime dir_datainicio;
    private DateTime dir_datatermino;
    private Diretor dtr_id;
    private Funcao fun_id;

    public int Dir_id { get => dir_id; set => dir_id = value; }
    public DateTime Dir_datainicio { get => dir_datainicio; set => dir_datainicio = value; }
    public DateTime Dir_datatermino { get => dir_datatermino; set => dir_datatermino = value; }
    public global::Diretor Dtr_id { get => dtr_id; set => dtr_id = value; }
    public global::Funcao Fun_id { get => fun_id; set => fun_id = value; }
}