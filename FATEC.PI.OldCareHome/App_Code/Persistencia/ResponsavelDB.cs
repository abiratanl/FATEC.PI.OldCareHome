using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for ResponsavelDB
/// </summary>
public class ResponsavelDB{
    public static int Insert(Responsavel r){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO res_responsavel(res_nome, res_parentesco, res_cpf, res_rg, end_id) ";
            sql += "VALUES(?res_nome, ?res_parentesco, ?res_cpf, ?res_rg, ?end_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?res_nome", r.Res_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?res_parentesco", r.Res_parentesco));
            objCommand.Parameters.Add(Mapped.Parameter("?res_cpf", r.Res_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?res_rg", r.Res_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", r.End_id.End_id));
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