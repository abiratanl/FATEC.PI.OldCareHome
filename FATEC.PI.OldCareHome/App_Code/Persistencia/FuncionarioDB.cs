using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for FuncionarioDB
/// </summary>
public class FuncionarioDB{
    public static int Insert(Funcionario f){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO fun_funcionario(fun_nome, fun_salario, fun_dataadmissao,fun_datanascimento,"; 
            sql += " fun_datasituacao, fun_sexo, fun_cpf, fun_rg, fun_pis, fun_ctps, sit_id, end_id, car_id)";
            sql += " VALUES(?fun_nome, ?fun_salario, ?fun_dataadmissao, ?fun_datanascimento, ?fun_datasituacao,"; 
            sql += " ?fun_sexo, ?fun_cpf, ?fun_rg, ?fun_pis, ?fun_ctps, ?sit_id, ?end_id, ?car_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?fun_nome", f.Fun_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_salario", f.Fun_salario));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_dataadmissao", f.Fun_dataadmissao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datanascimento", f.Fun_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datasituacao", f.Fun_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_sexo", f.Fun_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_rg", f.Fun_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_pis", f.Fun_pis));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_ctps", f.Fun_ctps));
            objCommand.Parameters.Add(Mapped.Parameter("?sit_id", f.Sit_id.Sit_id));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", f.End_id.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", f.Car_id.Car_id));
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

    public static int Update(Funcionario f, int id)    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE fun_funcionario SET";
            sql += " fun_nome = ?fun_nome,";
            sql += " fun_salario ?fun_salario,";
            sql += " fun_datanascimento ?fun_datanascimento,";
            sql += " fun_dataadmissao ?fun_dataadmissao,";
            sql += " fun_datasituacao ?fun_datasituacao,";
            sql += " fun_cpf ?fun_cpf,";
            sql += " fun_rg ?fun_rg,";
            sql += " fun_pis ?fun_pis,";
            sql += " fun_ctps ?fun_ctps,";
            sql += " fun_sexo ?fun_sexo,";
            sql += " end_id ?end_id,";
            sql += " car_id ?car_id,";            
            sql += " sit_id ?sit_id";
            sql += " WHERE fun_id = ?fun_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?fun_nome", f.Fun_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_salario", f.Fun_salario));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datanascimento", f.Fun_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_dataadmissao", f.Fun_dataadmissao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datasituacao", f.Fun_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_cpf", f.Fun_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_rg", f.Fun_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_pis", f.Fun_pis));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_ctps", f.Fun_ctps));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_sexo", f.Fun_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", f.End_id.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", f.Car_id.Car_id));
            objCommand.Parameters.Add(Mapped.Parameter("?sit_id", f.Sit_id.Sit_id));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_id", id));
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

    public static DataSet SelectGrid() {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM fun_funcionario ORDER BY fun_nome", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        // O objeto DataAdapter vai preencher o DataSet com os dados do BD.
        objDataAdapter.Fill(ds); // O método Fill é o responsável por preencher o DataSet
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Delete(int id)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "DELETE FROM fun_funcionario WHERE fun_id = ?fun_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?fun_id", id));
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
        string sql = "SELECT fun_id AS `Código`,";
        sql += " fun_nome AS `Nome`,";
        sql += " DATE_FORMAT(fun_dataadmissao, '%d/%m/%Y') AS `Data de Admissão`,";
        sql += " fun_salario AS `Salário`,";
        sql += " DATE_FORMAT(fun_datasituacao, '%d/%m/%Y') AS `Data da Situação`,";
        sql += " DATE_FORMAT(fun_datanascimento, '%d/%m/%Y') AS `Data de Nascimento`,";
        sql += " fun_cpf AS `CPF`,";
        sql += " fun_rg AS `RG`,";
        sql += " fun_pis AS `PIS`,";
        sql += " fun_ctps AS `CTPS`,";
        sql += " fun_sexo AS `Sexo`,";
        sql += " end_id AS `Endereço`,";                        
        sql += " sit_descricao AS `Situação`,"; ;
        sql += " car_descricao AS `Cargo`";
        sql += " FROM fun_funcionario INNER JOIN sit_situacao USING(sit_id)";
        sql += " INNER JOIN car_cargo USING (car_id) INNER JOIN end_endereco USING (end_id) ORDER BY fun_nome"; 

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
        string sql = "SELECT * FROM fun_funcionario WHERE fun_id = ?fun_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?fun_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }
}