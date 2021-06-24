using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for ItemPrescricaoDB
/// </summary>
public class ItemPrescricaoDB{
    public static int Insert(ItemPrescricao i){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO ite_itemprescricao(ite_quantidade, ite_frequencia, ite_duracao, ite_observacao, pro_id) ";
            sql += "VALUES(?ite_quantidade, ?ite_frequencia, ?ite_duracao, ?ite_observacao, ?pro_id)"; 
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ite_quantidade", i.Ite_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_frequencia", i.Ite_frequencia));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_duracao", i.Ite_duracao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", i.Pro_id.Pro_id));
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

    public static int Update(ItemPrescricao i, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE ite_itemprescricao SET";
            sql += " ite_quantidade = ?ite_quantidade,";
            sql += " ite_frequencia = ?ite_frequencia,";
            sql += " ite_duracao = ?ite_duracao,";
            sql += " ite_observacao = ?ite_observacao,";
            sql += " pro_id = ?pro_id,";
            sql += " pre_id = ?pre_id";
            sql += " where ite_id = ?ite_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ite_quantidade", i.Ite_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_frequencia", i.Ite_frequencia));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_duracao", i.Ite_duracao));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_observacao", i.Ite_observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", i.Pro_id.Pro_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", i.Pre_id.Pre_id));
            objCommand.Parameters.Add(Mapped.Parameter("?ite_id", id));
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
            string sql = "DELETE FROM ite_itemprescricao WHERE ite_id = ?ite_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?ite_id", id));
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

    public static DataSet SelectId(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "SELECT * FROM ite_itemprescricao WHERE ite_id = ?ite_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?ite_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    public static DataSet SelectAll()
    {
        string sql = "SELECT ite_id AS `Código`,";
        sql += " ite_quantidade AS `Quantidade`,";
        sql += " ite_frequencia AS `Frequência Diária`,";
        sql += " ite_duracao AS `Duração em Dias`,";
        sql += " ite_observacao AS `Observação`,";
        sql += " pre_id AS `Prescrição`,";
        sql += " pro_descricao AS `Produto`";
        sql += " FROM ite_itemprescricao INNER JOIN pro_produto USING (pro_id) ORDER BY pro_descricao";
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