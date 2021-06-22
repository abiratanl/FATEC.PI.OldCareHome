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
        DataSet ds = PatologiaDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }

    protected void btnIncluir_Click(object sender, EventArgs e)
    {
        ltlMsg.Text = "";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsert').modal('show'); </script>", false);
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Patologia p = new Patologia();
        p.Pat_descricao = txtDescricao.Text;
        p.Pat_cid = txtCid.Text;
        p.Pat_restricao = txtRestricao.Text;   

        switch (PatologiaDB.Insert(p))
        {
            case 0:
                CarregarTable();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);               
                break;
            case -2:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                break;
        }
    }

    protected void btnRptEditar_Click(object sender, EventArgs e)
    {
        Session["id"] = ((LinkButton)sender).CommandArgument;
        DataSet ds = PatologiaDB.SelectId(Convert.ToInt32(Session["id"]));
        txtUpdateDescricao.Text = ds.Tables[0].Rows[0]["pat_descricao"].ToString();
        txtUpdateCid.Text = ds.Tables[0].Rows[0]["pat_cid"].ToString();       
        txtUpdateRestricao.Text = ds.Tables[0].Rows[0]["pat_restricao"].ToString();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUpdate').modal('show'); </script>", false);
        
        ltlMsg.Text = "Abre o registro " + Session["id"].ToString() + " para edição";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Patologia p = new Patologia();
        p.Pat_descricao = txtUpdateDescricao.Text;
        p.Pat_cid = txtUpdateCid.Text;
        p.Pat_restricao = txtUpdateRestricao.Text;       
        switch (PatologiaDB.Update(p, Convert.ToInt32(Session["id"])))
        {
            case 0:
                CarregarTable();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUpdateOk').modal('show'); </script>", false);
                // rptTableBody.DataBind();
                break;
            case -2:
                ltlMsg.Text = "<div class='alert alert-danger'><strong> Erro ao editar registro!</strong></ div > ";
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                break;
        }
    }


    protected void btnRptExcluir_Click(object sender, EventArgs e)
    {

        Session["id"] = ((LinkButton)sender).CommandArgument;
        ltlMsg.Text = Session["id"].ToString();
        DataSet ds = PatologiaDB.SelectId(Convert.ToInt32(Session["id"]));
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDelete').modal('show'); </script>", false);
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDelete').modal('show'); </script>", false);
        ltlExcluir.Text = "<strong> Código: " + ds.Tables[0].Rows[0]["pat_id"].ToString() + "<br>Patologia: " + ds.Tables[0].Rows[0]["pat_descricao"].ToString();
        ltlExcluir.Text += "<br>CID: " + ds.Tables[0].Rows[0]["pat_cid"].ToString() + "<br>Restrição: " + ds.Tables[0].Rows[0]["pat_restricao"].ToString() + "</strong>";
        ltlMsg.Text = "Exclui o registro " + Session["id"].ToString();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        switch (PatologiaDB.Delete(Convert.ToInt32(Session["id"])))
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
}