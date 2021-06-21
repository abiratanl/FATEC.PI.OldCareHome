using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Adm_HomeTabelas : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = "Cadastro de Ocorrências";
        CarregarTable();
    }
    protected void CarregarTable(){
        DataSet ds = OcorrenciaDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }
}