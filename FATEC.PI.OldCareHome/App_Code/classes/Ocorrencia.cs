using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ocorrencia
/// </summary>
public class Ocorrencia
{
    private int oco_id;
    private string oco_descricao;
    private string oco_tipo;

    public int Oco_id { get => oco_id; set => oco_id = value; }
    public string Oco_descricao { get => oco_descricao; set => oco_descricao = value; }
    public string Oco_tipo { get => oco_tipo; set => oco_tipo = value; }
}