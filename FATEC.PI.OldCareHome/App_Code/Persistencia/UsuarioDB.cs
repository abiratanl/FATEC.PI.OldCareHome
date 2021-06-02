using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UsuarioDB
/// </summary>
public class UsuarioDB{
    public static int Insert(Usuario u){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO usu_usuario(usu_nome, usu_email, usu_senha, usu_situacao, usu_datacadastro, usu_datasituacao, usu_trocarsenha) ";
            sql += "VALUES(?usu_nome, ?usu_email, ?usu_senha, ?usu_situacao, ?usu_datacadastro, ?usu_datasituacao, ?usu_trocarsenha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_nome", u.Usu_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", u.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", u.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_situacao", u.Usu_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datacadastro", u.Usu_datacadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datasituacao", u.Usu_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_trocarsenha", u.Usu_trocarsenha));
            // utilizado quando  não tem retorno, como seria o caso do SELECT
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
    public static DataSet SelectAll()    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM usu_usuario ORDER BY usu_nome ",
        objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        // O objeto DataAdapter vai preencher o DataSet com os dados do BD.
        objDataAdapter.Fill(ds); // O método Fill é o responsável por preencher o DataSet
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    public static DataSet SelectEmail(string email){
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        string sql = "select * from usu_usuario where usu_email = ?email;";
        objCommand = Mapped.Command(sql, objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?email", email)); // única diferença do select comum
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}

