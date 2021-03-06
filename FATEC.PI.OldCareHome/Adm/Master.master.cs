using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Adm_Master : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //lblTitle.Text = "Usuários Cadastrados";
            //CarregarTable();
            //CarregarGrid();

            //Carregar um DropDownList com o Banco de Dados
            DataSet ds = TabelasDB.SelectAll();
            ddlTabelas.DataSource = ds;
            ddlTabelas.DataTextField = "Descrição"; // Nome da coluna do Banco de dados
            ddlTabelas.DataValueField = "Tabela"; // ID da coluna do Banco
            ddlTabelas.DataBind();
            ddlTabelas.Items.Insert(0, "Selecione Tabela");
        }

    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        Session.Remove("perfil");
        Response.Redirect("~/Default.aspx");
    }



    protected void btnMenuPatologia_Click(object sender, EventArgs e)
    {
       // Response.Redirect("~/adm/insertPatologia.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalPatologia').modal('show'); </script>", false);
    }

    protected void btnMenuQuarto_Click(object sender, EventArgs e)
    {
       // Response.Redirect("~/adm/insertQuarto.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertQuarto').modal('show'); </script>", false);
    }

    protected void btnInsertUsuario_Click(object sender, EventArgs e)
    {
       // Response.Redirect("~/adm/insertUsuario.aspx");
        // Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertUsuario').modal('show'); </script>", false);        
    }
    public void ChangeTable()
    {
        DataSet ds = UsuarioDB.SelectAll();
        switch (ddlTabelas.SelectedValue)
        {
            case "usu_usuario":
                //ds = UsuarioDB.SelectAll();
                Response.Redirect("~/adm/tblUsuario.aspx");
                break;
            case "pat_patologia":
                //ds = PatologiaDB.SelectAll();
                Response.Redirect("~/adm/tblPatologia.aspx");
                break;
            case "qua_quarto":
                Response.Redirect("~/adm/tblQuarto.aspx");               
                break;
            case "pro_produto":
                Response.Redirect("~/adm/tblProduto.aspx");               
                break;
            case "oco_ocorrencia":
                Response.Redirect("~/adm/tblOcorrencia.aspx");
                break;
            case "per_perfil":
                Response.Redirect("~/adm/tblPerfil.aspx");
                break;
            case "fun_funcionario":
                Response.Redirect("~/adm/tblFuncionario.aspx");
                break;
            case "int_internos":
                Response.Redirect("~/adm/tblInternos.aspx");
                break;
            case "res_responsavel":
                Response.Redirect("~/adm/tblResponsavel.aspx");
                break;
        }        
    }



    protected void ddlTabelas_SelectedIndexChanged(object sender, EventArgs e)
    {
        ChangeTable();
    }

    protected void btnDisponibilidade_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/relDisponibilidade.aspx");
    }

    protected void btnRestricoes_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/relRestricoes.aspx");
    }
}
