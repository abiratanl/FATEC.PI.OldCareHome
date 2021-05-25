using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for LarDB
/// </summary>
public class LarDB
{
    public static int Insert(Lar l)
    {

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO lar(lar_nome, lar_nomefantasia, lar_cnpj, lar_registro, end_id, lar_descricao) ";
            sql += "VALUES(?lar_nome, ?lar_nomefantasia, ?lar_cnpj, ?lar_registro, ?end_id, ?lar_descricao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?lar_nome", l.Lar_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_nomefantasia", l.Lar_nomefantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_cnpj", l.Lar_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_registro", l.Lar_registro));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", l.End_id.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_descricao", l.Lar_descricao));
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