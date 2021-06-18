using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for LogDB
/// </summary>
public class LogDB{
    public static int Insert(Log l){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO log(log_data, log_tabela, log_operacao, log_antes, log_depois, usu_id) ";
            sql += "VALUES(?log_data, ?log_tabela, ?log_operacao, ?log_antes, ?log_depois, ?usu_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?log_data", l.Log_data));
            objCommand.Parameters.Add(Mapped.Parameter("?log_tabela", l.Log_tabela));
            objCommand.Parameters.Add(Mapped.Parameter("?log_operacao", l.Log_operacao));
            objCommand.Parameters.Add(Mapped.Parameter("?log_antes", l.Log_antes));
            objCommand.Parameters.Add(Mapped.Parameter("?log_depois", l.Log_depois));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", l.Usu_id.Usu_id));
            // utilizado quando código não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception){
            return -2;
        }
        return 0;
    }
}