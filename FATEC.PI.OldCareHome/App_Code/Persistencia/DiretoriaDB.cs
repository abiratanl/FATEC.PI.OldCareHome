using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DiretoriaDB
/// </summary>
public class DiretoriaDB
{
    public static int Insert(Diretoria d){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO dir_diretoria(dir_datainicio, dir_datatermino, dtr_id, car_id) ";
            sql += "VALUES(?dir_datainicio, ?dir_datatermino, ?dtr_id, ?car_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datainicio", d.Dir_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datatermino", d.Dir_datatermino));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", d.Dtr_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", d.Car_id.Car_id));
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



    public static int Update(Diretoria d, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE dir_diretoria SET";
            sql += " dir_datainicio = ?dir_datainicio,";
            sql += " dir_datatermino = ?dir_datatermino,";
            sql += " dtr_id = ?dtr_id,";
            sql += " car_id = ?car_id";
            sql += " WHERE dir_id = ?dir_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datainicio", d.Dir_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?dir_datatermino", d.Dir_datatermino));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_id", d.Dtr_id.Dtr_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", d.Car_id.Car_id));
            objCommand.Parameters.Add(Mapped.Parameter("?dir_id", id));
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
            string sql = "DELETE FROM dir_diretoria WHERE dir_id = ?dir_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?dir_id", id));
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
        string sql = "SELECT dir_id AS `Código`, DATE_FORMAT(dir_datainicio, '%d/%m/%Y') AS `Data de Início`,";
        sql += " DATE_FORMAT(dir_datatermino, '%d/%m/%Y') AS `Data de Término`,";
        sql += " dtr_nome AS `Diretor`, car_descricao AS `Cargo` FROM dir_diretoria INNER JOIN  dtr_diretor USING(dtr_id)";
        sql += " INNER JOIN  car_cargo USING(car_id) ORDER BY dtr_nome";
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
        string sql = "SELECT * FROM dir_diretoria WHERE dir_id = ?dir_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?dir_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
}