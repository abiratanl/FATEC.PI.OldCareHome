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
            string sql = "INSERT INTO int_internos(int_nome, int_datanascimento, int_sexo, int_pai, int_mae, int_estadocivil, int_profissao, int_escolaridade, int_naturalidade, int_cpf, int_rg, int_tituloeleitor, int_beneficioinss, int_planosaude, int_situacao, int_dataentrada, int_datasituacao, int_mobilidade, qua_id, end_id)";
            sql += " VALUES(?int_nome, ?int_datanascimento, ?int_sexo, ?int_pai, ?int_mae, ?int_estadocivil, ?int_profissao, ?int_escolaridade, ?int_naturalidade, ?int_cpf, ?int_rg, ?int_tituloeleitor, ?int_beneficioinss, ?int_planosaude, ?int_situacao, ?int_dataentrada, ?int_datasituacao, ?int_mobilidade, ?qua_id, ?end_id)"; 
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


    public static int Update(Internos i, int id)
    {
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE int_internos SET";
            sql += " int_nome = ?int_nome,";
            sql += " int_datanascimento = ?int_datanascimento,";
            sql += " int_sexo = ?int_sexo,";
            sql += " int_pai = ?int_pai,";
            sql += " int_mae = ?int_mae,";
            sql += " int_estadocivil = ?int_estadocivil,";
            sql += " int_profissao = ?int_profissao,";
            sql += " int_escolaridade = ?int_escolaridade,";
            sql += " int_naturalidade = ?int_naturalidade,";
            sql += " int_cpf = ?int_cpf,";
            sql += " int_rg = ?int_rg,";
            sql += " int_tituloeleitor = ?int_tituloeleitor,";
            sql += " int_beneficioinss = ?int_beneficioinss,";
            sql += " int_planosaude = ?int_planosaude,";
            sql += " int_situacao = ?int_situacao,";
            sql += " int_dataentrada = ?int_dataentrada,";
            sql += " int_datasituacao = ?int_datasituacao,";
            sql += " int_mobilidade = ?int_mobilidade,";
            sql += " qua_id = ?qua_id,";
            sql += " end_id = ?end_id";
            sql += " WHERE int_id = ?int_id";            

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
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", id));
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
            string sql = "DELETE FROM int_internos WHERE int_id = ?int_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?int_id", id));
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
        string sql = "SELECT int_id AS `Código`,";
        sql += " int_nome AS `Nome`,";
        sql += " DATE_FORMAT(int_datanascimento, '%d/%m/%Y') AS `Data de Nascimento`,";
        sql += " int_sexo AS `Sexo`,";
        sql += " int_pai AS `Pai`,";
        sql += " int_mae AS `Mãe`,";
        sql += " int_estadocivil AS `Estado Civil`,";
        sql += " int_profissao AS `Profissão`,";
        sql += " int_escolaridade AS `Escolaridade`,";
        sql += " int_naturalidade AS `Naturalidade`,";
        sql += " int_cpf AS `CPF`,";
        sql += " int_rg AS `RG`,";
        sql += " int_tituloeleitor AS `Título de Eleitor`,";
        sql += " int_beneficioinss AS `Número Benefício`,";
        sql += " int_planosaude AS `Plano de Saúde`,";
        sql += " int_situacao AS `Situação`,";
        sql += " DATE_FORMAT(int_dataentrada, '%d/%m/%Y') AS `Data de Entrada`,";
        sql += " DATE_FORMAT(int_datasituacao, '%d/%m/%Y') AS `Data da Situação`,";
        sql += " int_mobilidade AS `Mobilidade`,";
        sql += " qua_id AS `Quarto`,";
        sql += " end_id AS `Endereço`";
        sql += " FROM int_internos ORDER BY int_nome";
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
        string sql = "SELECT * FROM int_internos WHERE int_id = ?int_id";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?int_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

    public static DataSet Restricoes()
    {
        string sql = "SELECT int_nome AS `Interno`, pat_descricao AS `Patologia`, pat_restricao AS `Restrição`";
        sql += " FROM int_internos INNER JOIN reg_registroclinico USING(int_id) INNER JOIN pat_patologia USING(pat_id) ORDER BY Interno; ";        
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