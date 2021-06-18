using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Adm_Teste : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e){
        if (!IsPostBack){ 
            //Carregar um DropDownList com o Banco de Dados
            DataSet ds = TabelasDB.SelectAll();
            ddlTeste.DataSource = ds;
            ddlTeste.DataTextField = "Descrição"; // Nome da coluna do Banco de dados
            ddlTeste.DataValueField = "Tabela"; // ID da coluna do Banco
            ddlTeste.DataBind();
            ddlTeste.Items.Insert(0, "Selecione Tabela");
            CarregarGrid();            
        }
    }

    public void CarregarGrid()  {

        DataSet ds = UsuarioDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0){
            gridTeste.DataSource = ds.Tables[0].DefaultView;
            gridTeste.DataBind();
            gridTeste.Visible = true;
            
        }
        else{
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }
    public void ChangeTable(){
        DataSet ds = UsuarioDB.SelectAll();
        switch (ddlTeste.SelectedValue) {
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
        if (qtd > 0){
            gridTeste.DataSource = ds.Tables[0].DefaultView;
            gridTeste.DataBind();
            gridTeste.Visible = true;

        }
        else
        {
            //gdv.Visible = false;
            //lbl.Text = "Não foram encontrado registros...";
        }
    }

    protected void OnSelectedIndexChanged(object sender, EventArgs e){
        ChangeTable();        
    }
}