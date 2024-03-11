using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModeloDeDominio
{
   public class Marcas
    {
        public int Id { get; set; }

       
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

        
    }
}
