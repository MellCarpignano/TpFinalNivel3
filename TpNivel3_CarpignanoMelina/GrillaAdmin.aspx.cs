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
    public partial class GrillaAdmin : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
          //  FiltroAvanzado = cheqboxFiltroAvanzado.Checked;


            if(Session["listaArticulos"] == null)
            {
                ArticulosNegocio negocios = new ArticulosNegocio();
                Session.Add("listaArticulos", negocios.listar());

            }

            GridAdmin.DataSource = Session["listaArticulos"];
            GridAdmin.DataBind();


            
            List<Articulos> lista = new List<Articulos>();
            ArticulosNegocio negocio = new ArticulosNegocio();
            // Session.Add("listaArticulos", negocio.listar());
            //GridAdmin.DataSource = Session["listaArticulos"];
             GridAdmin.DataSource = negocio.listar();
            GridAdmin.DataBind();
        }

       

        protected void BtnAgregarArt_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarArt.aspx");
        }

        protected void GridAdmin_SelectedIndexChanged1(object sender, EventArgs e)
        {

            var algo = GridAdmin.SelectedRow.Cells[0].Text;
            var id = GridAdmin.SelectedDataKey.Value.ToString();
            Response.Redirect("ABMadministrador.aspx?Id=" + id);

        }

        protected void filtro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> lista = (List<Articulos>)Session["listaArticulos"];
            List<Articulos> listafiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(filtro.Text.ToUpper())); //el to upper me permite escribir en mayus/minus y funciona igual
            GridAdmin.DataSource = listafiltrada;
            GridAdmin.DataBind();
        }

        protected void cheqboxFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = cheqboxFiltroAvanzado.Checked;
             txtFiltroA.Enabled = !FiltroAvanzado;
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          ddlSeleccion.Items.Clear(); //para que no se acumulen las precargas 

            if(ddlCategoria.SelectedItem.ToString() == "Tipo")
            {
               ddlSeleccion.Items.Add("Celulares");
                ddlSeleccion.Items.Add("Tv y audio");

                ddlSeleccion.Items.Add("Juego");

            }
            if(ddlCategoria.SelectedItem.ToString() == "Marca")
            {
                
               ddlSeleccion.Items.Add("Samsung");

                ddlSeleccion.Items.Add("Motorola");

                ddlSeleccion.Items.Add("Apple");

                ddlSeleccion.Items.Add("Sony");
            }

            if (ddlCategoria.SelectedItem.ToString() == "Precio")
            {

                ddlSeleccion.Items.Add("Menores a $10.000");

                ddlSeleccion.Items.Add("Entre $10.000 y $35.000");

                ddlSeleccion.Items.Add("Mayores a $40.000");

            }
        }

        protected void ddlSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscarFA_Click(object sender, EventArgs e)
        {
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                GridAdmin.DataSource = negocio.filtrar(ddlCategoria.SelectedItem.ToString(),ddlSeleccion.SelectedItem.ToString(), txtFiltroA.Text);
                GridAdmin.DataBind();

            }
            catch (Exception ex)
            {

               Session.Add("Error.aspx", ex);
            }
        }
    }
}