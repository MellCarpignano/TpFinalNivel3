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
    public partial class RegistoUsuarioF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrarmeUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                UsuarioNegocio negocio = new UsuarioNegocio();
                EmailServices emailservices = new EmailServices();

                user.Email = TxtEmail.Text;
                user.Contraseña = Txtpassword.Text;
                user.Nombre = TxtNombre.Text;
                user.Apellido = TxtApellido.Text;
                user.urlImagenPerfil = TxtUrlImagen.Text;
                

                int id = negocio.InsertarNuevo(user);

                emailservices.armarCorreo(user.Email, "Bienvenidx Usuario", "Te damos la bienvenida a la APP");
                emailservices.enviarEmail();
                Response.Redirect("RegistroExitoso.aspx");



            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
            }
        }

        protected void BtnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx"); 

        }
    }
}