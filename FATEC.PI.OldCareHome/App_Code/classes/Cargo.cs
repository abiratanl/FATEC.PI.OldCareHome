using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cargo
/// </summary>
public class Cargo
{
    private int    car_id;
    private string car_descricao;
    private string car_cbo;

    public int Car_id { get => car_id; set => car_id = value; }
    public string Car_descricao { get => car_descricao; set => car_descricao = value; }
    public string Car_cbo { get => car_cbo; set => car_cbo = value; }
}