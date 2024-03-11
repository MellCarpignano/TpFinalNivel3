using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using Negocio;


namespace Negocio
{
    
      public class UsuarioNegocio
    {
        //ID, EMAIL, PASS, ADMIN

        //NO TENEMOS: NOMBRE APELLIDO FECHA IMAGEN



        public int InsertarNuevo(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try 
            {
                datos.setearProcedidmiento("insertarNuevo");
                datos.SetearParametro("@email", nuevo.Email);
                datos.SetearParametro("@pass", nuevo.Contraseña);
                datos.SetearParametro("@nombre", nuevo.Nombre);
                datos.SetearParametro("@apellido", nuevo.Apellido);
                datos.SetearParametro("@urlImagenPerfil",  nuevo.urlImagenPerfil);
               
                
                return datos.EjectuarAccionScalar();

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

        public void actualizar(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
               
                datos.SetearConsulta("update USERS set urlImagenPerfil = @imagen WHERE Id= @Id");
                datos.SetearParametro("@imagen", user.urlImagenPerfil);
                datos.SetearParametro("@Id", user.Id);
                datos.EjecutarAccion();

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

        public bool Login(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select  id, email, pass, admin from USERS where email = @email and pass = @pass");
                datos.SetearParametro("email", usuario.Email);
                datos.SetearParametro("pass", usuario.Contraseña);
                datos.EjecutarLectura();
                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["id"];
                    usuario.Admin = (bool)datos.Lector["admin"];
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }

}
