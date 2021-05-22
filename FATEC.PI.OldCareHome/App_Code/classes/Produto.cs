using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Produto
/// </summary>
public class Produto
{
    private int     pro_id;
    private string  pro_descricao;
    private string  pro_unidade;
    private Boolean pro_emuso;

    public int Pro_id { get => pro_id; set => pro_id = value; }
    public string Pro_descricao { get => pro_descricao; set => pro_descricao = value; }
    public string Pro_unidade { get => pro_unidade; set => pro_unidade = value; }
    public bool Pro_emuso { get => pro_emuso; set => pro_emuso = value; }
}