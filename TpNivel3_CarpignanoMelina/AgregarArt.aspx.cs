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
    public partial class AgregarArt : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TxtIdArt.Enabled = false; //visible, pero deshabilitada.

                //Configuracion inicial de la pantalla
                if (!IsPostBack)
                {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    List<Articulos> lista = negocio.listar(); //Me traigo la base de datos y la guardo en el obj lista

                    DropDownCategoria.DataSource = lista;
                    DropDownCategoria.DataValueField = "Id";
                    DropDownCategoria.DataTextField = "Categoria";
                    DropDownCategoria.DataBind();

                    DropDownMarcas.DataSource = lista;
                    DropDownMarcas.DataValueField = "Id";
                    DropDownMarcas.DataTextField = "Marca";
                    DropDownMarcas.DataBind();
                    

                }

                
            }
            catch (Exception ex)
            {

                Session.Add("Error.aspx", ex);
            }
            
        }

        protected void TxtUpdatePanel_TextChanged(object sender, EventArgs e)
        {
            ImgaAregarup.ImageUrl = TxtUpdatePanel.Text;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulos nuevo = new Articulos();

                ArticulosNegocio negocio = new ArticulosNegocio();

               
                nuevo.Descripcion = TxtDescripArt.Text;
                nuevo.Codigo = TxtCodigoArt.Text;
                nuevo.Nombre = TxtNombreArt.Text;
                nuevo.Precio = int.Parse(TxtPrecio.Text);
                nuevo.ImagenUrl = TxtUpdatePanel.Text;

                nuevo.Marca = new Marcas();
                nuevo.Marca.Id = int.Parse(DropDownMarcas.SelectedValue);

                nuevo.Categoria = new Categorias();
                nuevo.Categoria.id = int.Parse(DropDownCategoria.SelectedValue);
                

                negocio.Agregar(nuevo);
                Response.Redirect("GrillaAdmin.aspx");
                
            }
            catch (Exception ex)
            {

                Session.Add("Error.aspx", ex);
            }
        }
    }
}