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
}