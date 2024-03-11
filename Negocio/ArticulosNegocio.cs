using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticulosNegocio
    {

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server= .\\SQLEXPRESS; database= CATALOGO_WEB_DB; integrated security= true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID ";
           
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Precio = (decimal)lector["Precio"];

                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];


                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)lector["idCategoria"];
                    aux.Categoria.descripcion = (string)lector["Categoria"];


                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];








                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public object listar(string id)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Idmarca, Idcategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @Marca, @Categoria, @ImagenUrl, @Precio)");
        
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);

                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Marca", nuevo.Marca.Id);
                datos.SetearParametro("@Categoria", nuevo.Categoria.id);

                datos.SetearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.SetearParametro("@Precio", nuevo.Precio);
           
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

        public void AgregarconSP (Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedidmiento("storedAltaArticulos");
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@ImagenUrl", nuevo.ImagenUrl);

                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@Marca", nuevo.Marca.Id);
                datos.SetearParametro("@Categoria", nuevo.Categoria.id);
                datos.SetearParametro("@Codigo", nuevo.Codigo);
              
                
               

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
        public void Modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update articulos set Codigo= @Codigo, Nombre= @Nombre, Descripcion= @Descripcion, ImagenUrl = @ImagenUrl, precio= @Precio where Id = @Id; ");
                datos.SetearParametro("@Codigo", modificar.Codigo);
                datos.SetearParametro("@Nombre", modificar.Nombre);
                datos.SetearParametro("@Descripcion", modificar.Descripcion);
                datos.SetearParametro("@ImagenUrl", modificar.ImagenUrl);
                datos.SetearParametro("@Precio", modificar.Precio);
                datos.SetearParametro("@Id", modificar.Id);

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


        public void eliminarArticulo(int id)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Id = @id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public List<Articulos> filtrarporId(string id)
        {

            Articulos articulos = new Articulos();
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            if (id != "")
            {
                datos.SetearConsulta("select A.Id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID=" + id);
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];


                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["idCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];


                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);
                }


            }
            return lista;

        }

        //------------------------------------------------------------------------------------------//



        public List<Articulos> filtrarporCodigo(string cod)
        {


            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            if (cod != "")
            {
                datos.SetearConsulta("select A.id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID=" + cod);
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];


                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["idCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];


                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);
                }


            }
            return lista;

        }















        public List<Articulos> filtrar(string categoria, string seleccion, string filtro)
        {

            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string consulta = "select A.id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID";


                if (categoria == "Tipo")
                {
                    switch (seleccion)
                    {
                        case "Celulares":
                            consulta += "Nombre from like '" + filtro + "%' ";
                            break;
                        case "Termina con..":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }


                }



                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();



                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];


                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["idCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];


                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];








                    lista.Add(aux);
                }


                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }

         

















        //public List<Articulos> filtrar(string campo, string criterio, string filtro)
        //{

            //    List<Articulos> lista = new List<Articulos>();
            //    AccesoDatos datos = new AccesoDatos();
            //    try
            //    {

            //        string consulta = "select A.id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID and ";


            //        if(campo == "Nombre")
            //        {
            //            switch (criterio)
            //            {
            //                case "Empieza con ..":
            //                    consulta += "Nombre from like '" + filtro + "%' ";
            //                    break;
            //                case "Termina con..":
            //                        consulta += "Nombre like '%" + filtro + "'";
            //                    break;

            //                default:
            //                    consulta += "Nombre like '%" + filtro + "%' ";
            //                    break;
            //            }


            //        }

            //        else if( campo== "Precio")
            //        {
            //            switch (criterio)
            //            {
            //                case " Menor a $ 10.000":
            //                    consulta += "precio > " + filtro;
            //                   break;
            //                 case "Entre $10.000 y $40.000":
            //                    consulta += "precio  > " + filtro;
            //                    break;
            //                case "Mas de $40.000":
            //                    consulta += "precio >" + filtro;
            //                    break;

            //                default:
            //                    break;
            //            }
            //        }


            //        datos.SetearConsulta(consulta);
            //        datos.EjecutarLectura();



            //        while (datos.Lector.Read())
            //        {
            //            Articulos aux = new Articulos();

            //            aux.Id = (int)datos.Lector["Id"];
            //            aux.Codigo = (string)datos.Lector["Codigo"];
            //            aux.Nombre = (string)datos.Lector["Nombre"];
            //            aux.Descripcion = (string)datos.Lector["Descripcion"];
            //            if (!(datos.Lector["ImagenUrl"] is DBNull))
            //                aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

            //            aux.Precio = (decimal)datos.Lector["Precio"];
            //            aux.IdMarca = (int)datos.Lector["IdMarca"];
            //            aux.IdCategoria = (int)datos.Lector["IdCategoria"];


            //            aux.Categoria = new Categorias();
            //            aux.Categoria.id = (int)datos.Lector["idCategoria"];
            //            aux.Categoria.descripcion = (string)datos.Lector["Categoria"];


            //            aux.Marca = new Marcas();
            //            aux.Marca.Id = (int)datos.Lector["IdMarca"];
            //            aux.Marca.Descripcion = (string)datos.Lector["Marca"];








            //            lista.Add(aux);
            //        }


            //        return lista;
            //    }



            //    catch (Exception ex)
            //    {

            //        throw ex;
            //    }
            //}
        }
    } 
}

