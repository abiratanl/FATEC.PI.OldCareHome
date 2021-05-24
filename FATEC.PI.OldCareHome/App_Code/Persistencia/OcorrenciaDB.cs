using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for OcorrenciaDB
/// </summary>
public class OcorrenciaDB{
    public static int Insert(Ocorrencia o){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO oco_ocorrencia(oco_descricao, oco_tipo) VALUES(?oco_descricao, ?oco_tipo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?oco_descricao", o.Oco_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?oco_tipo", o.Oco_tipo));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
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