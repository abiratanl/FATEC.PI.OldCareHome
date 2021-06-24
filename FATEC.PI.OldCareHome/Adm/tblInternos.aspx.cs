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
        DataSet ds = InternosDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }

    protected void btnIncluirUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/insertInternos.aspx");        
    }
    

    protected void btnRptEditar_Click(object sender, EventArgs e)
    {
        Session["id"] = ((LinkButton)sender).CommandArgument;
        Response.Redirect("~/adm/editInternos.aspx");        
        
    }
   
    protected void btnRptExcluir_Click(object sender, EventArgs e)
    {

        Session["id"] = ((LinkButton)sender).CommandArgument;        
        DataSet ds = InternosDB.SelectId(Convert.ToInt32(Session["id"]));
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDelete').modal('show'); </script>", false);
        ltlExcluir.Text = "<strong> Código: " + ds.Tables[0].Rows[0]["int_id"].ToString() + "<br>Nome: " + ds.Tables[0].Rows[0]["int_nome"].ToString();
        ltlExcluir.Text += "<br>Sexo: " + ds.Tables[0].Rows[0]["int_sexo"].ToString() + "<br>Data de Nascimento: " + DateTime.Parse(ds.Tables[0].Rows[0]["int_datanascimento"].ToString()).ToString("dd/MM/yyyy") + "</strong>";
        ltlMsg.Text = "Exclui o registro " + Session["id"].ToString();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        switch (InternosDB.Delete(Convert.ToInt32(Session["id"])))
        {
            case 0:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDeleteOk').modal('show'); </script>", false);
                CarregarTable();
                break;
            case -2:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                break;
        }
    }

    protected void btnAdicionar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/insertInternos.aspx");
    }
}



