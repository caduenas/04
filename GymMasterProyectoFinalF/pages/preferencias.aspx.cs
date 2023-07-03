using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class preferencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = "";
            HttpCookie cookie = Request.Cookies["UserId"];
            if (cookie != null)
            {
                userId = cookie.Value;
                // Utiliza el userId como necesites
            }
            else
            {
                // La cookie no existe, maneja el caso en consecuencia
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(contrasena.Text == re_contrasena.Text)
            {
                string userId = "";
                HttpCookie cookie = Request.Cookies["UserId"];
                if (cookie != null)
                {
                    userId = cookie.Value;
                    // Utiliza el userId como necesites
                }
                else
                {
                    // La cookie no existe, maneja el caso en consecuencia
                }
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                conn.Open();
                string contras = contrasena.Text;
                string sql = @"update asesorados set contrasena_asesorado ='" + contrasena.Text + "'where id_asesorados='" + userId + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@contras", contrasena.Text);
                bool proc = Convert.ToBoolean(cmd.ExecuteNonQuery());
                Response.Redirect("asignacion_tablas.aspx");
                conn.Close();
            }
            else
            {
                // Las contraseñas no coinciden
                string script = "alert('Las contraseñas no coinciden. Por favor, inténtalo nuevamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ContrasenasNoCoinciden", script, true);
            }
        }
    }
}