using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for EncargoDB
/// </summary>
public class EncargoDB{
    public static int Insert(Encargo e){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO enc_encargo(enc_datainicio, enc_situacao, enc_datasituacao, int_id, res_id) ";
            sql += "VALUES(?enc_datainicio, ?enc_situacao, ?enc_datasituacao, ?int_id, ?res_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datainicio", e.Enc_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_situacao", e.Enc_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datasituacao", e.Enc_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", e.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", e.Res_id.Res_id));
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