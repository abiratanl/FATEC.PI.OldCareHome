using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Categoria
/// </summary>
public class Categoria
{
    private int cat_codigo;
    private string cat_descricao;

    public int Cat_codigo { get => cat_codigo; set => cat_codigo = value; }
    public string Cat_descricao { get => cat_descricao; set => cat_descricao = value; }
}