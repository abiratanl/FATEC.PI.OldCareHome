using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for InternoDB
/// </summary>
public class InternosDB{
    public static int Insert(Internos i){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO int_interno(int_nome, int_datanascimento, int_sexo, int_pai, int_mae, int_estadocivil, int_profissao, int_escolaridade, int_naturalidade, int_cpf, int_rg, int_tituloeleitor, int_beneficioinss, int_planosaude, int_situacao, int_dataentrada, int_datasituacao, int_mobilidade, qua_id, end_id) ";
            sql += "VALUES(?int_nome, ?int_datanascimento, ?int_sexo, ?int_pai, ?int_mae, ?int_estadocivil, ?int_profissao, ?int_escolaridade, ?int_naturalidade, ?int_cpf, ?int_rg, ?int_tituloeleitor, ?int_beneficioinss, ?int_planosaude, ?int_situacao, ?int_dataentrada, ?int_datasituacao, ?int_mobilidade, ?qua_id, ?end_id)"; 
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?int_nome", i.Int_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?int_datanascimento", i.Int_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?int_sexo", i.Int_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?int_pai", i.Int_pai));
            objCommand.Parameters.Add(Mapped.Parameter("?int_mae", i.Int_mae));
            objCommand.Parameters.Add(Mapped.Parameter("?int_estadocivil", i.Int_estadocivil));
            objCommand.Parameters.Add(Mapped.Parameter("?int_profissao", i.Int_profissao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_escolaridade", i.Int_escolaridade));
            objCommand.Parameters.Add(Mapped.Parameter("?int_naturalidade", i.Int_naturalidade));
            objCommand.Parameters.Add(Mapped.Parameter("?int_cpf", i.Int_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?int_rg", i.Int_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?int_tituloeleitor", i.Int_tituloeleitor));
            objCommand.Parameters.Add(Mapped.Parameter("?int_beneficioinss", i.Int_beneficioinss));
            objCommand.Parameters.Add(Mapped.Parameter("?int_planosaude", i.Int_planosaude));
            objCommand.Parameters.Add(Mapped.Parameter("?int_situacao", i.Int_situacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_dataentrada", i.Int_dataentrada));
            objCommand.Parameters.Add(Mapped.Parameter("?int_datasituacao", i.Int_datasituacao));
            objCommand.Parameters.Add(Mapped.Parameter("?int_mobilidade", i.Int_mobilidade));
            objCommand.Parameters.Add(Mapped.Parameter("?qua_id", i.Qua_id.Qua_id));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", i.End_id.End_id));
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
    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM int_internos ORDER BY int_nome", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        // O objeto DataAdapter vai preencher o DataSet com os dados do BD.
        objDataAdapter.Fill(ds); // O método Fill é o responsável por preencher o DataSet
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}