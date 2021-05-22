using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Quarto
/// </summary>
public class Quarto
{
    private int qua_id;
    private string qua_descricao;
    private int qua_capacidade;
    private string qua_tipo;

    public int Qua_id { get => qua_id; set => qua_id = value; }
    public string Qua_descricao { get => qua_descricao; set => qua_descricao = value; }
    public int Qua_capacidade { get => qua_capacidade; set => qua_capacidade = value; }
    public string Qua_tipo { get => qua_tipo; set => qua_tipo = value; }
}