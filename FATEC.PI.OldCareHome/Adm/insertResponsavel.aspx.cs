using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_insertInternos : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                //lblSessao.Text = Session["nome"].ToString();
                DataSet dsQuarto = QuartoDB.SelectAll();
                ddlQuarto.DataSource = dsQuarto;
                ddlQuarto.DataTextField = "Descrição"; // Nome da coluna do Banco de dados
                ddlQuarto.DataValueField = "Código"; // ID da coluna do Banco
                ddlQuarto.DataBind();
                ddlQuarto.Items.Insert(0, "Selecione");
                ddlEscolaridade.Items.Insert(0, "Selecione");
                ddlMobilidade.Items.Insert(0, "Selecione");
                ddlSituacao.Items.Insert(0, "Selecione");
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/tblInternos.aspx");
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (ddlSituacao.Text == "Selecione" || txtDataEntrada.Text == "" || ddlQuarto.Text == "Selecione" || txtNome.Text == "")
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCampo').modal('show'); </script>", false);
        else
        {
            Internos i = new Internos();
            i.Int_nome = txtNome.Text;
            if (txtDataNascimento.Text != "")
                i.Int_datanascimento = Convert.ToDateTime(txtDataNascimento.Text);
            i.Int_sexo = rbtnSexo.SelectedValue.ToString();
            i.Int_pai = txtPai.Text;
            i.Int_mae = txtMae.Text;
            i.Int_estadocivil = txtEstadoCivil.Text;
            i.Int_profissao = txtProfissao.Text;
            i.Int_escolaridade = ddlEscolaridade.SelectedItem.ToString();
            i.Int_naturalidade = txtNaturalidade.Text;
            i.Int_cpf = txtCpf.Text;
            i.Int_rg = txtRg.Text;
            i.Int_tituloeleitor = txtTitulo.Text;
            i.Int_beneficioinss = txtInss.Text;
            i.Int_planosaude = txtPlanoSaude.Text;
            if (ddlSituacao.SelectedItem.ToString() != "Selecione")
                i.Int_situacao = ddlSituacao.SelectedItem.ToString();
            i.Int_dataentrada = Convert.ToDateTime(txtDataEntrada.Text);
            if (txtDataSituacao.Text != "")
                i.Int_datasituacao = Convert.ToDateTime(txtDataSituacao.Text);

            i.Int_mobilidade = ddlMobilidade.SelectedItem.ToString();
            Quarto q = new Quarto();
            q.Qua_id = Convert.ToInt32(ddlQuarto.SelectedValue);
            i.Qua_id = q;
            Endereco end = new Endereco();
            end.End_id = 1;
            i.End_id = end;


            switch (InternosDB.Insert(i))
            {
                case 0:
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertOk').modal('show'); </script>", false);

                    break;
                case -2:

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                    break;
            }
        }
    }

    protected void btnFecharModal_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adm/tblInternos.aspx");
    }

}