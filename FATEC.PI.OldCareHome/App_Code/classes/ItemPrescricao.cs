using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ItemPrescricao
/// </summary>
public class ItemPrescricao
{
    private int        ite_id;
    private int        ite_quantidade;
    private int        ite_frequencia;
    private int        ite_duracao;
    private string     ite_observacao;
    private Produto    pro_id;
    private Prescricao pre_id;

    public int Ite_id { get => ite_id; set => ite_id = value; }
    public int Ite_quantidade { get => ite_quantidade; set => ite_quantidade = value; }
    public int Ite_frequencia { get => ite_frequencia; set => ite_frequencia = value; }
    public int Ite_duracao { get => ite_duracao; set => ite_duracao = value; }
    public string Ite_observacao { get => ite_observacao; set => ite_observacao = value; }
    public global::Produto Pro_id { get => pro_id; set => pro_id = value; }
    public Prescricao Pre_id { get => pre_id; set => pre_id = value; }
}