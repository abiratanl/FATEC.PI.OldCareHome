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
        lblTitle.Text = "Cadastro de Quartos";
        CarregarTable();
    }
    protected void CarregarTable(){
        DataSet ds = QuartoDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }

    protected void btnRptEditar_Click(object sender, EventArgs e)
    {

    }

    protected void btnRptExcluir_Click(object sender, EventArgs e)
    {

    }

    protected void btnIncluirUsuario_Click(object sender, EventArgs e)
    {

    }
}