using System;
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

    public static DataSet SelectAll()
    {
        string sql = "SELECT pro_id AS `Código`, pro_descricao AS `Produto`, pro_unidade AS Unidade, pro_emuso AS `Em Uso` FROM pro_produto;";
        
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