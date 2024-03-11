using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }


        public AccesoDatos()
        {
            conexion = new SqlConnection("server= .\\SQLEXPRESS; database= CATALOGO_WEB_DB; integrated security= true;");
            comando = new SqlCommand();

        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }


        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }


        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int EjectuarAccionScalar()
        {
            comando.Connection= conexion;

            try
            {
               conexion.Open();
               return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void setearProcedidmiento(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
                
                
       }

        public void SetearParametro(string nombre, object value)
        {
            comando.Parameters.AddWithValue(nombre, value);
        }

        public void CerrarConexion() 
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }



    }

}
