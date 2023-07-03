using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static GymMasterProyectoFinalF.pages.asignacion_tablas;

namespace GymMasterProyectoFinalF.pages
{
    public partial class login_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string id = "";
            string correo = correousu.Text;
            string contras = password.Text;

            if (string.IsNullOrEmpty(correousu.Text) || string.IsNullOrEmpty(password.Text))
            {
                // Los campos de usuario y/o contraseña están vacíos
                conn.Close();
                // Muestra un mensaje emergente en el cliente usando JavaScript
                string script = "alert('Por favor, ingresa un usuario y una contraseña.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "CamposVacios", script, true);
            }
            else
            {
                string sql = "SELECT * FROM asesorados WHERE correo_asesorado = @correo and contrasena_asesorado = @contras";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@correo", correousu.Text);
                cmd.Parameters.AddWithValue("@contras", password.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // El usuario y la contraseña son válidos
                    reader.Read();
                    id = reader["id_asesorados"].ToString();
                    reader.Close();
                    HttpCookie cookie = new HttpCookie("UserId", id);
                    cookie.Expires = DateTime.Now.AddMonths(1); // Establece la fecha de caducidad de la cookie
                    Response.Cookies.Add(cookie);
                    conn.Close();
                    Response.Redirect("Home_usuarios.aspx");
                }
                else
                {
                    // El usuario y/o la contraseña son incorrectos
                    reader.Close();
                    conn.Close();
                    // Muestra un mensaje emergente en el cliente usando JavaScript
                    string script = "alert('Contraseña incorrecta. Por favor, intenta nuevamente.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ContraseñaIncorrecta", script, true);
                }
            }
        }
    }
}