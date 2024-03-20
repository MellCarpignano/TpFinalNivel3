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
    public partial class Home1 : System.Web.UI.Page
    {


        public List<Articulos> listArt = new List<Articulos>();
        protected void Page_Load(object sender, EventArgs e)
        {

        

            ArticulosNegocio negocio = new ArticulosNegocio();
            listArt = negocio.listar();

            if (!IsPostBack)
            {


                repetidordelhome.DataSource = listArt;
                repetidordelhome.DataBind();

            }

            
        }
     
        protected void BtnDetalle_Click1(object sender, EventArgs e)
        {

            string valorCodigo = ((Button)sender).CommandArgument;
            Response.Redirect("DetalleArticulo.aspx?Codigo=" + valorCodigo);

            
        }
    }
}