using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{

     public enum tipoUsuario
    {
        NORMAL = 0,
        ADMIN = 1
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }

        public string User { get; set; }
        public string Contraseña { get; set; }

        public tipoUsuario TipoUser { get; set; }
        public string urlImagenPerfil { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public bool Admin { get; set; }

    }
}
