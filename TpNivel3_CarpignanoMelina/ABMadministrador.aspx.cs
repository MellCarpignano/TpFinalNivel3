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
    public partial class ABMadministrador : System.Web.UI.Page
    {
        public bool confirmaElimin { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Seguridad.esAdmin(Session["usuario"]))
            {
                Session.Add("error", "se requiere permiso de administrador");
                Response.Redirect("Error.aspx");
            }


            //Configuracion inicial de la pantalla
            if (!IsPostBack)
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                List<Articulos> lista = negocio.listar(); //Me traigo la base de datos y la guardo en el obj lista

                DddlCategoria.DataSource = lista;
                DddlCategoria.DataValueField = "Id";
                DddlCategoria.DataTextField = "Categoria";
                DddlCategoria.DataBind();

                DdlMarca.DataSource = lista;
                DdlMarca.DataValueField = "Id";
                DdlMarca.DataTextField = "Marca";
                DdlMarca.DataBind();


            }

          

                if (Request.QueryString["Id"] != null)
                {
                    var id = int.Parse(Request.QueryString["Id"].ToString());
                    List<Articulos> temporal = (List<Articulos>)Session["listaArticulos"]; //Como el objeto que quiero precargar esta en la sesion uso la lista temporal

                    Articulos seleccionado = temporal.Find(x => x.Id == id); //busco en la temporal con la expresion lamda que busque dentro del listado por Id . Me devuelve el ojeto seleccionado
                     
                   
                 
                    TxtIdArt.Text = seleccionado.Id.ToString();
                    TxtCodigoArt.Text = seleccionado.Codigo.ToString();
                    TxtNombreArt.Text = seleccionado.Nombre;
                    TxtDescripArt.Text = seleccionado.Descripcion;
                    TxtMarca.Text = seleccionado.Marca.ToString();
                    TxtPrecio.Text = seleccionado.Precio.ToString();
                    imgArt.ImageUrl = seleccionado.ImagenUrl;

                DdlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                DddlCategoria.SelectedValue = seleccionado.Categoria.id.ToString();


                }


                
            

        }


        protected void BtnModificar_Click(object sender, EventArgs e)
        {

    


            Response.Redirect("ModificarArt.aspx");
        
            
         
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            confirmaElimin = true;
        }

        protected void BtnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChqboxEliminacion.Checked)
                {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    negocio.eliminarArticulo(int.Parse(TxtIdArt.Text));
                    Response.Redirect("GrillaAdmin.aspx");
                }
                

            }
            catch (Exception ex)
            {

                Session.Add("Error.aspx", ex);
            }
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("GrillaAdmin.aspx");
        }
    }
}