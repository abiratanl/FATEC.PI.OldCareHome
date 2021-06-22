using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for ResponsavelDB
/// </summary>
public class ResponsavelDB{
    public static int Insert(Responsavel r){
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO res_responsavel(res_nome, res_parentesco, res_cpf, res_rg, end_id) ";
            sql += "VALUES(?res_nome, ?res_parentesco, ?res_cpf, ?res_rg, ?end_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?res_nome", r.Res_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?res_parentesco", r.Res_parentesco));
            objCommand.Parameters.Add(Mapped.Parameter("?res_cpf", r.Res_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?res_rg", r.Res_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", r.End_id.End_id));
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

    public static int Update(Responsavel r, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE res_responsavel SET";
            sql += " res_nome = ?res_nome,";
            sql += " res_parentesco ?res_parentesco,";
            sql += " res_cpf ?res_cpf,";
            sql += " res_rg ?res_rg,";            
            sql += " end_id ?end_id";
            sql += " WHERE res_id = ?res_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?int_nome", r.Res_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?int_datanascimento", r.Res_parentesco));
            objCommand.Parameters.Add(Mapped.Parameter("?int_cpf", r.Res_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?int_rg", r.Res_rg));          
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", r.End_id.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", id));
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
            string sql = "DELETE FROM res_responsavel WHERE res_id = ?res_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?res_id", id));
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
        string sql = "SELECT res_id AS `Código`";
        sql += " res_nome AS `Nome`,";
        sql += " res_parentesco AS `Parentesco`,";
        sql += " res_cpf AS `CPF`,";
        sql += " res_rg AS `RG`,";
        sql += " end_id AS `Endereço`";
        sql += " FROM res_responsavel INNER JOIN end_endereco USING (end_id) ORDER BY res_nome";
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
        string sql = "SELECT * FROM res_responsavel WHERE res_id = ?res_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?res_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

}