using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_insertPerfil : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e){

    }

    protected void btnCadastrar_Click(object sender, EventArgs e){

        Perfil p = new Perfil();
        p.Per_descricao = txtPerfil.Text;

        switch (PerfilDB.Insert(p)){
            case 0:
                ltlMensagem.Text = ">>>>> O K <<<<<<<";
                break;
            case -2:
                ltlMensagem.Text = ">>>>> ERRO <<<<<<<";
                break;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string tabela = "per_perfil", campo = "per_id", valor = "1";
        switch (Del.Delete(tabela, campo, valor))
        {
            case 0:
                ltlMensagem.Text = ">>>>> O K <<<<<<<";
                break;
            case -2:
                ltlMensagem.Text = ">>>>> ERRO <<<<<<<";
                break;
        }
    }
}