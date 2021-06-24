using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for PrescricaoDB
/// </summary>
public class PrescricaoDB{
    public static int Insert(Prescricao p){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO pre_prescricao(pre_data, pre_medico, pre_situacao, int_id) VALUES(?pre_data, ?pre_medico, ?pre_situacao, ?int_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pre_data", p.Pre_data));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_medico", p.Pre_medico));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_situacao", p.Pre_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", p.Int_id.Int_id));
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

    public static int Update(Prescricao p, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE pre_prescricao SET";
            sql += " pre_data = ?pre_data,";
            sql += " pre_medico = ?pre_medico,";
            sql += " pre_situacao = ?pre_situacao,";
            sql += " int_id = ?int_id";
            sql += " where pre_id = ?pre_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pre_data", p.Pre_data));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_medico", p.Pre_medico));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_situacao", p.Pre_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", p.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", id));
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
            string sql = "DELETE FROM pre_prescricao WHERE pre_id = ?pre_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", id));
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
        string sql = "SELECT * FROM pre_prescricao WHERE pre_id = ?pre_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?pre_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }


    public static DataSet SelectAll()
    {
        string sql = "SELECT pre_id AS `Código`,";
        sql += " DATE_FORMAT(pre_data, '%d/%m/%Y') AS `Data`,";
        sql += " pre_medico AS `Médico`,";
        sql += " pre_situacao AS `Situação`,";
        sql += " int_nome AS `Interno`";
        sql += " FROM pre_prescricao INNER JOIN int_internos USING (int_id) ORDER BY int_nome";
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