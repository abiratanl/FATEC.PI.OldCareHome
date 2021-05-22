using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Patologia
/// </summary>
public class Patologia
{
    private int    pat_id;
    private string pat_descricao;
    private string pat_cid;
    private string pat_restricao;

    public int Pat_id { get => pat_id; set => pat_id = value; }
    public string Pat_descricao { get => pat_descricao; set => pat_descricao = value; }
    public string Pat_cid { get => pat_cid; set => pat_cid = value; }
    public string Pat_restricao { get => pat_restricao; set => pat_restricao = value; }
}