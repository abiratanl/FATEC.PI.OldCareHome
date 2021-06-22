using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DiretorDB
/// </summary>
public class DiretorDB{
    public static int Insert(Diretor d){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO dtr_diretor(dtr_nome, dtr_cpf, dtr_rg, end_id) VALUES(?dtr_nome, ?dtr_cpf, ?dtr_rg, ?end_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_nome", d.Dtr_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_cpf", d.Dtr_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_rg", d.Dtr_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", d.End_id.End_id));
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


    public static int Update(Diretor d, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE dtr_diretor SET";
            sql += " dtr_nome= ?dtr_nome,";
            sql += " dtr_cpf = ?dtr_cpf,";
            sql += " dtr_rg = ?dtr_rg,";
            sql += " end_id = ?end_id";
            sql += " WHERE dtr_id = ?dtr_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_nome", d.Dtr_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_cpf", d.Dtr_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_rg", d.Dtr_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", id));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", d.End_id.End_id));
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
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "DELETE FROM dtr_diretor WHERE dtr_id = ?dtr_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", id));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception ex)
        {
            return -2;
        }
        return 0;
    }
    public static DataSet SelectAll()
    {
        string sql = "SELECT dtr_id AS `Código`, dtr_nome AS `Nome`, dtr_cpf AS `CPF`,";        
        sql += " dtr_rg AS `RG` end_descricao FROM dtr_diretor INNER JOIN  end_endereco USING(end_id) ORDER BY dtr_nome";
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
        string sql = "SELECT * FROM dtr_diretor WHERE dtr_id = ?dtr_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    


}

