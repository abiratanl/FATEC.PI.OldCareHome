using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Contato
/// </summary>
public class Contato
{
    private int         con_id;
    private string      con_descricao;
    private string      con_tipo;
    private Responsavel res_id;

    public int Con_id { get => con_id; set => con_id = value; }
    public string Con_descricao { get => con_descricao; set => con_descricao = value; }
    public string Con_tipo { get => con_tipo; set => con_tipo = value; }
    public global::Responsavel Res_id { get => res_id; set => res_id = value; }
}