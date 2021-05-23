﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

/// <summary>
/// Summary description for PerfilDB
/// </summary>
public class PerfilDB{
    public static int Insert(Perfil p){
        
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO per_perfil(per_descricao) VALUES(?per_descricao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?per_descricao", p.Per_descricao));
            // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception)
        {
            return 2;
        }
        return 0;
    }
}