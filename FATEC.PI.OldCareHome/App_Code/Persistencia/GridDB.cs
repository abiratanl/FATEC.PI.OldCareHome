using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for GridDB
/// </summary>
public class GridDB{
    public static DataSet SelectAll(String sql){         
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