using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Historico
/// </summary>
public class Historico
{
    private int his_id;
    private DateTime his_data;    
    private Ocorrencia oco_id;
    private Interno int_id;
    private string his_observacao;

    public int His_id { get => his_id; set => his_id = value; }
    public DateTime His_data { get => his_data; set => his_data = value; }
    public global::Ocorrencia Oco_id { get => oco_id; set => oco_id = value; }
    public global::Interno Int_id { get => int_id; set => int_id = value; }
    public string His_observacao { get => his_observacao; set => his_observacao = value; }
}