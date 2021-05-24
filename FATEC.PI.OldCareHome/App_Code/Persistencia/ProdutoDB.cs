﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for ProdutoDB
/// </summary>
public class ProdutoDB{
    public static int Insert(Produto p){

        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO pro_produto(pro_descricao, pro_unidade, pro_emuso) VALUES(?pro_descricao, ?pro_unidade, ?pro_emuso)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pro_descricao", p.Pro_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_unidade", p.Pro_unidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_emuso", p.Pro_emuso));
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