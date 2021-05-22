using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Logdb
/// </summary>
public class Logdb
{
    private int log_id;
    private DateTime log_data;
    private string log_tabela;
    private string log_operacao;
    private string log_antes;
    private string log_depois;
    private Usuario usu_id;

    public int Log_id { get => log_id; set => log_id = value; }
    public DateTime Log_data { get => log_data; set => log_data = value; }
    public string Log_tabela { get => log_tabela; set => log_tabela = value; }
    public string Log_operacao { get => log_operacao; set => log_operacao = value; }
    public string Log_antes { get => log_antes; set => log_antes = value; }
    public string Log_depois { get => log_depois; set => log_depois = value; }
    public global::Usuario Usu_id { get => usu_id; set => usu_id = value; }
}