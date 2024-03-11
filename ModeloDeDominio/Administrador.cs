using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    class Administrador
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public tipoUsuario TipoUsuario { get; set; }
    }
}
