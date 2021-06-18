using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_InsertPatologia : System.Web.UI.Page
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

    protected void btnInsertPatologiaCadastrar_Click(object sender, EventArgs e){
        if (PatologiaDB.VerificaPatologia(txtInsertPatologiaDescricao.Text))
        {
            // Email já cadastrado
            ltlMensagem.Text = "<strong> Erro ao inserir. Patologia já cadastrada.</strong>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
            txtInsertPatologiaDescricao.Focus();
            return;

        }
        Patologia p = new Patologia();
        p.Pat_descricao = txtInsertPatologiaDescricao.Text;
        p.Pat_cid = txtInsertPatologiaCid.Text;
        p.Pat_restricao = txtInsertPatologiaRestricao.Text;
        // u.Per_id = ddlPerfil.SelectedValue;
        switch (PatologiaDB.Insert(p)){
            case 0:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCadastroOk').modal('show'); </script>", false);
                break;
            case -2:
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroBanco').modal('show'); </script>", false);
                break;
        }
        txtInsertPatologiaDescricao.Text = "";
        txtInsertPatologiaCid.Text = "";
        txtInsertPatologiaRestricao.Text = "";
    }

    protected void btnInsertPatologiaVoltar_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/HomeRestrita.aspx");
    }
}