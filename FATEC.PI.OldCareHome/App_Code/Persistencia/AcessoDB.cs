using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
/// <summary>
/// Summary description for Acesso
/// </summary>
public class AcessoDB{
    public static int Insert(Acesso a, Perfil p, Usuario u){        
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO ace_acesso(ace_data, ace_ativo, per_id, usu_id) VALUES(?ace_data, ?ace_ativo, ?per_id, ?usu_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ace_data", a.Ace_data));
            objCommand.Parameters.Add(Mapped.Parameter("?ace_ativo", a.Ace_ativo));
            objCommand.Parameters.Add(Mapped.Parameter("?per_id", p.Per_id));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", a.Usu_id));
            // utilizado quando código não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception)
        {
            return-2;
        }
        return 0;
    }
}