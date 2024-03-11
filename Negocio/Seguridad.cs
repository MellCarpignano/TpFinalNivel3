using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;

namespace Negocio
{
    public static class Seguridad
    {

        public static bool sesionActiva (object user) // valida si yo tengo una sesion activa. Recibo un objet generico 
        {
            Usuario usuario = user != null ? (Usuario) user : null; //si es distinto de nulo lo transformo en user, sino lo dejo null

            if (usuario != null && usuario.Id != 0)
            {
                return true; // sesion activa
            }
            else
            {
                return false; //sesion inactiva
            }

        }

        public static bool esAdmin(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            return usuario != null ? usuario.Admin : false;
            
        }
    }
}
