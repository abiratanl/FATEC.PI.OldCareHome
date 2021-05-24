using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for EnderecoDB
/// </summary>
public class EnderecoDB
{
    public static int Insert(Endereco e)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO end_endereco(end_tipo, end_logradouro, end_descricao, end_numero, end_bairro, end_cidade, end_cep, end_estado, end_complemento) ";
            sql += "VALUES(?end_tipo, ?end_logradouro, ?end_descricao, ?end_numero, ?end_bairro, ?end_cidade, ?end_cep, ?end_estado, ?end_complemento)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?end_tipo", e.End_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?end_logradouro", e.End_logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?end_descricao", e.End_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?end_numero", e.End_numero));
            objCommand.Parameters.Add(Mapped.Parameter("?end_bairro", e.End_bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cidade", e.End_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cep", e.End_cep));
            objCommand.Parameters.Add(Mapped.Parameter("?end_estado", e.End_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?end_complemento", e.End_complemento));
            // utilizado quando  não tem retorno, como seria o caso do SELECT
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