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
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Session.Add("listaArticulos", negocio.listar());

            if (Request.QueryString["Codigo"] != null)
                {
                    string codigo = (Request.QueryString["Codigo"].ToString());
                    List<Articulos> temporal2 = (List<Articulos>)Session["listaArticulos"]; //Como el objeto que quiero precargar esta en la sesion uso la lista temporal
                    Articulos seleccionado = temporal2.Find(x => x.Codigo == codigo); //busco en la lista temporal con la expresion lamda que busque dentro del listado por Id . Me devuelve el ojeto seleccionado

                    txtId.Text = seleccionado.Id.ToString();
                    TxtNombreArt.Text = seleccionado.Nombre;
                    TxtDescripcion.Text = seleccionado.Descripcion;
                    Txtprecio.Text = seleccionado.Precio.ToString(); 
                }






        }

        protected void BtnAgregarFav_Click(object sender, EventArgs e)
        {
            string idFav = ((Button)sender).CommandArgument;
            Response.Redirect("MisFavoritos.aspx?Id=" + idFav);
        }

        protected void BtnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}