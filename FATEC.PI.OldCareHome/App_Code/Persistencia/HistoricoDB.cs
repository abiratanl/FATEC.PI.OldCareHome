using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for HistoricoDB
/// </summary>
public class HistoricoDB{
    public static int Insert(Historico h, Ocorrencia o, Interno i){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO his_historico(his_data, oco_id, int_id, his_observacao) VALUES(?his_data, ?oco_id, ?int_id, ?his_observacao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?his_data", h.His_data));
            objCommand.Parameters.Add(Mapped.Parameter("?oco_id", o.Oco_id));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", i.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?his_observacao", h.His_observacao));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception)
        {
            return 2;
        }
        return 0;
    }
}