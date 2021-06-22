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


    public static int Update(Endereco e, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE end_endereco SET";
            sql += " end_tipo = ?end_tipo,";
            sql += " end_logradouro = ?end_logradouro,";
            sql += " end_descricao = ?end_descricao,";
            sql += " end_numero = ?end_numero,";
            sql += " end_bairro = ?end_bairro,";
            sql += " end_cidade = ?end_cidade,";
            sql += " end_cep = ?end_cep,";
            sql += " end_estado = ?end_estado,";
            sql += " end_complemento = ?end_complemento";
            sql += " WHERE end_id = ?end_id";

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
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

        }
        catch (Exception ex)
        {
            return -2;
        }
        return 0;
    }

    public static int Delete(int id)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "DELETE FROM end_endereco WHERE end_id = ?end_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", id));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception ex)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static DataSet SelectAll()
    {
        string sql = "SELECT end_id AS `Código`, end_tipo AS `Tipo`, end_logradouro AS `Logradouro`,";
        sql += " end_descricao AS `Descricão`, end_numero AS `Número`, end_bairro AS `Bairro`,";
        sql += " end_cidade AS `Cidade`, end_cep AS `CEP`, end_estado AS `Estado`,";
        sql += " end_complemento AS `Complemento` FROM end_endereco ORDER BY end_descricao";

        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        // O objeto DataAdapter vai preencher o DataSet com os dados do BD.
        objDataAdapter.Fill(ds); // O método Fill é o responsável por preencher o DataSet
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    //pat_id, pat_descricao, pat_cid, pat_restricao
    public static DataSet SelectId(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "SELECT * FROM end_endereco WHERE end_id = ?end_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?end_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }   
}