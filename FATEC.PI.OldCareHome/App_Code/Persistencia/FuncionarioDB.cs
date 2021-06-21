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
            string sql = "INSERT INTO fun_funcionario(fun_nome, fun_salario, fun_dataadmissao,fun_datanascimento, fun_datasituacao, fun_sexo, fun_cpf, fun_rg, fun_pis, fun_ctps, sit_id, end_id, car_id) ";
            sql += "VALUES(?fun_nome, ?fun_salario, ?fun_dataadmissao, ?fun_datanascimento, ?fun_datasituacao, ?fun_sexo, ?fun_cpf, ?fun_rg, ?fun_pis, ?fun_ctps, ?sit_id, ?end_id, ?car_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?fun_nome", f.Fun_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_salario", f.Fun_salario));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_dataadmissao", f.Fun_dataadmissao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datanascimento", f.Fun_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_datasituacao", f.Fun_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?fun_sexo", f.Fun_sexo));
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
    public static DataSet SelectAll(){
        string sql = "SELECT fun_id AS `Código`, fun_nome AS `Nome`, DATE_FORMAT(fun_dataadmissao, '%d/%m/%Y') AS `Admissão`, sit_descricao AS `Situação` FROM fun_funcionario INNER JOIN sit_situacao USING(sit_id) ORDER BY fun_nome";
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