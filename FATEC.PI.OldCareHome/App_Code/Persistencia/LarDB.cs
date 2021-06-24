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


    public static int Update(Lar l, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE lar SET";
            sql += " lar_nome = ?lar_nome,";
            sql += " lar_nomefantasia ?lar_nomefantasia,";
            sql += " lar_cnpj ?lar_cnpj,";
            sql += " lar_registro ?lar_registro,";
            sql += " lar_descricao ?lar_descricao,";
            sql += " end_id ?end_id";
            sql += " WHERE lar_id = ?lar_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?lar_nome", l.Lar_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_nomefantasia", l.Lar_nomefantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_cnpj", l.Lar_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_registro", l.Lar_registro));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_descricao", l.Lar_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", l.End_id.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?lar_id", id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception )
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
            string sql = "DELETE FROM lar WHERE lar_id = ?lar_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?lar_id", id));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception )
        {
            retorno = -2;
        }
        return retorno;
    }

    public static DataSet SelectAll()
    {
        string sql = "SELECT lar_id AS `Código`,";
        sql += " lar_nome AS `Nome`,";
        sql += " DATE_FORMAT(fun_dataadmissao, '%d/%m/%Y') AS `Admissão`,";
        sql += " lar_nomefantasia AS `Salário`,";
        sql += " lar_cnpj AS `CPF`,";
        sql += " lar_registro AS `RG`,";
        sql += " lar_descricao AS `PIS`,";
        sql += " end_id AS `CTPS`";
        sql += " FROM lar INNER JOIN end_endereco USING(end_id)";

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

    public static DataSet SelectId(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "SELECT * FROM lar WHERE lar_id = ?lar_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?lar_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
}