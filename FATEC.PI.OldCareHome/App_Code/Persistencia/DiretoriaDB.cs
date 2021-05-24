using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DiretoriaDB
/// </summary>
public class DiretoriaDB
{
    public static int Insert(Diretoria D, Diretor d, Cargo c){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO dir_diretoria(dir_datainicio, dir_datatermino, dtr_id, car_id) ";
            sql += "VALUES(?dir_datainicio, ?dir_datatermino, ?dtr_id, ?car_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datainicio", D.Dir_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datatermino", D.Dir_datatermino));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", d.Dtr_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", c.Car_id));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception){
            return 2;
        }
        return 0;
    }
}