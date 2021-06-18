﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for PatologiaDB
/// </summary>
public class PatologiaDB{
    public static int Insert(Patologia p){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO pat_patologia(pat_descricao, pat_cid, pat_restricao) VALUES(?pat_descricao, ?pat_cid, ?pat_restricao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pat_descricao", p.Pat_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?pat_cid", p.Pat_cid));
            objCommand.Parameters.Add(Mapped.Parameter("?pat_restricao", p.Pat_restricao));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception ex){
            return -2;
        }
        return 0;
    }

    public static DataSet SelectAll()
    {
        string sql = "SELECT pat_id AS `Código`, pat_descricao AS `Descrição`, pat_cid AS `CID`,  ";
        sql += "pat_restricao AS `Restrição` FROM pat_patologia ORDER BY pat_descricao";

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
    public static bool VerificaPatologia(string patologia)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select * from pat_patologia  where pat_descricao = ?pat_descricao";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?pat_descricao", patologia));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        if (ds.Tables[0].Rows.Count == 1){
            return true;
        }
        return false;
    }
}