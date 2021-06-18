using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Adm_insertUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        lblSessao.Text = Session["nome"].ToString();
        if (!IsPostBack)
        {
            //Carregar um DropDownList com o Banco de Dados
            DataSet ds = PerfilDB.SelectAll();
            ddlPerfil.DataSource = ds;
            ddlPerfil.DataTextField = "Perfil"; // Nome da coluna do Banco de dados
            ddlPerfil.DataValueField = "Código"; // ID da coluna do Banco
            ddlPerfil.DataBind();
            ddlPerfil.Items.Insert(0, "Selecione");
        }

    }

    protected void btnInsertUsuarioVoltar_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/HomeRestrita.aspx");
    }

    protected void btnInsertUsuarioCadastrar_Click(object sender, EventArgs e){
        if (UsuarioDB.VerificaEmail(txtInsertUsuarioEmail.Text))
        {
            // Email já cadastrado
            ltlMensagem.Text = "<strong> Erro ao inserir usuário. Email já cadastrado.</strong>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
            txtInsertUsuarioEmail.Focus();
            return;

        }
        Usuario u = new Usuario();         
        u.Usu_nome = txtInsertUsuarioNome.Text ;
        u.Usu_email = txtInsertUsuarioEmail.Text;
        u.Usu_senha = Functions.HashTexto(txtInsertUsuarioSenha.Text);
        u.Usu_datacadastro = Convert.ToDateTime(txtDataCadastro.Text);

        Perfil p = new Perfil();
        p.Per_id = Convert.ToInt32(ddlPerfil.SelectedValue);
        u.Per_id = p;


        switch (UsuarioDB.Insert(u)){
            case 0:                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);
                
                break;
            case -2:
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                
                break;
        }
        txtInsertUsuarioNome.Text = "";
        txtInsertUsuarioEmail.Text = "";
        txtInsertUsuarioSenha.Text = "";
        txtDataCadastro.Text = "";
    }
}