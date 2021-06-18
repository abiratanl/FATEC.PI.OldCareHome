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

    public static DataSet SelectAll(){
        string sql = "SELECT qua_id AS `Código`, qua_descricao AS `Descrição`, qua_tipo AS `Tipo`,  ";
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
}