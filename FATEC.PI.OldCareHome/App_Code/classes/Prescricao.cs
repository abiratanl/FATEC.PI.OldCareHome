using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Prescricao
/// </summary>
public class Prescricao
{
    private int      pre_id;
    private DateTime pre_data;
    private string   pre_medico;
    private string   pre_situacao;
    private Internos  int_id;

    public int Pre_id { get => pre_id; set => pre_id = value; }
    public DateTime Pre_data { get => pre_data; set => pre_data = value; }
    public string Pre_medico { get => pre_medico; set => pre_medico = value; }
    public string Pre_situacao { get => pre_situacao; set => pre_situacao = value; }
    public global::Internos Int_id { get => int_id; set => int_id = value; }
}