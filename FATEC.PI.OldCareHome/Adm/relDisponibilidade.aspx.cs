using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_Tables_Usuario : System.Web.UI.Page
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
        DataSet ds = QuartoDB.Disponibilidade();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }




    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/tblInternos.aspx");
    }
}



