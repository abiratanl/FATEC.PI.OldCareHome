using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        

    }

    protected void btnEntrar_Click(object sender, EventArgs e) {
        DataSet ds = UsuarioDB.SelectLogin(txtEmail.Text, txtSenha.Text);
        if (ds.Tables[0].Rows.Count == 1){
            Session["nome"] = ds.Tables[0].Rows[0]["usu_nome"].ToString();
            Session["perfil"] = ds.Tables[0].Rows[0]["per_descricao"].ToString();
            Response.Redirect("~/adm/homeRestrita.aspx");
        }
        else{
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalErroLogin').modal('show'); </script>", false);
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e){
        // Msg: Retorna à home pública quando implementada;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalCancelarLogin').modal('show'); </script>", false);
    }

}
