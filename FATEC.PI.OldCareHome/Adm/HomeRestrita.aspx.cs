using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
public partial class Adm_HomeRestrita : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null)
        {
            //Exibir mensagem de erro e redirecionar para login
            Response.Redirect("~/Default.aspx");
        }
        else {

            lblSessao.Text = Session["nome"].ToString();
            if (!IsPostBack) {
                //lblTitle.Text = "Usuários Cadastrados";
                //CarregarTable();
                CarregarGrid();          

                //Carregar um DropDownList com o Banco de Dados
                DataSet ds = TabelasDB.SelectAll();
                ddlTabelas.DataSource = ds;
                ddlTabelas.DataTextField = "Descrição"; // Nome da coluna do Banco de dados
                ddlTabelas.DataValueField = "Tabela"; // ID da coluna do Banco
                ddlTabelas.DataBind();
                ddlTabelas.Items.Insert(0, "Selecione Tabela");
            }

        }
    }
    public void CarregarGrid()
    {
        DataSet ds = UsuarioDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gridMain.DataSource = ds.Tables[0].DefaultView;
            gridMain.DataBind();
            gridMain.Visible = true;

        }
        else
        {
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }



    protected void btnAdicionar_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertUsuario').modal('show'); </script>", false);
        //Carregar um DropDownList com o Banco de Dados
        DataSet ds = PerfilDB.SelectAll();
        ddlPerfil.DataSource = ds;
        ddlPerfil.DataTextField = "Perfil"; // Nome da coluna do Banco de dados
        ddlPerfil.DataValueField = "Código"; // ID da coluna do Banco
        ddlPerfil.DataBind();
        //ddlPerfil.Items.Insert(0, "Selecione");
        ddlPerfil.SelectedItem.Value = "Secretaria";
    }



    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }


    //protected void CarregarTable(){
    //    DataSet ds = UsuarioDB.SelectAll();
    //    rptTableBody.DataSource = ds;
    //    rptTableBody.DataBind();
    //}




    protected void btnSalvarPatologia_Click(object sender, EventArgs e){
        if (PatologiaDB.VerificaPatologia(txtPatologia.Text))
        {
            // Patologia já cadastrada
            ltlMensagem.Text = "<strong> Erro ao inserir. Patologia já cadastrada.</strong>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
            txtPatologia.Focus();
            

        }

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

    protected void btnInsertQuarto_Click(object sender, EventArgs e)
    {
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



    protected void btnSalvarUsuario_Click(object sender, EventArgs e){
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
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);

                break;
            case -2:                

               Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                
                break;
        }
    }

    public void ChangeTable()
    {
        DataSet ds = UsuarioDB.SelectAll();
        switch (ddlTabelas.SelectedValue)
        {
            case "usu_usuario":
                ds = UsuarioDB.SelectAll();
                break;
            case "pat_patologia":
                ds = PatologiaDB.SelectAll();
                break;
            case "qua_quarto":
                ds = QuartoDB.SelectAll();
                break;
            case "int_internos":
                ds = InternosDB.SelectAll();
                break;
            case "res_responsavel":
                ds = ResponsavelDB.SelectAll();
                break;
            case "fun_funcionario":
                ds = FuncionarioDB.SelectGrid();
                break;
        }
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gridMain.DataSource = ds.Tables[0].DefaultView;
            gridMain.DataBind();
            gridMain.Visible = true;

        }
        else
        {
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }

    

    protected void ddlTabelas_SelectedIndexChanged(object sender, EventArgs e){
        ChangeTable();
        //lblTitle.Text = "Cadastro de " +  ddlTabelas.SelectedItem;
        //lblMsg.Text = ddlTabelas.SelectedValue;
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {

    }

    protected void btnExcluir_Click1(object sender, EventArgs e)
    {

    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalPatologia').modal('show'); </script>", false);
    }
}