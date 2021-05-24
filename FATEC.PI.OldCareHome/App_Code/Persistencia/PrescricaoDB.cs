using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for PrescricaoDB
/// </summary>
public class PrescricaoDB{
    public static int Insert(Prescricao p){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO pre_prescricao(pre_data, pre_medico, pre_situacao, int_id) VALUES(?pre_data, ?pre_medico, ?pre_situacao, ?int_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pre_data", p.Pre_data));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_medico", p.Pre_medico));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_situacao", p.Pre_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", p.Int_id.Int_id));
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