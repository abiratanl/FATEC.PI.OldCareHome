﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Adm_Tables_Patologia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = "Cadastro de Funcionários";
        CarregarTable();
    }
    protected void CarregarTable()
    {
        DataSet ds = FuncionarioDB.SelectAll();
        rptTableBody.DataSource = ds;
        rptTableBody.DataBind();
    }
}