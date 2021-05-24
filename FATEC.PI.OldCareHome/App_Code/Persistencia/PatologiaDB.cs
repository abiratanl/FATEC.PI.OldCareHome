using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for PatologiaDB
/// </summary>
public class PatologiaDB{
    public static int Insert(Patologia p){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO pat_patologia(pat_descricao, pat_cid, pat_restricao) VALUES(?pat_descricao, ?pat_cid, ?pat_restricao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?per_descricao", p.Pat_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?per_cid", p.Pat_cid));
            objCommand.Parameters.Add(Mapped.Parameter("?per_restricao", p.Pat_restricao));
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