using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for MedicacaoDB
/// </summary>
public class MedicacaoDB{
    public static int Insert(Medicacao m){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO med_medicacao(med_data, med_quantidade, pre_id, fun_id) VALUES(?med_data, ?med_quantidade, ?pre_id, ?fun_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?med_data", m.Med_data));
            objCommand.Parameters.Add(Mapped.Parameter("?med_quantidade", m.Med_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", m.Pre_id.Pre_id));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_id", m.Fun_id.Fun_id));
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