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
    public partial class InsertarEntrenadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonIngresarR_Click(object sender, EventArgs e)
        {
           
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                conn.Open();

                string sql = @"INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) 
                VALUES (@nombre, @apellido, @contrasena, @correo, @numero)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombre", nombreCompleto.Text);
                cmd.Parameters.AddWithValue("@apellido", ApellidoCompleto.Text);
                cmd.Parameters.AddWithValue("@contrasena", password.Text);
                cmd.Parameters.AddWithValue("@correo",  correoElectro.Text);
                cmd.Parameters.AddWithValue("@numero", numCelular.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    resultadoLabel.Text = "El entrenador se ha insertado correctamente.";
                }
                else
                {
                    resultadoLabel.Text = "Hubo un error al insertar el entrenador.";
                }
            

        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_administrador.aspx");
        }
    }
}