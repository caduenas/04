using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class OpcionesConsultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Busqueda_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                conn.Open();
                string nombre = NombreUsuario.Text;
                string correoEle = correoE.Text;
                string sql = @"SELECT * FROM entrenadores WHERE nombre_entrenador = @nombre AND correo_entrenador = @correo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correoEle);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Creamos una tabla HTML para mostrar los resultados
                    StringBuilder htmlBuilder = new StringBuilder();
                    htmlBuilder.Append("<table>");
                    htmlBuilder.Append("<tr><th>ID</th><th>Nombre</th><th>Apellido</th><th>Correo</th><th>Celular</th></tr>");

                    while (reader.Read())
                    {
                        int idUsuario = (int)reader["id_entrenador"];
                        string nombrease = reader["nombre_entrenador"].ToString();
                        string apellido = reader["apellido_entrenador"].ToString();
                        string correo = reader["correo_entrenador"].ToString();
                        string numero = reader["numero_entrenador"].ToString();


                        htmlBuilder.Append("<tr>");
                        htmlBuilder.Append("<td>" + idUsuario + "</td>");
                        htmlBuilder.Append("<td>" + nombrease + "</td>");
                        htmlBuilder.Append("<td>" + apellido + "</td>");
                        htmlBuilder.Append("<td>" + correo + "</td>");
                        htmlBuilder.Append("<td>" + numero + "</td>");
                        htmlBuilder.Append("</tr>");
                    }

                    htmlBuilder.Append("</table>");

                    // Mostramos la tabla en la página web
                    Resultado.InnerHtml = htmlBuilder.ToString();
                }
                else
                {
                    Resultado.InnerHtml = "No se encontraron resultados.";
                }

                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_administrador.aspx");
        }
    }
}