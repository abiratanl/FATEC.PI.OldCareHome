using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for MedicacaoDB
/// </summary>
public class MedicacaoDB{
    public static int Insert(Medicacao m){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO med_medicacao(med_data, med_quantidade, pre_id, fun_id) VALUES(?med_data, ?med_quantidade, ?pre_id, ?fun_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?med_data", m.Med_data));
            objCommand.Parameters.Add(Mapped.Parameter("?med_quantidade", m.Med_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", m.Pre_id.Pre_id));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_id", m.Fun_id.Fun_id));
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

    public static int Update(Medicacao m, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE med_medicacao SET";
            sql += " med_data = ?med_data,";
            sql += " med_quantidade = ?med_quantidade,";
            sql += " fun_id = ?fun_id,";
            sql += " pre_id = ?pre_id";
            sql += " where med_id = ?med_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?med_data", m.Med_data));
            objCommand.Parameters.Add(Mapped.Parameter("?med_quantidade", m.Med_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_id", m.Fun_id.Fun_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pre_id", m.Pre_id.Pre_id));
            objCommand.Parameters.Add(Mapped.Parameter("?med_id", id));
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
            string sql = "DELETE FROM med_medicacao WHERE med_id = ?med_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?med_id", id));
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
        string sql = "SELECT * FROM med_medicacao WHERE med_id = ?med_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?med_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    public static DataSet SelectAll()
    {
        string sql = "SELECT med_id AS `Código`,";
        sql += " DATE_FORMAT(med_data, '%d/%m/%Y') AS `Data`,";
        sql += " med_quantidade AS `Quantidade`,";
        sql += " fun_nome AS `Funcionario`,";
        sql += " pre_id AS `Prescrição`";
        sql += " FROM med_medicacao INNER JOIN fun_funcionario USING (fun_id) ORDER BY fun_nome";
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