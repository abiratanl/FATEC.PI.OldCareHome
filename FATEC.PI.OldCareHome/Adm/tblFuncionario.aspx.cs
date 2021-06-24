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
        if (Session["nome"] == null)
        {
            //Exibir mensagem de erro e redirecionar para login
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            lblSessao.Text = Session["nome"].ToString();
            if (!IsPostBack)
            {
                lblSessao.Text = Session["nome"].ToString();
                CarregarTable();
            }
        }
    }
    protected void CarregarTable()
    {
        DataSet ds = FuncionarioDB.SelectAll();
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