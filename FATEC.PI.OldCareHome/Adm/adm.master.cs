using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adm_adm : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSair_Click(object sender, EventArgs e){
        Session.Remove("nome");
        Session.Remove("perfil");
        Response.Redirect("~/Default.aspx");
    }

    

    protected void btnMenuPatologia_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/insertPatologia.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalPatologia').modal('show'); </script>", false);
    }

    protected void btnMenuQuarto_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/insertQuarto.aspx");
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertQuarto').modal('show'); </script>", false);
    }

    protected void btnInsertUsuario_Click(object sender, EventArgs e){
        Response.Redirect("~/adm/insertUsuario.aspx");
        // Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalInsertUsuario').modal('show'); </script>", false);        
    }
}
