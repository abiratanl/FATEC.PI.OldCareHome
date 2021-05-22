using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Situacao
/// </summary>
public class Situacao
{
    private int    sit_id;
    private string sit_descricao;

    public int Sit_id { get => sit_id; set => sit_id = value; }
    public string Sit_descricao { get => sit_descricao; set => sit_descricao = value; }
}