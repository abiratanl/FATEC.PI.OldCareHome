﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

    protected void btnUsuarios_Click(object sender, EventArgs e) {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "modalBootstrap", "$(function(){$('#modalExemplo2').modal('show');})", true);
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> $('#modalExemplo2').modal('show'); </script>", false);
    }
}
