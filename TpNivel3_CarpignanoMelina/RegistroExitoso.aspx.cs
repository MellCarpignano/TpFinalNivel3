using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinalNivel3_MelinaCarpignano
{
    public partial class RegistroExitoso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIrAPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisDatos.aspx");
        }

        protected void BtnVolerHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}