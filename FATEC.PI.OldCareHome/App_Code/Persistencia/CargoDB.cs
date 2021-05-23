using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for CargoDB
/// </summary>
public class CargoDB
{
    public static int Insert(Cargo c)
    {        
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO car_cargo(car_descricao, car_cbo) VALUES(?car_descricao, ?car_cbo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?car_descricao", c.Car_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?car_cbo", c.Car_cbo));
            // utilizado quando  não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception)
        {
            return -2;
        }
        return 0;
    }
}