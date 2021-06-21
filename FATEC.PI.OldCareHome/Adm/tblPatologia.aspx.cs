using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Adm_Tables_Patologia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarTable();
    }
    protected void CarregarTable()
    {
        DataSet ds = PatologiaDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }
}