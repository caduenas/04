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
    public partial class registro_entrenador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void botonIngresarR_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();



            string nombres = nombreCompleto.Text;
            string apellidos = ApellidoCompleto.Text;
            string correo = correoElectro.Text;
            string contras = password.Text;
            string confirmContras = confirmarPassword.Text;
            string telefono = numCelular.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contras) || string.IsNullOrEmpty(confirmContras) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos))
            {
                // Los campos están vacíos
                conn.Close();
                string script = "alert('Por favor, completa todos los campos.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "CamposVacios", script, true);
            }
            else if (contras != confirmContras)
            {
                // La contraseña y la confirmación de contraseña no coinciden
                conn.Close();
                string script = "alert('La contraseña y la confirmación de contraseña no coinciden. Por favor, verifica e intenta nuevamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ContrasenaNoCoincide", script, true);
            }
            else
            {
                string sql = "INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES (@nombreC, @apellidoC, @contras, @correo, @telefono)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombreC", nombres);
                cmd.Parameters.AddWithValue("@apellidoC", apellidos);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contras", contras);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    conn.Close();
                    string script = "alert('Registro exitoso.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "RegistroExitoso", script, true);
                }
                else
                {
                    conn.Close();
                    string script = "alert('Error al registrar. Por favor, intenta nuevamente.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ErrorRegistro", script, true);
               
                }

            }
        }
    }
}