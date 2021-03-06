using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UsuarioDB
/// </summary>
public class UsuarioDB
{
    public static int Insert(Usuario u)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO usu_usuario(usu_nome, usu_email, usu_senha, usu_datacadastro, per_id) ";
            sql += "VALUES(?usu_nome, ?usu_email, ?usu_senha, ?usu_datacadastro, ?per_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_nome", u.Usu_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", u.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", u.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datacadastro", u.Usu_datacadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?per_id", u.Per_id.Per_id));
            // utilizado quando  não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception )
        {
            return -2;
        }
        return 0;
    }


    public static int Update(Usuario u, int id)
    {        
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE usu_usuario SET";
            sql += " usu_nome = ?usu_nome,";
            sql += " usu_email = ?usu_email,";
            sql += " usu_senha = ?usu_senha,";
            sql += " usu_datacadastro = ?usu_datacadastro,";
            sql += " per_id = ?per_id";
            sql += " where usu_id = ?usu_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_nome", u.Usu_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", u.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", u.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datacadastro", u.Usu_datacadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", id));
            objCommand.Parameters.Add(Mapped.Parameter("?per_id", u.Per_id.Per_id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

        }
        catch (Exception ex)
        {
            return -2;
        }
        return  0;
    }
    public static int Delete(int id)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "DELETE FROM usu_usuario WHERE usu_id = ?usu_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", id));
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
        string sql = "SELECT usu_id AS `Código`, usu_nome AS `Nome`, usu_email AS `Email`,  ";
        sql += "DATE_FORMAT(usu_datacadastro, '%d/%m/%Y') AS `Data de Cadastro`, ";
        sql += "per_descricao AS `Perfil`  FROM usu_usuario INNER JOIN  per_perfil USING(per_id) ORDER BY usu_nome";
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
    public static DataSet SelectLogin(string email, string senha){
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select usu_nome, per_descricao from usu_usuario inner join ";
        sql += "per_perfil using(per_id) where usu_email = ?usu_email and usu_senha = ?usu_senha";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?usu_email", email));
        objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", senha));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    public static DataSet SelectId(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "SELECT * FROM usu_usuario WHERE usu_id = ?usu_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?usu_id", id));       
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    public static bool VerificaEmail(string email){
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select * from usu_usuario  where usu_email = ?usu_email ";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?usu_email", email));        
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        if (ds.Tables[0].Rows.Count == 1){
            return true;
        }
        return false;
    }


}

