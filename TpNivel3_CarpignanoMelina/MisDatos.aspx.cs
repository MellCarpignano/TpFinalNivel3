using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ModeloDeDominio;

namespace TpFinalNivel3_MelinaCarpignano
{
    public partial class MisDatos : System.Web.UI.Page
    {
        public string ImagenAvatar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void btnguardarfoto_Click(object sender, EventArgs e)
        {
            try
            {
              
                UsuarioNegocio negocio = new UsuarioNegocio();
                //Escribir img
                string ruta = Server.MapPath("./ImagenPerfil/");    //desde donde estoy, le pido que me devuelva la ruta fisica
                Usuario user = (Usuario)Session["user"];    //traigo el id asi guardo una imagen x persona que se loguee
                txtImagen.PostedFile.SaveAs(ruta + "perfil-" + user.Id + ".jpg");

                user.urlImagenPerfil = "perfil-" + user.Id + ".jpg";
                user.Nombre = TxtNombreDatos.Text;
                user.Apellido = TxtApellidoDatos.Text;
                user.Email = TxtEmaildatos.Text;

                negocio.actualizar(user);


                //lectura de img

                Image img = (Image)Master.FindControl("ImagenAvatar");
                if(!string.IsNullOrEmpty(user.urlImagenPerfil))
                {
                    img.ImageUrl = "~/ImagenPerfil/" + user.urlImagenPerfil;
                }
               
                
               

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}