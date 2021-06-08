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

    protected void btnSalvar_Click(object sender, EventArgs e){
        Usuario u = new Usuario();
        u.Usu_nome = txtNome.Text;
        u.Usu_email = txtEmail.Text;
        u.Usu_senha = txtSenha.Text;
       // u.Per_id = ddlPerfil.SelectedValue;
        switch (UsuarioDB.Insert(u))
        {
            case 0:
                //ltlMensagem.Text = ">>>>> O K <<<<<<<";
                break;
            case -2:
                //ltlMensagem.Text = ">>>>> ERRO <<<<<<<";
                break;
        }

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }

    
    protected void CarregarTable(){
        DataSet ds = UsuarioDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }
    
}