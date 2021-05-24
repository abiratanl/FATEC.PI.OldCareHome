using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for ContatoDB
/// </summary>
public class ContatoDB{
    public static int Insert(Contato c){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO con_contato(con_tipo, con_descricao, res_id) VALUES(?con_tipo, ?con_descricao, ?res_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?con_tipo", c.Con_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?con_descricao", c.Con_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", c.Res_id.Res_id));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception)
        {
            return -2;
        }
        return 0;
    }
}
