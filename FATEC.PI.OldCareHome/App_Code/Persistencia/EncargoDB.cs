using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for EncargoDB
/// </summary>
public class EncargoDB{
    public static int Insert(Encargo e){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO enc_encargo(enc_datainicio, enc_situacao, enc_datasituacao, int_id, res_id) ";
            sql += "VALUES(?enc_datainicio, ?enc_situacao, ?enc_datasituacao, ?int_id, ?res_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datainicio", e.Enc_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_situacao", e.Enc_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datasituacao", e.Enc_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", e.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", e.Res_id.Res_id));
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


    public static int Update(Encargo e, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE enc_encargo SET";
            sql += " enc_datainicio = ?enc_datainicio,";
            sql += " enc_situacao ?enc_situacao,";
            sql += " enc_datasituacao ?enc_datasituacao,";
            sql += " res_id ?res_id,";
            sql += " int_id ?int_id";
            sql += " WHERE res_id = ?res_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datainicio", e.Enc_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_situacao", e.Enc_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_datasituacao", e.Enc_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", e.Res_id.Res_id));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", e.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?enc_id", id));
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
            string sql = "DELETE FROM enc_encargo WHERE enc_id = ?enc_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?enc_id", id));
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
        string sql = "SELECT enc_id AS `Código`";
        sql += " DATE_FORMAT(enc_datainicio, '%d/%m/%Y') AS `Data de Início`,";
        sql += " enc_situacao AS `Situação`,";
        sql += " DATE_FORMAT(enc_datasituacao, '%d/%m/%Y') AS `Data da Situação`,";
        sql += " res_id AS `Responsável`,";
        sql += " int_id AS `Interno`";
        sql += " FROM enc_encargo INNER JOIN int_internos USING (int_id) INNER JOIN res_responsavel USING (res_id)";
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
        string sql = "SELECT * FROM enc_encargo WHERE enc_id = ?enc_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?enc_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

}