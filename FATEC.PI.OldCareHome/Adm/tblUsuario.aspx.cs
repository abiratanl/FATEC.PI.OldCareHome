using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
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
        DataSet ds = UsuarioDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }

    protected void btnIncluirUsuario_Click(object sender, EventArgs e)
    {
        ltlMsg.Text = "";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsert').modal('show'); </script>", false);
        txtUsuarioNome.Text = "";
        txtUsuarioEmail.Text = "";
        txtUsuarioSenha.Text = "";
        txtUsuarioDataCadastro.Text = "";
        //Carregar um DropDownList com o Banco de Dados
        DataSet ds = PerfilDB.SelectAll();
        ddlPerfil.DataSource = ds;
        ddlPerfil.DataTextField = "Perfil";
        ddlPerfil.DataValueField = "Código";
        ddlPerfil.DataBind();
        //ddlPerfil.Items.Insert(0, "Selecione");
       // ddlPerfil.SelectedItem.Value = "Secretaria";
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        if (UsuarioDB.VerificaEmail(txtUsuarioEmail.Text))
        {
            // Email já cadastrado
            ltlMensagem.Text = "<strong> Erro ao inserir usuário. Email já cadastrado.</strong>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
            return;

        }
        Usuario u = new Usuario();
        u.Usu_nome = txtUsuarioNome.Text;
        u.Usu_email = txtUsuarioEmail.Text;
        u.Usu_senha = Functions.HashTexto(txtUsuarioSenha.Text);
        u.Usu_datacadastro = Convert.ToDateTime(txtUsuarioDataCadastro.Text);

        Perfil p = new Perfil();
        p.Per_id = Convert.ToInt32(ddlPerfil.SelectedValue);
        u.Per_id = p;


        switch (UsuarioDB.Insert(u))
        {
            case 0:
                CarregarTable();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);
                //rptTableBody.DataBind();
                break;
            case -2:

                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                break;
        }
    }

    protected void btnRptEditar_Click(object sender, EventArgs e)
    {
        Session["id"] = ((LinkButton)sender).CommandArgument;
        DataSet ds = UsuarioDB.SelectId(Convert.ToInt32(Session["id"]));
        txtUpdateNome.Text = ds.Tables[0].Rows[0]["usu_nome"].ToString();
        txtUpdateEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
        DateTime d = Convert.ToDateTime(ds.Tables[0].Rows[0]["usu_datacadastro"].ToString());
        txtUpdateDataCadastro.Text = d.ToString(@"yyyy-MM-dd");
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalUpdate').modal('show'); </script>", false);
        DataSet dsPerfil = PerfilDB.SelectAll();
        ddlUpdatePerfil.DataSource = dsPerfil;
        ddlUpdatePerfil.DataTextField = "Perfil"; // Nome da coluna do Banco de dados
        ddlUpdatePerfil.DataValueField = "Código"; // ID da coluna do Banco
        ddlUpdatePerfil.DataBind();
        ddlUpdatePerfil.SelectedValue = ds.Tables[0].Rows[0]["per_id"].ToString();
        ltlMsg.Text = "Abre o registro " + Session["id"].ToString() + " para edição";
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Usuario u = new Usuario();
        u.Usu_nome = txtUpdateNome.Text;
        u.Usu_email = txtUpdateEmail.Text;
        u.Usu_senha = Functions.HashTexto(txtUpdateSenha.Text);
        u.Usu_datacadastro = Convert.ToDateTime(txtUpdateDataCadastro.Text);
        Perfil p = new Perfil();
        p.Per_id = Convert.ToInt32(ddlUpdatePerfil.SelectedValue);
        u.Per_id = p;
        switch (UsuarioDB.Update(u, Convert.ToInt32(Session["id"])))
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
        DataSet ds = UsuarioDB.SelectId(Convert.ToInt32(Session["id"]));
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDelete').modal('show'); </script>", false);
        ltlExcluir.Text = "<strong> Código: " + ds.Tables[0].Rows[0]["usu_id"].ToString() + "<br>Nome: " + ds.Tables[0].Rows[0]["usu_nome"].ToString();
        ltlExcluir.Text += "<br>Email: " + ds.Tables[0].Rows[0]["usu_email"].ToString() + "<br>Data de Cadastro: " + DateTime.Parse(ds.Tables[0].Rows[0]["usu_datacadastro"].ToString()).ToString("dd/MM/yyyy") + "</strong>";
        ltlMsg.Text = "Exclui o registro " + Session["id"].ToString();
    }
   
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        switch (UsuarioDB.Delete(Convert.ToInt32(Session["id"])))
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
   


