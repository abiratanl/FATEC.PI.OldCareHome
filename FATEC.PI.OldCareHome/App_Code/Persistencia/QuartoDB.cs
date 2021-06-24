using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for QuartoDB
/// </summary>
public class QuartoDB{
    public static int Insert(Quarto q){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO qua_quarto(qua_descricao, qua_capacidade, qua_tipo) VALUES(?qua_descricao, ?qua_capacidade, ?qua_tipo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?qua_descricao", q.Qua_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_capacidade", q.Qua_capacidade));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_tipo", q.Qua_tipo));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception ex){
            return -2;
        }
        return 0;
    }

    public static int Update(Quarto q, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE qua_quarto SET";
            sql += " qua_descricao = ?qua_descricao,";            
            sql += " qua_capacidade = ?qua_capacidade,";
            sql += " qua_tipo = ?qua_tipo";
            sql += " WHERE qua_id = ?qua_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?qua_descricao", q.Qua_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_capacidade", q.Qua_capacidade));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_tipo", q.Qua_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_id", id));
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
            string sql = "DELETE FROM qua_quarto WHERE qua_id = ?qua_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?qua_id", id));
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

    public static DataSet SelectAll(){
        string sql = "SELECT qua_id AS `Código`, qua_descricao AS `Descrição`, qua_tipo AS `Gênero`,  ";
        sql += "qua_capacidade AS `Capacidade` FROM qua_quarto";
        
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
        string sql = "SELECT qua_id, qua_descricao, qua_capacidade, qua_tipo FROM qua_quarto WHERE qua_id = ?qua_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?qua_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
    public static DataSet Disponibilidade()
    {
        string sql = "SELECT SUM(qua_quarto.qua_capacidade) AS `Capacidade`, COUNT(int_internos.qua_id) AS `Ocupação`, (SUM(qua_quarto.qua_capacidade) - (SUM(int_internos.qua_id))) `Disponível`, qua_tipo as `Sexo` FROM qua_quarto LEFT JOIN int_internos USING (qua_id) GROUP BY qua_tipo";

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

}