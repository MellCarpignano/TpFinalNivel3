using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloDeDominio;
using Negocio;


namespace TpFinalNivel3_MelinaCarpignano
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLoginUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                usuario.Email = txtUser.Text;
                usuario.Contraseña = txtPassUser.Text;
                if (negocio.Login(usuario))
                {
                    Session.Add("user", usuario);
                    Response.Redirect("MiPerfil.aspx");
                }
                else
                {
                    Session.Add("Error", "Usuario o contraseña incorrectas");
                    Response.Redirect("Error.aspx");
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error.aspx", ex);
            }
        }
    }
}