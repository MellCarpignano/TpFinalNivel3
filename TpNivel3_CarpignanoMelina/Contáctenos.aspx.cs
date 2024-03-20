using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloDeDominio;
using Negocio;

namespace TpFinalNivel3_MelinaCarpignano
{
    public partial class Contáctenos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnContactenos_Click(object sender, EventArgs e)
        {

        }

        protected void BtnEnviarmsj_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactoOk.aspx");
        }
    }
}