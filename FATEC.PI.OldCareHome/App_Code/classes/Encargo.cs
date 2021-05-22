using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Encargo
/// </summary>
public class Encargo
{
    private int         enc_id;
    private DateTime    enc_datainicio;
    private string      enc_situacao;
    private DateTime    enc_datasituacao;
    private Interno     int_id;
    private Responsavel res_id;

    public int Enc_id { get => enc_id; set => enc_id = value; }
    public DateTime Enc_datainicio { get => enc_datainicio; set => enc_datainicio = value; }
    public string Enc_situacao { get => enc_situacao; set => enc_situacao = value; }
    public DateTime Enc_datasituacao { get => enc_datasituacao; set => enc_datasituacao = value; }
    public global::Interno Int_id { get => int_id; set => int_id = value; }
    public global::Responsavel Res_id { get => res_id; set => res_id = value; }
}