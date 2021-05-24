using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for ItemPrescricaoDB
/// </summary>
public class ItemPrescricaoDB{
    public static int Insert(ItemPrescricao i){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO ite_itemprescricao(ite_quantidade, ite_frequencia, ite_duracao, ite_observacao, pro_id) ";
            sql += "VALUES(?ite_quantidade, ?ite_frequencia, ?ite_duracao, ?ite_observacao, ?pro_id)"; 
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ite_quantidade", i.Ite_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_frequencia", i.Ite_frequencia));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_duracao", i.Ite_duracao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", i.Pro_id.Pro_id));
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