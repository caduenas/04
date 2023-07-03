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
    public partial class login_entrenador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string id = "";
            string correo = correoEntrenador.Text;
            string contras = password.Text;
            string confirmContras = confirmarPassword.Text;
            

            if (string.IsNullOrEmpty(correoEntrenador.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(confirmarPassword.Text) )
            {
                // Los campos de usuario,telefono, contraseña o confirmar contraseña están vacíos
                conn.Close();
                // Muestra un mensaje emergente en el cliente usando JavaScript
                string script = "alert('Por favor, ingresa un usuario, una contraseña y confirma la contraseña.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "CamposVacios", script, true);
            }
            else if (contras != confirmContras)
            {
                // La contraseña y la confirmación de contraseña no coinciden
                conn.Close();
                // Muestra un mensaje emergente en el cliente usando JavaScript
                string script = "alert('La contraseña y la confirmación de contraseña no coinciden. Por favor, verifica e intenta nuevamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ContrasenaNoCoincide", script, true);
            }
            else
            {
                string sql = "SELECT * FROM entrenadores WHERE correo_entrenador = @correo and contrasena_entrenador = @contras";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@correo", correoEntrenador.Text);
                cmd.Parameters.AddWithValue("@contras", password.Text);
                

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // El usuario y la contraseña son válidos
                    reader.Read();
                    id = reader["id_entrenador"].ToString();
                    reader.Close();
                    HttpCookie cookie = new HttpCookie("EntrenadorId", id);
                    cookie.Expires = DateTime.Now.AddMonths(1); // Establece la fecha de caducidad de la cookie
                    Response.Cookies.Add(cookie);
                    conn.Close();
                    Response.Redirect("Home_entrenador.aspx");
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