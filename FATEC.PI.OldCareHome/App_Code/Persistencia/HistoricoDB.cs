using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for HistoricoDB
/// </summary>
public class HistoricoDB{
    public static int Insert(Historico h){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO his_historico(his_data, oco_id, int_id, his_observacao) VALUES(?his_data, ?oco_id, ?int_id, ?his_observacao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?his_data", h.His_data));
            objCommand.Parameters.Add(Mapped.Parameter("?oco_id", h.Oco_id.Oco_id));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", h.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?his_observacao", h.His_observacao));
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

    public static int Update(Historico h, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE his_historico SET";
            sql += " his_data = ?his_data,";
            sql += " his_observacao = ?his_observacao,";
            sql += " int_id = ?int_id,";
            sql += " oco_id = ?oco_id";
            sql += " where his_id = ?his_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?his_data", h.His_data));
            objCommand.Parameters.Add(Mapped.Parameter("?his_observacao", h.His_observacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", h.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?oco_id", h.Oco_id.Oco_id));
            objCommand.Parameters.Add(Mapped.Parameter("?his_id", id));
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
            string sql = "DELETE FROM his_historico WHERE his_id = ?his_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?his_id", id));
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
        string sql = "SELECT * FROM his_historico WHERE his_id = ?his_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?his_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

   
    public static DataSet SelectAll()
    {
        string sql = "SELECT his_id AS `Código`,";
        sql += " DATE_FORMAT(his_data, '%d/%m/%Y') AS `Data`,";
        sql += " his_observacao AS `Observação`,";
        sql += " int_nome AS `Interno`,";
        sql += " oco_descricao AS `Ocorrência`"; 
        sql += " FROM his_historico INNER JOIN int_internos USING (int_id) INNER JOIN oco_ocorrencia USING (oco_id) ORDER BY int_nome";
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