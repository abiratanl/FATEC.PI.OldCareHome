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

    public static int Update(Contato c, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE con_contato SET";
            sql += " con_descricao = ?con_descricao,";
            sql += " con_tipo = ?con_tipo,";
            sql += " res_id = ?res_id";
            sql += " WHERE con_id = ?con_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?con_descricao", c.Con_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?con_tipo", c.Con_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", c.Res_id.Res_id));
            objCommand.Parameters.Add(Mapped.Parameter("?con_id", id));
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
            string sql = "DELETE FROM con_contato WHERE con_id = ?con_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?con_id", id));
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
        string sql = "SELECT con_id AS `Código`, con_descricao AS `Descrição`, con_tipo AS `Tipo`,  ";
        sql += "res_id AS `Responsavel` FROM con_contato ORDER BY con_descricao";

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
        string sql = "SELECT * FROM con_contato WHERE con_id = ?con_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?con_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
}