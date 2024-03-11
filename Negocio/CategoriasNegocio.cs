using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;

namespace Negocio
{
   public class CategoriasNegocio
    {


        public List<Categorias> listarC()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }




            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

    }
}
