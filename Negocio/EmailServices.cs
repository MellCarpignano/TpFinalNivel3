using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Negocio
{
    public class EmailServices
    {
       private MailMessage email { get; set; }
        private SmtpClient server { get; set; }


        public EmailServices()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("70ccb250f519d1", "fd6c117def7a20");
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "sandbox.smtp.mailtrap.io";

        }

        public void armarCorreo( string emailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@novatech.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = "Se ha completado su alta de usuario satisfactoriamente. Gracias por elegirnos";
        }

        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
