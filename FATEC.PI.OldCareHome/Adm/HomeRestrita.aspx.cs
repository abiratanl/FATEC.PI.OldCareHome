using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
public partial class Adm_HomeRestrita : System.Web.UI.Page{
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
            if (!IsPostBack){                
                lblTitle.Text = "Cadastro de Usuários";
                CarregarTable();
            }
        }
    }
    public void CarregarGrid()
    {
        DataSet ds = UsuarioDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            //gridMain.DataSource = ds.Tables[0].DefaultView;
           // gridMain.DataBind();
            //gridMain.Visible = true;
            //lbl.Text = "Foram encontrados " + qtd + " de registros";
        }
        else
        {
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }



    protected void btnAdicionar_Click(object sender, EventArgs e){
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUsuarios').modal('show'); </script>", false);
    }

    

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }

    
    protected void CarregarTable(){
        DataSet ds = UsuarioDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void btnSalvarPatologia_Click(object sender, EventArgs e){
        Patologia p = new Patologia();
        p.Pat_descricao = txtPatologia.Text;
        p.Pat_cid = txtCid.Text;
        p.Pat_restricao = txtRestricao.Text;
        // u.Per_id = ddlPerfil.SelectedValue;
        switch (PatologiaDB.Insert(p))
        {
            case 0:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);
                break;
            case -2:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                break;
        }
    }

    protected void btnInsertQuarto_Click(object sender, EventArgs e){
        Quarto q = new Quarto();
        q.Qua_descricao = txtQuartoDescricao.Text;
        q.Qua_capacidade = Convert.ToInt32(txtQuartoCapacidade.Text);
        q.Qua_tipo = txtQuartoTipo.Text;     



        switch (QuartoDB.Insert(q))
        {
            case 0:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);

                break;
            case -2:

                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                break;
        }
    }
}