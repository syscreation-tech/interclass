using Regra_de_Negocios.Services;
using System;

namespace Gabriel_TCM
{
    public partial class Ac : System.Web.UI.Page
    {
        #region Propriedades
        LoginService loginService = new LoginService(); 
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            txtSenha.Focus();
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            logar();
        }
        public void logar()
        {
            if(string.IsNullOrEmpty(txtLogin.Text)|| string.IsNullOrEmpty(txtSenha.Text))
            {
                this.ExibirAlerta(Mensagem.TipoMensagem.Alerta, "Usuario ou Senha nao informado.");
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtLogin.Focus();
                return;
            }
            else
            {
                if (loginService.validarUsuairo(txtLogin.Text, txtSenha.Text))
                {
                    if ((txtLogin.Text == "admin") && (txtSenha.Text == "admin"))
                    {
                        Response.Redirect("~/Admin");
                    }else
                    Response.Redirect("~/Usuario/Index");
                }

                {
                    this.ExibirAlerta(Mensagem.TipoMensagem.Alerta,"Usuário não exite ou esta inativo");
                    return;
                }
            }
        }
    }
}
