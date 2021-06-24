using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for RegistroClinicoDB
/// </summary>
public class RegistroClinicoDB{
    public static int Insert(RegistroClinico r){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO reg_registroclinico(reg_datainicio, reg_grau, reg_situacao, reg_datasituacao, pat_id, int_id) ";
            sql += "VALUES(?reg_datainicio, ?reg_grau, ?reg_situacao, ?reg_datasituacao, ?pat_id, ?int_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?reg_datainicio", r.Reg_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_grau", r.Reg_grau));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_situacao", r.Reg_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_datasituacao", r.Reg_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?pat_id", r.Pat_id.Pat_id));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", r.Int_id.Int_id));
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

    public static int Update(RegistroClinico r, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE reg_registroclinico SET";
            sql += " reg_datainicio = ?reg_datainicio,";
            sql += " reg_datasituacao = ?reg_datasituacao,";
            sql += " reg_grau = ?reg_grau,";
            sql += " int_id = ?int_id,";
            sql += " pat_id = ?pat_id";
            sql += " WHERE reg_id = ?reg_id";


            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?reg_datainicio", r.Reg_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_datasituacao", r.Reg_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_grau", r.Reg_grau));
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", r.Int_id.Int_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pat_id", r.Pat_id.Pat_id));
            objCommand.Parameters.Add(Mapped.Parameter("?reg_id", id));
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
            string sql = "DELETE FROM reg_registroclinico WHERE reg_id = ?reg_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?reg_id", id));
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
        string sql = "SELECT reg_id AS `Código`,";
        sql += " DATE_FORMAT(reg_datainicio, '%d/%m/%Y') AS `Data de Início`,";
        sql += " DATE_FORMAT(reg_datasituacao, '%d/%m/%Y') AS `Data de Término`,";
        sql += " reg_situcaco AS `Situação`,";
        sql += " int_nome AS `Interno`,";
        sql += " pat_descrocap AS `Patologia`,";
        sql += " pat_resticao AS `Restrição`";
        sql += " FROM reg_registroclinico INNER JOIN  int_internos USING(int_id)";
        sql += " INNER JOIN  pat_patologia USING(pat_id) ORDER BY int_nome";
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
        string sql = "SELECT * FROM reg_registroclinico WHERE reg_id = ?reg_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?reg_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
}