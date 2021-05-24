using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DiretorDB
/// </summary>
public class DiretorDB{
    public static int Insert(Diretor d, Endereco e){

        try{
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO dtr_diretor(dtr_nome, dtr_cpf, dtr_rg, end_id) VALUES(?dtr_nome, ?dtr_cpf, ?dtr_rg, ?end_id)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_nome", d.Dtr_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_cpf", d.Dtr_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?dtr_rg", d.Dtr_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", e.End_id));
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