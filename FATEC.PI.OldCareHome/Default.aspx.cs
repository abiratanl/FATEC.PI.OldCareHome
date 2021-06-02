using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void btnEntrar_Click(object sender, EventArgs e) {
        Usuario usuario = new Usuario();
        DataSet ds = new DataSet();
        ds = UsuarioDB.SelectEmail(txtEmail.Text);        
        if(ds.Tables[0].Rows.Count == 0){
            //Msg: Email ou senha não confere (modal)
        }
        else{
            if (!true) //Se txtEmail.Text != usuario.usu_email
            {
                //Msg: Email ou senha não confere (modal)
            }
            else
            {
                //Preencher as propriedades do usuário com os dados do Dataset
                //Iniciar Sessão
                //Msg: Bem-vindo ao OldCareHome (modal)
                //Ir para homeRestrita
            }

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e){
       // Msg: Retorna à home pública quando implementada;
    }    
}