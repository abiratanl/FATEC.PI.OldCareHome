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
        if (Session["nome"] == null)
        {
            //Exibir mensagem de erro e redirecionar para login
            Response.Redirect("~/Default.aspx");
        }
        else
        {

            // lblSessao.Text = Session["nome"].ToString();
            if (!IsPostBack)
            {
                //CarregarTable();
            }

        }
        
    }

    protected void CarregarTable(){
        //DataSet ds = UsuarioDB.SelectAll();
       // rptTableBody.DataSource = ds;
       // rptTableBody.DataBind();
    }
}