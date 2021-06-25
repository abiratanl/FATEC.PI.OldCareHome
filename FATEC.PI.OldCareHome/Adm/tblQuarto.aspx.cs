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
        Session["id"] = ((LinkButton)sender).CommandArgument;
        DataSet ds = QuartoDB.SelectId(Convert.ToInt32(Session["id"]));
        txtDescricao.Text = ds.Tables[0].Rows[0]["qua_descricao"].ToString();
        txtCapacidade.Text = ds.Tables[0].Rows[0]["qua_capacidade"].ToString();
        rbtnSexo.SelectedValue = ds.Tables[0].Rows[0]["qua_tipo"].ToString();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUpdate').modal('show'); </script>", false);
        
    }

    protected void btnRptExcluir_Click(object sender, EventArgs e)
    {

    }

    protected void btnIncluirUsuario_Click(object sender, EventArgs e)
    {

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Quarto q = new Quarto();
        q.Qua_descricao = txtDescricao.Text;
        q.Qua_capacidade = Convert.ToInt32(txtCapacidade.Text);
        q.Qua_tipo = rbtnSexo.SelectedValue.ToString();
        switch (QuartoDB.Update(q, Convert.ToInt32(Session["id"])))
        {
            case 0:
                CarregarTable();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUpdateOk').modal('show'); </script>", false);
                // rptTableBody.DataBind();
                break;
            case -2:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                break;
        }
    }
}