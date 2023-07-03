using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class edicion_tablas : System.Web.UI.Page
    {
        string userId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            HttpCookie cookie = Request.Cookies["Asesorado_seleccionado"];
            if (cookie != null)
            {
                userId = cookie.Value;
                // Utiliza el userId como necesites
            }
            else
            {
                // La cookie no existe, maneja el caso en consecuencia
            }
            TextBox1.Text = userId;
        }
    }
}