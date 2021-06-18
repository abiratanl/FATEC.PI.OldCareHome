using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_insertQuarto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        if (Session["nome"] == null){
            //Exibir mensagem de erro e redirecionar para login
            Response.Redirect("~/Default.aspx");
        }
        else{
            lblSessao.Text = Session["nome"].ToString();
        }
    }

    protected void btnInsertQuartoVoltar_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/HomeRestrita.aspx");
    }

    

    protected void btnInsertQuartoCadastrar_Click(object sender, EventArgs e){
        Quarto q = new Quarto();
        q.Qua_descricao = txtInsertQuartoDescricao.Text;
        q.Qua_tipo = txtInsertQuartoTipo.Text;
        q.Qua_capacidade = Convert.ToInt32(txtInsertQuartoCapacidade.Text);
        
        switch (QuartoDB.Insert(q))
        {
            case 0:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);

                break;
            case -2:

                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);

                break;
        }
        txtInsertQuartoDescricao.Text = "";
        txtInsertQuartoTipo.Text = "";
        txtInsertQuartoCapacidade.Text = "";
    }
}