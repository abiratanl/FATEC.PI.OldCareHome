using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for TabelasDB
/// </summary>
public class TabelasDB{
    public static DataSet SelectAll(){
        string sql = "SELECT tab_id AS `Código`,  tab_nome AS `Tabela`, tab_descricao AS `Descrição` FROM tab_tabelas ORDER BY `Descrição`";
        
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