using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Acesso
/// </summary>
public class Acesso
{
    private int      ace_id;
    private DateTime ace_data;
    private Boolean  ace_ativo;
    private Usuario  usu_id;
    private Perfil   per_id;

    public int Ace_id { get => ace_id; set => ace_id = value; }
    public DateTime Ace_data { get => ace_data; set => ace_data = value; }
    public bool Ace_ativo { get => ace_ativo; set => ace_ativo = value; }
    public global::Usuario Usu_id { get => usu_id; set => usu_id = value; }
    public global::Perfil Per_id { get => per_id; set => per_id = value; }
}