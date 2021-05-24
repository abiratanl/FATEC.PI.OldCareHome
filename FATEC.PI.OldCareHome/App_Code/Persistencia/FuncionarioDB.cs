using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for FuncionarioDB
/// </summary>
public class FuncionarioDB{
    public static int Insert(Funcionario f, Endereco e, Situacao s, Cargo c){

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
            objCommand.Parameters.Add(Mapped.Parameter("?sit_id", s.Sit_id));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", e.End_id));
            objCommand.Parameters.Add(Mapped.Parameter("?car_id", c.Car_id));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception){
            return 2;
        }
        return 0;
    }
}