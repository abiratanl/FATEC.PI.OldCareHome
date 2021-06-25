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
        Response.Redirect("~/adm/insertPatologia.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalPatologia').modal('show'); </script>", false);
    }

    protected void btnMenuQuarto_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/insertQuarto.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertQuarto').modal('show'); </script>", false);
    }

    protected void btnInsertUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/insertUsuario.aspx");
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
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            //gridMain.DataSource = ds.Tables[0].DefaultView;
            //gridMain.DataBind();
            //gridMain.Visible = true;

        }
        else
        {
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }



    protected void ddlTabelas_SelectedIndexChanged(object sender, EventArgs e)
    {
        ChangeTable();
        //lblTitle.Text = "Cadastro de " +  ddlTabelas.SelectedItem;
        //lblMsg.Text = ddlTabelas.SelectedValue;
    }

    protected void btnDisponibilidade_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalDisponibilidade').modal('show'); </script>", false);
        DataSet ds = QuartoDB.Disponibilidade();
        lblCapacidadeM.Text = ds.Tables[0].Rows[0]["Capacidade"].ToString();
        lblCapacidadeF.Text = ds.Tables[0].Rows[1]["Capacidade"].ToString();
        lblOcupacaoM.Text = ds.Tables[0].Rows[0]["Ocupação"].ToString();
        lblOcupacaoF.Text = ds.Tables[0].Rows[1]["Ocupação"].ToString();
        lblDisponivelM.Text = ds.Tables[0].Rows[0]["Disponível"].ToString();
        lblDisponivelF.Text = ds.Tables[0].Rows[1]["Disponível"].ToString();        
       
    }
}
